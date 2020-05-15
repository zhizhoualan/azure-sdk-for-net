// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> An array of private link service id that can be linked to a private end point with auto approved. </summary>
    public partial class AutoApprovedPrivateLinkServicesResult
    {
        /// <summary> Initializes a new instance of AutoApprovedPrivateLinkServicesResult. </summary>
        internal AutoApprovedPrivateLinkServicesResult()
        {
        }

        /// <summary> Initializes a new instance of AutoApprovedPrivateLinkServicesResult. </summary>
        /// <param name="value"> An array of auto approved private link service. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal AutoApprovedPrivateLinkServicesResult(IReadOnlyList<AutoApprovedPrivateLinkService> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of auto approved private link service. </summary>
        public IReadOnlyList<AutoApprovedPrivateLinkService> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}