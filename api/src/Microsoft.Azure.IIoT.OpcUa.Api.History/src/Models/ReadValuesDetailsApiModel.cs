// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.History.Models {
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// Read historic values
    /// </summary>
    [DataContract]
    public class ReadValuesDetailsApiModel {

        /// <summary>
        /// Beginning of period to read. Set to null
        /// if no specific start time is specified.
        /// </summary>
        [DataMember(Name = "startTime",
            EmitDefaultValue = false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// End of period to read. Set to null if no
        /// specific end time is specified.
        /// </summary>
        [DataMember(Name = "endTime",
            EmitDefaultValue = false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The maximum number of values returned for any Node
        /// over the time range. If only one time is specified,
        /// the time range shall extend to return this number
        /// of values. 0 or null indicates that there is no
        /// maximum.
        /// </summary>
        [DataMember(Name = "numValues",
            EmitDefaultValue = false)]
        public uint? NumValues { get; set; }

        /// <summary>
        /// Whether to return the bounding values or not.
        /// </summary>
        [DataMember(Name = "returnBounds",
            EmitDefaultValue = false)]
        public bool? ReturnBounds { get; set; }
    }
}
