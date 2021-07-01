# Yaksa.OrckestraCommerce.Client.Api.SearchApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreate**](SearchApi.md#addorupdatevariantsearchconfigurationrequestscopeidconfigurationsvariantcreate) | **PUT** /search/{ScopeId}/configurations/variant | Adds or updates the variant search configuration for the specified product definition. - {AddOrUpdateVariantSearchConfigurationRequest}
[**AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePost**](SearchApi.md#advancedsearchrequestscopeidculturenameadvancedindexnamepost) | **POST** /search/{ScopeId}/{CultureName}/advanced/{IndexName} | Make a generic search - {AdvancedSearchRequest}
[**GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGet**](SearchApi.md#getvariantsearchconfigurationsrequestscopeidconfigurationsvariantget) | **GET** /search/{ScopeId}/configurations/variant | Returns the list of variant search configurations in the system. - {GetVariantSearchConfigurationsRequest}
[**IndexCustomersRequestindexescustomersCreate**](SearchApi.md#indexcustomersrequestindexescustomerscreate) | **PUT** /search/indexes/customers | Start the customers indexing durable task - {IndexCustomersRequest}
[**IndexInventoriesRequestindexesinventoriesCreate**](SearchApi.md#indexinventoriesrequestindexesinventoriescreate) | **PUT** /search/indexes/inventories | Start the inventories indexing durable task - {IndexInventoriesRequest}
[**IndexProductsRequestindexesproductsCreate**](SearchApi.md#indexproductsrequestindexesproductscreate) | **PUT** /search/indexes/products | Start the products indexing durable tasks - {IndexProductsRequest}
[**IndexStoresRequestindexesstoresCreate**](SearchApi.md#indexstoresrequestindexesstorescreate) | **PUT** /search/indexes/stores | Start the stores indexing durable task - {IndexStoresRequest}
[**SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePost**](SearchApi.md#searchavailableproductsbycategoryrequestscopeidculturenameavailableproductsbycategorycategorynamepost) | **POST** /search/{ScopeId}/{CultureName}/availableProducts/byCategory/{CategoryName} | Search for products available in the inventory using an optional search query - {SearchAvailableProductsByCategoryRequest}
[**SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPost**](SearchApi.md#searchavailableproductsrequestscopeidculturenameavailableproductspost) | **POST** /search/{ScopeId}/{CultureName}/availableProducts | Search for products available in the inventory - {SearchAvailableProductsRequest}
[**SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePost**](SearchApi.md#searchbysearchqueryrequestscopeidculturenamebysearchqueryquerytypequerynamepost) | **POST** /search/{ScopeId}/{CultureName}/bySearchQuery/{QueryType}/{QueryName} | Search using a Search Query as a template - {SearchBySearchQueryRequest}
[**SearchCustomersRequestScopeIdCultureNamecustomersPost**](SearchApi.md#searchcustomersrequestscopeidculturenamecustomerspost) | **POST** /search/{ScopeId}/{CultureName}/customers | Search for customers - {SearchCustomersRequest}
[**SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPost**](SearchApi.md#searchproductbyidsrequestscopeidculturenameproductsbyidspost) | **POST** /search/{ScopeId}/{CultureName}/products/byIds | Search product by ids - {SearchProductByIdsRequest}
[**SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPost**](SearchApi.md#searchproductbysavedqueryrequestscopeidculturenameproductsbysavedqueryqueryidpost) | **POST** /search/{ScopeId}/{CultureName}/products/bySavedQuery/{QueryId} | Search product by saved query - {SearchProductBySavedQueryRequest}
[**SearchProductRequestScopeIdCultureNameproductsPost**](SearchApi.md#searchproductrequestscopeidculturenameproductspost) | **POST** /search/{ScopeId}/{CultureName}/products | Search for product - {SearchProductRequest}
[**SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPost**](SearchApi.md#searchsimilarproductsrequestscopeidculturenameproductssimilarproductidpost) | **POST** /search/{ScopeId}/{CultureName}/products/similar/{ProductId} | Search for similar products - {SearchSimilarProductsRequest}


<a name="addorupdatevariantsearchconfigurationrequestscopeidconfigurationsvariantcreate"></a>
# **AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreate**
> string AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreate (string accept, string scopeId, AddOrUpdateVariantSearchConfigurationRequest body = null)

Adds or updates the variant search configuration for the specified product definition. - {AddOrUpdateVariantSearchConfigurationRequest}

Adds or updates the variant search configuration for the specified product definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new AddOrUpdateVariantSearchConfigurationRequest(); // AddOrUpdateVariantSearchConfigurationRequest |  (optional) 

            try
            {
                // Adds or updates the variant search configuration for the specified product definition. - {AddOrUpdateVariantSearchConfigurationRequest}
                string result = apiInstance.AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreate(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.AddOrUpdateVariantSearchConfigurationRequestScopeIdconfigurationsvariantCreate: " + e.Message );
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
 **body** | [**AddOrUpdateVariantSearchConfigurationRequest**](AddOrUpdateVariantSearchConfigurationRequest.md)|  | [optional] 

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
| **404** | Requested configurations not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedsearchrequestscopeidculturenameadvancedindexnamepost"></a>
# **AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePost**
> SearchResult AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePost (string accept, string scopeId, string cultureName, string indexName, AdvancedSearchRequest body = null)

Make a generic search - {AdvancedSearchRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var indexName = indexName_example;  // string | The required name of the index to query: [Products, Customers, Stores, Inventories, ...]. See orckestra.overture.solr section in web.config for the complete list.
            var body = new AdvancedSearchRequest(); // AdvancedSearchRequest |  (optional) 

            try
            {
                // Make a generic search - {AdvancedSearchRequest}
                SearchResult result = apiInstance.AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePost(accept, scopeId, cultureName, indexName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.AdvancedSearchRequestScopeIdCultureNameadvancedIndexNamePost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **indexName** | **string**| The required name of the index to query: [Products, Customers, Stores, Inventories, ...]. See orckestra.overture.solr section in web.config for the complete list. | 
 **body** | [**AdvancedSearchRequest**](AdvancedSearchRequest.md)|  | [optional] 

### Return type

[**SearchResult**](SearchResult.md)

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

<a name="getvariantsearchconfigurationsrequestscopeidconfigurationsvariantget"></a>
# **GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGet**
> List&lt;VariantSearchConfiguration&gt; GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGet (string accept, string scopeId)

Returns the list of variant search configurations in the system. - {GetVariantSearchConfigurationsRequest}

Returns the list of variant search configurations in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Returns the list of variant search configurations in the system. - {GetVariantSearchConfigurationsRequest}
                List<VariantSearchConfiguration> result = apiInstance.GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetVariantSearchConfigurationsRequestScopeIdconfigurationsvariantGet: " + e.Message );
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

### Return type

[**List&lt;VariantSearchConfiguration&gt;**](VariantSearchConfiguration.md)

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
| **404** | Requested configurations not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexcustomersrequestindexescustomerscreate"></a>
# **IndexCustomersRequestindexescustomersCreate**
> List&lt;TaskInfo&gt; IndexCustomersRequestindexescustomersCreate (string accept, IndexCustomersRequest body = null)

Start the customers indexing durable task - {IndexCustomersRequest}

Start the customers indexing durable task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class IndexCustomersRequestindexescustomersCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new IndexCustomersRequest(); // IndexCustomersRequest |  (optional) 

            try
            {
                // Start the customers indexing durable task - {IndexCustomersRequest}
                List<TaskInfo> result = apiInstance.IndexCustomersRequestindexescustomersCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.IndexCustomersRequestindexescustomersCreate: " + e.Message );
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
 **body** | [**IndexCustomersRequest**](IndexCustomersRequest.md)|  | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="indexinventoriesrequestindexesinventoriescreate"></a>
# **IndexInventoriesRequestindexesinventoriesCreate**
> List&lt;TaskInfo&gt; IndexInventoriesRequestindexesinventoriesCreate (string accept, IndexInventoriesRequest body = null)

Start the inventories indexing durable task - {IndexInventoriesRequest}

Start the inventories indexing durable task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class IndexInventoriesRequestindexesinventoriesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new IndexInventoriesRequest(); // IndexInventoriesRequest |  (optional) 

            try
            {
                // Start the inventories indexing durable task - {IndexInventoriesRequest}
                List<TaskInfo> result = apiInstance.IndexInventoriesRequestindexesinventoriesCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.IndexInventoriesRequestindexesinventoriesCreate: " + e.Message );
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
 **body** | [**IndexInventoriesRequest**](IndexInventoriesRequest.md)|  | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="indexproductsrequestindexesproductscreate"></a>
# **IndexProductsRequestindexesproductsCreate**
> List&lt;TaskInfo&gt; IndexProductsRequestindexesproductsCreate (string accept, IndexProductsRequest body = null)

Start the products indexing durable tasks - {IndexProductsRequest}

Start the products indexing durable tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class IndexProductsRequestindexesproductsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new IndexProductsRequest(); // IndexProductsRequest |  (optional) 

            try
            {
                // Start the products indexing durable tasks - {IndexProductsRequest}
                List<TaskInfo> result = apiInstance.IndexProductsRequestindexesproductsCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.IndexProductsRequestindexesproductsCreate: " + e.Message );
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
 **body** | [**IndexProductsRequest**](IndexProductsRequest.md)|  | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="indexstoresrequestindexesstorescreate"></a>
# **IndexStoresRequestindexesstoresCreate**
> List&lt;TaskInfo&gt; IndexStoresRequestindexesstoresCreate (string accept, IndexStoresRequest body = null)

Start the stores indexing durable task - {IndexStoresRequest}

Start the stores indexing durable task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class IndexStoresRequestindexesstoresCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new IndexStoresRequest(); // IndexStoresRequest |  (optional) 

            try
            {
                // Start the stores indexing durable task - {IndexStoresRequest}
                List<TaskInfo> result = apiInstance.IndexStoresRequestindexesstoresCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.IndexStoresRequestindexesstoresCreate: " + e.Message );
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
 **body** | [**IndexStoresRequest**](IndexStoresRequest.md)|  | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="searchavailableproductsbycategoryrequestscopeidculturenameavailableproductsbycategorycategorynamepost"></a>
# **SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePost**
> SearchAvailableProductsByCategoryResponse SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePost (string accept, string scopeId, string cultureName, string categoryName, SearchAvailableProductsByCategoryRequest body = null)

Search for products available in the inventory using an optional search query - {SearchAvailableProductsByCategoryRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var categoryName = categoryName_example;  // string | The name of the category
            var body = new SearchAvailableProductsByCategoryRequest(); // SearchAvailableProductsByCategoryRequest |  (optional) 

            try
            {
                // Search for products available in the inventory using an optional search query - {SearchAvailableProductsByCategoryRequest}
                SearchAvailableProductsByCategoryResponse result = apiInstance.SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePost(accept, scopeId, cultureName, categoryName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchAvailableProductsByCategoryRequestScopeIdCultureNameavailableProductsbyCategoryCategoryNamePost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **categoryName** | **string**| The name of the category | 
 **body** | [**SearchAvailableProductsByCategoryRequest**](SearchAvailableProductsByCategoryRequest.md)|  | [optional] 

### Return type

[**SearchAvailableProductsByCategoryResponse**](SearchAvailableProductsByCategoryResponse.md)

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
| **404** | Requested available products not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchavailableproductsrequestscopeidculturenameavailableproductspost"></a>
# **SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPost**
> ProductSearchResult SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPost (string accept, string scopeId, string cultureName, SearchAvailableProductsRequest body = null)

Search for products available in the inventory - {SearchAvailableProductsRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var body = new SearchAvailableProductsRequest(); // SearchAvailableProductsRequest |  (optional) 

            try
            {
                // Search for products available in the inventory - {SearchAvailableProductsRequest}
                ProductSearchResult result = apiInstance.SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPost(accept, scopeId, cultureName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchAvailableProductsRequestScopeIdCultureNameavailableProductsPost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **body** | [**SearchAvailableProductsRequest**](SearchAvailableProductsRequest.md)|  | [optional] 

### Return type

[**ProductSearchResult**](ProductSearchResult.md)

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
| **404** | Requested available products not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchbysearchqueryrequestscopeidculturenamebysearchqueryquerytypequerynamepost"></a>
# **SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePost**
> SearchQueryResult SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePost (string accept, string scopeId, string cultureName, string queryType, string queryName, SearchBySearchQueryRequest body = null)

Search using a Search Query as a template - {SearchBySearchQueryRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var queryType = queryType_example;  // string | The type of the requested search query
            var queryName = queryName_example;  // string | The name of the requested search query
            var body = new SearchBySearchQueryRequest(); // SearchBySearchQueryRequest |  (optional) 

            try
            {
                // Search using a Search Query as a template - {SearchBySearchQueryRequest}
                SearchQueryResult result = apiInstance.SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePost(accept, scopeId, cultureName, queryType, queryName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchBySearchQueryRequestScopeIdCultureNamebySearchQueryQueryTypeQueryNamePost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **queryType** | **string**| The type of the requested search query | 
 **queryName** | **string**| The name of the requested search query | 
 **body** | [**SearchBySearchQueryRequest**](SearchBySearchQueryRequest.md)|  | [optional] 

### Return type

[**SearchQueryResult**](SearchQueryResult.md)

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

<a name="searchcustomersrequestscopeidculturenamecustomerspost"></a>
# **SearchCustomersRequestScopeIdCultureNamecustomersPost**
> SearchResult SearchCustomersRequestScopeIdCultureNamecustomersPost (string accept, string scopeId, string cultureName, SearchCustomersRequest body = null)

Search for customers - {SearchCustomersRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchCustomersRequestScopeIdCultureNamecustomersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var body = new SearchCustomersRequest(); // SearchCustomersRequest |  (optional) 

            try
            {
                // Search for customers - {SearchCustomersRequest}
                SearchResult result = apiInstance.SearchCustomersRequestScopeIdCultureNamecustomersPost(accept, scopeId, cultureName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCustomersRequestScopeIdCultureNamecustomersPost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **body** | [**SearchCustomersRequest**](SearchCustomersRequest.md)|  | [optional] 

### Return type

[**SearchResult**](SearchResult.md)

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

<a name="searchproductbyidsrequestscopeidculturenameproductsbyidspost"></a>
# **SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPost**
> SearchResult SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPost (string accept, string scopeId, string cultureName, SearchProductByIdsRequest body = null)

Search product by ids - {SearchProductByIdsRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var body = new SearchProductByIdsRequest(); // SearchProductByIdsRequest |  (optional) 

            try
            {
                // Search product by ids - {SearchProductByIdsRequest}
                SearchResult result = apiInstance.SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPost(accept, scopeId, cultureName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchProductByIdsRequestScopeIdCultureNameproductsbyIdsPost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **body** | [**SearchProductByIdsRequest**](SearchProductByIdsRequest.md)|  | [optional] 

### Return type

[**SearchResult**](SearchResult.md)

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

<a name="searchproductbysavedqueryrequestscopeidculturenameproductsbysavedqueryqueryidpost"></a>
# **SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPost**
> SearchResult SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPost (string accept, string scopeId, string cultureName, string queryId, SearchProductBySavedQueryRequest body = null)

Search product by saved query - {SearchProductBySavedQueryRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var queryId = queryId_example;  // string | the id of the saved query to execute.
            var body = new SearchProductBySavedQueryRequest(); // SearchProductBySavedQueryRequest |  (optional) 

            try
            {
                // Search product by saved query - {SearchProductBySavedQueryRequest}
                SearchResult result = apiInstance.SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPost(accept, scopeId, cultureName, queryId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchProductBySavedQueryRequestScopeIdCultureNameproductsbySavedQueryQueryIdPost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **queryId** | **string**| the id of the saved query to execute. | 
 **body** | [**SearchProductBySavedQueryRequest**](SearchProductBySavedQueryRequest.md)|  | [optional] 

### Return type

[**SearchResult**](SearchResult.md)

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

<a name="searchproductrequestscopeidculturenameproductspost"></a>
# **SearchProductRequestScopeIdCultureNameproductsPost**
> SearchResult SearchProductRequestScopeIdCultureNameproductsPost (string accept, string scopeId, string cultureName, SearchProductRequest body = null)

Search for product - {SearchProductRequest}

Execute a generic search against the search engine provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchProductRequestScopeIdCultureNameproductsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var cultureName = cultureName_example;  // string | The culture (language) to use to process the request (en-US)
            var body = new SearchProductRequest(); // SearchProductRequest |  (optional) 

            try
            {
                // Search for product - {SearchProductRequest}
                SearchResult result = apiInstance.SearchProductRequestScopeIdCultureNameproductsPost(accept, scopeId, cultureName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchProductRequestScopeIdCultureNameproductsPost: " + e.Message );
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
 **cultureName** | **string**| The culture (language) to use to process the request (en-US) | 
 **body** | [**SearchProductRequest**](SearchProductRequest.md)|  | [optional] 

### Return type

[**SearchResult**](SearchResult.md)

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

<a name="searchsimilarproductsrequestscopeidculturenameproductssimilarproductidpost"></a>
# **SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPost**
> SearchResult SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPost (string accept, string scopeId, string cultureName, string productId, SearchSimilarProductsRequest body = null)

Search for similar products - {SearchSimilarProductsRequest}

Search for similar products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned
            var productId = productId_example;  // string | The product id
            var body = new SearchSimilarProductsRequest(); // SearchSimilarProductsRequest |  (optional) 

            try
            {
                // Search for similar products - {SearchSimilarProductsRequest}
                SearchResult result = apiInstance.SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPost(accept, scopeId, cultureName, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchSimilarProductsRequestScopeIdCultureNameproductssimilarProductIdPost: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language tha data will be returned | 
 **productId** | **string**| The product id | 
 **body** | [**SearchSimilarProductsRequest**](SearchSimilarProductsRequest.md)|  | [optional] 

### Return type

[**SearchResult**](SearchResult.md)

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

