/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Endpoint registration model
 *
 */
class EndpointRegistrationApiModel {
  /**
   * Create a EndpointRegistrationApiModel.
   * @property {string} id Registered identifier of the endpoint
   * @property {string} [endpointUrl] Original endpoint url of the endpoint
   * @property {string} [siteId] Registered site of the endpoint
   * @property {object} endpoint Endpoint information of the registration
   * @property {string} [endpoint.url] Endpoint url to use to connect with
   * @property {array} [endpoint.alternativeUrls] Alternative endpoint urls
   * that can be used for
   * accessing and validating the server
   * @property {object} [endpoint.user] User Authentication
   * @property {string} [endpoint.user.type] Type of credential. Possible
   * values include: 'None', 'UserName', 'X509Certificate', 'JwtToken'
   * @property {object} [endpoint.user.value] Value to pass to server
   * @property {string} [endpoint.securityMode] Security Mode to use for
   * communication
   * default to best. Possible values include: 'Best', 'Sign',
   * 'SignAndEncrypt', 'None'
   * @property {string} [endpoint.securityPolicy] Security policy uri to use
   * for communication
   * default to best.
   * @property {buffer} [endpoint.certificate] Endpoint certificate that was
   * registered.
   * @property {number} [securityLevel] Security level of the endpoint
   * @property {array} [authenticationMethods] Supported authentication methods
   * that can be selected to
   * obtain a credential and used to interact with the endpoint.
   */
  constructor() {
  }

  /**
   * Defines the metadata of EndpointRegistrationApiModel
   *
   * @returns {object} metadata of EndpointRegistrationApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'EndpointRegistrationApiModel',
      type: {
        name: 'Composite',
        className: 'EndpointRegistrationApiModel',
        modelProperties: {
          id: {
            required: true,
            serializedName: 'id',
            type: {
              name: 'String'
            }
          },
          endpointUrl: {
            required: false,
            serializedName: 'endpointUrl',
            type: {
              name: 'String'
            }
          },
          siteId: {
            required: false,
            serializedName: 'siteId',
            type: {
              name: 'String'
            }
          },
          endpoint: {
            required: true,
            serializedName: 'endpoint',
            type: {
              name: 'Composite',
              className: 'EndpointApiModel'
            }
          },
          securityLevel: {
            required: false,
            serializedName: 'securityLevel',
            type: {
              name: 'Number'
            }
          },
          authenticationMethods: {
            required: false,
            serializedName: 'authenticationMethods',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'AuthenticationMethodApiModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'AuthenticationMethodApiModel'
                  }
              }
            }
          }
        }
      }
    };
  }
}

module.exports = EndpointRegistrationApiModel;
