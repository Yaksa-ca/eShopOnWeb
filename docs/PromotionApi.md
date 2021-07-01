# Yaksa.OrckestraCommerce.Client.Api.PromotionApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessPromotionEngineRequestenginePost**](PromotionApi.md#processpromotionenginerequestenginepost) | **POST** /promotion/engine/ | Invoke the promotions evaluation of a given Cart - {ProcessPromotionEngineRequest}


<a name="processpromotionenginerequestenginepost"></a>
# **ProcessPromotionEngineRequestenginePost**
> PromotionEngineResult ProcessPromotionEngineRequestenginePost (string accept, ProcessPromotionEngineRequest body = null)

Invoke the promotions evaluation of a given Cart - {ProcessPromotionEngineRequest}

Invoke the promotions evaluation of a given Cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ProcessPromotionEngineRequestenginePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PromotionApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ProcessPromotionEngineRequest(); // ProcessPromotionEngineRequest |  (optional) 

            try
            {
                // Invoke the promotions evaluation of a given Cart - {ProcessPromotionEngineRequest}
                PromotionEngineResult result = apiInstance.ProcessPromotionEngineRequestenginePost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionApi.ProcessPromotionEngineRequestenginePost: " + e.Message );
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
 **body** | [**ProcessPromotionEngineRequest**](ProcessPromotionEngineRequest.md)|  | [optional] 

### Return type

[**PromotionEngineResult**](PromotionEngineResult.md)

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

