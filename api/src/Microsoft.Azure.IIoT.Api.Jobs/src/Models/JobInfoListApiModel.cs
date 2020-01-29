﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Api.Jobs.Models {
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Job info list model
    /// </summary>
    [DataContract]
    public class JobInfoListApiModel {

        /// <summary>
        /// Continuation token
        /// </summary>
        [DataMember(Name = "continuationToken",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// Jobs
        /// </summary>
        [DataMember(Name = "jobs",
            EmitDefaultValue = false)]
        public List<JobInfoApiModel> Jobs { get; set; }
    }
}