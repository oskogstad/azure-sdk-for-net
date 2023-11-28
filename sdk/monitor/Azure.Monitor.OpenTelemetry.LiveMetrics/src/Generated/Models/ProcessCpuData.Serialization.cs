// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class ProcessCpuData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProcessName))
            {
                writer.WritePropertyName("ProcessName"u8);
                writer.WriteStringValue(ProcessName);
            }
            if (Optional.IsDefined(CpuPercentage))
            {
                writer.WritePropertyName("CpuPercentage"u8);
                writer.WriteNumberValue(CpuPercentage.Value);
            }
            writer.WriteEndObject();
        }
    }
}
