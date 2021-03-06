# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.twin
  module Models
    #
    # Call request model
    #
    class MethodCallRequestApiModel
      # @return [String] Method id of method to call.
      attr_accessor :method_id

      # @return [String] Context of the method, i.e. an object or object type
      # node.
      attr_accessor :object_id

      # @return [Array<MethodCallArgumentApiModel>] Arguments for the method -
      # null means no args
      attr_accessor :arguments

      # @return [Array<String>] An optional component path from the node
      # identified by
      # MethodId or from a resolved objectId to the actual
      # method node.
      attr_accessor :method_browse_path

      # @return [Array<String>] An optional component path from the node
      # identified by
      # ObjectId to the actual object or objectType node.
      # If ObjectId is null, the root node (i=84) is used.
      attr_accessor :object_browse_path

      # @return [RequestHeaderApiModel] Optional request header
      attr_accessor :header


      #
      # Mapper for MethodCallRequestApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'MethodCallRequestApiModel',
          type: {
            name: 'Composite',
            class_name: 'MethodCallRequestApiModel',
            model_properties: {
              method_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'methodId',
                type: {
                  name: 'String'
                }
              },
              object_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'objectId',
                type: {
                  name: 'String'
                }
              },
              arguments: {
                client_side_validation: true,
                required: false,
                serialized_name: 'arguments',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'MethodCallArgumentApiModelElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'MethodCallArgumentApiModel'
                      }
                  }
                }
              },
              method_browse_path: {
                client_side_validation: true,
                required: false,
                serialized_name: 'methodBrowsePath',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              object_browse_path: {
                client_side_validation: true,
                required: false,
                serialized_name: 'objectBrowsePath',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              header: {
                client_side_validation: true,
                required: false,
                serialized_name: 'header',
                type: {
                  name: 'Composite',
                  class_name: 'RequestHeaderApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
