# Yaksa.OrckestraCommerce.Client.Model.InviteNewOrganizationalCustomerRequest
Regroupment of all custom CDMV services, notably for clinics related operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The customer&#39;s first name. | [optional] 
**LastName** | **string** | The customer&#39;s last name. | [optional] 
**EmailAddress** | **string** | The customer&#39;s email address | [optional] 
**Language** | **string** | The customer&#39;s preferred language. | [optional] 
**ProductIdAuthorizations** | [**List&lt;ProductIdAuthorization&gt;**](ProductIdAuthorization.md) | The list of product authorizations that will be added to his account. The status here is meaningless and its value will be ignored, as it will always default to Authorized when the customer creates his account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

