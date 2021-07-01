# Yaksa.OrckestraCommerce.Client.Model.ImportProductsPricesRequest
Integration resources dedicated to data exchanges across system boundaries or other systems.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowPricesDeleting** | **bool** | Whether or not the import have to delete prices which are not specified in the import file. | [optional] 
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**MaximumErrors** | **int** | The maximum number of validation errors that can be encountered. | [optional] 
**Path** | **string** | The path of the file(s) to import. | [optional] 
**RebuildSearchIndex** | **bool** | Indicates whether or not the search indexes are rebuilt after the import. The default value is True (when not set) | [optional] 
**TaskId** | **string** | the task id. Use this to query the system for the state of the task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

