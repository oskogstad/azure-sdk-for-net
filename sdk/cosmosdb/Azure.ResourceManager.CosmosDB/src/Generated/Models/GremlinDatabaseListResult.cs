// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the Gremlin databases and their properties. </summary>
    internal partial class GremlinDatabaseListResult
    {
        /// <summary> Initializes a new instance of <see cref="GremlinDatabaseListResult"/>. </summary>
        internal GremlinDatabaseListResult()
        {
            Value = new ChangeTrackingList<GremlinDatabaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="GremlinDatabaseListResult"/>. </summary>
        /// <param name="value"> List of Gremlin databases and their properties. </param>
        internal GremlinDatabaseListResult(IReadOnlyList<GremlinDatabaseData> value)
        {
            Value = value;
        }

        /// <summary> List of Gremlin databases and their properties. </summary>
        public IReadOnlyList<GremlinDatabaseData> Value { get; }
    }
}
