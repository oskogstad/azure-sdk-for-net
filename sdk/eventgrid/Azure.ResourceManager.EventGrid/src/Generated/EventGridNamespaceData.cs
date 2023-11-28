// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the EventGridNamespace data model.
    /// Namespace resource.
    /// </summary>
    public partial class EventGridNamespaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public EventGridNamespaceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<EventGridPrivateEndpointConnectionData>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Represents available Sku pricing tiers. </param>
        /// <param name="identity"> Identity information for the Namespace resource. </param>
        /// <param name="privateEndpointConnections"></param>
        /// <param name="provisioningState"> Provisioning state of the namespace resource. </param>
        /// <param name="topicsConfiguration"> Topics configuration information for the namespace resource. </param>
        /// <param name="topicSpacesConfiguration"> Topic spaces configuration information for the namespace resource. </param>
        /// <param name="isZoneRedundant">
        /// Allows the user to specify if the service is zone-redundant. This is a required property and user needs to specify this value explicitly.
        /// Once specified, this property cannot be updated.
        /// </param>
        /// <param name="publicNetworkAccess">
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PubSub.NamespaceProperties.InboundIpRules" /&gt;
        /// </param>
        /// <param name="inboundIPRules"> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </param>
        /// <param name="minimumTlsVersionAllowed"> Minimum TLS version of the publisher allowed to publish to this namespace. Only TLS version 1.2 is supported. </param>
        internal EventGridNamespaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, NamespaceSku sku, ManagedServiceIdentity identity, IList<EventGridPrivateEndpointConnectionData> privateEndpointConnections, NamespaceProvisioningState? provisioningState, TopicsConfiguration topicsConfiguration, TopicSpacesConfiguration topicSpacesConfiguration, bool? isZoneRedundant, EventGridPublicNetworkAccess? publicNetworkAccess, IList<EventGridInboundIPRule> inboundIPRules, TlsVersion? minimumTlsVersionAllowed) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            TopicsConfiguration = topicsConfiguration;
            TopicSpacesConfiguration = topicSpacesConfiguration;
            IsZoneRedundant = isZoneRedundant;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIPRules = inboundIPRules;
            MinimumTlsVersionAllowed = minimumTlsVersionAllowed;
        }

        /// <summary> Represents available Sku pricing tiers. </summary>
        public NamespaceSku Sku { get; set; }
        /// <summary> Identity information for the Namespace resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets the private endpoint connections. </summary>
        public IList<EventGridPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Provisioning state of the namespace resource. </summary>
        public NamespaceProvisioningState? ProvisioningState { get; }
        /// <summary> Topics configuration information for the namespace resource. </summary>
        internal TopicsConfiguration TopicsConfiguration { get; set; }
        /// <summary> The hostname for the topics configuration. This is a read-only property. </summary>
        public string TopicsHostname
        {
            get => TopicsConfiguration is null ? default : TopicsConfiguration.Hostname;
        }

        /// <summary> Topic spaces configuration information for the namespace resource. </summary>
        public TopicSpacesConfiguration TopicSpacesConfiguration { get; set; }
        /// <summary>
        /// Allows the user to specify if the service is zone-redundant. This is a required property and user needs to specify this value explicitly.
        /// Once specified, this property cannot be updated.
        /// </summary>
        public bool? IsZoneRedundant { get; set; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PubSub.NamespaceProperties.InboundIpRules" /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> Minimum TLS version of the publisher allowed to publish to this namespace. Only TLS version 1.2 is supported. </summary>
        public TlsVersion? MinimumTlsVersionAllowed { get; set; }
    }
}
