# Yaksa.OrckestraCommerce.Client.Model.AddFromGlobalRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**CultureNames** | **List&lt;string&gt;** | The names of the cultures for which localized data should be preserved. | [optional] 
**OverwriteIsActiveWith** | **bool** | Indicates whether to set IsActive property of the pushed products to &#39;true&#39;. | [optional] 
**ParentCategoryIds** | **List&lt;string&gt;** | The categories id values of the categories for which to take the products from. | [optional] 
**ProductIds** | **List&lt;string&gt;** | The id values of the products to be pushed to a sales scope. | [optional] 
**TaskId** | **string** | the task id. Use this to query the system for the state of the task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

