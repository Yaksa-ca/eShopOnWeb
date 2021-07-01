# Yaksa.OrckestraCommerce.Client.Model.CartSummary
CartSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**AdditionalFeeTotal** | **double** | discount amount applied on the cart, independently from line item and shipping discounts. | [optional] 
**BillingCurrency** | **string** | the currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;. | [optional] 
**CartType** | **string** | the cart type, according to the CartType lookup. | [optional] 
**Created** | **DateTime** | Date the entity was created | [optional] 
**CustomerId** | **string** | the ID of the customer owning this cart. | 
**DiscountAmount** | **double** | discount amount applied on the cart, independently from line item and shipping discounts. | [optional] 
**DiscountTotal** | **double** | the computed sum of all discounts applied to the cart (including order, line item and shipping level discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**MerchandiseTotal** | **double** | the total amount of all line items merchandise without discounts. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**Name** | **string** | the name of the cart. | 
**ScopeId** | **string** | the scope. | [optional] 
**ShipmentSummaries** | [**List&lt;ShipmentSummary&gt;**](ShipmentSummary.md) | the list of shipment summaries. | [optional] 
**ShippingTotal** | **double** | the computed sum of all shipment amounts. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**Source** | **string** | the cart source. | [optional] 
**SubTotal** | **double** | the computed sum of all line items totals, including line item and order level discount. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**TaxTotal** | **double** | the computed sum of all tax amount for the order. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**Total** | **double** | the grand total for the cart. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

