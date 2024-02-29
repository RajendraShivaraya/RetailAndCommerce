using System.Runtime.Serialization;
using Microsoft.Dynamics.Commerce.Runtime.Messages;

namespace Runtime.Extension.StoreHours.RequestsAndResponses
{
    public sealed class RajGetStoreHoursDataRequest : Request
    {
        public RajGetStoreHoursDataRequest(string storeNumber)
        {
            StoreNumber = storeNumber;
        }

        [DataMember]
        public string StoreNumber { get; private set; }
    }
}
