// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> List of job details. </summary>
    internal partial class JobDetailsList
    {
        /// <summary> Job details object. </summary>
        [CodeGenMember("Value")]
        public IReadOnlyList<JobDetails> Values { get; }
    }
}
