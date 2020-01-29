﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Agent.Framework.Storage.Database {
    using Microsoft.Azure.IIoT.Agent.Framework.Models;
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;
    using System;

    /// <summary>
    /// processing status
    /// </summary>
    [DataContract]
    public class ProcessingStatusDocument {

        /// <summary>
        /// id
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Etag
        /// </summary>
        [DataMember(Name = "_etag")]
        public string ETag { get; set; }

        /// <summary>
        /// Document type
        /// </summary>
        public string ClassType { get; set; } = ClassTypeName;
        /// <summary/>
        public static readonly string ClassTypeName = "ProcessingStatus";

        /// <summary>
        /// Identifier of the job document
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Last known heartbeat
        /// </summary>
        public DateTime? LastKnownHeartbeat { get; set; }

        /// <summary>
        /// Last known state
        /// </summary>
        public JToken LastKnownState { get; set; }

        /// <summary>
        /// Processing mode
        /// </summary>
        public ProcessMode? ProcessMode { get; set; }
    }
}