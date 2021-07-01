# Yaksa.OrckestraCommerce.Client.Api.CouponsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsumeCouponByCodeRequestconsumecodePost**](CouponsApi.md#consumecouponbycoderequestconsumecodepost) | **POST** /coupons/consume/code | Consume a coupon using its code - {ConsumeCouponByCodeRequest}
[**ConsumeCouponRequestconsumePost**](CouponsApi.md#consumecouponrequestconsumepost) | **POST** /coupons/consume | Consume a coupon - {ConsumeCouponRequest}
[**DeleteCouponByCodeRequestdeletecodeDelete**](CouponsApi.md#deletecouponbycoderequestdeletecodedelete) | **DELETE** /coupons/delete/code | Delete a coupon - {DeleteCouponByCodeRequest}
[**GetCouponRequestCouponCodeGet**](CouponsApi.md#getcouponrequestcouponcodeget) | **GET** /coupons/{CouponCode} | Retrieve a coupon using its coupon code - {GetCouponRequest}
[**GetCouponsRequestvalidatesCustomerIdPost**](CouponsApi.md#getcouponsrequestvalidatescustomeridpost) | **POST** /coupons/validates/{CustomerId} | Validates a list of coupons for a customer - {GetCouponsRequest}
[**LiberateCouponRequestliberatePost**](CouponsApi.md#liberatecouponrequestliberatepost) | **POST** /coupons/liberate | Liberates a coupon - {LiberateCouponRequest}


<a name="consumecouponbycoderequestconsumecodepost"></a>
# **ConsumeCouponByCodeRequestconsumecodePost**
> void ConsumeCouponByCodeRequestconsumecodePost (string accept, ConsumeCouponByCodeRequest body = null)

Consume a coupon using its code - {ConsumeCouponByCodeRequest}

Consume a coupon using its code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ConsumeCouponByCodeRequestconsumecodePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CouponsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ConsumeCouponByCodeRequest(); // ConsumeCouponByCodeRequest |  (optional) 

            try
            {
                // Consume a coupon using its code - {ConsumeCouponByCodeRequest}
                apiInstance.ConsumeCouponByCodeRequestconsumecodePost(accept, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.ConsumeCouponByCodeRequestconsumecodePost: " + e.Message );
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
 **body** | [**ConsumeCouponByCodeRequest**](ConsumeCouponByCodeRequest.md)|  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumecouponrequestconsumepost"></a>
# **ConsumeCouponRequestconsumePost**
> void ConsumeCouponRequestconsumePost (string accept, ConsumeCouponRequest body = null)

Consume a coupon - {ConsumeCouponRequest}

Consume a coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ConsumeCouponRequestconsumePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CouponsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ConsumeCouponRequest(); // ConsumeCouponRequest |  (optional) 

            try
            {
                // Consume a coupon - {ConsumeCouponRequest}
                apiInstance.ConsumeCouponRequestconsumePost(accept, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.ConsumeCouponRequestconsumePost: " + e.Message );
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
 **body** | [**ConsumeCouponRequest**](ConsumeCouponRequest.md)|  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponbycoderequestdeletecodedelete"></a>
# **DeleteCouponByCodeRequestdeletecodeDelete**
> DeleteCouponResult DeleteCouponByCodeRequestdeletecodeDelete (string accept, string couponCode = null, bool? force = null)

Delete a coupon - {DeleteCouponByCodeRequest}

Delete a coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteCouponByCodeRequestdeletecodeDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CouponsApi(config);
            var accept = accept_example;  // string | Accept Header
            var couponCode = couponCode_example;  // string | The coupon code. (optional) 
            var force = true;  // bool? | Delete the promo code if it is used in an active promotion and update the promotion. (optional) 

            try
            {
                // Delete a coupon - {DeleteCouponByCodeRequest}
                DeleteCouponResult result = apiInstance.DeleteCouponByCodeRequestdeletecodeDelete(accept, couponCode, force);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.DeleteCouponByCodeRequestdeletecodeDelete: " + e.Message );
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
 **couponCode** | **string**| The coupon code. | [optional] 
 **force** | **bool?**| Delete the promo code if it is used in an active promotion and update the promotion. | [optional] 

### Return type

[**DeleteCouponResult**](DeleteCouponResult.md)

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

<a name="getcouponrequestcouponcodeget"></a>
# **GetCouponRequestCouponCodeGet**
> Coupon GetCouponRequestCouponCodeGet (string accept, string couponCode)

Retrieve a coupon using its coupon code - {GetCouponRequest}

Retrieve a coupon using its coupon code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCouponRequestCouponCodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CouponsApi(config);
            var accept = accept_example;  // string | Accept Header
            var couponCode = couponCode_example;  // string | The coupon code.

            try
            {
                // Retrieve a coupon using its coupon code - {GetCouponRequest}
                Coupon result = apiInstance.GetCouponRequestCouponCodeGet(accept, couponCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.GetCouponRequestCouponCodeGet: " + e.Message );
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
 **couponCode** | **string**| The coupon code. | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | The coupon does not exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponsrequestvalidatescustomeridpost"></a>
# **GetCouponsRequestvalidatesCustomerIdPost**
> List&lt;Coupon&gt; GetCouponsRequestvalidatesCustomerIdPost (string accept, string customerId, GetCouponsRequest body = null)

Validates a list of coupons for a customer - {GetCouponsRequest}

Validates a list of coupon codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCouponsRequestvalidatesCustomerIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CouponsApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer unique identifier
            var body = new GetCouponsRequest(); // GetCouponsRequest |  (optional) 

            try
            {
                // Validates a list of coupons for a customer - {GetCouponsRequest}
                List<Coupon> result = apiInstance.GetCouponsRequestvalidatesCustomerIdPost(accept, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.GetCouponsRequestvalidatesCustomerIdPost: " + e.Message );
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
 **customerId** | **string**| The customer unique identifier | 
 **body** | [**GetCouponsRequest**](GetCouponsRequest.md)|  | [optional] 

### Return type

[**List&lt;Coupon&gt;**](Coupon.md)

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

<a name="liberatecouponrequestliberatepost"></a>
# **LiberateCouponRequestliberatePost**
> void LiberateCouponRequestliberatePost (string accept, LiberateCouponRequest body = null)

Liberates a coupon - {LiberateCouponRequest}

Liberates a coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class LiberateCouponRequestliberatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CouponsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new LiberateCouponRequest(); // LiberateCouponRequest |  (optional) 

            try
            {
                // Liberates a coupon - {LiberateCouponRequest}
                apiInstance.LiberateCouponRequestliberatePost(accept, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.LiberateCouponRequestliberatePost: " + e.Message );
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
 **body** | [**LiberateCouponRequest**](LiberateCouponRequest.md)|  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

