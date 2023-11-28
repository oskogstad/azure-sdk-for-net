// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Sku information related properties of a server. </summary>
    public partial class ServerSku
    {
        /// <summary> Initializes a new instance of <see cref="ServerSku"/>. </summary>
        /// <param name="name"> The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3. </param>
        /// <param name="tier"> The tier of the particular SKU, e.g. Burstable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal ServerSku(string name, PostgreSqlFlexibleServerSkuTier tier)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Tier = tier;
        }

        /// <summary> The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3. </summary>
        public string Name { get; }
        /// <summary> The tier of the particular SKU, e.g. Burstable. </summary>
        public PostgreSqlFlexibleServerSkuTier Tier { get; }
    }
}
