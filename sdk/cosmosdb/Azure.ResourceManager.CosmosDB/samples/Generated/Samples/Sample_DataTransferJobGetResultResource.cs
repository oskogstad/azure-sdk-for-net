// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_DataTransferJobGetResultResource
    {
        // CosmosDBDataTransferJobCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBDataTransferJobCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/data-transfer-service/CosmosDBDataTransferJobCreate.json
            // this example is just showing the usage of "DataTransferJobs_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataTransferJobGetResultResource created on azure
            // for more information of creating DataTransferJobGetResultResource, please refer to the document of DataTransferJobGetResultResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string jobName = "j1";
            ResourceIdentifier dataTransferJobGetResultResourceId = DataTransferJobGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, jobName);
            DataTransferJobGetResultResource dataTransferJobGetResult = client.GetDataTransferJobGetResultResource(dataTransferJobGetResultResourceId);

            // invoke the operation
            DataTransferJobGetResultCreateOrUpdateContent content = new DataTransferJobGetResultCreateOrUpdateContent(new DataTransferJobProperties(new CosmosCassandraDataTransferDataSourceSink("keyspace", "table"), new AzureBlobDataTransferDataSourceSink("blob_container")
            {
                EndpointUri = new Uri("https://blob.windows.net"),
            }));
            ArmOperation<DataTransferJobGetResultResource> lro = await dataTransferJobGetResult.UpdateAsync(WaitUntil.Completed, content);
            DataTransferJobGetResultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataTransferJobGetResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBDataTransferJobGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBDataTransferJobGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/data-transfer-service/CosmosDBDataTransferJobGet.json
            // this example is just showing the usage of "DataTransferJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataTransferJobGetResultResource created on azure
            // for more information of creating DataTransferJobGetResultResource, please refer to the document of DataTransferJobGetResultResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string jobName = "j1";
            ResourceIdentifier dataTransferJobGetResultResourceId = DataTransferJobGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, jobName);
            DataTransferJobGetResultResource dataTransferJobGetResult = client.GetDataTransferJobGetResultResource(dataTransferJobGetResultResourceId);

            // invoke the operation
            DataTransferJobGetResultResource result = await dataTransferJobGetResult.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataTransferJobGetResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBDataTransferJobPause
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Pause_CosmosDBDataTransferJobPause()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/data-transfer-service/CosmosDBDataTransferJobPause.json
            // this example is just showing the usage of "DataTransferJobs_Pause" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataTransferJobGetResultResource created on azure
            // for more information of creating DataTransferJobGetResultResource, please refer to the document of DataTransferJobGetResultResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string jobName = "j1";
            ResourceIdentifier dataTransferJobGetResultResourceId = DataTransferJobGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, jobName);
            DataTransferJobGetResultResource dataTransferJobGetResult = client.GetDataTransferJobGetResultResource(dataTransferJobGetResultResourceId);

            // invoke the operation
            DataTransferJobGetResultResource result = await dataTransferJobGetResult.PauseAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataTransferJobGetResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBDataTransferJobCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Resume_CosmosDBDataTransferJobCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/data-transfer-service/CosmosDBDataTransferJobResume.json
            // this example is just showing the usage of "DataTransferJobs_Resume" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataTransferJobGetResultResource created on azure
            // for more information of creating DataTransferJobGetResultResource, please refer to the document of DataTransferJobGetResultResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string jobName = "j1";
            ResourceIdentifier dataTransferJobGetResultResourceId = DataTransferJobGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, jobName);
            DataTransferJobGetResultResource dataTransferJobGetResult = client.GetDataTransferJobGetResultResource(dataTransferJobGetResultResourceId);

            // invoke the operation
            DataTransferJobGetResultResource result = await dataTransferJobGetResult.ResumeAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataTransferJobGetResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBDataTransferJobCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Cancel_CosmosDBDataTransferJobCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/data-transfer-service/CosmosDBDataTransferJobCancel.json
            // this example is just showing the usage of "DataTransferJobs_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataTransferJobGetResultResource created on azure
            // for more information of creating DataTransferJobGetResultResource, please refer to the document of DataTransferJobGetResultResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string jobName = "j1";
            ResourceIdentifier dataTransferJobGetResultResourceId = DataTransferJobGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, jobName);
            DataTransferJobGetResultResource dataTransferJobGetResult = client.GetDataTransferJobGetResultResource(dataTransferJobGetResultResourceId);

            // invoke the operation
            DataTransferJobGetResultResource result = await dataTransferJobGetResult.CancelAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataTransferJobGetResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
