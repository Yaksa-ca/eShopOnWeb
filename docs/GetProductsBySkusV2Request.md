# Yaksa.OrckestraCommerce.Client.Model.GetProductsBySkusV2Request
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | The culture name in which language the data will be returned | [optional] 
**IncludeVariants** | **bool** | whether or not to include the variants (if they exists) of the product. | [optional] 
**IncludeMedia** | **bool** |  Gets or sets a value indicating whether or not to include the media of the product. | [optional] 
**IncludePriceLists** | **bool** | whether or not to include the price lists of the product. | [optional] 
**IncludeRelationships** | **bool** |  Gets or sets a value indicating whether or not to include the relationships of the product. | [optional] 
**SearchVariantSkus** | **bool** | Gets or sets a value indicating whether or not to search for variant SKU-s, in addition to searching in product SKU-s. | [optional] 
**Skus** | **List&lt;string&gt;** | the SKU-s for the products to retrieve | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

