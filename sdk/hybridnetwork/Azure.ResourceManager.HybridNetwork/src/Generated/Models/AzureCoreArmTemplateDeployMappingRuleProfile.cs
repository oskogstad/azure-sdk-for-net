// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure template deploy mapping rule profile. </summary>
    public partial class AzureCoreArmTemplateDeployMappingRuleProfile : MappingRuleProfile
    {
        /// <summary> Initializes a new instance of <see cref="AzureCoreArmTemplateDeployMappingRuleProfile"/>. </summary>
        public AzureCoreArmTemplateDeployMappingRuleProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureCoreArmTemplateDeployMappingRuleProfile"/>. </summary>
        /// <param name="applicationEnablement"> The application enablement. </param>
        /// <param name="templateMappingRuleProfile"> The template mapping rule profile. </param>
        internal AzureCoreArmTemplateDeployMappingRuleProfile(ApplicationEnablement? applicationEnablement, ArmTemplateMappingRuleProfile templateMappingRuleProfile) : base(applicationEnablement)
        {
            TemplateMappingRuleProfile = templateMappingRuleProfile;
        }

        /// <summary> The template mapping rule profile. </summary>
        internal ArmTemplateMappingRuleProfile TemplateMappingRuleProfile { get; set; }
        /// <summary> List of template parameters. </summary>
        public string TemplateParameters
        {
            get => TemplateMappingRuleProfile is null ? default : TemplateMappingRuleProfile.TemplateParameters;
            set
            {
                if (TemplateMappingRuleProfile is null)
                    TemplateMappingRuleProfile = new ArmTemplateMappingRuleProfile();
                TemplateMappingRuleProfile.TemplateParameters = value;
            }
        }
    }
}
