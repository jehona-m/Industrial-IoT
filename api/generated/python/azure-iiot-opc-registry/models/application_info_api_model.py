# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 2.3.33.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class ApplicationInfoApiModel(Model):
    """Application info model.

    :param application_id: Unique application id
    :type application_id: str
    :param application_type: Possible values include: 'Server', 'Client',
     'ClientAndServer', 'DiscoveryServer'
    :type application_type: str or
     ~azure-iiot-opc-registry.models.ApplicationType
    :param application_uri: Unique application uri
    :type application_uri: str
    :param product_uri: Product uri
    :type product_uri: str
    :param application_name: Default name of application
    :type application_name: str
    :param locale: Locale of default name - defaults to "en"
    :type locale: str
    :param localized_names: Localized Names of application keyed on locale
    :type localized_names: dict[str, str]
    :param certificate: Application public cert
    :type certificate: bytearray
    :param capabilities: The capabilities advertised by the server.
    :type capabilities: list[str]
    :param discovery_urls: Discovery urls of the server
    :type discovery_urls: list[str]
    :param discovery_profile_uri: Discovery profile uri
    :type discovery_profile_uri: str
    :param gateway_server_uri: Gateway server uri
    :type gateway_server_uri: str
    :param host_addresses: Host addresses of server application or null
    :type host_addresses: list[str]
    :param site_id: Site of the application
    :type site_id: str
    :param discoverer_id: Discoverer that registered the application
    :type discoverer_id: str
    :param not_seen_since: Last time application was seen
    :type not_seen_since: datetime
    :param created:
    :type created: ~azure-iiot-opc-registry.models.RegistryOperationApiModel
    :param updated:
    :type updated: ~azure-iiot-opc-registry.models.RegistryOperationApiModel
    """

    _validation = {
        'capabilities': {'unique': True},
        'discovery_urls': {'unique': True},
        'host_addresses': {'unique': True},
    }

    _attribute_map = {
        'application_id': {'key': 'applicationId', 'type': 'str'},
        'application_type': {'key': 'applicationType', 'type': 'ApplicationType'},
        'application_uri': {'key': 'applicationUri', 'type': 'str'},
        'product_uri': {'key': 'productUri', 'type': 'str'},
        'application_name': {'key': 'applicationName', 'type': 'str'},
        'locale': {'key': 'locale', 'type': 'str'},
        'localized_names': {'key': 'localizedNames', 'type': '{str}'},
        'certificate': {'key': 'certificate', 'type': 'bytearray'},
        'capabilities': {'key': 'capabilities', 'type': '[str]'},
        'discovery_urls': {'key': 'discoveryUrls', 'type': '[str]'},
        'discovery_profile_uri': {'key': 'discoveryProfileUri', 'type': 'str'},
        'gateway_server_uri': {'key': 'gatewayServerUri', 'type': 'str'},
        'host_addresses': {'key': 'hostAddresses', 'type': '[str]'},
        'site_id': {'key': 'siteId', 'type': 'str'},
        'discoverer_id': {'key': 'discovererId', 'type': 'str'},
        'not_seen_since': {'key': 'notSeenSince', 'type': 'iso-8601'},
        'created': {'key': 'created', 'type': 'RegistryOperationApiModel'},
        'updated': {'key': 'updated', 'type': 'RegistryOperationApiModel'},
    }

    def __init__(self, application_id=None, application_type=None, application_uri=None, product_uri=None, application_name=None, locale=None, localized_names=None, certificate=None, capabilities=None, discovery_urls=None, discovery_profile_uri=None, gateway_server_uri=None, host_addresses=None, site_id=None, discoverer_id=None, not_seen_since=None, created=None, updated=None):
        super(ApplicationInfoApiModel, self).__init__()
        self.application_id = application_id
        self.application_type = application_type
        self.application_uri = application_uri
        self.product_uri = product_uri
        self.application_name = application_name
        self.locale = locale
        self.localized_names = localized_names
        self.certificate = certificate
        self.capabilities = capabilities
        self.discovery_urls = discovery_urls
        self.discovery_profile_uri = discovery_profile_uri
        self.gateway_server_uri = gateway_server_uri
        self.host_addresses = host_addresses
        self.site_id = site_id
        self.discoverer_id = discoverer_id
        self.not_seen_since = not_seen_since
        self.created = created
        self.updated = updated
