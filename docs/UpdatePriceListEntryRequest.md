# Yaksa.OrckestraCommerce.Client.Model.UpdatePriceListEntryRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsIgnored** | **bool** | Gets or sets a value indicating whether the price should be ignored, default is false. If set to true, the price entry will override the parent but will be ignored at the scope level, thus fallbacking to the next available price entry in the current scope | [optional] 
**Price** | **double** | The price of the updated price list entry | [optional] 
**PriceListId** | **string** | The id of the price list for which we want to update a price list entry | [optional] 
**VariantId** | **string** | The id of the variant for which we want to update a price list entry | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

