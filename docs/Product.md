# Yaksa.OrckestraCommerce.Client.Model.Product
Product

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Created** | **DateTime** | Date the entity was created | [optional] 
**CreatedBy** | **string** | Identifier of the operator who created the entity | [optional] 
**LastModified** | **DateTime** | Date that the last modification was applied to the entity | [optional] 
**LastModifiedBy** | **string** | Identifier of the operator who last modified the entity | [optional] 
**ActivationOverridden** | **bool** | Allow overriding the Active flag and the activation schedule at a descendent scope level. | [optional] 
**AllowVariantActivationSchedule** | **bool** | Allow overriding the activation schedule at the variant level. | [optional] 
**Brand** | **string** | the Brand of the Product. | [optional] 
**ItemFormat** | **double** | the ItemFormat of the Product (must be mg, mm, mm2, mm3 or Unit quantity). | [optional] 
**ScheduledActivation** | **DateTime** | The date on which the product becomes active. | [optional] 
**ScheduledDeactivation** | **DateTime** | The date on which the product becomes inactive. | [optional] 
**SellingMethod** | **string** | the Selling Method of the Product. | [optional] 
**UnitOfMeasure** | **string** | the unit of measure of the Product. | [optional] 
**Weight** | **double** | The weight of the Product. | [optional] 
**WeightUOM** | **string** | The weight unit of measure of the Product. | [optional] 
**Active** | **bool** | whether the Product is active or not. | [optional] 
**CatalogId** | **string** | the id of the catalog to which the product belongs. | [optional] 
**DefinitionName** | **string** | the product definition name that represents the Product (its properties). | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**IncludeInSearch** | **bool** | Whether or not the Product should be included in the front-end search result. | [optional] 
**IsOverridden** | **bool** | whether the product has overridden values in the current Sales scope. | [optional] 
**LastPublishedDate** | **DateTime** | the last published date of the Product. | [optional] 
**ListPrice** | **double** | the default price for the Product | [optional] 
**MediaSet** | [**List&lt;ProductMedia&gt;**](ProductMedia.md) | the list of media of the Product | [optional] 
**NewProductDate** | **DateTime** | the number of days the Product is flagged as a new product introduction. | [optional] 
**ParentCategoryIds** | **List&lt;string&gt;** | the business key (id) of the primary Category. | [optional] 
**Prices** | [**List&lt;ProductPriceEntry&gt;**](ProductPriceEntry.md) | a list of ProductPriceEntry. | [optional] 
**PrimaryParentCategoryId** | **string** | the business key (id) of the primary Category. | [optional] 
**PublicationStatus** | **string** | the publication status of the Product. Currently supported values are &#39;InProgress&#39;, &#39;Rejected&#39;, &#39;PendingApproval&#39;, &#39;ReadyToCompose&#39;, &#39;Published&#39; | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | The list of related entities (Product, Category or Variant) related to the Product. | [optional] 
**SequenceNumber** | **int** | the number used for ordering the Product in a list. | [optional] 
**Sku** | **string** | the stock keeping unit code (SKU) of the Product. | [optional] 
**TaxCategory** | **string** | the tax category of the Product. | [optional] 
**VariantMediaSet** | [**List&lt;VariantMediaSet&gt;**](VariantMediaSet.md) | the media list of key variants of the Product | [optional] 
**Variants** | [**List&lt;Variant&gt;**](Variant.md) | the list of Variant of the Product | [optional] 
**IdsOfOverriddenVariants** | **List&lt;string&gt;** |  | [optional] 
**OverriddenProperties** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

