﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Registry.Models {
    using System.Runtime.Serialization;
    using System.ComponentModel;

    /// <summary>
    /// Gateway modules model
    /// </summary>
    [DataContract]
    public class GatewayModulesApiModel {

        /// <summary>
        /// Supervisor identity if deployed
        /// </summary>
        [DataMember(Name = "supervisor",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public SupervisorApiModel Supervisor { get; set; }

        /// <summary>
        /// Publisher identity if deployed
        /// </summary>
        [DataMember(Name = "publisher",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public PublisherApiModel Publisher { get; set; }

        /// <summary>
        /// Discoverer identity if deployed
        /// </summary>
        [DataMember(Name = "discoverer",
            EmitDefaultValue = false)]
        [DefaultValue(null)]
        public DiscovererApiModel Discoverer { get; set; }
    }
}