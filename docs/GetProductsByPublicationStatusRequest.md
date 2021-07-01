# Yaksa.OrckestraCommerce.Client.Model.GetProductsByPublicationStatusRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | The culture in which the data will be returned | 
**IncludePrice** | **bool** | The flag to include product&#39;s default price | [optional] 
**MaximumItems** | **int** | The maximum number of results to return. Default value : 10 | [optional] 
**PropertyNames** | **List&lt;string&gt;** | the list of properties to return | [optional] 
**PublicationStatus** | **string** | The publication status to filter the products by | [optional] 
**SortBy** | **string** | The name of the property to be sorted | [optional] 
**SortDirection** | **string** | The sorting direction | [optional] 
**Categories** | **List&lt;string&gt;** | The list of category ids | [optional] 
**ContinuationToken** | **string** | The continuation token used for pagination | [optional] 
**IncludeCount** | **bool** | The flag to include product count | [optional] 
**Uncategorized** | **bool** | The flag to filter results to un-categorized products | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

