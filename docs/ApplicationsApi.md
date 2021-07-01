# Yaksa.OrckestraCommerce.Client.Api.ApplicationsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllApplicationsRequestGet**](ApplicationsApi.md#getallapplicationsrequestget) | **GET** /applications/ | Retrieve the full list of applications. - {GetAllApplicationsRequest}
[**SetApplicationVisibilityRequestApplicationIdvisibilityCreate**](ApplicationsApi.md#setapplicationvisibilityrequestapplicationidvisibilitycreate) | **PUT** /applications/{ApplicationId}/visibility | Set the application visibility. - {SetApplicationVisibilityRequest}


<a name="getallapplicationsrequestget"></a>
# **GetAllApplicationsRequestGet**
> List&lt;Application&gt; GetAllApplicationsRequestGet (string accept)

Retrieve the full list of applications. - {GetAllApplicationsRequest}

Retrieve the full list of applications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAllApplicationsRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ApplicationsApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the full list of applications. - {GetAllApplicationsRequest}
                List<Application> result = apiInstance.GetAllApplicationsRequestGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.GetAllApplicationsRequestGet: " + e.Message );
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

<a name="setapplicationvisibilityrequestapplicationidvisibilitycreate"></a>
# **SetApplicationVisibilityRequestApplicationIdvisibilityCreate**
> Application SetApplicationVisibilityRequestApplicationIdvisibilityCreate (string accept, int applicationId, SetApplicationVisibilityRequest body = null)

Set the application visibility. - {SetApplicationVisibilityRequest}

Set the application visibility.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SetApplicationVisibilityRequestApplicationIdvisibilityCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ApplicationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var applicationId = 56;  // int | The id of the application
            var body = new SetApplicationVisibilityRequest(); // SetApplicationVisibilityRequest |  (optional) 

            try
            {
                // Set the application visibility. - {SetApplicationVisibilityRequest}
                Application result = apiInstance.SetApplicationVisibilityRequestApplicationIdvisibilityCreate(accept, applicationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.SetApplicationVisibilityRequestApplicationIdvisibilityCreate: " + e.Message );
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
 **body** | [**SetApplicationVisibilityRequest**](SetApplicationVisibilityRequest.md)|  | [optional] 

### Return type

[**Application**](Application.md)

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

