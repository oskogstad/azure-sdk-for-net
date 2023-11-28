// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ContainerThrottlingInfo. </summary>
    public partial class ContainerThrottlingInfo
    {
        /// <summary> Initializes a new instance of <see cref="ContainerThrottlingInfo"/>. </summary>
        public ContainerThrottlingInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerThrottlingInfo"/>. </summary>
        /// <param name="periods"></param>
        /// <param name="throttledPeriods"></param>
        /// <param name="throttledTime"></param>
        internal ContainerThrottlingInfo(int? periods, int? throttledPeriods, int? throttledTime)
        {
            Periods = periods;
            ThrottledPeriods = throttledPeriods;
            ThrottledTime = throttledTime;
        }

        /// <summary> Gets or sets the periods. </summary>
        public int? Periods { get; set; }
        /// <summary> Gets or sets the throttled periods. </summary>
        public int? ThrottledPeriods { get; set; }
        /// <summary> Gets or sets the throttled time. </summary>
        public int? ThrottledTime { get; set; }
    }
}
