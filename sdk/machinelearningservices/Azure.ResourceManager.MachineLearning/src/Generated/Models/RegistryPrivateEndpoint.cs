// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The PE network resource that is linked to this PE connection. </summary>
    public partial class RegistryPrivateEndpoint : PrivateEndpointBase
    {
        /// <summary> Initializes a new instance of <see cref="RegistryPrivateEndpoint"/>. </summary>
        public RegistryPrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegistryPrivateEndpoint"/>. </summary>
        /// <param name="id"> The ARM identifier for Private Endpoint. </param>
        /// <param name="subnetArmId"> The subnetId that the private endpoint is connected to. </param>
        internal RegistryPrivateEndpoint(ResourceIdentifier id, ResourceIdentifier subnetArmId) : base(id)
        {
            SubnetArmId = subnetArmId;
        }

        /// <summary> The subnetId that the private endpoint is connected to. </summary>
        public ResourceIdentifier SubnetArmId { get; set; }
    }
}
