# Yaksa.OrckestraCommerce.Client.Api.GroupsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserToGroupRequestGroupIdUserNamePost**](GroupsApi.md#addusertogrouprequestgroupidusernamepost) | **POST** /groups/{GroupId}/{UserName} | Add a user to a group - {AddUserToGroupRequest}
[**CreateGroupRequestDisplayNamePost**](GroupsApi.md#creategrouprequestdisplaynamepost) | **POST** /groups/{DisplayName}/ | Create a new Group - {CreateGroupRequest}
[**DeleteGroupRequestGroupIdDelete**](GroupsApi.md#deletegrouprequestgroupiddelete) | **DELETE** /groups/{GroupId} | Delete the group using its id. - {DeleteGroupRequest}
[**FindGroupsRequestfindPost**](GroupsApi.md#findgroupsrequestfindpost) | **POST** /groups/find/ | Find the groups with the specified name - {FindGroupsRequest}
[**GetGroupMembersWithPagingRequestGroupIdusersGet**](GroupsApi.md#getgroupmemberswithpagingrequestgroupidusersget) | **GET** /groups/{GroupId}/users | Retrieve the group members by group Id. - {GetGroupMembersWithPagingRequest}
[**GetGroupRequestGroupIdGet**](GroupsApi.md#getgrouprequestgroupidget) | **GET** /groups/{GroupId}/ | Retrieve the group by Id. - {GetGroupRequest}
[**RemoveUserFromGroupRequestGroupIdUserNameDelete**](GroupsApi.md#removeuserfromgrouprequestgroupidusernamedelete) | **DELETE** /groups/{GroupId}/{UserName} | Remove a user from a group - {RemoveUserFromGroupRequest}
[**SaveGroupRequestGroupIdCreate**](GroupsApi.md#savegrouprequestgroupidcreate) | **PUT** /groups/{GroupId}/ | Save the group. - {SaveGroupRequest}


<a name="addusertogrouprequestgroupidusernamepost"></a>
# **AddUserToGroupRequestGroupIdUserNamePost**
> void AddUserToGroupRequestGroupIdUserNamePost (string accept, string groupId, string userName, Object body = null)

Add a user to a group - {AddUserToGroupRequest}

Add a user to a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddUserToGroupRequestGroupIdUserNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var groupId = groupId_example;  // string | The group identifier.
            var userName = userName_example;  // string | The username.
            var body = ;  // Object |  (optional) 

            try
            {
                // Add a user to a group - {AddUserToGroupRequest}
                apiInstance.AddUserToGroupRequestGroupIdUserNamePost(accept, groupId, userName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.AddUserToGroupRequestGroupIdUserNamePost: " + e.Message );
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
 **groupId** | **string**| The group identifier. | 
 **userName** | **string**| The username. | 
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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategrouprequestdisplaynamepost"></a>
# **CreateGroupRequestDisplayNamePost**
> Group CreateGroupRequestDisplayNamePost (string accept, string displayName, CreateGroupRequest body = null)

Create a new Group - {CreateGroupRequest}

Create a new Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateGroupRequestDisplayNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var displayName = displayName_example;  // string | the display name.
            var body = new CreateGroupRequest(); // CreateGroupRequest |  (optional) 

            try
            {
                // Create a new Group - {CreateGroupRequest}
                Group result = apiInstance.CreateGroupRequestDisplayNamePost(accept, displayName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroupRequestDisplayNamePost: " + e.Message );
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
 **displayName** | **string**| the display name. | 
 **body** | [**CreateGroupRequest**](CreateGroupRequest.md)|  | [optional] 

### Return type

[**Group**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegrouprequestgroupiddelete"></a>
# **DeleteGroupRequestGroupIdDelete**
> void DeleteGroupRequestGroupIdDelete (string accept, string groupId)

Delete the group using its id. - {DeleteGroupRequest}

Delete the group using its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteGroupRequestGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var groupId = groupId_example;  // string | The group identifier.

            try
            {
                // Delete the group using its id. - {DeleteGroupRequest}
                apiInstance.DeleteGroupRequestGroupIdDelete(accept, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupRequestGroupIdDelete: " + e.Message );
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
 **groupId** | **string**| The group identifier. | 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findgroupsrequestfindpost"></a>
# **FindGroupsRequestfindPost**
> FindGroupsResult FindGroupsRequestfindPost (string accept, FindGroupsRequest body = null)

Find the groups with the specified name - {FindGroupsRequest}

Find the groups with the specified name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindGroupsRequestfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new FindGroupsRequest(); // FindGroupsRequest |  (optional) 

            try
            {
                // Find the groups with the specified name - {FindGroupsRequest}
                FindGroupsResult result = apiInstance.FindGroupsRequestfindPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.FindGroupsRequestfindPost: " + e.Message );
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
 **body** | [**FindGroupsRequest**](FindGroupsRequest.md)|  | [optional] 

### Return type

[**FindGroupsResult**](FindGroupsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmemberswithpagingrequestgroupidusersget"></a>
# **GetGroupMembersWithPagingRequestGroupIdusersGet**
> GetGroupMembersWithPagingResult GetGroupMembersWithPagingRequestGroupIdusersGet (string accept, string groupId, int? startingIndex = null, int? maximumItems = null)

Retrieve the group members by group Id. - {GetGroupMembersWithPagingRequest}

Retrieve the group members by group Id. If MaximumItems and StartingIndex are not set, 0 is taken and so the request returns 0 results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetGroupMembersWithPagingRequestGroupIdusersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var groupId = groupId_example;  // string | The group identifier.
            var startingIndex = 56;  // int? | The starting index. (optional) 
            var maximumItems = 56;  // int? | The maximum of items to be returned. (optional) 

            try
            {
                // Retrieve the group members by group Id. - {GetGroupMembersWithPagingRequest}
                GetGroupMembersWithPagingResult result = apiInstance.GetGroupMembersWithPagingRequestGroupIdusersGet(accept, groupId, startingIndex, maximumItems);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupMembersWithPagingRequestGroupIdusersGet: " + e.Message );
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
 **groupId** | **string**| The group identifier. | 
 **startingIndex** | **int?**| The starting index. | [optional] 
 **maximumItems** | **int?**| The maximum of items to be returned. | [optional] 

### Return type

[**GetGroupMembersWithPagingResult**](GetGroupMembersWithPagingResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprequestgroupidget"></a>
# **GetGroupRequestGroupIdGet**
> Group GetGroupRequestGroupIdGet (string accept, string groupId)

Retrieve the group by Id. - {GetGroupRequest}

Retrieve the group by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetGroupRequestGroupIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var groupId = groupId_example;  // string | The group identifier.

            try
            {
                // Retrieve the group by Id. - {GetGroupRequest}
                Group result = apiInstance.GetGroupRequestGroupIdGet(accept, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupRequestGroupIdGet: " + e.Message );
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
 **groupId** | **string**| The group identifier. | 

### Return type

[**Group**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserfromgrouprequestgroupidusernamedelete"></a>
# **RemoveUserFromGroupRequestGroupIdUserNameDelete**
> void RemoveUserFromGroupRequestGroupIdUserNameDelete (string accept, string groupId, string userName)

Remove a user from a group - {RemoveUserFromGroupRequest}

Remove a user from a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveUserFromGroupRequestGroupIdUserNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var groupId = groupId_example;  // string | The group identifier.
            var userName = userName_example;  // string | The username.

            try
            {
                // Remove a user from a group - {RemoveUserFromGroupRequest}
                apiInstance.RemoveUserFromGroupRequestGroupIdUserNameDelete(accept, groupId, userName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.RemoveUserFromGroupRequestGroupIdUserNameDelete: " + e.Message );
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
 **groupId** | **string**| The group identifier. | 
 **userName** | **string**| The username. | 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savegrouprequestgroupidcreate"></a>
# **SaveGroupRequestGroupIdCreate**
> Group SaveGroupRequestGroupIdCreate (string accept, string groupId, SaveGroupRequest body = null)

Save the group. - {SaveGroupRequest}

Save the group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveGroupRequestGroupIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new GroupsApi(config);
            var accept = accept_example;  // string | Accept Header
            var groupId = groupId_example;  // string | the object identifier of this group.
            var body = new SaveGroupRequest(); // SaveGroupRequest |  (optional) 

            try
            {
                // Save the group. - {SaveGroupRequest}
                Group result = apiInstance.SaveGroupRequestGroupIdCreate(accept, groupId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.SaveGroupRequestGroupIdCreate: " + e.Message );
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
 **groupId** | **string**| the object identifier of this group. | 
 **body** | [**SaveGroupRequest**](SaveGroupRequest.md)|  | [optional] 

### Return type

[**Group**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

