// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Registry {
    using Microsoft.Azure.IIoT.OpcUa.Registry.Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Endpoint registry
    /// </summary>
    public interface IEndpointRegistry {

        /// <summary>
        /// Get all endpoints in paged form
        /// </summary>
        /// <param name="onlyServerState">Whether only
        /// desired endpoint state should be returned.
        /// </param>
        /// <param name="continuation"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<EndpointInfoListModel> ListEndpointsAsync(string continuation,
            bool onlyServerState = false, int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Find registration of the supplied endpoint.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="onlyServerState">Whether only
        /// desired endpoint state should be returned.
        /// </param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<EndpointInfoListModel> QueryEndpointsAsync(
            EndpointRegistrationQueryModel query,
            bool onlyServerState = false, int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Get endpoint registration by identifer.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="onlyServerState">Whether only
        /// desired endpoint state should be returned.
        /// </param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<EndpointInfoModel> GetEndpointAsync(string endpointId,
            bool onlyServerState = false,
            CancellationToken ct = default);

        /// <summary>
        /// Set the endpoint state to activated
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="context"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task ActivateEndpointAsync(string endpointId,
            RegistryOperationContextModel context = null,
            CancellationToken ct = default);

        /// <summary>
        /// Update existing server endpoint registration.
        /// Id and url field in request must not be null and
        /// endpoint registration must exist.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UpdateEndpointAsync(string endpointId,
            EndpointRegistrationUpdateModel request,
            CancellationToken ct = default);

        /// <summary>
        /// Set the endpoint state to deactivated
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="context"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeactivateEndpointAsync(string endpointId,
            RegistryOperationContextModel context = null,
            CancellationToken ct = default);
    }
}
