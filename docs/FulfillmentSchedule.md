# Yaksa.OrckestraCommerce.Client.Model.FulfillmentSchedule
FulfillmentSchedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FulfillmentLocationId** | **string** | A unique identifier for the FulfillmentLocation. | [optional] 
**OpeningHourExceptions** | [**List&lt;DailyScheduleException&gt;**](DailyScheduleException.md) | This collection will contain every exception of the regular hours entered for the store or warehouse. | [optional] 
**OpeningHours** | [**List&lt;DailySchedule&gt;**](DailySchedule.md) | This collection will contain one OpeningHour for each calendar week day. | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ScheduleType** | **string** | the type of the schedule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

