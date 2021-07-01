# Yaksa.OrckestraCommerce.Client.Model.GetCartsByCustomerIdRequest
Carts are entities used for assembling an order before submitting.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CartType** | **string** | The optional cart type. Only the carts of this specific type will be returned. | [optional] 
**CultureName** | **string** | The culture name in which language the data will be returned. | [optional] 
**CustomerId** | **string** | The unique identifier of the Customer owning the cart | 
**IncludeChildScopes** | **bool** | a value indicating whether to include carts found in child scopes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

