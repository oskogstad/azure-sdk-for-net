// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A rule management event data source. The discriminator fields is always RuleManagementEventDataSource in this case. </summary>
    public partial class RuleManagementEventDataSource : RuleDataSource
    {
        /// <summary> Initializes a new instance of <see cref="RuleManagementEventDataSource"/>. </summary>
        public RuleManagementEventDataSource()
        {
            OdataType = "Microsoft.Azure.Management.Insights.Models.RuleManagementEventDataSource";
        }

        /// <summary> Initializes a new instance of <see cref="RuleManagementEventDataSource"/>. </summary>
        /// <param name="odataType"> specifies the type of data source. There are two types of rule data sources: RuleMetricDataSource and RuleManagementEventDataSource. </param>
        /// <param name="resourceId"> the resource identifier of the resource the rule monitors. **NOTE**: this property cannot be updated for an existing rule. </param>
        /// <param name="legacyResourceId"> the legacy resource identifier of the resource the rule monitors. **NOTE**: this property cannot be updated for an existing rule. </param>
        /// <param name="resourceLocation"> the location of the resource. </param>
        /// <param name="metricNamespace"> the namespace of the metric. </param>
        /// <param name="eventName"> the event name. </param>
        /// <param name="eventSource"> the event source. </param>
        /// <param name="level"> the level. </param>
        /// <param name="operationName"> The name of the operation that should be checked for. If no name is provided, any operation will match. </param>
        /// <param name="resourceGroupName"> the resource group name. </param>
        /// <param name="resourceProviderName"> the resource provider name. </param>
        /// <param name="status"> The status of the operation that should be checked for. If no status is provided, any status will match. </param>
        /// <param name="subStatus"> the substatus. </param>
        /// <param name="claims"> the claims. </param>
        internal RuleManagementEventDataSource(string odataType, ResourceIdentifier resourceId, ResourceIdentifier legacyResourceId, string resourceLocation, string metricNamespace, string eventName, string eventSource, string level, string operationName, string resourceGroupName, string resourceProviderName, string status, string subStatus, RuleManagementEventClaimsDataSource claims) : base(odataType, resourceId, legacyResourceId, resourceLocation, metricNamespace)
        {
            EventName = eventName;
            EventSource = eventSource;
            Level = level;
            OperationName = operationName;
            ResourceGroupName = resourceGroupName;
            ResourceProviderName = resourceProviderName;
            Status = status;
            SubStatus = subStatus;
            Claims = claims;
            OdataType = odataType ?? "Microsoft.Azure.Management.Insights.Models.RuleManagementEventDataSource";
        }

        /// <summary> the event name. </summary>
        public string EventName { get; set; }
        /// <summary> the event source. </summary>
        public string EventSource { get; set; }
        /// <summary> the level. </summary>
        public string Level { get; set; }
        /// <summary> The name of the operation that should be checked for. If no name is provided, any operation will match. </summary>
        public string OperationName { get; set; }
        /// <summary> the resource group name. </summary>
        public string ResourceGroupName { get; set; }
        /// <summary> the resource provider name. </summary>
        public string ResourceProviderName { get; set; }
        /// <summary> The status of the operation that should be checked for. If no status is provided, any status will match. </summary>
        public string Status { get; set; }
        /// <summary> the substatus. </summary>
        public string SubStatus { get; set; }
        /// <summary> the claims. </summary>
        internal RuleManagementEventClaimsDataSource Claims { get; set; }
        /// <summary> the email address. </summary>
        public string ClaimsEmailAddress
        {
            get => Claims is null ? default : Claims.EmailAddress;
            set
            {
                if (Claims is null)
                    Claims = new RuleManagementEventClaimsDataSource();
                Claims.EmailAddress = value;
            }
        }
    }
}
