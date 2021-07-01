# Yaksa.OrckestraCommerce.Client.Model.QueueWorkflowTaskRequest
Long running tasks perform batch processing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | The correlation identifier allowing to regroup and retrieve various tasks together. | [optional] 
**Inputs** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**IsSequential** | **bool** | Value indicating whether the task must be run in the specific sequence. | [optional] 
**SequenceGroup** | **string** | The name to identify the sequence that this task is part of. Tasks that must execute in sequence must share the same SequenceGroup | [optional] 
**SequenceQuota** | **int** | Value indicating what is the expected maximum sequence count. | [optional] 
**TaskName** | **string** | The task identifier. | [optional] 
**WorkflowName** | **string** | The relative path of the workflow xaml file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

