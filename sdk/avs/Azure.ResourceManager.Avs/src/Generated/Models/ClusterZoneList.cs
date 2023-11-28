// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> List of all zones and associated hosts for a cluster. </summary>
    internal partial class ClusterZoneList
    {
        /// <summary> Initializes a new instance of <see cref="ClusterZoneList"/>. </summary>
        internal ClusterZoneList()
        {
            Zones = new ChangeTrackingList<AvsClusterZone>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterZoneList"/>. </summary>
        /// <param name="zones"> Zone and associated hosts info. </param>
        internal ClusterZoneList(IReadOnlyList<AvsClusterZone> zones)
        {
            Zones = zones;
        }

        /// <summary> Zone and associated hosts info. </summary>
        public IReadOnlyList<AvsClusterZone> Zones { get; }
    }
}
