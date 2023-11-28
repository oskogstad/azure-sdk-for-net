// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the resource properties. </summary>
    internal partial class NetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        public NetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaces>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> Gets or sets the list of network interfaces associated with the virtual machine. </param>
        internal NetworkProfile(IList<NetworkInterfaces> networkInterfaces)
        {
            NetworkInterfaces = networkInterfaces;
        }

        /// <summary> Gets or sets the list of network interfaces associated with the virtual machine. </summary>
        public IList<NetworkInterfaces> NetworkInterfaces { get; }
    }
}
