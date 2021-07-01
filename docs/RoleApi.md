# Yaksa.OrckestraCommerce.Client.Api.RoleApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetParentRolesRequestRoleIdparentsGet**](RoleApi.md#getparentrolesrequestroleidparentsget) | **GET** /role/{RoleId}/parents | Retrieve the list of parent role of a child role - {GetParentRolesRequest}


<a name="getparentrolesrequestroleidparentsget"></a>
# **GetParentRolesRequestRoleIdparentsGet**
> List&lt;Role&gt; GetParentRolesRequestRoleIdparentsGet (string accept, int roleId)

Retrieve the list of parent role of a child role - {GetParentRolesRequest}

Retrieve the list of parent role of a child role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetParentRolesRequestRoleIdparentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RoleApi(config);
            var accept = accept_example;  // string | Accept Header
            var roleId = 56;  // int | The child role identifier.

            try
            {
                // Retrieve the list of parent role of a child role - {GetParentRolesRequest}
                List<Role> result = apiInstance.GetParentRolesRequestRoleIdparentsGet(accept, roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleApi.GetParentRolesRequestRoleIdparentsGet: " + e.Message );
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
 **roleId** | **int**| The child role identifier. | 

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

