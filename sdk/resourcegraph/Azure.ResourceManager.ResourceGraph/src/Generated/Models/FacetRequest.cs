// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> A request to compute additional statistics (facets) over the query results. </summary>
    public partial class FacetRequest
    {
        /// <summary> Initializes a new instance of <see cref="FacetRequest"/>. </summary>
        /// <param name="expression"> The column or list of columns to summarize by. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expression"/> is null. </exception>
        public FacetRequest(string expression)
        {
            Argument.AssertNotNull(expression, nameof(expression));

            Expression = expression;
        }

        /// <summary> The column or list of columns to summarize by. </summary>
        public string Expression { get; }
        /// <summary> The options for facet evaluation. </summary>
        public FacetRequestOptions Options { get; set; }
    }
}
