// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityInsights.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableSecurityInsightsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableSecurityInsightsResourceGroupResource"/> class for mocking. </summary>
        protected MockableSecurityInsightsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSecurityInsightsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSecurityInsightsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }
    }
}
