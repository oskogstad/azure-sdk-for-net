// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// Representation of the response data from an embeddings request.
    /// Embeddings measure the relatedness of text strings and are commonly used for search, clustering,
    /// recommendations, and other similar scenarios.
    /// </summary>
    public partial class Embeddings
    {
        /// <summary> Initializes a new instance of <see cref="Embeddings"/>. </summary>
        /// <param name="data"> Embedding values for the prompts submitted in the request. </param>
        /// <param name="usage"> Usage counts for tokens input using the embeddings API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> or <paramref name="usage"/> is null. </exception>
        internal Embeddings(IEnumerable<EmbeddingItem> data, EmbeddingsUsage usage)
        {
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(usage, nameof(usage));

            Data = data.ToList();
            Usage = usage;
        }

        /// <summary> Initializes a new instance of <see cref="Embeddings"/>. </summary>
        /// <param name="data"> Embedding values for the prompts submitted in the request. </param>
        /// <param name="usage"> Usage counts for tokens input using the embeddings API. </param>
        internal Embeddings(IReadOnlyList<EmbeddingItem> data, EmbeddingsUsage usage)
        {
            Data = data;
            Usage = usage;
        }

        /// <summary> Embedding values for the prompts submitted in the request. </summary>
        public IReadOnlyList<EmbeddingItem> Data { get; }
        /// <summary> Usage counts for tokens input using the embeddings API. </summary>
        public EmbeddingsUsage Usage { get; }
    }
}
