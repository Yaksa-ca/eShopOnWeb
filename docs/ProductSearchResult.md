# Yaksa.OrckestraCommerce.Client.Model.ProductSearchResult
ProductSearchResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrectedSearchTerms** | **string** | the auto-corrected search terms used to return values. | [optional] 
**Documents** | [**List&lt;ProductDocument&gt;**](ProductDocument.md) | a list of Document matching the search request. | [optional] 
**Facets** | [**List&lt;Facet&gt;**](Facet.md) | a list of Facet corresponding to the search request. | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**StartIndex** | **int** | the index of the first record in the list from which to start paging. | [optional] 
**Suggestions** | [**List&lt;Suggestion&gt;**](Suggestion.md) | a list of Suggestion that could return more meaningful results for the search term entered. | [optional] 
**TotalCount** | **long** | the total number of records matching the search request, irrespective of the page. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

