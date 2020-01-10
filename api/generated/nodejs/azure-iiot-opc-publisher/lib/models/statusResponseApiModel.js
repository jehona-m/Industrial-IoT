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
 * Status response model
 *
 */
class StatusResponseApiModel {
  /**
   * Create a StatusResponseApiModel.
   * @property {string} [name] Name of this service
   * @property {string} [status] Operational status
   * @property {string} [currentTime] Current time
   * @property {string} [startTime] Start time of service
   * @property {number} [upTime] Up time of service
   * @property {string} [uid] Value generated at bootstrap by each instance of
   * the service and
   * used to correlate logs coming from the same instance. The value
   * changes every time the service starts.
   * @property {object} [properties] A property bag with details about the
   * service
   * @property {object} [dependencies] A property bag with details about the
   * internal dependencies
   * @property {object} [metadata]
   */
  constructor() {
  }

  /**
   * Defines the metadata of StatusResponseApiModel
   *
   * @returns {object} metadata of StatusResponseApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'StatusResponseApiModel',
      type: {
        name: 'Composite',
        className: 'StatusResponseApiModel',
        modelProperties: {
          name: {
            required: false,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          },
          status: {
            required: false,
            serializedName: 'status',
            type: {
              name: 'String'
            }
          },
          currentTime: {
            required: false,
            readOnly: true,
            serializedName: 'currentTime',
            type: {
              name: 'String'
            }
          },
          startTime: {
            required: false,
            readOnly: true,
            serializedName: 'startTime',
            type: {
              name: 'String'
            }
          },
          upTime: {
            required: false,
            readOnly: true,
            serializedName: 'upTime',
            type: {
              name: 'Number'
            }
          },
          uid: {
            required: false,
            readOnly: true,
            serializedName: 'uid',
            type: {
              name: 'String'
            }
          },
          properties: {
            required: false,
            readOnly: true,
            serializedName: 'properties',
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          },
          dependencies: {
            required: false,
            readOnly: true,
            serializedName: 'dependencies',
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          },
          metadata: {
            required: false,
            readOnly: true,
            serializedName: '$metadata',
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          }
        }
      }
    };
  }
}

module.exports = StatusResponseApiModel;
