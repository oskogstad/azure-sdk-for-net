// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> List of Offer proxy resources for the HCI cluster. </summary>
    internal partial class HciOfferList
    {
        /// <summary> Initializes a new instance of <see cref="HciOfferList"/>. </summary>
        internal HciOfferList()
        {
            Value = new ChangeTrackingList<OfferData>();
        }

        /// <summary> Initializes a new instance of <see cref="HciOfferList"/>. </summary>
        /// <param name="value"> List of Offer proxy resources. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal HciOfferList(IReadOnlyList<OfferData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Offer proxy resources. </summary>
        public IReadOnlyList<OfferData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
