# Yaksa.OrckestraCommerce.Client.Model.GetInventoryItemsByScopeAndSkusRequest
Inventory items are a combination of InventoryQuantity and InventorySchedules.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime** | The date which will be used to compute the status. If is not set, DateTime.Now will be used. | [optional] 
**IncludeChildScopes** | **bool** | Whether inventory locations from child scopes should also be included in the results. | [optional] 
**MaximumItems** | **int** | The maximum items returned by the search query | [optional] 
**Skus** | **List&lt;string&gt;** | SKUs which will be associated to the InventoryLocationId to retrieve inventory items | [optional] 
**SortDirection** | **string** | The sort direction. (Ascending or descending) | [optional] 
**SortOrderField** | **string** | the sort order field. | [optional] 
**StartingIndex** | **int** | The starting index | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

