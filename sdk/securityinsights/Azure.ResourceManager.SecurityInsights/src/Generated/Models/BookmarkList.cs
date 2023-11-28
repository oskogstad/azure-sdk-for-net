// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List all the bookmarks. </summary>
    internal partial class BookmarkList
    {
        /// <summary> Initializes a new instance of <see cref="BookmarkList"/>. </summary>
        /// <param name="value"> Array of bookmarks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal BookmarkList(IEnumerable<SecurityInsightsBookmarkData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BookmarkList"/>. </summary>
        /// <param name="nextLink"> URL to fetch the next set of cases. </param>
        /// <param name="value"> Array of bookmarks. </param>
        internal BookmarkList(string nextLink, IReadOnlyList<SecurityInsightsBookmarkData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to fetch the next set of cases. </summary>
        public string NextLink { get; }
        /// <summary> Array of bookmarks. </summary>
        public IReadOnlyList<SecurityInsightsBookmarkData> Value { get; }
    }
}
