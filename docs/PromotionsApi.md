# Yaksa.OrckestraCommerce.Client.Api.PromotionsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportCouponCodesRequestPromotionIdcouponsexportPost**](PromotionsApi.md#exportcouponcodesrequestpromotionidcouponsexportpost) | **POST** /promotions/{PromotionId}/coupons/export | Export a promotion&#39;s coupon codes list - {ExportCouponCodesRequest}
[**FindPromoCodesRequestScopeIdPromotionIdpromoCodesPost**](PromotionsApi.md#findpromocodesrequestscopeidpromotionidpromocodespost) | **POST** /promotions/{ScopeId}/{PromotionId}/promoCodes | Retrieve the list of the promotion&#39;s promo codes - {FindPromoCodesRequest}
[**GeneratePromoCodesRequestScopeIdPromotionIdpromoCodesgeneratePost**](PromotionsApi.md#generatepromocodesrequestscopeidpromotionidpromocodesgeneratepost) | **POST** /promotions/{ScopeId}/{PromotionId}/promoCodes/generate | Generate promo codes for the promotion - {GeneratePromoCodesRequest}
[**GetPromoCodesCountRequestScopeIdPromotionIdpromoCodescountGet**](PromotionsApi.md#getpromocodescountrequestscopeidpromotionidpromocodescountget) | **GET** /promotions/{ScopeId}/{PromotionId}/promoCodes/count | Retrieve the number of promo codes associated to a promotion with multiple promo codes - {GetPromoCodesCountRequest}
[**ImportCouponCodesRequestPromotionIdcouponsimportPost**](PromotionsApi.md#importcouponcodesrequestpromotionidcouponsimportpost) | **POST** /promotions/{PromotionId}/coupons/import | Import (insert or update) a promotion&#39;s coupons - {ImportCouponCodesRequest}
[**ValidatePromoCodeRequestScopeIdPromotionIdpromoCodesPromoCodevalidatePost**](PromotionsApi.md#validatepromocoderequestscopeidpromotionidpromocodespromocodevalidatepost) | **POST** /promotions/{ScopeId}/{PromotionId}/promoCodes/{PromoCode}/validate | Validate if the promo code can be created - {ValidatePromoCodeRequest}


<a name="exportcouponcodesrequestpromotionidcouponsexportpost"></a>
# **ExportCouponCodesRequestPromotionIdcouponsexportPost**
> List&lt;string&gt; ExportCouponCodesRequestPromotionIdcouponsexportPost (string accept, string promotionId, ExportCouponCodesRequest body = null)

Export a promotion's coupon codes list - {ExportCouponCodesRequest}

Export a promotion's coupon codes list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportCouponCodesRequestPromotionIdcouponsexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PromotionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var promotionId = promotionId_example;  // string | The promotion id.
            var body = new ExportCouponCodesRequest(); // ExportCouponCodesRequest |  (optional) 

            try
            {
                // Export a promotion's coupon codes list - {ExportCouponCodesRequest}
                List<string> result = apiInstance.ExportCouponCodesRequestPromotionIdcouponsexportPost(accept, promotionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ExportCouponCodesRequestPromotionIdcouponsexportPost: " + e.Message );
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
 **promotionId** | **string**| The promotion id. | 
 **body** | [**ExportCouponCodesRequest**](ExportCouponCodesRequest.md)|  | [optional] 

### Return type

**List<string>**

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

<a name="findpromocodesrequestscopeidpromotionidpromocodespost"></a>
# **FindPromoCodesRequestScopeIdPromotionIdpromoCodesPost**
> FindPromoCodesResponse FindPromoCodesRequestScopeIdPromotionIdpromoCodesPost (string accept, string scopeId, string promotionId, FindPromoCodesRequest body = null)

Retrieve the list of the promotion's promo codes - {FindPromoCodesRequest}

Retrieve the list of the promotion's promo codes. This is a paged result.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindPromoCodesRequestScopeIdPromotionIdpromoCodesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PromotionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var promotionId = promotionId_example;  // string | The id of the promotion.
            var body = new FindPromoCodesRequest(); // FindPromoCodesRequest |  (optional) 

            try
            {
                // Retrieve the list of the promotion's promo codes - {FindPromoCodesRequest}
                FindPromoCodesResponse result = apiInstance.FindPromoCodesRequestScopeIdPromotionIdpromoCodesPost(accept, scopeId, promotionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.FindPromoCodesRequestScopeIdPromotionIdpromoCodesPost: " + e.Message );
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
 **promotionId** | **string**| The id of the promotion. | 
 **body** | [**FindPromoCodesRequest**](FindPromoCodesRequest.md)|  | [optional] 

### Return type

[**FindPromoCodesResponse**](FindPromoCodesResponse.md)

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

<a name="generatepromocodesrequestscopeidpromotionidpromocodesgeneratepost"></a>
# **GeneratePromoCodesRequestScopeIdPromotionIdpromoCodesgeneratePost**
> GeneratePromoCodesResponse GeneratePromoCodesRequestScopeIdPromotionIdpromoCodesgeneratePost (string accept, string scopeId, string promotionId, GeneratePromoCodesRequest body = null)

Generate promo codes for the promotion - {GeneratePromoCodesRequest}

Generate promo codes for the promotion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GeneratePromoCodesRequestScopeIdPromotionIdpromoCodesgeneratePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PromotionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var promotionId = promotionId_example;  // string | The id of the promotion.
            var body = new GeneratePromoCodesRequest(); // GeneratePromoCodesRequest |  (optional) 

            try
            {
                // Generate promo codes for the promotion - {GeneratePromoCodesRequest}
                GeneratePromoCodesResponse result = apiInstance.GeneratePromoCodesRequestScopeIdPromotionIdpromoCodesgeneratePost(accept, scopeId, promotionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.GeneratePromoCodesRequestScopeIdPromotionIdpromoCodesgeneratePost: " + e.Message );
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
 **promotionId** | **string**| The id of the promotion. | 
 **body** | [**GeneratePromoCodesRequest**](GeneratePromoCodesRequest.md)|  | [optional] 

### Return type

[**GeneratePromoCodesResponse**](GeneratePromoCodesResponse.md)

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

<a name="getpromocodescountrequestscopeidpromotionidpromocodescountget"></a>
# **GetPromoCodesCountRequestScopeIdPromotionIdpromoCodescountGet**
> GetPromoCodesCountResponse GetPromoCodesCountRequestScopeIdPromotionIdpromoCodescountGet (string accept, string scopeId, string promotionId)

Retrieve the number of promo codes associated to a promotion with multiple promo codes - {GetPromoCodesCountRequest}

Retrieve the number of promo codes associated to a promotion with multiple promo codes, return 0 if the promo code mode is different from Multiple.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPromoCodesCountRequestScopeIdPromotionIdpromoCodescountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PromotionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var promotionId = promotionId_example;  // string | The id of the promotion.

            try
            {
                // Retrieve the number of promo codes associated to a promotion with multiple promo codes - {GetPromoCodesCountRequest}
                GetPromoCodesCountResponse result = apiInstance.GetPromoCodesCountRequestScopeIdPromotionIdpromoCodescountGet(accept, scopeId, promotionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetPromoCodesCountRequestScopeIdPromotionIdpromoCodescountGet: " + e.Message );
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
 **promotionId** | **string**| The id of the promotion. | 

### Return type

[**GetPromoCodesCountResponse**](GetPromoCodesCountResponse.md)

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

<a name="importcouponcodesrequestpromotionidcouponsimportpost"></a>
# **ImportCouponCodesRequestPromotionIdcouponsimportPost**
> TaskInfo ImportCouponCodesRequestPromotionIdcouponsimportPost (string accept, string promotionId, ImportCouponCodesRequest body = null)

Import (insert or update) a promotion's coupons - {ImportCouponCodesRequest}

Import (insert or update) a promotion's coupons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportCouponCodesRequestPromotionIdcouponsimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PromotionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var promotionId = promotionId_example;  // string | The promotion id.
            var body = new ImportCouponCodesRequest(); // ImportCouponCodesRequest |  (optional) 

            try
            {
                // Import (insert or update) a promotion's coupons - {ImportCouponCodesRequest}
                TaskInfo result = apiInstance.ImportCouponCodesRequestPromotionIdcouponsimportPost(accept, promotionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ImportCouponCodesRequestPromotionIdcouponsimportPost: " + e.Message );
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
 **promotionId** | **string**| The promotion id. | 
 **body** | [**ImportCouponCodesRequest**](ImportCouponCodesRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="validatepromocoderequestscopeidpromotionidpromocodespromocodevalidatepost"></a>
# **ValidatePromoCodeRequestScopeIdPromotionIdpromoCodesPromoCodevalidatePost**
> ValidationResult ValidatePromoCodeRequestScopeIdPromotionIdpromoCodesPromoCodevalidatePost (string accept, string scopeId, string promotionId, string promoCode, Object body = null)

Validate if the promo code can be created - {ValidatePromoCodeRequest}

Validate if the promo code can be created. Returns true is the code is not created yet in the system, or created but associated to the specified promotion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ValidatePromoCodeRequestScopeIdPromotionIdpromoCodesPromoCodevalidatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PromotionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var promotionId = promotionId_example;  // string | The id of the promotion.
            var promoCode = promoCode_example;  // string | The promo code to validate
            var body = ;  // Object |  (optional) 

            try
            {
                // Validate if the promo code can be created - {ValidatePromoCodeRequest}
                ValidationResult result = apiInstance.ValidatePromoCodeRequestScopeIdPromotionIdpromoCodesPromoCodevalidatePost(accept, scopeId, promotionId, promoCode, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ValidatePromoCodeRequestScopeIdPromotionIdpromoCodesPromoCodevalidatePost: " + e.Message );
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
 **promotionId** | **string**| The id of the promotion. | 
 **promoCode** | **string**| The promo code to validate | 
 **body** | **Object**|  | [optional] 

### Return type

[**ValidationResult**](ValidationResult.md)

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

