# Yaksa.OrckestraCommerce.Client.Model.TimeSlotReservation
TimeSlotReservation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CartCustomerId** | **string** | The cart customer id associated with the reservation. | 
**CartName** | **string** | The cart name associated with the reservation. | 
**CartScopeId** | **string** | The cart scope id associated with the reservation. | 
**Comment** | **string** | The reservation comment. | [optional] 
**Created** | **DateTime** | The date and time the reservation was created. | [optional] 
**CreatedBy** | **string** | The user who created the reservation. | [optional] 
**ExpiryDateTime** | **DateTime** | The reservation expiry time. Required for Tentative status. | [optional] 
**ExpiryWarningDateTime** | **DateTime** | The reservation expiry warning time. Required for Tentative status. | [optional] 
**FulfillmentLocationId** | **string** | The unique identifier of a fulfillment location. | 
**FulfillmentLocationTimeSlotId** | **string** | The unique identifier of a fulfillment location timeslot. | 
**Id** | **string** | The unique identifier of the time slot. | 
**LastModified** | **DateTime** | The date and time the reservation was last modified. | [optional] 
**LastModifiedBy** | **string** | The user who last modified the reservation. | [optional] 
**MaxNumberOfRenewals** | **int** | The maximum number of renewals that can be performed on this reservation. | [optional] 
**NumberOfRenewals** | **int** | The number of renewals performed on this reservation. | [optional] 
**OrderId** | **string** | The unique identifier of an order. | [optional] 
**OrderNumber** | **string** | The order number associated with the reservation. | [optional] 
**ReservationDate** | **DateTime** | The reservation date. | 
**ReservationStatus** | **string** | The reservation status. | 
**ShipmentId** | **string** | The unique identifier of a shipment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

