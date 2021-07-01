# Yaksa.OrckestraCommerce.Client.Model.ImportOrdersRequest
Integration resources dedicated to data exchanges across system boundaries or other systems.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**OrderLocationNumber** | **string** | The location (store) of the order | [optional] 
**OrderNumberBatchPrefix** | **string** | Prefix used to allow system integrator to ensure that there will be no clash with current order numbering | [optional] 
**Path** | **string** | The path of the file(s) to import. | [optional] 
**ReplaceExistingOrders** | **bool** | Indicates that existing orders will be replaced based on their Order Number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

