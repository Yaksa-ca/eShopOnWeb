# Yaksa.OrckestraCommerce.Client.Model.PostProcessOrderRequest
Orders are entities which represent an order of a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FinishedStatusesToIgnore** | **List&lt;string&gt;** | Gets or sets a list of statuses that are not considered as finished. | [optional] 
**RestartFulfillmentProcess** | **bool** | Gets or sets a value indicating whether if the fulfillment process for this order needs to be restarted. | [optional] 
**ShipmentIds** | **List&lt;string&gt;** | The optional list of shipment ids to filter for reprocessing the order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

