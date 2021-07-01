# Yaksa.OrckestraCommerce.Client.Api.OrderdraftApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGet**](OrderdraftApi.md#getorderdraftpaymentrequestscopeiddraftidpaymentpaymentidget) | **GET** /orderdraft/{ScopeId}/{DraftId}/payment/{PaymentId} | Retrieve an order draft - {GetOrderDraftPaymentRequest}
[**UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPost**](OrderdraftApi.md#updateorderdraftpaymentrequestscopeiddraftidpaymentpaymentidpost) | **POST** /orderdraft/{ScopeId}/{DraftId}/payment/{PaymentId} | Update an order draft payment - {UpdateOrderDraftPaymentRequest}


<a name="getorderdraftpaymentrequestscopeiddraftidpaymentpaymentidget"></a>
# **GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGet**
> Payment GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGet (string accept, string scopeId, string draftId, string paymentId)

Retrieve an order draft - {GetOrderDraftPaymentRequest}

Retrieve an order draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrderdraftApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var draftId = draftId_example;  // string | The id of the draft order for the request.
            var paymentId = paymentId_example;  // string | The of payment associate to the cart.

            try
            {
                // Retrieve an order draft - {GetOrderDraftPaymentRequest}
                Payment result = apiInstance.GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGet(accept, scopeId, draftId, paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderdraftApi.GetOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdGet: " + e.Message );
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
 **draftId** | **string**| The id of the draft order for the request. | 
 **paymentId** | **string**| The of payment associate to the cart. | 

### Return type

[**Payment**](Payment.md)

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

<a name="updateorderdraftpaymentrequestscopeiddraftidpaymentpaymentidpost"></a>
# **UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPost**
> Payment UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPost (string accept, string scopeId, string draftId, string paymentId, UpdateOrderDraftPaymentRequest body = null)

Update an order draft payment - {UpdateOrderDraftPaymentRequest}

Update an order draft payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrderdraftApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var draftId = draftId_example;  // string | The id of the draft order for the request.
            var paymentId = paymentId_example;  // string | The of payment associate to the cart.
            var body = new UpdateOrderDraftPaymentRequest(); // UpdateOrderDraftPaymentRequest |  (optional) 

            try
            {
                // Update an order draft payment - {UpdateOrderDraftPaymentRequest}
                Payment result = apiInstance.UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPost(accept, scopeId, draftId, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderdraftApi.UpdateOrderDraftPaymentRequestScopeIdDraftIdpaymentPaymentIdPost: " + e.Message );
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
 **draftId** | **string**| The id of the draft order for the request. | 
 **paymentId** | **string**| The of payment associate to the cart. | 
 **body** | [**UpdateOrderDraftPaymentRequest**](UpdateOrderDraftPaymentRequest.md)|  | [optional] 

### Return type

[**Payment**](Payment.md)

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

