// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Query filter option for listing runs. </summary>
    public partial class RunQueryFilter
    {
        /// <summary> Initializes a new instance of <see cref="RunQueryFilter"/>. </summary>
        /// <param name="operand"> Parameter name to be used for filter. The allowed operands to query pipeline runs are PipelineName, RunStart, RunEnd and Status; to query activity runs are ActivityName, ActivityRunStart, ActivityRunEnd, ActivityType and Status, and to query trigger runs are TriggerName, TriggerRunTimestamp and Status. </param>
        /// <param name="operator"> Operator to be used for filter. </param>
        /// <param name="values"> List of filter values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="values"/> is null. </exception>
        public RunQueryFilter(RunQueryFilterOperand operand, RunQueryFilterOperator @operator, IEnumerable<string> values)
        {
            Argument.AssertNotNull(values, nameof(values));

            Operand = operand;
            Operator = @operator;
            Values = values.ToList();
        }

        /// <summary> Parameter name to be used for filter. The allowed operands to query pipeline runs are PipelineName, RunStart, RunEnd and Status; to query activity runs are ActivityName, ActivityRunStart, ActivityRunEnd, ActivityType and Status, and to query trigger runs are TriggerName, TriggerRunTimestamp and Status. </summary>
        public RunQueryFilterOperand Operand { get; }
        /// <summary> Operator to be used for filter. </summary>
        public RunQueryFilterOperator Operator { get; }
        /// <summary> List of filter values. </summary>
        public IList<string> Values { get; }
    }
}
