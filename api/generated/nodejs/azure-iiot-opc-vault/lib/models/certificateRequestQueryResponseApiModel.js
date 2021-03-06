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
 * Response model
 *
 */
class CertificateRequestQueryResponseApiModel {
  /**
   * Create a CertificateRequestQueryResponseApiModel.
   * @property {array} [requests] The query result.
   * @property {string} [nextPageLink] Link to the next page of results.
   */
  constructor() {
  }

  /**
   * Defines the metadata of CertificateRequestQueryResponseApiModel
   *
   * @returns {object} metadata of CertificateRequestQueryResponseApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'CertificateRequestQueryResponseApiModel',
      type: {
        name: 'Composite',
        className: 'CertificateRequestQueryResponseApiModel',
        modelProperties: {
          requests: {
            required: false,
            serializedName: 'requests',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'CertificateRequestRecordApiModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'CertificateRequestRecordApiModel'
                  }
              }
            }
          },
          nextPageLink: {
            required: false,
            serializedName: 'nextPageLink',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = CertificateRequestQueryResponseApiModel;
