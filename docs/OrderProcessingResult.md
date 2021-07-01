# Yaksa.OrckestraCommerce.Client.Model.OrderProcessingResult
OrderProcessingResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Arguments** | **Dictionary&lt;string, Object&gt;** | Dictionary&lt;String,Object&gt; | [optional] 
**ExecutionResult** | **string** | the result of the execution. | [optional] 
**Messages** | [**List&lt;ExecutionMessage&gt;**](ExecutionMessage.md) | the collection of messages collected during the workflow execution. | [optional] 
**ProcessingExceptions** | **List&lt;Object&gt;** | the list of unhandled exceptions that occurred during the workflow execution. | [optional] 
**ResultingOrder** | [**Order**](Order.md) |  | [optional] 
**ShipmentFulfillmentReadinessInfos** | [**List&lt;ShipmentFulfillmentReadinessInfo&gt;**](ShipmentFulfillmentReadinessInfo.md) | a collection of Shipment Fulfillment Readiness Information. | [optional] 
**ValidationResults** | [**List&lt;ValidationResult&gt;**](ValidationResult.md) | a collection of validation results that were applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

