# Yaksa.OrckestraCommerce.Client.Model.CalculateFulfillmentLocationsDelayRequest
Fulfillment locations are entities which handles fulfillment for a shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultDelayInMinutesWhenSLADateExceedsMaxDate** | **int** | The default delay in minutes when the SLA time exceeds the max days (Default is 5). | 
**DelayInMinutes** | **int** | The delay to be used in the calculation. | 
**FromDateTime** | **DateTime** | The UTC date time the expiry delay would be calculated from. If null, UTC now will be used. | [optional] 
**FulfillmentLocationIds** | **List&lt;string&gt;** | the unique identifier of the Fulfillment locations to calculate. | 
**ScheduleType** | **string** | The schedule type to use. | [optional] 
**SlaCreationMaxDays** | **int** | The number of days the SLA can extend into the future (Default is 30). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

