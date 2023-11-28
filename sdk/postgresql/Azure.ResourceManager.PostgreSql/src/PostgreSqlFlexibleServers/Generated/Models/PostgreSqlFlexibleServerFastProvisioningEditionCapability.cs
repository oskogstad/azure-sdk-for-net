// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Represents capability of a fast provisioning edition. </summary>
    public partial class PostgreSqlFlexibleServerFastProvisioningEditionCapability : PostgreSqlBaseCapability
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerFastProvisioningEditionCapability"/>. </summary>
        internal PostgreSqlFlexibleServerFastProvisioningEditionCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerFastProvisioningEditionCapability"/>. </summary>
        /// <param name="capabilityStatus"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="supportedTier"> Fast provisioning supported tier name. </param>
        /// <param name="supportedSku"> Fast provisioning supported sku name. </param>
        /// <param name="supportedStorageGb"> Fast provisioning supported storage in Gb. </param>
        /// <param name="supportedServerVersions"> Fast provisioning supported version. </param>
        /// <param name="serverCount"> Count of servers in cache matching the spec. </param>
        internal PostgreSqlFlexibleServerFastProvisioningEditionCapability(PostgreSqlFlexbileServerCapabilityStatus? capabilityStatus, string reason, string supportedTier, string supportedSku, long? supportedStorageGb, string supportedServerVersions, int? serverCount) : base(capabilityStatus, reason)
        {
            SupportedTier = supportedTier;
            SupportedSku = supportedSku;
            SupportedStorageGb = supportedStorageGb;
            SupportedServerVersions = supportedServerVersions;
            ServerCount = serverCount;
        }

        /// <summary> Fast provisioning supported tier name. </summary>
        public string SupportedTier { get; }
        /// <summary> Fast provisioning supported sku name. </summary>
        public string SupportedSku { get; }
        /// <summary> Fast provisioning supported version. </summary>
        public string SupportedServerVersions { get; }
        /// <summary> Count of servers in cache matching the spec. </summary>
        public int? ServerCount { get; }
    }
}
