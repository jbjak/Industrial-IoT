// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Modules.OpcUa.Twin.v2.Models {
    using Microsoft.Azure.IIoT.OpcUa.Core.Models;
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// Diagnostics configuration
    /// </summary>
    [DataContract]
    public class DiagnosticsApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        public DiagnosticsApiModel() { }

        /// <summary>
        /// Create from service model
        /// </summary>
        /// <param name="model"></param>
        public DiagnosticsApiModel(DiagnosticsModel model) {
            if (model == null) {
                throw new ArgumentNullException(nameof(model));
            }
            AuditId = model.AuditId;
            Level = model.Level;
            TimeStamp = model.TimeStamp;
        }

        /// <summary>
        /// Create service model from api model
        /// </summary>
        public DiagnosticsModel ToServiceModel() {
            return new DiagnosticsModel {
                AuditId = AuditId,
                Level = Level,
                TimeStamp = TimeStamp
            };
        }

        /// <summary>
        /// Requested level of response diagnostics.
        /// (default: Status)
        /// </summary>
        [DataMember(Name = "Level",
            EmitDefaultValue = false)]
        public DiagnosticsLevel? Level { get; set; }

        /// <summary>
        /// Client audit log entry.
        /// (default: client generated)
        /// </summary>
        [DataMember(Name = "AuditId",
            EmitDefaultValue = false)]
        public string AuditId { get; set; }

        /// <summary>
        /// Timestamp of request.
        /// (default: client generated)
        /// </summary>
        [DataMember(Name = "TimeStamp",
            EmitDefaultValue = false)]
        public DateTime? TimeStamp { get; set; }
    }
}
