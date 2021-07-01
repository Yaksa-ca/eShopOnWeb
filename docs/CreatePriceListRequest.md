# Yaksa.OrckestraCommerce.Client.Model.CreatePriceListRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CultureName** | **string** | The culture name in which language the data will be returned | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**EndDate** | **DateTime** | The end date of the PriceList | [optional] 
**NextHigherPriorityPriceListId** | **string** | The identifier of the price list with the next higher priority. If null, the price list will have the highest priority. | [optional] 
**RebuildSearchIndex** | **bool** | Whether or not the product prices search index will be built rollowing the import. The default value is False. | [optional] 
**StartDate** | **DateTime** | The start date of the PriceList | [optional] 
**Type** | **string** | The type of the PriceList. | [optional] 
**Category** | **string** | The category of the PriceList. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

