# Yaksa.OrckestraCommerce.Client.Api.PickingMissionsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignPickerToPickingMissionRequestScopeIdIdassignPickerPost**](PickingMissionsApi.md#assignpickertopickingmissionrequestscopeididassignpickerpost) | **POST** /pickingMissions/{ScopeId}/{Id}/assignPicker | Assigns a picker to the specified picking mission - {AssignPickerToPickingMissionRequest}
[**CancelPickingMissionAssemblyRequestScopeIdIdcancelAssemblyPost**](PickingMissionsApi.md#cancelpickingmissionassemblyrequestscopeididcancelassemblypost) | **POST** /pickingMissions/{ScopeId}/{Id}/cancelAssembly | Cancels the assembly of a picking mission which is currently in progress - {CancelPickingMissionAssemblyRequest}
[**CancelPickingMissionRequestScopeIdIdcancelPost**](PickingMissionsApi.md#cancelpickingmissionrequestscopeididcancelpost) | **POST** /pickingMissions/{ScopeId}/{Id}/cancel | Cancels the specified picking mission - {CancelPickingMissionRequest}
[**CompletePickingMissionAssemblyRequestScopeIdIdcompleteAssemblyPost**](PickingMissionsApi.md#completepickingmissionassemblyrequestscopeididcompleteassemblypost) | **POST** /pickingMissions/{ScopeId}/{Id}/completeAssembly | Completes the specified picking mission with the list of picked quantity items - {CompletePickingMissionAssemblyRequest}
[**CreatePickingMissionRequestScopeIdPost**](PickingMissionsApi.md#createpickingmissionrequestscopeidpost) | **POST** /pickingMissions/{ScopeId} | Creates a new picking mission for a fulfillment location and a list of mission items - {CreatePickingMissionRequest}
[**GetFulfillmentLocationPickingMissionsRequestScopeIdbyLocationFulfillmentLocationIdGet**](PickingMissionsApi.md#getfulfillmentlocationpickingmissionsrequestscopeidbylocationfulfillmentlocationidget) | **GET** /pickingMissions/{ScopeId}/byLocation/{FulfillmentLocationId} | Gets the list of picking missions for a fulfillment location and optionally filtered by status - {GetFulfillmentLocationPickingMissionsRequest}
[**GetOrderPickingMissionsRequestScopeIdbyOrderOrderIdGet**](PickingMissionsApi.md#getorderpickingmissionsrequestscopeidbyorderorderidget) | **GET** /pickingMissions/{ScopeId}/byOrder/{OrderId} | Gets the list of picking missions for an order and optionally filtered by fulfillment location and/or status - {GetOrderPickingMissionsRequest}
[**GetPickingMissionRequestScopeIdIdGet**](PickingMissionsApi.md#getpickingmissionrequestscopeididget) | **GET** /pickingMissions/{ScopeId}/{Id} | Gets a picking mission by its identifier - {GetPickingMissionRequest}
[**GetShipmentPickingMissionsRequestScopeIdbyShipmentShipmentIdGet**](PickingMissionsApi.md#getshipmentpickingmissionsrequestscopeidbyshipmentshipmentidget) | **GET** /pickingMissions/{ScopeId}/byShipment/{ShipmentId} | Gets the list of picking missions for a shipment and optionally filtered by fulfillment location and/or status - {GetShipmentPickingMissionsRequest}
[**SavePickingMissionAssemblyProgressRequestScopeIdIdsaveAssemblyProgressCreate**](PickingMissionsApi.md#savepickingmissionassemblyprogressrequestscopeididsaveassemblyprogresscreate) | **PUT** /pickingMissions/{ScopeId}/{Id}/saveAssemblyProgress | Saves the assembly progress made on the specified picking mission with the list of picked quantity items - {SavePickingMissionAssemblyProgressRequest}
[**StartPickingMissionAssemblyRequestScopeIdIdstartAssemblyPost**](PickingMissionsApi.md#startpickingmissionassemblyrequestscopeididstartassemblypost) | **POST** /pickingMissions/{ScopeId}/{Id}/startAssembly | Starts the assembly of the specified picking mission - {StartPickingMissionAssemblyRequest}
[**UnassignPickerFromPickingMissionRequestScopeIdIdunassignPickerPost**](PickingMissionsApi.md#unassignpickerfrompickingmissionrequestscopeididunassignpickerpost) | **POST** /pickingMissions/{ScopeId}/{Id}/unassignPicker | Unassigns the picker from the specified picking mission - {UnassignPickerFromPickingMissionRequest}
[**UpdatePickingMissionRequestScopeIdIdCreate**](PickingMissionsApi.md#updatepickingmissionrequestscopeididcreate) | **PUT** /pickingMissions/{ScopeId}/{Id} | Updates mission items of the specified picking mission - {UpdatePickingMissionRequest}


<a name="assignpickertopickingmissionrequestscopeididassignpickerpost"></a>
# **AssignPickerToPickingMissionRequestScopeIdIdassignPickerPost**
> PickingMission AssignPickerToPickingMissionRequestScopeIdIdassignPickerPost (string accept, string scopeId, string id, AssignPickerToPickingMissionRequest body = null)

Assigns a picker to the specified picking mission - {AssignPickerToPickingMissionRequest}

Assigns a picker to the specified picking mission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AssignPickerToPickingMissionRequestScopeIdIdassignPickerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope identifier.
            var id = id_example;  // string | the picking mission identifier.
            var body = new AssignPickerToPickingMissionRequest(); // AssignPickerToPickingMissionRequest |  (optional) 

            try
            {
                // Assigns a picker to the specified picking mission - {AssignPickerToPickingMissionRequest}
                PickingMission result = apiInstance.AssignPickerToPickingMissionRequestScopeIdIdassignPickerPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.AssignPickerToPickingMissionRequestScopeIdIdassignPickerPost: " + e.Message );
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
 **scopeId** | **string**| the scope identifier. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | [**AssignPickerToPickingMissionRequest**](AssignPickerToPickingMissionRequest.md)|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="cancelpickingmissionassemblyrequestscopeididcancelassemblypost"></a>
# **CancelPickingMissionAssemblyRequestScopeIdIdcancelAssemblyPost**
> PickingMission CancelPickingMissionAssemblyRequestScopeIdIdcancelAssemblyPost (string accept, string scopeId, string id, Object body = null)

Cancels the assembly of a picking mission which is currently in progress - {CancelPickingMissionAssemblyRequest}

Cancels the assembly of a picking mission which is currently in progress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CancelPickingMissionAssemblyRequestScopeIdIdcancelAssemblyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var id = id_example;  // string | the picking mission identifier.
            var body = ;  // Object |  (optional) 

            try
            {
                // Cancels the assembly of a picking mission which is currently in progress - {CancelPickingMissionAssemblyRequest}
                PickingMission result = apiInstance.CancelPickingMissionAssemblyRequestScopeIdIdcancelAssemblyPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.CancelPickingMissionAssemblyRequestScopeIdIdcancelAssemblyPost: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | **Object**|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="cancelpickingmissionrequestscopeididcancelpost"></a>
# **CancelPickingMissionRequestScopeIdIdcancelPost**
> PickingMission CancelPickingMissionRequestScopeIdIdcancelPost (string accept, string scopeId, string id, Object body = null)

Cancels the specified picking mission - {CancelPickingMissionRequest}

Cancels the specified picking mission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CancelPickingMissionRequestScopeIdIdcancelPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var id = id_example;  // string | the picking mission identifier.
            var body = ;  // Object |  (optional) 

            try
            {
                // Cancels the specified picking mission - {CancelPickingMissionRequest}
                PickingMission result = apiInstance.CancelPickingMissionRequestScopeIdIdcancelPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.CancelPickingMissionRequestScopeIdIdcancelPost: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | **Object**|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="completepickingmissionassemblyrequestscopeididcompleteassemblypost"></a>
# **CompletePickingMissionAssemblyRequestScopeIdIdcompleteAssemblyPost**
> PickingMission CompletePickingMissionAssemblyRequestScopeIdIdcompleteAssemblyPost (string accept, string scopeId, string id, CompletePickingMissionAssemblyRequest body = null)

Completes the specified picking mission with the list of picked quantity items - {CompletePickingMissionAssemblyRequest}

Completes the specified picking mission with the list of picked quantity items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CompletePickingMissionAssemblyRequestScopeIdIdcompleteAssemblyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var id = id_example;  // string | the picking mission identifier.
            var body = new CompletePickingMissionAssemblyRequest(); // CompletePickingMissionAssemblyRequest |  (optional) 

            try
            {
                // Completes the specified picking mission with the list of picked quantity items - {CompletePickingMissionAssemblyRequest}
                PickingMission result = apiInstance.CompletePickingMissionAssemblyRequestScopeIdIdcompleteAssemblyPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.CompletePickingMissionAssemblyRequestScopeIdIdcompleteAssemblyPost: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | [**CompletePickingMissionAssemblyRequest**](CompletePickingMissionAssemblyRequest.md)|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="createpickingmissionrequestscopeidpost"></a>
# **CreatePickingMissionRequestScopeIdPost**
> PickingMission CreatePickingMissionRequestScopeIdPost (string accept, string scopeId, CreatePickingMissionRequest body = null)

Creates a new picking mission for a fulfillment location and a list of mission items - {CreatePickingMissionRequest}

Creates a new picking mission for a fulfillment location and a list of mission items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreatePickingMissionRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var body = new CreatePickingMissionRequest(); // CreatePickingMissionRequest |  (optional) 

            try
            {
                // Creates a new picking mission for a fulfillment location and a list of mission items - {CreatePickingMissionRequest}
                PickingMission result = apiInstance.CreatePickingMissionRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.CreatePickingMissionRequestScopeIdPost: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **body** | [**CreatePickingMissionRequest**](CreatePickingMissionRequest.md)|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="getfulfillmentlocationpickingmissionsrequestscopeidbylocationfulfillmentlocationidget"></a>
# **GetFulfillmentLocationPickingMissionsRequestScopeIdbyLocationFulfillmentLocationIdGet**
> PickingMissionResult GetFulfillmentLocationPickingMissionsRequestScopeIdbyLocationFulfillmentLocationIdGet (string accept, string scopeId, string fulfillmentLocationId, string status = null)

Gets the list of picking missions for a fulfillment location and optionally filtered by status - {GetFulfillmentLocationPickingMissionsRequest}

Gets the list of picking missions for a fulfillment location and optionally filtered by status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationPickingMissionsRequestScopeIdbyLocationFulfillmentLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the fulfillment location identifier.
            var status = status_example;  // string | the picking mission status. (optional) 

            try
            {
                // Gets the list of picking missions for a fulfillment location and optionally filtered by status - {GetFulfillmentLocationPickingMissionsRequest}
                PickingMissionResult result = apiInstance.GetFulfillmentLocationPickingMissionsRequestScopeIdbyLocationFulfillmentLocationIdGet(accept, scopeId, fulfillmentLocationId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.GetFulfillmentLocationPickingMissionsRequestScopeIdbyLocationFulfillmentLocationIdGet: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **fulfillmentLocationId** | **string**| the fulfillment location identifier. | 
 **status** | **string**| the picking mission status. | [optional] 

### Return type

[**PickingMissionResult**](PickingMissionResult.md)

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

<a name="getorderpickingmissionsrequestscopeidbyorderorderidget"></a>
# **GetOrderPickingMissionsRequestScopeIdbyOrderOrderIdGet**
> PickingMissionResult GetOrderPickingMissionsRequestScopeIdbyOrderOrderIdGet (string accept, string scopeId, string orderId, string fulfillmentLocationId = null, string status = null)

Gets the list of picking missions for an order and optionally filtered by fulfillment location and/or status - {GetOrderPickingMissionsRequest}

Gets the list of picking missions for an order and optionally filtered by fulfillment location and/or status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderPickingMissionsRequestScopeIdbyOrderOrderIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var orderId = orderId_example;  // string | the order identifier.
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the fulfillment location identifier. (optional) 
            var status = status_example;  // string | the picking mission status. (optional) 

            try
            {
                // Gets the list of picking missions for an order and optionally filtered by fulfillment location and/or status - {GetOrderPickingMissionsRequest}
                PickingMissionResult result = apiInstance.GetOrderPickingMissionsRequestScopeIdbyOrderOrderIdGet(accept, scopeId, orderId, fulfillmentLocationId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.GetOrderPickingMissionsRequestScopeIdbyOrderOrderIdGet: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **orderId** | **string**| the order identifier. | 
 **fulfillmentLocationId** | **string**| the fulfillment location identifier. | [optional] 
 **status** | **string**| the picking mission status. | [optional] 

### Return type

[**PickingMissionResult**](PickingMissionResult.md)

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

<a name="getpickingmissionrequestscopeididget"></a>
# **GetPickingMissionRequestScopeIdIdGet**
> PickingMission GetPickingMissionRequestScopeIdIdGet (string accept, string scopeId, string id)

Gets a picking mission by its identifier - {GetPickingMissionRequest}

Gets a picking mission by its identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPickingMissionRequestScopeIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var id = id_example;  // string | the picking mission identifier.

            try
            {
                // Gets a picking mission by its identifier - {GetPickingMissionRequest}
                PickingMission result = apiInstance.GetPickingMissionRequestScopeIdIdGet(accept, scopeId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.GetPickingMissionRequestScopeIdIdGet: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **id** | **string**| the picking mission identifier. | 

### Return type

[**PickingMission**](PickingMission.md)

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
| **404** | Requested picking mission not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentpickingmissionsrequestscopeidbyshipmentshipmentidget"></a>
# **GetShipmentPickingMissionsRequestScopeIdbyShipmentShipmentIdGet**
> PickingMissionResult GetShipmentPickingMissionsRequestScopeIdbyShipmentShipmentIdGet (string accept, string scopeId, string shipmentId, string fulfillmentLocationId = null, string status = null)

Gets the list of picking missions for a shipment and optionally filtered by fulfillment location and/or status - {GetShipmentPickingMissionsRequest}

Gets the list of picking missions for a shipment and optionally filtered by fulfillment location and/or status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetShipmentPickingMissionsRequestScopeIdbyShipmentShipmentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var shipmentId = shipmentId_example;  // string | the shipment identifier.
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the fulfillment location identifier. (optional) 
            var status = status_example;  // string | the picking mission status. (optional) 

            try
            {
                // Gets the list of picking missions for a shipment and optionally filtered by fulfillment location and/or status - {GetShipmentPickingMissionsRequest}
                PickingMissionResult result = apiInstance.GetShipmentPickingMissionsRequestScopeIdbyShipmentShipmentIdGet(accept, scopeId, shipmentId, fulfillmentLocationId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.GetShipmentPickingMissionsRequestScopeIdbyShipmentShipmentIdGet: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **shipmentId** | **string**| the shipment identifier. | 
 **fulfillmentLocationId** | **string**| the fulfillment location identifier. | [optional] 
 **status** | **string**| the picking mission status. | [optional] 

### Return type

[**PickingMissionResult**](PickingMissionResult.md)

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

<a name="savepickingmissionassemblyprogressrequestscopeididsaveassemblyprogresscreate"></a>
# **SavePickingMissionAssemblyProgressRequestScopeIdIdsaveAssemblyProgressCreate**
> PickingMission SavePickingMissionAssemblyProgressRequestScopeIdIdsaveAssemblyProgressCreate (string accept, string scopeId, string id, SavePickingMissionAssemblyProgressRequest body = null)

Saves the assembly progress made on the specified picking mission with the list of picked quantity items - {SavePickingMissionAssemblyProgressRequest}

Saves the assembly progress made on the specified picking mission with the list of picked quantity items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SavePickingMissionAssemblyProgressRequestScopeIdIdsaveAssemblyProgressCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var id = id_example;  // string | the picking mission identifier.
            var body = new SavePickingMissionAssemblyProgressRequest(); // SavePickingMissionAssemblyProgressRequest |  (optional) 

            try
            {
                // Saves the assembly progress made on the specified picking mission with the list of picked quantity items - {SavePickingMissionAssemblyProgressRequest}
                PickingMission result = apiInstance.SavePickingMissionAssemblyProgressRequestScopeIdIdsaveAssemblyProgressCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.SavePickingMissionAssemblyProgressRequestScopeIdIdsaveAssemblyProgressCreate: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | [**SavePickingMissionAssemblyProgressRequest**](SavePickingMissionAssemblyProgressRequest.md)|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="startpickingmissionassemblyrequestscopeididstartassemblypost"></a>
# **StartPickingMissionAssemblyRequestScopeIdIdstartAssemblyPost**
> PickingMission StartPickingMissionAssemblyRequestScopeIdIdstartAssemblyPost (string accept, string scopeId, string id, Object body = null)

Starts the assembly of the specified picking mission - {StartPickingMissionAssemblyRequest}

Starts the assembly of the specified picking mission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class StartPickingMissionAssemblyRequestScopeIdIdstartAssemblyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var id = id_example;  // string | the picking mission identifier.
            var body = ;  // Object |  (optional) 

            try
            {
                // Starts the assembly of the specified picking mission - {StartPickingMissionAssemblyRequest}
                PickingMission result = apiInstance.StartPickingMissionAssemblyRequestScopeIdIdstartAssemblyPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.StartPickingMissionAssemblyRequestScopeIdIdstartAssemblyPost: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | **Object**|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="unassignpickerfrompickingmissionrequestscopeididunassignpickerpost"></a>
# **UnassignPickerFromPickingMissionRequestScopeIdIdunassignPickerPost**
> PickingMission UnassignPickerFromPickingMissionRequestScopeIdIdunassignPickerPost (string accept, string scopeId, string id, Object body = null)

Unassigns the picker from the specified picking mission - {UnassignPickerFromPickingMissionRequest}

Unassigns the picker from the specified picking mission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UnassignPickerFromPickingMissionRequestScopeIdIdunassignPickerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope identifier.
            var id = id_example;  // string | the picking mission identifier.
            var body = ;  // Object |  (optional) 

            try
            {
                // Unassigns the picker from the specified picking mission - {UnassignPickerFromPickingMissionRequest}
                PickingMission result = apiInstance.UnassignPickerFromPickingMissionRequestScopeIdIdunassignPickerPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.UnassignPickerFromPickingMissionRequestScopeIdIdunassignPickerPost: " + e.Message );
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
 **scopeId** | **string**| the scope identifier. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | **Object**|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

<a name="updatepickingmissionrequestscopeididcreate"></a>
# **UpdatePickingMissionRequestScopeIdIdCreate**
> PickingMission UpdatePickingMissionRequestScopeIdIdCreate (string accept, string scopeId, string id, UpdatePickingMissionRequest body = null)

Updates mission items of the specified picking mission - {UpdatePickingMissionRequest}

Updates mission items of the specified picking mission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePickingMissionRequestScopeIdIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new PickingMissionsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | the scope id.
            var id = id_example;  // string | the picking mission identifier.
            var body = new UpdatePickingMissionRequest(); // UpdatePickingMissionRequest |  (optional) 

            try
            {
                // Updates mission items of the specified picking mission - {UpdatePickingMissionRequest}
                PickingMission result = apiInstance.UpdatePickingMissionRequestScopeIdIdCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickingMissionsApi.UpdatePickingMissionRequestScopeIdIdCreate: " + e.Message );
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
 **scopeId** | **string**| the scope id. | 
 **id** | **string**| the picking mission identifier. | 
 **body** | [**UpdatePickingMissionRequest**](UpdatePickingMissionRequest.md)|  | [optional] 

### Return type

[**PickingMission**](PickingMission.md)

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

