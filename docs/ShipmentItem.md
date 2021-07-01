# Yaksa.OrckestraCommerce.Client.Model.ShipmentItem
ShipmentItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ExecutionResult** | **string** | The execution result of the shipment processing. | [optional] 
**ExpectedDeliveryDate** | **DateTime** | The expected delivery date. | [optional] 
**FulfillmentLocationId** | **string** | The fulfillment location id. | [optional] 
**FulfillmentScheduledTimeBeginDate** | **DateTime** | The begin date and time scheduled for the fulfillment. | [optional] 
**FulfillmentScheduledTimeEndDate** | **DateTime** | The end date and time scheduled for the fulfillment. | [optional] 
**Messages** | [**List&lt;ExecutionMessage&gt;**](ExecutionMessage.md) | The execution messages when the shipment was processed. | [optional] 
**PickUpLocationId** | **string** | The pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise. | [optional] 
**ShippingAddress** | [**Address**](Address.md) |  | [optional] 
**ValidationResults** | [**List&lt;ValidationResult&gt;**](ValidationResult.md) | The validation results when the shipment was processed. | [optional] 
**SlAs** | [**List&lt;OrderFulfillmentSLA&gt;**](OrderFulfillmentSLA.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

