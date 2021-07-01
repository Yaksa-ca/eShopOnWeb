# Yaksa.OrckestraCommerce.Client.Model.SearchAvailableProductsByCategoryRequest
The API used to query the search engine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationName** | **string** | The name of the configuration to use to process this request | [optional] 
**Query** | [**Query**](Query.md) |  | [optional] 
**AutoCorrect** | **bool** | Whether search term should be automatically corrected | [optional] 
**AvailabilityDate** | **DateTime** | the date at which the product should be available | [optional] 
**BoostQueryParams** | **List&lt;string&gt;** | The boost query parameters for this search. This will append a &#39;bq&#39; parameter to the call to Solr for each param. | [optional] 
**FacetPredicates** | [**List&lt;FacetPredicate&gt;**](FacetPredicate.md) | List of FacetPredicates to apply on the search | [optional] 
**Facets** | **List&lt;string&gt;** | The facets, a list of strings, that will be included in the results | [optional] 
**IncludeFacets** | **bool** | Whether facets are returned as part of the search results | [optional] 
**InventoryLocationIds** | **List&lt;string&gt;** | the Ids of the inventory locations where the products should be available. | [optional] 
**InventoryLocationOperator** | **string** | should the products found be available in all (AND) or in any (OR) of the inventory locations. | [optional] 
**InventoryStatuses** | **List&lt;string&gt;** | The inventory statuses to filter by. If none are specified, the value will be taken from the product setting &#39;AvailableInventoryStatuses&#39; (InStock, OutOfStock, BackOrder). | [optional] 
**Properties** | **List&lt;string&gt;** | The collection of properties, represented as a string. According to the search engine, a list of properties may be required to retrieve the document properties | [optional] 
**SearchTerms** | **string** | The search terms for this search query | [optional] 
**VariantGroupingStrategy** | **string** | The variant grouping strategy | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

