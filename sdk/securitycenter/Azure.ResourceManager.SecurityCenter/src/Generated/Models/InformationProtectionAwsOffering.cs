// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The information protection for AWS offering. </summary>
    public partial class InformationProtectionAwsOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of <see cref="InformationProtectionAwsOffering"/>. </summary>
        public InformationProtectionAwsOffering()
        {
            OfferingType = OfferingType.InformationProtectionAws;
        }

        /// <summary> Initializes a new instance of <see cref="InformationProtectionAwsOffering"/>. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="informationProtection"> The native cloud connection configuration. </param>
        internal InformationProtectionAwsOffering(OfferingType offeringType, string description, AwsInformationProtection informationProtection) : base(offeringType, description)
        {
            InformationProtection = informationProtection;
            OfferingType = offeringType;
        }

        /// <summary> The native cloud connection configuration. </summary>
        internal AwsInformationProtection InformationProtection { get; set; }
        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string InformationProtectionCloudRoleArn
        {
            get => InformationProtection is null ? default : InformationProtection.CloudRoleArn;
            set
            {
                if (InformationProtection is null)
                    InformationProtection = new AwsInformationProtection();
                InformationProtection.CloudRoleArn = value;
            }
        }
    }
}
