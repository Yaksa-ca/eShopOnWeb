# Yaksa.OrckestraCommerce.Client.Model.CreateRelationshipsRequest
The API used to handle Relationships between entities.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entities** | [**List&lt;RelationshipEntity&gt;**](RelationshipEntity.md) | Indicates the entities to which the related entities are to be applied | [optional] 
**EntitiesType** | **string** | Indicates the type of the entities | [optional] 
**MerchandiseType** | **string** | The MerchandiseType of the relationships. The type is based on the MerchandiseType Lookup. Contains the value of the lookup | [optional] 
**Mutual** | **bool** | Indicates whether the relationships to create should be mutual between the entities and the related entities | [optional] 
**RelatedEntities** | [**List&lt;RelationshipEntity&gt;**](RelationshipEntity.md) | Indicates the related entities which are to be applied to the entities | [optional] 
**RelatedEntitiesType** | **string** | Indicates the type of the related entities | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

