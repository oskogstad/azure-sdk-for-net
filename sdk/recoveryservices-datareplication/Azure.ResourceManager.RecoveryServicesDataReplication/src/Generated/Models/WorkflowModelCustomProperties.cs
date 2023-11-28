// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary>
    /// Workflow model custom properties.
    /// Please note <see cref="WorkflowModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FailoverWorkflowModelCustomProperties"/>, <see cref="TestFailoverCleanupWorkflowModelCustomProperties"/> and <see cref="TestFailoverWorkflowModelCustomProperties"/>.
    /// </summary>
    public abstract partial class WorkflowModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="WorkflowModelCustomProperties"/>. </summary>
        protected WorkflowModelCustomProperties()
        {
            AffectedObjectDetails = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkflowModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="affectedObjectDetails"> Gets or sets any custom properties of the affected object. </param>
        internal WorkflowModelCustomProperties(string instanceType, IReadOnlyDictionary<string, string> affectedObjectDetails)
        {
            InstanceType = instanceType;
            AffectedObjectDetails = affectedObjectDetails;
        }

        /// <summary> Gets or sets the instance type. </summary>
        internal string InstanceType { get; set; }
        /// <summary> Gets or sets any custom properties of the affected object. </summary>
        public IReadOnlyDictionary<string, string> AffectedObjectDetails { get; }
    }
}
