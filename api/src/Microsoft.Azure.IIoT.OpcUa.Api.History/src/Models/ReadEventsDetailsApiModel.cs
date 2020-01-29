// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.History.Models {
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// Read event data
    /// </summary>
    [DataContract]
    public class ReadEventsDetailsApiModel {

        /// <summary>
        /// Start time to read from
        /// </summary>
        [DataMember(Name = "startTime",
            EmitDefaultValue = false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// End time to read to
        /// </summary>
        [DataMember(Name = "endTime",
            EmitDefaultValue = false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Number of events to read
        /// </summary>
        [DataMember(Name = "numEvents",
            EmitDefaultValue = false)]
        public uint? NumEvents { get; set; }

        /// <summary>
        /// The filter to use to select the event fields
        /// </summary>
        [DataMember(Name = "filter",
            EmitDefaultValue = false)]
        public EventFilterApiModel Filter { get; set; }
    }
}
