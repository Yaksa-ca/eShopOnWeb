# Yaksa.OrckestraCommerce.Client.Model.TaskInfo
TaskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | The correlation id. | [optional] 
**Created** | **DateTime** | The date at which the task was created | [optional] 
**FaultedReason** | **string** | The reason why the task faulted, if relevant. | [optional] 
**InputArguments** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**IsSequential** | **bool** | Value indicating whether a task must be run as part of the specific sequence that the tasks were queued rather than being run at the same time. | [optional] 
**LastModified** | **DateTime** | The date at which the task was modified | [optional] 
**LogEntriesCount** | **int** | The number of log entries. | [optional] 
**Name** | **string** | The task name | [optional] 
**OutputArguments** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Requester** | **string** | The user who requested the task | [optional] 
**ResultBlobUrl** | **string** | The url to a a resource containing the result of the task execution | [optional] 
**RetryCount** | **int** | Gets or sets the number of retries to execute the task or resuming a bookmark. | [optional] 
**SequenceGroup** | **string** | The name to identify the sequence that this task is part of. Tasks that must execute in sequence must share the same SequenceGroup | [optional] 
**SequenceNumber** | **long** | The number of the task in the sequence it is part of. | [optional] 
**SequenceQuota** | **int** | Value indicating what is the expected maximum sequence count. | [optional] 
**Status** | **string** | The task current status | [optional] 
**TaskId** | **string** | The unique Id for the task | [optional] 
**Type** | **string** | The type of the current task | [optional] 
**WorkflowActivityType** | **string** | Gets or sets the type of the workflow activity. | [optional] 
**WorkflowXamlPath** | **string** | Gets or sets the relative workflow xaml path. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

