// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Properties of a configure alert request. </summary>
    public partial class SiteRecoveryConfigureAlertProperties
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryConfigureAlertProperties"/>. </summary>
        public SiteRecoveryConfigureAlertProperties()
        {
            CustomEmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> A value indicating whether to send email to subscription administrator. </summary>
        public string SendToOwners { get; set; }
        /// <summary> The custom email address for sending emails. </summary>
        public IList<string> CustomEmailAddresses { get; }
        /// <summary> The locale for the email notification. </summary>
        public string Locale { get; set; }
    }
}
