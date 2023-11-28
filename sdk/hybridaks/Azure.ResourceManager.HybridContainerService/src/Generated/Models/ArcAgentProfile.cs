// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Defines the Arc Agent properties for the Provisioned clusters. </summary>
    public partial class ArcAgentProfile
    {
        /// <summary> Initializes a new instance of <see cref="ArcAgentProfile"/>. </summary>
        public ArcAgentProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArcAgentProfile"/>. </summary>
        /// <param name="agentVersion"> Version of the Arc agents to be installed on the provisioned Provisioned cluster resource. </param>
        /// <param name="agentAutoUpgrade"> Indicates whether the Arc agents on the provisioned clusters be upgraded automatically to the latest version. Defaults to Enabled. </param>
        internal ArcAgentProfile(string agentVersion, AutoUpgradeOption? agentAutoUpgrade)
        {
            AgentVersion = agentVersion;
            AgentAutoUpgrade = agentAutoUpgrade;
        }

        /// <summary> Version of the Arc agents to be installed on the provisioned Provisioned cluster resource. </summary>
        public string AgentVersion { get; set; }
        /// <summary> Indicates whether the Arc agents on the provisioned clusters be upgraded automatically to the latest version. Defaults to Enabled. </summary>
        public AutoUpgradeOption? AgentAutoUpgrade { get; set; }
    }
}
