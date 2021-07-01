# Yaksa.OrckestraCommerce.Client.Model.SearchBySearchQueryRequest
The API used to query the search engine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationName** | **string** | The name of the configuration to use to process this request | [optional] 
**Query** | [**Query**](Query.md) |  | [optional] 
**AutoCorrect** | **bool** | Whether search term should be automatically corrected | [optional] 
**FacetPredicates** | [**List&lt;FacetPredicate&gt;**](FacetPredicate.md) | List of FacetPredicates to apply on the search | [optional] 
**Facets** | **List&lt;string&gt;** | The facets, a list of strings, that will be included in the results | [optional] 
**IncludeFacets** | **bool** | Whether facets are returned as part of the search results | [optional] 
**Properties** | **List&lt;string&gt;** | the collection of properties, represented as string, to return in the search results. | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**SearchTerms** | **string** | The search terms for this search query | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

