// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderSubscriptionStateRule. </summary>
    public partial class ProviderSubscriptionStateRule
    {
        /// <summary> Initializes a new instance of <see cref="ProviderSubscriptionStateRule"/>. </summary>
        public ProviderSubscriptionStateRule()
        {
            AllowedActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderSubscriptionStateRule"/>. </summary>
        /// <param name="state"></param>
        /// <param name="allowedActions"></param>
        internal ProviderSubscriptionStateRule(ProviderSubscriptionState? state, IList<string> allowedActions)
        {
            State = state;
            AllowedActions = allowedActions;
        }

        /// <summary> Gets or sets the state. </summary>
        public ProviderSubscriptionState? State { get; set; }
        /// <summary> Gets the allowed actions. </summary>
        public IList<string> AllowedActions { get; }
    }
}
