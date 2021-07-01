# Yaksa.OrckestraCommerce.Client.Model.OrderItem
OrderItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingCurrency** | **string** | The currency ISO code under which the items are sold &#39;Currency.IsoCode&#39;. | [optional] 
**Created** | **DateTime** | The date when the order as created. | [optional] 
**CustomerEmail** | **string** | The email of customer who made the order. | [optional] 
**CustomerId** | **string** | The customer id who made the order. | [optional] 
**CustomerName** | **string** | The complete name of the customer who made the order. | [optional] 
**Id** | **string** | The id of the order. | [optional] 
**Messages** | [**List&lt;ExecutionMessage&gt;**](ExecutionMessage.md) | The execution messages when the order was post processed. | [optional] 
**OrderNumber** | **string** | The order number. | [optional] 
**OrderStatus** | **string** | The order status. | [optional] 
**PostProcessingExecutionResult** | **string** | execution result of the order post processing. | [optional] 
**ScopeId** | **string** | The scope id. | [optional] 
**ShipmentItems** | [**List&lt;ShipmentItem&gt;**](ShipmentItem.md) | The list of shipments for this order. | [optional] 
**Source** | **string** | The source of the order. | [optional] 
**Total** | **double** | The total of the order. | [optional] 
**ValidationResults** | [**List&lt;ValidationResult&gt;**](ValidationResult.md) | The validation results when the order was post processed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

