﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------


namespace Microsoft.Azure.IIoT.OpcUa.Publisher.Clients.v2.Models {
    using Microsoft.Azure.IIoT.OpcUa.Publisher.Models;
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// Configuration version
    /// </summary>
    [DataContract]
    public class ConfigurationVersionApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        public ConfigurationVersionApiModel() { }

        /// <summary>
        /// Create api model from service model
        /// </summary>
        /// <param name="model"></param>
        public ConfigurationVersionApiModel(ConfigurationVersionModel model) {
            if (model == null) {
                throw new ArgumentNullException(nameof(model));
            }
            MajorVersion = model.MajorVersion;
            MinorVersion = model.MinorVersion;
        }

        /// <summary>
        /// Create service model from api model
        /// </summary>
        public ConfigurationVersionModel ToServiceModel() {
            return new ConfigurationVersionModel {
                MajorVersion = MajorVersion,
                MinorVersion = MinorVersion
            };
        }

        /// <summary>
        /// Major version
        /// </summary>
        [DataMember(Name = "majorVersion")]
        public uint MajorVersion { get; set; }

        /// <summary>
        /// Minor version
        /// </summary>
        [DataMember(Name = "minorVersion")]
        public uint MinorVersion { get; set; }
    }
}
