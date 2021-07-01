# Yaksa.OrckestraCommerce.Client.Model.GetProductsBySkuV2Request
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CultureName** | **string** | The culture name in which language tha data will be returned | [optional] 
**IncludePriceLists** | **bool** | whether or not to include the price lists of the products. | [optional] 
**IncludeRelationships** | **bool** |  Gets or sets a value indicating whether or not to include the relationships of the products. | [optional] 
**SearchVariantSkus** | **bool** | Gets or sets a value indicating whether or not to search for variant SKU-s, in addition to searching in product SKU-s. | [optional] 
**Sku** | **string** | the stock keeping unit code (SKU) for the products to retrieve | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

