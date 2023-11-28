// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> SQL Settings in Firewall Policy. </summary>
    internal partial class FirewallPolicySQL
    {
        /// <summary> Initializes a new instance of <see cref="FirewallPolicySQL"/>. </summary>
        public FirewallPolicySQL()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicySQL"/>. </summary>
        /// <param name="allowSqlRedirect"> A flag to indicate if SQL Redirect traffic filtering is enabled. Turning on the flag requires no rule using port 11000-11999. </param>
        internal FirewallPolicySQL(bool? allowSqlRedirect)
        {
            AllowSqlRedirect = allowSqlRedirect;
        }

        /// <summary> A flag to indicate if SQL Redirect traffic filtering is enabled. Turning on the flag requires no rule using port 11000-11999. </summary>
        public bool? AllowSqlRedirect { get; set; }
    }
}
