# Yaksa.OrckestraCommerce.Client.Model.Lookup
Lookup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The description of this lookup | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**IsActive** | **bool** | If the lookup is active. Lookup can not be used after being deactivated but previous references are not deleted. | [optional] 
**IsSystem** | **bool** | If the lookup value is part of the base system. | [optional] 
**LookupName** | **string** | The name for the Lookup. This is the business key. Should be unique and not null. | [optional] 
**Values** | [**List&lt;LookupValue&gt;**](LookupValue.md) | The list of values available for the Lookup. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

