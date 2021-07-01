# Yaksa.OrckestraCommerce.Client.Api.DataexchangeApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportProductPriceRequestproductpricesScopeIdexportPost**](DataexchangeApi.md#exportproductpricerequestproductpricesscopeidexportpost) | **POST** /dataexchange/productprices/{ScopeId}/export | Export Product Prices of a priceList - {ExportProductPriceRequest}
[**ExportPromoCodesRequestpromotionsPromotionIdpromoCodesexportPost**](DataexchangeApi.md#exportpromocodesrequestpromotionspromotionidpromocodesexportpost) | **POST** /dataexchange/promotions/{PromotionId}/promoCodes/export | Export the promo codes of the promotion - {ExportPromoCodesRequest}
[**ImportProductPriceRequestproductpricesScopeIdimportPost**](DataexchangeApi.md#importproductpricerequestproductpricesscopeidimportpost) | **POST** /dataexchange/productprices/{ScopeId}/import | Import a  file Products and Product Prices of a priceList - {ImportProductPriceRequest}
[**ImportPromoCodesRequestpromotionsPromotionIdpromoCodesimportPost**](DataexchangeApi.md#importpromocodesrequestpromotionspromotionidpromocodesimportpost) | **POST** /dataexchange/promotions/{PromotionId}/promoCodes/import | Import the promo codes for the promotion - {ImportPromoCodesRequest}
[**ProductInformationExportRequestproductsScopeIdexportPost**](DataexchangeApi.md#productinformationexportrequestproductsscopeidexportpost) | **POST** /dataexchange/products/{ScopeId}/export | Export Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationExportRequest}
[**ProductInformationImportRequestproductsScopeIdimportPost**](DataexchangeApi.md#productinformationimportrequestproductsscopeidimportpost) | **POST** /dataexchange/products/{ScopeId}/import | Import Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationImportRequest}
[**ProductInformationLegacyImportRequestproductsScopeIdlegacyimportPost**](DataexchangeApi.md#productinformationlegacyimportrequestproductsscopeidlegacyimportpost) | **POST** /dataexchange/products/{ScopeId}/legacy/import | Import Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationLegacyImportRequest}


<a name="exportproductpricerequestproductpricesscopeidexportpost"></a>
# **ExportProductPriceRequestproductpricesScopeIdexportPost**
> TaskInfo ExportProductPriceRequestproductpricesScopeIdexportPost (string accept, string scopeId, ExportProductPriceRequest body = null)

Export Product Prices of a priceList - {ExportProductPriceRequest}

Export Product Prices of a priceList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportProductPriceRequestproductpricesScopeIdexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DataexchangeApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ExportProductPriceRequest(); // ExportProductPriceRequest |  (optional) 

            try
            {
                // Export Product Prices of a priceList - {ExportProductPriceRequest}
                TaskInfo result = apiInstance.ExportProductPriceRequestproductpricesScopeIdexportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataexchangeApi.ExportProductPriceRequestproductpricesScopeIdexportPost: " + e.Message );
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
 **body** | [**ExportProductPriceRequest**](ExportProductPriceRequest.md)|  | [optional] 

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

<a name="exportpromocodesrequestpromotionspromotionidpromocodesexportpost"></a>
# **ExportPromoCodesRequestpromotionsPromotionIdpromoCodesexportPost**
> TaskInfo ExportPromoCodesRequestpromotionsPromotionIdpromoCodesexportPost (string accept, string promotionId, ExportPromoCodesRequest body = null)

Export the promo codes of the promotion - {ExportPromoCodesRequest}

Export the promo codes of the promotion. The ouput is a csv file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportPromoCodesRequestpromotionsPromotionIdpromoCodesexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DataexchangeApi(config);
            var accept = accept_example;  // string | Accept Header
            var promotionId = promotionId_example;  // string | The id of the promotion.
            var body = new ExportPromoCodesRequest(); // ExportPromoCodesRequest |  (optional) 

            try
            {
                // Export the promo codes of the promotion - {ExportPromoCodesRequest}
                TaskInfo result = apiInstance.ExportPromoCodesRequestpromotionsPromotionIdpromoCodesexportPost(accept, promotionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataexchangeApi.ExportPromoCodesRequestpromotionsPromotionIdpromoCodesexportPost: " + e.Message );
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
 **promotionId** | **string**| The id of the promotion. | 
 **body** | [**ExportPromoCodesRequest**](ExportPromoCodesRequest.md)|  | [optional] 

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

<a name="importproductpricerequestproductpricesscopeidimportpost"></a>
# **ImportProductPriceRequestproductpricesScopeIdimportPost**
> TaskInfo ImportProductPriceRequestproductpricesScopeIdimportPost (string accept, string scopeId, ImportProductPriceRequest body = null)

Import a  file Products and Product Prices of a priceList - {ImportProductPriceRequest}

Import a file Products and Product Prices of a priceList - {ImportProductPriceRequest}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportProductPriceRequestproductpricesScopeIdimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DataexchangeApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ImportProductPriceRequest(); // ImportProductPriceRequest |  (optional) 

            try
            {
                // Import a  file Products and Product Prices of a priceList - {ImportProductPriceRequest}
                TaskInfo result = apiInstance.ImportProductPriceRequestproductpricesScopeIdimportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataexchangeApi.ImportProductPriceRequestproductpricesScopeIdimportPost: " + e.Message );
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
 **body** | [**ImportProductPriceRequest**](ImportProductPriceRequest.md)|  | [optional] 

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

<a name="importpromocodesrequestpromotionspromotionidpromocodesimportpost"></a>
# **ImportPromoCodesRequestpromotionsPromotionIdpromoCodesimportPost**
> TaskInfo ImportPromoCodesRequestpromotionsPromotionIdpromoCodesimportPost (string accept, string promotionId, ImportPromoCodesRequest body = null)

Import the promo codes for the promotion - {ImportPromoCodesRequest}

Import the promo codes for the promotion. The promo codes to import are in csv file, one promo code per row

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ImportPromoCodesRequestpromotionsPromotionIdpromoCodesimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DataexchangeApi(config);
            var accept = accept_example;  // string | Accept Header
            var promotionId = promotionId_example;  // string | The id of the promotion.
            var body = new ImportPromoCodesRequest(); // ImportPromoCodesRequest |  (optional) 

            try
            {
                // Import the promo codes for the promotion - {ImportPromoCodesRequest}
                TaskInfo result = apiInstance.ImportPromoCodesRequestpromotionsPromotionIdpromoCodesimportPost(accept, promotionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataexchangeApi.ImportPromoCodesRequestpromotionsPromotionIdpromoCodesimportPost: " + e.Message );
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
 **promotionId** | **string**| The id of the promotion. | 
 **body** | [**ImportPromoCodesRequest**](ImportPromoCodesRequest.md)|  | [optional] 

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

<a name="productinformationexportrequestproductsscopeidexportpost"></a>
# **ProductInformationExportRequestproductsScopeIdexportPost**
> TaskInfo ProductInformationExportRequestproductsScopeIdexportPost (string accept, string scopeId, ProductInformationExportRequest body = null)

Export Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationExportRequest}

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
    public class ProductInformationExportRequestproductsScopeIdexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DataexchangeApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ProductInformationExportRequest(); // ProductInformationExportRequest |  (optional) 

            try
            {
                // Export Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationExportRequest}
                TaskInfo result = apiInstance.ProductInformationExportRequestproductsScopeIdexportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataexchangeApi.ProductInformationExportRequestproductsScopeIdexportPost: " + e.Message );
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
 **body** | [**ProductInformationExportRequest**](ProductInformationExportRequest.md)|  | [optional] 

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

<a name="productinformationimportrequestproductsscopeidimportpost"></a>
# **ProductInformationImportRequestproductsScopeIdimportPost**
> TaskInfo ProductInformationImportRequestproductsScopeIdimportPost (string accept, string scopeId, ProductInformationImportRequest body = null)

Import Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationImportRequest}

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
    public class ProductInformationImportRequestproductsScopeIdimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DataexchangeApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ProductInformationImportRequest(); // ProductInformationImportRequest |  (optional) 

            try
            {
                // Import Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationImportRequest}
                TaskInfo result = apiInstance.ProductInformationImportRequestproductsScopeIdimportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataexchangeApi.ProductInformationImportRequestproductsScopeIdimportPost: " + e.Message );
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
 **body** | [**ProductInformationImportRequest**](ProductInformationImportRequest.md)|  | [optional] 

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

<a name="productinformationlegacyimportrequestproductsscopeidlegacyimportpost"></a>
# **ProductInformationLegacyImportRequestproductsScopeIdlegacyimportPost**
> TaskInfo ProductInformationLegacyImportRequestproductsScopeIdlegacyimportPost (string accept, string scopeId, ProductInformationLegacyImportRequest body = null)

Import Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationLegacyImportRequest}

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
    public class ProductInformationLegacyImportRequestproductsScopeIdlegacyimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new DataexchangeApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope.
            var body = new ProductInformationLegacyImportRequest(); // ProductInformationLegacyImportRequest |  (optional) 

            try
            {
                // Import Metadatas, Products, Prices, Categories and RelationShips - {ProductInformationLegacyImportRequest}
                TaskInfo result = apiInstance.ProductInformationLegacyImportRequestproductsScopeIdlegacyimportPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataexchangeApi.ProductInformationLegacyImportRequestproductsScopeIdlegacyimportPost: " + e.Message );
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
 **body** | [**ProductInformationLegacyImportRequest**](ProductInformationLegacyImportRequest.md)|  | [optional] 

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

