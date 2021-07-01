# Yaksa.OrckestraCommerce.Client.Model.ClearRelationshipsV2Request
The API used to handle Relationships between entities.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**EntityId** | **string** | the entity identifier | [optional] 
**EntityType** | **string** | The type of the entity whose relationship should be deleted. For deleting relationships of a product variant, &#39;Product&#39; should be specified and ParentId should be set to Product Id. | [optional] 
**ParentId** | **string** | This parameter should be specified when deleting a product variant. In this case this field will contain product&#39;s Id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

