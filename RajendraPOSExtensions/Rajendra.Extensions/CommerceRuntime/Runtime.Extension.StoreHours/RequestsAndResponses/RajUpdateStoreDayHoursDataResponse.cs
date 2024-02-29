namespace Runtime.Extension.StoreHours.RequestsAndResponses
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Runtime.Extension.StoreHours.Entities;

    /// <summary>
    /// Defines a simple response class that holds a list of StoreHour instances.
    /// </summary>
    [DataContract]
    public sealed class RajUpdateStoreDayHoursDataResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RajUpdateStoreDayHoursDataResponse"/> class.
        /// </summary>
        /// <param name="storeDayHours">The store day hours.</param>
        public RajUpdateStoreDayHoursDataResponse(RajStoreDayHoursEntity storeDayHours)
        {
            this.StoreDayHours = storeDayHours;
        }

        /// <summary>
        /// Gets the store day hours.
        /// </summary>
        [DataMember]
        public RajStoreDayHoursEntity StoreDayHours { get; private set; }
    }
}