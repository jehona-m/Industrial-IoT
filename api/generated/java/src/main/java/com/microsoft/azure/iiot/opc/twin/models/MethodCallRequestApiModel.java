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

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Call request model.
 */
public class MethodCallRequestApiModel {
    /**
     * Method id of method to call.
     */
    @JsonProperty(value = "methodId")
    private String methodId;

    /**
     * Context of the method, i.e. an object or object type
     * node.
     */
    @JsonProperty(value = "objectId")
    private String objectId;

    /**
     * Arguments for the method - null means no args.
     */
    @JsonProperty(value = "arguments")
    private List<MethodCallArgumentApiModel> arguments;

    /**
     * An optional component path from the node identified by
     * MethodId or from a resolved objectId to the actual
     * method node.
     */
    @JsonProperty(value = "methodBrowsePath")
    private List<String> methodBrowsePath;

    /**
     * An optional component path from the node identified by
     * ObjectId to the actual object or objectType node.
     * If ObjectId is null, the root node (i=84) is used.
     */
    @JsonProperty(value = "objectBrowsePath")
    private List<String> objectBrowsePath;

    /**
     * The headerProperty property.
     */
    @JsonProperty(value = "header")
    private RequestHeaderApiModel headerProperty;

    /**
     * Get method id of method to call.
     *
     * @return the methodId value
     */
    public String methodId() {
        return this.methodId;
    }

    /**
     * Set method id of method to call.
     *
     * @param methodId the methodId value to set
     * @return the MethodCallRequestApiModel object itself.
     */
    public MethodCallRequestApiModel withMethodId(String methodId) {
        this.methodId = methodId;
        return this;
    }

    /**
     * Get context of the method, i.e. an object or object type
     node.
     *
     * @return the objectId value
     */
    public String objectId() {
        return this.objectId;
    }

    /**
     * Set context of the method, i.e. an object or object type
     node.
     *
     * @param objectId the objectId value to set
     * @return the MethodCallRequestApiModel object itself.
     */
    public MethodCallRequestApiModel withObjectId(String objectId) {
        this.objectId = objectId;
        return this;
    }

    /**
     * Get arguments for the method - null means no args.
     *
     * @return the arguments value
     */
    public List<MethodCallArgumentApiModel> arguments() {
        return this.arguments;
    }

    /**
     * Set arguments for the method - null means no args.
     *
     * @param arguments the arguments value to set
     * @return the MethodCallRequestApiModel object itself.
     */
    public MethodCallRequestApiModel withArguments(List<MethodCallArgumentApiModel> arguments) {
        this.arguments = arguments;
        return this;
    }

    /**
     * Get an optional component path from the node identified by
     MethodId or from a resolved objectId to the actual
     method node.
     *
     * @return the methodBrowsePath value
     */
    public List<String> methodBrowsePath() {
        return this.methodBrowsePath;
    }

    /**
     * Set an optional component path from the node identified by
     MethodId or from a resolved objectId to the actual
     method node.
     *
     * @param methodBrowsePath the methodBrowsePath value to set
     * @return the MethodCallRequestApiModel object itself.
     */
    public MethodCallRequestApiModel withMethodBrowsePath(List<String> methodBrowsePath) {
        this.methodBrowsePath = methodBrowsePath;
        return this;
    }

    /**
     * Get an optional component path from the node identified by
     ObjectId to the actual object or objectType node.
     If ObjectId is null, the root node (i=84) is used.
     *
     * @return the objectBrowsePath value
     */
    public List<String> objectBrowsePath() {
        return this.objectBrowsePath;
    }

    /**
     * Set an optional component path from the node identified by
     ObjectId to the actual object or objectType node.
     If ObjectId is null, the root node (i=84) is used.
     *
     * @param objectBrowsePath the objectBrowsePath value to set
     * @return the MethodCallRequestApiModel object itself.
     */
    public MethodCallRequestApiModel withObjectBrowsePath(List<String> objectBrowsePath) {
        this.objectBrowsePath = objectBrowsePath;
        return this;
    }

    /**
     * Get the headerProperty value.
     *
     * @return the headerProperty value
     */
    public RequestHeaderApiModel headerProperty() {
        return this.headerProperty;
    }

    /**
     * Set the headerProperty value.
     *
     * @param headerProperty the headerProperty value to set
     * @return the MethodCallRequestApiModel object itself.
     */
    public MethodCallRequestApiModel withHeaderProperty(RequestHeaderApiModel headerProperty) {
        this.headerProperty = headerProperty;
        return this;
    }

}
