// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the HttpVersion condition for the delivery rule. </summary>
    public partial class DeliveryRuleHttpVersionCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleHttpVersionCondition"/>. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleHttpVersionCondition(HttpVersionMatchCondition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = MatchVariable.HttpVersion;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleHttpVersionCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleHttpVersionCondition(MatchVariable name, HttpVersionMatchCondition properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public HttpVersionMatchCondition Properties { get; set; }
    }
}
