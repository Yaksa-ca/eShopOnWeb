# Yaksa.OrckestraCommerce.Client.Model.TargetingCondition
TargetingCondition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BinaryOperator** | **string** | The binary operator which will be apply between the children targeting conditions. | [optional] 
**Children** | [**List&lt;TargetingCondition&gt;**](TargetingCondition.md) | The children of this targeting condition. | [optional] 
**CollectionOperator** | **string** |  Gets or sets the operator to apply on the Value to get the promotion when the target is used on a collection. | [optional] 
**Not** | **bool** |  Gets or sets a value indicating whether to use the Operator should NOT be matched. | [optional] 
**Operator** | **string** | The operator to apply on the Value to get the promotion. | [optional] 
**PropertyPath** | **string** | The relative path of the property used for the condition | [optional] 
**Type** | **string** | The type of condition | [optional] 
**Value** | **Object** | Object | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

