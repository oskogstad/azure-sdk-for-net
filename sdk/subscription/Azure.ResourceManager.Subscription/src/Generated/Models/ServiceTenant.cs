// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> Billing account service tenant. </summary>
    public partial class ServiceTenant
    {
        /// <summary> Initializes a new instance of <see cref="ServiceTenant"/>. </summary>
        internal ServiceTenant()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceTenant"/>. </summary>
        /// <param name="tenantId"> Service tenant id. </param>
        /// <param name="tenantName"> Service tenant name. </param>
        internal ServiceTenant(Guid? tenantId, string tenantName)
        {
            TenantId = tenantId;
            TenantName = tenantName;
        }

        /// <summary> Service tenant id. </summary>
        public Guid? TenantId { get; }
        /// <summary> Service tenant name. </summary>
        public string TenantName { get; }
    }
}
