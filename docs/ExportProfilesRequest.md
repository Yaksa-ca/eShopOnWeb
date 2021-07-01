# Yaksa.OrckestraCommerce.Client.Model.ExportProfilesRequest
Integration resources dedicated to data exchanges across system boundaries or other systems.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | The correlation id for the durable task. | [optional] 
**ExcludeDeletedProfiles** | **bool** | Indicates whether to exclude the deleted profiles. | [optional] 
**FileFormat** | **string** | The file format of the export, JSON or XML. If not set the export will be in JSON. (Optional) | [optional] 
**FilePath** | **string** | The File path in the blob storage. (Optional) | [optional] 
**ProfilesToExport** | **List&lt;string&gt;** | Profiles to export, if not set all profiles will be exported. (Optional) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

