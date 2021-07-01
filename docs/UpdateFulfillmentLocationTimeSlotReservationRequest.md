# Yaksa.OrckestraCommerce.Client.Model.UpdateFulfillmentLocationTimeSlotReservationRequest
Fulfillment locations are entities which handles fulfillment for a shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SlotId** | **string** | The unique identifier of the time slot. An empty guid will not update the time slot. | [optional] 
**Comment** | **string** | The comment of the time slot reservation. | [optional] 
**ExpiryTime** | **string** | The expiry time for this reservation. Required only for Tentative status. | [optional] 
**ExpiryWarningTime** | **string** | The expiry time for this reservation. Required only for Tentative status. | [optional] 
**OrderId** | **string** | The reservation order id associated with the reservation. | [optional] 
**OrderNumber** | **string** | The reservation order number associated with the reservation. | [optional] 
**ReservationStatus** | **string** | The reservation status. Options are Tentative, Confirmed, Expired and Void. | 
**ShipmentId** | **string** | The reservation shipment id associated with the reservation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

