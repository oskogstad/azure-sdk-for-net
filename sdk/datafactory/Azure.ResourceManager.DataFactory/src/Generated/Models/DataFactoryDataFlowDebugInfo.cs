// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Data flow debug resource. </summary>
    public partial class DataFactoryDataFlowDebugInfo : DataFactoryDebugInfo
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowDebugInfo"/>. </summary>
        /// <param name="properties">
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletProperties"/>, <see cref="DataFactoryMappingDataFlowProperties"/> and <see cref="DataFactoryWranglingDataFlowProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryDataFlowDebugInfo(DataFactoryDataFlowProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary>
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletProperties"/>, <see cref="DataFactoryMappingDataFlowProperties"/> and <see cref="DataFactoryWranglingDataFlowProperties"/>.
        /// </summary>
        public DataFactoryDataFlowProperties Properties { get; }
    }
}
