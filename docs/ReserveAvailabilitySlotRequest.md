# Yaksa.OrckestraCommerce.Client.Model.ReserveAvailabilitySlotRequest
Fulfillment locations are entities which handles fulfillment for a shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**EndDate** | **DateTime** | the Date and Time of the desired slot. The calendar date on which the slot should be checked and the time at which the slot ends | [optional] 
**FulfillmentType** | **string** | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | [optional] 
**OrderId** | **string** | the unique identifier of the Order. | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ShipmentId** | **string** | the unique identifier of the Shipment. | [optional] 
**StartDate** | **DateTime** | the Date and Time of the desired slot. The calendar date on which the slot should be checked and the time at which the slot starts | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

