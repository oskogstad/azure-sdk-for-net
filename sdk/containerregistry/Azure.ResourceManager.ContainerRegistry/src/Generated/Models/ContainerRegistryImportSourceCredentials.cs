// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ContainerRegistryImportSourceCredentials. </summary>
    public partial class ContainerRegistryImportSourceCredentials
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryImportSourceCredentials"/>. </summary>
        /// <param name="password"> The password used to authenticate with the source registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="password"/> is null. </exception>
        public ContainerRegistryImportSourceCredentials(string password)
        {
            Argument.AssertNotNull(password, nameof(password));

            Password = password;
        }

        /// <summary> The username to authenticate with the source registry. </summary>
        public string Username { get; set; }
        /// <summary> The password used to authenticate with the source registry. </summary>
        public string Password { get; }
    }
}
