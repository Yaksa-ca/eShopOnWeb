# Yaksa.OrckestraCommerce.Client.Model.FindProductAuthorizationsByStatusRequest
Regroupment of all custom CDMV services, notably for clinics related operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status to use for the search. Default value is Pending | [optional] 
**IncludeProductDetails** | **bool** | Whether to include the details of the products | [optional] 
**IncludeVariants** | **bool** | Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered | [optional] 
**CultureName** | **string** | The culture name which dictates in which language localized values are returned in | [optional] 
**IncludeCustomerInfo** | **bool** | Whether to include the customer information for each of the product authorizations | [optional] 
**ResultsPerPage** | **int** | The maximum number of results that can be returned at once. Defaults to 50 | [optional] 
**StartingPage** | **int** | If the results are returned on multiple pages, this indicates which page of results to return | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

