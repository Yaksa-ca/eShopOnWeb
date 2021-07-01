# Yaksa.OrckestraCommerce.Client.Api.TasksApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreate**](TasksApi.md#addorupdatescheduledtasktriggerscheduledtaskgrouptasknametriggerstriggergrouptriggernamecreate) | **PUT** /tasks/scheduled/{TaskGroup}/{TaskName}/triggers/{TriggerGroup}/{TriggerName} | Add or update a trigger of a scheduled task - {AddOrUpdateScheduledTaskTrigger}
[**CancelTaskRequestTaskIdcancelPost**](TasksApi.md#canceltaskrequesttaskidcancelpost) | **POST** /tasks/{TaskId}/cancel | Cancels the specified long running (batch processing) task. - {CancelTaskRequest}
[**DeleteAllScheduledTasksRequestscheduledallDelete**](TasksApi.md#deleteallscheduledtasksrequestscheduledalldelete) | **DELETE** /tasks/scheduled/all | Remove all the scheduled task activities - {DeleteAllScheduledTasksRequest}
[**DeleteScheduledTaskRequestscheduledGroupNameDelete**](TasksApi.md#deletescheduledtaskrequestscheduledgroupnamedelete) | **DELETE** /tasks/scheduled/{Group}/{Name} | Remove a specific scheduled task activity - {DeleteScheduledTaskRequest}
[**DeleteTaskInfoRequestTaskIdDelete**](TasksApi.md#deletetaskinforequesttaskiddelete) | **DELETE** /tasks/{TaskId} | Delete a long running task - {DeleteTaskInfoRequest}
[**GetAllScheduledTasksRequestscheduledallGet**](TasksApi.md#getallscheduledtasksrequestscheduledallget) | **GET** /tasks/scheduled/all | Retrieve a list of all the scheduled tasks - {GetAllScheduledTasksRequest}
[**GetRequesterTasksInfoRequestGet**](TasksApi.md#getrequestertasksinforequestget) | **GET** /tasks | Retrieve a list of long running tasks for a specified requester - {GetRequesterTasksInfoRequest}
[**GetRunningScheduledTasksRequestscheduledrunningGet**](TasksApi.md#getrunningscheduledtasksrequestscheduledrunningget) | **GET** /tasks/scheduled/running | Retrieve the job info of the currently running scheduled tasks - {GetRunningScheduledTasksRequest}
[**GetScheduledTaskRequestscheduledGroupNameGet**](TasksApi.md#getscheduledtaskrequestscheduledgroupnameget) | **GET** /tasks/scheduled/{Group}/{Name} | Retrieve a specfic scheduled task - {GetScheduledTaskRequest}
[**GetTaskExecutionLogsRequestTaskIdlogsGet**](TasksApi.md#gettaskexecutionlogsrequesttaskidlogsget) | **GET** /tasks/{TaskId}/logs | Retrieve the log entries from a long running task - {GetTaskExecutionLogsRequest}
[**GetTaskInfoRequestTaskIdGet**](TasksApi.md#gettaskinforequesttaskidget) | **GET** /tasks/{TaskId} | Retrieve the state of a long running task - {GetTaskInfoRequest}
[**GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGet**](TasksApi.md#gettasksinfobycorrelationidrequestbycorrelationididget) | **GET** /tasks/byCorrelationId/{Id} | Retrieve the state of long running tasks by correlation id - {GetTasksInfoByCorrelationIdRequest}
[**QueueActivityTaskRequestactivitiesTaskIdPost**](TasksApi.md#queueactivitytaskrequestactivitiestaskidpost) | **POST** /tasks/activities/{TaskId} | Queue a new task activity - {QueueActivityTaskRequest}
[**QueueWorkflowTaskRequestworkflowsTaskIdPost**](TasksApi.md#queueworkflowtaskrequestworkflowstaskidpost) | **POST** /tasks/workflows/{TaskId} | Queue a new task workflow - {QueueWorkflowTaskRequest}
[**RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDelete**](TasksApi.md#removescheduledtasktriggerrequestscheduledtaskgrouptasknametriggerstriggergrouptriggernamedelete) | **DELETE** /tasks/scheduled/{TaskGroup}/{TaskName}/triggers/{TriggerGroup}/{TriggerName} | Remove a given trigger of a scheduled task - {RemoveScheduledTaskTriggerRequest}
[**ScheduleTaskActivityRequestscheduledactivitiesGroupNamePost**](TasksApi.md#scheduletaskactivityrequestscheduledactivitiesgroupnamepost) | **POST** /tasks/scheduled/activities/{Group}/{Name} | Create a scheduled activity task based on a activity class - {ScheduleTaskActivityRequest}
[**ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePost**](TasksApi.md#scheduletaskworkflowrequestscheduledworkflowsgroupnamepost) | **POST** /tasks/scheduled/workflows/{Group}/{Name} | Create a scheduled workflow task based on a workflow file - {ScheduleTaskWorkflowRequest}


<a name="addorupdatescheduledtasktriggerscheduledtaskgrouptasknametriggerstriggergrouptriggernamecreate"></a>
# **AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreate**
> ScheduledTaskInfo AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreate (string accept, string taskGroup, string taskName, string triggerGroup, string triggerName, AddOrUpdateScheduledTaskTrigger body = null)

Add or update a trigger of a scheduled task - {AddOrUpdateScheduledTaskTrigger}

Add or update a trigger of a scheduled task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskGroup = taskGroup_example;  // string | the affinity group of the scheduled job.
            var taskName = taskName_example;  // string | the name of the scheduled job.
            var triggerGroup = triggerGroup_example;  // string | the trigger affinity group.
            var triggerName = triggerName_example;  // string | the trigger name.
            var body = new AddOrUpdateScheduledTaskTrigger(); // AddOrUpdateScheduledTaskTrigger |  (optional) 

            try
            {
                // Add or update a trigger of a scheduled task - {AddOrUpdateScheduledTaskTrigger}
                ScheduledTaskInfo result = apiInstance.AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreate(accept, taskGroup, taskName, triggerGroup, triggerName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskGroup** | **string**| the affinity group of the scheduled job. | 
 **taskName** | **string**| the name of the scheduled job. | 
 **triggerGroup** | **string**| the trigger affinity group. | 
 **triggerName** | **string**| the trigger name. | 
 **body** | [**AddOrUpdateScheduledTaskTrigger**](AddOrUpdateScheduledTaskTrigger.md)|  | [optional] 

### Return type

[**ScheduledTaskInfo**](ScheduledTaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceltaskrequesttaskidcancelpost"></a>
# **CancelTaskRequestTaskIdcancelPost**
> void CancelTaskRequestTaskIdcancelPost (string accept, string taskId, Object body = null)

Cancels the specified long running (batch processing) task. - {CancelTaskRequest}

Cancels the specified long running (batch processing) task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CancelTaskRequestTaskIdcancelPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskId = taskId_example;  // string | The task identifier.
            var body = ;  // Object |  (optional) 

            try
            {
                // Cancels the specified long running (batch processing) task. - {CancelTaskRequest}
                apiInstance.CancelTaskRequestTaskIdcancelPost(accept, taskId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.CancelTaskRequestTaskIdcancelPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskId** | **string**| The task identifier. | 
 **body** | **Object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallscheduledtasksrequestscheduledalldelete"></a>
# **DeleteAllScheduledTasksRequestscheduledallDelete**
> void DeleteAllScheduledTasksRequestscheduledallDelete (string accept)

Remove all the scheduled task activities - {DeleteAllScheduledTasksRequest}

Remove all the scheduled task activities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteAllScheduledTasksRequestscheduledallDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Remove all the scheduled task activities - {DeleteAllScheduledTasksRequest}
                apiInstance.DeleteAllScheduledTasksRequestscheduledallDelete(accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteAllScheduledTasksRequestscheduledallDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescheduledtaskrequestscheduledgroupnamedelete"></a>
# **DeleteScheduledTaskRequestscheduledGroupNameDelete**
> void DeleteScheduledTaskRequestscheduledGroupNameDelete (string accept, string group, string name)

Remove a specific scheduled task activity - {DeleteScheduledTaskRequest}

Remove a specific scheduled task activity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteScheduledTaskRequestscheduledGroupNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var group = group_example;  // string | the affinity group of the scheduled job.
            var name = name_example;  // string | the name of the scheduled job.

            try
            {
                // Remove a specific scheduled task activity - {DeleteScheduledTaskRequest}
                apiInstance.DeleteScheduledTaskRequestscheduledGroupNameDelete(accept, group, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteScheduledTaskRequestscheduledGroupNameDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **group** | **string**| the affinity group of the scheduled job. | 
 **name** | **string**| the name of the scheduled job. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaskinforequesttaskiddelete"></a>
# **DeleteTaskInfoRequestTaskIdDelete**
> void DeleteTaskInfoRequestTaskIdDelete (string accept, string taskId, bool? force = null)

Delete a long running task - {DeleteTaskInfoRequest}

Delete a long running task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteTaskInfoRequestTaskIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskId = taskId_example;  // string | The task identifier.
            var force = true;  // bool? | force delete task. (optional) 

            try
            {
                // Delete a long running task - {DeleteTaskInfoRequest}
                apiInstance.DeleteTaskInfoRequestTaskIdDelete(accept, taskId, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTaskInfoRequestTaskIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskId** | **string**| The task identifier. | 
 **force** | **bool?**| force delete task. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallscheduledtasksrequestscheduledallget"></a>
# **GetAllScheduledTasksRequestscheduledallGet**
> List&lt;ScheduledTaskInfo&gt; GetAllScheduledTasksRequestscheduledallGet (string accept)

Retrieve a list of all the scheduled tasks - {GetAllScheduledTasksRequest}

Retrieve a list of all the scheduled tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAllScheduledTasksRequestscheduledallGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve a list of all the scheduled tasks - {GetAllScheduledTasksRequest}
                List<ScheduledTaskInfo> result = apiInstance.GetAllScheduledTasksRequestscheduledallGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetAllScheduledTasksRequestscheduledallGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 

### Return type

[**List&lt;ScheduledTaskInfo&gt;**](ScheduledTaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequestertasksinforequestget"></a>
# **GetRequesterTasksInfoRequestGet**
> List&lt;TaskInfo&gt; GetRequesterTasksInfoRequestGet (string accept, string requester = null, DateTime? lastModified = null, List<string> filterTaskNames = null)

Retrieve a list of long running tasks for a specified requester - {GetRequesterTasksInfoRequest}

Retrieve a list of long running tasks for a specified requester

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRequesterTasksInfoRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var requester = requester_example;  // string | The username of the user that requested the tasks. (optional) 
            var lastModified = 2013-10-20T19:20:30+01:00;  // DateTime? | The last modification date of the task. Use this to limit the results to items after this date (optional) 
            var filterTaskNames = new List<string>(); // List<string> | The array of task type names to filter by, if none specified, no filtering is performed. The type names are the fully qualified type names (Eg. Orckestra.Overture.Providers.CommerceEngine.Profiles.ProfileSchemaImportTask, Orckestra.Overture.Providers.CommerceEngine) (optional) 

            try
            {
                // Retrieve a list of long running tasks for a specified requester - {GetRequesterTasksInfoRequest}
                List<TaskInfo> result = apiInstance.GetRequesterTasksInfoRequestGet(accept, requester, lastModified, filterTaskNames);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetRequesterTasksInfoRequestGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **requester** | **string**| The username of the user that requested the tasks. | [optional] 
 **lastModified** | **DateTime?**| The last modification date of the task. Use this to limit the results to items after this date | [optional] 
 **filterTaskNames** | [**List&lt;string&gt;**](string.md)| The array of task type names to filter by, if none specified, no filtering is performed. The type names are the fully qualified type names (Eg. Orckestra.Overture.Providers.CommerceEngine.Profiles.ProfileSchemaImportTask, Orckestra.Overture.Providers.CommerceEngine) | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrunningscheduledtasksrequestscheduledrunningget"></a>
# **GetRunningScheduledTasksRequestscheduledrunningGet**
> List&lt;RunningScheduledTaskInfo&gt; GetRunningScheduledTasksRequestscheduledrunningGet (string accept)

Retrieve the job info of the currently running scheduled tasks - {GetRunningScheduledTasksRequest}

Retrieve the job info of the currently running scheduled tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRunningScheduledTasksRequestscheduledrunningGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the job info of the currently running scheduled tasks - {GetRunningScheduledTasksRequest}
                List<RunningScheduledTaskInfo> result = apiInstance.GetRunningScheduledTasksRequestscheduledrunningGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetRunningScheduledTasksRequestscheduledrunningGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 

### Return type

[**List&lt;RunningScheduledTaskInfo&gt;**](RunningScheduledTaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscheduledtaskrequestscheduledgroupnameget"></a>
# **GetScheduledTaskRequestscheduledGroupNameGet**
> ScheduledTaskInfo GetScheduledTaskRequestscheduledGroupNameGet (string accept, string group, string name)

Retrieve a specfic scheduled task - {GetScheduledTaskRequest}

Retrieve a specfic scheduled task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetScheduledTaskRequestscheduledGroupNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var group = group_example;  // string | the affinity group of the scheduled job.
            var name = name_example;  // string | the name of the scheduled job.

            try
            {
                // Retrieve a specfic scheduled task - {GetScheduledTaskRequest}
                ScheduledTaskInfo result = apiInstance.GetScheduledTaskRequestscheduledGroupNameGet(accept, group, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetScheduledTaskRequestscheduledGroupNameGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **group** | **string**| the affinity group of the scheduled job. | 
 **name** | **string**| the name of the scheduled job. | 

### Return type

[**ScheduledTaskInfo**](ScheduledTaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskexecutionlogsrequesttaskidlogsget"></a>
# **GetTaskExecutionLogsRequestTaskIdlogsGet**
> List&lt;TaskExecutionLogEntry&gt; GetTaskExecutionLogsRequestTaskIdlogsGet (string accept, string taskId)

Retrieve the log entries from a long running task - {GetTaskExecutionLogsRequest}

Retrieve the log entries from a long running task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTaskExecutionLogsRequestTaskIdlogsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskId = taskId_example;  // string | The task identifier.

            try
            {
                // Retrieve the log entries from a long running task - {GetTaskExecutionLogsRequest}
                List<TaskExecutionLogEntry> result = apiInstance.GetTaskExecutionLogsRequestTaskIdlogsGet(accept, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskExecutionLogsRequestTaskIdlogsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskId** | **string**| The task identifier. | 

### Return type

[**List&lt;TaskExecutionLogEntry&gt;**](TaskExecutionLogEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskinforequesttaskidget"></a>
# **GetTaskInfoRequestTaskIdGet**
> TaskInfo GetTaskInfoRequestTaskIdGet (string accept, string taskId)

Retrieve the state of a long running task - {GetTaskInfoRequest}

Retrieve the state of a long running task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTaskInfoRequestTaskIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskId = taskId_example;  // string | The task identifier.

            try
            {
                // Retrieve the state of a long running task - {GetTaskInfoRequest}
                TaskInfo result = apiInstance.GetTaskInfoRequestTaskIdGet(accept, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskInfoRequestTaskIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskId** | **string**| The task identifier. | 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasksinfobycorrelationidrequestbycorrelationididget"></a>
# **GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGet**
> List&lt;TaskInfo&gt; GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGet (string accept, string id)

Retrieve the state of long running tasks by correlation id - {GetTasksInfoByCorrelationIdRequest}

Retrieve the state of long running tasks by correlation id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var id = id_example;  // string | The task correlation identifier

            try
            {
                // Retrieve the state of long running tasks by correlation id - {GetTasksInfoByCorrelationIdRequest}
                List<TaskInfo> result = apiInstance.GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGet(accept, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **id** | **string**| The task correlation identifier | 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueactivitytaskrequestactivitiestaskidpost"></a>
# **QueueActivityTaskRequestactivitiesTaskIdPost**
> TaskInfo QueueActivityTaskRequestactivitiesTaskIdPost (string accept, string taskId, QueueActivityTaskRequest body = null)

Queue a new task activity - {QueueActivityTaskRequest}

Queue a new task activity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class QueueActivityTaskRequestactivitiesTaskIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskId = taskId_example;  // string | The task identifier.
            var body = new QueueActivityTaskRequest(); // QueueActivityTaskRequest |  (optional) 

            try
            {
                // Queue a new task activity - {QueueActivityTaskRequest}
                TaskInfo result = apiInstance.QueueActivityTaskRequestactivitiesTaskIdPost(accept, taskId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.QueueActivityTaskRequestactivitiesTaskIdPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskId** | **string**| The task identifier. | 
 **body** | [**QueueActivityTaskRequest**](QueueActivityTaskRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueworkflowtaskrequestworkflowstaskidpost"></a>
# **QueueWorkflowTaskRequestworkflowsTaskIdPost**
> TaskInfo QueueWorkflowTaskRequestworkflowsTaskIdPost (string accept, string taskId, QueueWorkflowTaskRequest body = null)

Queue a new task workflow - {QueueWorkflowTaskRequest}

Queue a new task workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class QueueWorkflowTaskRequestworkflowsTaskIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskId = taskId_example;  // string | The task identifier.
            var body = new QueueWorkflowTaskRequest(); // QueueWorkflowTaskRequest |  (optional) 

            try
            {
                // Queue a new task workflow - {QueueWorkflowTaskRequest}
                TaskInfo result = apiInstance.QueueWorkflowTaskRequestworkflowsTaskIdPost(accept, taskId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.QueueWorkflowTaskRequestworkflowsTaskIdPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskId** | **string**| The task identifier. | 
 **body** | [**QueueWorkflowTaskRequest**](QueueWorkflowTaskRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removescheduledtasktriggerrequestscheduledtaskgrouptasknametriggerstriggergrouptriggernamedelete"></a>
# **RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDelete**
> ScheduledTaskInfo RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDelete (string accept, string taskGroup, string taskName, string triggerGroup, string triggerName)

Remove a given trigger of a scheduled task - {RemoveScheduledTaskTriggerRequest}

Remove a given trigger of a scheduled task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var taskGroup = taskGroup_example;  // string | the affinity group of the scheduled job.
            var taskName = taskName_example;  // string | the name of the scheduled job.
            var triggerGroup = triggerGroup_example;  // string | the trigger affinity group.
            var triggerName = triggerName_example;  // string | the trigger name.

            try
            {
                // Remove a given trigger of a scheduled task - {RemoveScheduledTaskTriggerRequest}
                ScheduledTaskInfo result = apiInstance.RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDelete(accept, taskGroup, taskName, triggerGroup, triggerName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **taskGroup** | **string**| the affinity group of the scheduled job. | 
 **taskName** | **string**| the name of the scheduled job. | 
 **triggerGroup** | **string**| the trigger affinity group. | 
 **triggerName** | **string**| the trigger name. | 

### Return type

[**ScheduledTaskInfo**](ScheduledTaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduletaskactivityrequestscheduledactivitiesgroupnamepost"></a>
# **ScheduleTaskActivityRequestscheduledactivitiesGroupNamePost**
> ScheduledTaskInfo ScheduleTaskActivityRequestscheduledactivitiesGroupNamePost (string accept, string group, string name, ScheduleTaskActivityRequest body = null)

Create a scheduled activity task based on a activity class - {ScheduleTaskActivityRequest}

Create a scheduled activity task based on a activity class

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ScheduleTaskActivityRequestscheduledactivitiesGroupNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var group = group_example;  // string | The group affinity of the scheduled job.
            var name = name_example;  // string | the name of the scheduled job.
            var body = new ScheduleTaskActivityRequest(); // ScheduleTaskActivityRequest |  (optional) 

            try
            {
                // Create a scheduled activity task based on a activity class - {ScheduleTaskActivityRequest}
                ScheduledTaskInfo result = apiInstance.ScheduleTaskActivityRequestscheduledactivitiesGroupNamePost(accept, group, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ScheduleTaskActivityRequestscheduledactivitiesGroupNamePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **group** | **string**| The group affinity of the scheduled job. | 
 **name** | **string**| the name of the scheduled job. | 
 **body** | [**ScheduleTaskActivityRequest**](ScheduleTaskActivityRequest.md)|  | [optional] 

### Return type

[**ScheduledTaskInfo**](ScheduledTaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduletaskworkflowrequestscheduledworkflowsgroupnamepost"></a>
# **ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePost**
> ScheduledTaskInfo ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePost (string accept, string group, string name, ScheduleTaskWorkflowRequest body = null)

Create a scheduled workflow task based on a workflow file - {ScheduleTaskWorkflowRequest}

Create a scheduled workflow task based on a workflow file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TasksApi(config);
            var accept = accept_example;  // string | Accept Header
            var group = group_example;  // string | The group affinity of the scheduled job.
            var name = name_example;  // string | the name of the scheduled job.
            var body = new ScheduleTaskWorkflowRequest(); // ScheduleTaskWorkflowRequest |  (optional) 

            try
            {
                // Create a scheduled workflow task based on a workflow file - {ScheduleTaskWorkflowRequest}
                ScheduledTaskInfo result = apiInstance.ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePost(accept, group, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **group** | **string**| The group affinity of the scheduled job. | 
 **name** | **string**| the name of the scheduled job. | 
 **body** | [**ScheduleTaskWorkflowRequest**](ScheduleTaskWorkflowRequest.md)|  | [optional] 

### Return type

[**ScheduledTaskInfo**](ScheduledTaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

