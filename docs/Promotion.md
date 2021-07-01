# Yaksa.OrckestraCommerce.Client.Model.Promotion
Promotion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**AllowConsumedConditionItemsToBeReused** | **bool** | Indicates whether the condition is re-usable | [optional] 
**AllowConsumedRewardItemsToBeReused** | **bool** | Indicates whether the reward is combinable | [optional] 
**CampaignId** | **string** | the Id of the campaign that this promotion belongs to | [optional] 
**CampaignPriority** | **int** | a copy of the priority of the campaign | [optional] 
**Conditions** | [**List&lt;PurchaseCondition&gt;**](PurchaseCondition.md) | the purchase conditions (purchase requirements) for the promotion to be applied. | [optional] 
**ConsumabilityRules** | [**List&lt;ConsumabilityRule&gt;**](ConsumabilityRule.md) | the rules used to determine whether an entity should be used when validating the conditions of this promotion. | [optional] 
**CouponEndDate** | **DateTime** | [Obsolete] the end date. | [optional] 
**CouponMaximumUsageCustomer** | **int** | the maximum usage per customer | [optional] 
**CouponMaximumUsageGlobal** | **int** |  the global maximum usage (across all customers). | [optional] 
**CouponMode** | **string** | What CouponMode kind of coupon, if any, is needed to qualify for this promotion. (None, Single, Multiple) | [optional] 
**CouponSingleCouponCode** | **string** | the coupon code used when in single coupon mode.  | [optional] 
**CouponStartDate** | **DateTime** | [Obsolete] the start date. | [optional] 
**DatetimeFilter** | [**PromotionDatetimeFilter**](PromotionDatetimeFilter.md) |  | [optional] 
**Description** | **string** | the description of the promotion | [optional] 
**EndDate** | **DateTime** | the promotion end date. | [optional] 
**ExcludeDiscountedItems** | **bool** | Indicates whether discounted items should be excluded when evaluating this promotion. | [optional] 
**Exclusivity** | **string** | Indicates exclusivity of the promotion | [optional] 
**IsActive** | **bool** | Indicates whether the promotion is Active | [optional] 
**IsExclusive** | **bool** | Indicates whether this promotion is exclusive or not. | [optional] 
**MaximumRewardAmount** | **double** | Indicates maximum amount of total reward for this promotion | [optional] 
**Name** | **string** | the name of the promotion. | [optional] 
**Priority** | **int** | the priority of the promotion. | [optional] 
**PromotionLimit** | **int** | the number of times that the promotion can be applied to a customer&#39;s cart | [optional] 
**PromotionText** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**RewardDefinitions** | [**List&lt;RewardDefinition&gt;**](RewardDefinition.md) | the reward definitions that are given if the promotion is applied. | [optional] 
**SelectionInfo** | **string** | the internal UI hints for the Orchestrator | [optional] 
**StartDate** | **DateTime** | the promotion start date. | [optional] 
**Targeting** | [**TargetingCondition**](TargetingCondition.md) |  | [optional] 
**VersionNumber** | **int** | the number of the version | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

