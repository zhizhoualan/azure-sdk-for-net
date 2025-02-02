// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Iot.TimeSeriesInsights.Models;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Definition of whether to expand hierarchy nodes in the same search instances call. </summary>
    public partial class HierarchiesExpandParameter
    {
        /// <summary> Initializes a new instance of HierarchiesExpandParameter. </summary>
        public HierarchiesExpandParameter()
        {
        }

        /// <summary> Kind of the expansion of hierarchy nodes. When it is set to &apos;UntilChildren&apos;, the hierarchy nodes are expanded recursively until there is more than one child. When it is set to &apos;OneLevel&apos;, the hierarchies are expanded only at the single level matching path search instances parameter. Optional, default is &apos;UntilChildren&apos;. </summary>
        public HierarchiesExpandKind? Kind { get; set; }
    }
}
