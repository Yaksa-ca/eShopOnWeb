# Yaksa.OrckestraCommerce.Client.Model.ShipmentFulfillmentState
ShipmentFulfillmentState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedManualTransitions** | **List&lt;string&gt;** | a list of allowed manual transitions from the shipment current status. | [optional] 
**AllowedStatusChanges** | **List&lt;string&gt;** | a list of allowed status changes that can be requested.  Requesting any other changes will fail. | [optional] 
**AllowsShipmentChangesProcessing** | **bool** | a flag indicating that the shipment changes can be reprocessed within the fulfillment workflow | [optional] 
**Created** | **DateTime** | The creation date of the shipment fulfillment state. | [optional] 
**CreatedBy** | **string** | the identity of the user who created the state. | [optional] 
**ExecutionResult** | **string** | the execution result of the shipment processing | [optional] 
**FulfillmentLocationId** | **string** | the unique identifier of the fulfillment location that will complete the shipment process. | [optional] 
**FulfillmentLocationScope** | **string** | the fulfillment location scope. | [optional] 
**FulfillmentMethodType** | **string** | the FulfillmentMethodType that will be used to complete the shipment. | [optional] 
**FulfillmentProviderId** | **string** | the fulfillment provider identifier. | [optional] 
**FulfillmentScheduledTimeBeginDate** | **DateTime** | the scheduled time at which fulfillment will begin. | [optional] 
**FulfillmentScheduledTimeEndDate** | **DateTime** | the scheduled time at which fulfillment will end. | [optional] 
**IsFinished** | **bool** | a value indicating whether if that fulfillment is finished for this shipment. | [optional] 
**IsProcessing** | **bool** | a value indicating whether if the shipment is being processed or not. | [optional] 
**IsResumable** | **bool** | the fulfillment workflow is resumable. | [optional] 
**LastModified** | **DateTime** | the last modification date. | [optional] 
**LastModifiedBy** | **string** | the identity of the user who modified the state. | [optional] 
**LockedForTaskProcessingUntil** | **DateTime** | the UTC datetime until when the shipment state and content will be exclusively open for modifications by the fulfillment workflow task. | [optional] 
**Messages** | [**List&lt;ExecutionMessage&gt;**](ExecutionMessage.md) | The execution messages when the shipment was processed | [optional] 
**NextStatuses** | **List&lt;string&gt;** | a list of the potential status the shipment could transition to from its current status. | [optional] 
**PickUpLocationId** | **string** | The pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise. | [optional] 
**ReadyToBeginFulfillmentOn** | **DateTime** | the date on which the shipment is ready to be processed. | [optional] 
**RetryCount** | **int** | the number of times the workflow was restarted after an error. | [optional] 
**ShipmentId** | **string** | the unique system shipment identifier. | [optional] 
**ShipmentLastProcessedOn** | **DateTime** | the date and time on which the shipment was last processed | [optional] 
**Status** | **string** | the current status of the shipment. | [optional] 
**TaskId** | **string** | the fulfillment task Id associated with the shipment processing. | [optional] 
**TaskStatus** | **string** | the fulfillment task status associated with the shipment processing. | [optional] 
**TaskWorkflowXamlPath** | **string** | the path of the fulfillment workflow. | [optional] 
**ValidationResults** | [**List&lt;ValidationResult&gt;**](ValidationResult.md) | the validation results when the shipment was processed. | [optional] 
**WorkflowInError** | **bool** | the fulfillment workflow is in error. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

