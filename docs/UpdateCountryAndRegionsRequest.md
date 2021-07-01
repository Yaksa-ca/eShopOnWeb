# Yaksa.OrckestraCommerce.Client.Model.UpdateCountryAndRegionsRequest
Globalization are entities related to regional settings. Such as countries, regions, timezones and cultures.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSupported** | **bool** | The indicator specifying if the Country is supported by the merchant | [optional] 
**Name** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**PhoneRegex** | **string** | The Country&#39;s telephone validation regular expression | [optional] 
**PostalCodeRegex** | **string** | The Country&#39;s postal code validation regular expression | [optional] 
**Regions** | [**List&lt;Region&gt;**](Region.md) | The list of Region associated to the Country | [optional] 
**SortOrder** | **int** | The number used for ordering the Country in a list | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

