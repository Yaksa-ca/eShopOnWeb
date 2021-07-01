# Yaksa.OrckestraCommerce.Client.Model.AddOrUpdateProductAuthorizationsByUsernameRequest
Regroupment of all custom CDMV services, notably for clinics related operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | Customer&#39;s username. | [optional] 
**ProductAuthorizations** | [**List&lt;ProductIdAuthorization&gt;**](ProductIdAuthorization.md) | Product authorization(s) to be added or updated. | [optional] 
**IncludeProductDetails** | **bool** | Whether to include the details of the products | [optional] 
**IncludeVariants** | **bool** | Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered | [optional] 
**CultureName** | **string** | The culture name which dictates in which language localized values are returned in | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

