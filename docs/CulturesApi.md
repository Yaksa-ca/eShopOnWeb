# Yaksa.OrckestraCommerce.Client.Api.CulturesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllCulturesRequestallGet**](CulturesApi.md#getallculturesrequestallget) | **GET** /cultures/all | Retrieve all cultures known to the system, including non supported - {GetAllCulturesRequest}
[**GetSupportedCulturesRequestGet**](CulturesApi.md#getsupportedculturesrequestget) | **GET** /cultures | Retrieve all supported cultures of the system - {GetSupportedCulturesRequest}
[**SetDefaultCultureRequestdefaultCreate**](CulturesApi.md#setdefaultculturerequestdefaultcreate) | **PUT** /cultures/default | Sets the default culture for the system - {SetDefaultCultureRequest}
[**SetSupportedCulturesRequestCreate**](CulturesApi.md#setsupportedculturesrequestcreate) | **PUT** /cultures | Updates the list of supported cultures in the system - {SetSupportedCulturesRequest}


<a name="getallculturesrequestallget"></a>
# **GetAllCulturesRequestallGet**
> CultureList GetAllCulturesRequestallGet (string accept)

Retrieve all cultures known to the system, including non supported - {GetAllCulturesRequest}

Retrieve all cultures known to the system, including non supported

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAllCulturesRequestallGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CulturesApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve all cultures known to the system, including non supported - {GetAllCulturesRequest}
                CultureList result = apiInstance.GetAllCulturesRequestallGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CulturesApi.GetAllCulturesRequestallGet: " + e.Message );
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

[**CultureList**](CultureList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupportedculturesrequestget"></a>
# **GetSupportedCulturesRequestGet**
> List&lt;Culture&gt; GetSupportedCulturesRequestGet (string accept)

Retrieve all supported cultures of the system - {GetSupportedCulturesRequest}

Retrieve all supported cultures of the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetSupportedCulturesRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CulturesApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve all supported cultures of the system - {GetSupportedCulturesRequest}
                List<Culture> result = apiInstance.GetSupportedCulturesRequestGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CulturesApi.GetSupportedCulturesRequestGet: " + e.Message );
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

[**List&lt;Culture&gt;**](Culture.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdefaultculturerequestdefaultcreate"></a>
# **SetDefaultCultureRequestdefaultCreate**
> void SetDefaultCultureRequestdefaultCreate (string accept, SetDefaultCultureRequest body = null)

Sets the default culture for the system - {SetDefaultCultureRequest}

Sets the default culture for the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SetDefaultCultureRequestdefaultCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CulturesApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new SetDefaultCultureRequest(); // SetDefaultCultureRequest |  (optional) 

            try
            {
                // Sets the default culture for the system - {SetDefaultCultureRequest}
                apiInstance.SetDefaultCultureRequestdefaultCreate(accept, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CulturesApi.SetDefaultCultureRequestdefaultCreate: " + e.Message );
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
 **body** | [**SetDefaultCultureRequest**](SetDefaultCultureRequest.md)|  | [optional] 

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
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsupportedculturesrequestcreate"></a>
# **SetSupportedCulturesRequestCreate**
> void SetSupportedCulturesRequestCreate (string accept, SetSupportedCulturesRequest body = null)

Updates the list of supported cultures in the system - {SetSupportedCulturesRequest}

Updates the list of supported cultures in the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SetSupportedCulturesRequestCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CulturesApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new SetSupportedCulturesRequest(); // SetSupportedCulturesRequest |  (optional) 

            try
            {
                // Updates the list of supported cultures in the system - {SetSupportedCulturesRequest}
                apiInstance.SetSupportedCulturesRequestCreate(accept, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CulturesApi.SetSupportedCulturesRequestCreate: " + e.Message );
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
 **body** | [**SetSupportedCulturesRequest**](SetSupportedCulturesRequest.md)|  | [optional] 

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
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

