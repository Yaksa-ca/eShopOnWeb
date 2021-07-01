# Yaksa.OrckestraCommerce.Client.Model.GetRequesterTasksInfoRequest
Long running tasks perform batch processing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FilterTaskNames** | **List&lt;string&gt;** | The array of task type names to filter by, if none specified, no filtering is performed. The type names are the fully qualified type names (Eg. Orckestra.Overture.Providers.CommerceEngine.Profiles.ProfileSchemaImportTask, Orckestra.Overture.Providers.CommerceEngine) | [optional] 
**LastModified** | **DateTime** | The last modification date of the task. Use this to limit the results to items after this date | [optional] 
**Requester** | **string** | The username of the user that requested the tasks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

