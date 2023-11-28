// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Connection state details of the private endpoint. </summary>
    public partial class SynapsePrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of <see cref="SynapsePrivateLinkServiceConnectionState"/>. </summary>
        public SynapsePrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapsePrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        internal SynapsePrivateLinkServiceConnectionState(string status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public string Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> The actions required for private link service connection. </summary>
        public string ActionsRequired { get; }
    }
}
