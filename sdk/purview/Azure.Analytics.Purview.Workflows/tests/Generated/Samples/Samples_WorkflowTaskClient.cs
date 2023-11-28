// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Purview.Workflows;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Workflows.Samples
{
    public partial class Samples_WorkflowTaskClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWorkflowTask_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            Response response = client.GetWorkflowTask(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("workflowRunId").ToString());
            Console.WriteLine(result.GetProperty("workflowId").ToString());
            Console.WriteLine(result.GetProperty("requestor").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateTime").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("targetValue").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWorkflowTask_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            Response response = await client.GetWorkflowTaskAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("workflowRunId").ToString());
            Console.WriteLine(result.GetProperty("workflowId").ToString());
            Console.WriteLine(result.GetProperty("requestor").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateTime").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("targetValue").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetWorkflowTask_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            Response response = client.GetWorkflowTask(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("title").ToString());
            Console.WriteLine(result.GetProperty("workflowRunId").ToString());
            Console.WriteLine(result.GetProperty("workflowId").ToString());
            Console.WriteLine(result.GetProperty("requestor").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateTime").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("targetValue").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("payload").ToString());
            Console.WriteLine(result.GetProperty("reminderInfo").GetProperty("lastRemindTime").ToString());
            Console.WriteLine(result.GetProperty("reminderInfo").GetProperty("nextRemindTime").ToString());
            Console.WriteLine(result.GetProperty("reminderInfo").GetProperty("reminderSettings").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("lastExpiryNotificationTime").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("nextExpiryNotificationTime").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("expiryTime").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("expirySettings").GetProperty("expireAfter").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("expirySettings").GetProperty("notifyOnExpiration")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetWorkflowTask_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            Response response = await client.GetWorkflowTaskAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("title").ToString());
            Console.WriteLine(result.GetProperty("workflowRunId").ToString());
            Console.WriteLine(result.GetProperty("workflowId").ToString());
            Console.WriteLine(result.GetProperty("requestor").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateTime").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("targetValue").ToString());
            Console.WriteLine(result.GetProperty("payload").GetProperty("payload").ToString());
            Console.WriteLine(result.GetProperty("reminderInfo").GetProperty("lastRemindTime").ToString());
            Console.WriteLine(result.GetProperty("reminderInfo").GetProperty("nextRemindTime").ToString());
            Console.WriteLine(result.GetProperty("reminderInfo").GetProperty("reminderSettings").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("lastExpiryNotificationTime").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("nextExpiryNotificationTime").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("expiryTime").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("expirySettings").GetProperty("expireAfter").ToString());
            Console.WriteLine(result.GetProperty("expiryInfo").GetProperty("expirySettings").GetProperty("notifyOnExpiration")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Reassign_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Reassign(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Reassign_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.ReassignAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Reassign_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                reassignments = new object[]
            {
new
{
reassignFrom = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
reassignTo = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
}
            },
            });
            Response response = client.Reassign(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Reassign_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            WorkflowTaskClient client = new WorkflowTaskClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                reassignments = new object[]
            {
new
{
reassignFrom = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
reassignTo = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
}
            },
            });
            Response response = await client.ReassignAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), content);

            Console.WriteLine(response.Status);
        }
    }
}
