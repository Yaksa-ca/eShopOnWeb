# Yaksa.OrckestraCommerce.Client.Model.SearchQuery
SearchQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the Search query | [optional] 
**ScopeId** | **string** | Scope of the Search query | [optional] 
**Name** | **string** | Name of the search query | [optional] 
**Category** | **string** | Category of the search query | [optional] 
**QueryType** | **string** | The type of the search query | [optional] 
**SupportedCultures** | **List&lt;string&gt;** | List of all supported cultures of the search query. If the query is auto-localizable, contains the list of the catalog supported cultures | [optional] 
**SupportsAllCulturesInCatalog** | **bool** | True if the query supports all the cultures of the catalog | [optional] 
**Created** | **DateTime** | Date the entity was created | [optional] 
**CreatedBy** | **string** | Identifier of the operator who created the entity | [optional] 
**LastModified** | **DateTime** | Date that the last modification was applied to the entity | [optional] 
**LastModifiedBy** | **string** | Identifier of the operator who last modified the entity | [optional] 
**QueryData** | [**List&lt;SearchQueryData&gt;**](SearchQueryData.md) | The data used to build a search request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

