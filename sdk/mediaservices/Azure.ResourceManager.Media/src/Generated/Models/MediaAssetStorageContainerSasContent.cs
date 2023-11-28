// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The parameters to the list SAS request. </summary>
    public partial class MediaAssetStorageContainerSasContent
    {
        /// <summary> Initializes a new instance of <see cref="MediaAssetStorageContainerSasContent"/>. </summary>
        public MediaAssetStorageContainerSasContent()
        {
        }

        /// <summary> The permissions to set on the SAS URL. </summary>
        public MediaAssetContainerPermission? Permissions { get; set; }
        /// <summary> The SAS URL expiration time.  This must be less than 24 hours from the current time. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
    }
}
