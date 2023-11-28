// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerJobCredential data model.
    /// A stored credential that can be used by a job to connect to target databases.
    /// </summary>
    public partial class SqlServerJobCredentialData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SqlServerJobCredentialData"/>. </summary>
        public SqlServerJobCredentialData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerJobCredentialData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="username"> The credential user name. </param>
        /// <param name="password"> The credential password. </param>
        internal SqlServerJobCredentialData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string username, string password) : base(id, name, resourceType, systemData)
        {
            Username = username;
            Password = password;
        }

        /// <summary> The credential user name. </summary>
        public string Username { get; set; }
        /// <summary> The credential password. </summary>
        public string Password { get; set; }
    }
}
