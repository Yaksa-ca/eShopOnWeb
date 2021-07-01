# Yaksa.OrckestraCommerce.Client.Model.AddOrUpdateRecurringOrderLineItemsRequest
Recurring orders are orders that are created automatically by the system based on a schedule defined by the customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LineItems** | [**List&lt;RecurringOrderLineItem&gt;**](RecurringOrderLineItem.md) | The list of line items to update | 
**MustApplyUpdatesToRecurringCart** | **bool** | A value indicating whether the values from the RecurringOrderLineItem will be applied to the recurring carts as well.  New values will always be added to a recurring cart. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

