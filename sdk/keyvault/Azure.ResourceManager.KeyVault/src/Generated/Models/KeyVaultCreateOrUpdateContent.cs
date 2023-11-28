// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Parameters for creating or updating a vault. </summary>
    public partial class KeyVaultCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="KeyVaultCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The supported Azure location where the key vault should be created. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public KeyVaultCreateOrUpdateContent(AzureLocation location, KeyVaultProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = properties;
        }

        /// <summary> The supported Azure location where the key vault should be created. </summary>
        public AzureLocation Location { get; }
        /// <summary> The tags that will be assigned to the key vault. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties of the vault. </summary>
        public KeyVaultProperties Properties { get; }
    }
}
