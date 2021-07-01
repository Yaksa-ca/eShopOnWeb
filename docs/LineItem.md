# Yaksa.OrckestraCommerce.Client.Model.LineItem
LineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**GiftMessage** | **string** | if the product is to be gift-wrapped, a message to be written on it. | [optional] 
**GiftWrap** | **bool** | whether or not the item will wrapped in a gift presentation. | [optional] 
**PlacedPrice** | **double** | Gets or sets the placed price of the line item at the moment the cart was submitted either on order creation or order modification. This value is set automatically by the system. | [optional] 
**ProductId** | **string** | The unique identifier of the product. | 
**Quantity** | **double** | The number of items bought for this Product. | 
**RecurringOrderFrequencyName** | **string** | the name of the recurring order program frequency. | [optional] 
**RecurringOrderProgramName** | **string** | the name of the recurring order program. | [optional] 
**VariantId** | **string** | The unique identifier of the product variant, if there is one. | [optional] 
**AdditionalFeeAmount** | **double** | The amount for all line item additional fees applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**AdditionalFees** | [**List&lt;LineItemAdditionalFee&gt;**](LineItemAdditionalFee.md) | The collection of additional fees to apply on this line item. | [optional] 
**CatalogId** | **string** | The unique identifier of the catalog where the product belongs. | 
**CurrentPrice** | **double** | The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**DefaultListPrice** | **double** | The default price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**DefaultPrice** | **double** | The default price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**DiscountAmount** | **double** | The amount for all discounts applied to this line item. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**IsGiftItem** | **bool** | item is a gift | [optional] 
**KvaDisplayValues** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**KvaValues** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ListPrice** | **double** | The price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**PlacedQuantity** | **double** | The placed quantity of product to purchase at the moment the cart was submitted either on order creation or order modification. This value is set automatically by the system. A decimal number can be used for products sold with a unit of measure (pounds, kilos, etc.). | [optional] 
**PricingCalculationSummary** | [**PricingCalculationSummary**](PricingCalculationSummary.md) |  | [optional] 
**ProductDefinitionName** | **string** | the product definition name. | [optional] 
**ProductSummary** | [**CartProductSummary**](CartProductSummary.md) |  | [optional] 
**RegularPrice** | **double** | The current regular price for one instance of the item (quantity &#x3D; 1), at the moment that the item is to be processed by the workflow. | [optional] 
**ReservationStatus** | **string** | The LineItem inventory reservation status. | [optional] 
**Rewards** | [**List&lt;Reward&gt;**](Reward.md) | The collection of RewardDefinitions to apply on this line item. | [optional] 
**ShipmentId** | **string** | The unique identifier of the shipment to use for this item. The shipment reference must be available within the same cart or order. | [optional] 
**Sku** | **string** | The LineItem Sku | [optional] 
**Status** | **string** | The LineItem status, according to the LineItemStatus lookup. | [optional] 
**Total** | **double** | The total amount for this line item, including discounts (list price * quantity - discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**TotalWithoutDiscount** | **double** | The total amount for this line item, including discounts (list price * quantity - discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

