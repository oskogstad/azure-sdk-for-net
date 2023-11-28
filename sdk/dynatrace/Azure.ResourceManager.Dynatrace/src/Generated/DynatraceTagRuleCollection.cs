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

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary>
    /// A class representing a collection of <see cref="DynatraceTagRuleResource"/> and their operations.
    /// Each <see cref="DynatraceTagRuleResource"/> in the collection will belong to the same instance of <see cref="DynatraceMonitorResource"/>.
    /// To get a <see cref="DynatraceTagRuleCollection"/> instance call the GetDynatraceTagRules method from an instance of <see cref="DynatraceMonitorResource"/>.
    /// </summary>
    public partial class DynatraceTagRuleCollection : ArmCollection, IEnumerable<DynatraceTagRuleResource>, IAsyncEnumerable<DynatraceTagRuleResource>
    {
        private readonly ClientDiagnostics _dynatraceTagRuleTagRulesClientDiagnostics;
        private readonly TagRulesRestOperations _dynatraceTagRuleTagRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DynatraceTagRuleCollection"/> class for mocking. </summary>
        protected DynatraceTagRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DynatraceTagRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DynatraceTagRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dynatraceTagRuleTagRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Dynatrace", DynatraceTagRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DynatraceTagRuleResource.ResourceType, out string dynatraceTagRuleTagRulesApiVersion);
            _dynatraceTagRuleTagRulesRestClient = new TagRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dynatraceTagRuleTagRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DynatraceMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DynatraceMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DynatraceTagRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleSetName, DynatraceTagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dynatraceTagRuleTagRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DynatraceArmOperation<DynatraceTagRuleResource>(new DynatraceTagRuleOperationSource(Client), _dynatraceTagRuleTagRulesClientDiagnostics, Pipeline, _dynatraceTagRuleTagRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DynatraceTagRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleSetName, DynatraceTagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dynatraceTagRuleTagRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken);
                var operation = new DynatraceArmOperation<DynatraceTagRuleResource>(new DynatraceTagRuleOperationSource(Client), _dynatraceTagRuleTagRulesClientDiagnostics, Pipeline, _dynatraceTagRuleTagRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<DynatraceTagRuleResource>> GetAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _dynatraceTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<DynatraceTagRuleResource> Get(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _dynatraceTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all TagRule by monitorName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DynatraceTagRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DynatraceTagRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dynatraceTagRuleTagRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dynatraceTagRuleTagRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DynatraceTagRuleResource(Client, DynatraceTagRuleData.DeserializeDynatraceTagRuleData(e)), _dynatraceTagRuleTagRulesClientDiagnostics, Pipeline, "DynatraceTagRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all TagRule by monitorName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DynatraceTagRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DynatraceTagRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dynatraceTagRuleTagRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dynatraceTagRuleTagRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DynatraceTagRuleResource(Client, DynatraceTagRuleData.DeserializeDynatraceTagRuleData(e)), _dynatraceTagRuleTagRulesClientDiagnostics, Pipeline, "DynatraceTagRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dynatraceTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _dynatraceTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<NullableResponse<DynatraceTagRuleResource>> GetIfExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dynatraceTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DynatraceTagRuleResource>(response.GetRawResponse());
                return Response.FromValue(new DynatraceTagRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual NullableResponse<DynatraceTagRuleResource> GetIfExists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _dynatraceTagRuleTagRulesClientDiagnostics.CreateScope("DynatraceTagRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dynatraceTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DynatraceTagRuleResource>(response.GetRawResponse());
                return Response.FromValue(new DynatraceTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DynatraceTagRuleResource> IEnumerable<DynatraceTagRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DynatraceTagRuleResource> IAsyncEnumerable<DynatraceTagRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
