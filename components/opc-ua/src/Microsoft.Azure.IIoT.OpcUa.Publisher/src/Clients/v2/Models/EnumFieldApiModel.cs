﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Publisher.Clients.v2.Models {
    using Microsoft.Azure.IIoT.OpcUa.Core.Models;
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// Enum field
    /// </summary>
    [DataContract]
    public class EnumFieldApiModel {
        /// <summary>
        /// Default constructor
        /// </summary>
        public EnumFieldApiModel() { }

        /// <summary>
        /// Create api model from service model
        /// </summary>
        /// <param name="model"></param>
        public EnumFieldApiModel(EnumFieldModel model) {
            if (model == null) {
                throw new ArgumentNullException(nameof(model));
            }
            Description = model.Description == null ? null :
                new LocalizedTextApiModel(model.Description);
            DisplayName = model.DisplayName == null ? null :
                new LocalizedTextApiModel(model.DisplayName);
            Name = model.Name;
            Value = model.Value;
        }

        /// <summary>
        /// Create service model from api model
        /// </summary>
        public EnumFieldModel ToServiceModel() {
            return new EnumFieldModel {
                Name = Name,
                Description = Description?.ToServiceModel(),
                DisplayName = DisplayName?.ToServiceModel(),
                Value = Value
            };
        }

        /// <summary>
        /// Name of the field.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the enumfielderation.
        /// </summary>
        [DataMember(Name = "value")]
        public long Value { get; set; }

        /// <summary>
        /// Human readable name for the value.
        /// </summary>
        [DataMember(Name = "displayName",
            EmitDefaultValue = false)]
        public LocalizedTextApiModel DisplayName { get; set; }

        /// <summary>
        /// A description of the value.
        /// </summary>
        [DataMember(Name = "description",
            EmitDefaultValue = false)]
        public LocalizedTextApiModel Description { get; set; }
    }
}
