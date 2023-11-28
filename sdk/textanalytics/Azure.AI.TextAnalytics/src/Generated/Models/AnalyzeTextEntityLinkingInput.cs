// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The AnalyzeTextEntityLinkingInput. </summary>
    internal partial class AnalyzeTextEntityLinkingInput : AnalyzeTextTask
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeTextEntityLinkingInput"/>. </summary>
        public AnalyzeTextEntityLinkingInput()
        {
            Kind = AnalyzeTextTaskKind.EntityLinking;
        }

        /// <summary> Gets or sets the analysis input. </summary>
        public MultiLanguageAnalysisInput AnalysisInput { get; set; }
        /// <summary> Supported parameters for an Entity Linking task. </summary>
        public EntityLinkingTaskParameters Parameters { get; set; }
    }
}
