# Yaksa.OrckestraCommerce.Client.Model.GetCustomerOrganizationsRequest
Customers represents entities which have the ability to buy products.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CustomerId** | **string** | The unique identifier of the customer. | [optional] 
**IncludeAllAddresses** | **bool** | Gets or sets a value indicating whether all addresses should be returned or only the first one. If False only one organization address will be returned using either IsPreferredBilling or IsPreferredShipping as priority. If True every organization addresses for the customer will be returned | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

