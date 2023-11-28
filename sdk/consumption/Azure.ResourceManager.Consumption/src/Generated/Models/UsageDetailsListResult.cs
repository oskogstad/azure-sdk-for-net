// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Result of listing usage details. It contains a list of available usage details in reverse chronological order by billing period. </summary>
    internal partial class UsageDetailsListResult
    {
        /// <summary> Initializes a new instance of <see cref="UsageDetailsListResult"/>. </summary>
        internal UsageDetailsListResult()
        {
            Value = new ChangeTrackingList<ConsumptionUsageDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="UsageDetailsListResult"/>. </summary>
        /// <param name="value">
        /// The list of usage details.
        /// Please note <see cref="ConsumptionUsageDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConsumptionLegacyUsageDetail"/> and <see cref="ConsumptionModernUsageDetail"/>.
        /// </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal UsageDetailsListResult(IReadOnlyList<ConsumptionUsageDetail> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of usage details.
        /// Please note <see cref="ConsumptionUsageDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConsumptionLegacyUsageDetail"/> and <see cref="ConsumptionModernUsageDetail"/>.
        /// </summary>
        public IReadOnlyList<ConsumptionUsageDetail> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
