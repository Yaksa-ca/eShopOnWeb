# Yaksa.OrckestraCommerce.Client.Model.UpdateProductDraftRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | Gets or sets the culture (language) name in which the product draft is processed | 
**DeleteVariantModifications** | [**List&lt;DeleteVariantModification&gt;**](DeleteVariantModification.md) | Gets or sets the list of modifications that the draft should apply to the variants | 
**OverwriteModifications** | **bool** | Gets or sets a value indicating wheter to clear the existing motifications and save only the list given in this request or add the given motifications to the existing list. The default value is &#39;true&#39; | [optional] 
**ParentCategoriesModification** | [**ParentCategoriesModification**](ParentCategoriesModification.md) |  | 
**PrimaryParentCategoryModification** | [**PrimaryParentCategoryModification**](PrimaryParentCategoryModification.md) |  | 
**ProductPropertyModifications** | [**List&lt;ProductPropertyModification&gt;**](ProductPropertyModification.md) | Gets or sets the list of modifications that the draft should apply to the product | 
**VariantPropertyModifications** | [**List&lt;VariantPropertyModification&gt;**](VariantPropertyModification.md) | Gets or sets the list of modifications that the draft should apply to the variants | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

