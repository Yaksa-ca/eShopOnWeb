# Yaksa.OrckestraCommerce.Client.Model.GetProductV2Request
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CultureName** | **string** | The culture name in which language the data will be returned | [optional] 
**IncludeVariants** | **bool** | whether or not to include the variants (if they exists) of the product. | [optional] 
**IncludeMedia** | **bool** |  Gets or sets a value indicating whether or not to include the media of the product. | [optional] 
**IncludePriceLists** | **bool** | whether or not to include the price lists of the product. | [optional] 
**IncludeRelationships** | **bool** |  Gets or sets a value indicating whether or not to include the relationships of the product. | [optional] 
**IncludeImageUrl** | **bool** | A value indicating whether or not to include the image url. | [optional] 
**IncludeInheritanceInformation** | **bool** | A value indicating whether to include the list of overridden properties and variants. Applicable for sales scopes. | [optional] 
**ProductId** | **string** | The business id for the product to retrieve | [optional] 
**PublishedVersion** | **bool** | A value indicating whether the published version of the product should be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

