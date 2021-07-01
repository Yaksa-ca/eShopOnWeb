# Yaksa.OrckestraCommerce.Client.Api.DiagnosticApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BasicDiagnosticRequestbasicGet**](DiagnosticApi.md#basicdiagnosticrequestbasicget) | **GET** /diagnostic/basic | Check the latency - {BasicDiagnosticRequest}
[**GetCacheStatusRequestcachesGet**](DiagnosticApi.md#getcachestatusrequestcachesget) | **GET** /diagnostic/caches | Get caches status  - {GetCacheStatusRequest}
[**GetVersionInfoRequestversioninfoGet**](DiagnosticApi.md#getversioninforequestversioninfoget) | **GET** /diagnostic/versioninfo | Return Orckestra Commerce Cloud platform Version Information - {GetVersionInfoRequest}


<a name="basicdiagnosticrequestbasicget"></a>
# **BasicDiagnosticRequestbasicGet**
> BasicDiagnostic BasicDiagnosticRequestbasicGet (string accept)

Check the latency - {BasicDiagnosticRequest}

Check the latency, no computation done

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class BasicDiagnosticRequestbasicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DiagnosticApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Check the latency - {BasicDiagnosticRequest}
                BasicDiagnostic result = apiInstance.BasicDiagnosticRequestbasicGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticApi.BasicDiagnosticRequestbasicGet: " + e.Message );
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

[**BasicDiagnostic**](BasicDiagnostic.md)

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

<a name="getcachestatusrequestcachesget"></a>
# **GetCacheStatusRequestcachesGet**
> List&lt;CacheStatus&gt; GetCacheStatusRequestcachesGet (string accept, string name = null)

Get caches status  - {GetCacheStatusRequest}

Get caches status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCacheStatusRequestcachesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DiagnosticApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | Optional. Name of the cache to retrieve. If none specified return status for all caches (optional) 

            try
            {
                // Get caches status  - {GetCacheStatusRequest}
                List<CacheStatus> result = apiInstance.GetCacheStatusRequestcachesGet(accept, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticApi.GetCacheStatusRequestcachesGet: " + e.Message );
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
 **name** | **string**| Optional. Name of the cache to retrieve. If none specified return status for all caches | [optional] 

### Return type

[**List&lt;CacheStatus&gt;**](CacheStatus.md)

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

<a name="getversioninforequestversioninfoget"></a>
# **GetVersionInfoRequestversioninfoGet**
> VersionInfo GetVersionInfoRequestversioninfoGet (string accept, string cultureName = null)

Return Orckestra Commerce Cloud platform Version Information - {GetVersionInfoRequest}

Request used to return Orckestra Commerce Cloud platform Version Information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetVersionInfoRequestversioninfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DiagnosticApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language the url will be returned (optional) 

            try
            {
                // Return Orckestra Commerce Cloud platform Version Information - {GetVersionInfoRequest}
                VersionInfo result = apiInstance.GetVersionInfoRequestversioninfoGet(accept, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticApi.GetVersionInfoRequestversioninfoGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language the url will be returned | [optional] 

### Return type

[**VersionInfo**](VersionInfo.md)

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

