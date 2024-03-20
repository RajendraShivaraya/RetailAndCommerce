using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
using System.Xml;
using Runtime.Extension.StoreHours.RequestsAndResponses;
using Runtime.Extension.StoreHours.Entities;
using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using Microsoft.Dynamics.Commerce.Runtime;
using RajStoreHours = Runtime.Extension.StoreHours;
using System.Threading.Tasks;

namespace RajendraRetailServerExtensions.ODataControllers
{
    [RoutePrefix("RajendraEntityAPI")]
    [BindEntity(typeof(RajStoreHours.Entities.RajStoreDayHoursEntity))]
    public class RajGetStoreHoursController : IController
    {
        /// <summary>
        /// Gets the controller name.
        /// </summary>
        public string ControllerName
        {
            get { return "Rajendra Get Store Hours"; }
        }

        [HttpPost]
        [Authorization(CommerceRoles.Anonymous, CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee, CommerceRoles.Application)]
        public async Task<PagedResult<RajStoreDayHoursEntity>> GetStoreHoursByRecId(IEndpointContext context, string storeNumber, QueryResultSettings queryResultSettings)
        {
            RajGetStoreHoursDataRequest request = new RajGetStoreHoursDataRequest(storeNumber);
            RajGetStoreHoursDataResponse response = await context.ExecuteAsync<RajGetStoreHoursDataResponse>(request).ConfigureAwait(false);
            return response.DayHours;
        }

        [HttpGet]
        [Authorization(CommerceRoles.Anonymous, CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee, CommerceRoles.Application)]
        public Task<string> GetMyName()
        {
            return Task.FromResult("Rajendra Sample Get APIs");
        }

        [HttpGet]
        [Authorization(CommerceRoles.Anonymous, CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee, CommerceRoles.Application)]
        public Task<bool> GetSampleForBoolean()
        {
            return Task.FromResult(true);
        }
    }
}
