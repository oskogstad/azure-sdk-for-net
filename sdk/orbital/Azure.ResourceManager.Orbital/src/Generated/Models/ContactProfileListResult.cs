// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Response for the ListContactProfiles API service call. </summary>
    internal partial class ContactProfileListResult
    {
        /// <summary> Initializes a new instance of <see cref="ContactProfileListResult"/>. </summary>
        internal ContactProfileListResult()
        {
            Value = new ChangeTrackingList<OrbitalContactProfileData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContactProfileListResult"/>. </summary>
        /// <param name="value"> A list of contact profile resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ContactProfileListResult(IReadOnlyList<OrbitalContactProfileData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of contact profile resources in a resource group. </summary>
        public IReadOnlyList<OrbitalContactProfileData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
