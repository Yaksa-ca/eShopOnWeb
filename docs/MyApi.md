# Yaksa.OrckestraCommerce.Client.Api.MyApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAuthorizedApplicationsRequestapplicationsGet**](MyApi.md#getauthorizedapplicationsrequestapplicationsget) | **GET** /my/applications/ | Retrieve the authorized applications list with the preferred application first. - {GetAuthorizedApplicationsRequest}
[**GetUserApplicationRequestapplicationGet**](MyApi.md#getuserapplicationrequestapplicationget) | **GET** /my/application | Retrieve the user default application id - {GetUserApplicationRequest}
[**GetUserCultureRequestcultureGet**](MyApi.md#getuserculturerequestcultureget) | **GET** /my/culture | Retrive the user prefered culture - {GetUserCultureRequest}
[**GetUserScopeRequestscopeModuleGet**](MyApi.md#getuserscoperequestscopemoduleget) | **GET** /my/scope/{Module} | Retrive the default user scope id for the provided module - {GetUserScopeRequest}
[**GetUserScopeTreeRequestscopeModuletreeGet**](MyApi.md#getuserscopetreerequestscopemoduletreeget) | **GET** /my/scope/{Module}/tree | Retrieve scope tree based on the user permissions for the provided module - {GetUserScopeTreeRequest}
[**SaveUserApplicationRequestapplicationApplicationIdPost**](MyApi.md#saveuserapplicationrequestapplicationapplicationidpost) | **POST** /my/application/{ApplicationId} | Set the user default application by providing the application id - {SaveUserApplicationRequest}
[**SaveUserCultureRequestcultureCultureIsoPost**](MyApi.md#saveuserculturerequestculturecultureisopost) | **POST** /my/culture/{CultureIso} | Set the user culture providing it&#39;s ISO format (ie en-US) - {SaveUserCultureRequest}
[**SaveUserScopeRequestscopeModuleScopeIdPost**](MyApi.md#saveuserscoperequestscopemodulescopeidpost) | **POST** /my/scope/{Module}/{ScopeId} | Set the user default scope providing the scope id and the module - {SaveUserScopeRequest}


<a name="getauthorizedapplicationsrequestapplicationsget"></a>
# **GetAuthorizedApplicationsRequestapplicationsGet**
> List&lt;Application&gt; GetAuthorizedApplicationsRequestapplicationsGet (string accept)

Retrieve the authorized applications list with the preferred application first. - {GetAuthorizedApplicationsRequest}

Retrieve the authorized applications list with the preferred application first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAuthorizedApplicationsRequestapplicationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the authorized applications list with the preferred application first. - {GetAuthorizedApplicationsRequest}
                List<Application> result = apiInstance.GetAuthorizedApplicationsRequestapplicationsGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.GetAuthorizedApplicationsRequestapplicationsGet: " + e.Message );
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

[**List&lt;Application&gt;**](Application.md)

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

<a name="getuserapplicationrequestapplicationget"></a>
# **GetUserApplicationRequestapplicationGet**
> Application GetUserApplicationRequestapplicationGet (string accept)

Retrieve the user default application id - {GetUserApplicationRequest}

Retrieve the user default application id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserApplicationRequestapplicationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the user default application id - {GetUserApplicationRequest}
                Application result = apiInstance.GetUserApplicationRequestapplicationGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.GetUserApplicationRequestapplicationGet: " + e.Message );
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

[**Application**](Application.md)

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

<a name="getuserculturerequestcultureget"></a>
# **GetUserCultureRequestcultureGet**
> Culture GetUserCultureRequestcultureGet (string accept)

Retrive the user prefered culture - {GetUserCultureRequest}

Retrive the user prefered culture

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserCultureRequestcultureGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrive the user prefered culture - {GetUserCultureRequest}
                Culture result = apiInstance.GetUserCultureRequestcultureGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.GetUserCultureRequestcultureGet: " + e.Message );
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

[**Culture**](Culture.md)

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

<a name="getuserscoperequestscopemoduleget"></a>
# **GetUserScopeRequestscopeModuleGet**
> Scope GetUserScopeRequestscopeModuleGet (string accept, string module)

Retrive the default user scope id for the provided module - {GetUserScopeRequest}

Retrive the user scope id for the provided module

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserScopeRequestscopeModuleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header
            var module = module_example;  // string | The module for which the scope will be define as default

            try
            {
                // Retrive the default user scope id for the provided module - {GetUserScopeRequest}
                Scope result = apiInstance.GetUserScopeRequestscopeModuleGet(accept, module);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.GetUserScopeRequestscopeModuleGet: " + e.Message );
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
 **module** | **string**| The module for which the scope will be define as default | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserscopetreerequestscopemoduletreeget"></a>
# **GetUserScopeTreeRequestscopeModuletreeGet**
> AuthorizedScope GetUserScopeTreeRequestscopeModuletreeGet (string accept, string module, string cultureName = null)

Retrieve scope tree based on the user permissions for the provided module - {GetUserScopeTreeRequest}

Retrieve scope tree based on the user permissions for the provided module

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserScopeTreeRequestscopeModuletreeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header
            var module = module_example;  // string | The module for which the scope tree is returned.
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned. (optional) 

            try
            {
                // Retrieve scope tree based on the user permissions for the provided module - {GetUserScopeTreeRequest}
                AuthorizedScope result = apiInstance.GetUserScopeTreeRequestscopeModuletreeGet(accept, module, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.GetUserScopeTreeRequestscopeModuletreeGet: " + e.Message );
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
 **module** | **string**| The module for which the scope tree is returned. | 
 **cultureName** | **string**| The culture name in which language tha data will be returned. | [optional] 

### Return type

[**AuthorizedScope**](AuthorizedScope.md)

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

<a name="saveuserapplicationrequestapplicationapplicationidpost"></a>
# **SaveUserApplicationRequestapplicationApplicationIdPost**
> void SaveUserApplicationRequestapplicationApplicationIdPost (string accept, int applicationId, Object body = null)

Set the user default application by providing the application id - {SaveUserApplicationRequest}

Set the user default application by providing the application id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveUserApplicationRequestapplicationApplicationIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header
            var applicationId = 56;  // int | The id of the application
            var body = ;  // Object |  (optional) 

            try
            {
                // Set the user default application by providing the application id - {SaveUserApplicationRequest}
                apiInstance.SaveUserApplicationRequestapplicationApplicationIdPost(accept, applicationId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.SaveUserApplicationRequestapplicationApplicationIdPost: " + e.Message );
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
 **applicationId** | **int**| The id of the application | 
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

<a name="saveuserculturerequestculturecultureisopost"></a>
# **SaveUserCultureRequestcultureCultureIsoPost**
> void SaveUserCultureRequestcultureCultureIsoPost (string accept, string cultureIso, Object body = null)

Set the user culture providing it's ISO format (ie en-US) - {SaveUserCultureRequest}

Set the user culture providing it's ISO format (ie en-US) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveUserCultureRequestcultureCultureIsoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureIso = cultureIso_example;  // string | The culture in iso format
            var body = ;  // Object |  (optional) 

            try
            {
                // Set the user culture providing it's ISO format (ie en-US) - {SaveUserCultureRequest}
                apiInstance.SaveUserCultureRequestcultureCultureIsoPost(accept, cultureIso, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.SaveUserCultureRequestcultureCultureIsoPost: " + e.Message );
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
 **cultureIso** | **string**| The culture in iso format | 
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

<a name="saveuserscoperequestscopemodulescopeidpost"></a>
# **SaveUserScopeRequestscopeModuleScopeIdPost**
> void SaveUserScopeRequestscopeModuleScopeIdPost (string accept, string module, string scopeId, Object body = null)

Set the user default scope providing the scope id and the module - {SaveUserScopeRequest}

Set the user default scope providing the scope id and the module

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveUserScopeRequestscopeModuleScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MyApi(config);
            var accept = accept_example;  // string | Accept Header
            var module = module_example;  // string | The module for which the user will set the default scope
            var scopeId = scopeId_example;  // string | The default scope id
            var body = ;  // Object |  (optional) 

            try
            {
                // Set the user default scope providing the scope id and the module - {SaveUserScopeRequest}
                apiInstance.SaveUserScopeRequestscopeModuleScopeIdPost(accept, module, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyApi.SaveUserScopeRequestscopeModuleScopeIdPost: " + e.Message );
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
 **module** | **string**| The module for which the user will set the default scope | 
 **scopeId** | **string**| The default scope id | 
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

