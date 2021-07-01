# Yaksa.OrckestraCommerce.Client.Model.ValidationFailure
ValidationFailure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttemptedValue** | **Object** | Object | [optional] 
**Context** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Descriptor** | [**ValidationFailureDescriptor**](ValidationFailureDescriptor.md) |  | [optional] 
**EntityId** | **string** | The unique entity identifier for which there was an error | [optional] 
**EntityType** | **string** | The entity type name that was validated | [optional] 
**FullyQualifiedPropertyName** | **string** | The complete contextual property name given it&#39;s position in the entity hierarchy. Example: [ContextClass].[ContextCollection][IndexInCollection].[PropertyName] | [optional] 
**PropertyName** | **string** | The name of the property to which the validation failure applied | [optional] 
**Severity** | **string** | The severity level of the failure | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

