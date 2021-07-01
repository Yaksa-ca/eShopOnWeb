# Yaksa.OrckestraCommerce.Client.Api.AuthorizationsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDirectAuthorizationsRequestdirectObjectsIdsPost**](AuthorizationsApi.md#getdirectauthorizationsrequestdirectobjectsidspost) | **POST** /authorizations/direct/{ObjectsIds} | Retrievet the direct authorizations - {GetDirectAuthorizationsRequest}
[**GetEffectiveAuthorizationsRequestGetEffectiveAuthorizationsPost**](AuthorizationsApi.md#geteffectiveauthorizationsrequestgeteffectiveauthorizationspost) | **POST** /authorizations/GetEffectiveAuthorizations | Retrieve the effective authorizations - {GetEffectiveAuthorizationsRequest}
[**GetMembershipSettingsRequestsettingsGet**](AuthorizationsApi.md#getmembershipsettingsrequestsettingsget) | **GET** /authorizations/settings | Retrieve the membership settings - {GetMembershipSettingsRequest}
[**GetUserEffectiveAuthorizationsRequestUserNameGetEffectiveAuthorizationsGet**](AuthorizationsApi.md#getusereffectiveauthorizationsrequestusernamegeteffectiveauthorizationsget) | **GET** /authorizations/{UserName}/GetEffectiveAuthorizations | Retrieve the user effective authorizations - {GetUserEffectiveAuthorizationsRequest}
[**GrantAuthorizationRequestRoleIdObjectIdPost**](AuthorizationsApi.md#grantauthorizationrequestroleidobjectidpost) | **POST** /authorizations/{RoleId}/{ObjectId} | Grant an authorization to an object (user or group for instance). - {GrantAuthorizationRequest}
[**GrantAuthorizationsRequestObjectIdPost**](AuthorizationsApi.md#grantauthorizationsrequestobjectidpost) | **POST** /authorizations/{ObjectId} | Grant a list of authorization to an object (user or group for instance). - {GrantAuthorizationsRequest}
[**RevokeAuthorizationRequestRoleIdObjectIdDelete**](AuthorizationsApi.md#revokeauthorizationrequestroleidobjectiddelete) | **DELETE** /authorizations/{RoleId}/{ObjectId} | Revoke an authorization to an object (user or group for instance). - {RevokeAuthorizationRequest}
[**RevokeAuthorizationsRequestObjectIdDelete**](AuthorizationsApi.md#revokeauthorizationsrequestobjectiddelete) | **DELETE** /authorizations/{ObjectId} | Revoke a list of authorization to an object (user or group for instance). - {RevokeAuthorizationsRequest}


<a name="getdirectauthorizationsrequestdirectobjectsidspost"></a>
# **GetDirectAuthorizationsRequestdirectObjectsIdsPost**
> List&lt;MembershipAuthorization&gt; GetDirectAuthorizationsRequestdirectObjectsIdsPost (string accept, List<string> objectsIds, Object body = null)

Retrievet the direct authorizations - {GetDirectAuthorizationsRequest}

Retrieve the direct authorizations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetDirectAuthorizationsRequestdirectObjectsIdsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var objectsIds = new List<string>(); // List<string> | The objects identifiers.
            var body = ;  // Object |  (optional) 

            try
            {
                // Retrievet the direct authorizations - {GetDirectAuthorizationsRequest}
                List<MembershipAuthorization> result = apiInstance.GetDirectAuthorizationsRequestdirectObjectsIdsPost(accept, objectsIds, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.GetDirectAuthorizationsRequestdirectObjectsIdsPost: " + e.Message );
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
 **objectsIds** | [**List&lt;string&gt;**](string.md)| The objects identifiers. | 
 **body** | **Object**|  | [optional] 

### Return type

[**List&lt;MembershipAuthorization&gt;**](MembershipAuthorization.md)

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

<a name="geteffectiveauthorizationsrequestgeteffectiveauthorizationspost"></a>
# **GetEffectiveAuthorizationsRequestGetEffectiveAuthorizationsPost**
> List&lt;MembershipAuthorization&gt; GetEffectiveAuthorizationsRequestGetEffectiveAuthorizationsPost (string accept, GetEffectiveAuthorizationsRequest body = null)

Retrieve the effective authorizations - {GetEffectiveAuthorizationsRequest}

Retrieve the effective authorizations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetEffectiveAuthorizationsRequestGetEffectiveAuthorizationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new GetEffectiveAuthorizationsRequest(); // GetEffectiveAuthorizationsRequest |  (optional) 

            try
            {
                // Retrieve the effective authorizations - {GetEffectiveAuthorizationsRequest}
                List<MembershipAuthorization> result = apiInstance.GetEffectiveAuthorizationsRequestGetEffectiveAuthorizationsPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.GetEffectiveAuthorizationsRequestGetEffectiveAuthorizationsPost: " + e.Message );
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
 **body** | [**GetEffectiveAuthorizationsRequest**](GetEffectiveAuthorizationsRequest.md)|  | [optional] 

### Return type

[**List&lt;MembershipAuthorization&gt;**](MembershipAuthorization.md)

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

<a name="getmembershipsettingsrequestsettingsget"></a>
# **GetMembershipSettingsRequestsettingsGet**
> MembershipSettings GetMembershipSettingsRequestsettingsGet (string accept)

Retrieve the membership settings - {GetMembershipSettingsRequest}

Retrieve the membership settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMembershipSettingsRequestsettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the membership settings - {GetMembershipSettingsRequest}
                MembershipSettings result = apiInstance.GetMembershipSettingsRequestsettingsGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.GetMembershipSettingsRequestsettingsGet: " + e.Message );
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

[**MembershipSettings**](MembershipSettings.md)

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

<a name="getusereffectiveauthorizationsrequestusernamegeteffectiveauthorizationsget"></a>
# **GetUserEffectiveAuthorizationsRequestUserNameGetEffectiveAuthorizationsGet**
> List&lt;MembershipAuthorization&gt; GetUserEffectiveAuthorizationsRequestUserNameGetEffectiveAuthorizationsGet (string accept, string userName)

Retrieve the user effective authorizations - {GetUserEffectiveAuthorizationsRequest}

Retrieve the user effective authorizations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserEffectiveAuthorizationsRequestUserNameGetEffectiveAuthorizationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var userName = userName_example;  // string | The username of the user.

            try
            {
                // Retrieve the user effective authorizations - {GetUserEffectiveAuthorizationsRequest}
                List<MembershipAuthorization> result = apiInstance.GetUserEffectiveAuthorizationsRequestUserNameGetEffectiveAuthorizationsGet(accept, userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.GetUserEffectiveAuthorizationsRequestUserNameGetEffectiveAuthorizationsGet: " + e.Message );
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

[**List&lt;MembershipAuthorization&gt;**](MembershipAuthorization.md)

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

<a name="grantauthorizationrequestroleidobjectidpost"></a>
# **GrantAuthorizationRequestRoleIdObjectIdPost**
> void GrantAuthorizationRequestRoleIdObjectIdPost (string accept, int roleId, string objectId, GrantAuthorizationRequest body = null)

Grant an authorization to an object (user or group for instance). - {GrantAuthorizationRequest}

Grant an authorization to an object (user or group for instance). If the RequestedScopeId is not specified all scopes will be granted (*). ObjectType is a short description about the object you are giving a permission (User, Group etc.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GrantAuthorizationRequestRoleIdObjectIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var roleId = 56;  // int | The role identifier.
            var objectId = objectId_example;  // string | The object identifier.
            var body = new GrantAuthorizationRequest(); // GrantAuthorizationRequest |  (optional) 

            try
            {
                // Grant an authorization to an object (user or group for instance). - {GrantAuthorizationRequest}
                apiInstance.GrantAuthorizationRequestRoleIdObjectIdPost(accept, roleId, objectId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.GrantAuthorizationRequestRoleIdObjectIdPost: " + e.Message );
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
 **roleId** | **int**| The role identifier. | 
 **objectId** | **string**| The object identifier. | 
 **body** | [**GrantAuthorizationRequest**](GrantAuthorizationRequest.md)|  | [optional] 

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

<a name="grantauthorizationsrequestobjectidpost"></a>
# **GrantAuthorizationsRequestObjectIdPost**
> void GrantAuthorizationsRequestObjectIdPost (string accept, string objectId, GrantAuthorizationsRequest body = null)

Grant a list of authorization to an object (user or group for instance). - {GrantAuthorizationsRequest}

Grant a list of authorization to an object (user or group for instance). If the RequestedScopeId is not specified all scopes will be granted (*). ObjectType is a short description about the object you are giving a permission (User, Group etc.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GrantAuthorizationsRequestObjectIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var objectId = objectId_example;  // string | The object identifier.
            var body = new GrantAuthorizationsRequest(); // GrantAuthorizationsRequest |  (optional) 

            try
            {
                // Grant a list of authorization to an object (user or group for instance). - {GrantAuthorizationsRequest}
                apiInstance.GrantAuthorizationsRequestObjectIdPost(accept, objectId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.GrantAuthorizationsRequestObjectIdPost: " + e.Message );
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
 **objectId** | **string**| The object identifier. | 
 **body** | [**GrantAuthorizationsRequest**](GrantAuthorizationsRequest.md)|  | [optional] 

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

<a name="revokeauthorizationrequestroleidobjectiddelete"></a>
# **RevokeAuthorizationRequestRoleIdObjectIdDelete**
> void RevokeAuthorizationRequestRoleIdObjectIdDelete (string accept, int roleId, string objectId, string requestedScopeId = null, string objectType = null)

Revoke an authorization to an object (user or group for instance). - {RevokeAuthorizationRequest}

Revoke an authorization to an object (user or group for instance).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RevokeAuthorizationRequestRoleIdObjectIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var roleId = 56;  // int | The Role identifier.
            var objectId = objectId_example;  // string | The Object identifier.
            var requestedScopeId = requestedScopeId_example;  // string | The Scope identifier. (optional) 
            var objectType = objectType_example;  // string | The object type. (optional) 

            try
            {
                // Revoke an authorization to an object (user or group for instance). - {RevokeAuthorizationRequest}
                apiInstance.RevokeAuthorizationRequestRoleIdObjectIdDelete(accept, roleId, objectId, requestedScopeId, objectType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.RevokeAuthorizationRequestRoleIdObjectIdDelete: " + e.Message );
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
 **roleId** | **int**| The Role identifier. | 
 **objectId** | **string**| The Object identifier. | 
 **requestedScopeId** | **string**| The Scope identifier. | [optional] 
 **objectType** | **string**| The object type. | [optional] 

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

<a name="revokeauthorizationsrequestobjectiddelete"></a>
# **RevokeAuthorizationsRequestObjectIdDelete**
> void RevokeAuthorizationsRequestObjectIdDelete (string accept, string objectId, List<string> authorizationsToRevoke = null)

Revoke a list of authorization to an object (user or group for instance). - {RevokeAuthorizationsRequest}

Revoke a list of authorization to an object (user or group for instance).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RevokeAuthorizationsRequestObjectIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthorizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var objectId = objectId_example;  // string | The object identifier.
            var authorizationsToRevoke = new List<string>(); // List<string> | The list of authorization to revoke. (optional) 

            try
            {
                // Revoke a list of authorization to an object (user or group for instance). - {RevokeAuthorizationsRequest}
                apiInstance.RevokeAuthorizationsRequestObjectIdDelete(accept, objectId, authorizationsToRevoke);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.RevokeAuthorizationsRequestObjectIdDelete: " + e.Message );
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
 **objectId** | **string**| The object identifier. | 
 **authorizationsToRevoke** | [**List&lt;string&gt;**](string.md)| The list of authorization to revoke. | [optional] 

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

