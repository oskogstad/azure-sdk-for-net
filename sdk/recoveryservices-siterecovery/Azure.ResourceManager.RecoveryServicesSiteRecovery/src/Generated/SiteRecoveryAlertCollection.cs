// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecoveryAlertResource"/> and their operations.
    /// Each <see cref="SiteRecoveryAlertResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SiteRecoveryAlertCollection"/> instance call the GetSiteRecoveryAlerts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SiteRecoveryAlertCollection : ArmCollection, IEnumerable<SiteRecoveryAlertResource>, IAsyncEnumerable<SiteRecoveryAlertResource>
    {
        private readonly ClientDiagnostics _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics;
        private readonly ReplicationAlertSettingsRestOperations _siteRecoveryAlertReplicationAlertSettingsRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryAlertCollection"/> class for mocking. </summary>
        protected SiteRecoveryAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SiteRecoveryAlertCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryAlertResource.ResourceType, out string siteRecoveryAlertReplicationAlertSettingsApiVersion);
            _siteRecoveryAlertReplicationAlertSettingsRestClient = new ReplicationAlertSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryAlertReplicationAlertSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an email notification(alert) configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertSettingName"> The name of the email notification(alert) configuration. </param>
        /// <param name="content"> The input to configure the email notification(alert). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryAlertResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string alertSettingName, SiteRecoveryAlertCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteRecoveryAlertReplicationAlertSettingsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryAlertResource>(Response.FromValue(new SiteRecoveryAlertResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an email notification(alert) configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertSettingName"> The name of the email notification(alert) configuration. </param>
        /// <param name="content"> The input to configure the email notification(alert). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryAlertResource> CreateOrUpdate(WaitUntil waitUntil, string alertSettingName, SiteRecoveryAlertCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteRecoveryAlertReplicationAlertSettingsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryAlertResource>(Response.FromValue(new SiteRecoveryAlertResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the specified email notification(alert) configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryAlertResource>> GetAsync(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryAlertReplicationAlertSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the specified email notification(alert) configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual Response<SiteRecoveryAlertResource> Get(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryAlertReplicationAlertSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of email notification(alert) configurations for the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryAlertResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryAlertResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryAlertReplicationAlertSettingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryAlertReplicationAlertSettingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryAlertResource(Client, SiteRecoveryAlertData.DeserializeSiteRecoveryAlertData(e)), _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics, Pipeline, "SiteRecoveryAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of email notification(alert) configurations for the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryAlertResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryAlertResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryAlertReplicationAlertSettingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryAlertReplicationAlertSettingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryAlertResource(Client, SiteRecoveryAlertData.DeserializeSiteRecoveryAlertData(e)), _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics, Pipeline, "SiteRecoveryAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryAlertReplicationAlertSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryAlertReplicationAlertSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryAlertResource>> GetIfExistsAsync(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryAlertReplicationAlertSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryAlertResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationAlertSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryAlertResource> GetIfExists(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _siteRecoveryAlertReplicationAlertSettingsClientDiagnostics.CreateScope("SiteRecoveryAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryAlertReplicationAlertSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryAlertResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryAlertResource> IEnumerable<SiteRecoveryAlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryAlertResource> IAsyncEnumerable<SiteRecoveryAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
