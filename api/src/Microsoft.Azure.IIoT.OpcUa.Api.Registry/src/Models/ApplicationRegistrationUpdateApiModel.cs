// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Registry.Models {
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Application registration update request
    /// </summary>
    public class ApplicationRegistrationUpdateApiModel {

        /// <summary>
        /// Product uri
        /// </summary>
        [JsonProperty(PropertyName = "productUri",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ProductUri { get; set; }

        /// <summary>
        /// Default name of the application
        /// </summary>
        [JsonProperty(PropertyName = "applicationName",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Locale of default name - defaults to "en"
        /// </summary>
        [JsonProperty(PropertyName = "locale",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// Localized names of application keyed on locale.
        /// Set value to null to remove loc entry.
        /// </summary>
        [JsonProperty(PropertyName = "localizedNames",
            NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> LocalizedNames { get; set; }

        /// <summary>
        /// Application public cert
        /// </summary>
        [JsonProperty(PropertyName = "certificate",
            NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Certificate { get; set; }

        /// <summary>
        /// Capabilities of the application
        /// </summary>
        [JsonProperty(PropertyName = "capabilities",
            NullValueHandling = NullValueHandling.Ignore)]
        public HashSet<string> Capabilities { get; set; }

        /// <summary>
        /// Discovery urls of the application
        /// </summary>
        [JsonProperty(PropertyName = "discoveryUrls",
            NullValueHandling = NullValueHandling.Ignore)]
        public HashSet<string> DiscoveryUrls { get; set; }

        /// <summary>
        /// Discovery profile uri
        /// </summary>
        [JsonProperty(PropertyName = "discoveryProfileUri",
            NullValueHandling = NullValueHandling.Ignore)]
        public string DiscoveryProfileUri { get; set; }

        /// <summary>
        /// Gateway server uri
        /// </summary>
        [JsonProperty(PropertyName = "gatewayServerUri",
            NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayServerUri { get; set; }
    }
}
