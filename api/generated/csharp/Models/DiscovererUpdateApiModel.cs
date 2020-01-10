// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Registry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Discoverer update request
    /// </summary>
    public partial class DiscovererUpdateApiModel
    {
        /// <summary>
        /// Initializes a new instance of the DiscovererUpdateApiModel class.
        /// </summary>
        public DiscovererUpdateApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiscovererUpdateApiModel class.
        /// </summary>
        /// <param name="siteId">Site the discoverer is part of</param>
        /// <param name="discovery">Possible values include: 'Off', 'Local',
        /// 'Network', 'Fast', 'Scan'</param>
        /// <param name="logLevel">Possible values include: 'Error',
        /// 'Information', 'Debug', 'Verbose'</param>
        public DiscovererUpdateApiModel(string siteId = default(string), DiscoveryMode? discovery = default(DiscoveryMode?), DiscoveryConfigApiModel discoveryConfig = default(DiscoveryConfigApiModel), TraceLogLevel? logLevel = default(TraceLogLevel?))
        {
            SiteId = siteId;
            Discovery = discovery;
            DiscoveryConfig = discoveryConfig;
            LogLevel = logLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets site the discoverer is part of
        /// </summary>
        [JsonProperty(PropertyName = "siteId")]
        public string SiteId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Off', 'Local', 'Network',
        /// 'Fast', 'Scan'
        /// </summary>
        [JsonProperty(PropertyName = "discovery")]
        public DiscoveryMode? Discovery { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discoveryConfig")]
        public DiscoveryConfigApiModel DiscoveryConfig { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Error', 'Information',
        /// 'Debug', 'Verbose'
        /// </summary>
        [JsonProperty(PropertyName = "logLevel")]
        public TraceLogLevel? LogLevel { get; set; }

    }
}
