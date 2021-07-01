# Yaksa.OrckestraCommerce.Client.Api.WarehousesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateWarehouseByNumberRequestScopeIdcreateOrUpdateCreate**](WarehousesApi.md#createorupdatewarehousebynumberrequestscopeidcreateorupdatecreate) | **PUT** /warehouses/{ScopeId}/createOrUpdate | Create or update a warehouse using its number - {CreateOrUpdateWarehouseByNumberRequest}
[**CreateWarehouseRequestScopeIdPost**](WarehousesApi.md#createwarehouserequestscopeidpost) | **POST** /warehouses/{ScopeId} | Creates a warehouse using the provided iD, if not provided, a new Id will be generated  - {CreateWarehouseRequest}
[**DeleteWarehouseRequestScopeIdIddeleteDelete**](WarehousesApi.md#deletewarehouserequestscopeididdeletedelete) | **DELETE** /warehouses/{ScopeId}/{Id}/delete | Deletes a warehouse using its Id - {DeleteWarehouseRequest}
[**FindWarehousesRequestScopeIdfindPost**](WarehousesApi.md#findwarehousesrequestscopeidfindpost) | **POST** /warehouses/{ScopeId}/find | Search for warehouses based on search terms - {FindWarehousesRequest}
[**GetWarehouseRequestScopeIdIdGet**](WarehousesApi.md#getwarehouserequestscopeididget) | **GET** /warehouses/{ScopeId}/{Id} | Retrieves a warehouse using its Id - {GetWarehouseRequest}
[**UpdateWarehouseRequestScopeIdIdCreate**](WarehousesApi.md#updatewarehouserequestscopeididcreate) | **PUT** /warehouses/{ScopeId}/{Id} | Update a warehouse using its Id - {UpdateWarehouseRequest}
[**UpdateWarehouseScopeAssociationsRequestScopeIdIdAssociatedScopesCreate**](WarehousesApi.md#updatewarehousescopeassociationsrequestscopeididassociatedscopescreate) | **PUT** /warehouses/{ScopeId}/{Id}/AssociatedScopes | Updates the scope associations of a warehouse - {UpdateWarehouseScopeAssociationsRequest}


<a name="createorupdatewarehousebynumberrequestscopeidcreateorupdatecreate"></a>
# **CreateOrUpdateWarehouseByNumberRequestScopeIdcreateOrUpdateCreate**
> Warehouse CreateOrUpdateWarehouseByNumberRequestScopeIdcreateOrUpdateCreate (string accept, string scopeId, CreateOrUpdateWarehouseByNumberRequest body = null)

Create or update a warehouse using its number - {CreateOrUpdateWarehouseByNumberRequest}

Creates or updates a warehouse

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrUpdateWarehouseByNumberRequestScopeIdcreateOrUpdateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new WarehousesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateOrUpdateWarehouseByNumberRequest(); // CreateOrUpdateWarehouseByNumberRequest |  (optional) 

            try
            {
                // Create or update a warehouse using its number - {CreateOrUpdateWarehouseByNumberRequest}
                Warehouse result = apiInstance.CreateOrUpdateWarehouseByNumberRequestScopeIdcreateOrUpdateCreate(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.CreateOrUpdateWarehouseByNumberRequestScopeIdcreateOrUpdateCreate: " + e.Message );
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
 **body** | [**CreateOrUpdateWarehouseByNumberRequest**](CreateOrUpdateWarehouseByNumberRequest.md)|  | [optional] 

### Return type

[**Warehouse**](Warehouse.md)

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

<a name="createwarehouserequestscopeidpost"></a>
# **CreateWarehouseRequestScopeIdPost**
> Warehouse CreateWarehouseRequestScopeIdPost (string accept, string scopeId, CreateWarehouseRequest body = null)

Creates a warehouse using the provided iD, if not provided, a new Id will be generated  - {CreateWarehouseRequest}

Creates a warehouse

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateWarehouseRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new WarehousesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateWarehouseRequest(); // CreateWarehouseRequest |  (optional) 

            try
            {
                // Creates a warehouse using the provided iD, if not provided, a new Id will be generated  - {CreateWarehouseRequest}
                Warehouse result = apiInstance.CreateWarehouseRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.CreateWarehouseRequestScopeIdPost: " + e.Message );
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
 **body** | [**CreateWarehouseRequest**](CreateWarehouseRequest.md)|  | [optional] 

### Return type

[**Warehouse**](Warehouse.md)

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

<a name="deletewarehouserequestscopeididdeletedelete"></a>
# **DeleteWarehouseRequestScopeIdIddeleteDelete**
> void DeleteWarehouseRequestScopeIdIddeleteDelete (string accept, string scopeId, string id)

Deletes a warehouse using its Id - {DeleteWarehouseRequest}

Deletes a warehouse

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteWarehouseRequestScopeIdIddeleteDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new WarehousesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | the unique identifier of the Warehouse to be updated.

            try
            {
                // Deletes a warehouse using its Id - {DeleteWarehouseRequest}
                apiInstance.DeleteWarehouseRequestScopeIdIddeleteDelete(accept, scopeId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.DeleteWarehouseRequestScopeIdIddeleteDelete: " + e.Message );
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
 **id** | **string**| the unique identifier of the Warehouse to be updated. | 

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

<a name="findwarehousesrequestscopeidfindpost"></a>
# **FindWarehousesRequestScopeIdfindPost**
> FindWarehousesQueryResult FindWarehousesRequestScopeIdfindPost (string accept, string scopeId, FindWarehousesRequest body = null)

Search for warehouses based on search terms - {FindWarehousesRequest}

Search for warehouses based on search terms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindWarehousesRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new WarehousesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindWarehousesRequest(); // FindWarehousesRequest |  (optional) 

            try
            {
                // Search for warehouses based on search terms - {FindWarehousesRequest}
                FindWarehousesQueryResult result = apiInstance.FindWarehousesRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.FindWarehousesRequestScopeIdfindPost: " + e.Message );
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
 **scopeId** | **string**| The scope to use to process the request | 
 **body** | [**FindWarehousesRequest**](FindWarehousesRequest.md)|  | [optional] 

### Return type

[**FindWarehousesQueryResult**](FindWarehousesQueryResult.md)

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

<a name="getwarehouserequestscopeididget"></a>
# **GetWarehouseRequestScopeIdIdGet**
> Warehouse GetWarehouseRequestScopeIdIdGet (string accept, string scopeId, string id, string cultureName = null, bool? includeAddresses = null, bool? includeSchedules = null, bool? includeOperatingStatus = null)

Retrieves a warehouse using its Id - {GetWarehouseRequest}

Retrieve a specific warehouse using its Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetWarehouseRequestScopeIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new WarehousesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The unique id of the warehouse.
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load the collection of addresses linked to the warehouse. (optional) 
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the warehouse. (optional) 
            var includeOperatingStatus = true;  // bool? | Specifies whether or not to load the operating status of the warehouse. (optional) 

            try
            {
                // Retrieves a warehouse using its Id - {GetWarehouseRequest}
                Warehouse result = apiInstance.GetWarehouseRequestScopeIdIdGet(accept, scopeId, id, cultureName, includeAddresses, includeSchedules, includeOperatingStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.GetWarehouseRequestScopeIdIdGet: " + e.Message );
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
 **id** | **string**| The unique id of the warehouse. | 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load the collection of addresses linked to the warehouse. | [optional] 
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the warehouse. | [optional] 
 **includeOperatingStatus** | **bool?**| Specifies whether or not to load the operating status of the warehouse. | [optional] 

### Return type

[**Warehouse**](Warehouse.md)

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
| **404** | Requested warehouse not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewarehouserequestscopeididcreate"></a>
# **UpdateWarehouseRequestScopeIdIdCreate**
> Warehouse UpdateWarehouseRequestScopeIdIdCreate (string accept, string scopeId, string id, UpdateWarehouseRequest body = null)

Update a warehouse using its Id - {UpdateWarehouseRequest}

Updates a warehouse

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateWarehouseRequestScopeIdIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new WarehousesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | the unique identifier of the Warehouse to be updated.
            var body = new UpdateWarehouseRequest(); // UpdateWarehouseRequest |  (optional) 

            try
            {
                // Update a warehouse using its Id - {UpdateWarehouseRequest}
                Warehouse result = apiInstance.UpdateWarehouseRequestScopeIdIdCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.UpdateWarehouseRequestScopeIdIdCreate: " + e.Message );
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
 **id** | **string**| the unique identifier of the Warehouse to be updated. | 
 **body** | [**UpdateWarehouseRequest**](UpdateWarehouseRequest.md)|  | [optional] 

### Return type

[**Warehouse**](Warehouse.md)

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

<a name="updatewarehousescopeassociationsrequestscopeididassociatedscopescreate"></a>
# **UpdateWarehouseScopeAssociationsRequestScopeIdIdAssociatedScopesCreate**
> void UpdateWarehouseScopeAssociationsRequestScopeIdIdAssociatedScopesCreate (string accept, string scopeId, string id, UpdateWarehouseScopeAssociationsRequest body = null)

Updates the scope associations of a warehouse - {UpdateWarehouseScopeAssociationsRequest}

Updates the scope associations of a warehouse, there must be at least one scope in the list of associated scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateWarehouseScopeAssociationsRequestScopeIdIdAssociatedScopesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new WarehousesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | the unique identifier of the Warehouse.
            var body = new UpdateWarehouseScopeAssociationsRequest(); // UpdateWarehouseScopeAssociationsRequest |  (optional) 

            try
            {
                // Updates the scope associations of a warehouse - {UpdateWarehouseScopeAssociationsRequest}
                apiInstance.UpdateWarehouseScopeAssociationsRequestScopeIdIdAssociatedScopesCreate(accept, scopeId, id, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.UpdateWarehouseScopeAssociationsRequestScopeIdIdAssociatedScopesCreate: " + e.Message );
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
 **id** | **string**| the unique identifier of the Warehouse. | 
 **body** | [**UpdateWarehouseScopeAssociationsRequest**](UpdateWarehouseScopeAssociationsRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

