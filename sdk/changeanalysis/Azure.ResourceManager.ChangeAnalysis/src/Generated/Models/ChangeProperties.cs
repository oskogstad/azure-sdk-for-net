// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    /// <summary> The properties of a change. </summary>
    public partial class ChangeProperties
    {
        /// <summary> Initializes a new instance of <see cref="ChangeProperties"/>. </summary>
        internal ChangeProperties()
        {
            InitiatedByList = new ChangeTrackingList<string>();
            PropertyChanges = new ChangeTrackingList<PropertyChange>();
        }

        /// <summary> Initializes a new instance of <see cref="ChangeProperties"/>. </summary>
        /// <param name="resourceId"> The resource id that the change is attached to. </param>
        /// <param name="changeDetectedOn"> The time when the change is detected. </param>
        /// <param name="initiatedByList">
        /// The list of identities who might initiated the change.
        /// The identity could be user name (email address) or the object ID of the Service Principal.
        /// </param>
        /// <param name="changeType"> The type of the change. </param>
        /// <param name="propertyChanges"> The list of detailed changes at json property level. </param>
        internal ChangeProperties(ResourceIdentifier resourceId, DateTimeOffset? changeDetectedOn, IReadOnlyList<string> initiatedByList, ChangeType? changeType, IReadOnlyList<PropertyChange> propertyChanges)
        {
            ResourceId = resourceId;
            ChangeDetectedOn = changeDetectedOn;
            InitiatedByList = initiatedByList;
            ChangeType = changeType;
            PropertyChanges = propertyChanges;
        }

        /// <summary> The resource id that the change is attached to. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The time when the change is detected. </summary>
        public DateTimeOffset? ChangeDetectedOn { get; }
        /// <summary>
        /// The list of identities who might initiated the change.
        /// The identity could be user name (email address) or the object ID of the Service Principal.
        /// </summary>
        public IReadOnlyList<string> InitiatedByList { get; }
        /// <summary> The type of the change. </summary>
        public ChangeType? ChangeType { get; }
        /// <summary> The list of detailed changes at json property level. </summary>
        public IReadOnlyList<PropertyChange> PropertyChanges { get; }
    }
}
