# Yaksa.OrckestraCommerce.Client.Model.AdvancedSearchRequest
The API used to query the search engine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationName** | **string** | The name of the configuration to use to process this request | [optional] 
**Query** | [**Query**](Query.md) |  | [optional] 
**AutoCorrect** | **bool** | Whether or not to automatically do the correction when there is no result and at least one suggestion | [optional] 
**BoostQueryParams** | **List&lt;string&gt;** | The boost query parameters for this search. This will append a &#39;bq&#39; parameter to the call to Solr for each param. | [optional] 
**ElevatedIds** | **List&lt;string&gt;** | The ids of the documents that will be elevated | [optional] 
**FacetHierarchyId** | **string** | The ID of the facet hierarchy to use. This will impact the facets results, only the facets defined in this hierarchy will be returned. | [optional] 
**FacetPredicates** | [**List&lt;FacetPredicate&gt;**](FacetPredicate.md) | List of FacetPredicate to apply on the search | [optional] 
**Facets** | **List&lt;string&gt;** | The facets, a list of string, that will be included in the results | [optional] 
**GroupByField** | **string** | The field used to group results. | [optional] 
**IncludeEmptyFacets** | **bool** | Whether to return the Facet with no values in it | [optional] 
**IncludeFacets** | **bool** | Whether facets are returned as part of the search results | [optional] 
**Operator** | **string** | The operator (OR, AND), default to AND | [optional] 
**Properties** | **List&lt;string&gt;** | The collection of properties, represented as string. According to the search engine, a list of properties may be required to retrieve the documents properties | [optional] 
**SearchTerms** | **string** | The search terms for this search query | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

