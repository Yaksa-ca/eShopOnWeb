# Yaksa.OrckestraCommerce.Client.Model.UpdateProductSettingsRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowTranslationFromSalesToGlobal** | **bool** | whether or not the changes to multilingual attributes in a sales scope should be copied over to the Global scope. | [optional] 
**AvailableInventoryStatuses** | **string** | the list of inventory statuses available to search. | [optional] 
**DefaultProductImportStatus** | **string** | Specify what will be the Active value for the products imported. | [optional] 
**EnableExtendedProductWorkflow** | **bool** | a value indicating whether the product workflow is simple (false) or with composer (true). | [optional] 
**IsInventoryEnabled** | **bool** | Determine if the inventory is enabled | [optional] 
**IsPricingAuditEnabled** | **bool** | the changes made to an price will be audited | [optional] 
**MaxNumberOfMediaItems** | **int** | the maximum number of media items | [optional] 
**MaxNumberOfProductAttributes** | **int** | the maximum number of product attributes | [optional] 
**MaxNumberOfRelationships** | **int** | the maximum number of relations | [optional] 
**MaxNumberOfVariantAttributes** | **int** | the maximum number of variant attributes. | [optional] 
**MaxNumberOfVariants** | **int** | the maximum number of variants | [optional] 
**NewProductDays** | **int** | the number of days the product stays in the New count. | [optional] 
**NotifySameScopeOtherLanguages** | **bool** | Whether or not to create notifications (for changes in system culture)  to all other languages of the same scope as the changes. | [optional] 
**OverrideGreaterThanZeroPricingConstraint** | **bool** | System setting to allow overriding the default behavior of not allowing any product with regular prices to be saved at 0 pricing. | [optional] 
**ProductExportMaxNumberOfItemPerFile** | **int** | the maximum number of product in a file for the product export. | [optional] 
**PropertyBag** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**SkuUniquenessLevel** | **string** | Specifies the product and variant sku uniqueness level. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

