namespace Runtime.Extension.StoreHours.RequestsAndResponses
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;
    using Runtime.Extension.StoreHours.Entities;

    /// <summary>
    /// A simple request class to get a list of store hours for a store.
    /// </summary>
    [DataContract]
    public sealed class RajUpdateStoreDayHoursDataRequest : Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RajUpdateStoreDayHoursDataRequest"/> class.
        /// </summary>
        /// <param name="storeDayHours">The store day and hours.</param>
        public RajUpdateStoreDayHoursDataRequest(RajStoreDayHoursEntity storeDayHours)
        {
            this.StoreDayHours = storeDayHours;
        }

        /// <summary>
        /// Gets the store day and hours related to the request.
        /// </summary>
        [DataMember]
        public RajStoreDayHoursEntity StoreDayHours { get; private set; }
    }
}