# Yaksa.OrckestraCommerce.Client.Api.TokenApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGuestTokenRequestcustomerguestGet**](TokenApi.md#getguesttokenrequestcustomerguestget) | **GET** /token/customer/guest | Retrieve an authentication token for a guest customer to be able to access external tool like the product picker - {GetGuestTokenRequest}
[**GetTokenRequestPost**](TokenApi.md#gettokenrequestpost) | **POST** /token | Retrieve an authentication token to be able to access external tool like the product picker - {GetTokenRequest}


<a name="getguesttokenrequestcustomerguestget"></a>
# **GetGuestTokenRequestcustomerguestGet**
> Token GetGuestTokenRequestcustomerguestGet (string accept, DateTime? expiryDate = null)

Retrieve an authentication token for a guest customer to be able to access external tool like the product picker - {GetGuestTokenRequest}

Retrieve an authentication token for a guest customer to be able to access external tool like the product picker. An encrypted security token to pass to the tool

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetGuestTokenRequestcustomerguestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TokenApi(config);
            var accept = accept_example;  // string | Accept Header
            var expiryDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The expiry date of the token. It must be in the future. (optional) 

            try
            {
                // Retrieve an authentication token for a guest customer to be able to access external tool like the product picker - {GetGuestTokenRequest}
                Token result = apiInstance.GetGuestTokenRequestcustomerguestGet(accept, expiryDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.GetGuestTokenRequestcustomerguestGet: " + e.Message );
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
 **expiryDate** | **DateTime?**| The expiry date of the token. It must be in the future. | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **422** | Validation error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokenrequestpost"></a>
# **GetTokenRequestPost**
> Token GetTokenRequestPost (string accept, GetTokenRequest body = null)

Retrieve an authentication token to be able to access external tool like the product picker - {GetTokenRequest}

Retrieve an authentication token to be able to access external tool like the product picker. An encrypted security token to pass to the tool

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTokenRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TokenApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new GetTokenRequest(); // GetTokenRequest |  (optional) 

            try
            {
                // Retrieve an authentication token to be able to access external tool like the product picker - {GetTokenRequest}
                Token result = apiInstance.GetTokenRequestPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.GetTokenRequestPost: " + e.Message );
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
 **body** | [**GetTokenRequest**](GetTokenRequest.md)|  | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **422** | Validation error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

