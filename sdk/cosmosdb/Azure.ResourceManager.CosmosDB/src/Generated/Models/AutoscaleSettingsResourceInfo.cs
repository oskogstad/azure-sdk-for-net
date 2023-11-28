// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB provisioned throughput settings object. </summary>
    public partial class AutoscaleSettingsResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="AutoscaleSettingsResourceInfo"/>. </summary>
        /// <param name="maxThroughput"> Represents maximum throughput container can scale up to. </param>
        public AutoscaleSettingsResourceInfo(int maxThroughput)
        {
            MaxThroughput = maxThroughput;
        }

        /// <summary> Initializes a new instance of <see cref="AutoscaleSettingsResourceInfo"/>. </summary>
        /// <param name="maxThroughput"> Represents maximum throughput container can scale up to. </param>
        /// <param name="autoUpgradePolicy"> Cosmos DB resource auto-upgrade policy. </param>
        /// <param name="targetMaxThroughput"> Represents target maximum throughput container can scale up to once offer is no longer in pending state. </param>
        internal AutoscaleSettingsResourceInfo(int maxThroughput, AutoUpgradePolicyResourceInfo autoUpgradePolicy, int? targetMaxThroughput)
        {
            MaxThroughput = maxThroughput;
            AutoUpgradePolicy = autoUpgradePolicy;
            TargetMaxThroughput = targetMaxThroughput;
        }

        /// <summary> Represents maximum throughput container can scale up to. </summary>
        public int MaxThroughput { get; set; }
        /// <summary> Cosmos DB resource auto-upgrade policy. </summary>
        internal AutoUpgradePolicyResourceInfo AutoUpgradePolicy { get; set; }
        /// <summary> Represents throughput policy which service must adhere to for auto-upgrade. </summary>
        public ThroughputPolicyResourceInfo AutoUpgradeThroughputPolicy
        {
            get => AutoUpgradePolicy is null ? default : AutoUpgradePolicy.ThroughputPolicy;
            set
            {
                if (AutoUpgradePolicy is null)
                    AutoUpgradePolicy = new AutoUpgradePolicyResourceInfo();
                AutoUpgradePolicy.ThroughputPolicy = value;
            }
        }

        /// <summary> Represents target maximum throughput container can scale up to once offer is no longer in pending state. </summary>
        public int? TargetMaxThroughput { get; }
    }
}
