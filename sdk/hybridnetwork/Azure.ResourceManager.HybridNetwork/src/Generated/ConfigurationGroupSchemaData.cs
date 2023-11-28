// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing the ConfigurationGroupSchema data model.
    /// Configuration group schema resource.
    /// </summary>
    public partial class ConfigurationGroupSchemaData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ConfigurationGroupSchemaData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ConfigurationGroupSchemaData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationGroupSchemaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Configuration group schema properties. </param>
        internal ConfigurationGroupSchemaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ConfigurationGroupSchemaPropertiesFormat properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> Configuration group schema properties. </summary>
        public ConfigurationGroupSchemaPropertiesFormat Properties { get; set; }
    }
}
