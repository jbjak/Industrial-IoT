// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Modules.OpcUa.Publisher.v2.Models {
    using Microsoft.Azure.IIoT.OpcUa.Core.Models;
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;
    using System;

    /// <summary>
    /// Credential model
    /// </summary>
    [DataContract]
    public class CredentialApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        public CredentialApiModel() { }

        /// <summary>
        /// Create api model from service model
        /// </summary>
        /// <param name="model"></param>
        public CredentialApiModel(CredentialModel model) {
            if (model == null) {
                throw new ArgumentNullException(nameof(model));
            }
            Value = model.Value;
            Type = model.Type;
        }

        /// <summary>
        /// Create service model from api model
        /// </summary>
        public CredentialModel ToServiceModel() {
            return new CredentialModel {
                Value = Value,
                Type = Type
            };
        }

        /// <summary>
        /// Type of credential
        /// </summary>
        [DataMember(Name = "type",
            EmitDefaultValue = false)]
        public CredentialType? Type { get; set; }

        /// <summary>
        /// Value to pass to server
        /// </summary>
        [DataMember(Name = "value",
            EmitDefaultValue = false)]
        public JToken Value { get; set; }
    }
}
