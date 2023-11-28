// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Indicates whether a proposed resource name is available. </summary>
    public partial class NameAvailabilityResponse
    {
        /// <summary> Initializes a new instance of <see cref="NameAvailabilityResponse"/>. </summary>
        internal NameAvailabilityResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NameAvailabilityResponse"/>. </summary>
        /// <param name="nameAvailable"> If true, the name is valid and available. If false, 'reason' describes why not. </param>
        /// <param name="reason"> The reason why the name is not available, if nameAvailable is false. </param>
        /// <param name="message"> The localized reason why the name is not available, if nameAvailable is false. </param>
        internal NameAvailabilityResponse(bool? nameAvailable, NameCheckFailureReason? reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> If true, the name is valid and available. If false, 'reason' describes why not. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason why the name is not available, if nameAvailable is false. </summary>
        public NameCheckFailureReason? Reason { get; }
        /// <summary> The localized reason why the name is not available, if nameAvailable is false. </summary>
        public string Message { get; }
    }
}
