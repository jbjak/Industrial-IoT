// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Publisher.Models {
    using Microsoft.Azure.IIoT.OpcUa.Api.Core.Models;
    using System.Runtime.Serialization;
    using System.Collections.Generic;

    /// <summary>
    /// Result of bulk request
    /// </summary>
    public class PublishBulkResponseApiModel {

        /// <summary>
        /// Node to add
        /// </summary>
        [DataMember(Name = "nodesToAdd",
            EmitDefaultValue = false)]
        public List<ServiceResultApiModel> NodesToAdd { get; set; }

        /// <summary>
        /// Node to remove
        /// </summary>
        [DataMember(Name = "nodesToRemove",
            EmitDefaultValue = false)]
        public List<ServiceResultApiModel> NodesToRemove { get; set; }
    }
}
