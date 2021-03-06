/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.history.models;

import java.util.List;
import org.joda.time.DateTime;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Deletes data at times.
 */
public class DeleteValuesAtTimesDetailsApiModel {
    /**
     * The timestamps to delete.
     */
    @JsonProperty(value = "reqTimes", required = true)
    private List<DateTime> reqTimes;

    /**
     * Get the timestamps to delete.
     *
     * @return the reqTimes value
     */
    public List<DateTime> reqTimes() {
        return this.reqTimes;
    }

    /**
     * Set the timestamps to delete.
     *
     * @param reqTimes the reqTimes value to set
     * @return the DeleteValuesAtTimesDetailsApiModel object itself.
     */
    public DeleteValuesAtTimesDetailsApiModel withReqTimes(List<DateTime> reqTimes) {
        this.reqTimes = reqTimes;
        return this;
    }

}
