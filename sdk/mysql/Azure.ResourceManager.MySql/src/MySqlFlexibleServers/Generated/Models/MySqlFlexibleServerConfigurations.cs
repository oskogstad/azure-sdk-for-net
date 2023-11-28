// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A list of server configurations. </summary>
    public partial class MySqlFlexibleServerConfigurations
    {
        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurations"/>. </summary>
        internal MySqlFlexibleServerConfigurations()
        {
            Values = new ChangeTrackingList<MySqlFlexibleServerConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurations"/>. </summary>
        /// <param name="values"> The list of server configurations. </param>
        internal MySqlFlexibleServerConfigurations(IReadOnlyList<MySqlFlexibleServerConfigurationData> values)
        {
            Values = values;
        }

        /// <summary> The list of server configurations. </summary>
        public IReadOnlyList<MySqlFlexibleServerConfigurationData> Values { get; }
    }
}
