# Yaksa.OrckestraCommerce.Client.Model.OrderFulfillmentState
OrderFulfillmentState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsCancelable** | **bool** | a calculated value assessment whether the whole order can be put canceled. This occurs only if all shipments can be put on canceled. | [optional] 
**IsHoldable** | **bool** | a calculated value assessment whether the whole order can be put on hold. This occurs only if all shipments can be put on hold. | [optional] 
**IsProcessing** | **bool** | value indicating whether if the order is being processed. | [optional] 
**OrderId** | **string** | the unique system identifier | [optional] 
**OrderNumber** | **string** | The order number. | [optional] 
**ProcessingExecutionResult** | **string** | The execution result of the order post processing. | [optional] 
**ProcessingMessages** | [**List&lt;ExecutionMessage&gt;**](ExecutionMessage.md) | The execution messages when the order was processed. | [optional] 
**ProcessingValidationResults** | [**List&lt;ValidationResult&gt;**](ValidationResult.md) | The validation results when the order was processed. | [optional] 
**ShipmentFulfillmentStates** | [**List&lt;ShipmentFulfillmentState&gt;**](ShipmentFulfillmentState.md) | the list of the order&#39;s list of shipment fulfillment state. | [optional] 
**Status** | **string** | the current order status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

