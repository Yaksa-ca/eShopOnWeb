# Yaksa.OrckestraCommerce.Client.Model.ChangeOrderStatusRequest
Orders are entities which represent an order of a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Notes** | **string** | An additional description or comment about the status change request. This information is automatically appended to the order notes. | [optional] 
**Reason** | **string** | The defined reason, if any, why the change is requested. | [optional] 
**RequestedStatus** | **string** | The status the shipments should be transitioned to. This value needs to be part of the ShipmentFulfillmentState.AllowedStatusChanges otherwise will fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

