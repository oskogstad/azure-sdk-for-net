// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> IP address information for a virtual network adapter reported by the fabric. </summary>
    public partial class NicIPAddressSettings
    {
        /// <summary> Initializes a new instance of <see cref="NicIPAddressSettings"/>. </summary>
        internal NicIPAddressSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NicIPAddressSettings"/>. </summary>
        /// <param name="allocationMethod"> Gets the ip address allocation method. </param>
        /// <param name="ipAddress"> Gets the ip address for the nic. </param>
        /// <param name="subnetMask"> Gets the mask. </param>
        internal NicIPAddressSettings(string allocationMethod, string ipAddress, string subnetMask)
        {
            AllocationMethod = allocationMethod;
            IPAddress = ipAddress;
            SubnetMask = subnetMask;
        }

        /// <summary> Gets the ip address allocation method. </summary>
        public string AllocationMethod { get; }
        /// <summary> Gets the ip address for the nic. </summary>
        public string IPAddress { get; }
        /// <summary> Gets the mask. </summary>
        public string SubnetMask { get; }
    }
}
