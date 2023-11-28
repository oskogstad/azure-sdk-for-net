// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The list cluster pools operation response. </summary>
    internal partial class HDInsightClusterPoolListData
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPoolListData"/>. </summary>
        internal HDInsightClusterPoolListData()
        {
            Value = new ChangeTrackingList<HDInsightClusterPoolData>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPoolListData"/>. </summary>
        /// <param name="value"> The list of cluster pools. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal HDInsightClusterPoolListData(IReadOnlyList<HDInsightClusterPoolData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of cluster pools. </summary>
        public IReadOnlyList<HDInsightClusterPoolData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
