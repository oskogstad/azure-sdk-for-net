// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A class representing the CommitmentPlan data model.
    /// Cognitive Services account commitment plan.
    /// </summary>
    public partial class CommitmentPlanData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CommitmentPlanData"/>. </summary>
        public CommitmentPlanData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommitmentPlanData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="properties"> Properties of Cognitive Services account commitment plan. </param>
        internal CommitmentPlanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string kind, CognitiveServicesSku sku, IDictionary<string, string> tags, AzureLocation? location, CommitmentPlanProperties properties) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Kind = kind;
            Sku = sku;
            Tags = tags;
            Location = location;
            Properties = properties;
        }

        /// <summary> Resource Etag. </summary>
        public ETag? ETag { get; }
        /// <summary> The Kind of the resource. </summary>
        public string Kind { get; set; }
        /// <summary> The resource model definition representing SKU. </summary>
        public CognitiveServicesSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Properties of Cognitive Services account commitment plan. </summary>
        public CommitmentPlanProperties Properties { get; set; }
    }
}
