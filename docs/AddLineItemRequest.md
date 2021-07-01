# Yaksa.OrckestraCommerce.Client.Model.AddLineItemRequest
Carts are entities used for assembling an order before submitting.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | The culture name in which language the data will be returned. | [optional] 
**WorkflowToExecute** | **string** | The name of the workflow that should be executed. | [optional] 
**GiftMessage** | **string** | if the product is to be gift-wrapped, a message to be written on it. | [optional] 
**GiftWrap** | **bool** | whether or not the item will wrapped in a gift presentation. | [optional] 
**Id** | **string** | The unique identifier of the LineItem to create. | [optional] 
**PlacedPrice** | **double** | The price of the LineItem, at the moment that the Product is added to the cart. | [optional] 
**ProductId** | **string** | The unique identifier of the product. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Quantity** | **double** | The number of items bought for this Product. | 
**RecurringOrderFrequencyName** | **string** | the name of the recurring order program frequency. | [optional] 
**RecurringOrderProgramName** | **string** | the name of the recurring order program. | [optional] 
**VariantId** | **string** | The unique identifier of the product variant, if there is one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

