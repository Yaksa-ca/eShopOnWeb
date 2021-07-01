# Yaksa.OrckestraCommerce.Client.Model.FulfillmentShipment
FulfillmentShipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**AggregatedStatus** | **string** | The name of the aggregated status when applicable. | [optional] 
**AllowedManualTransitions** | **List&lt;string&gt;** | a list of allowed manual transitions from the shipment current status. | [optional] 
**Created** | **DateTime** | Date the shipment fullfillment was created. | [optional] 
**ExecutionResult** | **string** | The execution result of the shipment processing. | [optional] 
**ExpectedDeliveryDate** | **DateTime** | The expected delivery date. | [optional] 
**FulfillmentExceptions** | [**List&lt;FulfillmentException&gt;**](FulfillmentException.md) | The fulfillment exceptions. | [optional] 
**FulfillmentLocationId** | **string** | The fulfillment location id. | [optional] 
**FulfillmentMethodType** | **string** | The Fulfillment Method Type that will be used to complete the shipment. | [optional] 
**FulfillmentScheduledTimeBeginDate** | **DateTime** | The begin date and time scheduled for the fulfillment. | [optional] 
**FulfillmentScheduledTimeEndDate** | **DateTime** | The end date and time scheduled for the fulfillment. | [optional] 
**IsProcessing** | **bool** | A value indicating whether the shipment is processing. | [optional] 
**LastModified** | **DateTime** | Date that the last modification was applied to the shipment fullfillment. | [optional] 
**NbItems** | **int** | The number of items in the shipment. | [optional] 
**NbUnits** | **double** | The number of units in the shipment. | [optional] 
**PickUpLocationId** | **string** | The pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise. | [optional] 
**ReturnTrackingNumber** | **string** | The shipment return tracking number provided by the shipping provider. | [optional] 
**ShippingAddress** | [**Address**](Address.md) |  | [optional] 
**ShippingProviderId** | **string** | The fulfillment provider id. | [optional] 
**SlAs** | [**List&lt;OrderFulfillmentSLA&gt;**](OrderFulfillmentSLA.md) | The fulfillment SLAs. | [optional] 
**Status** | **string** | The current status of the shipment. | [optional] 
**TrackingNumber** | **string** | The shipment tracking number provided by the shipping provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

