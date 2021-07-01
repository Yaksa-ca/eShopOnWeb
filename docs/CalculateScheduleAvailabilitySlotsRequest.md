# Yaksa.OrckestraCommerce.Client.Model.CalculateScheduleAvailabilitySlotsRequest
Fulfillment locations are entities which handles fulfillment for a shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CalculateReservationSummary** | **bool** | A value indicating whether the reservatiom summary will be calculated. | [optional] 
**DayOfWeekFilter** | **List&lt;string&gt;** | The day of week to filter (default is all days). Valid entries are Sunday through Saturday. | [optional] 
**EndDate** | **DateTime** | The date of the last day to calculate for (time should not be included). | [optional] 
**EndTime** | **string** | The end time of the period to consider the availability. | [optional] 
**ExcludeTimeSlotsOutsideTimeRange** | **bool** | A value indicating whether timeslots are returned if they are outside the time range. | [optional] 
**OrderId** | **string** | the unique identifier of the Order. | [optional] 
**OverridenLeadTime** | **string** | the optional override lead time, if set, the lead time for the store operating status will not be used. | [optional] 
**ShipmentId** | **string** | the unique identifier of the Shipment. | [optional] 
**StartDate** | **DateTime** | The date of the first day to calculate for (time should not be included). | [optional] 
**StartTime** | **string** | The start time of the period to consider the availability. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

