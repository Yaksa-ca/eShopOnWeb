# Yaksa.OrckestraCommerce.Client.Model.RewardDefinition
RewardDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ConsumabilityRules** | [**List&lt;ConsumabilityRule&gt;**](ConsumabilityRule.md) | the rules used to determine whether an entity should be used when validating the conditions of this promotion. | [optional] 
**Disambiguation** | **string** | the disambiguation method. | [optional] 
**ExcludeDiscountedItems** | **bool** | a flag indicating whether discounted items should be excluded when evaluating this reward. | [optional] 
**Level** | **string** | the level of the reward: on which part of the order the promotion is applied. | [optional] 
**MatchQuantityOrLess** | **bool** | the value indicating whether the reward condition can be less than the quantity specified. | [optional] 
**MatchQuantityOrMore** | **bool** | the value indicating whether the reward can be more than the quantity specified. | [optional] 
**Quantity** | **double** | the quantity of targets on which the reward will apply. | [optional] 
**RewardTargets** | [**List&lt;RewardTarget&gt;**](RewardTarget.md) | a list of reward targets on which the reward will be applied.  | [optional] 
**RewardType** | **string** | The type of reward. (e.g: Discount or External) | [optional] 
**UnitOfMeasure** | **string** | the UnitOfMeasure (Unit, Kilogram, Liter, etc..) of the reward. | [optional] 
**UseConsumedItemsFromConditions** | **bool** | the value indicating whether the reward can use items consumed in the conditions. | [optional] 
**Value** | **double** | the value of the reward. | [optional] 
**ValueType** | **string** | the type of the value of the reward: how the Value will be applied to the RewardTargets. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

