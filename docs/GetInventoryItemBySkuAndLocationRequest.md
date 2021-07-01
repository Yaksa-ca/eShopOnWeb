# Yaksa.OrckestraCommerce.Client.Model.GetInventoryItemBySkuAndLocationRequest
Inventory items are a combination of InventoryQuantity and InventorySchedules.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**Date** | **DateTime** | The date for which the status will be computed. If is default, DateTime.Now will be used. | [optional] 
**InventoryLocationId** | **string** | business id for the inventory location which will be associated to the Sku to retrieve InventoryItem | [optional] 
**Sku** | **string** | Sku which will be associated to the InventoryLocationId to retrieve InventoryItem | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

