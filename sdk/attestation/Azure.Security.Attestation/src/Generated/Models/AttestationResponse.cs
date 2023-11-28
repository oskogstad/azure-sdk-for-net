// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.Attestation
{
    /// <summary> The result of an attestation operation. </summary>
    internal partial class AttestationResponse
    {
        /// <summary> Initializes a new instance of <see cref="AttestationResponse"/>. </summary>
        internal AttestationResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AttestationResponse"/>. </summary>
        /// <param name="token"> An RFC 7519 JSON Web Token, the body of which is an AttestationResult object. </param>
        internal AttestationResponse(string token)
        {
            Token = token;
        }

        /// <summary> An RFC 7519 JSON Web Token, the body of which is an AttestationResult object. </summary>
        public string Token { get; }
    }
}
