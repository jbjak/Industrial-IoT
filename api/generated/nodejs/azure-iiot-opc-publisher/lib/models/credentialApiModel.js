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
 * Credential model
 *
 */
class CredentialApiModel {
  /**
   * Create a CredentialApiModel.
   * @property {string} [type] Type of credential. Possible values include:
   * 'None', 'UserName', 'X509Certificate', 'JwtToken'
   * @property {object} [value] Value to pass to server
   */
  constructor() {
  }

  /**
   * Defines the metadata of CredentialApiModel
   *
   * @returns {object} metadata of CredentialApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'CredentialApiModel',
      type: {
        name: 'Composite',
        className: 'CredentialApiModel',
        modelProperties: {
          type: {
            required: false,
            serializedName: 'type',
            type: {
              name: 'Enum',
              allowedValues: [ 'None', 'UserName', 'X509Certificate', 'JwtToken' ]
            }
          },
          value: {
            required: false,
            serializedName: 'value',
            type: {
              name: 'Object'
            }
          }
        }
      }
    };
  }
}

module.exports = CredentialApiModel;