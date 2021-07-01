# Yaksa.OrckestraCommerce.Client.Model.CategoryTreeNode
CategoryTreeNode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ChildNodes** | [**List&lt;CategoryTreeNode&gt;**](CategoryTreeNode.md) | The child nodes as a list. This collection can be empty even if HasChildNodes is true. This means that the collection was not fetched from the service | [optional] 
**DisplayName** | **string** | The display name | [optional] 
**HasChildNodes** | **bool** | A value indicating whether this node has child nodes | [optional] 
**Path** | [**CategoryTreePath**](CategoryTreePath.md) |  | [optional] 
**ProductCount** | **long** | The product count. The number of products directly under this category | [optional] 
**SequenceNumber** | **int** | The number used for ordering the CategoryTreeNode in a list. An integer that allows the ordering of the category  tree nodes when they are presented in a list.No restriction is given for the number (e.g. it allows two category tree nodes to have the same value for this property). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

