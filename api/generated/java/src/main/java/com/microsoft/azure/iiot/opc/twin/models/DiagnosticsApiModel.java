/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.twin.models;

import org.joda.time.DateTime;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Diagnostics configuration.
 */
public class DiagnosticsApiModel {
    /**
     * Requested level of response diagnostics.
     * (default: Status). Possible values include: 'None', 'Status',
     * 'Operations', 'Diagnostics', 'Verbose'.
     */
    @JsonProperty(value = "level")
    private DiagnosticsLevel level;

    /**
     * Client audit log entry.
     * (default: client generated).
     */
    @JsonProperty(value = "auditId")
    private String auditId;

    /**
     * Timestamp of request.
     * (default: client generated).
     */
    @JsonProperty(value = "timeStamp")
    private DateTime timeStamp;

    /**
     * Get requested level of response diagnostics.
     (default: Status). Possible values include: 'None', 'Status', 'Operations', 'Diagnostics', 'Verbose'.
     *
     * @return the level value
     */
    public DiagnosticsLevel level() {
        return this.level;
    }

    /**
     * Set requested level of response diagnostics.
     (default: Status). Possible values include: 'None', 'Status', 'Operations', 'Diagnostics', 'Verbose'.
     *
     * @param level the level value to set
     * @return the DiagnosticsApiModel object itself.
     */
    public DiagnosticsApiModel withLevel(DiagnosticsLevel level) {
        this.level = level;
        return this;
    }

    /**
     * Get client audit log entry.
     (default: client generated).
     *
     * @return the auditId value
     */
    public String auditId() {
        return this.auditId;
    }

    /**
     * Set client audit log entry.
     (default: client generated).
     *
     * @param auditId the auditId value to set
     * @return the DiagnosticsApiModel object itself.
     */
    public DiagnosticsApiModel withAuditId(String auditId) {
        this.auditId = auditId;
        return this;
    }

    /**
     * Get timestamp of request.
     (default: client generated).
     *
     * @return the timeStamp value
     */
    public DateTime timeStamp() {
        return this.timeStamp;
    }

    /**
     * Set timestamp of request.
     (default: client generated).
     *
     * @param timeStamp the timeStamp value to set
     * @return the DiagnosticsApiModel object itself.
     */
    public DiagnosticsApiModel withTimeStamp(DateTime timeStamp) {
        this.timeStamp = timeStamp;
        return this;
    }

}
