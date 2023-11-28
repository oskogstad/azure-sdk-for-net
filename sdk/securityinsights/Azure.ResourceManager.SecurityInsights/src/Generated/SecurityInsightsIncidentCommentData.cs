// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsIncidentComment data model.
    /// Represents an incident comment
    /// </summary>
    public partial class SecurityInsightsIncidentCommentData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentCommentData"/>. </summary>
        public SecurityInsightsIncidentCommentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentCommentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> The time the comment was created. </param>
        /// <param name="lastModifiedOn"> The time the comment was updated. </param>
        /// <param name="message"> The comment message. </param>
        /// <param name="author"> Describes the client that created the comment. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        internal SecurityInsightsIncidentCommentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string message, SecurityInsightsClientInfo author, ETag? etag) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Message = message;
            Author = author;
            ETag = etag;
        }

        /// <summary> The time the comment was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the comment was updated. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The comment message. </summary>
        public string Message { get; set; }
        /// <summary> Describes the client that created the comment. </summary>
        public SecurityInsightsClientInfo Author { get; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
