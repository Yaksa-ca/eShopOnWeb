# Yaksa.OrckestraCommerce.Client.Model.Category
Category

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**CatalogId** | **string** | The catalog id | [optional] 
**Children** | [**List&lt;Category&gt;**](Category.md) | The child categories (list of Category) | [optional] 
**Created** | **DateTime** | The date of creation of the Category | [optional] 
**CreatedBy** | **string** | The identifier of the user who created the Category | [optional] 
**DefinitionName** | **string** | The name of the definition of the Category | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**IncludeInSearch** | **bool** | Whether the category is included in the search | [optional] 
**LastModified** | **DateTime** | The date of the last modification to the Category | [optional] 
**LastModifiedBy** | **string** | The identifier of the user who last modified the Category | [optional] 
**PrimaryParentCategoryId** | **string** | The primary parent category id | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | The relationships of the Category | [optional] 
**SequenceNumber** | **int** | The number used for ordering the Category. An integer that allows the ordering of the categories when they are presented in a list. No restriction is given for the number (e.g. it allows two categories to have the same value for this property) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

