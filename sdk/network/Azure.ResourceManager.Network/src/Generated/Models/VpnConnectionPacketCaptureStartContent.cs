// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn Connection packet capture parameters supplied to start packet capture on gateway connection. </summary>
    public partial class VpnConnectionPacketCaptureStartContent
    {
        /// <summary> Initializes a new instance of <see cref="VpnConnectionPacketCaptureStartContent"/>. </summary>
        public VpnConnectionPacketCaptureStartContent()
        {
            LinkConnectionNames = new ChangeTrackingList<string>();
        }

        /// <summary> Start Packet capture parameters on vpn connection. </summary>
        public string FilterData { get; set; }
        /// <summary> List of site link connection names. </summary>
        public IList<string> LinkConnectionNames { get; }
    }
}
