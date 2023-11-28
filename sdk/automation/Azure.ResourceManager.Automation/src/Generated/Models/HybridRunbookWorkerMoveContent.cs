// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Parameters supplied to move hybrid worker operation. </summary>
    public partial class HybridRunbookWorkerMoveContent
    {
        /// <summary> Initializes a new instance of <see cref="HybridRunbookWorkerMoveContent"/>. </summary>
        public HybridRunbookWorkerMoveContent()
        {
        }

        /// <summary> Gets or sets the target hybrid runbook worker group. </summary>
        public string HybridRunbookWorkerGroupName { get; set; }
    }
}
