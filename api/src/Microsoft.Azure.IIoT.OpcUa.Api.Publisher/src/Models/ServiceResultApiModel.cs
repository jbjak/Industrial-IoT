// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Publisher.Models {
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;
    using System.ComponentModel;

    /// <summary>
    /// Service result
    /// </summary>
    [DataContract]
    public class ServiceResultApiModel {

        /// <summary>
        /// Error code - if null operation succeeded.
        /// </summary>
        [DataMember(Name = "statusCode",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public uint? StatusCode { get; set; }

        /// <summary>
        /// Error message in case of error or null.
        /// </summary>
        [DataMember(Name = "errorMessage",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Additional diagnostics information
        /// </summary>
        [DataMember(Name = "diagnostics",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public JToken Diagnostics { get; set; }
    }
}
