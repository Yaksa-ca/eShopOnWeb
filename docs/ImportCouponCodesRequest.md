# Yaksa.OrckestraCommerce.Client.Model.ImportCouponCodesRequest
A promotion defines a set of rewards that can be applied to a Cart if a set of conditions are true.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**CouponCodes** | **List&lt;string&gt;** | The list of coupon codes to add to the promotion | [optional] 
**PromotionName** | **string** | The (friendly) name of the promotion (used in messages instead of the unique id) | [optional] 
**RequestedBy** | **string** | The user name of the request initiator | [optional] 
**TaskId** | **string** | The task id. Use this to query the system for the state of the task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

