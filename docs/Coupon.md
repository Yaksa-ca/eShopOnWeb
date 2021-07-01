# Yaksa.OrckestraCommerce.Client.Model.Coupon
Coupon

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CouponCode** | **string** | The coupon code. This is the string that is to be entered on the Cart or Order to be able to fetch the coupon and apply the promotion. It is unique in the system. | [optional] 
**CouponState** | **string** | Gets or sets a value to indicate if the coupon is usable and the reason when it is not. | [optional] 
**DisplayText** | **string** | The coupon display text. | [optional] 
**HasBeenConsumed** | **bool** | Gets or sets a value indicating whether or not the coupon has been consumed in a previous order submission. This will be used to un-consume a coupon if it is no longer active when submitted. (Cart and draft only) | [optional] 
**Id** | **string** | The unique identifier of the coupon. | [optional] 
**IsActive** | **bool** | Gets or sets a value indicating whether or not the coupon is being applied to the current order. (Cart and draft only) | [optional] 
**IsDeleted** | **bool** | Gets or sets a value indicating whether or not the coupon has a soft delete. This is used to ensure that coupons that have been previously consumed are not removed before they are de-consumed. (Cart and draft only) | [optional] 
**Mode** | **string** | The coupon mode.  This mode is used to know if the coupon is unique for this promotion, or part of a set of coupons. | [optional] 
**PromotionId** | **string** | The unique identifier of the promotion to which the coupon is associated. | 
**UsedCount** | **int** | Gets or sets the number of times the promo code was used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

