# Yaksa.OrckestraCommerce.Client.Model.SearchProductRequest
The API used to query the search engine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationName** | **string** | The name of the configuration to use to process this request | [optional] 
**ActiveProductOnly** | **bool** | whether to return active products only. True by default. | [optional] 
**Facets** | **List&lt;string&gt;** | the list of facets that will be included in the results. | [optional] 
**FeaturedProducts** | **List&lt;string&gt;** | The document ids of the products that will be elevated | [optional] 
**Keywords** | **string** | the search terms to use in the query. | [optional] 
**MaximumItems** | **int** | the maximum number of items returned by the search query. | [optional] 
**Properties** | **List&lt;string&gt;** | the collection of properties, represented as string, to return in the search results. | [optional] 
**SearchFilters** | [**List&lt;SearchFilter&gt;**](SearchFilter.md) | the collection of SearchFilters. | [optional] 
**SearchRanges** | [**List&lt;SearchRange&gt;**](SearchRange.md) | the collection of SearchRange. | [optional] 
**SortFieldDirection** | **string** | the direction used to sort the results. | [optional] 
**SortFieldName** | **string** | the name of the field used to order the results. | [optional] 
**StartingIndex** | **int** | the index of the first record in the list (used for paging purpose). | [optional] 
**VariantGroupingStrategy** | **string** | The variant grouping strategy | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

