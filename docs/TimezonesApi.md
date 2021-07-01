# Yaksa.OrckestraCommerce.Client.Api.TimezonesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindUtcOffsetForTimeZoneRequestconvertPost**](TimezonesApi.md#findutcoffsetfortimezonerequestconvertpost) | **POST** /timezones/convert | Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest}
[**GetTimeZonesRequestGet**](TimezonesApi.md#gettimezonesrequestget) | **GET** /timezones | Retrieve a list of all time zones - {GetTimeZonesRequest}


<a name="findutcoffsetfortimezonerequestconvertpost"></a>
# **FindUtcOffsetForTimeZoneRequestconvertPost**
> UtcOffsetForTimeZone FindUtcOffsetForTimeZoneRequestconvertPost (string accept, FindUtcOffsetForTimeZoneRequest body = null)

Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest}

Convert a UTC datetime to a specific TimeZone datetime

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindUtcOffsetForTimeZoneRequestconvertPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TimezonesApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new FindUtcOffsetForTimeZoneRequest(); // FindUtcOffsetForTimeZoneRequest |  (optional) 

            try
            {
                // Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest}
                UtcOffsetForTimeZone result = apiInstance.FindUtcOffsetForTimeZoneRequestconvertPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimezonesApi.FindUtcOffsetForTimeZoneRequestconvertPost: " + e.Message );
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
 **body** | [**FindUtcOffsetForTimeZoneRequest**](FindUtcOffsetForTimeZoneRequest.md)|  | [optional] 

### Return type

[**UtcOffsetForTimeZone**](UtcOffsetForTimeZone.md)

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

<a name="gettimezonesrequestget"></a>
# **GetTimeZonesRequestGet**
> List&lt;TimeZone&gt; GetTimeZonesRequestGet (string accept)

Retrieve a list of all time zones - {GetTimeZonesRequest}

Retrieve a list of all time zones

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTimeZonesRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TimezonesApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve a list of all time zones - {GetTimeZonesRequest}
                List<TimeZone> result = apiInstance.GetTimeZonesRequestGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimezonesApi.GetTimeZonesRequestGet: " + e.Message );
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

[**List&lt;TimeZone&gt;**](TimeZone.md)

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

