# Yaksa.OrckestraCommerce.Client.Model.GetShipmentFulfillmentInfosRequest
ShipmentFulfillmentInfos are entities which represent the Shipment Fulfillment Informations of a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**DateRangeFilter** | **string** | the date range filter | [optional] 
**EndDate** | **DateTime** | the EndDate, ISO-8601 format | [optional] 
**ExcludeShipmentInFinalState** | **bool** | value indicating whether or not shipments in final state of the workflow will be returned | [optional] 
**FlaggedOnly** | **bool** | true if you just want to get flagged Shipments | [optional] 
**FulfillmentLocationId** | **string** | the FulfillmentLocationId | [optional] 
**OrderId** | **string** | the order id | [optional] 
**PageNumber** | **int** | the PageNumber | [optional] 
**PageSize** | **int** | the PageSize | [optional] 
**PickUpLocationId** | **string** | the PickUpLocationId | [optional] 
**RequiredFields** | **List&lt;string&gt;** | The fields from ShipmentFulfillmentInfo that are absolutely required. Default is all. | [optional] 
**SearchText** | **string** | the SearchText | [optional] 
**Sort** | **string** | the sorted fields, seperated by commas, use &#39;-&#39; before field name for descending | [optional] 
**StartDate** | **DateTime** | the StartDate, ISO-8601 format | [optional] 
**Statuses** | **List&lt;string&gt;** | the Statuses | [optional] 
**Type** | **string** | the FulfillmentMethodType | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

