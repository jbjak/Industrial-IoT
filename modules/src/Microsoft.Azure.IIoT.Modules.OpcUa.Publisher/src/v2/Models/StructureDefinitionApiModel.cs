﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Modules.OpcUa.Publisher.v2.Models {
    using Microsoft.Azure.IIoT.OpcUa.Core.Models;
    using System.Runtime.Serialization;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Structure definition
    /// </summary>
    [DataContract]
    public class StructureDefinitionApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        public StructureDefinitionApiModel() { }

        /// <summary>
        /// Create api model from service model
        /// </summary>
        /// <param name="model"></param>
        public StructureDefinitionApiModel(StructureDefinitionModel model) {
            if (model == null) {
                throw new ArgumentNullException(nameof(model));
            }
            BaseDataTypeId = model.BaseDataTypeId;
            StructureType = model.StructureType;
            Fields = model.Fields?
                .Select(f => new StructureFieldApiModel(f))
                .ToList();
        }

        /// <summary>
        /// Create service model from api model
        /// </summary>
        public StructureDefinitionModel ToServiceModel() {
            return new StructureDefinitionModel {
                BaseDataTypeId = BaseDataTypeId,
                Fields = Fields?
                    .Select(f => f.ToServiceModel())
                    .ToList(),
                StructureType = StructureType
            };
        }

        /// <summary>
        /// Base data type of the structure
        /// </summary>
        [DataMember(Name = "baseDataTypeId",
            EmitDefaultValue = false)]
        public string BaseDataTypeId { get; set; }

        /// <summary>
        /// Type of structure
        /// </summary>
        [DataMember(Name = "structureType")]
        public StructureType StructureType { get; set; }

        /// <summary>
        /// Fields in the structure or union
        /// </summary>
        [DataMember(Name = "fields")]
        public List<StructureFieldApiModel> Fields { get; set; }
    }
}
