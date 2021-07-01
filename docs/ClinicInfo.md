# Yaksa.OrckestraCommerce.Client.Model.ClinicInfo
ClinicInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClinicId** | **string** | The identifier of the clinic | [optional] 
**IsScopeActive** | **bool** | Whether the scope associated to this clinic is active or not | [optional] 
**ClinicGroupId** | **string** | The Clinic Group this clinic belongs to, if any | [optional] 
**ParentHierarchy** | **List&lt;string&gt;** | The clinic&#39;s parent hierarchy, from closest parent to farthest | [optional] 
**ScopeId** | **string** | The identifier of the scope the clinic belongs to | [optional] 
**DefaultCulture** | **string** | The default culture of the clinic | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**StoreInfo** | [**ClinicStoreInfo**](ClinicStoreInfo.md) |  | [optional] 
**FulfillmentLocations** | [**List&lt;FulfillmentLocationInfo&gt;**](FulfillmentLocationInfo.md) | Information about the fulfillment locations associated to the clinic | [optional] 
**UrlInfo** | [**UrlInfo**](UrlInfo.md) |  | [optional] 
**IsMigrated** | **bool** | True if the clinic is migrated from another platform. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

