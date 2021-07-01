# Yaksa.OrckestraCommerce.Client.Api.IntegrationApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportOrderSchemaRequestordersschemaexportPost**](IntegrationApi.md#exportorderschemarequestordersschemaexportpost) | **POST** /integration/orders/schema/export | Export order schema to a file that will be stored in the blob - {ExportOrderSchemaRequest}
[**ExportProductPricesRequestproductsScopeIdpricesexportPost**](IntegrationApi.md#exportproductpricesrequestproductsscopeidpricesexportpost) | **POST** /integration/products/{ScopeId}/prices/export | Exports a set of product prices - {ExportProductPricesRequest}
[**ExportProductsRequestproductsScopeIdexportPost**](IntegrationApi.md#exportproductsrequestproductsscopeidexportpost) | **POST** /integration/products/{ScopeId}/export | Export Metadatas, Products, Prices, Categories and RelationShips - {ExportProductsRequest}
[**ExportProfileSchemaRequestprofilesschemaexportPost**](IntegrationApi.md#exportprofileschemarequestprofilesschemaexportpost) | **POST** /integration/profiles/schema/export | Export the profile system schema - {ExportProfileSchemaRequest}
[**ExportProfilesRequestprofilesexportPost**](IntegrationApi.md#exportprofilesrequestprofilesexportpost) | **POST** /integration/profiles/export | Export the profile system data - {ExportProfilesRequest}
[**ImportInventoryItemsRequestinventoryItemsimportPost**](IntegrationApi.md#importinventoryitemsrequestinventoryitemsimportpost) | **POST** /integration/inventoryItems/import | Import inventory items from a set of files - {ImportInventoryItemsRequest}
[**ImportOrderSchemaRequestordersschemaimportPost**](IntegrationApi.md#importorderschemarequestordersschemaimportpost) | **POST** /integration/orders/schema/import | Import order schema from file - {ImportOrderSchemaRequest}
[**ImportOrdersRequestordersimportPost**](IntegrationApi.md#importordersrequestordersimportpost) | **POST** /integration/orders/import | Import Orders and their&#39;s sub-elements :  Payments Shipments, LineItems, Taxes, Addresses, Order history, Notes, Additional fees, Discounts and coupons - {ImportOrdersRequest}
[**ImportProductsPricesRequestproductsScopeIdpricesimportPost**](IntegrationApi.md#importproductspricesrequestproductsscopeidpricesimportpost) | **POST** /integration/products/{ScopeId}/prices/import | Requests that a products prices import be started asynchronously. - {ImportProductsPricesRequest}
[**ImportProductsRequestproductsScopeIdimportPost**](IntegrationApi.md#importproductsrequestproductsscopeidimportpost) | **POST** /integration/products/{ScopeId}/import | Import Metadatas, Products, Prices, Categories and RelationShips - {ImportProductsRequest}
[**ImportProfileSchemaRequestprofilesschemaimportPost**](IntegrationApi.md#importprofileschemarequestprofilesschemaimportpost) | **POST** /integration/profiles/schema/import | Import the profile system schema - {ImportProfileSchemaRequest}
[**ImportProfilesRequestprofilesimportPost**](IntegrationApi.md#importprofilesrequestprofilesimportpost) | **POST** /integration/profiles/import | Import/Sync the profile system data - {ImportProfilesRequest}


<a name="exportorderschemarequestordersschemaexportpost"></a>
# **ExportOrderSchemaRequestordersschemaexportPost**
> TaskInfo ExportOrderSchemaRequestordersschemaexportPost (string accept, ExportOrderSchemaRequest body = null)

Export order schema to a file that will be stored in the blob - {ExportOrderSchemaRequest}

Export order schema to a file that will be stored in the blob

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportOrderSchemaRequestordersschemaexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ExportOrderSchemaRequest(); // ExportOrderSchemaRequest |  (optional) 

            try
            {
                // Export order schema to a file that will be stored in the blob - {ExportOrderSchemaRequest}
                TaskInfo result = apiInstance.ExportOrderSchemaRequestordersschemaexportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ExportOrderSchemaRequestordersschemaexportPost: " + e.Message );
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
 **body** | [**ExportOrderSchemaRequest**](ExportOrderSchemaRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportproductpricesrequestproductsscopeidpricesexportpost"></a>
# **ExportProductPricesRequestproductsScopeIdpricesexportPost**
> List&lt;ProductPriceExportInfo&gt; ExportProductPricesRequestproductsScopeIdpricesexportPost (string accept, string scopeId, ExportProductPricesRequest body = null)

Exports a set of product prices - {ExportProductPricesRequest}

Exports a set of product prices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportProductPricesRequestproductsScopeIdpricesexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new ExportProductPricesRequest(); // ExportProductPricesRequest |  (optional) 

            try
            {
                // Exports a set of product prices - {ExportProductPricesRequest}
                List<ProductPriceExportInfo> result = apiInstance.ExportProductPricesRequestproductsScopeIdpricesexportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ExportProductPricesRequestproductsScopeIdpricesexportPost: " + e.Message );
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
 **body** | [**ExportProductPricesRequest**](ExportProductPricesRequest.md)|  | [optional] 

### Return type

[**List&lt;ProductPriceExportInfo&gt;**](ProductPriceExportInfo.md)

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

<a name="exportproductsrequestproductsscopeidexportpost"></a>
# **ExportProductsRequestproductsScopeIdexportPost**
> TaskInfo ExportProductsRequestproductsScopeIdexportPost (string accept, string scopeId, ExportProductsRequest body = null)

Export Metadatas, Products, Prices, Categories and RelationShips - {ExportProductsRequest}

Export Metadatas, Products, Prices, Categories and RelationShips

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportProductsRequestproductsScopeIdexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ExportProductsRequest(); // ExportProductsRequest |  (optional) 

            try
            {
                // Export Metadatas, Products, Prices, Categories and RelationShips - {ExportProductsRequest}
                TaskInfo result = apiInstance.ExportProductsRequestproductsScopeIdexportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ExportProductsRequestproductsScopeIdexportPost: " + e.Message );
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
 **scopeId** | **string**| The scope. | 
 **body** | [**ExportProductsRequest**](ExportProductsRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportprofileschemarequestprofilesschemaexportpost"></a>
# **ExportProfileSchemaRequestprofilesschemaexportPost**
> TaskInfo ExportProfileSchemaRequestprofilesschemaexportPost (string accept, ExportProfileSchemaRequest body = null)

Export the profile system schema - {ExportProfileSchemaRequest}

Export the profile system schema. Return the task information for the started durable task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportProfileSchemaRequestprofilesschemaexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ExportProfileSchemaRequest(); // ExportProfileSchemaRequest |  (optional) 

            try
            {
                // Export the profile system schema - {ExportProfileSchemaRequest}
                TaskInfo result = apiInstance.ExportProfileSchemaRequestprofilesschemaexportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ExportProfileSchemaRequestprofilesschemaexportPost: " + e.Message );
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
 **body** | [**ExportProfileSchemaRequest**](ExportProfileSchemaRequest.md)|  | [optional] 

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

<a name="exportprofilesrequestprofilesexportpost"></a>
# **ExportProfilesRequestprofilesexportPost**
> TaskInfo ExportProfilesRequestprofilesexportPost (string accept, ExportProfilesRequest body = null)

Export the profile system data - {ExportProfilesRequest}

Export the profile system data. Return the task information for the started durable task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportProfilesRequestprofilesexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ExportProfilesRequest(); // ExportProfilesRequest |  (optional) 

            try
            {
                // Export the profile system data - {ExportProfilesRequest}
                TaskInfo result = apiInstance.ExportProfilesRequestprofilesexportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ExportProfilesRequestprofilesexportPost: " + e.Message );
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
 **body** | [**ExportProfilesRequest**](ExportProfilesRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importinventoryitemsrequestinventoryitemsimportpost"></a>
# **ImportInventoryItemsRequestinventoryItemsimportPost**
> TaskInfo ImportInventoryItemsRequestinventoryItemsimportPost (string accept, ImportInventoryItemsRequest body = null)

Import inventory items from a set of files - {ImportInventoryItemsRequest}

Import inventory items from a set of files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportInventoryItemsRequestinventoryItemsimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ImportInventoryItemsRequest(); // ImportInventoryItemsRequest |  (optional) 

            try
            {
                // Import inventory items from a set of files - {ImportInventoryItemsRequest}
                TaskInfo result = apiInstance.ImportInventoryItemsRequestinventoryItemsimportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportInventoryItemsRequestinventoryItemsimportPost: " + e.Message );
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
 **body** | [**ImportInventoryItemsRequest**](ImportInventoryItemsRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |
| **404** | The task could not be launched. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importorderschemarequestordersschemaimportpost"></a>
# **ImportOrderSchemaRequestordersschemaimportPost**
> TaskInfo ImportOrderSchemaRequestordersschemaimportPost (string accept, ImportOrderSchemaRequest body = null)

Import order schema from file - {ImportOrderSchemaRequest}

Import order schema from file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportOrderSchemaRequestordersschemaimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ImportOrderSchemaRequest(); // ImportOrderSchemaRequest |  (optional) 

            try
            {
                // Import order schema from file - {ImportOrderSchemaRequest}
                TaskInfo result = apiInstance.ImportOrderSchemaRequestordersschemaimportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportOrderSchemaRequestordersschemaimportPost: " + e.Message );
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
 **body** | [**ImportOrderSchemaRequest**](ImportOrderSchemaRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importordersrequestordersimportpost"></a>
# **ImportOrdersRequestordersimportPost**
> TaskInfo ImportOrdersRequestordersimportPost (string accept, ImportOrdersRequest body = null)

Import Orders and their's sub-elements :  Payments Shipments, LineItems, Taxes, Addresses, Order history, Notes, Additional fees, Discounts and coupons - {ImportOrdersRequest}

Import Orders and their's sub-elements : Payments Shipments, LineItems, Taxes, Addresses, Order history, Notes, Additional fees, Discounts and coupons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportOrdersRequestordersimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ImportOrdersRequest(); // ImportOrdersRequest |  (optional) 

            try
            {
                // Import Orders and their's sub-elements :  Payments Shipments, LineItems, Taxes, Addresses, Order history, Notes, Additional fees, Discounts and coupons - {ImportOrdersRequest}
                TaskInfo result = apiInstance.ImportOrdersRequestordersimportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportOrdersRequestordersimportPost: " + e.Message );
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
 **body** | [**ImportOrdersRequest**](ImportOrdersRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importproductspricesrequestproductsscopeidpricesimportpost"></a>
# **ImportProductsPricesRequestproductsScopeIdpricesimportPost**
> TaskInfo ImportProductsPricesRequestproductsScopeIdpricesimportPost (string accept, string scopeId, ImportProductsPricesRequest body = null)

Requests that a products prices import be started asynchronously. - {ImportProductsPricesRequest}

Requests that a products prices import be started asynchronously for a given scope using the data available in the blob storage at the provided path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportProductsPricesRequestproductsScopeIdpricesimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ImportProductsPricesRequest(); // ImportProductsPricesRequest |  (optional) 

            try
            {
                // Requests that a products prices import be started asynchronously. - {ImportProductsPricesRequest}
                TaskInfo result = apiInstance.ImportProductsPricesRequestproductsScopeIdpricesimportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportProductsPricesRequestproductsScopeIdpricesimportPost: " + e.Message );
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
 **scopeId** | **string**| The scope. | 
 **body** | [**ImportProductsPricesRequest**](ImportProductsPricesRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importproductsrequestproductsscopeidimportpost"></a>
# **ImportProductsRequestproductsScopeIdimportPost**
> TaskInfo ImportProductsRequestproductsScopeIdimportPost (string accept, string scopeId, ImportProductsRequest body = null)

Import Metadatas, Products, Prices, Categories and RelationShips - {ImportProductsRequest}

Import Metadatas, Products, Prices, Categories and RelationShips

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportProductsRequestproductsScopeIdimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ImportProductsRequest(); // ImportProductsRequest |  (optional) 

            try
            {
                // Import Metadatas, Products, Prices, Categories and RelationShips - {ImportProductsRequest}
                TaskInfo result = apiInstance.ImportProductsRequestproductsScopeIdimportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportProductsRequestproductsScopeIdimportPost: " + e.Message );
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
 **scopeId** | **string**| The scope. | 
 **body** | [**ImportProductsRequest**](ImportProductsRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importprofileschemarequestprofilesschemaimportpost"></a>
# **ImportProfileSchemaRequestprofilesschemaimportPost**
> TaskInfo ImportProfileSchemaRequestprofilesschemaimportPost (string accept, ImportProfileSchemaRequest body = null)

Import the profile system schema - {ImportProfileSchemaRequest}

Import the profile system schema. Return the task information for the started durable task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportProfileSchemaRequestprofilesschemaimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ImportProfileSchemaRequest(); // ImportProfileSchemaRequest |  (optional) 

            try
            {
                // Import the profile system schema - {ImportProfileSchemaRequest}
                TaskInfo result = apiInstance.ImportProfileSchemaRequestprofilesschemaimportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportProfileSchemaRequestprofilesschemaimportPost: " + e.Message );
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
 **body** | [**ImportProfileSchemaRequest**](ImportProfileSchemaRequest.md)|  | [optional] 

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

<a name="importprofilesrequestprofilesimportpost"></a>
# **ImportProfilesRequestprofilesimportPost**
> TaskInfo ImportProfilesRequestprofilesimportPost (string accept, ImportProfilesRequest body = null)

Import/Sync the profile system data - {ImportProfilesRequest}

Import/Delete/Sync the profile system data.     A result file containing all success and failures will be sent to the blob.  The task will always be set as RunToCompletion by design.   To see the status please check the property ErrorsInFiles in the task result or the result zip file in the blob.    Restictions:                - Files must be in the root of the zip               - Only one import header by entity: Could not set different columns on the same profile in the same import zip               - Only one delete header by entity: Could not perform a delete on the same profile with different keys. Cannot set some with ChildrenOnly and other not.               - Importing an entity with extra will delete all related extra that have an import header               - Delete files doesn't apply on extra    Return the task information for the started durable task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportProfilesRequestprofilesimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new IntegrationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ImportProfilesRequest(); // ImportProfilesRequest |  (optional) 

            try
            {
                // Import/Sync the profile system data - {ImportProfilesRequest}
                TaskInfo result = apiInstance.ImportProfilesRequestprofilesimportPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportProfilesRequestprofilesimportPost: " + e.Message );
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
 **body** | [**ImportProfilesRequest**](ImportProfilesRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

