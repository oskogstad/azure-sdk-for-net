// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The datastore details of the MT. </summary>
    public partial class SiteRecoveryDataStore
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryDataStore"/>. </summary>
        internal SiteRecoveryDataStore()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryDataStore"/>. </summary>
        /// <param name="symbolicName"> The symbolic name of data store. </param>
        /// <param name="uuid"> The uuid of data store. </param>
        /// <param name="capacity"> The capacity of data store in GBs. </param>
        /// <param name="freeSpace"> The free space of data store in GBs. </param>
        /// <param name="dataStoreType"> The type of data store. </param>
        internal SiteRecoveryDataStore(string symbolicName, Guid? uuid, string capacity, string freeSpace, string dataStoreType)
        {
            SymbolicName = symbolicName;
            Uuid = uuid;
            Capacity = capacity;
            FreeSpace = freeSpace;
            DataStoreType = dataStoreType;
        }

        /// <summary> The symbolic name of data store. </summary>
        public string SymbolicName { get; }
        /// <summary> The uuid of data store. </summary>
        public Guid? Uuid { get; }
        /// <summary> The capacity of data store in GBs. </summary>
        public string Capacity { get; }
        /// <summary> The free space of data store in GBs. </summary>
        public string FreeSpace { get; }
        /// <summary> The type of data store. </summary>
        public string DataStoreType { get; }
    }
}
