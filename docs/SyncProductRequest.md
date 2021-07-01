# Yaksa.OrckestraCommerce.Client.Model.SyncProductRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefinitionName** | **string** | Gets or sets the definition name for the product to be synchronized.  | [optional] 
**DeleteVariantModifications** | [**List&lt;DeleteVariantModification&gt;**](DeleteVariantModification.md) | Gets or sets the list of modifications that the draft should apply to the variants | 
**ParentCategoriesModification** | [**ParentCategoriesModification**](ParentCategoriesModification.md) |  | 
**PrimaryParentCategoryModification** | [**PrimaryParentCategoryModification**](PrimaryParentCategoryModification.md) |  | 
**ProductPropertyModifications** | **Dictionary&lt;string, List&lt;ProductPropertyModification&gt;&gt;** | Dictionary&lt;String,List&lt;ProductPropertyModification&gt;&gt; | 
**VariantPropertyModifications** | **Dictionary&lt;string, List&lt;VariantPropertyModification&gt;&gt;** | Dictionary&lt;String,List&lt;VariantPropertyModification&gt;&gt; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

