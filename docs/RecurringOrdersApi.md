# Yaksa.OrckestraCommerce.Client.Api.RecurringOrdersApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrUpdateRecurringOrderLineItemsRequestScopeIdlineItemsforCustomerCustomerIdCreate**](RecurringOrdersApi.md#addorupdaterecurringorderlineitemsrequestscopeidlineitemsforcustomercustomeridcreate) | **PUT** /recurringOrders/{ScopeId}/lineItems/forCustomer/{CustomerId} | Add or update a list of recurring order line items - {AddOrUpdateRecurringOrderLineItemsRequest}
[**CreateRecurringOrderProgramRequestprogramsPost**](RecurringOrdersApi.md#createrecurringorderprogramrequestprogramspost) | **POST** /recurringOrders/programs | Create a new recurring order program - {CreateRecurringOrderProgramRequest}
[**DeleteRecurringCartLineItemsRequestScopeIdcartsCustomerIdlineItemsDelete**](RecurringOrdersApi.md#deleterecurringcartlineitemsrequestscopeidcartscustomeridlineitemsdelete) | **DELETE** /recurringOrders/{ScopeId}/carts/{CustomerId}/lineItems | Delete line items from a recurring cart - {DeleteRecurringCartLineItemsRequest}
[**DeleteRecurringOrderLineItemsRequestScopeIdCustomerIdlineItemsDelete**](RecurringOrdersApi.md#deleterecurringorderlineitemsrequestscopeidcustomeridlineitemsdelete) | **DELETE** /recurringOrders/{ScopeId}/{CustomerId}/lineItems | Delete a recurring order line item - {DeleteRecurringOrderLineItemsRequest}
[**DeleteRecurringOrderProgramRequestprogramsRecurringOrderProgramNameDelete**](RecurringOrdersApi.md#deleterecurringorderprogramrequestprogramsrecurringorderprogramnamedelete) | **DELETE** /recurringOrders/programs/{RecurringOrderProgramName} | Delete a new recurring order program - {DeleteRecurringOrderProgramRequest}
[**GetRecurringOrderLineItemRequestScopeIdlineItemsRecurringOrderLineItemIdGet**](RecurringOrdersApi.md#getrecurringorderlineitemrequestscopeidlineitemsrecurringorderlineitemidget) | **GET** /recurringOrders/{ScopeId}/lineItems/{RecurringOrderLineItemId} | Get a recurring order line item - {GetRecurringOrderLineItemRequest}
[**GetRecurringOrderLineItemsForCustomerRequestScopeIdlineItemsbyCustomerCustomerIdGet**](RecurringOrdersApi.md#getrecurringorderlineitemsforcustomerrequestscopeidlineitemsbycustomercustomeridget) | **GET** /recurringOrders/{ScopeId}/lineItems/byCustomer/{CustomerId} | Get the recurring order line items for a customer - {GetRecurringOrderLineItemsForCustomerRequest}
[**GetRecurringOrderProgramRequestprogramsRecurringOrderProgramNameGet**](RecurringOrdersApi.md#getrecurringorderprogramrequestprogramsrecurringorderprogramnameget) | **GET** /recurringOrders/programs/{RecurringOrderProgramName} | Get a recurring order program - {GetRecurringOrderProgramRequest}
[**GetRecurringOrderProgramsByScopeIdRequestprogramsbyScopeScopeIdGet**](RecurringOrdersApi.md#getrecurringorderprogramsbyscopeidrequestprogramsbyscopescopeidget) | **GET** /recurringOrders/programs/byScope/{ScopeId} | Get the recurring order programs associated to a scope - {GetRecurringOrderProgramsByScopeIdRequest}
[**RescheduleRecurringCartRequestScopeIdcartCartNamerescheduleCreate**](RecurringOrdersApi.md#reschedulerecurringcartrequestscopeidcartcartnamereschedulecreate) | **PUT** /recurringOrders/{ScopeId}/cart/{CartName}/reschedule | Reschedule the recurring order line items present in a recurring cart - {RescheduleRecurringCartRequest}
[**UpdateRecurringOrderProgramRequestprogramsRecurringOrderProgramNameCreate**](RecurringOrdersApi.md#updaterecurringorderprogramrequestprogramsrecurringorderprogramnamecreate) | **PUT** /recurringOrders/programs/{RecurringOrderProgramName} | Update a recurring order program - {UpdateRecurringOrderProgramRequest}


<a name="addorupdaterecurringorderlineitemsrequestscopeidlineitemsforcustomercustomeridcreate"></a>
# **AddOrUpdateRecurringOrderLineItemsRequestScopeIdlineItemsforCustomerCustomerIdCreate**
> ListOfRecurringOrderLineItems AddOrUpdateRecurringOrderLineItemsRequestScopeIdlineItemsforCustomerCustomerIdCreate (string accept, string scopeId, string customerId, AddOrUpdateRecurringOrderLineItemsRequest body = null)

Add or update a list of recurring order line items - {AddOrUpdateRecurringOrderLineItemsRequest}

Add or update a list of recurring order line items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateRecurringOrderLineItemsRequestScopeIdlineItemsforCustomerCustomerIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope of the recurring order line item
            var customerId = customerId_example;  // string | The customer id of the recurring order line items
            var body = new AddOrUpdateRecurringOrderLineItemsRequest(); // AddOrUpdateRecurringOrderLineItemsRequest |  (optional) 

            try
            {
                // Add or update a list of recurring order line items - {AddOrUpdateRecurringOrderLineItemsRequest}
                ListOfRecurringOrderLineItems result = apiInstance.AddOrUpdateRecurringOrderLineItemsRequestScopeIdlineItemsforCustomerCustomerIdCreate(accept, scopeId, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.AddOrUpdateRecurringOrderLineItemsRequestScopeIdlineItemsforCustomerCustomerIdCreate: " + e.Message );
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
 **scopeId** | **string**| The scope of the recurring order line item | 
 **customerId** | **string**| The customer id of the recurring order line items | 
 **body** | [**AddOrUpdateRecurringOrderLineItemsRequest**](AddOrUpdateRecurringOrderLineItemsRequest.md)|  | [optional] 

### Return type

[**ListOfRecurringOrderLineItems**](ListOfRecurringOrderLineItems.md)

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

<a name="createrecurringorderprogramrequestprogramspost"></a>
# **CreateRecurringOrderProgramRequestprogramsPost**
> RecurringOrderProgram CreateRecurringOrderProgramRequestprogramsPost (string accept, CreateRecurringOrderProgramRequest body = null)

Create a new recurring order program - {CreateRecurringOrderProgramRequest}

Create a new recurring order program

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateRecurringOrderProgramRequestprogramsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new CreateRecurringOrderProgramRequest(); // CreateRecurringOrderProgramRequest |  (optional) 

            try
            {
                // Create a new recurring order program - {CreateRecurringOrderProgramRequest}
                RecurringOrderProgram result = apiInstance.CreateRecurringOrderProgramRequestprogramsPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.CreateRecurringOrderProgramRequestprogramsPost: " + e.Message );
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
 **body** | [**CreateRecurringOrderProgramRequest**](CreateRecurringOrderProgramRequest.md)|  | [optional] 

### Return type

[**RecurringOrderProgram**](RecurringOrderProgram.md)

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

<a name="deleterecurringcartlineitemsrequestscopeidcartscustomeridlineitemsdelete"></a>
# **DeleteRecurringCartLineItemsRequestScopeIdcartsCustomerIdlineItemsDelete**
> void DeleteRecurringCartLineItemsRequestScopeIdcartsCustomerIdlineItemsDelete (string accept, string scopeId, string customerId, List<string> lineItemIds)

Delete line items from a recurring cart - {DeleteRecurringCartLineItemsRequest}

Delete line items from a recurring cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteRecurringCartLineItemsRequestScopeIdcartsCustomerIdlineItemsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope of the RecurringOrderLineItems to delete
            var customerId = customerId_example;  // string | The customer id of the recurring order line items
            var lineItemIds = new List<string>(); // List<string> | The list of line item ids to delete

            try
            {
                // Delete line items from a recurring cart - {DeleteRecurringCartLineItemsRequest}
                apiInstance.DeleteRecurringCartLineItemsRequestScopeIdcartsCustomerIdlineItemsDelete(accept, scopeId, customerId, lineItemIds);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.DeleteRecurringCartLineItemsRequestScopeIdcartsCustomerIdlineItemsDelete: " + e.Message );
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
 **scopeId** | **string**| The scope of the RecurringOrderLineItems to delete | 
 **customerId** | **string**| The customer id of the recurring order line items | 
 **lineItemIds** | [**List&lt;string&gt;**](string.md)| The list of line item ids to delete | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterecurringorderlineitemsrequestscopeidcustomeridlineitemsdelete"></a>
# **DeleteRecurringOrderLineItemsRequestScopeIdCustomerIdlineItemsDelete**
> void DeleteRecurringOrderLineItemsRequestScopeIdCustomerIdlineItemsDelete (string accept, string scopeId, string customerId, List<string> recurringOrderLineItemIds)

Delete a recurring order line item - {DeleteRecurringOrderLineItemsRequest}

Delete a recurring order line item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteRecurringOrderLineItemsRequestScopeIdCustomerIdlineItemsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope of the RecurringOrderLineItems to delete
            var customerId = customerId_example;  // string | The customer id of the recurring order line items to delete
            var recurringOrderLineItemIds = new List<string>(); // List<string> | The list of recurring order line item ids to delete

            try
            {
                // Delete a recurring order line item - {DeleteRecurringOrderLineItemsRequest}
                apiInstance.DeleteRecurringOrderLineItemsRequestScopeIdCustomerIdlineItemsDelete(accept, scopeId, customerId, recurringOrderLineItemIds);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.DeleteRecurringOrderLineItemsRequestScopeIdCustomerIdlineItemsDelete: " + e.Message );
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
 **scopeId** | **string**| The scope of the RecurringOrderLineItems to delete | 
 **customerId** | **string**| The customer id of the recurring order line items to delete | 
 **recurringOrderLineItemIds** | [**List&lt;string&gt;**](string.md)| The list of recurring order line item ids to delete | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterecurringorderprogramrequestprogramsrecurringorderprogramnamedelete"></a>
# **DeleteRecurringOrderProgramRequestprogramsRecurringOrderProgramNameDelete**
> void DeleteRecurringOrderProgramRequestprogramsRecurringOrderProgramNameDelete (string accept, string recurringOrderProgramName)

Delete a new recurring order program - {DeleteRecurringOrderProgramRequest}

Delete a new recurring order program

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteRecurringOrderProgramRequestprogramsRecurringOrderProgramNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var recurringOrderProgramName = recurringOrderProgramName_example;  // string | The unique identifier of the recurring order program to delete

            try
            {
                // Delete a new recurring order program - {DeleteRecurringOrderProgramRequest}
                apiInstance.DeleteRecurringOrderProgramRequestprogramsRecurringOrderProgramNameDelete(accept, recurringOrderProgramName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.DeleteRecurringOrderProgramRequestprogramsRecurringOrderProgramNameDelete: " + e.Message );
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
 **recurringOrderProgramName** | **string**| The unique identifier of the recurring order program to delete | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecurringorderlineitemrequestscopeidlineitemsrecurringorderlineitemidget"></a>
# **GetRecurringOrderLineItemRequestScopeIdlineItemsRecurringOrderLineItemIdGet**
> RecurringOrderLineItem GetRecurringOrderLineItemRequestScopeIdlineItemsRecurringOrderLineItemIdGet (string accept, string scopeId, string recurringOrderLineItemId)

Get a recurring order line item - {GetRecurringOrderLineItemRequest}

Get a recurring order line item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRecurringOrderLineItemRequestScopeIdlineItemsRecurringOrderLineItemIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope of the RecurringOrderLineItem to get
            var recurringOrderLineItemId = recurringOrderLineItemId_example;  // string | The recurring order line item id

            try
            {
                // Get a recurring order line item - {GetRecurringOrderLineItemRequest}
                RecurringOrderLineItem result = apiInstance.GetRecurringOrderLineItemRequestScopeIdlineItemsRecurringOrderLineItemIdGet(accept, scopeId, recurringOrderLineItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.GetRecurringOrderLineItemRequestScopeIdlineItemsRecurringOrderLineItemIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope of the RecurringOrderLineItem to get | 
 **recurringOrderLineItemId** | **string**| The recurring order line item id | 

### Return type

[**RecurringOrderLineItem**](RecurringOrderLineItem.md)

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

<a name="getrecurringorderlineitemsforcustomerrequestscopeidlineitemsbycustomercustomeridget"></a>
# **GetRecurringOrderLineItemsForCustomerRequestScopeIdlineItemsbyCustomerCustomerIdGet**
> ListOfRecurringOrderLineItems GetRecurringOrderLineItemsForCustomerRequestScopeIdlineItemsbyCustomerCustomerIdGet (string accept, string scopeId, string customerId)

Get the recurring order line items for a customer - {GetRecurringOrderLineItemsForCustomerRequest}

Get the recurring order line items for a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRecurringOrderLineItemsForCustomerRequestScopeIdlineItemsbyCustomerCustomerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope of the RecurringOrderLineItems to get
            var customerId = customerId_example;  // string | The customer id of the RecurringOrderLineItems to get

            try
            {
                // Get the recurring order line items for a customer - {GetRecurringOrderLineItemsForCustomerRequest}
                ListOfRecurringOrderLineItems result = apiInstance.GetRecurringOrderLineItemsForCustomerRequestScopeIdlineItemsbyCustomerCustomerIdGet(accept, scopeId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.GetRecurringOrderLineItemsForCustomerRequestScopeIdlineItemsbyCustomerCustomerIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope of the RecurringOrderLineItems to get | 
 **customerId** | **string**| The customer id of the RecurringOrderLineItems to get | 

### Return type

[**ListOfRecurringOrderLineItems**](ListOfRecurringOrderLineItems.md)

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

<a name="getrecurringorderprogramrequestprogramsrecurringorderprogramnameget"></a>
# **GetRecurringOrderProgramRequestprogramsRecurringOrderProgramNameGet**
> RecurringOrderProgram GetRecurringOrderProgramRequestprogramsRecurringOrderProgramNameGet (string accept, string recurringOrderProgramName)

Get a recurring order program - {GetRecurringOrderProgramRequest}

Get a recurring order program

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRecurringOrderProgramRequestprogramsRecurringOrderProgramNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var recurringOrderProgramName = recurringOrderProgramName_example;  // string | The unique identifier of the recurring order program to get

            try
            {
                // Get a recurring order program - {GetRecurringOrderProgramRequest}
                RecurringOrderProgram result = apiInstance.GetRecurringOrderProgramRequestprogramsRecurringOrderProgramNameGet(accept, recurringOrderProgramName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.GetRecurringOrderProgramRequestprogramsRecurringOrderProgramNameGet: " + e.Message );
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
 **recurringOrderProgramName** | **string**| The unique identifier of the recurring order program to get | 

### Return type

[**RecurringOrderProgram**](RecurringOrderProgram.md)

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

<a name="getrecurringorderprogramsbyscopeidrequestprogramsbyscopescopeidget"></a>
# **GetRecurringOrderProgramsByScopeIdRequestprogramsbyScopeScopeIdGet**
> ListOfRecurringOrderPrograms GetRecurringOrderProgramsByScopeIdRequestprogramsbyScopeScopeIdGet (string accept, string scopeId)

Get the recurring order programs associated to a scope - {GetRecurringOrderProgramsByScopeIdRequest}

Get the recurring order programs associated to a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRecurringOrderProgramsByScopeIdRequestprogramsbyScopeScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope of the recurring order programs to get

            try
            {
                // Get the recurring order programs associated to a scope - {GetRecurringOrderProgramsByScopeIdRequest}
                ListOfRecurringOrderPrograms result = apiInstance.GetRecurringOrderProgramsByScopeIdRequestprogramsbyScopeScopeIdGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.GetRecurringOrderProgramsByScopeIdRequestprogramsbyScopeScopeIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope of the recurring order programs to get | 

### Return type

[**ListOfRecurringOrderPrograms**](ListOfRecurringOrderPrograms.md)

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

<a name="reschedulerecurringcartrequestscopeidcartcartnamereschedulecreate"></a>
# **RescheduleRecurringCartRequestScopeIdcartCartNamerescheduleCreate**
> ListOfRecurringOrderLineItems RescheduleRecurringCartRequestScopeIdcartCartNamerescheduleCreate (string accept, string scopeId, string cartName, RescheduleRecurringCartRequest body = null)

Reschedule the recurring order line items present in a recurring cart - {RescheduleRecurringCartRequest}

Reschedule the recurring order line items present in a recurring cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RescheduleRecurringCartRequestScopeIdcartCartNamerescheduleCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope
            var cartName = cartName_example;  // string | The name of the cart
            var body = new RescheduleRecurringCartRequest(); // RescheduleRecurringCartRequest |  (optional) 

            try
            {
                // Reschedule the recurring order line items present in a recurring cart - {RescheduleRecurringCartRequest}
                ListOfRecurringOrderLineItems result = apiInstance.RescheduleRecurringCartRequestScopeIdcartCartNamerescheduleCreate(accept, scopeId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.RescheduleRecurringCartRequestScopeIdcartCartNamerescheduleCreate: " + e.Message );
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
 **scopeId** | **string**| The scope | 
 **cartName** | **string**| The name of the cart | 
 **body** | [**RescheduleRecurringCartRequest**](RescheduleRecurringCartRequest.md)|  | [optional] 

### Return type

[**ListOfRecurringOrderLineItems**](ListOfRecurringOrderLineItems.md)

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

<a name="updaterecurringorderprogramrequestprogramsrecurringorderprogramnamecreate"></a>
# **UpdateRecurringOrderProgramRequestprogramsRecurringOrderProgramNameCreate**
> RecurringOrderProgram UpdateRecurringOrderProgramRequestprogramsRecurringOrderProgramNameCreate (string accept, string recurringOrderProgramName, UpdateRecurringOrderProgramRequest body = null)

Update a recurring order program - {UpdateRecurringOrderProgramRequest}

Update a recurring order program

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateRecurringOrderProgramRequestprogramsRecurringOrderProgramNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RecurringOrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var recurringOrderProgramName = recurringOrderProgramName_example;  // string | The name and unique identifier of the recurring order program
            var body = new UpdateRecurringOrderProgramRequest(); // UpdateRecurringOrderProgramRequest |  (optional) 

            try
            {
                // Update a recurring order program - {UpdateRecurringOrderProgramRequest}
                RecurringOrderProgram result = apiInstance.UpdateRecurringOrderProgramRequestprogramsRecurringOrderProgramNameCreate(accept, recurringOrderProgramName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurringOrdersApi.UpdateRecurringOrderProgramRequestprogramsRecurringOrderProgramNameCreate: " + e.Message );
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
 **recurringOrderProgramName** | **string**| The name and unique identifier of the recurring order program | 
 **body** | [**UpdateRecurringOrderProgramRequest**](UpdateRecurringOrderProgramRequest.md)|  | [optional] 

### Return type

[**RecurringOrderProgram**](RecurringOrderProgram.md)

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

