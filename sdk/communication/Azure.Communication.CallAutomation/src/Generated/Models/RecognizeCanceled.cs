// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The RecognizeCanceled. </summary>
    public partial class RecognizeCanceled
    {
        /// <summary> Initializes a new instance of <see cref="RecognizeCanceled"/>. </summary>
        internal RecognizeCanceled()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecognizeCanceled"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        internal RecognizeCanceled(string callConnectionId, string serverCallId, string correlationId, string operationContext)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
        }
    }
}
