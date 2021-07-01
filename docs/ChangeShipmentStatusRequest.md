# Yaksa.OrckestraCommerce.Client.Model.ChangeShipmentStatusRequest
Orders are entities which represent an order of a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Notes** | **string** | An additional description or comment provided for the status change request. This information will be automatically appended to the shipment notes. | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Reason** | **string** | The defined reason, if any, why the change is requested. | [optional] 
**RequestedStatus** | **string** | The status the shipment should be transitioned to. This value needs to be part of the ShipmentFulfillmentState.AllowedStatusChanges otherwise will fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

