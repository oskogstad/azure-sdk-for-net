// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HealthBot.Models
{
    /// <summary> The resource model definition representing SKU. </summary>
    public partial class HealthBotSku
    {
        /// <summary> Initializes a new instance of <see cref="HealthBotSku"/>. </summary>
        /// <param name="name"> The name of the Azure Health Bot SKU. </param>
        public HealthBotSku(HealthBotSkuName name)
        {
            Name = name;
        }

        /// <summary> The name of the Azure Health Bot SKU. </summary>
        public HealthBotSkuName Name { get; set; }
    }
}
