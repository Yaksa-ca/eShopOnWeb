# Yaksa.OrckestraCommerce.Client.Model.IndexProductsRequest
The API used to query the search engine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IgnoreSequenceQuota** | **bool** | Value indicating whether the task sequence quota should be ingored. Default value is TRUE | [optional] 
**IndexingType** | **string** | The possible indexing types are &#39;partial&#39;, &#39;full&#39; or &#39;clean&#39;. The &#39;clean&#39; indexing will clean the index and re-index all documents (default: &#39;partial&#39;). | [optional] 
**TaskName** | **string** | The name that will be given to task executing the indexing. | [optional] 
**CatalogIds** | **List&lt;string&gt;** | Optional. The list of catalogs to index. If not specified, all catalogs will be indexed. | [optional] 
**CultureNames** | **List&lt;string&gt;** | Optional. The list of cultures to index. If not specified, all cultures will be indexed. | [optional] 
**TargetIndex** | **int** | Optional. The indexes targetted by the rebuild. All by default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

