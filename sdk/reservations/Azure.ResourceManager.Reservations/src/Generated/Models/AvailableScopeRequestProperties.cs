// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Available scope request properties. </summary>
    internal partial class AvailableScopeRequestProperties
    {
        /// <summary> Initializes a new instance of <see cref="AvailableScopeRequestProperties"/>. </summary>
        public AvailableScopeRequestProperties()
        {
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Gets the scopes. </summary>
        public IList<string> Scopes { get; }
    }
}
