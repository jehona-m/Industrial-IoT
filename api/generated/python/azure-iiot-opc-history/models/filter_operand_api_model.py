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


class FilterOperandApiModel(Model):
    """Filter operand.

    :param index: Element reference in the outer list if
     operand is an element operand
    :type index: int
    :param value: Variant value if operand is a literal
    :type value: object
    :param node_id: Type definition node id if operand is
     simple or full attribute operand.
    :type node_id: str
    :param browse_path: Browse path of attribute operand
    :type browse_path: list[str]
    :param attribute_id: Possible values include: 'NodeClass', 'BrowseName',
     'DisplayName', 'Description', 'WriteMask', 'UserWriteMask', 'IsAbstract',
     'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier', 'Value',
     'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel',
     'UserAccessLevel', 'MinimumSamplingInterval', 'Historizing', 'Executable',
     'UserExecutable', 'DataTypeDefinition', 'RolePermissions',
     'UserRolePermissions', 'AccessRestrictions'
    :type attribute_id: str or ~azure-iiot-opc-history.models.NodeAttribute
    :param index_range: Index range of attribute operand
    :type index_range: str
    :param alias: Optional alias to refer to it makeing it a
     full blown attribute operand
    :type alias: str
    """

    _attribute_map = {
        'index': {'key': 'index', 'type': 'int'},
        'value': {'key': 'value', 'type': 'object'},
        'node_id': {'key': 'nodeId', 'type': 'str'},
        'browse_path': {'key': 'browsePath', 'type': '[str]'},
        'attribute_id': {'key': 'attributeId', 'type': 'NodeAttribute'},
        'index_range': {'key': 'indexRange', 'type': 'str'},
        'alias': {'key': 'alias', 'type': 'str'},
    }

    def __init__(self, index=None, value=None, node_id=None, browse_path=None, attribute_id=None, index_range=None, alias=None):
        super(FilterOperandApiModel, self).__init__()
        self.index = index
        self.value = value
        self.node_id = node_id
        self.browse_path = browse_path
        self.attribute_id = attribute_id
        self.index_range = index_range
        self.alias = alias
