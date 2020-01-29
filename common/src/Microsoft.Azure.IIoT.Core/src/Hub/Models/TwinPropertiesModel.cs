// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Hub.Models {
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Twin properties
    /// </summary>
    [DataContract]
    public class TwinPropertiesModel {

        /// <summary>
        /// Reported settings
        /// </summary>
        [DataMember(Name = "reported",
            EmitDefaultValue = false)]
        public Dictionary<string, JToken> Reported { get; set; }

        /// <summary>
        /// Desired settings
        /// </summary>
        [DataMember(Name = "desired",
            EmitDefaultValue = false)]
        public Dictionary<string, JToken> Desired { get; set; }
    }
}
