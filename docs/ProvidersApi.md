# Yaksa.OrckestraCommerce.Client.Api.ProvidersApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateFulfillmentProviderRequestScopeIdfulfillmentCreate**](ProvidersApi.md#createorupdatefulfillmentproviderrequestscopeidfulfillmentcreate) | **PUT** /providers/{ScopeId}/fulfillment | Create or update a fulfillment provider - {CreateOrUpdateFulfillmentProviderRequest}
[**DeleteFulfillmentProviderRequestScopeIdfulfillmentIdDelete**](ProvidersApi.md#deletefulfillmentproviderrequestscopeidfulfillmentiddelete) | **DELETE** /providers/{ScopeId}/fulfillment/{Id} | Delete a fulfillment provider - {DeleteFulfillmentProviderRequest}
[**GetCarrierProvidersRequestScopeIdcarrierGet**](ProvidersApi.md#getcarrierprovidersrequestscopeidcarrierget) | **GET** /providers/{ScopeId}/carrier | Get the carrier providers information - {GetCarrierProvidersRequest}
[**GetFulfillmentProvidersMetadataRequestfulfillmentmetadataGet**](ProvidersApi.md#getfulfillmentprovidersmetadatarequestfulfillmentmetadataget) | **GET** /providers/fulfillment/metadata | Get the fulfillment providers information - {GetFulfillmentProvidersMetadataRequest}
[**GetFulfillmentProvidersRequestScopeIdfulfillmentGet**](ProvidersApi.md#getfulfillmentprovidersrequestscopeidfulfillmentget) | **GET** /providers/{ScopeId}/fulfillment | Get the fulfillment providers information - {GetFulfillmentProvidersRequest}
[**GetPaymentProvidersRequestScopeIdpaymentGet**](ProvidersApi.md#getpaymentprovidersrequestscopeidpaymentget) | **GET** /providers/{ScopeId}/payment | Get the payment providers information - {GetPaymentProvidersRequest}
[**GetProvidersRequestScopeIdtypesGet**](ProvidersApi.md#getprovidersrequestscopeidtypesget) | **GET** /providers/{ScopeId}/types | Retrieve all providers configured for the given scope - {GetProvidersRequest}
[**ValidateProviderSettingsRequestvalidateProviderSettingsGet**](ProvidersApi.md#validateprovidersettingsrequestvalidateprovidersettingsget) | **GET** /providers/validateProviderSettings | Validate the settings of a provider in the system - {ValidateProviderSettingsRequest}


<a name="createorupdatefulfillmentproviderrequestscopeidfulfillmentcreate"></a>
# **CreateOrUpdateFulfillmentProviderRequestScopeIdfulfillmentCreate**
> FulfillmentProviderInfo CreateOrUpdateFulfillmentProviderRequestScopeIdfulfillmentCreate (string accept, string scopeId, CreateOrUpdateFulfillmentProviderRequest body = null)

Create or update a fulfillment provider - {CreateOrUpdateFulfillmentProviderRequest}

Create or update a fulfillment provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrUpdateFulfillmentProviderRequestScopeIdfulfillmentCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateOrUpdateFulfillmentProviderRequest(); // CreateOrUpdateFulfillmentProviderRequest |  (optional) 

            try
            {
                // Create or update a fulfillment provider - {CreateOrUpdateFulfillmentProviderRequest}
                FulfillmentProviderInfo result = apiInstance.CreateOrUpdateFulfillmentProviderRequestScopeIdfulfillmentCreate(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.CreateOrUpdateFulfillmentProviderRequestScopeIdfulfillmentCreate: " + e.Message );
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
 **body** | [**CreateOrUpdateFulfillmentProviderRequest**](CreateOrUpdateFulfillmentProviderRequest.md)|  | [optional] 

### Return type

[**FulfillmentProviderInfo**](FulfillmentProviderInfo.md)

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

<a name="deletefulfillmentproviderrequestscopeidfulfillmentiddelete"></a>
# **DeleteFulfillmentProviderRequestScopeIdfulfillmentIdDelete**
> void DeleteFulfillmentProviderRequestScopeIdfulfillmentIdDelete (string accept, string scopeId, string id)

Delete a fulfillment provider - {DeleteFulfillmentProviderRequest}

Delete a fulfillment provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentProviderRequestScopeIdfulfillmentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | the unique identifier for the EntityTypeDefinition

            try
            {
                // Delete a fulfillment provider - {DeleteFulfillmentProviderRequest}
                apiInstance.DeleteFulfillmentProviderRequestScopeIdfulfillmentIdDelete(accept, scopeId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.DeleteFulfillmentProviderRequestScopeIdfulfillmentIdDelete: " + e.Message );
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
 **id** | **string**| the unique identifier for the EntityTypeDefinition | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcarrierprovidersrequestscopeidcarrierget"></a>
# **GetCarrierProvidersRequestScopeIdcarrierGet**
> FulfillmentCarrierProviderInfos GetCarrierProvidersRequestScopeIdcarrierGet (string accept, string scopeId, bool? includeParentScopes = null)

Get the carrier providers information - {GetCarrierProvidersRequest}

Get the carrier providers information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCarrierProvidersRequestScopeIdcarrierGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var includeParentScopes = true;  // bool? | Determines whether parent scopes are included. (optional) 

            try
            {
                // Get the carrier providers information - {GetCarrierProvidersRequest}
                FulfillmentCarrierProviderInfos result = apiInstance.GetCarrierProvidersRequestScopeIdcarrierGet(accept, scopeId, includeParentScopes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetCarrierProvidersRequestScopeIdcarrierGet: " + e.Message );
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
 **includeParentScopes** | **bool?**| Determines whether parent scopes are included. | [optional] 

### Return type

[**FulfillmentCarrierProviderInfos**](FulfillmentCarrierProviderInfos.md)

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

<a name="getfulfillmentprovidersmetadatarequestfulfillmentmetadataget"></a>
# **GetFulfillmentProvidersMetadataRequestfulfillmentmetadataGet**
> FulfillmentProvidersMetadata GetFulfillmentProvidersMetadataRequestfulfillmentmetadataGet (string accept)

Get the fulfillment providers information - {GetFulfillmentProvidersMetadataRequest}

Get the fulfillment providers information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentProvidersMetadataRequestfulfillmentmetadataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Get the fulfillment providers information - {GetFulfillmentProvidersMetadataRequest}
                FulfillmentProvidersMetadata result = apiInstance.GetFulfillmentProvidersMetadataRequestfulfillmentmetadataGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetFulfillmentProvidersMetadataRequestfulfillmentmetadataGet: " + e.Message );
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

[**FulfillmentProvidersMetadata**](FulfillmentProvidersMetadata.md)

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

<a name="getfulfillmentprovidersrequestscopeidfulfillmentget"></a>
# **GetFulfillmentProvidersRequestScopeIdfulfillmentGet**
> FulfillmentProviderInfos GetFulfillmentProvidersRequestScopeIdfulfillmentGet (string accept, string scopeId, bool? includeParentScopes = null)

Get the fulfillment providers information - {GetFulfillmentProvidersRequest}

Get the fulfillment providers information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentProvidersRequestScopeIdfulfillmentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var includeParentScopes = true;  // bool? | Determines whether parent scopes are included. (optional) 

            try
            {
                // Get the fulfillment providers information - {GetFulfillmentProvidersRequest}
                FulfillmentProviderInfos result = apiInstance.GetFulfillmentProvidersRequestScopeIdfulfillmentGet(accept, scopeId, includeParentScopes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetFulfillmentProvidersRequestScopeIdfulfillmentGet: " + e.Message );
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
 **includeParentScopes** | **bool?**| Determines whether parent scopes are included. | [optional] 

### Return type

[**FulfillmentProviderInfos**](FulfillmentProviderInfos.md)

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

<a name="getpaymentprovidersrequestscopeidpaymentget"></a>
# **GetPaymentProvidersRequestScopeIdpaymentGet**
> PaymentProviderInfos GetPaymentProvidersRequestScopeIdpaymentGet (string accept, string scopeId)

Get the payment providers information - {GetPaymentProvidersRequest}

Get the payment providers information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPaymentProvidersRequestScopeIdpaymentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Get the payment providers information - {GetPaymentProvidersRequest}
                PaymentProviderInfos result = apiInstance.GetPaymentProvidersRequestScopeIdpaymentGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetPaymentProvidersRequestScopeIdpaymentGet: " + e.Message );
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

[**PaymentProviderInfos**](PaymentProviderInfos.md)

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

<a name="getprovidersrequestscopeidtypesget"></a>
# **GetProvidersRequestScopeIdtypesGet**
> GetProvidersResponse GetProvidersRequestScopeIdtypesGet (string accept, string scopeId, string providerType = null, bool? includeParentScopes = null)

Retrieve all providers configured for the given scope - {GetProvidersRequest}

Retrieve all providers of all different types configured for the given scope or retreive all providers of a specific type for a given scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProvidersRequestScopeIdtypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var providerType = providerType_example;  // string | Type of this provider: ['Undefined' or 'StoreLocator' or 'Geolocation' or 'PrintOrder' or 'PrintShipment' or 'OrderProcessing' or 'Shipping' or 'Payment' or 'Tax' or 'Rounding' or 'TargetingContext' or 'OrderNumberGenerator' or 'RmaNumberGenerator' or 'DigitalAssetManagement' or 'DirectoryProvider' or 'MembershipProvider' or 'Inventory' or 'Audit' or 'SlotInstance' or 'PriceCalculator' or 'SearchPriceCalculator' or 'Search' or 'BlobStorage' or 'ShipmentProcessingDate' or 'ProductImportParser' or 'DataExchange' or 'ProductDataExchangeImport' or 'ProductDataExchangeExport' or 'ProductPriceDataExchangeImport' or 'ProductPriceDataExchangeExport' or 'MailProvider' or 'NotificationProvider' or 'OrderImportParser' or 'PromotionLineItemValidator' or 'PickingMissionNumberGenerator' or 'FulfillmentCarrier' or 'FulfillmentRouting']  // Note: 'Undefined' retrieves all providers. (optional) 
            var includeParentScopes = true;  // bool? | Determine if parent scopes are considered when retrieving providers. (optional) 

            try
            {
                // Retrieve all providers configured for the given scope - {GetProvidersRequest}
                GetProvidersResponse result = apiInstance.GetProvidersRequestScopeIdtypesGet(accept, scopeId, providerType, includeParentScopes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProvidersRequestScopeIdtypesGet: " + e.Message );
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
 **providerType** | **string**| Type of this provider: [&#39;Undefined&#39; or &#39;StoreLocator&#39; or &#39;Geolocation&#39; or &#39;PrintOrder&#39; or &#39;PrintShipment&#39; or &#39;OrderProcessing&#39; or &#39;Shipping&#39; or &#39;Payment&#39; or &#39;Tax&#39; or &#39;Rounding&#39; or &#39;TargetingContext&#39; or &#39;OrderNumberGenerator&#39; or &#39;RmaNumberGenerator&#39; or &#39;DigitalAssetManagement&#39; or &#39;DirectoryProvider&#39; or &#39;MembershipProvider&#39; or &#39;Inventory&#39; or &#39;Audit&#39; or &#39;SlotInstance&#39; or &#39;PriceCalculator&#39; or &#39;SearchPriceCalculator&#39; or &#39;Search&#39; or &#39;BlobStorage&#39; or &#39;ShipmentProcessingDate&#39; or &#39;ProductImportParser&#39; or &#39;DataExchange&#39; or &#39;ProductDataExchangeImport&#39; or &#39;ProductDataExchangeExport&#39; or &#39;ProductPriceDataExchangeImport&#39; or &#39;ProductPriceDataExchangeExport&#39; or &#39;MailProvider&#39; or &#39;NotificationProvider&#39; or &#39;OrderImportParser&#39; or &#39;PromotionLineItemValidator&#39; or &#39;PickingMissionNumberGenerator&#39; or &#39;FulfillmentCarrier&#39; or &#39;FulfillmentRouting&#39;]  // Note: &#39;Undefined&#39; retrieves all providers. | [optional] 
 **includeParentScopes** | **bool?**| Determine if parent scopes are considered when retrieving providers. | [optional] 

### Return type

[**GetProvidersResponse**](GetProvidersResponse.md)

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

<a name="validateprovidersettingsrequestvalidateprovidersettingsget"></a>
# **ValidateProviderSettingsRequestvalidateProviderSettingsGet**
> List&lt;ValidationResult&gt; ValidateProviderSettingsRequestvalidateProviderSettingsGet (string accept, string providerId = null, string providerType = null)

Validate the settings of a provider in the system - {ValidateProviderSettingsRequest}

Validate the settings of a provider in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ValidateProviderSettingsRequestvalidateProviderSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProvidersApi(config);
            var accept = accept_example;  // string | Accept Header
            var providerId = providerId_example;  // string | the unique identifier of the provider to validate. (optional) 
            var providerType = providerType_example;  // string | the type of the provider to validate. (optional) 

            try
            {
                // Validate the settings of a provider in the system - {ValidateProviderSettingsRequest}
                List<ValidationResult> result = apiInstance.ValidateProviderSettingsRequestvalidateProviderSettingsGet(accept, providerId, providerType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ValidateProviderSettingsRequestvalidateProviderSettingsGet: " + e.Message );
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
 **providerId** | **string**| the unique identifier of the provider to validate. | [optional] 
 **providerType** | **string**| the type of the provider to validate. | [optional] 

### Return type

[**List&lt;ValidationResult&gt;**](ValidationResult.md)

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

