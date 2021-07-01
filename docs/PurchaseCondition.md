# Yaksa.OrckestraCommerce.Client.Model.PurchaseCondition
PurchaseCondition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ConsumabilityRules** | [**List&lt;ConsumabilityRule&gt;**](ConsumabilityRule.md) | the rules used to determine whether an entity should be used when validating the conditions of this promotion. | [optional] 
**ExcludeDiscountedItems** | **bool** | a flag indicating whether discounted items should be excluded when evaluating this condition. | [optional] 
**Level** | **string** | The level of the purchase condition: on which part of the cart the condition will be applied. | [optional] 
**Targets** | [**List&lt;PurchaseConditionTarget&gt;**](PurchaseConditionTarget.md) | a list of the targets on which the condition will be applied. | [optional] 
**Type** | **string** | The type: how the Value will be applied to the Targets. | [optional] 
**UnitOfMeasure** | **string** | the UnitOfMeasure (Unit, Kilogram, Liter, etc..) of the condition. | [optional] 
**Value** | **double** | the value of the condition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

