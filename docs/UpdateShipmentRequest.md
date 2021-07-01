# Yaksa.OrckestraCommerce.Client.Model.UpdateShipmentRequest
Carts are entities used for assembling an order before submitting.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | The culture name in which language the data will be returned. | [optional] 
**WorkflowToExecute** | **string** | The name of the workflow that should be executed. | [optional] 
**FulfillmentLocationId** | **string** | The fulfillment location id. | [optional] 
**FulfillmentMethodCarrierName** | **string** | The fulfillment method carrier name  for the fulfillment method. | [optional] 
**FulfillmentMethodCarrierOptionDisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**FulfillmentMethodCarrierServiceLevel** | **string** | The fulfillment method carrier service level for this fulfillment method. | [optional] 
**FulfillmentMethodDisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**FulfillmentMethodName** | **string** | The unique identifier of the Shipment.FulfillmentMethod. | [optional] 
**FulfillmentScheduledTimeBeginDate** | **DateTime** | the requested schedule begin date and time. | [optional] 
**FulfillmentScheduledTimeEndDate** | **DateTime** | the requested schedule end date and time. | [optional] 
**FulfillmentScheduleMode** | **string** | The fulfillment schedule mode. | [optional] 
**PickUpLocationId** | **string** | Gets or sets the pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise. | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ShippingAddress** | [**Address**](Address.md) |  | [optional] 
**ShippingProviderId** | **string** | The unique identifier of the shipping provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

