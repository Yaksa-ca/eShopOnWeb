# Yaksa.OrckestraCommerce.Client.Model.FindFulfillmentSLARequest
API calls used during the fulfillment process.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationName** | **string** | The name of the configuration to use to process this request | [optional] 
**CultureName** | **string** | The culture (language) to use to process the request (en-US) | 
**Query** | [**Query**](Query.md) |  | [optional] 
**FulfillmentLocationId** | **string** | The fulfillment location id. | [optional] 
**OnlyActive** | **bool** | Whether we should retrieve only the active fulfillment SLA. | [optional] 
**OnlyNearExpiryOrExpired** | **bool** | Whether we should retrieve only the fulfillment SLA near expiry or expired. | [optional] 
**OrderId** | **string** | The order id. | [optional] 
**ShipmentId** | **string** | The shipment id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

