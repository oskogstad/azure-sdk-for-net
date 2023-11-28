// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedCosmosDBSqlTriggerResourceInfo. </summary>
    public partial class ExtendedCosmosDBSqlTriggerResourceInfo : CosmosDBSqlTriggerResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlTriggerResourceInfo"/>. </summary>
        /// <param name="triggerName"> Name of the Cosmos DB SQL trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public ExtendedCosmosDBSqlTriggerResourceInfo(string triggerName) : base(triggerName)
        {
            Argument.AssertNotNull(triggerName, nameof(triggerName));
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlTriggerResourceInfo"/>. </summary>
        /// <param name="triggerName"> Name of the Cosmos DB SQL trigger. </param>
        /// <param name="body"> Body of the Trigger. </param>
        /// <param name="triggerType"> Type of the Trigger. </param>
        /// <param name="triggerOperation"> The operation the trigger is associated with. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedCosmosDBSqlTriggerResourceInfo(string triggerName, string body, CosmosDBSqlTriggerType? triggerType, CosmosDBSqlTriggerOperation? triggerOperation, string rid, float? timestamp, ETag? etag) : base(triggerName, body, triggerType, triggerOperation)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
