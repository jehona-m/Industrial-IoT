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
 * Result of node browse continuation
 *
 */
class BrowsePathResponseApiModel {
  /**
   * Create a BrowsePathResponseApiModel.
   * @property {array} [targets] Targets
   * @property {object} [errorInfo]
   * @property {number} [errorInfo.statusCode] Error code - if null operation
   * succeeded.
   * @property {string} [errorInfo.errorMessage] Error message in case of error
   * or null.
   * @property {object} [errorInfo.diagnostics] Additional diagnostics
   * information
   */
  constructor() {
  }

  /**
   * Defines the metadata of BrowsePathResponseApiModel
   *
   * @returns {object} metadata of BrowsePathResponseApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'BrowsePathResponseApiModel',
      type: {
        name: 'Composite',
        className: 'BrowsePathResponseApiModel',
        modelProperties: {
          targets: {
            required: false,
            serializedName: 'targets',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'NodePathTargetApiModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'NodePathTargetApiModel'
                  }
              }
            }
          },
          errorInfo: {
            required: false,
            serializedName: 'errorInfo',
            type: {
              name: 'Composite',
              className: 'ServiceResultApiModel'
            }
          }
        }
      }
    };
  }
}

module.exports = BrowsePathResponseApiModel;
