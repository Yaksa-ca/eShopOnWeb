# Yaksa.OrckestraCommerce.Client.Model.ProductDocument
ProductDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**CatalogId** | **string** | the catalog identifier. | [optional] 
**CurrentPrice** | **double** | the current price according to the date sent in the request. | [optional] 
**DefaultPrice** | **double** | [Obsolete] the default price. | [optional] 
**EntityPricing** | [**EntityPricing**](EntityPricing.md) |  | [optional] 
**GroupPricing** | [**GroupPricing**](GroupPricing.md) |  | [optional] 
**InventoryLocationStatuses** | [**List&lt;InventoryItemAvailability&gt;**](InventoryItemAvailability.md) | the inventory statuses in each inventory location sent in the request. | [optional] 
**ListPrice** | **double** | [Obsolete] the list price (default price). | [optional] 
**Price** | **double** | the current price according to the date sent in the request. | [optional] 
**ProductId** | **string** | the product identifier. | [optional] 
**RegularPrice** | **double** | The current regular price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**Sku** | **string** | the sku. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

