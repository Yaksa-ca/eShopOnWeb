# Yaksa.OrckestraCommerce.Client.Model.GetProductsCountByCategoryRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CategoryId** | **string** | The category id at which point in the category hierarchy the &#39;get products&#39; should  be started. If nothing is specified the root is used as starting point | 
**IncludeDescendantsCategories** | **bool** | Whether or not the descendant categories content should be recursively included below the specified starting categoryId | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

