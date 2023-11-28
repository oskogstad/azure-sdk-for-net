// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.GuestConfiguration;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmGuestConfigurationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="GuestConfiguration.GuestConfigurationAssignmentData"/>. </summary>
        /// <param name="id"> ARM resource id of the guest configuration assignment. </param>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="location"> Region where the VM is located. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="properties"> Properties of the Guest configuration assignment. </param>
        /// <returns> A new <see cref="GuestConfiguration.GuestConfigurationAssignmentData"/> instance for mocking. </returns>
        public static GuestConfigurationAssignmentData GuestConfigurationAssignmentData(ResourceIdentifier id = null, string name = null, AzureLocation? location = null, ResourceType? resourceType = null, SystemData systemData = null, GuestConfigurationAssignmentProperties properties = null)
        {
            return new GuestConfigurationAssignmentData(id, name, location, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationAssignmentProperties"/>. </summary>
        /// <param name="targetResourceId"> VM resource Id. </param>
        /// <param name="guestConfiguration"> The guest configuration to assign. </param>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="lastComplianceStatusCheckedOn"> Date and time when last compliance status was checked. </param>
        /// <param name="latestReportId"> Id of the latest report for the guest configuration assignment. </param>
        /// <param name="parameterHash"> parameter hash for the guest configuration assignment. </param>
        /// <param name="latestAssignmentReport"> Last reported guest configuration assignment report. </param>
        /// <param name="context"> The source which initiated the guest configuration assignment. Ex: Azure Policy. </param>
        /// <param name="assignmentHash"> Combined hash of the configuration package and parameters. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="resourceType"> Type of the resource - VMSS / VM. </param>
        /// <param name="vmssVmList"> The list of VM Compliance data for VMSS. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationAssignmentProperties"/> instance for mocking. </returns>
        public static GuestConfigurationAssignmentProperties GuestConfigurationAssignmentProperties(string targetResourceId = null, GuestConfigurationNavigation guestConfiguration = null, AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = null, DateTimeOffset? lastComplianceStatusCheckedOn = null, ResourceIdentifier latestReportId = null, string parameterHash = null, GuestConfigurationAssignmentReportInfo latestAssignmentReport = null, string context = null, string assignmentHash = null, GuestConfigurationProvisioningState? provisioningState = null, string resourceType = null, IEnumerable<GuestConfigurationVmssVmInfo> vmssVmList = null)
        {
            vmssVmList ??= new List<GuestConfigurationVmssVmInfo>();

            return new GuestConfigurationAssignmentProperties(targetResourceId, guestConfiguration, complianceStatus, lastComplianceStatusCheckedOn, latestReportId, parameterHash, latestAssignmentReport, context, assignmentHash, provisioningState, resourceType, vmssVmList?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationNavigation"/>. </summary>
        /// <param name="kind"> Kind of the guest configuration. For example:DSC. </param>
        /// <param name="name"> Name of the guest configuration. </param>
        /// <param name="version"> Version of the guest configuration. </param>
        /// <param name="contentUri"> Uri of the storage where guest configuration package is uploaded. </param>
        /// <param name="contentHash"> Combined hash of the guest configuration package and configuration parameters. </param>
        /// <param name="assignmentType"> Specifies the assignment type and execution of the configuration. Possible values are Audit, DeployAndAutoCorrect, ApplyAndAutoCorrect and ApplyAndMonitor. </param>
        /// <param name="assignmentSource"> Specifies the origin of the configuration. </param>
        /// <param name="contentType"> Specifies the content type of the configuration. Possible values could be Builtin or Custom. </param>
        /// <param name="configurationParameters"> The configuration parameters for the guest configuration. </param>
        /// <param name="configurationProtectedParameters"> The protected configuration parameters for the guest configuration. </param>
        /// <param name="configurationSetting"> The configuration setting for the guest configuration. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationNavigation"/> instance for mocking. </returns>
        public static GuestConfigurationNavigation GuestConfigurationNavigation(GuestConfigurationKind? kind = null, string name = null, string version = null, Uri contentUri = null, string contentHash = null, GuestConfigurationAssignmentType? assignmentType = null, string assignmentSource = null, string contentType = null, IEnumerable<GuestConfigurationParameter> configurationParameters = null, IEnumerable<GuestConfigurationParameter> configurationProtectedParameters = null, LcmConfigurationSetting configurationSetting = null)
        {
            configurationParameters ??= new List<GuestConfigurationParameter>();
            configurationProtectedParameters ??= new List<GuestConfigurationParameter>();

            return new GuestConfigurationNavigation(kind, name, version, contentUri, contentHash, assignmentType, assignmentSource, contentType, configurationParameters?.ToList(), configurationProtectedParameters?.ToList(), configurationSetting);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LcmConfigurationSetting"/>. </summary>
        /// <param name="configurationMode"> Specifies how the LCM(Local Configuration Manager) actually applies the configuration to the target nodes. Possible values are ApplyOnly, ApplyAndMonitor, and ApplyAndAutoCorrect. </param>
        /// <param name="isModuleOverwriteAllowed"> If true - new configurations downloaded from the pull service are allowed to overwrite the old ones on the target node. Otherwise, false. </param>
        /// <param name="actionAfterReboot"> Specifies what happens after a reboot during the application of a configuration. The possible values are ContinueConfiguration and StopConfiguration. </param>
        /// <param name="refreshFrequencyInMins"> The time interval, in minutes, at which the LCM checks a pull service to get updated configurations. This value is ignored if the LCM is not configured in pull mode. The default value is 30. </param>
        /// <param name="rebootIfNeeded"> Set this to true to automatically reboot the node after a configuration that requires reboot is applied. Otherwise, you will have to manually reboot the node for any configuration that requires it. The default value is false. To use this setting when a reboot condition is enacted by something other than DSC (such as Windows Installer), combine this setting with the xPendingReboot module. </param>
        /// <param name="configurationModeFrequencyInMins"> How often, in minutes, the current configuration is checked and applied. This property is ignored if the ConfigurationMode property is set to ApplyOnly. The default value is 15. </param>
        /// <returns> A new <see cref="Models.LcmConfigurationSetting"/> instance for mocking. </returns>
        public static LcmConfigurationSetting LcmConfigurationSetting(LcmConfigurationMode? configurationMode = null, bool? isModuleOverwriteAllowed = null, ActionAfterReboot? actionAfterReboot = null, float? refreshFrequencyInMins = null, bool? rebootIfNeeded = null, float? configurationModeFrequencyInMins = null)
        {
            return new LcmConfigurationSetting(configurationMode, isModuleOverwriteAllowed, actionAfterReboot, refreshFrequencyInMins, rebootIfNeeded, configurationModeFrequencyInMins);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationAssignmentReportInfo"/>. </summary>
        /// <param name="id"> ARM resource id of the report for the guest configuration assignment. </param>
        /// <param name="reportId"> GUID that identifies the guest configuration assignment report under a subscription, resource group. </param>
        /// <param name="assignment"> Configuration details of the guest configuration assignment. </param>
        /// <param name="vm"> Information about the VM. </param>
        /// <param name="startOn"> Start date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="endOn"> End date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="operationType"> Type of report, Consistency or Initial. </param>
        /// <param name="resources"> The list of resources for which guest configuration assignment compliance is checked. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationAssignmentReportInfo"/> instance for mocking. </returns>
        public static GuestConfigurationAssignmentReportInfo GuestConfigurationAssignmentReportInfo(ResourceIdentifier id = null, Guid? reportId = null, GuestConfigurationAssignmentInfo assignment = null, GuestConfigurationVmInfo vm = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = null, GuestConfigurationAssignmentReportType? operationType = null, IEnumerable<AssignmentReportResourceInfo> resources = null)
        {
            resources ??= new List<AssignmentReportResourceInfo>();

            return new GuestConfigurationAssignmentReportInfo(id, reportId, assignment, vm, startOn, endOn, complianceStatus, operationType, resources?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationAssignmentInfo"/>. </summary>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="configuration"> Information about the configuration. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationAssignmentInfo"/> instance for mocking. </returns>
        public static GuestConfigurationAssignmentInfo GuestConfigurationAssignmentInfo(string name = null, GuestConfigurationInfo configuration = null)
        {
            return new GuestConfigurationAssignmentInfo(name, configuration);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationInfo"/>. </summary>
        /// <param name="name"> Name of the configuration. </param>
        /// <param name="version"> Version of the configuration. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationInfo"/> instance for mocking. </returns>
        public static GuestConfigurationInfo GuestConfigurationInfo(string name = null, string version = null)
        {
            return new GuestConfigurationInfo(name, version);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationVmInfo"/>. </summary>
        /// <param name="id"> Azure resource Id of the VM. </param>
        /// <param name="uuid"> UUID(Universally Unique Identifier) of the VM. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationVmInfo"/> instance for mocking. </returns>
        public static GuestConfigurationVmInfo GuestConfigurationVmInfo(ResourceIdentifier id = null, Guid? uuid = null)
        {
            return new GuestConfigurationVmInfo(id, uuid);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AssignmentReportResourceInfo"/>. </summary>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="assignmentResourceSettingName"> Name of the guest configuration assignment resource setting. </param>
        /// <param name="reasons"> Compliance reason and reason code for a resource. </param>
        /// <param name="properties"> Properties of a guest configuration assignment resource. </param>
        /// <returns> A new <see cref="Models.AssignmentReportResourceInfo"/> instance for mocking. </returns>
        public static AssignmentReportResourceInfo AssignmentReportResourceInfo(AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = null, string assignmentResourceSettingName = null, IEnumerable<AssignmentReportResourceComplianceReason> reasons = null, BinaryData properties = null)
        {
            reasons ??= new List<AssignmentReportResourceComplianceReason>();

            return new AssignmentReportResourceInfo(complianceStatus, assignmentResourceSettingName, reasons?.ToList(), properties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AssignmentReportResourceComplianceReason"/>. </summary>
        /// <param name="phrase"> Reason for the compliance of the guest configuration assignment resource. </param>
        /// <param name="code"> Code for the compliance of the guest configuration assignment resource. </param>
        /// <returns> A new <see cref="Models.AssignmentReportResourceComplianceReason"/> instance for mocking. </returns>
        public static AssignmentReportResourceComplianceReason AssignmentReportResourceComplianceReason(string phrase = null, string code = null)
        {
            return new AssignmentReportResourceComplianceReason(phrase, code);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationVmssVmInfo"/>. </summary>
        /// <param name="vmId"> UUID of the VM. </param>
        /// <param name="vmResourceId"> Azure resource Id of the VM. </param>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="latestReportId"> Id of the latest report for the guest configuration assignment. </param>
        /// <param name="lastComplianceCheckedOn"> Date and time when last compliance status was checked. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationVmssVmInfo"/> instance for mocking. </returns>
        public static GuestConfigurationVmssVmInfo GuestConfigurationVmssVmInfo(Guid? vmId = null, ResourceIdentifier vmResourceId = null, AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = null, Guid? latestReportId = null, DateTimeOffset? lastComplianceCheckedOn = null)
        {
            return new GuestConfigurationVmssVmInfo(vmId, vmResourceId, complianceStatus, latestReportId, lastComplianceCheckedOn);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationResourceData"/>. </summary>
        /// <param name="id"> ARM resource id of the guest configuration assignment. </param>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="location"> Region where the VM is located. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationResourceData"/> instance for mocking. </returns>
        public static GuestConfigurationResourceData GuestConfigurationResourceData(ResourceIdentifier id = null, string name = null, AzureLocation? location = null, ResourceType? resourceType = null, SystemData systemData = null)
        {
            return new GuestConfigurationResourceData(id, name, location, resourceType, systemData);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationAssignmentReport"/>. </summary>
        /// <param name="id"> ARM resource id of the report for the guest configuration assignment. </param>
        /// <param name="name"> GUID that identifies the guest configuration assignment report under a subscription, resource group. </param>
        /// <param name="properties"> Properties of the guest configuration report. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationAssignmentReport"/> instance for mocking. </returns>
        public static GuestConfigurationAssignmentReport GuestConfigurationAssignmentReport(ResourceIdentifier id = null, string name = null, GuestConfigurationAssignmentReportProperties properties = null)
        {
            return new GuestConfigurationAssignmentReport(id, name, properties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationAssignmentReportProperties"/>. </summary>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="reportId"> GUID that identifies the guest configuration assignment report under a subscription, resource group. </param>
        /// <param name="assignment"> Configuration details of the guest configuration assignment. </param>
        /// <param name="vm"> Information about the VM. </param>
        /// <param name="startOn"> Start date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="endOn"> End date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="details"> Details of the assignment report. </param>
        /// <param name="vmssResourceId"> Azure resource Id of the VMSS. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationAssignmentReportProperties"/> instance for mocking. </returns>
        public static GuestConfigurationAssignmentReportProperties GuestConfigurationAssignmentReportProperties(AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = null, Guid? reportId = null, GuestConfigurationAssignmentInfo assignment = null, GuestConfigurationVmInfo vm = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, GuestConfigurationAssignmentReportDetails details = null, string vmssResourceId = null)
        {
            return new GuestConfigurationAssignmentReportProperties(complianceStatus, reportId, assignment, vm, startOn, endOn, details, vmssResourceId);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GuestConfigurationAssignmentReportDetails"/>. </summary>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="startOn"> Start date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="endOn"> End date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="jobId"> GUID of the report. </param>
        /// <param name="operationType"> Type of report, Consistency or Initial. </param>
        /// <param name="resources"> The list of resources for which guest configuration assignment compliance is checked. </param>
        /// <returns> A new <see cref="Models.GuestConfigurationAssignmentReportDetails"/> instance for mocking. </returns>
        public static GuestConfigurationAssignmentReportDetails GuestConfigurationAssignmentReportDetails(AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, Guid? jobId = null, GuestConfigurationAssignmentReportType? operationType = null, IEnumerable<AssignmentReportResourceInfo> resources = null)
        {
            resources ??= new List<AssignmentReportResourceInfo>();

            return new GuestConfigurationAssignmentReportDetails(complianceStatus, startOn, endOn, jobId, operationType, resources?.ToList());
        }
    }
}
