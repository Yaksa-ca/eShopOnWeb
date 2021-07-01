# Yaksa.OrckestraCommerce.Client.Api.MonerisCanadaVaultProfileApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPost**](MonerisCanadaVaultProfileApi.md#createcartpaymentvaultprofilerequestcartsscopeidcustomeridcartnamepaymentspaymentidpost) | **POST** /monerisCanadaVaultProfile/carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId} | Create a vault profile for a cart payment - {CreateCartPaymentVaultProfileRequest}
[**CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPost**](MonerisCanadaVaultProfileApi.md#createorderdraftpaymentvaultprofilerequestorderdraftscopeiddraftidpaymentspaymentidpost) | **POST** /monerisCanadaVaultProfile/orderdraft/{ScopeId}/{DraftId}/payments/{PaymentId} | Create a vault profile for a draft order - {CreateOrderDraftPaymentVaultProfileRequest}


<a name="createcartpaymentvaultprofilerequestcartsscopeidcustomeridcartnamepaymentspaymentidpost"></a>
# **CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPost**
> VaultProfileCreationResult CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPost (string accept, string scopeId, string customerId, string cartName, string paymentId, CreateCartPaymentVaultProfileRequest body = null)

Create a vault profile for a cart payment - {CreateCartPaymentVaultProfileRequest}

Create a vault profile for a cart payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MonerisCanadaVaultProfileApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer identifier associated with the cart
            var cartName = cartName_example;  // string | The name of the cart associated with the payment
            var paymentId = paymentId_example;  // string | The id of the payment associated with the draft order
            var body = new CreateCartPaymentVaultProfileRequest(); // CreateCartPaymentVaultProfileRequest |  (optional) 

            try
            {
                // Create a vault profile for a cart payment - {CreateCartPaymentVaultProfileRequest}
                VaultProfileCreationResult result = apiInstance.CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPost(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonerisCanadaVaultProfileApi.CreateCartPaymentVaultProfileRequestcartsScopeIdCustomerIdCartNamepaymentsPaymentIdPost: " + e.Message );
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
 **customerId** | **string**| The customer identifier associated with the cart | 
 **cartName** | **string**| The name of the cart associated with the payment | 
 **paymentId** | **string**| The id of the payment associated with the draft order | 
 **body** | [**CreateCartPaymentVaultProfileRequest**](CreateCartPaymentVaultProfileRequest.md)|  | [optional] 

### Return type

[**VaultProfileCreationResult**](VaultProfileCreationResult.md)

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

<a name="createorderdraftpaymentvaultprofilerequestorderdraftscopeiddraftidpaymentspaymentidpost"></a>
# **CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPost**
> VaultProfileCreationResult CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPost (string accept, string scopeId, string draftId, string paymentId, CreateOrderDraftPaymentVaultProfileRequest body = null)

Create a vault profile for a draft order - {CreateOrderDraftPaymentVaultProfileRequest}

Create a vault profile for a draft order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MonerisCanadaVaultProfileApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var draftId = draftId_example;  // string | The id of the draft order
            var paymentId = paymentId_example;  // string | The id of the payment associated with the draft order
            var body = new CreateOrderDraftPaymentVaultProfileRequest(); // CreateOrderDraftPaymentVaultProfileRequest |  (optional) 

            try
            {
                // Create a vault profile for a draft order - {CreateOrderDraftPaymentVaultProfileRequest}
                VaultProfileCreationResult result = apiInstance.CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPost(accept, scopeId, draftId, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonerisCanadaVaultProfileApi.CreateOrderDraftPaymentVaultProfileRequestorderdraftScopeIdDraftIdpaymentsPaymentIdPost: " + e.Message );
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
 **draftId** | **string**| The id of the draft order | 
 **paymentId** | **string**| The id of the payment associated with the draft order | 
 **body** | [**CreateOrderDraftPaymentVaultProfileRequest**](CreateOrderDraftPaymentVaultProfileRequest.md)|  | [optional] 

### Return type

[**VaultProfileCreationResult**](VaultProfileCreationResult.md)

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

