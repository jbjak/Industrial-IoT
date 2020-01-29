// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Twin.Models {
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// method arg model
    /// </summary>
    [DataContract]
    public class MethodCallArgumentApiModel {

        /// <summary>
        /// Initial value or value to use
        /// </summary>
        [DataMember(Name = "value")]
        public JToken Value { get; set; }

        /// <summary>
        /// Data type Id of the value (from meta data)
        /// </summary>
        [DataMember(Name = "dataType")]
        public string DataType { get; set; }
    }
}
