# Yaksa.OrckestraCommerce.Client.Model.CDMVCreateCustomerRequest
Regroupment of all custom CDMV services, notably for clinics related operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailAddress** | **string** | Customer email address. | [optional] 
**FileNumber** | **string** | Customer file numer. | [optional] 
**FirstName** | **string** | Customer first name. | [optional] 
**LastName** | **string** | Customer last name. | [optional] 
**Password** | **string** | Customer password. | [optional] 
**ProductIdAuthorizations** | [**List&lt;ProductIdAuthorization&gt;**](ProductIdAuthorization.md) | Customer product id authorization. | [optional] 
**B2CAccountCreationType** | **string** | The customer&#39;s B2C site profile account type. | [optional] 
**Language** | **string** | Customer preferred language | [optional] 
**NewsletterOptIn** | **bool** | Whether the customer is subscribed to receive email newsletters | [optional] 
**OriginalId** | **string** | The customer&#39;s original ID. Defaults to the customer&#39;s email address if no value is provided. | [optional] 
**InvitationEmailAddress** | **string** | Customer email address used for the invitation to create his account. | [optional] 
**ExcludeFromWelcomePromo** | **bool** | True if the customer is not eligible for the Welcome promotion. | [optional] 
**PhoneNumber** | **string** | Customer phone number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

