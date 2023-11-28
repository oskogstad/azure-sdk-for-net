// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> A set of rules governing the network accessibility. </summary>
    internal partial class NetworkRuleSet
    {
        /// <summary> Initializes a new instance of <see cref="NetworkRuleSet"/>. </summary>
        public NetworkRuleSet()
        {
            VirtualNetworkRules = new ChangeTrackingList<ElasticSanVirtualNetworkRule>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRuleSet"/>. </summary>
        /// <param name="virtualNetworkRules"> The list of virtual network rules. </param>
        internal NetworkRuleSet(IList<ElasticSanVirtualNetworkRule> virtualNetworkRules)
        {
            VirtualNetworkRules = virtualNetworkRules;
        }

        /// <summary> The list of virtual network rules. </summary>
        public IList<ElasticSanVirtualNetworkRule> VirtualNetworkRules { get; }
    }
}
