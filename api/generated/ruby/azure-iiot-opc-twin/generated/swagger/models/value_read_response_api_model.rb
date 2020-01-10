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
    # Value read response model
    #
    class ValueReadResponseApiModel
      # @return Value read
      attr_accessor :value

      # @return [String] Built in data type of the value read.
      attr_accessor :data_type

      # @return [Integer] Pico seconds part of when value was read at source.
      attr_accessor :source_picoseconds

      # @return [DateTime] Timestamp of when value was read at source.
      attr_accessor :source_timestamp

      # @return [Integer] Pico seconds part of when value was read at server.
      attr_accessor :server_picoseconds

      # @return [DateTime] Timestamp of when value was read at server.
      attr_accessor :server_timestamp

      # @return [ServiceResultApiModel]
      attr_accessor :error_info


      #
      # Mapper for ValueReadResponseApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'ValueReadResponseApiModel',
          type: {
            name: 'Composite',
            class_name: 'ValueReadResponseApiModel',
            model_properties: {
              value: {
                client_side_validation: true,
                required: false,
                serialized_name: 'value',
                type: {
                  name: 'Object'
                }
              },
              data_type: {
                client_side_validation: true,
                required: false,
                serialized_name: 'dataType',
                type: {
                  name: 'String'
                }
              },
              source_picoseconds: {
                client_side_validation: true,
                required: false,
                serialized_name: 'sourcePicoseconds',
                type: {
                  name: 'Number'
                }
              },
              source_timestamp: {
                client_side_validation: true,
                required: false,
                serialized_name: 'sourceTimestamp',
                type: {
                  name: 'DateTime'
                }
              },
              server_picoseconds: {
                client_side_validation: true,
                required: false,
                serialized_name: 'serverPicoseconds',
                type: {
                  name: 'Number'
                }
              },
              server_timestamp: {
                client_side_validation: true,
                required: false,
                serialized_name: 'serverTimestamp',
                type: {
                  name: 'DateTime'
                }
              },
              error_info: {
                client_side_validation: true,
                required: false,
                serialized_name: 'errorInfo',
                type: {
                  name: 'Composite',
                  class_name: 'ServiceResultApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
