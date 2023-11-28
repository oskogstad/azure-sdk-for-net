// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Additional features status like Arc Agent Onboarding. </summary>
    internal partial class ProvisionedClustersCommonPropertiesStatusFeaturesStatus
    {
        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatusFeaturesStatus"/>. </summary>
        internal ProvisionedClustersCommonPropertiesStatusFeaturesStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatusFeaturesStatus"/>. </summary>
        /// <param name="arcAgentStatus"> Defines the observed Arc Agent status that is resourceSynced back to the ARM resource. </param>
        internal ProvisionedClustersCommonPropertiesStatusFeaturesStatus(ArcAgentStatus arcAgentStatus)
        {
            ArcAgentStatus = arcAgentStatus;
        }

        /// <summary> Defines the observed Arc Agent status that is resourceSynced back to the ARM resource. </summary>
        public ArcAgentStatus ArcAgentStatus { get; }
    }
}
