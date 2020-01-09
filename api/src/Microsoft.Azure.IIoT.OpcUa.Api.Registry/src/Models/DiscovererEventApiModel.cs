﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Registry.Models {
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Discoverer event type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiscovererEventType {

        /// <summary>
        /// New
        /// </summary>
        New,

        /// <summary>
        /// Updated
        /// </summary>
        Updated,

        /// <summary>
        /// Connected
        /// </summary>
        Connected,

        /// <summary>
        /// Disconnected
        /// </summary>
        Disconnected,

        /// <summary>
        /// Deleted
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Discoverer event
    /// </summary>
    public class DiscovererEventApiModel {

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public DiscovererEventType EventType { get; set; }

        /// <summary>
        /// Discoverer
        /// </summary>
        [JsonProperty(PropertyName = "discoverer",
            NullValueHandling = NullValueHandling.Ignore)]
        public DiscovererApiModel Discoverer { get; set; }
    }
}