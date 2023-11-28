// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The IotSecuritySolutionAnalyticsModelDevicesMetrics. </summary>
    public partial class IotSecuritySolutionAnalyticsModelDevicesMetrics
    {
        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelDevicesMetrics"/>. </summary>
        internal IotSecuritySolutionAnalyticsModelDevicesMetrics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelDevicesMetrics"/>. </summary>
        /// <param name="date"> Aggregation of IoT Security solution device alert metrics by date. </param>
        /// <param name="devicesMetrics"> Device alert count by severity. </param>
        internal IotSecuritySolutionAnalyticsModelDevicesMetrics(DateTimeOffset? date, IotSeverityMetrics devicesMetrics)
        {
            Date = date;
            DevicesMetrics = devicesMetrics;
        }
        /// <summary> Device alert count by severity. </summary>
        public IotSeverityMetrics DevicesMetrics { get; }
    }
}
