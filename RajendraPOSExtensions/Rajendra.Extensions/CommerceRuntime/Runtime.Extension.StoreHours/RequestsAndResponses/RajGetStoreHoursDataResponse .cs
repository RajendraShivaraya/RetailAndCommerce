using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime;
using System.Runtime.Serialization;
using Runtime.Extension.StoreHours.Entities;


namespace Runtime.Extension.StoreHours.RequestsAndResponses
{
    [DataContract]
    public sealed class RajGetStoreHoursDataResponse : Response
    {
        public RajGetStoreHoursDataResponse(PagedResult<RajStoreDayHoursEntity> dayHours)
        {
            DayHours = dayHours;
        }

        [DataMember]
        public PagedResult<RajStoreDayHoursEntity> DayHours { get; private set; }
    }
}
