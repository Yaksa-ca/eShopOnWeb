# Yaksa.OrckestraCommerce.Client.Api.MarketingApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketingSettingsRequestsettingsGet**](MarketingApi.md#getmarketingsettingsrequestsettingsget) | **GET** /marketing/settings | Get the marketing application settings - {GetMarketingSettingsRequest}
[**UpdateMarketingSettingsRequestsettingsCreate**](MarketingApi.md#updatemarketingsettingsrequestsettingscreate) | **PUT** /marketing/settings | Update the marketing application settings - {UpdateMarketingSettingsRequest}


<a name="getmarketingsettingsrequestsettingsget"></a>
# **GetMarketingSettingsRequestsettingsGet**
> Settings GetMarketingSettingsRequestsettingsGet (string accept)

Get the marketing application settings - {GetMarketingSettingsRequest}

Get the marketing application settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMarketingSettingsRequestsettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MarketingApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Get the marketing application settings - {GetMarketingSettingsRequest}
                Settings result = apiInstance.GetMarketingSettingsRequestsettingsGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingApi.GetMarketingSettingsRequestsettingsGet: " + e.Message );
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

[**Settings**](Settings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemarketingsettingsrequestsettingscreate"></a>
# **UpdateMarketingSettingsRequestsettingsCreate**
> Settings UpdateMarketingSettingsRequestsettingsCreate (string accept, UpdateMarketingSettingsRequest body = null)

Update the marketing application settings - {UpdateMarketingSettingsRequest}

Update the marketing application settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateMarketingSettingsRequestsettingsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MarketingApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new UpdateMarketingSettingsRequest(); // UpdateMarketingSettingsRequest |  (optional) 

            try
            {
                // Update the marketing application settings - {UpdateMarketingSettingsRequest}
                Settings result = apiInstance.UpdateMarketingSettingsRequestsettingsCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingApi.UpdateMarketingSettingsRequestsettingsCreate: " + e.Message );
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
 **body** | [**UpdateMarketingSettingsRequest**](UpdateMarketingSettingsRequest.md)|  | [optional] 

### Return type

[**Settings**](Settings.md)

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

