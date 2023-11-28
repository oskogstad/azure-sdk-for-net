// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> Provision request specification. </summary>
    public partial class AnalysisServerPatch
    {
        /// <summary> Initializes a new instance of <see cref="AnalysisServerPatch"/>. </summary>
        public AnalysisServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The SKU of the Analysis Services resource. </summary>
        public AnalysisResourceSku Sku { get; set; }
        /// <summary> Key-value pairs of additional provisioning properties. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> A collection of AS server administrators. </summary>
        internal ServerAdministrators AsAdministrators { get; set; }
        /// <summary> An array of administrator user identities. </summary>
        public IList<string> AsAdministratorIdentities
        {
            get
            {
                if (AsAdministrators is null)
                    AsAdministrators = new ServerAdministrators();
                return AsAdministrators.AsAdministratorIdentities;
            }
        }

        /// <summary> The SAS container URI to the backup container. </summary>
        public Uri BackupBlobContainerUri { get; set; }
        /// <summary> The gateway details configured for the AS server. </summary>
        public AnalysisGatewayDetails GatewayDetails { get; set; }
        /// <summary> The firewall settings for the AS server. </summary>
        public AnalysisIPv4FirewallSettings IPV4FirewallSettings { get; set; }
        /// <summary> How the read-write server's participation in the query pool is controlled.&lt;br/&gt;It can have the following values: &lt;ul&gt;&lt;li&gt;readOnly - indicates that the read-write server is intended not to participate in query operations&lt;/li&gt;&lt;li&gt;all - indicates that the read-write server can participate in query operations&lt;/li&gt;&lt;/ul&gt;Specifying readOnly when capacity is 1 results in error. </summary>
        public AnalysisConnectionMode? QuerypoolConnectionMode { get; set; }
        /// <summary> The managed mode of the server (0 = not managed, 1 = managed). </summary>
        public AnalysisManagedMode? ManagedMode { get; set; }
        /// <summary> The server monitor mode for AS server. </summary>
        public ServerMonitorMode? ServerMonitorMode { get; set; }
    }
}
