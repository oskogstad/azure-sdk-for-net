// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthBot.Models
{
    /// <summary> Parameters for updating a Azure Health Bot. </summary>
    public partial class HealthBotPatch
    {
        /// <summary> Initializes a new instance of <see cref="HealthBotPatch"/>. </summary>
        public HealthBotPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Properties of Azure Health Bot. </summary>
        public HealthBotProperties Properties { get; set; }
        /// <summary> Tags for a Azure Health Bot. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> SKU of the Azure Health Bot. </summary>
        internal HealthBotSku Sku { get; set; }
        /// <summary> The name of the Azure Health Bot SKU. </summary>
        public HealthBotSkuName? SkuName
        {
            get => Sku is null ? default(HealthBotSkuName?) : Sku.Name;
            set
            {
                Sku = value.HasValue ? new HealthBotSku(value.Value) : null;
            }
        }

        /// <summary> The identity of the Azure Health Bot. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets or sets the location. </summary>
        public AzureLocation? Location { get; set; }
    }
}
