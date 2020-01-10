# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.registry
  module Models
    #
    # Discovery configuration
    #
    class DiscoveryConfigApiModel
      # @return [String] Address ranges to scan (null == all wired nics)
      attr_accessor :address_ranges_to_scan

      # @return [Integer] Network probe timeout
      attr_accessor :network_probe_timeout_ms

      # @return [Integer] Max network probes that should ever run.
      attr_accessor :max_network_probes

      # @return [String] Port ranges to scan (null == all unassigned)
      attr_accessor :port_ranges_to_scan

      # @return [Integer] Port probe timeout
      attr_accessor :port_probe_timeout_ms

      # @return [Integer] Max port probes that should ever run.
      attr_accessor :max_port_probes

      # @return [Integer] Probes that must always be there as percent of max.
      attr_accessor :min_port_probes_percent

      # @return [Integer] Delay time between discovery sweeps in seconds
      attr_accessor :idle_time_between_scans_sec

      # @return [Array<String>] List of preset discovery urls to use
      attr_accessor :discovery_urls

      # @return [Array<String>] List of locales to filter with during discovery
      attr_accessor :locales

      # @return [EndpointActivationFilterApiModel]
      attr_accessor :activation_filter


      #
      # Mapper for DiscoveryConfigApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'DiscoveryConfigApiModel',
          type: {
            name: 'Composite',
            class_name: 'DiscoveryConfigApiModel',
            model_properties: {
              address_ranges_to_scan: {
                client_side_validation: true,
                required: false,
                serialized_name: 'addressRangesToScan',
                type: {
                  name: 'String'
                }
              },
              network_probe_timeout_ms: {
                client_side_validation: true,
                required: false,
                serialized_name: 'networkProbeTimeoutMs',
                type: {
                  name: 'Number'
                }
              },
              max_network_probes: {
                client_side_validation: true,
                required: false,
                serialized_name: 'maxNetworkProbes',
                type: {
                  name: 'Number'
                }
              },
              port_ranges_to_scan: {
                client_side_validation: true,
                required: false,
                serialized_name: 'portRangesToScan',
                type: {
                  name: 'String'
                }
              },
              port_probe_timeout_ms: {
                client_side_validation: true,
                required: false,
                serialized_name: 'portProbeTimeoutMs',
                type: {
                  name: 'Number'
                }
              },
              max_port_probes: {
                client_side_validation: true,
                required: false,
                serialized_name: 'maxPortProbes',
                type: {
                  name: 'Number'
                }
              },
              min_port_probes_percent: {
                client_side_validation: true,
                required: false,
                serialized_name: 'minPortProbesPercent',
                type: {
                  name: 'Number'
                }
              },
              idle_time_between_scans_sec: {
                client_side_validation: true,
                required: false,
                serialized_name: 'idleTimeBetweenScansSec',
                type: {
                  name: 'Number'
                }
              },
              discovery_urls: {
                client_side_validation: true,
                required: false,
                serialized_name: 'discoveryUrls',
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
              locales: {
                client_side_validation: true,
                required: false,
                serialized_name: 'locales',
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
              activation_filter: {
                client_side_validation: true,
                required: false,
                serialized_name: 'activationFilter',
                type: {
                  name: 'Composite',
                  class_name: 'EndpointActivationFilterApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
