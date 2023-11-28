// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The UnknownActiveBaseSecurityAdminRule. </summary>
    internal partial class UnknownActiveBaseSecurityAdminRule : ActiveBaseSecurityAdminRule
    {
        /// <summary> Initializes a new instance of <see cref="UnknownActiveBaseSecurityAdminRule"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="commitOn"> Deployment time string. </param>
        /// <param name="region"> Deployment region. </param>
        /// <param name="configurationDescription"> A description of the security admin configuration. </param>
        /// <param name="ruleCollectionDescription"> A description of the rule collection. </param>
        /// <param name="ruleCollectionAppliesToGroups"> Groups for rule collection. </param>
        /// <param name="ruleGroups"> Effective configuration groups. </param>
        /// <param name="kind"> Whether the rule is custom or default. </param>
        internal UnknownActiveBaseSecurityAdminRule(string id, DateTimeOffset? commitOn, string region, string configurationDescription, string ruleCollectionDescription, IReadOnlyList<NetworkManagerSecurityGroupItem> ruleCollectionAppliesToGroups, IReadOnlyList<NetworkConfigurationGroup> ruleGroups, EffectiveAdminRuleKind kind) : base(id, commitOn, region, configurationDescription, ruleCollectionDescription, ruleCollectionAppliesToGroups, ruleGroups, kind)
        {
            Kind = kind;
        }
    }
}
