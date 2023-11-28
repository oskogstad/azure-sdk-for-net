// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> The check availability request body. </summary>
    public partial class SelfHelpNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="SelfHelpNameAvailabilityContent"/>. </summary>
        public SelfHelpNameAvailabilityContent()
        {
        }

        /// <summary> The name of the resource for which availability needs to be checked. </summary>
        public string ResourceName { get; set; }
        /// <summary> The resource type. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
