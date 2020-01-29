// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Registry.Models {
    using System.Runtime.Serialization;
    using System.ComponentModel;

    /// <summary>
    /// Gateway registration query
    /// </summary>
    [DataContract]
    public class GatewayQueryApiModel {

        /// <summary>
        /// Site of the Gateway
        /// </summary>
        [DataMember(Name = "siteId",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public string SiteId { get; set; }

        /// <summary>
        /// Included connected or disconnected
        /// </summary>
        [DataMember(Name = "connected",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public bool? Connected { get; set; }
    }
}
