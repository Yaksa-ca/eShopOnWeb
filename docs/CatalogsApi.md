# Yaksa.OrckestraCommerce.Client.Api.CatalogsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCatalogChildrenIdsRequestCatalogIdchildrenGet**](CatalogsApi.md#getcatalogchildrenidsrequestcatalogidchildrenget) | **GET** /catalogs/{CatalogId}/children | Retrieve all catalog children for a catalog - {GetCatalogChildrenIdsRequest}
[**GetCatalogRequestCatalogIdGet**](CatalogsApi.md#getcatalogrequestcatalogidget) | **GET** /catalogs/{CatalogId} | Retrieve a catalog - {GetCatalogRequest}
[**GetClosestCatalogLanguageRequestclosestlanguageCatalogIdLanguageGet**](CatalogsApi.md#getclosestcataloglanguagerequestclosestlanguagecatalogidlanguageget) | **GET** /catalogs/closestlanguage/{CatalogId}/{Language} | Retrieve the &#39;closest&#39; language supported by a catalog from the requested language - {GetClosestCatalogLanguageRequest}
[**GetUsedLanguagesRequestusedCulturesGet**](CatalogsApi.md#getusedlanguagesrequestusedculturesget) | **GET** /catalogs/usedCultures | Retrieve the list of cultures supported by product catalogs - {GetUsedLanguagesRequest}
[**UpdateCatalogRequestCatalogIdCreate**](CatalogsApi.md#updatecatalogrequestcatalogidcreate) | **PUT** /catalogs/{CatalogId} | Update a catalog - {UpdateCatalogRequest}


<a name="getcatalogchildrenidsrequestcatalogidchildrenget"></a>
# **GetCatalogChildrenIdsRequestCatalogIdchildrenGet**
> List&lt;Catalog&gt; GetCatalogChildrenIdsRequestCatalogIdchildrenGet (string accept, string catalogId, string cultureName)

Retrieve all catalog children for a catalog - {GetCatalogChildrenIdsRequest}

Retrieve all catalog children for a catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCatalogChildrenIdsRequestCatalogIdchildrenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CatalogsApi(config);
            var accept = accept_example;  // string | Accept Header
            var catalogId = catalogId_example;  // string | The Id of the parent Catalog.
            var cultureName = cultureName_example;  // string | The name of the culture (language) to use to process the request.

            try
            {
                // Retrieve all catalog children for a catalog - {GetCatalogChildrenIdsRequest}
                List<Catalog> result = apiInstance.GetCatalogChildrenIdsRequestCatalogIdchildrenGet(accept, catalogId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogsApi.GetCatalogChildrenIdsRequestCatalogIdchildrenGet: " + e.Message );
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
 **catalogId** | **string**| The Id of the parent Catalog. | 
 **cultureName** | **string**| The name of the culture (language) to use to process the request. | 

### Return type

[**List&lt;Catalog&gt;**](Catalog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested catalog id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogrequestcatalogidget"></a>
# **GetCatalogRequestCatalogIdGet**
> Catalog GetCatalogRequestCatalogIdGet (string accept, string catalogId, string cultureName, bool? includeChildren = null)

Retrieve a catalog - {GetCatalogRequest}

Retrieve a catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCatalogRequestCatalogIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CatalogsApi(config);
            var accept = accept_example;  // string | Accept Header
            var catalogId = catalogId_example;  // string | The CatalogId of the request.
            var cultureName = cultureName_example;  // string | The name of the culture (language) to use to process the request.
            var includeChildren = true;  // bool? | Indicates if the children must be included in the response. (optional) 

            try
            {
                // Retrieve a catalog - {GetCatalogRequest}
                Catalog result = apiInstance.GetCatalogRequestCatalogIdGet(accept, catalogId, cultureName, includeChildren);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogsApi.GetCatalogRequestCatalogIdGet: " + e.Message );
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
 **catalogId** | **string**| The CatalogId of the request. | 
 **cultureName** | **string**| The name of the culture (language) to use to process the request. | 
 **includeChildren** | **bool?**| Indicates if the children must be included in the response. | [optional] 

### Return type

[**Catalog**](Catalog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested catalog id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclosestcataloglanguagerequestclosestlanguagecatalogidlanguageget"></a>
# **GetClosestCatalogLanguageRequestclosestlanguageCatalogIdLanguageGet**
> string GetClosestCatalogLanguageRequestclosestlanguageCatalogIdLanguageGet (string accept, string catalogId, string language)

Retrieve the 'closest' language supported by a catalog from the requested language - {GetClosestCatalogLanguageRequest}

Retrieve the 'closest' language supported by a catalog from the requested language - {GetClosestCatalogLanguageRequest}. This allows to know if a language is supported by a given Catalog. If it is, it will be returned as is, otherwise the 'closest' language is returned. The 'closest' language could be the same language but different country, if it is not supported the default language of the catalog is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetClosestCatalogLanguageRequestclosestlanguageCatalogIdLanguageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CatalogsApi(config);
            var accept = accept_example;  // string | Accept Header
            var catalogId = catalogId_example;  // string | The ID of the catalog
            var language = language_example;  // string | The requested language

            try
            {
                // Retrieve the 'closest' language supported by a catalog from the requested language - {GetClosestCatalogLanguageRequest}
                string result = apiInstance.GetClosestCatalogLanguageRequestclosestlanguageCatalogIdLanguageGet(accept, catalogId, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogsApi.GetClosestCatalogLanguageRequestclosestlanguageCatalogIdLanguageGet: " + e.Message );
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
 **catalogId** | **string**| The ID of the catalog | 
 **language** | **string**| The requested language | 

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
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusedlanguagesrequestusedculturesget"></a>
# **GetUsedLanguagesRequestusedCulturesGet**
> CultureIsoList GetUsedLanguagesRequestusedCulturesGet (string accept)

Retrieve the list of cultures supported by product catalogs - {GetUsedLanguagesRequest}

Returns the list of cultures supported by product catalogs - {GetUsedLanguagesRequest}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUsedLanguagesRequestusedCulturesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CatalogsApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the list of cultures supported by product catalogs - {GetUsedLanguagesRequest}
                CultureIsoList result = apiInstance.GetUsedLanguagesRequestusedCulturesGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogsApi.GetUsedLanguagesRequestusedCulturesGet: " + e.Message );
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

### Return type

[**CultureIsoList**](CultureIsoList.md)

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

<a name="updatecatalogrequestcatalogidcreate"></a>
# **UpdateCatalogRequestCatalogIdCreate**
> Catalog UpdateCatalogRequestCatalogIdCreate (string accept, string catalogId, UpdateCatalogRequest body = null)

Update a catalog - {UpdateCatalogRequest}

Update a catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCatalogRequestCatalogIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CatalogsApi(config);
            var accept = accept_example;  // string | Accept Header
            var catalogId = catalogId_example;  // string | The unique identifier of the catalog to update.
            var body = new UpdateCatalogRequest(); // UpdateCatalogRequest |  (optional) 

            try
            {
                // Update a catalog - {UpdateCatalogRequest}
                Catalog result = apiInstance.UpdateCatalogRequestCatalogIdCreate(accept, catalogId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogsApi.UpdateCatalogRequestCatalogIdCreate: " + e.Message );
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
 **catalogId** | **string**| The unique identifier of the catalog to update. | 
 **body** | [**UpdateCatalogRequest**](UpdateCatalogRequest.md)|  | [optional] 

### Return type

[**Catalog**](Catalog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested catalog id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

