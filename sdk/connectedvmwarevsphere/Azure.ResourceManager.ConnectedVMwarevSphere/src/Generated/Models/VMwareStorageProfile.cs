// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
    public partial class VMwareStorageProfile
    {
        /// <summary> Initializes a new instance of <see cref="VMwareStorageProfile"/>. </summary>
        public VMwareStorageProfile()
        {
            Disks = new ChangeTrackingList<VMwareVirtualDisk>();
            ScsiControllers = new ChangeTrackingList<VirtualScsiController>();
        }

        /// <summary> Initializes a new instance of <see cref="VMwareStorageProfile"/>. </summary>
        /// <param name="disks"> Gets or sets the list of virtual disks associated with the virtual machine. </param>
        /// <param name="scsiControllers"> Gets or sets the list of virtual SCSI controllers associated with the virtual machine. </param>
        internal VMwareStorageProfile(IList<VMwareVirtualDisk> disks, IReadOnlyList<VirtualScsiController> scsiControllers)
        {
            Disks = disks;
            ScsiControllers = scsiControllers;
        }

        /// <summary> Gets or sets the list of virtual disks associated with the virtual machine. </summary>
        public IList<VMwareVirtualDisk> Disks { get; }
        /// <summary> Gets or sets the list of virtual SCSI controllers associated with the virtual machine. </summary>
        public IReadOnlyList<VirtualScsiController> ScsiControllers { get; }
    }
}
