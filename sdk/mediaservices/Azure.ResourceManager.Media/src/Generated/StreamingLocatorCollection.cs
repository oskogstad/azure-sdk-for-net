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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamingLocatorResource"/> and their operations.
    /// Each <see cref="StreamingLocatorResource"/> in the collection will belong to the same instance of <see cref="MediaServicesAccountResource"/>.
    /// To get a <see cref="StreamingLocatorCollection"/> instance call the GetStreamingLocators method from an instance of <see cref="MediaServicesAccountResource"/>.
    /// </summary>
    public partial class StreamingLocatorCollection : ArmCollection, IEnumerable<StreamingLocatorResource>, IAsyncEnumerable<StreamingLocatorResource>
    {
        private readonly ClientDiagnostics _streamingLocatorClientDiagnostics;
        private readonly StreamingLocatorsRestOperations _streamingLocatorRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamingLocatorCollection"/> class for mocking. </summary>
        protected StreamingLocatorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingLocatorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamingLocatorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingLocatorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", StreamingLocatorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamingLocatorResource.ResourceType, out string streamingLocatorApiVersion);
            _streamingLocatorRestClient = new StreamingLocatorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingLocatorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaServicesAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaServicesAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Streaming Locator in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamingLocatorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string streamingLocatorName, StreamingLocatorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamingLocatorRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<StreamingLocatorResource>(Response.FromValue(new StreamingLocatorResource(Client, response), response.GetRawResponse()));
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
        /// Create a Streaming Locator in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamingLocatorResource> CreateOrUpdate(WaitUntil waitUntil, string streamingLocatorName, StreamingLocatorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamingLocatorRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, data, cancellationToken);
                var operation = new MediaArmOperation<StreamingLocatorResource>(Response.FromValue(new StreamingLocatorResource(Client, response), response.GetRawResponse()));
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
        /// Get the details of a Streaming Locator in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> is null. </exception>
        public virtual async Task<Response<StreamingLocatorResource>> GetAsync(string streamingLocatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamingLocatorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingLocatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of a Streaming Locator in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> is null. </exception>
        public virtual Response<StreamingLocatorResource> Get(string streamingLocatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.Get");
            scope.Start();
            try
            {
                var response = _streamingLocatorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingLocatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Streaming Locators in the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamingLocatorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamingLocatorResource> GetAllAsync(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingLocatorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingLocatorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StreamingLocatorResource(Client, StreamingLocatorData.DeserializeStreamingLocatorData(e)), _streamingLocatorClientDiagnostics, Pipeline, "StreamingLocatorCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Streaming Locators in the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamingLocatorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamingLocatorResource> GetAll(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingLocatorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingLocatorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StreamingLocatorResource(Client, StreamingLocatorData.DeserializeStreamingLocatorData(e)), _streamingLocatorClientDiagnostics, Pipeline, "StreamingLocatorCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string streamingLocatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamingLocatorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> is null. </exception>
        public virtual Response<bool> Exists(string streamingLocatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamingLocatorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> is null. </exception>
        public virtual async Task<NullableResponse<StreamingLocatorResource>> GetIfExistsAsync(string streamingLocatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _streamingLocatorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StreamingLocatorResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingLocatorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/streamingLocators/{streamingLocatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingLocators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingLocatorName"> The Streaming Locator name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingLocatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingLocatorName"/> is null. </exception>
        public virtual NullableResponse<StreamingLocatorResource> GetIfExists(string streamingLocatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingLocatorName, nameof(streamingLocatorName));

            using var scope = _streamingLocatorClientDiagnostics.CreateScope("StreamingLocatorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _streamingLocatorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingLocatorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StreamingLocatorResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingLocatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamingLocatorResource> IEnumerable<StreamingLocatorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamingLocatorResource> IAsyncEnumerable<StreamingLocatorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
