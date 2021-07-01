# Yaksa.OrckestraCommerce.Client.Model.UpdateCartRequest
Carts are entities used for assembling an order before submitting.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | The culture name in which language the data will be returned. | [optional] 
**WorkflowToExecute** | **string** | The name of the workflow that should be executed. | [optional] 
**BillingCurrency** | **string** | the currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;. | [optional] 
**CartType** | **string** | the cart type, according to the CartType lookup. | [optional] 
**Coupons** | [**List&lt;Coupon&gt;**](Coupon.md) | the collection of coupon codes included in the order. | [optional] 
**Customer** | [**CustomerSummary**](CustomerSummary.md) |  | [optional] 
**ExecuteWorkflow** | **bool** | Whether or not to execute the specified workflow before returning the cart. | [optional] 
**OrderLocation** | [**OrderLocationSummary**](OrderLocationSummary.md) |  | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | The collection of payments to use for this order. | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Shipments** | [**List&lt;Shipment&gt;**](Shipment.md) | the collection of shipments associated to this order. | [optional] 
**Source** | **string** | the cart source. | [optional] 
**Status** | **string** | the status of the cart. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

