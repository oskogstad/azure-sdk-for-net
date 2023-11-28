// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> DNS Proxy settings for Firewall. </summary>
    public partial class FirewallDnsSettings
    {
        /// <summary> Initializes a new instance of <see cref="FirewallDnsSettings"/>. </summary>
        public FirewallDnsSettings()
        {
            DnsServers = new ChangeTrackingList<IPAddressInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="FirewallDnsSettings"/>. </summary>
        /// <param name="enableDnsProxy"> Enable DNS proxy, disabled by default. </param>
        /// <param name="enabledDnsType"> Enabled DNS proxy type, disabled by default. </param>
        /// <param name="dnsServers"> List of IPs associated with the Firewall. </param>
        internal FirewallDnsSettings(AllowDnsProxyType? enableDnsProxy, EnabledDnsType? enabledDnsType, IList<IPAddressInfo> dnsServers)
        {
            EnableDnsProxy = enableDnsProxy;
            EnabledDnsType = enabledDnsType;
            DnsServers = dnsServers;
        }

        /// <summary> Enable DNS proxy, disabled by default. </summary>
        public AllowDnsProxyType? EnableDnsProxy { get; set; }
        /// <summary> Enabled DNS proxy type, disabled by default. </summary>
        public EnabledDnsType? EnabledDnsType { get; set; }
        /// <summary> List of IPs associated with the Firewall. </summary>
        public IList<IPAddressInfo> DnsServers { get; }
    }
}
