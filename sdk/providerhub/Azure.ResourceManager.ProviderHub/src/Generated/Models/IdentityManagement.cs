// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The IdentityManagement. </summary>
    internal partial class IdentityManagement
    {
        /// <summary> Initializes a new instance of <see cref="IdentityManagement"/>. </summary>
        internal IdentityManagement()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IdentityManagement"/>. </summary>
        /// <param name="managementType"></param>
        internal IdentityManagement(IdentityManagementType? managementType)
        {
            ManagementType = managementType;
        }

        /// <summary> Gets the management type. </summary>
        public IdentityManagementType? ManagementType { get; }
    }
}
