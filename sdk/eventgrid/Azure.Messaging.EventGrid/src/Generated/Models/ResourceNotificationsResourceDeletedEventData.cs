// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Describes the schema of the common properties across all ARN system topic delete events. </summary>
    public partial class ResourceNotificationsResourceDeletedEventData
    {
        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceDeletedEventData"/>. </summary>
        internal ResourceNotificationsResourceDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceDeletedEventData"/>. </summary>
        /// <param name="resourceDetails"> resourceInfo details for delete event. </param>
        /// <param name="operationalDetails"> details about operational info. </param>
        internal ResourceNotificationsResourceDeletedEventData(ResourceNotificationsResourceDeletedDetails resourceDetails, ResourceNotificationsOperationalDetails operationalDetails)
        {
            ResourceDetails = resourceDetails;
            OperationalDetails = operationalDetails;
        }

        /// <summary> resourceInfo details for delete event. </summary>
        public ResourceNotificationsResourceDeletedDetails ResourceDetails { get; }
        /// <summary> details about operational info. </summary>
        public ResourceNotificationsOperationalDetails OperationalDetails { get; }
    }
}
