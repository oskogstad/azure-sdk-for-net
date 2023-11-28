// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity source for an Office 365 service. </summary>
    public partial class Office365Source : CopyActivitySource
    {
        /// <summary> Initializes a new instance of <see cref="Office365Source"/>. </summary>
        public Office365Source()
        {
            CopySourceType = "Office365Source";
        }

        /// <summary> Initializes a new instance of <see cref="Office365Source"/>. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="allowedGroups"> The groups containing all the users. Type: array of strings (or Expression with resultType array of strings). </param>
        /// <param name="userScopeFilterUri"> The user scope uri. Type: string (or Expression with resultType string). </param>
        /// <param name="dateFilterColumn"> The Column to apply the &lt;paramref name="StartTime"/&gt; and &lt;paramref name="EndTime"/&gt;. Type: string (or Expression with resultType string). </param>
        /// <param name="startOn"> Start time of the requested range for this dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="endOn"> End time of the requested range for this dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="outputColumns"> The columns to be read out from the Office 365 table. Type: array of objects (or Expression with resultType array of objects). itemType: OutputColumn. Example: [ { "name": "Id" }, { "name": "CreatedDateTime" } ]. </param>
        internal Office365Source(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<IList<string>> allowedGroups, DataFactoryElement<string> userScopeFilterUri, DataFactoryElement<string> dateFilterColumn, DataFactoryElement<string> startOn, DataFactoryElement<string> endOn, DataFactoryElement<IList<Office365TableOutputColumn>> outputColumns) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            AllowedGroups = allowedGroups;
            UserScopeFilterUri = userScopeFilterUri;
            DateFilterColumn = dateFilterColumn;
            StartOn = startOn;
            EndOn = endOn;
            OutputColumns = outputColumns;
            CopySourceType = copySourceType ?? "Office365Source";
        }

        /// <summary> The groups containing all the users. Type: array of strings (or Expression with resultType array of strings). </summary>
        public DataFactoryElement<IList<string>> AllowedGroups { get; set; }
        /// <summary> The user scope uri. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserScopeFilterUri { get; set; }
        /// <summary> The Column to apply the &lt;paramref name="StartTime"/&gt; and &lt;paramref name="EndTime"/&gt;. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> DateFilterColumn { get; set; }
        /// <summary> Start time of the requested range for this dataset. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> StartOn { get; set; }
        /// <summary> End time of the requested range for this dataset. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> EndOn { get; set; }
        /// <summary> The columns to be read out from the Office 365 table. Type: array of objects (or Expression with resultType array of objects). itemType: OutputColumn. Example: [ { "name": "Id" }, { "name": "CreatedDateTime" } ]. </summary>
        public DataFactoryElement<IList<Office365TableOutputColumn>> OutputColumns { get; set; }
    }
}
