# Yaksa.OrckestraCommerce.Client.Model.DeleteProductsRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**FilterByPublicationStatus** | **string** | The publication status to filter the products by. The filtering isn&#39;t applied for explicitly passed Product Ids. | [optional] 
**IncludeUncategorized** | **bool** | When set to true, will indicate that all of the uncategorized products should be deleted. | [optional] 
**ParentCategoryIds** | **List&lt;string&gt;** | The categories id values of the categories from which products will be deleted. | [optional] 
**ProductIds** | **List&lt;string&gt;** | The id values of the products to be deleted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

