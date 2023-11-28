// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Payload object for upsert offer with multiple context and plans. </summary>
    public partial class MultiContextAndPlansContent
    {
        /// <summary> Initializes a new instance of <see cref="MultiContextAndPlansContent"/>. </summary>
        public MultiContextAndPlansContent()
        {
            PlansContext = new ChangeTrackingList<ContextAndPlansDetails>();
        }

        /// <summary> The offer ID which contains the plans. </summary>
        public string OfferId { get; set; }
        /// <summary> The offer's eTag. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Gets the plans context. </summary>
        public IList<ContextAndPlansDetails> PlansContext { get; }
    }
}
