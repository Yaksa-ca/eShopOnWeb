# Yaksa.OrckestraCommerce.Client.Api.RolesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRoleChildRequestParentRoleIdChildRoleIdPost**](RolesApi.md#addrolechildrequestparentroleidchildroleidpost) | **POST** /roles/{ParentRoleId}/{ChildRoleId} | Add a child role to a parent. - {AddRoleChildRequest}
[**AddRoleChildToGlobalAdministratorRoleRequestsystemAdministratorChildRoleIdPost**](RolesApi.md#addrolechildtoglobaladministratorrolerequestsystemadministratorchildroleidpost) | **POST** /roles/systemAdministrator/{ChildRoleId} | This message is used to add a child role to the Global Administrator Role. - {AddRoleChildToGlobalAdministratorRoleRequest}
[**AddRoleChildrenRequestParentRoleIdchildPost**](RolesApi.md#addrolechildrenrequestparentroleidchildpost) | **POST** /roles/{ParentRoleId}/child | Add a list of child role to a parent. - {AddRoleChildrenRequest}
[**CreateCustomRoleRequestcustomNamePost**](RolesApi.md#createcustomrolerequestcustomnamepost) | **POST** /roles/custom/{Name} | Create a new custom role. - {CreateCustomRoleRequest}
[**CreateRoleRequestNamePost**](RolesApi.md#createrolerequestnamepost) | **POST** /roles/{Name} | Create a new role. - {CreateRoleRequest}
[**DeleteRoleRequestIdDelete**](RolesApi.md#deleterolerequestiddelete) | **DELETE** /roles/{Id} | Delete role. - {DeleteRoleRequest}
[**GetCustomRolesRequestcustomGet**](RolesApi.md#getcustomrolesrequestcustomget) | **GET** /roles/custom | Retrieve all the custom roles. - {GetCustomRolesRequest}
[**GetRoleByIdRequestIdGet**](RolesApi.md#getrolebyidrequestidget) | **GET** /roles/{Id} | Retrieve the role by Id. - {GetRoleByIdRequest}
[**GetRoleRequestModuleIdRoleNameGet**](RolesApi.md#getrolerequestmoduleidrolenameget) | **GET** /roles/{ModuleId}/{RoleName} | Retrieve the role by name and module Id - {GetRoleRequest}
[**GetRolesRequestGet**](RolesApi.md#getrolesrequestget) | **GET** /roles | Retrieve all the roles - {GetRolesRequest}
[**RemoveRoleChildRequestParentRoleIdChildRoleIdDelete**](RolesApi.md#removerolechildrequestparentroleidchildroleiddelete) | **DELETE** /roles/{ParentRoleId}/{ChildRoleId} | Remove a child role to a parent. - {RemoveRoleChildRequest}
[**RemoveRoleChildrenRequestParentRoleIdchildDelete**](RolesApi.md#removerolechildrenrequestparentroleidchilddelete) | **DELETE** /roles/{ParentRoleId}/child | Remove a list of children roles from a parent. - {RemoveRoleChildrenRequest}
[**RoleIsHierarchicalChildOfParentRolesRequestChildRoleIdchildOfPost**](RolesApi.md#roleishierarchicalchildofparentrolesrequestchildroleidchildofpost) | **POST** /roles/{ChildRoleId}/childOf | Check if child role id is a hierarchical child of parent role ids. - {RoleIsHierarchicalChildOfParentRolesRequest}
[**SaveCustomRoleRequestcustomRoleIdCreate**](RolesApi.md#savecustomrolerequestcustomroleidcreate) | **PUT** /roles/custom/{RoleId} | Save the custom role. - {SaveCustomRoleRequest}
[**UpdateRoleRequestIdCreate**](RolesApi.md#updaterolerequestidcreate) | **PUT** /roles/{Id} | Update an existing role. - {UpdateRoleRequest}


<a name="addrolechildrequestparentroleidchildroleidpost"></a>
# **AddRoleChildRequestParentRoleIdChildRoleIdPost**
> void AddRoleChildRequestParentRoleIdChildRoleIdPost (string accept, int parentRoleId, int childRoleId, AddRoleChildRequest body = null)

Add a child role to a parent. - {AddRoleChildRequest}

Add a child role to a parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddRoleChildRequestParentRoleIdChildRoleIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var parentRoleId = 56;  // int | the parent role identifier.
            var childRoleId = 56;  // int | the child role identifier.
            var body = new AddRoleChildRequest(); // AddRoleChildRequest |  (optional) 

            try
            {
                // Add a child role to a parent. - {AddRoleChildRequest}
                apiInstance.AddRoleChildRequestParentRoleIdChildRoleIdPost(accept, parentRoleId, childRoleId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AddRoleChildRequestParentRoleIdChildRoleIdPost: " + e.Message );
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
 **parentRoleId** | **int**| the parent role identifier. | 
 **childRoleId** | **int**| the child role identifier. | 
 **body** | [**AddRoleChildRequest**](AddRoleChildRequest.md)|  | [optional] 

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

<a name="addrolechildtoglobaladministratorrolerequestsystemadministratorchildroleidpost"></a>
# **AddRoleChildToGlobalAdministratorRoleRequestsystemAdministratorChildRoleIdPost**
> void AddRoleChildToGlobalAdministratorRoleRequestsystemAdministratorChildRoleIdPost (string accept, int childRoleId, AddRoleChildToGlobalAdministratorRoleRequest body = null)

This message is used to add a child role to the Global Administrator Role. - {AddRoleChildToGlobalAdministratorRoleRequest}

This message is used to add a child role to the Global Administrator Role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddRoleChildToGlobalAdministratorRoleRequestsystemAdministratorChildRoleIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var childRoleId = 56;  // int | the child role identifier.
            var body = new AddRoleChildToGlobalAdministratorRoleRequest(); // AddRoleChildToGlobalAdministratorRoleRequest |  (optional) 

            try
            {
                // This message is used to add a child role to the Global Administrator Role. - {AddRoleChildToGlobalAdministratorRoleRequest}
                apiInstance.AddRoleChildToGlobalAdministratorRoleRequestsystemAdministratorChildRoleIdPost(accept, childRoleId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AddRoleChildToGlobalAdministratorRoleRequestsystemAdministratorChildRoleIdPost: " + e.Message );
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
 **childRoleId** | **int**| the child role identifier. | 
 **body** | [**AddRoleChildToGlobalAdministratorRoleRequest**](AddRoleChildToGlobalAdministratorRoleRequest.md)|  | [optional] 

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

<a name="addrolechildrenrequestparentroleidchildpost"></a>
# **AddRoleChildrenRequestParentRoleIdchildPost**
> void AddRoleChildrenRequestParentRoleIdchildPost (string accept, int parentRoleId, AddRoleChildrenRequest body = null)

Add a list of child role to a parent. - {AddRoleChildrenRequest}

Add a list of child role to a parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddRoleChildrenRequestParentRoleIdchildPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var parentRoleId = 56;  // int | the parent role identifier.
            var body = new AddRoleChildrenRequest(); // AddRoleChildrenRequest |  (optional) 

            try
            {
                // Add a list of child role to a parent. - {AddRoleChildrenRequest}
                apiInstance.AddRoleChildrenRequestParentRoleIdchildPost(accept, parentRoleId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AddRoleChildrenRequestParentRoleIdchildPost: " + e.Message );
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
 **parentRoleId** | **int**| the parent role identifier. | 
 **body** | [**AddRoleChildrenRequest**](AddRoleChildrenRequest.md)|  | [optional] 

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

<a name="createcustomrolerequestcustomnamepost"></a>
# **CreateCustomRoleRequestcustomNamePost**
> Role CreateCustomRoleRequestcustomNamePost (string accept, string name, Object body = null)

Create a new custom role. - {CreateCustomRoleRequest}

Create a new custom role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCustomRoleRequestcustomNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | the role name.
            var body = ;  // Object |  (optional) 

            try
            {
                // Create a new custom role. - {CreateCustomRoleRequest}
                Role result = apiInstance.CreateCustomRoleRequestcustomNamePost(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.CreateCustomRoleRequestcustomNamePost: " + e.Message );
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
 **name** | **string**| the role name. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Role**](Role.md)

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

<a name="createrolerequestnamepost"></a>
# **CreateRoleRequestNamePost**
> Role CreateRoleRequestNamePost (string accept, string name, CreateRoleRequest body = null)

Create a new role. - {CreateRoleRequest}

Create a new role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateRoleRequestNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | the role name.
            var body = new CreateRoleRequest(); // CreateRoleRequest |  (optional) 

            try
            {
                // Create a new role. - {CreateRoleRequest}
                Role result = apiInstance.CreateRoleRequestNamePost(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.CreateRoleRequestNamePost: " + e.Message );
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
 **name** | **string**| the role name. | 
 **body** | [**CreateRoleRequest**](CreateRoleRequest.md)|  | [optional] 

### Return type

[**Role**](Role.md)

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

<a name="deleterolerequestiddelete"></a>
# **DeleteRoleRequestIdDelete**
> void DeleteRoleRequestIdDelete (string accept, int id, int? moduleId = null, string name = null)

Delete role. - {DeleteRoleRequest}

Delete role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteRoleRequestIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var id = 56;  // int | the role identifier.
            var moduleId = 56;  // int? | the module identifier. (optional) 
            var name = name_example;  // string | the name. (optional) 

            try
            {
                // Delete role. - {DeleteRoleRequest}
                apiInstance.DeleteRoleRequestIdDelete(accept, id, moduleId, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRoleRequestIdDelete: " + e.Message );
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
 **id** | **int**| the role identifier. | 
 **moduleId** | **int?**| the module identifier. | [optional] 
 **name** | **string**| the name. | [optional] 

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

<a name="getcustomrolesrequestcustomget"></a>
# **GetCustomRolesRequestcustomGet**
> List&lt;Role&gt; GetCustomRolesRequestcustomGet (string accept, string orderBy = null, string cultureCode = null)

Retrieve all the custom roles. - {GetCustomRolesRequest}

Retrieve all the custom roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomRolesRequestcustomGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var orderBy = orderBy_example;  // string | The 'order by attribute' use to sort custom roles return. By default, the custom roles will be order by DisplayName. (optional) 
            var cultureCode = cultureCode_example;  // string | The CultureCode is use when you sort by DisplayName. By default, the culture 'en_US' will be use. If you don't sort by display name, this parameter is not mandatory. (optional) 

            try
            {
                // Retrieve all the custom roles. - {GetCustomRolesRequest}
                List<Role> result = apiInstance.GetCustomRolesRequestcustomGet(accept, orderBy, cultureCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetCustomRolesRequestcustomGet: " + e.Message );
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
 **orderBy** | **string**| The &#39;order by attribute&#39; use to sort custom roles return. By default, the custom roles will be order by DisplayName. | [optional] 
 **cultureCode** | **string**| The CultureCode is use when you sort by DisplayName. By default, the culture &#39;en_US&#39; will be use. If you don&#39;t sort by display name, this parameter is not mandatory. | [optional] 

### Return type

[**List&lt;Role&gt;**](Role.md)

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

<a name="getrolebyidrequestidget"></a>
# **GetRoleByIdRequestIdGet**
> Role GetRoleByIdRequestIdGet (string accept, int id)

Retrieve the role by Id. - {GetRoleByIdRequest}

Retrieve the role by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRoleByIdRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var id = 56;  // int | The role identifier.

            try
            {
                // Retrieve the role by Id. - {GetRoleByIdRequest}
                Role result = apiInstance.GetRoleByIdRequestIdGet(accept, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleByIdRequestIdGet: " + e.Message );
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
 **id** | **int**| The role identifier. | 

### Return type

[**Role**](Role.md)

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

<a name="getrolerequestmoduleidrolenameget"></a>
# **GetRoleRequestModuleIdRoleNameGet**
> Role GetRoleRequestModuleIdRoleNameGet (string accept, int moduleId, string roleName)

Retrieve the role by name and module Id - {GetRoleRequest}

Retrieve the role by name and module Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRoleRequestModuleIdRoleNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var moduleId = 56;  // int | The module identifier.
            var roleName = roleName_example;  // string | The role name.

            try
            {
                // Retrieve the role by name and module Id - {GetRoleRequest}
                Role result = apiInstance.GetRoleRequestModuleIdRoleNameGet(accept, moduleId, roleName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleRequestModuleIdRoleNameGet: " + e.Message );
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
 **moduleId** | **int**| The module identifier. | 
 **roleName** | **string**| The role name. | 

### Return type

[**Role**](Role.md)

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

<a name="getrolesrequestget"></a>
# **GetRolesRequestGet**
> List&lt;Role&gt; GetRolesRequestGet (string accept)

Retrieve all the roles - {GetRolesRequest}

Retrieve all the roles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRolesRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve all the roles - {GetRolesRequest}
                List<Role> result = apiInstance.GetRolesRequestGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetRolesRequestGet: " + e.Message );
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

[**List&lt;Role&gt;**](Role.md)

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

<a name="removerolechildrequestparentroleidchildroleiddelete"></a>
# **RemoveRoleChildRequestParentRoleIdChildRoleIdDelete**
> void RemoveRoleChildRequestParentRoleIdChildRoleIdDelete (string accept, int parentRoleId, int childRoleId, string applicationName = null)

Remove a child role to a parent. - {RemoveRoleChildRequest}

Remove a child role to a parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveRoleChildRequestParentRoleIdChildRoleIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var parentRoleId = 56;  // int | the parent role identifier.
            var childRoleId = 56;  // int | the child role identifier.
            var applicationName = applicationName_example;  // string | the application name. (optional) 

            try
            {
                // Remove a child role to a parent. - {RemoveRoleChildRequest}
                apiInstance.RemoveRoleChildRequestParentRoleIdChildRoleIdDelete(accept, parentRoleId, childRoleId, applicationName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RemoveRoleChildRequestParentRoleIdChildRoleIdDelete: " + e.Message );
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
 **parentRoleId** | **int**| the parent role identifier. | 
 **childRoleId** | **int**| the child role identifier. | 
 **applicationName** | **string**| the application name. | [optional] 

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

<a name="removerolechildrenrequestparentroleidchilddelete"></a>
# **RemoveRoleChildrenRequestParentRoleIdchildDelete**
> void RemoveRoleChildrenRequestParentRoleIdchildDelete (string accept, int parentRoleId, List<string> childRoleIds = null, string applicationName = null)

Remove a list of children roles from a parent. - {RemoveRoleChildrenRequest}

Remove a list of children roles from a parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveRoleChildrenRequestParentRoleIdchildDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var parentRoleId = 56;  // int | the parent role identifier.
            var childRoleIds = new List<string>(); // List<string> | the list of child role identifier. (optional) 
            var applicationName = applicationName_example;  // string | the application name. (optional) 

            try
            {
                // Remove a list of children roles from a parent. - {RemoveRoleChildrenRequest}
                apiInstance.RemoveRoleChildrenRequestParentRoleIdchildDelete(accept, parentRoleId, childRoleIds, applicationName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RemoveRoleChildrenRequestParentRoleIdchildDelete: " + e.Message );
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
 **parentRoleId** | **int**| the parent role identifier. | 
 **childRoleIds** | [**List&lt;string&gt;**](string.md)| the list of child role identifier. | [optional] 
 **applicationName** | **string**| the application name. | [optional] 

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

<a name="roleishierarchicalchildofparentrolesrequestchildroleidchildofpost"></a>
# **RoleIsHierarchicalChildOfParentRolesRequestChildRoleIdchildOfPost**
> List&lt;RoleChildAssociation&gt; RoleIsHierarchicalChildOfParentRolesRequestChildRoleIdchildOfPost (string accept, int childRoleId, RoleIsHierarchicalChildOfParentRolesRequest body = null)

Check if child role id is a hierarchical child of parent role ids. - {RoleIsHierarchicalChildOfParentRolesRequest}

Check if child role id is a hierarchical child of parent role ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RoleIsHierarchicalChildOfParentRolesRequestChildRoleIdchildOfPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var childRoleId = 56;  // int | the child role identifier.
            var body = new RoleIsHierarchicalChildOfParentRolesRequest(); // RoleIsHierarchicalChildOfParentRolesRequest |  (optional) 

            try
            {
                // Check if child role id is a hierarchical child of parent role ids. - {RoleIsHierarchicalChildOfParentRolesRequest}
                List<RoleChildAssociation> result = apiInstance.RoleIsHierarchicalChildOfParentRolesRequestChildRoleIdchildOfPost(accept, childRoleId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RoleIsHierarchicalChildOfParentRolesRequestChildRoleIdchildOfPost: " + e.Message );
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
 **childRoleId** | **int**| the child role identifier. | 
 **body** | [**RoleIsHierarchicalChildOfParentRolesRequest**](RoleIsHierarchicalChildOfParentRolesRequest.md)|  | [optional] 

### Return type

[**List&lt;RoleChildAssociation&gt;**](RoleChildAssociation.md)

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

<a name="savecustomrolerequestcustomroleidcreate"></a>
# **SaveCustomRoleRequestcustomRoleIdCreate**
> Role SaveCustomRoleRequestcustomRoleIdCreate (string accept, int roleId, SaveCustomRoleRequest body = null)

Save the custom role. - {SaveCustomRoleRequest}

Save the custom role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveCustomRoleRequestcustomRoleIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var roleId = 56;  // int | the role identifier.
            var body = new SaveCustomRoleRequest(); // SaveCustomRoleRequest |  (optional) 

            try
            {
                // Save the custom role. - {SaveCustomRoleRequest}
                Role result = apiInstance.SaveCustomRoleRequestcustomRoleIdCreate(accept, roleId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.SaveCustomRoleRequestcustomRoleIdCreate: " + e.Message );
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
 **roleId** | **int**| the role identifier. | 
 **body** | [**SaveCustomRoleRequest**](SaveCustomRoleRequest.md)|  | [optional] 

### Return type

[**Role**](Role.md)

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

<a name="updaterolerequestidcreate"></a>
# **UpdateRoleRequestIdCreate**
> void UpdateRoleRequestIdCreate (string accept, int id, UpdateRoleRequest body = null)

Update an existing role. - {UpdateRoleRequest}

Update an existing role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateRoleRequestIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RolesApi(config);
            var accept = accept_example;  // string | Accept Header
            var id = 56;  // int | the role identifier.
            var body = new UpdateRoleRequest(); // UpdateRoleRequest |  (optional) 

            try
            {
                // Update an existing role. - {UpdateRoleRequest}
                apiInstance.UpdateRoleRequestIdCreate(accept, id, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.UpdateRoleRequestIdCreate: " + e.Message );
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
 **id** | **int**| the role identifier. | 
 **body** | [**UpdateRoleRequest**](UpdateRoleRequest.md)|  | [optional] 

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

