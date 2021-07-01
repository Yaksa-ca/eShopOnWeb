# Yaksa.OrckestraCommerce.Client.Model.LineItemSummary
LineItemSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**AdditionalFeeAmount** | **double** | The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**CatalogId** | **string** | The unique identifier of the catalog where the product belongs. | 
**CurrentPrice** | **double** | The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**CurrentPricePriceListCategory** | **string** | The category of the current price | [optional] 
**CurrentPricePriceListId** | **string** | The id of the current price | [optional] 
**CurrentPricePriceListType** | **string** | The type of the current price | [optional] 
**DiscountAmount** | **double** | The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**ItemFormat** | **double** | the ItemFormat of the product. | [optional] 
**ListPrice** | **double** | The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**ProductDisplayName** | **string** | The UI-friendly display name for the product. | [optional] 
**ProductId** | **string** | The unique identifier of the product | 
**Quantity** | **double** | The quantity of product to purchase. A decimal number can be used for products sold with a unit of measure (pounds, kilos, etc.). | [optional] 
**RecurringOrderFrequencyName** | **string** |  | [optional] 
**RecurringOrderProgramName** | **string** |  | [optional] 
**RegularPrice** | **double** | The current regular price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**RegularPricePriceListCategory** | **string** | The category of the regular price | [optional] 
**RegularPricePriceListId** | **string** | The id of the regular price | [optional] 
**ShipmentId** | **string** | The unique identifier of the shipment to use for this item | [optional] 
**Sku** | **string** | The LineItem Sku | [optional] 
**Status** | **string** |  | [optional] 
**Total** | **double** | The total amount for this line item, including discounts (list price * quantity - discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**UnitOfMeasure** | **string** | the UnitOfMeasure of the product. | [optional] 
**VariantId** | **string** | The unique identifier of the product variant if the purchased product is a variant | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

