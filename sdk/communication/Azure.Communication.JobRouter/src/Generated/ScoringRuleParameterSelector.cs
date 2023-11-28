// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> Supported parameters for scoring workers used with BestWorkerMode. </summary>
    public readonly partial struct ScoringRuleParameterSelector : IEquatable<ScoringRuleParameterSelector>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScoringRuleParameterSelector"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScoringRuleParameterSelector(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JobLabelsValue = "jobLabels";
        private const string WorkerSelectorsValue = "workerSelectors";

        /// <summary> Parameter to add job labels to scoring payload.  Property is sent as `job`. </summary>
        public static ScoringRuleParameterSelector JobLabels { get; } = new ScoringRuleParameterSelector(JobLabelsValue);
        /// <summary> Parameter to add worker selectors from a job to scoring payload.  Property is sent as `selectors`. </summary>
        public static ScoringRuleParameterSelector WorkerSelectors { get; } = new ScoringRuleParameterSelector(WorkerSelectorsValue);
        /// <summary> Determines if two <see cref="ScoringRuleParameterSelector"/> values are the same. </summary>
        public static bool operator ==(ScoringRuleParameterSelector left, ScoringRuleParameterSelector right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScoringRuleParameterSelector"/> values are not the same. </summary>
        public static bool operator !=(ScoringRuleParameterSelector left, ScoringRuleParameterSelector right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScoringRuleParameterSelector"/>. </summary>
        public static implicit operator ScoringRuleParameterSelector(string value) => new ScoringRuleParameterSelector(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScoringRuleParameterSelector other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScoringRuleParameterSelector other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
