// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input for test migrate. </summary>
    public partial class TestMigrateContent
    {
        /// <summary> Initializes a new instance of <see cref="TestMigrateContent"/>. </summary>
        /// <param name="properties"> Test migrate input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public TestMigrateContent(TestMigrateProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Test migrate input properties. </summary>
        internal TestMigrateProperties Properties { get; }
        /// <summary>
        /// The provider specific details.
        /// Please note <see cref="TestMigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtTestMigrateContent"/>.
        /// </summary>
        public TestMigrateProviderSpecificContent TestMigrateProviderSpecificDetails
        {
            get => Properties?.ProviderSpecificDetails;
        }
    }
}
