// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchServiceCounters
    {
        internal static SearchServiceCounters DeserializeSearchServiceCounters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SearchResourceCounter documentCount = default;
            SearchResourceCounter indexesCount = default;
            SearchResourceCounter indexersCount = default;
            SearchResourceCounter dataSourcesCount = default;
            SearchResourceCounter storageSize = default;
            SearchResourceCounter synonymMaps = default;
            Optional<SearchResourceCounter> skillsetCount = default;
            SearchResourceCounter vectorIndexSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexesCount"u8))
                {
                    indexesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexersCount"u8))
                {
                    indexersCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourcesCount"u8))
                {
                    dataSourcesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("storageSize"u8))
                {
                    storageSize = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("synonymMaps"u8))
                {
                    synonymMaps = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("skillsetCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skillsetCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("vectorIndexSize"u8))
                {
                    vectorIndexSize = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
            }
            return new SearchServiceCounters(documentCount, indexesCount, indexersCount, dataSourcesCount, storageSize, synonymMaps, skillsetCount.Value, vectorIndexSize);
        }
    }
}
