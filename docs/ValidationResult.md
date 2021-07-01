# Yaksa.OrckestraCommerce.Client.Model.ValidationResult
ValidationResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | A category that applies to the validation results | [optional] 
**ErrorMinimumSeverity** | **string** | The minimum severity to consider as error | [optional] 
**Errors** | [**List&lt;ValidationFailure&gt;**](ValidationFailure.md) | If applicable, a list of all validation failures associated with the result | [optional] 
**IsValid** | **bool** | Returns true if all errors are lesser than ErrorMinimumSeverity | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

