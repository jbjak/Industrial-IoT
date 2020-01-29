// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Modules.Discovery.v2.Models {
    using Microsoft.Azure.IIoT.OpcUa.Registry.Models;
    using System.Runtime.Serialization;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Discovery configuration
    /// </summary>
    [DataContract]
    public class DiscoveryConfigApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        public DiscoveryConfigApiModel() { }

        /// <summary>
        /// Create from service model
        /// </summary>
        /// <param name="model"></param>
        public DiscoveryConfigApiModel(DiscoveryConfigModel model) {
            if (model == null) {
                throw new ArgumentNullException(nameof(model));
            }
            AddressRangesToScan = model.AddressRangesToScan;
            NetworkProbeTimeout = model.NetworkProbeTimeout;
            MaxNetworkProbes = model.MaxNetworkProbes;
            PortRangesToScan = model.PortRangesToScan;
            PortProbeTimeout = PortProbeTimeout;
            MaxPortProbes = model.MaxPortProbes;
            MinPortProbesPercent = model.MinPortProbesPercent;
            IdleTimeBetweenScans = IdleTimeBetweenScans;
            DiscoveryUrls = model.DiscoveryUrls;
            Locales = model.Locales;
            ActivationFilter = model.ActivationFilter == null ? null :
                new EndpointActivationFilterApiModel(model.ActivationFilter);
        }

        /// <summary>
        /// Convert back to service model
        /// </summary>
        /// <returns></returns>
        public DiscoveryConfigModel ToServiceModel() {
            return new DiscoveryConfigModel {
                AddressRangesToScan = AddressRangesToScan,
                NetworkProbeTimeout = NetworkProbeTimeout,
                MaxNetworkProbes = MaxNetworkProbes,
                PortRangesToScan = PortRangesToScan,
                PortProbeTimeout = PortProbeTimeout,
                MaxPortProbes = MaxPortProbes,
                MinPortProbesPercent = MinPortProbesPercent,
                IdleTimeBetweenScans = IdleTimeBetweenScans,
                ActivationFilter = ActivationFilter?.ToServiceModel(),
                Locales = Locales,
                DiscoveryUrls = DiscoveryUrls,
            };
        }

        /// <summary>
        /// Address ranges to scan (null == all wired nics)
        /// </summary>
        [DataMember(Name = "AddressRangesToScan",
            EmitDefaultValue = false)]
        public string AddressRangesToScan { get; set; }

        /// <summary>
        /// Network probe timeout.
        /// </summary>
        [DataMember(Name = "NetworkProbeTimeout",
            EmitDefaultValue = false)]
        public TimeSpan? NetworkProbeTimeout { get; set; }

        /// <summary>
        /// Max network probes that should ever run.
        /// </summary>
        [DataMember(Name = "MaxNetworkProbes",
            EmitDefaultValue = false)]
        public int? MaxNetworkProbes { get; set; }

        /// <summary>
        /// Port ranges to scan (null == all unassigned)
        /// </summary>
        [DataMember(Name = "PortRangesToScan",
            EmitDefaultValue = false)]
        public string PortRangesToScan { get; set; }

        /// <summary>
        /// Port probe timeout
        /// </summary>
        [DataMember(Name = "PortProbeTimeout",
            EmitDefaultValue = false)]
        public TimeSpan? PortProbeTimeout { get; set; }

        /// <summary>
        /// Max port probes that should ever run.
        /// </summary>
        [DataMember(Name = "MaxPortProbes",
            EmitDefaultValue = false)]
        public int? MaxPortProbes { get; set; }

        /// <summary>
        /// Probes that must always be there as percent of max.
        /// </summary>
        [DataMember(Name = "MinPortProbesPercent",
            EmitDefaultValue = false)]
        public int? MinPortProbesPercent { get; set; }

        /// <summary>
        /// Delay time between discovery sweeps
        /// </summary>
        [DataMember(Name = "IdleTimeBetweenScans",
            EmitDefaultValue = false)]
        public TimeSpan? IdleTimeBetweenScans { get; set; }

        /// <summary>
        /// List of preset discovery urls to use
        /// </summary>
        [DataMember(Name = "DiscoveryUrls",
            EmitDefaultValue = false)]
        public List<string> DiscoveryUrls { get; set; }

        /// <summary>
        /// List of locales to filter with during discovery
        /// </summary>
        [DataMember(Name = "Locales",
            EmitDefaultValue = false)]
        public List<string> Locales { get; set; }

        /// <summary>
        /// Activate all twins with this filter during onboarding.
        /// </summary>
        [DataMember(Name = "ActivationFilter",
            EmitDefaultValue = false)]
        public EndpointActivationFilterApiModel ActivationFilter { get; set; }
    }
}
