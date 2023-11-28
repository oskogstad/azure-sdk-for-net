// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private link service connection details. </summary>
    public partial class DeviceUpdatePrivateLinkServiceConnection
    {
        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateLinkServiceConnection"/>. </summary>
        public DeviceUpdatePrivateLinkServiceConnection()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateLinkServiceConnection"/>. </summary>
        /// <param name="name"> Private link service connection name. </param>
        /// <param name="groupIds"> List of group IDs. </param>
        /// <param name="requestMessage"> Request message. </param>
        internal DeviceUpdatePrivateLinkServiceConnection(string name, IList<string> groupIds, string requestMessage)
        {
            Name = name;
            GroupIds = groupIds;
            RequestMessage = requestMessage;
        }

        /// <summary> Private link service connection name. </summary>
        public string Name { get; set; }
        /// <summary> List of group IDs. </summary>
        public IList<string> GroupIds { get; }
        /// <summary> Request message. </summary>
        public string RequestMessage { get; set; }
    }
}
