# Yaksa.OrckestraCommerce.Client.Api.SegmentsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateSegmentRequestPost**](SegmentsApi.md#createorupdatesegmentrequestpost) | **POST** /segments | Create or update a segment based on name - {CreateOrUpdateSegmentRequest}
[**DeleteSegmentRequestSegmentIdDelete**](SegmentsApi.md#deletesegmentrequestsegmentiddelete) | **DELETE** /segments/{SegmentId} | Delete a segment - {DeleteSegmentRequest}
[**FindSegmentsRequestfindPost**](SegmentsApi.md#findsegmentsrequestfindpost) | **POST** /segments/find | Search for segments matching the parameters - {FindSegmentsRequest}
[**GetSegmentRequestSegmentIdGet**](SegmentsApi.md#getsegmentrequestsegmentidget) | **GET** /segments/{SegmentId} | Retrieve a segment - {GetSegmentRequest}
[**GetSegmentsRequestGet**](SegmentsApi.md#getsegmentsrequestget) | **GET** /segments | Retrieve all segments - {GetSegmentsRequest}


<a name="createorupdatesegmentrequestpost"></a>
# **CreateOrUpdateSegmentRequestPost**
> Segment CreateOrUpdateSegmentRequestPost (string accept, CreateOrUpdateSegmentRequest body = null)

Create or update a segment based on name - {CreateOrUpdateSegmentRequest}

Create or update a segment based on name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrUpdateSegmentRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SegmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new CreateOrUpdateSegmentRequest(); // CreateOrUpdateSegmentRequest |  (optional) 

            try
            {
                // Create or update a segment based on name - {CreateOrUpdateSegmentRequest}
                Segment result = apiInstance.CreateOrUpdateSegmentRequestPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.CreateOrUpdateSegmentRequestPost: " + e.Message );
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
 **body** | [**CreateOrUpdateSegmentRequest**](CreateOrUpdateSegmentRequest.md)|  | [optional] 

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

<a name="deletesegmentrequestsegmentiddelete"></a>
# **DeleteSegmentRequestSegmentIdDelete**
> DeleteSegmentResult DeleteSegmentRequestSegmentIdDelete (string accept, string segmentId)

Delete a segment - {DeleteSegmentRequest}

Delete a segment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteSegmentRequestSegmentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SegmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var segmentId = segmentId_example;  // string | The id of the segment to delete.

            try
            {
                // Delete a segment - {DeleteSegmentRequest}
                DeleteSegmentResult result = apiInstance.DeleteSegmentRequestSegmentIdDelete(accept, segmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.DeleteSegmentRequestSegmentIdDelete: " + e.Message );
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
 **segmentId** | **string**| The id of the segment to delete. | 

### Return type

[**DeleteSegmentResult**](DeleteSegmentResult.md)

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
| **404** | Requested segment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsegmentsrequestfindpost"></a>
# **FindSegmentsRequestfindPost**
> SegmentQueryResult FindSegmentsRequestfindPost (string accept, FindSegmentsRequest body = null)

Search for segments matching the parameters - {FindSegmentsRequest}

Search for segments matching the parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindSegmentsRequestfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SegmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new FindSegmentsRequest(); // FindSegmentsRequest |  (optional) 

            try
            {
                // Search for segments matching the parameters - {FindSegmentsRequest}
                SegmentQueryResult result = apiInstance.FindSegmentsRequestfindPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.FindSegmentsRequestfindPost: " + e.Message );
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
 **body** | [**FindSegmentsRequest**](FindSegmentsRequest.md)|  | [optional] 

### Return type

[**SegmentQueryResult**](SegmentQueryResult.md)

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
| **404** | Requested segment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsegmentrequestsegmentidget"></a>
# **GetSegmentRequestSegmentIdGet**
> Segment GetSegmentRequestSegmentIdGet (string accept, string segmentId, bool? validateTargeting = null)

Retrieve a segment - {GetSegmentRequest}

Retrieve a segment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetSegmentRequestSegmentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SegmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var segmentId = segmentId_example;  // string | The id of the segment to retrieve.
            var validateTargeting = true;  // bool? | Indicates whether the targeting conditions in the segment should be validated (optional) 

            try
            {
                // Retrieve a segment - {GetSegmentRequest}
                Segment result = apiInstance.GetSegmentRequestSegmentIdGet(accept, segmentId, validateTargeting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetSegmentRequestSegmentIdGet: " + e.Message );
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
 **segmentId** | **string**| The id of the segment to retrieve. | 
 **validateTargeting** | **bool?**| Indicates whether the targeting conditions in the segment should be validated | [optional] 

### Return type

[**Segment**](Segment.md)

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
| **404** | Requested segment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsegmentsrequestget"></a>
# **GetSegmentsRequestGet**
> List&lt;Segment&gt; GetSegmentsRequestGet (string accept, bool? validateTargeting = null, int? startingIndex = null, int? maximumItems = null)

Retrieve all segments - {GetSegmentsRequest}

Retrieve all segments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetSegmentsRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SegmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var validateTargeting = true;  // bool? | Indicates whether the targeting conditions in the segment should be validated (optional) 
            var startingIndex = 56;  // int? | The starting index. (The offset of the first record when requesting paged data) (optional) 
            var maximumItems = 56;  // int? | The number of items to return. (This is the page size when requesting paged data) (optional) 

            try
            {
                // Retrieve all segments - {GetSegmentsRequest}
                List<Segment> result = apiInstance.GetSegmentsRequestGet(accept, validateTargeting, startingIndex, maximumItems);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetSegmentsRequestGet: " + e.Message );
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
 **validateTargeting** | **bool?**| Indicates whether the targeting conditions in the segment should be validated | [optional] 
 **startingIndex** | **int?**| The starting index. (The offset of the first record when requesting paged data) | [optional] 
 **maximumItems** | **int?**| The number of items to return. (This is the page size when requesting paged data) | [optional] 

### Return type

[**List&lt;Segment&gt;**](Segment.md)

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
| **404** | Requested segment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

