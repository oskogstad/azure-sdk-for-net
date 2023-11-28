// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt disk input. </summary>
    public partial class VMwareCbtDiskContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="isOSDisk"> A value indicating whether the disk is the OS disk. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="logStorageAccountSasSecretName"> The key vault secret name of the log storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/>, <paramref name="isOSDisk"/>, <paramref name="logStorageAccountId"/> or <paramref name="logStorageAccountSasSecretName"/> is null. </exception>
        public VMwareCbtDiskContent(string diskId, string isOSDisk, ResourceIdentifier logStorageAccountId, string logStorageAccountSasSecretName)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));
            Argument.AssertNotNull(isOSDisk, nameof(isOSDisk));
            Argument.AssertNotNull(logStorageAccountId, nameof(logStorageAccountId));
            Argument.AssertNotNull(logStorageAccountSasSecretName, nameof(logStorageAccountSasSecretName));

            DiskId = diskId;
            IsOSDisk = isOSDisk;
            LogStorageAccountId = logStorageAccountId;
            LogStorageAccountSasSecretName = logStorageAccountSasSecretName;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The disk type. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; set; }
        /// <summary> A value indicating whether the disk is the OS disk. </summary>
        public string IsOSDisk { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The key vault secret name of the log storage account. </summary>
        public string LogStorageAccountSasSecretName { get; }
        /// <summary> The DiskEncryptionSet ARM Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
    }
}
