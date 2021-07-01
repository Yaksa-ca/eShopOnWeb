# Yaksa.OrckestraCommerce.Client.Api.ModulesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApplicationModulesbyApplicationNameApplicationNameGet**](ModulesApi.md#getapplicationmodulesbyapplicationnameapplicationnameget) | **GET** /modules/byApplicationName/{ApplicationName} | Retrieve all the specified application modules. - {GetApplicationModules}
[**GetModulesRequestGet**](ModulesApi.md#getmodulesrequestget) | **GET** /modules/ | Retrieve the full list of modules. - {GetModulesRequest}


<a name="getapplicationmodulesbyapplicationnameapplicationnameget"></a>
# **GetApplicationModulesbyApplicationNameApplicationNameGet**
> List&lt;Module&gt; GetApplicationModulesbyApplicationNameApplicationNameGet (string accept, string applicationName)

Retrieve all the specified application modules. - {GetApplicationModules}

Retrieve all the specified application modules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetApplicationModulesbyApplicationNameApplicationNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ModulesApi(config);
            var accept = accept_example;  // string | Accept Header
            var applicationName = applicationName_example;  // string | The application name.

            try
            {
                // Retrieve all the specified application modules. - {GetApplicationModules}
                List<Module> result = apiInstance.GetApplicationModulesbyApplicationNameApplicationNameGet(accept, applicationName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModulesApi.GetApplicationModulesbyApplicationNameApplicationNameGet: " + e.Message );
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
 **applicationName** | **string**| The application name. | 

### Return type

[**List&lt;Module&gt;**](Module.md)

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

<a name="getmodulesrequestget"></a>
# **GetModulesRequestGet**
> List&lt;Module&gt; GetModulesRequestGet (string accept)

Retrieve the full list of modules. - {GetModulesRequest}

Retrieve the full list of modules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetModulesRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ModulesApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the full list of modules. - {GetModulesRequest}
                List<Module> result = apiInstance.GetModulesRequestGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModulesApi.GetModulesRequestGet: " + e.Message );
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

[**List&lt;Module&gt;**](Module.md)

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

