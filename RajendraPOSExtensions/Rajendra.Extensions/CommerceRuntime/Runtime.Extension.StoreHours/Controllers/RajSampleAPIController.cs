using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime.Extension.StoreHours.Controllers
{
    public class RajSampleAPIController : IController
    {
        /// <summary>
        /// A simple GET endpoint to demonstrate GET endpoints on an unbound controller.
        /// </summary>
        /// <returns>A simple true value to indicate the endpoint was reached.</returns>
        [HttpGet]
        [Authorization(CommerceRoles.Anonymous, CommerceRoles.Application, CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee, CommerceRoles.Storefront)]
        public Task<bool> RajSampleGet()
        {
            return Task.FromResult(true);
        }

        /// <summary>
        /// A simple POST endpoint to demonstrate POST endpoints on an unbound controller.
        /// </summary>
        /// <returns>A simple true value to indicate the endpoint was reached.</returns>
        [HttpPost]
        [Authorization(CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee)]
        public Task<bool> RajSamplePost()
        {
            return Task.FromResult(true);
        }
    }
}
