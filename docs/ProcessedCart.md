# Yaksa.OrckestraCommerce.Client.Model.ProcessedCart
ProcessedCart

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Created** | **DateTime** | Date the entity was created | [optional] 
**CreatedBy** | **string** | Identifier of the operator who created the entity | [optional] 
**LastModified** | **DateTime** | Date that the last modification was applied to the entity | [optional] 
**LastModifiedBy** | **string** | Identifier of the operator who last modified the entity | [optional] 
**AdditionalFeeTotal** | **double** | the sum of LineItems totals. | [optional] 
**AdjustmentTotal** | **double** | the total amount of adjustments.  This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**BillingCurrency** | **string** | the currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;. | [optional] 
**CartType** | **string** | the cart type, according to the CartType lookup. | [optional] 
**CartVersion** | **string** | the version of the cart | [optional] 
**Coupons** | [**List&lt;Coupon&gt;**](Coupon.md) | the collection of coupon codes included in the order. | [optional] 
**CultureName** | **string** | the culture in which the cart is being processed. | [optional] 
**Customer** | [**CustomerSummary**](CustomerSummary.md) |  | [optional] 
**CustomerId** | **string** | the ID of the customer owning this cart. | 
**DiscountTotal** | **double** | the computed sum of all discounts applied to the cart (including order, line item and fulfillment level discounts). This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**FulfillmentCost** | **double** | the computed sum of all shipment cost. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**FulfillmentCostWithoutDiscount** | **double** | the fulfillment cost without discount. | [optional] 
**FulfillmentLevelDiscountTotal** | **double** | the sum of Shipments discounts. Shipment.DiscountAmount. | [optional] 
**ItemCount** | **int** | the line item count. | [optional] 
**LineItemLevelDiscount** | **double** | the minimum value between the sum of LineItem.DiscountAmount and LineItemsTotalWithoutDiscount. | [optional] 
**LineItemsTotal** | **double** | the sum of LineItems totals. | [optional] 
**LineItemsTotalWithoutDiscount** | **double** | the sum of LineItems totals without discount. | [optional] 
**MerchandiseTotal** | **double** | the total amount of all line items merchandise without discounts. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**Name** | **string** | the name of the cart. | 
**OrderLocation** | [**OrderLocationSummary**](OrderLocationSummary.md) |  | [optional] 
**OriginalPromotions** | [**List&lt;PromotionVersion&gt;**](PromotionVersion.md) | the promotion versions applied for the original order. | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | The collection of payments to use for this order. | [optional] 
**ScopeId** | **string** | the unique identifier of the scope associated to the cart. | [optional] 
**ShipmentLevelDiscountTotal** | **double** | the sum of Discounts amounts. | [optional] 
**Shipments** | [**List&lt;Shipment&gt;**](Shipment.md) | the collection of shipments associated to this order. | [optional] 
**Source** | **string** | the cart source. | [optional] 
**Status** | **string** | the status of the cart. | [optional] 
**SubTotal** | **double** | the computed sum of all line items totals, including line item and order level discount. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**SubTotalDiscount** | **double** | the sum of LineItems totals without discount. | [optional] 
**TaxTotal** | **double** | the computed sum of all tax amount for the order. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**Total** | **double** | the grand total for the cart. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**Messages** | [**List&lt;ExecutionMessage&gt;**](ExecutionMessage.md) | the customer information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

