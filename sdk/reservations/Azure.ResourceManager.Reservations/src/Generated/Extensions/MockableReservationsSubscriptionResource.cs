// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Reservations;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableReservationsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private AzureReservationAPIRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableReservationsSubscriptionResource"/> class for mocking. </summary>
        protected MockableReservationsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableReservationsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableReservationsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AzureReservationAPIRestOperations DefaultRestClient => _defaultRestClient ??= new AzureReservationAPIRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ReservationQuotaResources in the SubscriptionResource. </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of ReservationQuotaResources and their operations over a ReservationQuotaResource. </returns>
        public virtual ReservationQuotaCollection GetAllReservationQuota(string providerId, AzureLocation location)
        {
            return new ReservationQuotaCollection(Client, Id, providerId, location);
        }

        /// <summary>
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ReservationQuotaResource>> GetReservationQuotaAsync(string providerId, AzureLocation location, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetAllReservationQuota(providerId, location).GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ReservationQuotaResource> GetReservationQuota(string providerId, AzureLocation location, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetAllReservationQuota(providerId, location).Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of QuotaRequestDetailResources in the SubscriptionResource. </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of QuotaRequestDetailResources and their operations over a QuotaRequestDetailResource. </returns>
        public virtual QuotaRequestDetailCollection GetQuotaRequestDetails(string providerId, AzureLocation location)
        {
            return new QuotaRequestDetailCollection(Client, Id, providerId, location);
        }

        /// <summary>
        /// For the specified Azure region (location), get the details and status of the quota request by the quota request ID for the resources of the resource provider. The PUT request for the quota (service limit) returns a response with the requestId parameter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <param name="id"> Quota Request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<QuotaRequestDetailResource>> GetQuotaRequestDetailAsync(string providerId, AzureLocation location, Guid id, CancellationToken cancellationToken = default)
        {
            return await GetQuotaRequestDetails(providerId, location).GetAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// For the specified Azure region (location), get the details and status of the quota request by the quota request ID for the resources of the resource provider. The PUT request for the quota (service limit) returns a response with the requestId parameter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <param name="id"> Quota Request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<QuotaRequestDetailResource> GetQuotaRequestDetail(string providerId, AzureLocation location, Guid id, CancellationToken cancellationToken = default)
        {
            return GetQuotaRequestDetails(providerId, location).Get(id, cancellationToken);
        }

        /// <summary>
        /// Get the regions and skus that are available for RI purchase for the specified Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetCatalog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationCatalog"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationCatalog> GetCatalogAsync(SubscriptionResourceGetCatalogOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SubscriptionResourceGetCatalogOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateGetCatalogRequest(Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateGetCatalogNextPageRequest(nextLink, Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ReservationCatalog.DeserializeReservationCatalog, DefaultClientDiagnostics, Pipeline, "MockableReservationsSubscriptionResource.GetCatalog", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the regions and skus that are available for RI purchase for the specified Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetCatalog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationCatalog"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationCatalog> GetCatalog(SubscriptionResourceGetCatalogOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SubscriptionResourceGetCatalogOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateGetCatalogRequest(Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateGetCatalogNextPageRequest(nextLink, Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ReservationCatalog.DeserializeReservationCatalog, DefaultClientDiagnostics, Pipeline, "MockableReservationsSubscriptionResource.GetCatalog", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get applicable `Reservation`s that are applied to this subscription or a resource group under this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/appliedReservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAppliedReservationList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppliedReservationData>> GetAppliedReservationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("MockableReservationsSubscriptionResource.GetAppliedReservations");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.GetAppliedReservationListAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get applicable `Reservation`s that are applied to this subscription or a resource group under this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/appliedReservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAppliedReservationList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppliedReservationData> GetAppliedReservations(CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("MockableReservationsSubscriptionResource.GetAppliedReservations");
            scope.Start();
            try
            {
                var response = DefaultRestClient.GetAppliedReservationList(Id.SubscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
