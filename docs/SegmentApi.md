# Yaksa.OrckestraCommerce.Client.Api.SegmentApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSegmentRequestPost**](SegmentApi.md#createsegmentrequestpost) | **POST** /segment | Create a segment - {CreateSegmentRequest}
[**UpdateSegmentRequestCreate**](SegmentApi.md#updatesegmentrequestcreate) | **PUT** /segment | Update a segment - {UpdateSegmentRequest}


<a name="createsegmentrequestpost"></a>
# **CreateSegmentRequestPost**
> Segment CreateSegmentRequestPost (string accept, CreateSegmentRequest body = null)

Create a segment - {CreateSegmentRequest}

Create a segment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateSegmentRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SegmentApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new CreateSegmentRequest(); // CreateSegmentRequest |  (optional) 

            try
            {
                // Create a segment - {CreateSegmentRequest}
                Segment result = apiInstance.CreateSegmentRequestPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentApi.CreateSegmentRequestPost: " + e.Message );
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
 **body** | [**CreateSegmentRequest**](CreateSegmentRequest.md)|  | [optional] 

### Return type

[**Segment**](Segment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesegmentrequestcreate"></a>
# **UpdateSegmentRequestCreate**
> Segment UpdateSegmentRequestCreate (string accept, UpdateSegmentRequest body = null)

Update a segment - {UpdateSegmentRequest}

Update a segment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateSegmentRequestCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SegmentApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new UpdateSegmentRequest(); // UpdateSegmentRequest |  (optional) 

            try
            {
                // Update a segment - {UpdateSegmentRequest}
                Segment result = apiInstance.UpdateSegmentRequestCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentApi.UpdateSegmentRequestCreate: " + e.Message );
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
 **body** | [**UpdateSegmentRequest**](UpdateSegmentRequest.md)|  | [optional] 

### Return type

[**Segment**](Segment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

