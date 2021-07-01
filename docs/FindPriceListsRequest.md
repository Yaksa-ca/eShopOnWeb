# Yaksa.OrckestraCommerce.Client.Model.FindPriceListsRequest
Products are entities which represents a buyable item managed in a catalog.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CultureName** | **string** | The culture name in which language the data will be returned | [optional] 
**EndDate** | **DateTime** | Gets or sets the upper bound of dates used to filter returned priceLists (optional). Set this date to filter the results to price lists active before this date. | [optional] 
**IncludeExpiredEntries** | **bool** | Gets or sets a value indicating whether expired entries should be returned. Default is false. | [optional] 
**StartDate** | **DateTime** | Gets or sets the lower bound of dates used to filter returned priceLists (optional). Set this date to filter the results to price lists active after this date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

