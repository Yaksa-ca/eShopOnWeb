# Yaksa.OrckestraCommerce.Client.Api.InventoryQuantitiesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInventoryQuantitiesByLocationRequestScopeIdbyLocationInventoryLocationIdGet**](InventoryQuantitiesApi.md#getinventoryquantitiesbylocationrequestscopeidbylocationinventorylocationidget) | **GET** /inventoryQuantities/{ScopeId}/byLocation/{InventoryLocationId} | Retrieve inventory quantities for the specified inventory location id - {GetInventoryQuantitiesByLocationRequest}


<a name="getinventoryquantitiesbylocationrequestscopeidbylocationinventorylocationidget"></a>
# **GetInventoryQuantitiesByLocationRequestScopeIdbyLocationInventoryLocationIdGet**
> InventoryQuantityResult GetInventoryQuantitiesByLocationRequestScopeIdbyLocationInventoryLocationIdGet (string accept, string scopeId, string inventoryLocationId, int? skip = null, int? take = null, bool? excludeItemsWithQuantityEqualToZero = null)

Retrieve inventory quantities for the specified inventory location id - {GetInventoryQuantitiesByLocationRequest}

Retrieve inventory quantities for the specified inventory location id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryQuantitiesByLocationRequestScopeIdbyLocationInventoryLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryQuantitiesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var inventoryLocationId = inventoryLocationId_example;  // string | business id for the inventory location which will be associated to the Sku to retrieve InventoryItem
            var skip = 56;  // int? | The number of results to skip (optional) 
            var take = 56;  // int? | The number of results to return (optional) 
            var excludeItemsWithQuantityEqualToZero = true;  // bool? | Wheather or not inventory items having a quantity equal to zero should be excluded from the result (optional) 

            try
            {
                // Retrieve inventory quantities for the specified inventory location id - {GetInventoryQuantitiesByLocationRequest}
                InventoryQuantityResult result = apiInstance.GetInventoryQuantitiesByLocationRequestScopeIdbyLocationInventoryLocationIdGet(accept, scopeId, inventoryLocationId, skip, take, excludeItemsWithQuantityEqualToZero);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryQuantitiesApi.GetInventoryQuantitiesByLocationRequestScopeIdbyLocationInventoryLocationIdGet: " + e.Message );
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
 **inventoryLocationId** | **string**| business id for the inventory location which will be associated to the Sku to retrieve InventoryItem | 
 **skip** | **int?**| The number of results to skip | [optional] 
 **take** | **int?**| The number of results to return | [optional] 
 **excludeItemsWithQuantityEqualToZero** | **bool?**| Wheather or not inventory items having a quantity equal to zero should be excluded from the result | [optional] 

### Return type

[**InventoryQuantityResult**](InventoryQuantityResult.md)

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

