# Yaksa.OrckestraCommerce.Client.Model.ClinicProductInformationImportRequest
Regroupment of all custom CDMV services, notably for clinics related operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The path of the file(s) to import. | [optional] 
**ContainerName** | **string** | The name of container which import file exists | [optional] 
**MaximumErrors** | **int** | The maximum number of validation errors that can be encountered. 0 means infinite number. | [optional] 
**TaskId** | **string** | the task id. Use this to query the system for the state of the task. | [optional] 
**FileFormat** | **string** | The file format of the import, Zip, JSON, XML or Excel. | [optional] 
**AllowPricesDeleting** | **bool** | Whether or not the import have to delete prices which are not specified in the import file. | [optional] 
**ReIndex** | **bool** | Whether or not the indexes are built after the import. The default value is True (when not set). | [optional] 
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**RebuildSearchIndex** | **bool** | Indicates whether or not the search indexes are rebuilt after the import. The default value is True (when not set). | [optional] 
**ExtendedOptions** | [**ImportProductExtendedOptions**](ImportProductExtendedOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

