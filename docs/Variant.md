# Yaksa.OrckestraCommerce.Client.Model.Variant
Variant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Created** | **DateTime** | Date the entity was created | [optional] 
**CreatedBy** | **string** | Identifier of the operator who created the entity | [optional] 
**LastModified** | **DateTime** | Date that the last modification was applied to the entity | [optional] 
**LastModifiedBy** | **string** | Identifier of the operator who last modified the entity | [optional] 
**Active** | **bool** | whether the Variant is active or not. | [optional] 
**MediaSet** | [**List&lt;ProductMedia&gt;**](ProductMedia.md) | the media | [optional] 
**OverriddenProperties** | **List&lt;string&gt;** | the list of overridden properties. | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | the relationships | [optional] 
**ScheduledActivation** | **DateTime** | The date on which the variant becomes active. | [optional] 
**ScheduledDeactivation** | **DateTime** | The date on which the variant becomes inactive. | [optional] 
**CatalogId** | **string** | the id of the catalog name to which the variant belongs. | [optional] 
**DefinitionName** | **string** | the product definition name that represents the Variants (its properties). | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**HiddenInScope** | **bool** | the hidden in scope flag of the Variant | [optional] 
**ListPrice** | **double** | the current price for the Variant. | [optional] 
**Prices** | [**List&lt;ProductPriceEntry&gt;**](ProductPriceEntry.md) | prices. | [optional] 
**ProductId** | **string** | the ID (business) of the product that owns the Variant | [optional] 
**SequenceNumber** | **int** | the number used for ordering the Variant in a list. | [optional] 
**Sku** | **string** | the stock keeping unit code (SKU) of the Variant. | [optional] 
**TaxCategory** | **string** | the tax category of the Variant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

