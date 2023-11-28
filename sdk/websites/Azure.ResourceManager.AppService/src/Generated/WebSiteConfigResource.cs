// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteConfig along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WebSiteConfigResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWebSiteConfigResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource"/> using the GetWebSiteConfig method.
    /// </summary>
    public partial class WebSiteConfigResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteConfigResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteConfigWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteConfigWebAppsRestClient;
        private readonly ClientDiagnostics _siteConfigSnapshotWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigSnapshotWebAppsRestClient;
        private readonly SiteConfigData _data;

        /// <summary> Initializes a new instance of the <see cref="WebSiteConfigResource"/> class for mocking. </summary>
        protected WebSiteConfigResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteConfigResource(ArmClient client, SiteConfigData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteConfigResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteConfigWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteConfigWebAppsApiVersion);
            _webSiteConfigWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteConfigWebAppsApiVersion);
            _siteConfigSnapshotWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteConfigSnapshotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteConfigSnapshotResource.ResourceType, out string siteConfigSnapshotWebAppsApiVersion);
            _siteConfigSnapshotWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteConfigSnapshotWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteConfigData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteConfigSnapshotResources in the WebSiteConfig. </summary>
        /// <returns> An object representing collection of SiteConfigSnapshotResources and their operations over a SiteConfigSnapshotResource. </returns>
        public virtual SiteConfigSnapshotCollection GetSiteConfigSnapshots()
        {
            return GetCachedClient(client => new SiteConfigSnapshotCollection(client, Id));
        }

        /// <summary>
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetConfigurationSnapshot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteConfigSnapshotResource>> GetSiteConfigSnapshotAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            return await GetSiteConfigSnapshots().GetAsync(snapshotId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetConfigurationSnapshot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteConfigSnapshotResource> GetSiteConfigSnapshot(string snapshotId, CancellationToken cancellationToken = default)
        {
            return GetSiteConfigSnapshots().Get(snapshotId, cancellationToken);
        }

        /// <summary>
        /// Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebSiteConfigResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteConfigWebAppsClientDiagnostics.CreateScope("WebSiteConfigResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteConfigWebAppsRestClient.GetConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebSiteConfigResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteConfigWebAppsClientDiagnostics.CreateScope("WebSiteConfigResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteConfigWebAppsRestClient.GetConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the configuration of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<WebSiteConfigResource>> UpdateAsync(SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteConfigWebAppsClientDiagnostics.CreateScope("WebSiteConfigResource.Update");
            scope.Start();
            try
            {
                var response = await _webSiteConfigWebAppsRestClient.UpdateConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WebSiteConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the configuration of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<WebSiteConfigResource> Update(SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteConfigWebAppsClientDiagnostics.CreateScope("WebSiteConfigResource.Update");
            scope.Start();
            try
            {
                var response = _webSiteConfigWebAppsRestClient.UpdateConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(new WebSiteConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the configuration of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteConfigResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteConfigWebAppsClientDiagnostics.CreateScope("WebSiteConfigResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteConfigWebAppsRestClient.CreateOrUpdateConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSiteConfigResource>(Response.FromValue(new WebSiteConfigResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates the configuration of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebSiteConfigResource> CreateOrUpdate(WaitUntil waitUntil, SiteConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteConfigWebAppsClientDiagnostics.CreateScope("WebSiteConfigResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteConfigWebAppsRestClient.CreateOrUpdateConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<WebSiteConfigResource>(Response.FromValue(new WebSiteConfigResource(Client, response), response.GetRawResponse()));
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
        /// Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListConfigurationSnapshotInfo</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteConfigurationSnapshotInfo"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteConfigSnapshotWebAppsRestClient.CreateListConfigurationSnapshotInfoRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteConfigSnapshotWebAppsRestClient.CreateListConfigurationSnapshotInfoNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SiteConfigurationSnapshotInfo.DeserializeSiteConfigurationSnapshotInfo, _siteConfigSnapshotWebAppsClientDiagnostics, Pipeline, "WebSiteConfigResource.GetConfigurationSnapshotInfo", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListConfigurationSnapshotInfo</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteConfigurationSnapshotInfo"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfo(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteConfigSnapshotWebAppsRestClient.CreateListConfigurationSnapshotInfoRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteConfigSnapshotWebAppsRestClient.CreateListConfigurationSnapshotInfoNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SiteConfigurationSnapshotInfo.DeserializeSiteConfigurationSnapshotInfo, _siteConfigSnapshotWebAppsClientDiagnostics, Pipeline, "WebSiteConfigResource.GetConfigurationSnapshotInfo", "value", "nextLink", cancellationToken);
        }
    }
}
