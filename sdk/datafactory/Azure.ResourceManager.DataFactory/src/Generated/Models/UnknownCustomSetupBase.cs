// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownCustomSetupBase. </summary>
    internal partial class UnknownCustomSetupBase : CustomSetupBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCustomSetupBase"/>. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        internal UnknownCustomSetupBase(string customSetupBaseType) : base(customSetupBaseType)
        {
            CustomSetupBaseType = customSetupBaseType ?? "Unknown";
        }
    }
}
