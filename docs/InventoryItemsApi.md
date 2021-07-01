# Yaksa.OrckestraCommerce.Client.Api.InventoryItemsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPost**](InventoryItemsApi.md#cancelallinventoryreserveditemsrequestreservationsowneridcancelallpost) | **POST** /inventoryItems/reservations/{OwnerId}/cancelAll | Cancel all inventory reserved items associated to the specified owner and inventory location. - {CancelAllInventoryReservedItemsRequest}
[**CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPost**](InventoryItemsApi.md#cancelinventoryreserveditemsrequestreservationsowneridcancellistpost) | **POST** /inventoryItems/reservations/{OwnerId}/cancelList | Allows to cancel a list of inventory reserved items associated to the specified owner. - {CancelInventoryReservedItemsRequest}
[**ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPost**](InventoryItemsApi.md#changeinventoryreserveditemsstockstatusrequestreservationsowneridchangestockstatuspost) | **POST** /inventoryItems/reservations/{OwnerId}/changeStockStatus | Change the stock status of inventory reserved items from their current stock status to the new given stock status. - {ChangeInventoryReservedItemsStockStatusRequest}
[**ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPost**](InventoryItemsApi.md#confirminventoryreservedorderitemsrequestreservationsowneridconfirmpost) | **POST** /inventoryItems/reservations/{OwnerId}/confirm | Applies the reserved items on the available quantitites in the inventory, decrement the effective reservation and changes the status Confirmed. - {ConfirmInventoryReservedOrderItemsRequest}
[**CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreate**](InventoryItemsApi.md#createorupdateinventoryitemrequestscopeidinventorylocationidskucreate) | **PUT** /inventoryItems/{ScopeId}/{InventoryLocationId}/{Sku} | Create or update an inventory item - {CreateOrUpdateInventoryItemRequest}
[**DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPost**](InventoryItemsApi.md#decreaseinventoryquantityrequestscopeidbyskuskubylocationinventorylocationiddecreasequantitypost) | **POST** /inventoryItems/{ScopeId}/bySku/{Sku}/byLocation/{InventoryLocationId}/decrease/{Quantity} | Decrease an inventory quantity - {DecreaseInventoryQuantityRequest}
[**EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePost**](InventoryItemsApi.md#evaluateinventoryavailabilityrequestreservationsowneridevaluatepost) | **POST** /inventoryItems/reservations/{OwnerId}/evaluate | Allows to send requests to evaluate inventory item availability - {EvaluateInventoryAvailabilityRequest}
[**FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPost**](InventoryItemsApi.md#findinventoryitemstatusbylocationandskusrequestscopeidbylocationinventorylocationidbyskusstatuspost) | **POST** /inventoryItems/{ScopeId}/byLocation/{InventoryLocationId}/bySkus/status | Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date - {FindInventoryItemStatusByLocationAndSkusRequest}
[**FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPost**](InventoryItemsApi.md#findinventoryitemstatusbyskuandlocationrequestscopeidbyskuskubylocationinventorylocationidstatuspost) | **POST** /inventoryItems/{ScopeId}/bySku/{Sku}/byLocation/{InventoryLocationId}/status | Retrieve the detail about the status of Inventory Item represented by the specified Sku and InventoryLocationId for the specified date - {FindInventoryItemStatusBySkuAndLocationRequest}
[**FindInventoryItemsRequestScopeIdfindPost**](InventoryItemsApi.md#findinventoryitemsrequestscopeidfindpost) | **POST** /inventoryItems/{ScopeId}/find | Retrieve a list of InventoryItem - {FindInventoryItemsRequest}
[**FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPost**](InventoryItemsApi.md#findinventoryitemsstatusbyscopeandskurequestscopeidbyskuskustatuspost) | **POST** /inventoryItems/{ScopeId}/bySku/{Sku}/status | Retrieve the detail about the status of Inventory Items represented by the specified Sku from all inventory location associated to the specific scope for the specified date - {FindInventoryItemsStatusByScopeAndSkuRequest}
[**FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPost**](InventoryItemsApi.md#findinventoryitemsstatusbyscopeandskusrequestscopeidbyskusstatuspost) | **POST** /inventoryItems/{ScopeId}/bySkus/status | Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date - {FindInventoryItemsStatusByScopeAndSkusRequest}
[**GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGet**](InventoryItemsApi.md#getinventoryitembyskuandlocationrequestscopeidbyskuskubylocationinventorylocationidget) | **GET** /inventoryItems/{ScopeId}/bySku/{Sku}/byLocation/{InventoryLocationId} | Retrieve an InventoryItem represented by association of sku and location id - {GetInventoryItemBySkuAndLocationRequest}
[**GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGet**](InventoryItemsApi.md#getinventoryitemsbylocationrequestscopeidbylocationinventorylocationidget) | **GET** /inventoryItems/{ScopeId}/byLocation/{InventoryLocationId} | Retrieve a list of InventoryItem represented by inventory location id - {GetInventoryItemsByLocationRequest}
[**GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGet**](InventoryItemsApi.md#getinventoryitemsbyscopeandskurequestscopeidbyskuskuget) | **GET** /inventoryItems/{ScopeId}/bySku/{Sku} | Retrieve a list of InventoryItemStatusDetails represented by sku from all inventory location associated to the specific scope - {GetInventoryItemsByScopeAndSkuRequest}
[**GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPost**](InventoryItemsApi.md#getinventoryitemsbyscopeandskusrequestscopeidbyskuspost) | **POST** /inventoryItems/{ScopeId}/bySkus | Retrieve a list of InventoryItemStatusDetails represented by SKUs from all inventory location associated to the specific scope - {GetInventoryItemsByScopeAndSkusRequest}
[**GetInventoryProvidersRequestScopeIdfindProvidersGet**](InventoryItemsApi.md#getinventoryprovidersrequestscopeidfindprovidersget) | **GET** /inventoryItems/{ScopeId}/findProviders | Retrieves all available inventory providers - {GetInventoryProvidersRequest}
[**GetInventoryReservedItemsRequestreservationsOwnerIdGet**](InventoryItemsApi.md#getinventoryreserveditemsrequestreservationsowneridget) | **GET** /inventoryItems/reservations/{OwnerId} | Find all reserved inventory items associated to the specified owner - {GetInventoryReservedItemsRequest}
[**IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPost**](InventoryItemsApi.md#increaseinventoryquantityrequestscopeidbyskuskubylocationinventorylocationidincreasequantitypost) | **POST** /inventoryItems/{ScopeId}/bySku/{Sku}/byLocation/{InventoryLocationId}/increase/{Quantity} | Increase an inventory quantity - {IncreaseInventoryQuantityRequest}
[**ReserveInventoryItemsRequestreservationsOwnerIdPost**](InventoryItemsApi.md#reserveinventoryitemsrequestreservationsowneridpost) | **POST** /inventoryItems/reservations/{OwnerId} | Allows to send requests to reserve a list of inventory items - {ReserveInventoryItemsRequest}


<a name="cancelallinventoryreserveditemsrequestreservationsowneridcancelallpost"></a>
# **CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPost**
> void CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPost (string accept, string ownerId, CancelAllInventoryReservedItemsRequest body = null)

Cancel all inventory reserved items associated to the specified owner and inventory location. - {CancelAllInventoryReservedItemsRequest}

Cancel all inventory reserved items associated to the specified owner and inventory location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var ownerId = ownerId_example;  // string | Gets or sets the unique identifier of the order, order draft or cart (according to the owner type)
            var body = new CancelAllInventoryReservedItemsRequest(); // CancelAllInventoryReservedItemsRequest |  (optional) 

            try
            {
                // Cancel all inventory reserved items associated to the specified owner and inventory location. - {CancelAllInventoryReservedItemsRequest}
                apiInstance.CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPost(accept, ownerId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.CancelAllInventoryReservedItemsRequestreservationsOwnerIdcancelAllPost: " + e.Message );
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
 **ownerId** | **string**| Gets or sets the unique identifier of the order, order draft or cart (according to the owner type) | 
 **body** | [**CancelAllInventoryReservedItemsRequest**](CancelAllInventoryReservedItemsRequest.md)|  | [optional] 

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

<a name="cancelinventoryreserveditemsrequestreservationsowneridcancellistpost"></a>
# **CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPost**
> void CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPost (string accept, string ownerId, CancelInventoryReservedItemsRequest body = null)

Allows to cancel a list of inventory reserved items associated to the specified owner. - {CancelInventoryReservedItemsRequest}

Allows to cancel a list of inventory reserved items associated to the specified owner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var ownerId = ownerId_example;  // string | The unique identifier of the order, order draft or cart (according to the owner type)
            var body = new CancelInventoryReservedItemsRequest(); // CancelInventoryReservedItemsRequest |  (optional) 

            try
            {
                // Allows to cancel a list of inventory reserved items associated to the specified owner. - {CancelInventoryReservedItemsRequest}
                apiInstance.CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPost(accept, ownerId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.CancelInventoryReservedItemsRequestreservationsOwnerIdcancelListPost: " + e.Message );
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
 **ownerId** | **string**| The unique identifier of the order, order draft or cart (according to the owner type) | 
 **body** | [**CancelInventoryReservedItemsRequest**](CancelInventoryReservedItemsRequest.md)|  | [optional] 

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

<a name="changeinventoryreserveditemsstockstatusrequestreservationsowneridchangestockstatuspost"></a>
# **ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPost**
> ChangeInventoryReservedItemsStockStatusResult ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPost (string accept, string ownerId, ChangeInventoryReservedItemsStockStatusRequest body = null)

Change the stock status of inventory reserved items from their current stock status to the new given stock status. - {ChangeInventoryReservedItemsStockStatusRequest}

Change the stock status of inventory reserved items from their current stock status to the new given stock status.Executing this request will only update the stock status of the specified reserved items. All corresponding order line items status will remain unchanged.The corresponding order must be reprocessed by using the PostProcessOrderRequest to get it's line items status updated with the new reserved stock status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var ownerId = ownerId_example;  // string | The unique identifier of the order, order draft or cart (according to the owner type)
            var body = new ChangeInventoryReservedItemsStockStatusRequest(); // ChangeInventoryReservedItemsStockStatusRequest |  (optional) 

            try
            {
                // Change the stock status of inventory reserved items from their current stock status to the new given stock status. - {ChangeInventoryReservedItemsStockStatusRequest}
                ChangeInventoryReservedItemsStockStatusResult result = apiInstance.ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPost(accept, ownerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.ChangeInventoryReservedItemsStockStatusRequestreservationsOwnerIdchangeStockStatusPost: " + e.Message );
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
 **ownerId** | **string**| The unique identifier of the order, order draft or cart (according to the owner type) | 
 **body** | [**ChangeInventoryReservedItemsStockStatusRequest**](ChangeInventoryReservedItemsStockStatusRequest.md)|  | [optional] 

### Return type

[**ChangeInventoryReservedItemsStockStatusResult**](ChangeInventoryReservedItemsStockStatusResult.md)

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

<a name="confirminventoryreservedorderitemsrequestreservationsowneridconfirmpost"></a>
# **ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPost**
> List&lt;InventoryReservedItem&gt; ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPost (string accept, string ownerId, ConfirmInventoryReservedOrderItemsRequest body = null)

Applies the reserved items on the available quantitites in the inventory, decrement the effective reservation and changes the status Confirmed. - {ConfirmInventoryReservedOrderItemsRequest}

Applies the reserved items on the available quantitites in the inventory, decrement the effective reservation and changes the status Confirmed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var ownerId = ownerId_example;  // string | The unique identifier of the order, order draft or cart (according to the owner type)
            var body = new ConfirmInventoryReservedOrderItemsRequest(); // ConfirmInventoryReservedOrderItemsRequest |  (optional) 

            try
            {
                // Applies the reserved items on the available quantitites in the inventory, decrement the effective reservation and changes the status Confirmed. - {ConfirmInventoryReservedOrderItemsRequest}
                List<InventoryReservedItem> result = apiInstance.ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPost(accept, ownerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.ConfirmInventoryReservedOrderItemsRequestreservationsOwnerIdconfirmPost: " + e.Message );
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
 **ownerId** | **string**| The unique identifier of the order, order draft or cart (according to the owner type) | 
 **body** | [**ConfirmInventoryReservedOrderItemsRequest**](ConfirmInventoryReservedOrderItemsRequest.md)|  | [optional] 

### Return type

[**List&lt;InventoryReservedItem&gt;**](InventoryReservedItem.md)

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

<a name="createorupdateinventoryitemrequestscopeidinventorylocationidskucreate"></a>
# **CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreate**
> InventoryItem CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreate (string accept, string scopeId, string inventoryLocationId, string sku, CreateOrUpdateInventoryItemRequest body = null)

Create or update an inventory item - {CreateOrUpdateInventoryItemRequest}

Create or update an inventory item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var inventoryLocationId = inventoryLocationId_example;  // string | The inventory location identifier used to identify the right inventory to update
            var sku = sku_example;  // string | The associated product sku
            var body = new CreateOrUpdateInventoryItemRequest(); // CreateOrUpdateInventoryItemRequest |  (optional) 

            try
            {
                // Create or update an inventory item - {CreateOrUpdateInventoryItemRequest}
                InventoryItem result = apiInstance.CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreate(accept, scopeId, inventoryLocationId, sku, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.CreateOrUpdateInventoryItemRequestScopeIdInventoryLocationIdSkuCreate: " + e.Message );
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
 **inventoryLocationId** | **string**| The inventory location identifier used to identify the right inventory to update | 
 **sku** | **string**| The associated product sku | 
 **body** | [**CreateOrUpdateInventoryItemRequest**](CreateOrUpdateInventoryItemRequest.md)|  | [optional] 

### Return type

[**InventoryItem**](InventoryItem.md)

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
| **404** | The inventory item was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="decreaseinventoryquantityrequestscopeidbyskuskubylocationinventorylocationiddecreasequantitypost"></a>
# **DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPost**
> InventoryQuantity DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPost (string accept, string scopeId, string sku, string inventoryLocationId, double quantity, Object body = null)

Decrease an inventory quantity - {DecreaseInventoryQuantityRequest}

Decrease an inventory quantity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | The associated product sku
            var inventoryLocationId = inventoryLocationId_example;  // string | The inventory location identifier used to identify the right inventory to update
            var quantity = 1.2D;  // double | The quantity to remove from the inventory
            var body = ;  // Object |  (optional) 

            try
            {
                // Decrease an inventory quantity - {DecreaseInventoryQuantityRequest}
                InventoryQuantity result = apiInstance.DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPost(accept, scopeId, sku, inventoryLocationId, quantity, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.DecreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIddecreaseQuantityPost: " + e.Message );
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
 **sku** | **string**| The associated product sku | 
 **inventoryLocationId** | **string**| The inventory location identifier used to identify the right inventory to update | 
 **quantity** | **double**| The quantity to remove from the inventory | 
 **body** | **Object**|  | [optional] 

### Return type

[**InventoryQuantity**](InventoryQuantity.md)

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
| **404** | The inventory quantity was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="evaluateinventoryavailabilityrequestreservationsowneridevaluatepost"></a>
# **EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePost**
> List&lt;InventoryItemAvailabilityEvaluationResult&gt; EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePost (string accept, string ownerId, EvaluateInventoryAvailabilityRequest body = null)

Allows to send requests to evaluate inventory item availability - {EvaluateInventoryAvailabilityRequest}

Allows to send requests to evaluate inventory item availability.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var ownerId = ownerId_example;  // string | The unique identifier of the order, order draft or cart (according to the owner type)
            var body = new EvaluateInventoryAvailabilityRequest(); // EvaluateInventoryAvailabilityRequest |  (optional) 

            try
            {
                // Allows to send requests to evaluate inventory item availability - {EvaluateInventoryAvailabilityRequest}
                List<InventoryItemAvailabilityEvaluationResult> result = apiInstance.EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePost(accept, ownerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.EvaluateInventoryAvailabilityRequestreservationsOwnerIdevaluatePost: " + e.Message );
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
 **ownerId** | **string**| The unique identifier of the order, order draft or cart (according to the owner type) | 
 **body** | [**EvaluateInventoryAvailabilityRequest**](EvaluateInventoryAvailabilityRequest.md)|  | [optional] 

### Return type

[**List&lt;InventoryItemAvailabilityEvaluationResult&gt;**](InventoryItemAvailabilityEvaluationResult.md)

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

<a name="findinventoryitemstatusbylocationandskusrequestscopeidbylocationinventorylocationidbyskusstatuspost"></a>
# **FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPost**
> List&lt;InventoryItemAvailability&gt; FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPost (string accept, string scopeId, string inventoryLocationId, FindInventoryItemStatusByLocationAndSkusRequest body = null)

Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date - {FindInventoryItemStatusByLocationAndSkusRequest}

Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var inventoryLocationId = inventoryLocationId_example;  // string | business id for the inventory location which will be associated to the Sku to retrieve InventoryItemStatus
            var body = new FindInventoryItemStatusByLocationAndSkusRequest(); // FindInventoryItemStatusByLocationAndSkusRequest |  (optional) 

            try
            {
                // Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date - {FindInventoryItemStatusByLocationAndSkusRequest}
                List<InventoryItemAvailability> result = apiInstance.FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPost(accept, scopeId, inventoryLocationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.FindInventoryItemStatusByLocationAndSkusRequestScopeIdbyLocationInventoryLocationIdbySkusstatusPost: " + e.Message );
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
 **inventoryLocationId** | **string**| business id for the inventory location which will be associated to the Sku to retrieve InventoryItemStatus | 
 **body** | [**FindInventoryItemStatusByLocationAndSkusRequest**](FindInventoryItemStatusByLocationAndSkusRequest.md)|  | [optional] 

### Return type

[**List&lt;InventoryItemAvailability&gt;**](InventoryItemAvailability.md)

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

<a name="findinventoryitemstatusbyskuandlocationrequestscopeidbyskuskubylocationinventorylocationidstatuspost"></a>
# **FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPost**
> InventoryItemAvailability FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPost (string accept, string scopeId, string sku, string inventoryLocationId, FindInventoryItemStatusBySkuAndLocationRequest body = null)

Retrieve the detail about the status of Inventory Item represented by the specified Sku and InventoryLocationId for the specified date - {FindInventoryItemStatusBySkuAndLocationRequest}

Retrieve the detail about the status of Inventory Item represented by the specified Sku and InventoryLocationId for the specified date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | Sku which will be associated to the InventoryLocationId to retrieve InventoryItemStatus
            var inventoryLocationId = inventoryLocationId_example;  // string | business id for the inventory location which will be associated to the Sku to retrieve InventoryItemStatus
            var body = new FindInventoryItemStatusBySkuAndLocationRequest(); // FindInventoryItemStatusBySkuAndLocationRequest |  (optional) 

            try
            {
                // Retrieve the detail about the status of Inventory Item represented by the specified Sku and InventoryLocationId for the specified date - {FindInventoryItemStatusBySkuAndLocationRequest}
                InventoryItemAvailability result = apiInstance.FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPost(accept, scopeId, sku, inventoryLocationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.FindInventoryItemStatusBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdstatusPost: " + e.Message );
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
 **sku** | **string**| Sku which will be associated to the InventoryLocationId to retrieve InventoryItemStatus | 
 **inventoryLocationId** | **string**| business id for the inventory location which will be associated to the Sku to retrieve InventoryItemStatus | 
 **body** | [**FindInventoryItemStatusBySkuAndLocationRequest**](FindInventoryItemStatusBySkuAndLocationRequest.md)|  | [optional] 

### Return type

[**InventoryItemAvailability**](InventoryItemAvailability.md)

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
| **404** | No inventory schedules was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinventoryitemsrequestscopeidfindpost"></a>
# **FindInventoryItemsRequestScopeIdfindPost**
> List&lt;InventoryItem&gt; FindInventoryItemsRequestScopeIdfindPost (string accept, string scopeId, FindInventoryItemsRequest body = null)

Retrieve a list of InventoryItem - {FindInventoryItemsRequest}

Retrieve a list of InventoryItem

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindInventoryItemsRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindInventoryItemsRequest(); // FindInventoryItemsRequest |  (optional) 

            try
            {
                // Retrieve a list of InventoryItem - {FindInventoryItemsRequest}
                List<InventoryItem> result = apiInstance.FindInventoryItemsRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.FindInventoryItemsRequestScopeIdfindPost: " + e.Message );
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
 **body** | [**FindInventoryItemsRequest**](FindInventoryItemsRequest.md)|  | [optional] 

### Return type

[**List&lt;InventoryItem&gt;**](InventoryItem.md)

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

<a name="findinventoryitemsstatusbyscopeandskurequestscopeidbyskuskustatuspost"></a>
# **FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPost**
> List&lt;InventoryItemAvailability&gt; FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPost (string accept, string scopeId, string sku, FindInventoryItemsStatusByScopeAndSkuRequest body = null)

Retrieve the detail about the status of Inventory Items represented by the specified Sku from all inventory location associated to the specific scope for the specified date - {FindInventoryItemsStatusByScopeAndSkuRequest}

Retrieve the detail about the status of Inventory Items represented by the specified Sku from all inventory location associated to the specific scope for the specified date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | Sku which will be associated to the InventoryLocationId to retrieve InventoryItem
            var body = new FindInventoryItemsStatusByScopeAndSkuRequest(); // FindInventoryItemsStatusByScopeAndSkuRequest |  (optional) 

            try
            {
                // Retrieve the detail about the status of Inventory Items represented by the specified Sku from all inventory location associated to the specific scope for the specified date - {FindInventoryItemsStatusByScopeAndSkuRequest}
                List<InventoryItemAvailability> result = apiInstance.FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPost(accept, scopeId, sku, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.FindInventoryItemsStatusByScopeAndSkuRequestScopeIdbySkuSkustatusPost: " + e.Message );
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
 **sku** | **string**| Sku which will be associated to the InventoryLocationId to retrieve InventoryItem | 
 **body** | [**FindInventoryItemsStatusByScopeAndSkuRequest**](FindInventoryItemsStatusByScopeAndSkuRequest.md)|  | [optional] 

### Return type

[**List&lt;InventoryItemAvailability&gt;**](InventoryItemAvailability.md)

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
| **404** | No inventory items status was found for this sku |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinventoryitemsstatusbyscopeandskusrequestscopeidbyskusstatuspost"></a>
# **FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPost**
> List&lt;InventoryItemAvailability&gt; FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPost (string accept, string scopeId, FindInventoryItemsStatusByScopeAndSkusRequest body = null)

Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date - {FindInventoryItemsStatusByScopeAndSkusRequest}

Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindInventoryItemsStatusByScopeAndSkusRequest(); // FindInventoryItemsStatusByScopeAndSkusRequest |  (optional) 

            try
            {
                // Retrieve the detail about the status of Inventory Items represented by the specified InventoryLocationId and a list of skus for the specified date - {FindInventoryItemsStatusByScopeAndSkusRequest}
                List<InventoryItemAvailability> result = apiInstance.FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.FindInventoryItemsStatusByScopeAndSkusRequestScopeIdbySkusstatusPost: " + e.Message );
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
 **body** | [**FindInventoryItemsStatusByScopeAndSkusRequest**](FindInventoryItemsStatusByScopeAndSkusRequest.md)|  | [optional] 

### Return type

[**List&lt;InventoryItemAvailability&gt;**](InventoryItemAvailability.md)

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

<a name="getinventoryitembyskuandlocationrequestscopeidbyskuskubylocationinventorylocationidget"></a>
# **GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGet**
> InventoryItemStatusDetails GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGet (string accept, string scopeId, string sku, string inventoryLocationId, DateTime? date = null)

Retrieve an InventoryItem represented by association of sku and location id - {GetInventoryItemBySkuAndLocationRequest}

Retrieve an InventoryItem represented by association of sku and location id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | Sku which will be associated to the InventoryLocationId to retrieve InventoryItem
            var inventoryLocationId = inventoryLocationId_example;  // string | business id for the inventory location which will be associated to the Sku to retrieve InventoryItem
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | The date for which the status will be computed. If is default, DateTime.Now will be used. (optional) 

            try
            {
                // Retrieve an InventoryItem represented by association of sku and location id - {GetInventoryItemBySkuAndLocationRequest}
                InventoryItemStatusDetails result = apiInstance.GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGet(accept, scopeId, sku, inventoryLocationId, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.GetInventoryItemBySkuAndLocationRequestScopeIdbySkuSkubyLocationInventoryLocationIdGet: " + e.Message );
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
 **sku** | **string**| Sku which will be associated to the InventoryLocationId to retrieve InventoryItem | 
 **inventoryLocationId** | **string**| business id for the inventory location which will be associated to the Sku to retrieve InventoryItem | 
 **date** | **DateTime?**| The date for which the status will be computed. If is default, DateTime.Now will be used. | [optional] 

### Return type

[**InventoryItemStatusDetails**](InventoryItemStatusDetails.md)

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
| **404** | No inventory schedules was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryitemsbylocationrequestscopeidbylocationinventorylocationidget"></a>
# **GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGet**
> List&lt;InventoryItem&gt; GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGet (string accept, string scopeId, string inventoryLocationId)

Retrieve a list of InventoryItem represented by inventory location id - {GetInventoryItemsByLocationRequest}

Retrieve a list of InventoryItem represented by inventory location id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var inventoryLocationId = inventoryLocationId_example;  // string | business id for the inventory location which will be associated to the Sku to retrieve InventoryItem

            try
            {
                // Retrieve a list of InventoryItem represented by inventory location id - {GetInventoryItemsByLocationRequest}
                List<InventoryItem> result = apiInstance.GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGet(accept, scopeId, inventoryLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.GetInventoryItemsByLocationRequestScopeIdbyLocationInventoryLocationIdGet: " + e.Message );
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

### Return type

[**List&lt;InventoryItem&gt;**](InventoryItem.md)

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

<a name="getinventoryitemsbyscopeandskurequestscopeidbyskuskuget"></a>
# **GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGet**
> InventoryItemStatusDetailsQueryResult GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGet (string accept, string scopeId, string sku, bool? includeChildScopes = null, int? startingIndex = null, int? maximumItems = null, string sortOrderField = null, string sortDirection = null, DateTime? date = null)

Retrieve a list of InventoryItemStatusDetails represented by sku from all inventory location associated to the specific scope - {GetInventoryItemsByScopeAndSkuRequest}

Retrieve a list of InventoryItemStatusDetails represented by sku from all inventory location associated to the specific scope. The list of inventory location ids is all existing Fulfillment Locations inside the specific Scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | Sku which will be associated to the InventoryLocationId to retrieve InventoryItem
            var includeChildScopes = true;  // bool? | Whether inventory locations from child scopes should also be included in the results. (optional) 
            var startingIndex = 56;  // int? | The starting index (optional) 
            var maximumItems = 56;  // int? | The maximum items returned by the search query, default to 50 (optional) 
            var sortOrderField = sortOrderField_example;  // string | the sort order field. (optional) 
            var sortDirection = sortDirection_example;  // string | The sort direction. (Ascending or descending) (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | The date which will be used to compute the status. If is not set, DateTime.Now will be used. (optional) 

            try
            {
                // Retrieve a list of InventoryItemStatusDetails represented by sku from all inventory location associated to the specific scope - {GetInventoryItemsByScopeAndSkuRequest}
                InventoryItemStatusDetailsQueryResult result = apiInstance.GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGet(accept, scopeId, sku, includeChildScopes, startingIndex, maximumItems, sortOrderField, sortDirection, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.GetInventoryItemsByScopeAndSkuRequestScopeIdbySkuSkuGet: " + e.Message );
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
 **sku** | **string**| Sku which will be associated to the InventoryLocationId to retrieve InventoryItem | 
 **includeChildScopes** | **bool?**| Whether inventory locations from child scopes should also be included in the results. | [optional] 
 **startingIndex** | **int?**| The starting index | [optional] 
 **maximumItems** | **int?**| The maximum items returned by the search query, default to 50 | [optional] 
 **sortOrderField** | **string**| the sort order field. | [optional] 
 **sortDirection** | **string**| The sort direction. (Ascending or descending) | [optional] 
 **date** | **DateTime?**| The date which will be used to compute the status. If is not set, DateTime.Now will be used. | [optional] 

### Return type

[**InventoryItemStatusDetailsQueryResult**](InventoryItemStatusDetailsQueryResult.md)

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
| **404** | No inventory items was found for this sku |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryitemsbyscopeandskusrequestscopeidbyskuspost"></a>
# **GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPost**
> InventoryItemStatusDetailsQueryResult GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPost (string accept, string scopeId, GetInventoryItemsByScopeAndSkusRequest body = null)

Retrieve a list of InventoryItemStatusDetails represented by SKUs from all inventory location associated to the specific scope - {GetInventoryItemsByScopeAndSkusRequest}

Retrieve a list of InventoryItemStatusDetails represented by SKUs from all inventory location associated to the specific scope. The list of inventory location ids is all existing Fulfillment Locations inside the specific Scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetInventoryItemsByScopeAndSkusRequest(); // GetInventoryItemsByScopeAndSkusRequest |  (optional) 

            try
            {
                // Retrieve a list of InventoryItemStatusDetails represented by SKUs from all inventory location associated to the specific scope - {GetInventoryItemsByScopeAndSkusRequest}
                InventoryItemStatusDetailsQueryResult result = apiInstance.GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.GetInventoryItemsByScopeAndSkusRequestScopeIdbySkusPost: " + e.Message );
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
 **body** | [**GetInventoryItemsByScopeAndSkusRequest**](GetInventoryItemsByScopeAndSkusRequest.md)|  | [optional] 

### Return type

[**InventoryItemStatusDetailsQueryResult**](InventoryItemStatusDetailsQueryResult.md)

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
| **404** | No inventory items was found for given SKUs |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryprovidersrequestscopeidfindprovidersget"></a>
# **GetInventoryProvidersRequestScopeIdfindProvidersGet**
> List&lt;InventoryProviderDetails&gt; GetInventoryProvidersRequestScopeIdfindProvidersGet (string accept, string scopeId, string cultureName = null)

Retrieves all available inventory providers - {GetInventoryProvidersRequest}

Finds all available inventory providers available in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryProvidersRequestScopeIdfindProvidersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture name in which language that data will be returned (optional) 

            try
            {
                // Retrieves all available inventory providers - {GetInventoryProvidersRequest}
                List<InventoryProviderDetails> result = apiInstance.GetInventoryProvidersRequestScopeIdfindProvidersGet(accept, scopeId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.GetInventoryProvidersRequestScopeIdfindProvidersGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language that data will be returned | [optional] 

### Return type

[**List&lt;InventoryProviderDetails&gt;**](InventoryProviderDetails.md)

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
| **404** | No inventory providers was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryreserveditemsrequestreservationsowneridget"></a>
# **GetInventoryReservedItemsRequestreservationsOwnerIdGet**
> List&lt;InventoryReservedItem&gt; GetInventoryReservedItemsRequestreservationsOwnerIdGet (string accept, string ownerId)

Find all reserved inventory items associated to the specified owner - {GetInventoryReservedItemsRequest}

Find all reserved inventory items associated to the specified owner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetInventoryReservedItemsRequestreservationsOwnerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var ownerId = ownerId_example;  // string | The unique identifier of the order, order draft or cart (according to the owner type)

            try
            {
                // Find all reserved inventory items associated to the specified owner - {GetInventoryReservedItemsRequest}
                List<InventoryReservedItem> result = apiInstance.GetInventoryReservedItemsRequestreservationsOwnerIdGet(accept, ownerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.GetInventoryReservedItemsRequestreservationsOwnerIdGet: " + e.Message );
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
 **ownerId** | **string**| The unique identifier of the order, order draft or cart (according to the owner type) | 

### Return type

[**List&lt;InventoryReservedItem&gt;**](InventoryReservedItem.md)

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

<a name="increaseinventoryquantityrequestscopeidbyskuskubylocationinventorylocationidincreasequantitypost"></a>
# **IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPost**
> InventoryQuantity IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPost (string accept, string scopeId, string sku, string inventoryLocationId, double quantity, Object body = null)

Increase an inventory quantity - {IncreaseInventoryQuantityRequest}

Increase an inventory quantity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | The associated product sku
            var inventoryLocationId = inventoryLocationId_example;  // string | The inventory location identifier used to identify the right inventory to update
            var quantity = 1.2D;  // double | The quantity to add in the inventory
            var body = ;  // Object |  (optional) 

            try
            {
                // Increase an inventory quantity - {IncreaseInventoryQuantityRequest}
                InventoryQuantity result = apiInstance.IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPost(accept, scopeId, sku, inventoryLocationId, quantity, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.IncreaseInventoryQuantityRequestScopeIdbySkuSkubyLocationInventoryLocationIdincreaseQuantityPost: " + e.Message );
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
 **sku** | **string**| The associated product sku | 
 **inventoryLocationId** | **string**| The inventory location identifier used to identify the right inventory to update | 
 **quantity** | **double**| The quantity to add in the inventory | 
 **body** | **Object**|  | [optional] 

### Return type

[**InventoryQuantity**](InventoryQuantity.md)

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
| **404** | The inventory quantity was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reserveinventoryitemsrequestreservationsowneridpost"></a>
# **ReserveInventoryItemsRequestreservationsOwnerIdPost**
> InventoryReservationResult ReserveInventoryItemsRequestreservationsOwnerIdPost (string accept, string ownerId, ReserveInventoryItemsRequest body = null)

Allows to send requests to reserve a list of inventory items - {ReserveInventoryItemsRequest}

Allows to send requests to reserve a list of inventory items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ReserveInventoryItemsRequestreservationsOwnerIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new InventoryItemsApi(config);
            var accept = accept_example;  // string | Accept Header
            var ownerId = ownerId_example;  // string | The unique identifier of the order, order draft or cart (according to the owner type)
            var body = new ReserveInventoryItemsRequest(); // ReserveInventoryItemsRequest |  (optional) 

            try
            {
                // Allows to send requests to reserve a list of inventory items - {ReserveInventoryItemsRequest}
                InventoryReservationResult result = apiInstance.ReserveInventoryItemsRequestreservationsOwnerIdPost(accept, ownerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryItemsApi.ReserveInventoryItemsRequestreservationsOwnerIdPost: " + e.Message );
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
 **ownerId** | **string**| The unique identifier of the order, order draft or cart (according to the owner type) | 
 **body** | [**ReserveInventoryItemsRequest**](ReserveInventoryItemsRequest.md)|  | [optional] 

### Return type

[**InventoryReservationResult**](InventoryReservationResult.md)

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

