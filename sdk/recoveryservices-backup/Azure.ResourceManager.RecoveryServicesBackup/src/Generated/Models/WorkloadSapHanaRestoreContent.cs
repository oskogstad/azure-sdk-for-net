// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// AzureWorkload SAP Hana-specific restore.
    /// Please note <see cref="WorkloadSapHanaRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadSapHanaPointInTimeRestoreContent"/>, <see cref="WorkloadSapHanaPointInTimeRestoreWithRehydrateContent"/> and <see cref="WorkloadSapHanaRestoreWithRehydrateContent"/>.
    /// </summary>
    public partial class WorkloadSapHanaRestoreContent : WorkloadRestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadSapHanaRestoreContent"/>. </summary>
        public WorkloadSapHanaRestoreContent()
        {
            ObjectType = "AzureWorkloadSAPHanaRestoreRequest";
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadSapHanaRestoreContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryType"> Type of this recovery. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM ID of the VM on which workload that was running is being recovered. </param>
        /// <param name="propertyBag"> Workload specific property bag. </param>
        /// <param name="targetInfo"> Details of target database. </param>
        /// <param name="recoveryMode"> Defines whether the current recovery mode is file restore or database restore. </param>
        /// <param name="targetVirtualMachineId">
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </param>
        internal WorkloadSapHanaRestoreContent(string objectType, FileShareRecoveryType? recoveryType, ResourceIdentifier sourceResourceId, IDictionary<string, string> propertyBag, TargetRestoreInfo targetInfo, RecoveryMode? recoveryMode, ResourceIdentifier targetVirtualMachineId) : base(objectType, recoveryType, sourceResourceId, propertyBag, targetInfo, recoveryMode, targetVirtualMachineId)
        {
            ObjectType = objectType ?? "AzureWorkloadSAPHanaRestoreRequest";
        }
    }
}
