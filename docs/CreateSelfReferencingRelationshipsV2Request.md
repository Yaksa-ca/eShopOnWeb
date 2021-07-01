# Yaksa.OrckestraCommerce.Client.Model.CreateSelfReferencingRelationshipsV2Request
The API used to handle Relationships between entities.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | A quantity for the Relationship. For example, X has 7 items of the relation Y. | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Entities** | [**List&lt;RelationshipEntity&gt;**](RelationshipEntity.md) | Indicates the entities to which the relationships are to be applied | [optional] 
**EntitiesType** | **string** | Indicates the type of the entities | [optional] 
**MerchandiseType** | **string** | The MerchandiseType of the relationships. The type is based on the MerchandiseType Lookup. Contains the value of the lookup | [optional] 
**Qualifier** | **string** | A qualifier for the Relationship. Flexible property that allows the consumer to enter custom information about the relationship | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

