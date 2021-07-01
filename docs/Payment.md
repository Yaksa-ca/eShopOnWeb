# Yaksa.OrckestraCommerce.Client.Model.Payment
Payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Amount** | **double** | The amount of this payment. | [optional] 
**BillingAddress** | [**Address**](Address.md) |  | [optional] 
**BillingAddressId** | **string** | The unique identifier of the billing address to use for this payment. | [optional] 
**Created** | **DateTime** | The creation date. | [optional] 
**CreatedBy** | **string** | The identity of the user who created the payment. | [optional] 
**LastModified** | **DateTime** | The last modification date. | [optional] 
**LastModifiedBy** | **string** | The identity of the user who modified the payment. | [optional] 
**PaymentCaptureAction** | [**PaymentCaptureAction**](PaymentCaptureAction.md) |  | [optional] 
**PaymentDate** | **DateTime** | the date when the payment was made. | [optional] 
**PaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**PaymentStatus** | **string** | The status of the payment. Typical values will include: Outstanding, Verified, Authorized, Paid | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

