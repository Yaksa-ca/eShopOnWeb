# Yaksa.OrckestraCommerce.Client.Api.ScopesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateScopeRequestScopeIdPost**](ScopesApi.md#createscoperequestscopeidpost) | **POST** /scopes/{ScopeId} | Create a scope - {CreateScopeRequest}
[**DeleteScopeRequestScopeIdDelete**](ScopesApi.md#deletescoperequestscopeiddelete) | **DELETE** /scopes/{ScopeId} | Delete a scope - {DeleteScopeRequest}
[**GetScopeChildrenRequestScopeIdchildrenGet**](ScopesApi.md#getscopechildrenrequestscopeidchildrenget) | **GET** /scopes/{ScopeId}/children | Retreive the children of a specific scope - {GetScopeChildrenRequest}
[**GetScopeRequestScopeIdGet**](ScopesApi.md#getscoperequestscopeidget) | **GET** /scopes/{ScopeId} | Retreive a specific scope - {GetScopeRequest}
[**UpdateScopeRequestScopeIdCreate**](ScopesApi.md#updatescoperequestscopeidcreate) | **PUT** /scopes/{ScopeId} | Update a scope - {UpdateScopeRequest}


<a name="createscoperequestscopeidpost"></a>
# **CreateScopeRequestScopeIdPost**
> Scope CreateScopeRequestScopeIdPost (string accept, string scopeId, CreateScopeRequest body = null)

Create a scope - {CreateScopeRequest}

Create a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateScopeRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ScopesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The unique identifier of the scope to create.
            var body = new CreateScopeRequest(); // CreateScopeRequest |  (optional) 

            try
            {
                // Create a scope - {CreateScopeRequest}
                Scope result = apiInstance.CreateScopeRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScopesApi.CreateScopeRequestScopeIdPost: " + e.Message );
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
 **scopeId** | **string**| The unique identifier of the scope to create. | 
 **body** | [**CreateScopeRequest**](CreateScopeRequest.md)|  | [optional] 

### Return type

[**Scope**](Scope.md)

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

<a name="deletescoperequestscopeiddelete"></a>
# **DeleteScopeRequestScopeIdDelete**
> void DeleteScopeRequestScopeIdDelete (string accept, string scopeId)

Delete a scope - {DeleteScopeRequest}

Delete a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteScopeRequestScopeIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ScopesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The unique identifier of the scope to delete.

            try
            {
                // Delete a scope - {DeleteScopeRequest}
                apiInstance.DeleteScopeRequestScopeIdDelete(accept, scopeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScopesApi.DeleteScopeRequestScopeIdDelete: " + e.Message );
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
 **scopeId** | **string**| The unique identifier of the scope to delete. | 

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

<a name="getscopechildrenrequestscopeidchildrenget"></a>
# **GetScopeChildrenRequestScopeIdchildrenGet**
> List&lt;Scope&gt; GetScopeChildrenRequestScopeIdchildrenGet (string accept, string scopeId, string cultureName = null, bool? includeCurrency = null)

Retreive the children of a specific scope - {GetScopeChildrenRequest}

Return a list of children scopes for the requested parent scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetScopeChildrenRequestScopeIdchildrenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ScopesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 
            var includeCurrency = true;  // bool? | Whether to include the associated currency (optional) 

            try
            {
                // Retreive the children of a specific scope - {GetScopeChildrenRequest}
                List<Scope> result = apiInstance.GetScopeChildrenRequestScopeIdchildrenGet(accept, scopeId, cultureName, includeCurrency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScopesApi.GetScopeChildrenRequestScopeIdchildrenGet: " + e.Message );
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
 **scopeId** | **string**| The id of the requested scope. | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 
 **includeCurrency** | **bool?**| Whether to include the associated currency | [optional] 

### Return type

[**List&lt;Scope&gt;**](Scope.md)

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
| **404** | Requested scope id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscoperequestscopeidget"></a>
# **GetScopeRequestScopeIdGet**
> Scope GetScopeRequestScopeIdGet (string accept, string scopeId, string cultureName = null, bool? includeChildren = null, bool? includeCurrency = null)

Retreive a specific scope - {GetScopeRequest}

Returns the requested scope. Optionally include Children and Currency information if the corresponding flags are set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetScopeRequestScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ScopesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope.
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 
            var includeChildren = true;  // bool? | Whether to include the entire scope map (optional) 
            var includeCurrency = true;  // bool? | Whether to include the associated currency (optional) 

            try
            {
                // Retreive a specific scope - {GetScopeRequest}
                Scope result = apiInstance.GetScopeRequestScopeIdGet(accept, scopeId, cultureName, includeChildren, includeCurrency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScopesApi.GetScopeRequestScopeIdGet: " + e.Message );
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
 **scopeId** | **string**| The id of the requested scope. | 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 
 **includeChildren** | **bool?**| Whether to include the entire scope map | [optional] 
 **includeCurrency** | **bool?**| Whether to include the associated currency | [optional] 

### Return type

[**Scope**](Scope.md)

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
| **404** | Requested scope id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatescoperequestscopeidcreate"></a>
# **UpdateScopeRequestScopeIdCreate**
> Scope UpdateScopeRequestScopeIdCreate (string accept, string scopeId, UpdateScopeRequest body = null)

Update a scope - {UpdateScopeRequest}

Update a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateScopeRequestScopeIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ScopesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The unique identifier of the scope to create.
            var body = new UpdateScopeRequest(); // UpdateScopeRequest |  (optional) 

            try
            {
                // Update a scope - {UpdateScopeRequest}
                Scope result = apiInstance.UpdateScopeRequestScopeIdCreate(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScopesApi.UpdateScopeRequestScopeIdCreate: " + e.Message );
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
 **scopeId** | **string**| The unique identifier of the scope to create. | 
 **body** | [**UpdateScopeRequest**](UpdateScopeRequest.md)|  | [optional] 

### Return type

[**Scope**](Scope.md)

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

