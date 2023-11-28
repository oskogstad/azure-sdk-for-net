// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Collection of vCenter details. </summary>
    internal partial class SiteRecoveryVCenterListResult
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVCenterListResult"/>. </summary>
        internal SiteRecoveryVCenterListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryVCenterData>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVCenterListResult"/>. </summary>
        /// <param name="value"> The vCenter details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal SiteRecoveryVCenterListResult(IReadOnlyList<SiteRecoveryVCenterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The vCenter details. </summary>
        public IReadOnlyList<SiteRecoveryVCenterData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
