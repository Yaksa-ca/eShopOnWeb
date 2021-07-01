# Yaksa.OrckestraCommerce.Client.Model.UpdateShipmentFulfillmentStateRequest
Orders are entities which represent an order of a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedManualTransitions** | **List&lt;string&gt;** | a list of allowed manual transitions from the shipment current status. | [optional] 
**AllowedStatusChanges** | **List&lt;string&gt;** | a list of allowed status changes that can be requested.  Requesting any other changes will fail. | [optional] 
**AllowsShipmentChangesProcessing** | **bool** | whether the saving an order in the current state should resume a processing the order within the fulfillment process. | [optional] 
**ClearFulfillmentFailureMessages** | **bool** | whether clear state failure messages. | [optional] 
**FulfillmentScheduledTimeBeginDate** | **DateTime** | the scheduled time at which fulfillment will begin. | [optional] 
**FulfillmentScheduledTimeEndDate** | **DateTime** | the scheduled time at which fulfillment will end. | [optional] 
**IsFinished** | **bool** | a flag indicating that fulfillment is complete for this shipment.  | [optional] 
**NextStatuses** | **List&lt;string&gt;** | a list of the potential statuses the shipment could transition to from its current status. | [optional] 
**RenewFulfillmentTaskLockExpirationOnProcess** | **string** | the whether the fulfillment task lock should be extended for another defined amount of time. | [optional] 
**Status** | **string** | the current status of the shipment. | [optional] 
**TaskId** | **string** | the task Id responsible for fulfilling the shipment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

