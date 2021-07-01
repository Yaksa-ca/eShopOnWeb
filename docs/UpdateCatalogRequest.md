# Yaksa.OrckestraCommerce.Client.Model.UpdateCatalogRequest
Catalogs are entities which represents markets and buyable Products organized in Categories.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultLanguage** | **string** | The catalog default language. | 
**Description** | **string** | The catalog description. | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**EndDate** | **DateTime** | The catalog ending date. | [optional] 
**IsActive** | **bool** | Whether the catalog is active. | [optional] 
**KeepModifications** | **bool** | A value indicating whether product modifications will remain intact when OverrideParent is set to false. | [optional] 
**Languages** | **List&lt;string&gt;** | The collection of languages (cultures) supported by this catalog. | [optional] 
**OverrideParent** | **bool** | A value indicating whether the products has overridden values in the current Sales scope. | [optional] 
**StartDate** | **DateTime** | The catalog starting date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

