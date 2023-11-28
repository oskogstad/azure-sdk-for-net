// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing an event hub data connection. </summary>
    public partial class KustoEventHubDataConnection : KustoDataConnectionData
    {
        /// <summary> Initializes a new instance of <see cref="KustoEventHubDataConnection"/>. </summary>
        public KustoEventHubDataConnection()
        {
            EventSystemProperties = new ChangeTrackingList<string>();
            Kind = DataConnectionKind.EventHub;
        }

        /// <summary> Initializes a new instance of <see cref="KustoEventHubDataConnection"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the endpoint for the data connection. </param>
        /// <param name="eventHubResourceId"> The resource ID of the event hub to be used to create a data connection. </param>
        /// <param name="consumerGroup"> The event hub consumer group. </param>
        /// <param name="tableName"> The table where the data should be ingested. Optionally the table information can be added to each message. </param>
        /// <param name="mappingRuleName"> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </param>
        /// <param name="dataFormat"> The data format of the message. Optionally the data format can be added to each message. </param>
        /// <param name="eventSystemProperties"> System properties of the event hub. </param>
        /// <param name="compression"> The event hub messages compression type. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="managedIdentityResourceId"> The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub. </param>
        /// <param name="managedIdentityObjectId"> The object ID of the managedIdentityResourceId. </param>
        /// <param name="databaseRouting"> Indication for database routing information from the data connection, by default only database routing information is allowed. </param>
        /// <param name="retrievalStartOn"> When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only retrieve events retained by the Event hub, based on its retention period. </param>
        internal KustoEventHubDataConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, DataConnectionKind kind, ResourceIdentifier eventHubResourceId, string consumerGroup, string tableName, string mappingRuleName, KustoEventHubDataFormat? dataFormat, IList<string> eventSystemProperties, EventHubMessagesCompressionType? compression, KustoProvisioningState? provisioningState, ResourceIdentifier managedIdentityResourceId, Guid? managedIdentityObjectId, KustoDatabaseRouting? databaseRouting, DateTimeOffset? retrievalStartOn) : base(id, name, resourceType, systemData, location, kind)
        {
            EventHubResourceId = eventHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            EventSystemProperties = eventSystemProperties;
            Compression = compression;
            ProvisioningState = provisioningState;
            ManagedIdentityResourceId = managedIdentityResourceId;
            ManagedIdentityObjectId = managedIdentityObjectId;
            DatabaseRouting = databaseRouting;
            RetrievalStartOn = retrievalStartOn;
            Kind = kind;
        }

        /// <summary> The resource ID of the event hub to be used to create a data connection. </summary>
        public ResourceIdentifier EventHubResourceId { get; set; }
        /// <summary> The event hub consumer group. </summary>
        public string ConsumerGroup { get; set; }
        /// <summary> The table where the data should be ingested. Optionally the table information can be added to each message. </summary>
        public string TableName { get; set; }
        /// <summary> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </summary>
        public string MappingRuleName { get; set; }
        /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
        public KustoEventHubDataFormat? DataFormat { get; set; }
        /// <summary> System properties of the event hub. </summary>
        public IList<string> EventSystemProperties { get; }
        /// <summary> The event hub messages compression type. </summary>
        public EventHubMessagesCompressionType? Compression { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public KustoProvisioningState? ProvisioningState { get; }
        /// <summary> The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub. </summary>
        public ResourceIdentifier ManagedIdentityResourceId { get; set; }
        /// <summary> The object ID of the managedIdentityResourceId. </summary>
        public Guid? ManagedIdentityObjectId { get; }
        /// <summary> Indication for database routing information from the data connection, by default only database routing information is allowed. </summary>
        public KustoDatabaseRouting? DatabaseRouting { get; set; }
        /// <summary> When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only retrieve events retained by the Event hub, based on its retention period. </summary>
        public DateTimeOffset? RetrievalStartOn { get; set; }
    }
}
