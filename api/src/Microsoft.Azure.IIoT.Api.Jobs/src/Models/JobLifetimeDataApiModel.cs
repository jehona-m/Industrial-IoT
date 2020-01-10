﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Api.Jobs.Models {
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lifetime data
    /// </summary>
    public class JobLifetimeDataApiModel {

        /// <summary>
        /// Status
        /// </summary>

        public JobStatus Status { get; set; }

        /// <summary>
        /// Processing status
        /// </summary>
        public Dictionary<string, ProcessingStatusApiModel> ProcessingStatus { get; set; }

        /// <summary>
        /// Updated at
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Created at
        /// </summary>
        public DateTime Created { get; set; }
    }
}