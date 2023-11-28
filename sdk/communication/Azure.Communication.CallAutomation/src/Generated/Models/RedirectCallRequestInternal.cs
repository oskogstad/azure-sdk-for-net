// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for redirecting the call. </summary>
    internal partial class RedirectCallRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="RedirectCallRequestInternal"/>. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="target"> The target identity to redirect the call to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="incomingCallContext"/> or <paramref name="target"/> is null. </exception>
        public RedirectCallRequestInternal(string incomingCallContext, CommunicationIdentifierModel target)
        {
            Argument.AssertNotNull(incomingCallContext, nameof(incomingCallContext));
            Argument.AssertNotNull(target, nameof(target));

            IncomingCallContext = incomingCallContext;
            Target = target;
        }

        /// <summary> The context associated with the call. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The target identity to redirect the call to. </summary>
        public CommunicationIdentifierModel Target { get; }
        /// <summary> Used by customer to send custom context to targets. </summary>
        public CustomContextInternal CustomContext { get; set; }
    }
}
