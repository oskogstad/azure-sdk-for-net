// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The DataMasking. </summary>
    public partial class DataMasking
    {
        /// <summary> Initializes a new instance of <see cref="DataMasking"/>. </summary>
        public DataMasking()
        {
            QueryParams = new ChangeTrackingList<DataMaskingEntity>();
            Headers = new ChangeTrackingList<DataMaskingEntity>();
        }

        /// <summary> Initializes a new instance of <see cref="DataMasking"/>. </summary>
        /// <param name="queryParams"> Masking settings for Url query parameters. </param>
        /// <param name="headers"> Masking settings for headers. </param>
        internal DataMasking(IList<DataMaskingEntity> queryParams, IList<DataMaskingEntity> headers)
        {
            QueryParams = queryParams;
            Headers = headers;
        }

        /// <summary> Masking settings for Url query parameters. </summary>
        public IList<DataMaskingEntity> QueryParams { get; }
        /// <summary> Masking settings for headers. </summary>
        public IList<DataMaskingEntity> Headers { get; }
    }
}
