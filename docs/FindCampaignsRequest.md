# Yaksa.OrckestraCommerce.Client.Model.FindCampaignsRequest
Campaigns are entities used to organize marketing promotions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationName** | **string** | The name of the configuration to use to process this request | [optional] 
**CultureName** | **string** | The culture (language) to use to process the request (en-US) | 
**Query** | [**Query**](Query.md) |  | [optional] 
**CampaignStatus** | **string** | The status of the campaign(s) to search for. | [optional] 
**CampaignType** | **string** | The type of the campaign. | [optional] 
**EffectiveDateTime** | **DateTime** | The date time at which the campaign must be effective. | [optional] 
**EndDateRange** | [**RangeDateTime**](RangeDateTime.md) |  | [optional] 
**SearchMode** | **string** | The campaign search mode. | [optional] 
**SearchTerm** | **string** | The search term used by the query. The search term will search on the campaign name. | [optional] 
**StartDateRange** | [**RangeDateTime**](RangeDateTime.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

