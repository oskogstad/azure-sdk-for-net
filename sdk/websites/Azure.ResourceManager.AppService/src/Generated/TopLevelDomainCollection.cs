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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="TopLevelDomainResource"/> and their operations.
    /// Each <see cref="TopLevelDomainResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="TopLevelDomainCollection"/> instance call the GetTopLevelDomains method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class TopLevelDomainCollection : ArmCollection, IEnumerable<TopLevelDomainResource>, IAsyncEnumerable<TopLevelDomainResource>
    {
        private readonly ClientDiagnostics _topLevelDomainClientDiagnostics;
        private readonly TopLevelDomainsRestOperations _topLevelDomainRestClient;

        /// <summary> Initializes a new instance of the <see cref="TopLevelDomainCollection"/> class for mocking. </summary>
        protected TopLevelDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TopLevelDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TopLevelDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topLevelDomainClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", TopLevelDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TopLevelDomainResource.ResourceType, out string topLevelDomainApiVersion);
            _topLevelDomainRestClient = new TopLevelDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topLevelDomainApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get details of a top-level domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the top-level domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<TopLevelDomainResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _topLevelDomainRestClient.GetAsync(Id.SubscriptionId, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopLevelDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get details of a top-level domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the top-level domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<TopLevelDomainResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _topLevelDomainRestClient.Get(Id.SubscriptionId, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopLevelDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all top-level domains supported for registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TopLevelDomainResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TopLevelDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topLevelDomainRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topLevelDomainRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TopLevelDomainResource(Client, TopLevelDomainData.DeserializeTopLevelDomainData(e)), _topLevelDomainClientDiagnostics, Pipeline, "TopLevelDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get all top-level domains supported for registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TopLevelDomainResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TopLevelDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topLevelDomainRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topLevelDomainRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TopLevelDomainResource(Client, TopLevelDomainData.DeserializeTopLevelDomainData(e)), _topLevelDomainClientDiagnostics, Pipeline, "TopLevelDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the top-level domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _topLevelDomainRestClient.GetAsync(Id.SubscriptionId, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the top-level domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _topLevelDomainRestClient.Get(Id.SubscriptionId, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the top-level domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<TopLevelDomainResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _topLevelDomainRestClient.GetAsync(Id.SubscriptionId, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TopLevelDomainResource>(response.GetRawResponse());
                return Response.FromValue(new TopLevelDomainResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the top-level domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<TopLevelDomainResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _topLevelDomainRestClient.Get(Id.SubscriptionId, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TopLevelDomainResource>(response.GetRawResponse());
                return Response.FromValue(new TopLevelDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TopLevelDomainResource> IEnumerable<TopLevelDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TopLevelDomainResource> IAsyncEnumerable<TopLevelDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
