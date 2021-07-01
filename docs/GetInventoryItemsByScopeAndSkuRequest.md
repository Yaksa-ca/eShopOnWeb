# Yaksa.OrckestraCommerce.Client.Model.GetInventoryItemsByScopeAndSkuRequest
Inventory items are a combination of InventoryQuantity and InventorySchedules.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**Date** | **DateTime** | The date which will be used to compute the status. If is not set, DateTime.Now will be used. | [optional] 
**IncludeChildScopes** | **bool** | Whether inventory locations from child scopes should also be included in the results. | [optional] 
**MaximumItems** | **int** | The maximum items returned by the search query, default to 50 | [optional] 
**Sku** | **string** | Sku which will be associated to the InventoryLocationId to retrieve InventoryItem | [optional] 
**SortDirection** | **string** | The sort direction. (Ascending or descending) | [optional] 
**SortOrderField** | **string** | the sort order field. | [optional] 
**StartingIndex** | **int** | The starting index | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

