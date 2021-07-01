# Yaksa.OrckestraCommerce.Client.Model.GetProductsPropertiesByDraftStateAndCategoriesRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | The culture in which the data will be returned | 
**DraftState** | **string** | The draft state used to filter the products | [optional] 
**MaximumItems** | **int** | The maximum number of results to return. Default value : 10 | [optional] 
**PropertiesNames** | **List&lt;string&gt;** | the list of properties to return | [optional] 
**SortBy** | **string** | The name of the property to be sorted | [optional] 
**SortDirection** | **string** | The sorting direction | [optional] 
**StartingIndex** | **int** | the starting index in the results to start getting the products (used for paging purpose) | [optional] 
**Categories** | **List&lt;string&gt;** | The list of category ids | [optional] 
**HasNotification** | **bool** | The flag to filter results to products with change notifications | [optional] 
**IncludeCount** | **bool** | The flag to include product count | [optional] 
**IsNew** | **bool** | The flag to filter results to new products only | [optional] 
**Uncategorized** | **bool** | The flag to filter results to uncategorized products | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

