// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The UnknownAutomationRuleAction. </summary>
    internal partial class UnknownAutomationRuleAction : SecurityInsightsAutomationRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAutomationRuleAction"/>. </summary>
        /// <param name="order"></param>
        /// <param name="actionType"> The type of the automation rule action. </param>
        internal UnknownAutomationRuleAction(int order, ActionType actionType) : base(order, actionType)
        {
            ActionType = actionType;
        }
    }
}
