using Microsoft.Dynamics.Commerce.Runtime;
using Microsoft.Dynamics.Commerce.Runtime.Data;
using Microsoft.Dynamics.Commerce.Runtime.DataAccess.SqlServer;
using Microsoft.Dynamics.Commerce.Runtime.DataServices.Messages;
using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime.RealtimeServices.Messages;
using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using System.Collections.ObjectModel;
using System.Globalization;
using Runtime.Extension.StoreHours.RequestsAndResponses;
using Runtime.Extension.StoreHours.Entities;


namespace Runtime.Extension.StoreHours.Services
{
    // In regular data service class, we implement the actual business logic to perform the opearations. Controller classes would call the service objects and get the response.
    // Since we are extending D365 CRT, we would need to adhere to architecture of D365. Hence we extend the data service classes from IRequestHandlerAsync.

    public class StoreHoursDataService : IRequestHandlerAsync
    {
        // This method is implemented to mention what are the supported request this data service class supports.
        public IEnumerable<Type> SupportedRequestTypes
        {
            get
            {
                return new[]
                {
                    typeof(RajGetStoreHoursDataRequest),
                    typeof(RajUpdateStoreDayHoursDataRequest),
              };
            }
        }

        public async Task<Response> Execute(Request request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            Type reqType = request.GetType();
            if (reqType == typeof(RajGetStoreHoursDataRequest))
            {
                return await this.GetStoreDayHoursAsync((RajGetStoreHoursDataRequest)request).ConfigureAwait(false);
            }
            else if (reqType == typeof(RajUpdateStoreDayHoursDataRequest))
            {
                return await this.UpdateStoreDayHoursAsync((RajUpdateStoreDayHoursDataRequest)request).ConfigureAwait(false);
            }
            else
            {
                string message = string.Format(CultureInfo.InvariantCulture, "Request '{0}' is not supported.", reqType);
                Console.WriteLine(message);
                throw new NotSupportedException(message);
            }
        }

        private async Task<Response> GetStoreDayHoursAsync(RajGetStoreHoursDataRequest request)
        {
            ThrowIf.Null(request, "request");

            using (DatabaseContext databaseContext = new SqlServerDatabaseContext(request.RequestContext))
            {
                var query = new SqlPagedQuery(request.QueryResultSettings)
                {
                    DatabaseSchema = "ext",
                    Select = new ColumnSet("DAY", "OPENTIME", "CLOSINGTIME", "RECID"),
                    From = "CONTOSORETAILSTOREHOURSVIEW",
                    Where = "STORENUMBER = @storeNumber",
                };

                query.Parameters["@storeNumber"] = request.StoreNumber;
                return new RajGetStoreHoursDataResponse(await databaseContext.ReadEntityAsync<RajStoreDayHoursEntity>(query).ConfigureAwait(false));
            }
        }

        private async Task<Response> UpdateStoreDayHoursAsync(RajUpdateStoreDayHoursDataRequest request)
        {
            ThrowIf.Null(request, "request");
            ThrowIf.Null(request.StoreDayHours, "request.StoreDayHours");
            if (request.StoreDayHours.DayOfWeek < 1 || request.StoreDayHours.DayOfWeek > 7)
            {
                throw new DataValidationException(DataValidationErrors.Microsoft_Dynamics_Commerce_Runtime_ValueOutOfRange);
            }

            InvokeExtensionMethodRealtimeRequest extensionRequest = new InvokeExtensionMethodRealtimeRequest(
                "ContosoRetailStoreHours_UpdateStoreHours",
                request.StoreDayHours.Id,
                request.StoreDayHours.DayOfWeek,
                request.StoreDayHours.OpenTime,
                request.StoreDayHours.CloseTime);
            InvokeExtensionMethodRealtimeResponse response = await request.RequestContext.ExecuteAsync<InvokeExtensionMethodRealtimeResponse>(extensionRequest).ConfigureAwait(false);
            ReadOnlyCollection<object> results = response.Result;

            long recId = Convert.ToInt64(results[0]);

            using (var databaseContext = new SqlServerDatabaseContext(request.RequestContext))
            {
                ParameterSet parameters = new ParameterSet();
                parameters["@bi_Id"] = recId;
                parameters["@i_Day"] = request.StoreDayHours.DayOfWeek;
                parameters["@i_OpenTime"] = request.StoreDayHours.OpenTime;
                parameters["@i_ClosingTime"] = request.StoreDayHours.CloseTime;
                await databaseContext.ExecuteStoredProcedureNonQueryAsync("[ext].UPDATESTOREDAYHOURS", parameters, resultSettings: null).ConfigureAwait(false);
            }

            return new RajUpdateStoreDayHoursDataResponse(request.StoreDayHours);
        }
    }
}
