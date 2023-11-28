// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Provider specific input for container creation operation.
    /// Please note <see cref="ReplicationProviderSpecificContainerCreationContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2AContainerCreationContent"/>, <see cref="A2ACrossClusterMigrationContainerCreationContent"/> and <see cref="VMwareCbtContainerCreationContent"/>.
    /// </summary>
    public abstract partial class ReplicationProviderSpecificContainerCreationContent
    {
        /// <summary> Initializes a new instance of <see cref="ReplicationProviderSpecificContainerCreationContent"/>. </summary>
        protected ReplicationProviderSpecificContainerCreationContent()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
