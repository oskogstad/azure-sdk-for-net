// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Request body of the CheckPrivateLinkServiceVisibility API service call. </summary>
    public partial class CheckPrivateLinkServiceVisibilityRequest
    {
        /// <summary> Initializes a new instance of <see cref="CheckPrivateLinkServiceVisibilityRequest"/>. </summary>
        public CheckPrivateLinkServiceVisibilityRequest()
        {
        }

        /// <summary> The alias of the private link service. </summary>
        public string PrivateLinkServiceAlias { get; set; }
    }
}
