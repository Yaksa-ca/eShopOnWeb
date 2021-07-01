# Yaksa.OrckestraCommerce.Client.Model.CreateFulfillmentSLARequest
API calls used during the fulfillment process.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultDelayInMinutesWhenSLADateExceedsMaxDate** | **int** | The default delay in minutes when the SLA time exceeded the max days (Default is 5). | [optional] 
**DelayInMinutes** | **int** | The delay before the sla will expire. | [optional] 
**ExpiryDate** | **DateTime** | The expiry date and time to use if passed in to the request. | [optional] 
**ExpiryWarningTimeInMinutes** | **int** | The warning time before the sla will expire. | [optional] 
**FulfillmentLocationId** | **string** | The fulfillment location identifier. | [optional] 
**Id** | **string** | The fulfillment sla id. | [optional] 
**Name** | **string** | The name. | [optional] 
**OrderId** | **string** | The order identifier. | [optional] 
**ScheduleType** | **string** | The schedule type to use. | [optional] 
**ShipmentId** | **string** | The shipment identifier. | [optional] 
**SlaCreationMaxDays** | **int** | The number of days the SLA can extend into the future (Default is 30). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

