# Yaksa.OrckestraCommerce.Client.Model.CreateProductAttributeRequest
Metadata are entities which represents additional definitions and attribute information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMultipleSelection** | **bool** | A value indicating whether multiple values can be specified. Applicable only for attributes of type &#39;Lookup&#39;. | [optional] 
**DataType** | **string** | The data type of this attribute | [optional] 
**DefaultValue** | [**ValueTypeWrapper**](ValueTypeWrapper.md) |  | [optional] 
**Description** | **string** | The description of the attribute | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**GroupName** | **string** | The ID of the attribute group, if the attribute is associated to a group | [optional] 
**IncludeInAllCategoryDefinition** | **bool** | A value indicating whether the attribute will be automatically returned with all Category definitions of the system | [optional] 
**IncludeInAllProductDefinition** | **bool** | A value indicating whether the attribute will be automatically returned with all Product definitions of the system | [optional] 
**IncludeInAllVariantDefinition** | **bool** | A value indicating whether or not the attribute should be automatically included in variant definitions of the system | [optional] 
**IsHiddenInOrchestrator** | **bool** | A value indicating whether this instance is hidden in the orchestrator | [optional] 
**IsRequired** | **bool** | A value indicating whether a value is required for this attribute | [optional] 
**Localizable** | **bool** | A value indicating whether this attribute is localizable and a distinct value can be specified for different cultures | [optional] 
**LookupName** | **string** | The name of the lookup type. Applicable only for attributes of type &#39;Lookup&#39;. | [optional] 
**MaximumValue** | [**ValueTypeWrapper**](ValueTypeWrapper.md) |  | [optional] 
**MinimumValue** | [**ValueTypeWrapper**](ValueTypeWrapper.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

