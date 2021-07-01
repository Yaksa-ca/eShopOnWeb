# Yaksa.OrckestraCommerce.Client.Api.ShipmentFulfillmentInfosApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCountShipmentFulfillmentInfosRequestScopeIdcountGet**](ShipmentFulfillmentInfosApi.md#getcountshipmentfulfillmentinfosrequestscopeidcountget) | **GET** /shipmentFulfillmentInfos/{ScopeId}/count | Get Number of shipment Fulfillment Infos - {GetCountShipmentFulfillmentInfosRequest}
[**GetNumberOfShipmentsForFulfillmentLocationRequestScopeIdnumberOfShipmentsForFulfillmentLocationFulfillmentLocationIdGet**](ShipmentFulfillmentInfosApi.md#getnumberofshipmentsforfulfillmentlocationrequestscopeidnumberofshipmentsforfulfillmentlocationfulfillmentlocationidget) | **GET** /shipmentFulfillmentInfos/{ScopeId}/numberOfShipmentsForFulfillmentLocation/{FulfillmentLocationId} | Get the number of shipments for a fulfillment location - {GetNumberOfShipmentsForFulfillmentLocationRequest}
[**GetPrintableShipmentUriRequestScopeIdShipmentIdprinturiGet**](ShipmentFulfillmentInfosApi.md#getprintableshipmenturirequestscopeidshipmentidprinturiget) | **GET** /shipmentFulfillmentInfos/{ScopeId}/{ShipmentId}/printuri | Get the uri of printable version of the shipment - {GetPrintableShipmentUriRequest}
[**GetPrintableShipmentsUriRequestScopeIdprintShipmentsPost**](ShipmentFulfillmentInfosApi.md#getprintableshipmentsurirequestscopeidprintshipmentspost) | **POST** /shipmentFulfillmentInfos/{ScopeId}/printShipments | Get the uri of printable version of a list of shipment - {GetPrintableShipmentsUriRequest}
[**GetShipmentFulfillmentInfosRequestScopeIdGet**](ShipmentFulfillmentInfosApi.md#getshipmentfulfillmentinfosrequestscopeidget) | **GET** /shipmentFulfillmentInfos/{ScopeId} | Get shipment Fulfillment Infos - {GetShipmentFulfillmentInfosRequest}


<a name="getcountshipmentfulfillmentinfosrequestscopeidcountget"></a>
# **GetCountShipmentFulfillmentInfosRequestScopeIdcountGet**
> CountShipmentFulfillmentInfos GetCountShipmentFulfillmentInfosRequestScopeIdcountGet (string accept, string scopeId, string pickUpLocationId = null, string fulfillmentLocationId = null, DateTime? startDate = null, DateTime? endDate = null, List<string> statuses = null, string type = null, string searchText = null, bool? flaggedOnly = null, bool? excludeShipmentInFinalState = null, string dateRangeFilter = null, string orderId = null)

Get Number of shipment Fulfillment Infos - {GetCountShipmentFulfillmentInfosRequest}

Get Number of shipment Fulfillment Infos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCountShipmentFulfillmentInfosRequestScopeIdcountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ShipmentFulfillmentInfosApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var pickUpLocationId = pickUpLocationId_example;  // string | the PickUpLocationId (optional) 
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the FulfillmentLocationId (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | the StartDate, ISO-8601 format (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | the EndDate, ISO-8601 format (optional) 
            var statuses = new List<string>(); // List<string> | the Statuses (optional) 
            var type = type_example;  // string | the FulfillmentMethodType (optional) 
            var searchText = searchText_example;  // string | the SearchText (optional) 
            var flaggedOnly = true;  // bool? | true if you just want to get flagged Shipments (optional) 
            var excludeShipmentInFinalState = true;  // bool? | value indicating whether or not shipments in final state of the workflow will be returned (optional) 
            var dateRangeFilter = dateRangeFilter_example;  // string | the date Range filter (optional) 
            var orderId = orderId_example;  // string | the order id (optional) 

            try
            {
                // Get Number of shipment Fulfillment Infos - {GetCountShipmentFulfillmentInfosRequest}
                CountShipmentFulfillmentInfos result = apiInstance.GetCountShipmentFulfillmentInfosRequestScopeIdcountGet(accept, scopeId, pickUpLocationId, fulfillmentLocationId, startDate, endDate, statuses, type, searchText, flaggedOnly, excludeShipmentInFinalState, dateRangeFilter, orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentFulfillmentInfosApi.GetCountShipmentFulfillmentInfosRequestScopeIdcountGet: " + e.Message );
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
 **pickUpLocationId** | **string**| the PickUpLocationId | [optional] 
 **fulfillmentLocationId** | **string**| the FulfillmentLocationId | [optional] 
 **startDate** | **DateTime?**| the StartDate, ISO-8601 format | [optional] 
 **endDate** | **DateTime?**| the EndDate, ISO-8601 format | [optional] 
 **statuses** | [**List&lt;string&gt;**](string.md)| the Statuses | [optional] 
 **type** | **string**| the FulfillmentMethodType | [optional] 
 **searchText** | **string**| the SearchText | [optional] 
 **flaggedOnly** | **bool?**| true if you just want to get flagged Shipments | [optional] 
 **excludeShipmentInFinalState** | **bool?**| value indicating whether or not shipments in final state of the workflow will be returned | [optional] 
 **dateRangeFilter** | **string**| the date Range filter | [optional] 
 **orderId** | **string**| the order id | [optional] 

### Return type

[**CountShipmentFulfillmentInfos**](CountShipmentFulfillmentInfos.md)

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

<a name="getnumberofshipmentsforfulfillmentlocationrequestscopeidnumberofshipmentsforfulfillmentlocationfulfillmentlocationidget"></a>
# **GetNumberOfShipmentsForFulfillmentLocationRequestScopeIdnumberOfShipmentsForFulfillmentLocationFulfillmentLocationIdGet**
> GetNumberOfShipmentsForFulfillmentLocationResponse GetNumberOfShipmentsForFulfillmentLocationRequestScopeIdnumberOfShipmentsForFulfillmentLocationFulfillmentLocationIdGet (string accept, string scopeId, string fulfillmentLocationId)

Get the number of shipments for a fulfillment location - {GetNumberOfShipmentsForFulfillmentLocationRequest}

Get the number of shipments for a fulfillment location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetNumberOfShipmentsForFulfillmentLocationRequestScopeIdnumberOfShipmentsForFulfillmentLocationFulfillmentLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ShipmentFulfillmentInfosApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the FulfillmentLocationId

            try
            {
                // Get the number of shipments for a fulfillment location - {GetNumberOfShipmentsForFulfillmentLocationRequest}
                GetNumberOfShipmentsForFulfillmentLocationResponse result = apiInstance.GetNumberOfShipmentsForFulfillmentLocationRequestScopeIdnumberOfShipmentsForFulfillmentLocationFulfillmentLocationIdGet(accept, scopeId, fulfillmentLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentFulfillmentInfosApi.GetNumberOfShipmentsForFulfillmentLocationRequestScopeIdnumberOfShipmentsForFulfillmentLocationFulfillmentLocationIdGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the FulfillmentLocationId | 

### Return type

[**GetNumberOfShipmentsForFulfillmentLocationResponse**](GetNumberOfShipmentsForFulfillmentLocationResponse.md)

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

<a name="getprintableshipmenturirequestscopeidshipmentidprinturiget"></a>
# **GetPrintableShipmentUriRequestScopeIdShipmentIdprinturiGet**
> string GetPrintableShipmentUriRequestScopeIdShipmentIdprinturiGet (string accept, string scopeId, string shipmentId)

Get the uri of printable version of the shipment - {GetPrintableShipmentUriRequest}

Get the uri of printable version of the shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPrintableShipmentUriRequestScopeIdShipmentIdprinturiGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ShipmentFulfillmentInfosApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var shipmentId = shipmentId_example;  // string | The shipment id for the request.

            try
            {
                // Get the uri of printable version of the shipment - {GetPrintableShipmentUriRequest}
                string result = apiInstance.GetPrintableShipmentUriRequestScopeIdShipmentIdprinturiGet(accept, scopeId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentFulfillmentInfosApi.GetPrintableShipmentUriRequestScopeIdShipmentIdprinturiGet: " + e.Message );
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
 **shipmentId** | **string**| The shipment id for the request. | 

### Return type

**string**

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
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprintableshipmentsurirequestscopeidprintshipmentspost"></a>
# **GetPrintableShipmentsUriRequestScopeIdprintShipmentsPost**
> string GetPrintableShipmentsUriRequestScopeIdprintShipmentsPost (string accept, string scopeId, GetPrintableShipmentsUriRequest body = null)

Get the uri of printable version of a list of shipment - {GetPrintableShipmentsUriRequest}

Get the uri of printable version of a list of shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPrintableShipmentsUriRequestScopeIdprintShipmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ShipmentFulfillmentInfosApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetPrintableShipmentsUriRequest(); // GetPrintableShipmentsUriRequest |  (optional) 

            try
            {
                // Get the uri of printable version of a list of shipment - {GetPrintableShipmentsUriRequest}
                string result = apiInstance.GetPrintableShipmentsUriRequestScopeIdprintShipmentsPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentFulfillmentInfosApi.GetPrintableShipmentsUriRequestScopeIdprintShipmentsPost: " + e.Message );
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
 **body** | [**GetPrintableShipmentsUriRequest**](GetPrintableShipmentsUriRequest.md)|  | [optional] 

### Return type

**string**

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
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentfulfillmentinfosrequestscopeidget"></a>
# **GetShipmentFulfillmentInfosRequestScopeIdGet**
> ShipmentFulfillmentInfoQueryResult GetShipmentFulfillmentInfosRequestScopeIdGet (string accept, string scopeId, string pickUpLocationId = null, string fulfillmentLocationId = null, DateTime? startDate = null, DateTime? endDate = null, List<string> statuses = null, string type = null, int? pageSize = null, int? pageNumber = null, string sort = null, string searchText = null, bool? flaggedOnly = null, bool? excludeShipmentInFinalState = null, string dateRangeFilter = null, string orderId = null, List<string> requiredFields = null)

Get shipment Fulfillment Infos - {GetShipmentFulfillmentInfosRequest}

Get shipment Fulfillment Infos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetShipmentFulfillmentInfosRequestScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ShipmentFulfillmentInfosApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var pickUpLocationId = pickUpLocationId_example;  // string | the PickUpLocationId (optional) 
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the FulfillmentLocationId (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | the StartDate, ISO-8601 format (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | the EndDate, ISO-8601 format (optional) 
            var statuses = new List<string>(); // List<string> | the Statuses (optional) 
            var type = type_example;  // string | the FulfillmentMethodType (optional) 
            var pageSize = 56;  // int? | the PageSize (optional) 
            var pageNumber = 56;  // int? | the PageNumber (optional) 
            var sort = sort_example;  // string | the sorted fields, seperated by commas, use '-' before field name for descending (optional) 
            var searchText = searchText_example;  // string | the SearchText (optional) 
            var flaggedOnly = true;  // bool? | true if you just want to get flagged Shipments (optional) 
            var excludeShipmentInFinalState = true;  // bool? | value indicating whether or not shipments in final state of the workflow will be returned (optional) 
            var dateRangeFilter = dateRangeFilter_example;  // string | the date range filter (optional) 
            var orderId = orderId_example;  // string | the order id (optional) 
            var requiredFields = new List<string>(); // List<string> | The fields from ShipmentFulfillmentInfo that are absolutely required. Default is all. (optional) 

            try
            {
                // Get shipment Fulfillment Infos - {GetShipmentFulfillmentInfosRequest}
                ShipmentFulfillmentInfoQueryResult result = apiInstance.GetShipmentFulfillmentInfosRequestScopeIdGet(accept, scopeId, pickUpLocationId, fulfillmentLocationId, startDate, endDate, statuses, type, pageSize, pageNumber, sort, searchText, flaggedOnly, excludeShipmentInFinalState, dateRangeFilter, orderId, requiredFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentFulfillmentInfosApi.GetShipmentFulfillmentInfosRequestScopeIdGet: " + e.Message );
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
 **pickUpLocationId** | **string**| the PickUpLocationId | [optional] 
 **fulfillmentLocationId** | **string**| the FulfillmentLocationId | [optional] 
 **startDate** | **DateTime?**| the StartDate, ISO-8601 format | [optional] 
 **endDate** | **DateTime?**| the EndDate, ISO-8601 format | [optional] 
 **statuses** | [**List&lt;string&gt;**](string.md)| the Statuses | [optional] 
 **type** | **string**| the FulfillmentMethodType | [optional] 
 **pageSize** | **int?**| the PageSize | [optional] 
 **pageNumber** | **int?**| the PageNumber | [optional] 
 **sort** | **string**| the sorted fields, seperated by commas, use &#39;-&#39; before field name for descending | [optional] 
 **searchText** | **string**| the SearchText | [optional] 
 **flaggedOnly** | **bool?**| true if you just want to get flagged Shipments | [optional] 
 **excludeShipmentInFinalState** | **bool?**| value indicating whether or not shipments in final state of the workflow will be returned | [optional] 
 **dateRangeFilter** | **string**| the date range filter | [optional] 
 **orderId** | **string**| the order id | [optional] 
 **requiredFields** | [**List&lt;string&gt;**](string.md)| The fields from ShipmentFulfillmentInfo that are absolutely required. Default is all. | [optional] 

### Return type

[**ShipmentFulfillmentInfoQueryResult**](ShipmentFulfillmentInfoQueryResult.md)

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

