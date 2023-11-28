// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Request body to build a new custom document classifier. </summary>
    public partial class BuildDocumentClassifierContent
    {
        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierContent"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="docTypes"> List of document types to classify against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> or <paramref name="docTypes"/> is null. </exception>
        public BuildDocumentClassifierContent(string classifierId, IDictionary<string, ClassifierDocumentTypeDetails> docTypes)
        {
            Argument.AssertNotNull(classifierId, nameof(classifierId));
            Argument.AssertNotNull(docTypes, nameof(docTypes));

            ClassifierId = classifierId;
            DocTypes = docTypes;
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierContent"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="description"> Document classifier description. </param>
        /// <param name="docTypes"> List of document types to classify against. </param>
        internal BuildDocumentClassifierContent(string classifierId, string description, IDictionary<string, ClassifierDocumentTypeDetails> docTypes)
        {
            ClassifierId = classifierId;
            Description = description;
            DocTypes = docTypes;
        }

        /// <summary> Unique document classifier name. </summary>
        public string ClassifierId { get; }
        /// <summary> Document classifier description. </summary>
        public string Description { get; set; }
        /// <summary> List of document types to classify against. </summary>
        public IDictionary<string, ClassifierDocumentTypeDetails> DocTypes { get; }
    }
}
