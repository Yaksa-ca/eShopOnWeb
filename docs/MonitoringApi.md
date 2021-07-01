# Yaksa.OrckestraCommerce.Client.Api.MonitoringApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOvertureHostInfoRequesthealthGet**](MonitoringApi.md#getoverturehostinforequesthealthget) | **GET** /monitoring/health | &lt;Add summary here&gt; - {GetOvertureHostInfoRequest}


<a name="getoverturehostinforequesthealthget"></a>
# **GetOvertureHostInfoRequesthealthGet**
> OvertureHostInfo GetOvertureHostInfoRequesthealthGet (string accept)

<Add summary here> - {GetOvertureHostInfoRequest}

Do not work in Swagger. To test it, send AccessToken value for example in the url {servicesUrl}api/monitoring/health?AccessToken=

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOvertureHostInfoRequesthealthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MonitoringApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // <Add summary here> - {GetOvertureHostInfoRequest}
                OvertureHostInfo result = apiInstance.GetOvertureHostInfoRequesthealthGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoringApi.GetOvertureHostInfoRequesthealthGet: " + e.Message );
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

[**OvertureHostInfo**](OvertureHostInfo.md)

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

