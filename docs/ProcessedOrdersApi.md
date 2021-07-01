# Yaksa.OrckestraCommerce.Client.Api.ProcessedOrdersApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReleaseOrderLockForShipmentRequestScopeIdOrderIdreleaselockPost**](ProcessedOrdersApi.md#releaseorderlockforshipmentrequestscopeidorderidreleaselockpost) | **POST** /processedOrders/{ScopeId}/{OrderId}/releaselock | Release a lock on a given order for a shipment. - {ReleaseOrderLockForShipmentRequest}
[**SaveProcessedOrderRequestScopeIdOrderIdPost**](ProcessedOrdersApi.md#saveprocessedorderrequestscopeidorderidpost) | **POST** /processedOrders/{ScopeId}/{OrderId} | Update an existing order based on the provided Order. - {SaveProcessedOrderRequest}
[**TryAcquireOrderLockForShipmentRequestScopeIdOrderIdlockPost**](ProcessedOrdersApi.md#tryacquireorderlockforshipmentrequestscopeidorderidlockpost) | **POST** /processedOrders/{ScopeId}/{OrderId}/lock | Acquire a lock on a given order for a shipment. - {TryAcquireOrderLockForShipmentRequest}


<a name="releaseorderlockforshipmentrequestscopeidorderidreleaselockpost"></a>
# **ReleaseOrderLockForShipmentRequestScopeIdOrderIdreleaselockPost**
> void ReleaseOrderLockForShipmentRequestScopeIdOrderIdreleaselockPost (string accept, string scopeId, string orderId, ReleaseOrderLockForShipmentRequest body = null)

Release a lock on a given order for a shipment. - {ReleaseOrderLockForShipmentRequest}

Release a lock on a given order for a shipment. This request does not perform validation nor does it process the order using workflows. Warning : Do not use, only for internal usage - in activites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ReleaseOrderLockForShipmentRequestScopeIdOrderIdreleaselockPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProcessedOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | the order id that will get locked.
            var body = new ReleaseOrderLockForShipmentRequest(); // ReleaseOrderLockForShipmentRequest |  (optional) 

            try
            {
                // Release a lock on a given order for a shipment. - {ReleaseOrderLockForShipmentRequest}
                apiInstance.ReleaseOrderLockForShipmentRequestScopeIdOrderIdreleaselockPost(accept, scopeId, orderId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessedOrdersApi.ReleaseOrderLockForShipmentRequestScopeIdOrderIdreleaselockPost: " + e.Message );
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
 **scopeId** | **string**| The id of the requested scope | 
 **orderId** | **string**| the order id that will get locked. | 
 **body** | [**ReleaseOrderLockForShipmentRequest**](ReleaseOrderLockForShipmentRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveprocessedorderrequestscopeidorderidpost"></a>
# **SaveProcessedOrderRequestScopeIdOrderIdPost**
> Order SaveProcessedOrderRequestScopeIdOrderIdPost (string accept, string scopeId, string orderId, SaveProcessedOrderRequest body = null)

Update an existing order based on the provided Order. - {SaveProcessedOrderRequest}

Update an existing order based on the provided Order. This request does not perform validation nor does it process the order using workflows. Warning : Do not use, only for internal usage - in activites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveProcessedOrderRequestScopeIdOrderIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProcessedOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | the unique system idenfitifier for the request.
            var body = new SaveProcessedOrderRequest(); // SaveProcessedOrderRequest |  (optional) 

            try
            {
                // Update an existing order based on the provided Order. - {SaveProcessedOrderRequest}
                Order result = apiInstance.SaveProcessedOrderRequestScopeIdOrderIdPost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessedOrdersApi.SaveProcessedOrderRequestScopeIdOrderIdPost: " + e.Message );
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
 **scopeId** | **string**| The id of the requested scope | 
 **orderId** | **string**| the unique system idenfitifier for the request. | 
 **body** | [**SaveProcessedOrderRequest**](SaveProcessedOrderRequest.md)|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="tryacquireorderlockforshipmentrequestscopeidorderidlockpost"></a>
# **TryAcquireOrderLockForShipmentRequestScopeIdOrderIdlockPost**
> OrderLockInfo TryAcquireOrderLockForShipmentRequestScopeIdOrderIdlockPost (string accept, string scopeId, string orderId, TryAcquireOrderLockForShipmentRequest body = null)

Acquire a lock on a given order for a shipment. - {TryAcquireOrderLockForShipmentRequest}

Acquire a lock on a given order for a shipment. This request does not perform validation nor does it process the order using workflows. Warning : Do not use, only for internal usage - in activities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class TryAcquireOrderLockForShipmentRequestScopeIdOrderIdlockPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProcessedOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | the order id that will get locked.
            var body = new TryAcquireOrderLockForShipmentRequest(); // TryAcquireOrderLockForShipmentRequest |  (optional) 

            try
            {
                // Acquire a lock on a given order for a shipment. - {TryAcquireOrderLockForShipmentRequest}
                OrderLockInfo result = apiInstance.TryAcquireOrderLockForShipmentRequestScopeIdOrderIdlockPost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessedOrdersApi.TryAcquireOrderLockForShipmentRequestScopeIdOrderIdlockPost: " + e.Message );
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
 **scopeId** | **string**| The id of the requested scope | 
 **orderId** | **string**| the order id that will get locked. | 
 **body** | [**TryAcquireOrderLockForShipmentRequest**](TryAcquireOrderLockForShipmentRequest.md)|  | [optional] 

### Return type

[**OrderLockInfo**](OrderLockInfo.md)

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

