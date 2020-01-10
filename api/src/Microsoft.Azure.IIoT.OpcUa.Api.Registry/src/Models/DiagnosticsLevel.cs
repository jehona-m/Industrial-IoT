﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Registry.Models {
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Level of diagnostics requested in responses
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiagnosticsLevel {

        /// <summary>
        /// Include no diagnostics in response
        /// </summary>
        None = 0,

        /// <summary>
        /// Include only status text as array (default)
        /// </summary>
        Status = 1,

        /// <summary>
        /// Include status and operations trace.
        /// </summary>
        Operations = 10,

        /// <summary>
        /// Include diagnostics
        /// </summary>
        Diagnostics = 50,

        /// <summary>
        /// Include full diagnostics trace.
        /// </summary>
        Verbose = 100
    }
}
