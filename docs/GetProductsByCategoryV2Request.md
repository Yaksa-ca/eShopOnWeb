# Yaksa.OrckestraCommerce.Client.Model.GetProductsByCategoryV2Request
Categories are entities which represents a classification of products.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CultureName** | **string** | The culture name in which language the data will be returned | [optional] 
**IncludeVariants** | **bool** | whether or not to include the variants (if they exists) of the product. | [optional] 
**IncludeMedia** | **bool** |  Gets or sets a value indicating whether or not to include the media of the product. | [optional] 
**IncludePriceLists** | **bool** | whether or not to include the price lists of the product. | [optional] 
**IncludeRelationships** | **bool** |  Gets or sets a value indicating whether or not to include the relationships of the product. | [optional] 
**CategoryId** | **string** | The category id at which point in the category hierarchy should the &#39;get products&#39; be started. | 
**ContinuationToken** | **string** | The continuation token used for pagination | [optional] 
**PageSize** | **int** | The maximum number of products to return. Default value : 10 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

