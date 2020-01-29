﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Api.Jobs.Models {
    using System.Runtime.Serialization;
    using System.Collections.Generic;

    /// <summary>
    /// Get job processing instructions from orchestrator
    /// </summary>
    [DataContract]
    public class JobRequestApiModel {

        /// <summary>
        /// Capabilities to match
        /// </summary>
        [DataMember(Name = "capabilities",
            EmitDefaultValue = false)]
        public Dictionary<string, string> Capabilities { get; set; }
    }
}