# Yaksa.OrckestraCommerce.Client.Model.ProductAuthorization
ProductAuthorization

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Id of this custom profile&#39;s instance | [optional] 
**CustomerId** | **string** | The Id of the customer this product authorization belongs to | [optional] 
**ProductId** | **string** | The product Id this authorization is for | [optional] 
**Product** | [**Product**](Product.md) |  | [optional] 
**RequestedDate** | **DateTime** | The date the authorization was requested at | [optional] 
**ExpiryDate** | **DateTime** | The date the authorization expires | [optional] 
**ResolutionDate** | **DateTime** | The date the authorization got resolved (accepted or refused) | [optional] 
**Status** | **string** | The current status of the authorization | [optional] 
**IsExpired** | **bool** | Whether the authorization has expired or not. | [optional] 
**IsActive** | **bool** | Whether the product authorization is active or not. This means that the customer is able to purchase the product associated to this authorization. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

