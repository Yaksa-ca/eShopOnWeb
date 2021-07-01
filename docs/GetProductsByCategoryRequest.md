# Yaksa.OrckestraCommerce.Client.Model.GetProductsByCategoryRequest
Categories are entities which represents a classification of products.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CultureName** | **string** | The culture name in which language tha data will be returned | [optional] 
**IncludeVariants** | **bool** | Whether or not to include the variants (if they exists) of the products. | [optional] 
**CategoryId** | **string** | The category id at which point in the category hierarchy should the &#39;get products&#39; be started. | 
**IncludePriceLists** | **bool** | Whether or not to include the price lists of the products. | [optional] 
**MaximumItems** | **int** | The maximum number of results to return. Default value : 10 | [optional] 
**StartingIndex** | **int** | the starting index in the results to start getting the products (used for paging purpose) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

