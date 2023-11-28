// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of databases. </summary>
    internal partial class DatabaseListResult
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseListResult"/>. </summary>
        internal DatabaseListResult()
        {
            Value = new ChangeTrackingList<SqlDatabaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal DatabaseListResult(IReadOnlyList<SqlDatabaseData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlDatabaseData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
