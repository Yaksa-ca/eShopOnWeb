# Yaksa.OrckestraCommerce.Client.Model.FindFulfillmentOrdersRequest
API calls used during the fulfillment process.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FulfillmentLocationId** | **string** | The fulfillment location id orders&#39; shipment need to be associated to. | [optional] 
**FulfillmentShipmentStatuses** | [**List&lt;FulfillmentShipmentStatus&gt;**](FulfillmentShipmentStatus.md) | The list of fulfillment shipment statuses orders&#39; shipment need to be associated to. | [optional] 
**MaximumItems** | **int** | The maximum number of results to return. Default value : 50 | [optional] 
**MinimumLimitDate** | **DateTime** | a date in the past defining the limit to get orders based on its creation date. It is ignored when &#39;SearchTerms&#39; has a value. | [optional] 
**OrderIds** | **List&lt;string&gt;** | A list of specific order ids needed to be fetched. | [optional] 
**SearchTerms** | **string** | A series of terms that will be used in the search for shipments. | [optional] 
**SortDirection** | **string** | Whether it should use ascending order (using order creation date) or descending order (using order last modified date). | [optional] 
**StartingIndex** | **int** | The starting index in the results to start getting the orders. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

