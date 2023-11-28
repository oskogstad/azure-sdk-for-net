// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Response of a list operation. </summary>
    internal partial class DatadogApiKeyListResponse
    {
        /// <summary> Initializes a new instance of <see cref="DatadogApiKeyListResponse"/>. </summary>
        internal DatadogApiKeyListResponse()
        {
            Value = new ChangeTrackingList<DatadogApiKey>();
        }

        /// <summary> Initializes a new instance of <see cref="DatadogApiKeyListResponse"/>. </summary>
        /// <param name="value"> Results of a list operation. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        internal DatadogApiKeyListResponse(IReadOnlyList<DatadogApiKey> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of a list operation. </summary>
        public IReadOnlyList<DatadogApiKey> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
