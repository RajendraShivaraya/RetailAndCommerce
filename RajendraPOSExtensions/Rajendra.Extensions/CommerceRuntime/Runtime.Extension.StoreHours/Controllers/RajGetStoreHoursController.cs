using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
using System.Xml;
using Runtime.Extension.StoreHours.RequestsAndResponses;
using Runtime.Extension.StoreHours.Entities;
using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using Microsoft.Dynamics.Commerce.Runtime;

namespace Runtime.Extension.StoreHours.Controllers
{
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
        protected async Task<PagedResult<RajStoreDayHoursEntity>> GetStoreHoursByRecId(IEndpointContext context, string storeNumber)
        {
            RajGetStoreHoursDataRequest request = new RajGetStoreHoursDataRequest(storeNumber);
            RajGetStoreHoursDataResponse response = await context.ExecuteAsync<RajGetStoreHoursDataResponse>(request).ConfigureAwait(false);
            return response.DayHours;
        }

    }
}
