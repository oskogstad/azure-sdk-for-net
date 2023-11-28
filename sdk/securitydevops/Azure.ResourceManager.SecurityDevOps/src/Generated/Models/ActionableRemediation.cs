// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The ActionableRemediation. </summary>
    public partial class ActionableRemediation
    {
        /// <summary> Initializes a new instance of <see cref="ActionableRemediation"/>. </summary>
        public ActionableRemediation()
        {
            SeverityLevels = new ChangeTrackingList<string>();
            Categories = new ChangeTrackingList<ActionableRemediationRuleCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="ActionableRemediation"/>. </summary>
        /// <param name="state"></param>
        /// <param name="severityLevels"></param>
        /// <param name="categories"></param>
        /// <param name="branchConfiguration"> Branch onboarding info. </param>
        internal ActionableRemediation(ActionableRemediationState? state, IList<string> severityLevels, IList<ActionableRemediationRuleCategory> categories, TargetBranchConfiguration branchConfiguration)
        {
            State = state;
            SeverityLevels = severityLevels;
            Categories = categories;
            BranchConfiguration = branchConfiguration;
        }

        /// <summary> Gets or sets the state. </summary>
        public ActionableRemediationState? State { get; set; }
        /// <summary> Gets the severity levels. </summary>
        public IList<string> SeverityLevels { get; }
        /// <summary> Gets the categories. </summary>
        public IList<ActionableRemediationRuleCategory> Categories { get; }
        /// <summary> Branch onboarding info. </summary>
        internal TargetBranchConfiguration BranchConfiguration { get; set; }
        /// <summary>
        /// Gets or sets branches that should have annotations.
        ///
        /// For Ignite, we will be supporting a single default branch configuration in the UX.
        /// </summary>
        public IList<string> BranchNames
        {
            get
            {
                if (BranchConfiguration is null)
                    BranchConfiguration = new TargetBranchConfiguration();
                return BranchConfiguration.Names;
            }
        }
    }
}
