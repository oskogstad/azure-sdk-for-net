// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The secrets related to a databox heavy job. </summary>
    public partial class DataBoxHeavyJobSecrets : JobSecrets
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxHeavyJobSecrets"/>. </summary>
        internal DataBoxHeavyJobSecrets()
        {
            CabinetPodSecrets = new ChangeTrackingList<DataBoxHeavySecret>();
            JobSecretsType = DataBoxOrderType.DataBoxHeavy;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxHeavyJobSecrets"/>. </summary>
        /// <param name="jobSecretsType"> Used to indicate what type of job secrets object. </param>
        /// <param name="dataCenterAccessSecurityCode"> Dc Access Security Code for Customer Managed Shipping. </param>
        /// <param name="error"> Error while fetching the secrets. </param>
        /// <param name="cabinetPodSecrets"> Contains the list of secret objects for a databox heavy job. </param>
        internal DataBoxHeavyJobSecrets(DataBoxOrderType jobSecretsType, DataCenterAccessSecurityCode dataCenterAccessSecurityCode, ResponseError error, IReadOnlyList<DataBoxHeavySecret> cabinetPodSecrets) : base(jobSecretsType, dataCenterAccessSecurityCode, error)
        {
            CabinetPodSecrets = cabinetPodSecrets;
            JobSecretsType = jobSecretsType;
        }

        /// <summary> Contains the list of secret objects for a databox heavy job. </summary>
        public IReadOnlyList<DataBoxHeavySecret> CabinetPodSecrets { get; }
    }
}
