# Yaksa.OrckestraCommerce.Client.Model.BulkAssignProductCategoriesRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryIdsToAssign** | **List&lt;string&gt;** | When specified, the products will have those categories assigned. | [optional] 
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**FilterByPublicationStatus** | **string** | The publication status to filter the products by. The filtering isn&#39;t applied for explicitly explicitly passed Product Ids. | [optional] 
**IncludeUncategorized** | **bool** | When set to true, will indicate that all of the uncategorized products should be updated. | [optional] 
**MoveProducts** | **bool** | When set to true, the products will be disassociated form the previously assigned categories. | [optional] 
**ParentCategoryIds** | **List&lt;string&gt;** | The id-s of the categories, products of which should be updated. | [optional] 
**ProductIds** | **List&lt;string&gt;** | The id values of the products to be updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

