# Yaksa.OrckestraCommerce.Client.Api.UsersApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateUserRequestUserNameactivatePost**](UsersApi.md#activateuserrequestusernameactivatepost) | **POST** /users/{UserName}/activate | Activate the user. - {ActivateUserRequest}
[**ActivateUsersRequestactivateCreate**](UsersApi.md#activateusersrequestactivatecreate) | **PUT** /users/activate | Activate a batch of users using theirs usernames - {ActivateUsersRequest}
[**CreateUserRequestUserNamePost**](UsersApi.md#createuserrequestusernamepost) | **POST** /users/{UserName} | Create a new user - {CreateUserRequest}
[**DeactivateUserRequestUserNamedeactivatePost**](UsersApi.md#deactivateuserrequestusernamedeactivatepost) | **POST** /users/{UserName}/deactivate | Deactivate the user using its username - {DeactivateUserRequest}
[**DeactivateUsersRequestdesactivateCreate**](UsersApi.md#deactivateusersrequestdesactivatecreate) | **PUT** /users/desactivate | Deactivate a batch of users using theirs usernames - {DeactivateUsersRequest}
[**DeleteUserRequestUserNameDelete**](UsersApi.md#deleteuserrequestusernamedelete) | **DELETE** /users/{UserName} | Delete the user. - {DeleteUserRequest}
[**FindUsersByNameRequestfindPost**](UsersApi.md#findusersbynamerequestfindpost) | **POST** /users/find | Find the users by name. Search in userPrincipalName, displayName and givenName - {FindUsersByNameRequest}
[**ForceChangeUserPasswordRequestUserNameforceChangePasswordPost**](UsersApi.md#forcechangeuserpasswordrequestusernameforcechangepasswordpost) | **POST** /users/{UserName}/forceChangePassword | Force the change of a user&#39;s password. - {ForceChangeUserPasswordRequest}
[**GetAvailableDomainsRequestdomainsGet**](UsersApi.md#getavailabledomainsrequestdomainsget) | **GET** /users/domains | Retrieve the available domains of the tenant. - {GetAvailableDomainsRequest}
[**GetUserGroupsRequestUserNamegroupsGet**](UsersApi.md#getusergroupsrequestusernamegroupsget) | **GET** /users/{UserName}/groups | Retrieve the user&#39;s group(s). - {GetUserGroupsRequest}
[**GetUserRequestUserNameGet**](UsersApi.md#getuserrequestusernameget) | **GET** /users/{UserName} | Retrieve the user by its username - {GetUserRequest}
[**ResetUserPasswordRequestUserNameresetUserPasswordCreate**](UsersApi.md#resetuserpasswordrequestusernameresetuserpasswordcreate) | **PUT** /users/{UserName}/resetUserPassword | Reset the user password. - {ResetUserPasswordRequest}
[**SaveUserRequestUserNameCreate**](UsersApi.md#saveuserrequestusernamecreate) | **PUT** /users/{UserName} | Save the user. - {SaveUserRequest}


<a name="activateuserrequestusernameactivatepost"></a>
# **ActivateUserRequestUserNameactivatePost**
> User ActivateUserRequestUserNameactivatePost (string accept, string userName, Object body = null)

Activate the user. - {ActivateUserRequest}

Activate the user using its username.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ActivateUserRequestUserNameactivatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The username.
            var body = ;  // Object |  (optional) 

            try
            {
                // Activate the user. - {ActivateUserRequest}
                User result = apiInstance.ActivateUserRequestUserNameactivatePost(accept, userName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ActivateUserRequestUserNameactivatePost: " + e.Message );
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
 **userName** | **string**| The username. | 
 **body** | **Object**|  | [optional] 

### Return type

[**User**](User.md)

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

<a name="activateusersrequestactivatecreate"></a>
# **ActivateUsersRequestactivateCreate**
> void ActivateUsersRequestactivateCreate (string accept, ActivateUsersRequest body = null)

Activate a batch of users using theirs usernames - {ActivateUsersRequest}

Activate a batch of users using theirs usernames

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ActivateUsersRequestactivateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ActivateUsersRequest(); // ActivateUsersRequest |  (optional) 

            try
            {
                // Activate a batch of users using theirs usernames - {ActivateUsersRequest}
                apiInstance.ActivateUsersRequestactivateCreate(accept, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ActivateUsersRequestactivateCreate: " + e.Message );
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
 **body** | [**ActivateUsersRequest**](ActivateUsersRequest.md)|  | [optional] 

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

<a name="createuserrequestusernamepost"></a>
# **CreateUserRequestUserNamePost**
> User CreateUserRequestUserNamePost (string accept, string userName, CreateUserRequest body = null)

Create a new user - {CreateUserRequest}

Create a new user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateUserRequestUserNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | the name of the user.
            var body = new CreateUserRequest(); // CreateUserRequest |  (optional) 

            try
            {
                // Create a new user - {CreateUserRequest}
                User result = apiInstance.CreateUserRequestUserNamePost(accept, userName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUserRequestUserNamePost: " + e.Message );
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
 **userName** | **string**| the name of the user. | 
 **body** | [**CreateUserRequest**](CreateUserRequest.md)|  | [optional] 

### Return type

[**User**](User.md)

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

<a name="deactivateuserrequestusernamedeactivatepost"></a>
# **DeactivateUserRequestUserNamedeactivatePost**
> User DeactivateUserRequestUserNamedeactivatePost (string accept, string userName, Object body = null)

Deactivate the user using its username - {DeactivateUserRequest}

Deactivate the user using its username

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeactivateUserRequestUserNamedeactivatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The name of the user.
            var body = ;  // Object |  (optional) 

            try
            {
                // Deactivate the user using its username - {DeactivateUserRequest}
                User result = apiInstance.DeactivateUserRequestUserNamedeactivatePost(accept, userName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeactivateUserRequestUserNamedeactivatePost: " + e.Message );
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
 **userName** | **string**| The name of the user. | 
 **body** | **Object**|  | [optional] 

### Return type

[**User**](User.md)

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

<a name="deactivateusersrequestdesactivatecreate"></a>
# **DeactivateUsersRequestdesactivateCreate**
> void DeactivateUsersRequestdesactivateCreate (string accept, DeactivateUsersRequest body = null)

Deactivate a batch of users using theirs usernames - {DeactivateUsersRequest}

Deactivate a batch of users using theirs usernames

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeactivateUsersRequestdesactivateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new DeactivateUsersRequest(); // DeactivateUsersRequest |  (optional) 

            try
            {
                // Deactivate a batch of users using theirs usernames - {DeactivateUsersRequest}
                apiInstance.DeactivateUsersRequestdesactivateCreate(accept, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeactivateUsersRequestdesactivateCreate: " + e.Message );
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
 **body** | [**DeactivateUsersRequest**](DeactivateUsersRequest.md)|  | [optional] 

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

<a name="deleteuserrequestusernamedelete"></a>
# **DeleteUserRequestUserNameDelete**
> void DeleteUserRequestUserNameDelete (string accept, string userName)

Delete the user. - {DeleteUserRequest}

Delete the user using its username.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteUserRequestUserNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The username of the user.

            try
            {
                // Delete the user. - {DeleteUserRequest}
                apiInstance.DeleteUserRequestUserNameDelete(accept, userName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserRequestUserNameDelete: " + e.Message );
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
 **userName** | **string**| The username of the user. | 

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

<a name="findusersbynamerequestfindpost"></a>
# **FindUsersByNameRequestfindPost**
> FindUsersByNameResult FindUsersByNameRequestfindPost (string accept, FindUsersByNameRequest body = null)

Find the users by name. Search in userPrincipalName, displayName and givenName - {FindUsersByNameRequest}

Find the users by name. Search in userPrincipalName, displayName and givenName

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindUsersByNameRequestfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new FindUsersByNameRequest(); // FindUsersByNameRequest |  (optional) 

            try
            {
                // Find the users by name. Search in userPrincipalName, displayName and givenName - {FindUsersByNameRequest}
                FindUsersByNameResult result = apiInstance.FindUsersByNameRequestfindPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.FindUsersByNameRequestfindPost: " + e.Message );
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
 **body** | [**FindUsersByNameRequest**](FindUsersByNameRequest.md)|  | [optional] 

### Return type

[**FindUsersByNameResult**](FindUsersByNameResult.md)

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

<a name="forcechangeuserpasswordrequestusernameforcechangepasswordpost"></a>
# **ForceChangeUserPasswordRequestUserNameforceChangePasswordPost**
> void ForceChangeUserPasswordRequestUserNameforceChangePasswordPost (string accept, string userName, ForceChangeUserPasswordRequest body = null)

Force the change of a user's password. - {ForceChangeUserPasswordRequest}

Force the change of a user's password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ForceChangeUserPasswordRequestUserNameforceChangePasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The username.
            var body = new ForceChangeUserPasswordRequest(); // ForceChangeUserPasswordRequest |  (optional) 

            try
            {
                // Force the change of a user's password. - {ForceChangeUserPasswordRequest}
                apiInstance.ForceChangeUserPasswordRequestUserNameforceChangePasswordPost(accept, userName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ForceChangeUserPasswordRequestUserNameforceChangePasswordPost: " + e.Message );
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
 **userName** | **string**| The username. | 
 **body** | [**ForceChangeUserPasswordRequest**](ForceChangeUserPasswordRequest.md)|  | [optional] 

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

<a name="getavailabledomainsrequestdomainsget"></a>
# **GetAvailableDomainsRequestdomainsGet**
> List&lt;string&gt; GetAvailableDomainsRequestdomainsGet (string accept)

Retrieve the available domains of the tenant. - {GetAvailableDomainsRequest}

Retrieve the available domains of the tenant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAvailableDomainsRequestdomainsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the available domains of the tenant. - {GetAvailableDomainsRequest}
                List<string> result = apiInstance.GetAvailableDomainsRequestdomainsGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetAvailableDomainsRequestdomainsGet: " + e.Message );
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

**List<string>**

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

<a name="getusergroupsrequestusernamegroupsget"></a>
# **GetUserGroupsRequestUserNamegroupsGet**
> List&lt;Group&gt; GetUserGroupsRequestUserNamegroupsGet (string accept, string userName)

Retrieve the user's group(s). - {GetUserGroupsRequest}

Retrieve the user's group(s).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserGroupsRequestUserNamegroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The username of the user.

            try
            {
                // Retrieve the user's group(s). - {GetUserGroupsRequest}
                List<Group> result = apiInstance.GetUserGroupsRequestUserNamegroupsGet(accept, userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGroupsRequestUserNamegroupsGet: " + e.Message );
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
 **userName** | **string**| The username of the user. | 

### Return type

[**List&lt;Group&gt;**](Group.md)

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

<a name="getuserrequestusernameget"></a>
# **GetUserRequestUserNameGet**
> User GetUserRequestUserNameGet (string accept, string userName)

Retrieve the user by its username - {GetUserRequest}

Retrieve the user by its username

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserRequestUserNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The username of user.

            try
            {
                // Retrieve the user by its username - {GetUserRequest}
                User result = apiInstance.GetUserRequestUserNameGet(accept, userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRequestUserNameGet: " + e.Message );
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
 **userName** | **string**| The username of user. | 

### Return type

[**User**](User.md)

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
| **404** | The user was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetuserpasswordrequestusernameresetuserpasswordcreate"></a>
# **ResetUserPasswordRequestUserNameresetUserPasswordCreate**
> ResetUserPasswordResult ResetUserPasswordRequestUserNameresetUserPasswordCreate (string accept, string userName, Object body = null)

Reset the user password. - {ResetUserPasswordRequest}

Reset the user password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ResetUserPasswordRequestUserNameresetUserPasswordCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The username of the user.
            var body = ;  // Object |  (optional) 

            try
            {
                // Reset the user password. - {ResetUserPasswordRequest}
                ResetUserPasswordResult result = apiInstance.ResetUserPasswordRequestUserNameresetUserPasswordCreate(accept, userName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResetUserPasswordRequestUserNameresetUserPasswordCreate: " + e.Message );
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
 **userName** | **string**| The username of the user. | 
 **body** | **Object**|  | [optional] 

### Return type

[**ResetUserPasswordResult**](ResetUserPasswordResult.md)

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

<a name="saveuserrequestusernamecreate"></a>
# **SaveUserRequestUserNameCreate**
> User SaveUserRequestUserNameCreate (string accept, string userName, SaveUserRequest body = null)

Save the user. - {SaveUserRequest}

Save the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveUserRequestUserNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new UsersApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | the username of the user.
            var body = new SaveUserRequest(); // SaveUserRequest |  (optional) 

            try
            {
                // Save the user. - {SaveUserRequest}
                User result = apiInstance.SaveUserRequestUserNameCreate(accept, userName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.SaveUserRequestUserNameCreate: " + e.Message );
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
 **userName** | **string**| the username of the user. | 
 **body** | [**SaveUserRequest**](SaveUserRequest.md)|  | [optional] 

### Return type

[**User**](User.md)

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

