# Yaksa.OrckestraCommerce.Client.Api.FulfillmentMethodsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePost**](FulfillmentMethodsApi.md#findcalculatedfulfillmentmethodsrequestscopeidcustomeridcartnamepost) | **POST** /fulfillmentMethods/{ScopeId}/{CustomerId}/{CartName} | Retrieve the list of all the potential FulfillmentMethod of a given customer Cart - {FindCalculatedFulfillmentMethodsRequest}
[**GetAvailableFulfillmentMethodsByScopeRequestScopeIdGet**](FulfillmentMethodsApi.md#getavailablefulfillmentmethodsbyscoperequestscopeidget) | **GET** /fulfillmentMethods/{ScopeId}/ | Gets the list of all the available fulfillment methods for a given scope - {GetAvailableFulfillmentMethodsByScopeRequest}


<a name="findcalculatedfulfillmentmethodsrequestscopeidcustomeridcartnamepost"></a>
# **FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePost**
> List&lt;FulfillmentMethod&gt; FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePost (string accept, string scopeId, string customerId, string cartName, FindCalculatedFulfillmentMethodsRequest body = null)

Retrieve the list of all the potential FulfillmentMethod of a given customer Cart - {FindCalculatedFulfillmentMethodsRequest}

Retrieve the list of all the potential FulfillmentMethod of a given customer Cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentMethodsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | the unique identifier of the Customer owning the cart.
            var cartName = cartName_example;  // string | The name of the cart to retrieve.
            var body = new FindCalculatedFulfillmentMethodsRequest(); // FindCalculatedFulfillmentMethodsRequest |  (optional) 

            try
            {
                // Retrieve the list of all the potential FulfillmentMethod of a given customer Cart - {FindCalculatedFulfillmentMethodsRequest}
                List<FulfillmentMethod> result = apiInstance.FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePost(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentMethodsApi.FindCalculatedFulfillmentMethodsRequestScopeIdCustomerIdCartNamePost: " + e.Message );
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
 **customerId** | **string**| the unique identifier of the Customer owning the cart. | 
 **cartName** | **string**| The name of the cart to retrieve. | 
 **body** | [**FindCalculatedFulfillmentMethodsRequest**](FindCalculatedFulfillmentMethodsRequest.md)|  | [optional] 

### Return type

[**List&lt;FulfillmentMethod&gt;**](FulfillmentMethod.md)

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

<a name="getavailablefulfillmentmethodsbyscoperequestscopeidget"></a>
# **GetAvailableFulfillmentMethodsByScopeRequestScopeIdGet**
> GetFulfillmentMethodsResponse GetAvailableFulfillmentMethodsByScopeRequestScopeIdGet (string accept, string scopeId)

Gets the list of all the available fulfillment methods for a given scope - {GetAvailableFulfillmentMethodsByScopeRequest}

Gets the list of all the available fulfillment methods for a given scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAvailableFulfillmentMethodsByScopeRequestScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentMethodsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Gets the list of all the available fulfillment methods for a given scope - {GetAvailableFulfillmentMethodsByScopeRequest}
                GetFulfillmentMethodsResponse result = apiInstance.GetAvailableFulfillmentMethodsByScopeRequestScopeIdGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentMethodsApi.GetAvailableFulfillmentMethodsByScopeRequestScopeIdGet: " + e.Message );
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

### Return type

[**GetFulfillmentMethodsResponse**](GetFulfillmentMethodsResponse.md)

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

