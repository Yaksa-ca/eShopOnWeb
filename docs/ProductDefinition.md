# Yaksa.OrckestraCommerce.Client.Model.ProductDefinition
ProductDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowPriceLists** | **bool** | Whether the entity can have list prices associated to it | [optional] 
**Description** | **string** | The description (non multilingual) of the entity definition | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Name** | **string** | The name (business key) of the definition | [optional] 
**ProductType** | **string** | The type of entity for which the definition applies (Product or Category) | [optional] 
**Properties** | [**List&lt;ProductPropertyDefinition&gt;**](ProductPropertyDefinition.md) | The non-grouped properties that are assigned to the definition | [optional] 
**PropertyGroups** | [**List&lt;ProductPropertyDefinitionGroup&gt;**](ProductPropertyDefinitionGroup.md) | The groups containing properties that are assigned to the definition | [optional] 
**SequenceNumber** | **int** | A number defining the order in which the definition appears in the list | [optional] 
**VariantProperties** | [**List&lt;ProductPropertyDefinition&gt;**](ProductPropertyDefinition.md) | The list of attributes assigned to the definition allowing Variant of a product. An empty collection means that variants are not allowedOnly available for a Product definition, not a Category | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

