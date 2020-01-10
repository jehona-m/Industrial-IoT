/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.registry.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Discoverer registration list.
 */
public class DiscovererListApiModel {
    /**
     * Registrations.
     */
    @JsonProperty(value = "items")
    private List<DiscovererApiModel> items;

    /**
     * Continuation or null if final.
     */
    @JsonProperty(value = "continuationToken")
    private String continuationToken;

    /**
     * Get registrations.
     *
     * @return the items value
     */
    public List<DiscovererApiModel> items() {
        return this.items;
    }

    /**
     * Set registrations.
     *
     * @param items the items value to set
     * @return the DiscovererListApiModel object itself.
     */
    public DiscovererListApiModel withItems(List<DiscovererApiModel> items) {
        this.items = items;
        return this;
    }

    /**
     * Get continuation or null if final.
     *
     * @return the continuationToken value
     */
    public String continuationToken() {
        return this.continuationToken;
    }

    /**
     * Set continuation or null if final.
     *
     * @param continuationToken the continuationToken value to set
     * @return the DiscovererListApiModel object itself.
     */
    public DiscovererListApiModel withContinuationToken(String continuationToken) {
        this.continuationToken = continuationToken;
        return this;
    }

}
