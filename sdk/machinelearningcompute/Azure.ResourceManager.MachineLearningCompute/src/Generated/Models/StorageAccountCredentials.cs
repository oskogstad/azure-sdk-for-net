// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Access information for the storage account. </summary>
    public partial class StorageAccountCredentials
    {
        /// <summary> Initializes a new instance of <see cref="StorageAccountCredentials"/>. </summary>
        internal StorageAccountCredentials()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountCredentials"/>. </summary>
        /// <param name="resourceId"> The ARM resource ID of the storage account. </param>
        /// <param name="primaryKey"> The primary key of the storage account. </param>
        /// <param name="secondaryKey"> The secondary key of the storage account. </param>
        internal StorageAccountCredentials(string resourceId, string primaryKey, string secondaryKey)
        {
            ResourceId = resourceId;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }

        /// <summary> The ARM resource ID of the storage account. </summary>
        public string ResourceId { get; }
        /// <summary> The primary key of the storage account. </summary>
        public string PrimaryKey { get; }
        /// <summary> The secondary key of the storage account. </summary>
        public string SecondaryKey { get; }
    }
}
