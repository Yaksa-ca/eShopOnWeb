# Yaksa.OrckestraCommerce.Client.Model.FindOrdersRequest
Orders are entities which represent an order of a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationName** | **string** | The name of the configuration to use to process this request | [optional] 
**CultureName** | **string** | The culture (language) to use to process the request (en-US) | 
**Query** | [**Query**](Query.md) |  | [optional] 
**CreatedDateRange** | [**RangeDateTime**](RangeDateTime.md) |  | [optional] 
**CustomerId** | **string** | Customer id | [optional] 
**FilterNeedingAttentionOnly** | **bool** | Whether results are filtered by needing attention only. | [optional] 
**FulfillmentDateRange** | [**RangeDateTime**](RangeDateTime.md) |  | [optional] 
**FulfillmentLocationId** | **string** | the fulfillment location id. | [optional] 
**FulfillmentMethodType** | **string** | the fulfillment method thype. | [optional] 
**IncludeActiveFulfillmentSLAs** | **bool** | Whether we should retrieve the active fulfillment SLAs or not. | [optional] 
**IncludeFulfillmentStates** | **bool** | Whether we should retrieve the fulfillmentStates or not. | [optional] 
**LastModifiedDateRange** | [**RangeDateTime**](RangeDateTime.md) |  | [optional] 
**OrderStatus** | **List&lt;string&gt;** | the order status. | [optional] 
**PaymentStatus** | **List&lt;string&gt;** | the list of payment status. | [optional] 
**SearchFulltextFields** | **bool** | Whether the search term is used on full-text indexed fields or not | [optional] 
**SearchTerms** | **string** | A series of terms that will be used in the search for orders. | [optional] 
**ShipmentStatus** | **List&lt;string&gt;** | the list of shipment status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

