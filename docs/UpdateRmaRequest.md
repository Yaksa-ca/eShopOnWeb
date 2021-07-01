# Yaksa.OrckestraCommerce.Client.Model.UpdateRmaRequest
Orders are entities which represent an order of a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsFinished** | **bool** | whether the RMA is finished. | [optional] 
**RmaExternalNumber** | **string** | the RMA external Number | [optional] 
**RmaItems** | [**List&lt;RmaItem&gt;**](RmaItem.md) | RMA item details | [optional] 
**Status** | **string** | the process status of the RMA | [optional] 
**TotalAmountRefunded** | **double** | Total amount of refunded items, if applicable | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

