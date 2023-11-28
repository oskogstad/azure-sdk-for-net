// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceMover.Mocking;
using Azure.ResourceManager.ResourceMover.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceMover
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ResourceMover. </summary>
    public static partial class ResourceMoverExtensions
    {
        private static MockableResourceMoverArmClient GetMockableResourceMoverArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableResourceMoverArmClient(client0));
        }

        private static MockableResourceMoverResourceGroupResource GetMockableResourceMoverResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableResourceMoverResourceGroupResource(client, resource.Id));
        }

        private static MockableResourceMoverSubscriptionResource GetMockableResourceMoverSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableResourceMoverSubscriptionResource(client, resource.Id));
        }

        private static MockableResourceMoverTenantResource GetMockableResourceMoverTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableResourceMoverTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="MoverResourceSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MoverResourceSetResource.CreateResourceIdentifier" /> to create a <see cref="MoverResourceSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverArmClient.GetMoverResourceSetResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="MoverResourceSetResource"/> object. </returns>
        public static MoverResourceSetResource GetMoverResourceSetResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableResourceMoverArmClient(client).GetMoverResourceSetResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MoverResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MoverResource.CreateResourceIdentifier" /> to create a <see cref="MoverResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverArmClient.GetMoverResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="MoverResource"/> object. </returns>
        public static MoverResource GetMoverResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableResourceMoverArmClient(client).GetMoverResource(id);
        }

        /// <summary>
        /// Gets a collection of MoverResourceSetResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverResourceGroupResource.GetMoverResourceSets()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of MoverResourceSetResources and their operations over a MoverResourceSetResource. </returns>
        public static MoverResourceSetCollection GetMoverResourceSets(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableResourceMoverResourceGroupResource(resourceGroupResource).GetMoverResourceSets();
        }

        /// <summary>
        /// Gets the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverResourceGroupResource.GetMoverResourceSetAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="moverResourceSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MoverResourceSetResource>> GetMoverResourceSetAsync(this ResourceGroupResource resourceGroupResource, string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableResourceMoverResourceGroupResource(resourceGroupResource).GetMoverResourceSetAsync(moverResourceSetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverResourceGroupResource.GetMoverResourceSet(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="moverResourceSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<MoverResourceSetResource> GetMoverResourceSet(this ResourceGroupResource resourceGroupResource, string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableResourceMoverResourceGroupResource(resourceGroupResource).GetMoverResourceSet(moverResourceSetName, cancellationToken);
        }

        /// <summary>
        /// Get all the Move Collections in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Migrate/moveCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_ListMoveCollectionsBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverSubscriptionResource.GetMoverResourceSets(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="MoverResourceSetResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MoverResourceSetResource> GetMoverResourceSetsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableResourceMoverSubscriptionResource(subscriptionResource).GetMoverResourceSetsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all the Move Collections in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Migrate/moveCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_ListMoveCollectionsBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverSubscriptionResource.GetMoverResourceSets(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="MoverResourceSetResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MoverResourceSetResource> GetMoverResourceSets(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableResourceMoverSubscriptionResource(subscriptionResource).GetMoverResourceSets(cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Migrate/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationsDiscovery_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverTenantResource.GetOperationsDiscoveries(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="MoverOperationsDiscovery"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MoverOperationsDiscovery> GetOperationsDiscoveriesAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableResourceMoverTenantResource(tenantResource).GetOperationsDiscoveriesAsync(cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Migrate/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationsDiscovery_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceMoverTenantResource.GetOperationsDiscoveries(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> A collection of <see cref="MoverOperationsDiscovery"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MoverOperationsDiscovery> GetOperationsDiscoveries(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableResourceMoverTenantResource(tenantResource).GetOperationsDiscoveries(cancellationToken);
        }
    }
}
