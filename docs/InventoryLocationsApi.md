# Yaksa.OrckestraCommerce.Client.Api.InventoryLocationsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventoryScheduleRequestInventoryLocationIdschedulesPost**](InventoryLocationsApi.md#addinventoryschedulerequestinventorylocationidschedulespost) | **POST** /inventoryLocations/{InventoryLocationId}/schedules | Add an inventory schedule to a location - {AddInventoryScheduleRequest}
[**CreateInventoryLocationRequestScopeIdPost**](InventoryLocationsApi.md#createinventorylocationrequestscopeidpost) | **POST** /inventoryLocations/{ScopeId} | Creates or updates an inventory location - {CreateInventoryLocationRequest}
[**DeleteInventoryScheduleRequestInventoryLocationIdschedulesScheduleIdDelete**](InventoryLocationsApi.md#deleteinventoryschedulerequestinventorylocationidschedulesscheduleiddelete) | **DELETE** /inventoryLocations/{InventoryLocationId}/schedules/{ScheduleId} | Delete an inventory schedule - {DeleteInventoryScheduleRequest}
[**GetInventoryLocationRequestScopeIdAssociatedLocationIdGet**](InventoryLocationsApi.md#getinventorylocationrequestscopeidassociatedlocationidget) | **GET** /inventoryLocations/{ScopeId}/{AssociatedLocationId} | Retrieve an inventory location by Id - {GetInventoryLocationRequest}
[**GetInventoryScheduleByIdRequestInventoryLocationIdschedulesbyIdScheduleIdGet**](InventoryLocationsApi.md#getinventoryschedulebyidrequestinventorylocationidschedulesbyidscheduleidget) | **GET** /inventoryLocations/{InventoryLocationId}/schedules/byId/{ScheduleId} | Retrieve an inventory schedule of a location using its id - {GetInventoryScheduleByIdRequest}
[**GetInventorySchedulesBySkuRequestInventoryLocationIdschedulesbySkuSkuGet**](InventoryLocationsApi.md#getinventoryschedulesbyskurequestinventorylocationidschedulesbyskuskuget) | **GET** /inventoryLocations/{InventoryLocationId}/schedules/bySku/{Sku} | Retrieve all the inventory schedules of a location and a sku - {GetInventorySchedulesBySkuRequest}
[**GetInventorySchedulesRequestInventoryLocationIdschedulesGet**](InventoryLocationsApi.md#getinventoryschedulesrequestinventorylocationidschedulesget) | **GET** /inventoryLocations/{InventoryLocationId}/schedules | Retrieve all the inventory schedules of a location - {GetInventorySchedulesRequest}
[**UpdateInventoryScheduleRequestInventoryLocationIdschedulesCreate**](InventoryLocationsApi.md#updateinventoryschedulerequestinventorylocationidschedulescreate) | **PUT** /inventoryLocations/{InventoryLocationId}/schedules | Update an inventory schedule daterange and status - {UpdateInventoryScheduleRequest}


<a name="addinventoryschedulerequestinventorylocationidschedulespost"></a>
# **AddInventoryScheduleRequestInventoryLocationIdschedulesPost**
> InventorySchedule AddInventoryScheduleRequestInventoryLocationIdschedulesPost (string accept, string inventoryLocationId, AddInventoryScheduleRequest body = null)

Add an inventory schedule to a location - {AddInventoryScheduleRequest}

Add an inventory schedule to a location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddInventoryScheduleRequestInventoryLocationIdschedulesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var inventoryLocationId = inventoryLocationId_example;  // string | The inventory location identifier
            var body = new AddInventoryScheduleRequest(); // AddInventoryScheduleRequest |  (optional) 

            try
            {
                // Add an inventory schedule to a location - {AddInventoryScheduleRequest}
                InventorySchedule result = apiInstance.AddInventoryScheduleRequestInventoryLocationIdschedulesPost(accept, inventoryLocationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.AddInventoryScheduleRequestInventoryLocationIdschedulesPost: " + e.Message );
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
 **inventoryLocationId** | **string**| The inventory location identifier | 
 **body** | [**AddInventoryScheduleRequest**](AddInventoryScheduleRequest.md)|  | [optional] 

### Return type

[**InventorySchedule**](InventorySchedule.md)

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
| **404** | The inventory schedule was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinventorylocationrequestscopeidpost"></a>
# **CreateInventoryLocationRequestScopeIdPost**
> InventoryLocation CreateInventoryLocationRequestScopeIdPost (string accept, string scopeId, CreateInventoryLocationRequest body = null)

Creates or updates an inventory location - {CreateInventoryLocationRequest}

Creates or updates an inventory location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateInventoryLocationRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateInventoryLocationRequest(); // CreateInventoryLocationRequest |  (optional) 

            try
            {
                // Creates or updates an inventory location - {CreateInventoryLocationRequest}
                InventoryLocation result = apiInstance.CreateInventoryLocationRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.CreateInventoryLocationRequestScopeIdPost: " + e.Message );
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
 **body** | [**CreateInventoryLocationRequest**](CreateInventoryLocationRequest.md)|  | [optional] 

### Return type

[**InventoryLocation**](InventoryLocation.md)

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
| **404** | The associated inventory location was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventoryschedulerequestinventorylocationidschedulesscheduleiddelete"></a>
# **DeleteInventoryScheduleRequestInventoryLocationIdschedulesScheduleIdDelete**
> void DeleteInventoryScheduleRequestInventoryLocationIdschedulesScheduleIdDelete (string accept, string inventoryLocationId, string scheduleId, string scopeId = null)

Delete an inventory schedule - {DeleteInventoryScheduleRequest}

Delete an inventory schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteInventoryScheduleRequestInventoryLocationIdschedulesScheduleIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var inventoryLocationId = inventoryLocationId_example;  // string | The inventory location identifier used to identify the right schedule to update
            var scheduleId = scheduleId_example;  // string | The inventory schedule identifier used to find the right schedule to update
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Delete an inventory schedule - {DeleteInventoryScheduleRequest}
                apiInstance.DeleteInventoryScheduleRequestInventoryLocationIdschedulesScheduleIdDelete(accept, inventoryLocationId, scheduleId, scopeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.DeleteInventoryScheduleRequestInventoryLocationIdschedulesScheduleIdDelete: " + e.Message );
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
 **inventoryLocationId** | **string**| The inventory location identifier used to identify the right schedule to update | 
 **scheduleId** | **string**| The inventory schedule identifier used to find the right schedule to update | 
 **scopeId** | **string**| The id of the requested scope | [optional] 

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

<a name="getinventorylocationrequestscopeidassociatedlocationidget"></a>
# **GetInventoryLocationRequestScopeIdAssociatedLocationIdGet**
> InventoryLocation GetInventoryLocationRequestScopeIdAssociatedLocationIdGet (string accept, string scopeId, string associatedLocationId)

Retrieve an inventory location by Id - {GetInventoryLocationRequest}

Retrieve an inventory location by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryLocationRequestScopeIdAssociatedLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var associatedLocationId = associatedLocationId_example;  // string | the business id for the inventory location to retrieve

            try
            {
                // Retrieve an inventory location by Id - {GetInventoryLocationRequest}
                InventoryLocation result = apiInstance.GetInventoryLocationRequestScopeIdAssociatedLocationIdGet(accept, scopeId, associatedLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.GetInventoryLocationRequestScopeIdAssociatedLocationIdGet: " + e.Message );
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
 **associatedLocationId** | **string**| the business id for the inventory location to retrieve | 

### Return type

[**InventoryLocation**](InventoryLocation.md)

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
| **404** | The inventory location was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryschedulebyidrequestinventorylocationidschedulesbyidscheduleidget"></a>
# **GetInventoryScheduleByIdRequestInventoryLocationIdschedulesbyIdScheduleIdGet**
> InventorySchedule GetInventoryScheduleByIdRequestInventoryLocationIdschedulesbyIdScheduleIdGet (string accept, string inventoryLocationId, string scheduleId, string scopeId = null)

Retrieve an inventory schedule of a location using its id - {GetInventoryScheduleByIdRequest}

Retrieve an inventory schedule of a location using its id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryScheduleByIdRequestInventoryLocationIdschedulesbyIdScheduleIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var inventoryLocationId = inventoryLocationId_example;  // string | the business id for the inventory location which schedules to retrieve
            var scheduleId = scheduleId_example;  // string | the id of the schedule to retrieve
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Retrieve an inventory schedule of a location using its id - {GetInventoryScheduleByIdRequest}
                InventorySchedule result = apiInstance.GetInventoryScheduleByIdRequestInventoryLocationIdschedulesbyIdScheduleIdGet(accept, inventoryLocationId, scheduleId, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.GetInventoryScheduleByIdRequestInventoryLocationIdschedulesbyIdScheduleIdGet: " + e.Message );
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
 **inventoryLocationId** | **string**| the business id for the inventory location which schedules to retrieve | 
 **scheduleId** | **string**| the id of the schedule to retrieve | 
 **scopeId** | **string**| The id of the requested scope | [optional] 

### Return type

[**InventorySchedule**](InventorySchedule.md)

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
| **404** | No inventory schedule associated to the inventory location was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryschedulesbyskurequestinventorylocationidschedulesbyskuskuget"></a>
# **GetInventorySchedulesBySkuRequestInventoryLocationIdschedulesbySkuSkuGet**
> List&lt;InventorySchedule&gt; GetInventorySchedulesBySkuRequestInventoryLocationIdschedulesbySkuSkuGet (string accept, string inventoryLocationId, string sku, string scopeId = null)

Retrieve all the inventory schedules of a location and a sku - {GetInventorySchedulesBySkuRequest}

Retrieve all the inventory schedules of a location and a sku

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventorySchedulesBySkuRequestInventoryLocationIdschedulesbySkuSkuGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var inventoryLocationId = inventoryLocationId_example;  // string | the business id for the inventory location which schedules to retrieve
            var sku = sku_example;  // string | the sku for the product which schedules to retrieve
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Retrieve all the inventory schedules of a location and a sku - {GetInventorySchedulesBySkuRequest}
                List<InventorySchedule> result = apiInstance.GetInventorySchedulesBySkuRequestInventoryLocationIdschedulesbySkuSkuGet(accept, inventoryLocationId, sku, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.GetInventorySchedulesBySkuRequestInventoryLocationIdschedulesbySkuSkuGet: " + e.Message );
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
 **inventoryLocationId** | **string**| the business id for the inventory location which schedules to retrieve | 
 **sku** | **string**| the sku for the product which schedules to retrieve | 
 **scopeId** | **string**| The id of the requested scope | [optional] 

### Return type

[**List&lt;InventorySchedule&gt;**](InventorySchedule.md)

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
| **404** | No inventory schedule associated to the inventory location was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryschedulesrequestinventorylocationidschedulesget"></a>
# **GetInventorySchedulesRequestInventoryLocationIdschedulesGet**
> List&lt;InventorySchedule&gt; GetInventorySchedulesRequestInventoryLocationIdschedulesGet (string accept, string inventoryLocationId, string scopeId = null)

Retrieve all the inventory schedules of a location - {GetInventorySchedulesRequest}

Retrieve all the inventory schedules of a location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventorySchedulesRequestInventoryLocationIdschedulesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var inventoryLocationId = inventoryLocationId_example;  // string | the business id for the inventory location which schedules to retrieve
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Retrieve all the inventory schedules of a location - {GetInventorySchedulesRequest}
                List<InventorySchedule> result = apiInstance.GetInventorySchedulesRequestInventoryLocationIdschedulesGet(accept, inventoryLocationId, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.GetInventorySchedulesRequestInventoryLocationIdschedulesGet: " + e.Message );
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
 **inventoryLocationId** | **string**| the business id for the inventory location which schedules to retrieve | 
 **scopeId** | **string**| The id of the requested scope | [optional] 

### Return type

[**List&lt;InventorySchedule&gt;**](InventorySchedule.md)

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
| **404** | No inventory schedule associated to the inventory location was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinventoryschedulerequestinventorylocationidschedulescreate"></a>
# **UpdateInventoryScheduleRequestInventoryLocationIdschedulesCreate**
> InventorySchedule UpdateInventoryScheduleRequestInventoryLocationIdschedulesCreate (string accept, string inventoryLocationId, UpdateInventoryScheduleRequest body = null)

Update an inventory schedule daterange and status - {UpdateInventoryScheduleRequest}

Update an inventory schedule daterange and status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateInventoryScheduleRequestInventoryLocationIdschedulesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var inventoryLocationId = inventoryLocationId_example;  // string | The inventory location identifier used to identify the right schedule to update
            var body = new UpdateInventoryScheduleRequest(); // UpdateInventoryScheduleRequest |  (optional) 

            try
            {
                // Update an inventory schedule daterange and status - {UpdateInventoryScheduleRequest}
                InventorySchedule result = apiInstance.UpdateInventoryScheduleRequestInventoryLocationIdschedulesCreate(accept, inventoryLocationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryLocationsApi.UpdateInventoryScheduleRequestInventoryLocationIdschedulesCreate: " + e.Message );
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
 **inventoryLocationId** | **string**| The inventory location identifier used to identify the right schedule to update | 
 **body** | [**UpdateInventoryScheduleRequest**](UpdateInventoryScheduleRequest.md)|  | [optional] 

### Return type

[**InventorySchedule**](InventorySchedule.md)

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
| **404** | The inventory schedule was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

