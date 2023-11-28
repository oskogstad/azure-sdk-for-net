// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Provides information about how node type can be scaled. </summary>
    public partial class NodeTypeSkuCapacity
    {
        /// <summary> Initializes a new instance of <see cref="NodeTypeSkuCapacity"/>. </summary>
        internal NodeTypeSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NodeTypeSkuCapacity"/>. </summary>
        /// <param name="minimum"> Lowest permitted node count in a node type. </param>
        /// <param name="maximum"> Highest permitted node count in a node type. </param>
        /// <param name="default"> Default node count in a node type. </param>
        /// <param name="scaleType"> Node type capacity scale type. </param>
        internal NodeTypeSkuCapacity(int? minimum, int? maximum, int? @default, NodeTypeSkuScaleType? scaleType)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
        }

        /// <summary> Lowest permitted node count in a node type. </summary>
        public int? Minimum { get; }
        /// <summary> Highest permitted node count in a node type. </summary>
        public int? Maximum { get; }
        /// <summary> Default node count in a node type. </summary>
        public int? Default { get; }
        /// <summary> Node type capacity scale type. </summary>
        public NodeTypeSkuScaleType? ScaleType { get; }
    }
}
