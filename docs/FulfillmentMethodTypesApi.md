# Yaksa.OrckestraCommerce.Client.Api.FulfillmentMethodTypesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet**](FulfillmentMethodTypesApi.md#getfulfillmentmethodtypesbyfulfillmentlocationrequestscopeidfulfillmentlocationidget) | **GET** /fulfillmentMethodTypes/{ScopeId}/{FulfillmentLocationId} | Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest}
[**GetFulfillmentMethodTypesByScopeRequestScopeIdGet**](FulfillmentMethodTypesApi.md#getfulfillmentmethodtypesbyscoperequestscopeidget) | **GET** /fulfillmentMethodTypes/{ScopeId} | Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest}


<a name="getfulfillmentmethodtypesbyfulfillmentlocationrequestscopeidfulfillmentlocationidget"></a>
# **GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet**
> List&lt;string&gt; GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet (string accept, string scopeId, string fulfillmentLocationId)

Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest}

Retrieve the fulfillment method types supported by a specific fulfillment location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentMethodTypesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.

            try
            {
                // Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest}
                List<string> result = apiInstance.GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet(accept, scopeId, fulfillmentLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentMethodTypesApi.GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 

### Return type

**List<string>**

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

<a name="getfulfillmentmethodtypesbyscoperequestscopeidget"></a>
# **GetFulfillmentMethodTypesByScopeRequestScopeIdGet**
> List&lt;string&gt; GetFulfillmentMethodTypesByScopeRequestScopeIdGet (string accept, string scopeId)

Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest}

Retrieve the Fulfillment method types supported by the locations of a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentMethodTypesByScopeRequestScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentMethodTypesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest}
                List<string> result = apiInstance.GetFulfillmentMethodTypesByScopeRequestScopeIdGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentMethodTypesApi.GetFulfillmentMethodTypesByScopeRequestScopeIdGet: " + e.Message );
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

**List<string>**

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

