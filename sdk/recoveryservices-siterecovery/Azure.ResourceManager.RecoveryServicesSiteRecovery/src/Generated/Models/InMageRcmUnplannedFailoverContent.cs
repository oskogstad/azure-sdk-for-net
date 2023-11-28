// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm provider specific input for unplanned failover. </summary>
    public partial class InMageRcmUnplannedFailoverContent : UnplannedFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmUnplannedFailoverContent"/>. </summary>
        /// <param name="performShutdown"> A value indicating whether VM is to be shutdown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="performShutdown"/> is null. </exception>
        public InMageRcmUnplannedFailoverContent(string performShutdown)
        {
            Argument.AssertNotNull(performShutdown, nameof(performShutdown));

            PerformShutdown = performShutdown;
            InstanceType = "InMageRcm";
        }

        /// <summary> A value indicating whether VM is to be shutdown. </summary>
        public string PerformShutdown { get; }
        /// <summary> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public ResourceIdentifier RecoveryPointId { get; set; }
    }
}
