// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Twin.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of node browse continuation
    /// </summary>
    public partial class BrowseNextResponseApiModel
    {
        /// <summary>
        /// Initializes a new instance of the BrowseNextResponseApiModel class.
        /// </summary>
        public BrowseNextResponseApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BrowseNextResponseApiModel class.
        /// </summary>
        /// <param name="references">References, if included, otherwise
        /// null.</param>
        /// <param name="continuationToken">Continuation token if more results
        /// pending.</param>
        public BrowseNextResponseApiModel(IList<NodeReferenceApiModel> references = default(IList<NodeReferenceApiModel>), string continuationToken = default(string), ServiceResultApiModel errorInfo = default(ServiceResultApiModel))
        {
            References = references;
            ContinuationToken = continuationToken;
            ErrorInfo = errorInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets references, if included, otherwise null.
        /// </summary>
        [JsonProperty(PropertyName = "references")]
        public IList<NodeReferenceApiModel> References { get; set; }

        /// <summary>
        /// Gets or sets continuation token if more results pending.
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorInfo")]
        public ServiceResultApiModel ErrorInfo { get; set; }

    }
}
