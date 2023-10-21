// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppJobExecutionData
    {
        internal static ContainerAppJobExecutionData DeserializeContainerAppJobExecutionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobExecutionRunningState> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<ContainerAppJobExecutionTemplate> template = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    foreach (var propertiesProperty in property.Value.EnumerateObject())
                    {
                        if (propertiesProperty.NameEquals("status"u8))
                        {
                            if (propertiesProperty.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new JobExecutionRunningState(propertiesProperty.Value.GetString());
                            continue;
                        }
                        if (propertiesProperty.NameEquals("startTime"u8))
                        {
                            if (propertiesProperty.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = propertiesProperty.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (propertiesProperty.NameEquals("endTime"u8))
                        {
                            if (propertiesProperty.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = propertiesProperty.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (propertiesProperty.NameEquals("template"u8))
                        {
                            if (propertiesProperty.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            template = ContainerAppJobExecutionTemplate.DeserializeContainerAppJobExecutionTemplate(propertiesProperty.Value);
                            continue;
                        }
                    }
                }


                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
            }
            return new ContainerAppJobExecutionData(id, name, type, systemData.Value, Optional.ToNullable(status), Optional.ToNullable(startTime), Optional.ToNullable(endTime), template.Value);
        }
    }
}
