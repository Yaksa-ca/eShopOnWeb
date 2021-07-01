# Yaksa.OrckestraCommerce.Client.Api.CategoriesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategoryRequestScopeIdPost**](CategoriesApi.md#createcategoryrequestscopeidpost) | **POST** /categories/{ScopeId} | Create a category - {CreateCategoryRequest}
[**DeleteCategoryRequestScopeIdCategoryIdDelete**](CategoriesApi.md#deletecategoryrequestscopeidcategoryiddelete) | **DELETE** /categories/{ScopeId}/{CategoryId} | Delete a category and related products - {DeleteCategoryRequest}
[**DeleteCategoryV2Requestv2ScopeIdCategoryIdDelete**](CategoriesApi.md#deletecategoryv2requestv2scopeidcategoryiddelete) | **DELETE** /categories/v2/{ScopeId}/{CategoryId} | Delete a category and related products - {DeleteCategoryV2Request}
[**FindCategoryTreeNodesRequestScopeIdtreeNodesSearchTermsGet**](CategoriesApi.md#findcategorytreenodesrequestscopeidtreenodessearchtermsget) | **GET** /categories/{ScopeId}/treeNodes/{SearchTerms} | Find category tree nodes - {FindCategoryTreeNodesRequest}
[**GetCategoriesContainingProductsByStatusRequestScopeIdcontainingProductsGet**](CategoriesApi.md#getcategoriescontainingproductsbystatusrequestscopeidcontainingproductsget) | **GET** /categories/{ScopeId}/containingProducts | Retrieve the ids of the categories that contain products in a given publication state - {GetCategoriesContainingProductsByStatusRequest}
[**GetCategoriesRequestScopeIdGet**](CategoriesApi.md#getcategoriesrequestscopeidget) | **GET** /categories/{ScopeId} | Retrieve the categories - {GetCategoriesRequest}
[**GetCategoriesV2Requestv2ScopeIdGet**](CategoriesApi.md#getcategoriesv2requestv2scopeidget) | **GET** /categories/v2/{ScopeId} | Retrieve the categories - {GetCategoriesV2Request}
[**GetCategoryChildrenRequestScopeIdCategoryIdchildrenGet**](CategoriesApi.md#getcategorychildrenrequestscopeidcategoryidchildrenget) | **GET** /categories/{ScopeId}/{CategoryId}/children | Retrieve the tree of child categories for a category - {GetCategoryChildrenRequest}
[**GetCategoryChildrenV2Requestv2ScopeIdCategoryIdchildrenGet**](CategoriesApi.md#getcategorychildrenv2requestv2scopeidcategoryidchildrenget) | **GET** /categories/v2/{ScopeId}/{CategoryId}/children | Retrieve the tree of child categories for a category - {GetCategoryChildrenV2Request}
[**GetCategoryRelationshipsRequestScopeIdCategoryIdrelationshipsGet**](CategoriesApi.md#getcategoryrelationshipsrequestscopeidcategoryidrelationshipsget) | **GET** /categories/{ScopeId}/{CategoryId}/relationships | Retrieve all relationships for a category - {GetCategoryRelationshipsRequest}
[**GetCategoryRelationshipsV2Requestv2ScopeIdCategoryIdrelationshipsGet**](CategoriesApi.md#getcategoryrelationshipsv2requestv2scopeidcategoryidrelationshipsget) | **GET** /categories/v2/{ScopeId}/{CategoryId}/relationships | Retrieve all relationships for a category - {GetCategoryRelationshipsV2Request}
[**GetCategoryRequestScopeIdCategoryIdGet**](CategoriesApi.md#getcategoryrequestscopeidcategoryidget) | **GET** /categories/{ScopeId}/{CategoryId} | Retrieve a category - {GetCategoryRequest}
[**GetCategoryTreeExistingItemByStateRequestScopeIdexistingGet**](CategoriesApi.md#getcategorytreeexistingitembystaterequestscopeidexistingget) | **GET** /categories/{ScopeId}/existing | Retrieve the category tree existing items of the specified parameters - {GetCategoryTreeExistingItemByStateRequest}
[**GetCategoryTreeNodesForPathRequestScopeIdtreeNodesStartIdEndIdGet**](CategoriesApi.md#getcategorytreenodesforpathrequestscopeidtreenodesstartidendidget) | **GET** /categories/{ScopeId}/treeNodes/{StartId}/{EndId} | Retrieve all nodes and their child nodes of a category tree node path - {GetCategoryTreeNodesForPathRequest}
[**GetCategoryTreeNodesRequestScopeIdCategoryIdtreeNodesGet**](CategoriesApi.md#getcategorytreenodesrequestscopeidcategoryidtreenodesget) | **GET** /categories/{ScopeId}/{CategoryId}/treeNodes | Retrieve all the child nodes of a category node - {GetCategoryTreeNodesRequest}
[**GetCategoryTreeNodesV2Requestv2ScopeIdCategoryIdtreeNodesGet**](CategoriesApi.md#getcategorytreenodesv2requestv2scopeidcategoryidtreenodesget) | **GET** /categories/v2/{ScopeId}/{CategoryId}/treeNodes | Retrieve all the child nodes of a category node - {GetCategoryTreeNodesV2Request}
[**GetCategoryV2Requestv2ScopeIdCategoryIdGet**](CategoriesApi.md#getcategoryv2requestv2scopeidcategoryidget) | **GET** /categories/v2/{ScopeId}/{CategoryId} | Retrieve a category - {GetCategoryV2Request}
[**GetProductsByCategoryRequestScopeIdCategoryIdproductsGet**](CategoriesApi.md#getproductsbycategoryrequestscopeidcategoryidproductsget) | **GET** /categories/{ScopeId}/{CategoryId}/products | Retrieve products from a category - {GetProductsByCategoryRequest}
[**GetProductsByCategoryV2Requestv2ScopeIdCategoryIdproductsGet**](CategoriesApi.md#getproductsbycategoryv2requestv2scopeidcategoryidproductsget) | **GET** /categories/v2/{ScopeId}/{CategoryId}/products | Retrieve products from a category - {GetProductsByCategoryV2Request}
[**UpdateCategoryRequestScopeIdCategoryIdPost**](CategoriesApi.md#updatecategoryrequestscopeidcategoryidpost) | **POST** /categories/{ScopeId}/{CategoryId} | Update an existing category - {UpdateCategoryRequest}
[**UpdateCategorySequenceRequestScopeIdCategoryIdchildrensequencePost**](CategoriesApi.md#updatecategorysequencerequestscopeidcategoryidchildrensequencepost) | **POST** /categories/{ScopeId}/{CategoryId}/children/sequence | Update categories sequence - {UpdateCategorySequenceRequest}
[**UpdateCategoryV2Requestv2ScopeIdCategoryIdCreate**](CategoriesApi.md#updatecategoryv2requestv2scopeidcategoryidcreate) | **PUT** /categories/v2/{ScopeId}/{CategoryId} | Update an existing category - {UpdateCategoryV2Request}


<a name="createcategoryrequestscopeidpost"></a>
# **CreateCategoryRequestScopeIdPost**
> Category CreateCategoryRequestScopeIdPost (string accept, string scopeId, CreateCategoryRequest body = null)

Create a category - {CreateCategoryRequest}

Create a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCategoryRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateCategoryRequest(); // CreateCategoryRequest |  (optional) 

            try
            {
                // Create a category - {CreateCategoryRequest}
                Category result = apiInstance.CreateCategoryRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategoryRequestScopeIdPost: " + e.Message );
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
 **body** | [**CreateCategoryRequest**](CreateCategoryRequest.md)|  | [optional] 

### Return type

[**Category**](Category.md)

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

<a name="deletecategoryrequestscopeidcategoryiddelete"></a>
# **DeleteCategoryRequestScopeIdCategoryIdDelete**
> void DeleteCategoryRequestScopeIdCategoryIdDelete (string accept, string scopeId, string categoryId, bool? deleteProducts = null)

Delete a category and related products - {DeleteCategoryRequest}

Delete a category and related products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteCategoryRequestScopeIdCategoryIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category's id.
            var deleteProducts = true;  // bool? | Determines whether the products should be deleted or have the category association removed. (optional) 

            try
            {
                // Delete a category and related products - {DeleteCategoryRequest}
                apiInstance.DeleteCategoryRequestScopeIdCategoryIdDelete(accept, scopeId, categoryId, deleteProducts);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategoryRequestScopeIdCategoryIdDelete: " + e.Message );
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
 **categoryId** | **string**| The category&#39;s id. | 
 **deleteProducts** | **bool?**| Determines whether the products should be deleted or have the category association removed. | [optional] 

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

<a name="deletecategoryv2requestv2scopeidcategoryiddelete"></a>
# **DeleteCategoryV2Requestv2ScopeIdCategoryIdDelete**
> void DeleteCategoryV2Requestv2ScopeIdCategoryIdDelete (string accept, string scopeId, string categoryId, bool? deleteProducts = null)

Delete a category and related products - {DeleteCategoryV2Request}

Delete a category and related products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteCategoryV2Requestv2ScopeIdCategoryIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category's id.
            var deleteProducts = true;  // bool? | Determines whether the products should be deleted or have the category association removed. (optional) 

            try
            {
                // Delete a category and related products - {DeleteCategoryV2Request}
                apiInstance.DeleteCategoryV2Requestv2ScopeIdCategoryIdDelete(accept, scopeId, categoryId, deleteProducts);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategoryV2Requestv2ScopeIdCategoryIdDelete: " + e.Message );
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
 **categoryId** | **string**| The category&#39;s id. | 
 **deleteProducts** | **bool?**| Determines whether the products should be deleted or have the category association removed. | [optional] 

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

<a name="findcategorytreenodesrequestscopeidtreenodessearchtermsget"></a>
# **FindCategoryTreeNodesRequestScopeIdtreeNodesSearchTermsGet**
> List&lt;CategoryTreeNode&gt; FindCategoryTreeNodesRequestScopeIdtreeNodesSearchTermsGet (string accept, string scopeId, string searchTerms, string cultureName, int? maximumResultSize = null)

Find category tree nodes - {FindCategoryTreeNodesRequest}

Request to find category tree nodes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindCategoryTreeNodesRequestScopeIdtreeNodesSearchTermsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The Scope of the request.
            var searchTerms = searchTerms_example;  // string | The search terms for the query.
            var cultureName = cultureName_example;  // string | The name of the culture (language) to use to process the request.
            var maximumResultSize = 56;  // int? | A hint that the service will use to determine the maximum number of nodes to return (optional) 

            try
            {
                // Find category tree nodes - {FindCategoryTreeNodesRequest}
                List<CategoryTreeNode> result = apiInstance.FindCategoryTreeNodesRequestScopeIdtreeNodesSearchTermsGet(accept, scopeId, searchTerms, cultureName, maximumResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.FindCategoryTreeNodesRequestScopeIdtreeNodesSearchTermsGet: " + e.Message );
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
 **scopeId** | **string**| The Scope of the request. | 
 **searchTerms** | **string**| The search terms for the query. | 
 **cultureName** | **string**| The name of the culture (language) to use to process the request. | 
 **maximumResultSize** | **int?**| A hint that the service will use to determine the maximum number of nodes to return | [optional] 

### Return type

[**List&lt;CategoryTreeNode&gt;**](CategoryTreeNode.md)

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

<a name="getcategoriescontainingproductsbystatusrequestscopeidcontainingproductsget"></a>
# **GetCategoriesContainingProductsByStatusRequestScopeIdcontainingProductsGet**
> GetCategoriesContainingProductsByStatusResult GetCategoriesContainingProductsByStatusRequestScopeIdcontainingProductsGet (string accept, string scopeId, string publicationStatus = null)

Retrieve the ids of the categories that contain products in a given publication state - {GetCategoriesContainingProductsByStatusRequest}

Retrieve the ids of the categories that contain products in a given publication state

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoriesContainingProductsByStatusRequestScopeIdcontainingProductsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var publicationStatus = publicationStatus_example;  // string | The publication status to filter the products (optional) 

            try
            {
                // Retrieve the ids of the categories that contain products in a given publication state - {GetCategoriesContainingProductsByStatusRequest}
                GetCategoriesContainingProductsByStatusResult result = apiInstance.GetCategoriesContainingProductsByStatusRequestScopeIdcontainingProductsGet(accept, scopeId, publicationStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoriesContainingProductsByStatusRequestScopeIdcontainingProductsGet: " + e.Message );
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
 **publicationStatus** | **string**| The publication status to filter the products | [optional] 

### Return type

[**GetCategoriesContainingProductsByStatusResult**](GetCategoriesContainingProductsByStatusResult.md)

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

<a name="getcategoriesrequestscopeidget"></a>
# **GetCategoriesRequestScopeIdGet**
> List&lt;Category&gt; GetCategoriesRequestScopeIdGet (string accept, string scopeId, string cultureName = null)

Retrieve the categories - {GetCategoriesRequest}

Retrieve a flat list of the categories for a scope, the relationships will not be loaded

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoriesRequestScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope id
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the categories - {GetCategoriesRequest}
                List<Category> result = apiInstance.GetCategoriesRequestScopeIdGet(accept, scopeId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoriesRequestScopeIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope id | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;Category&gt;**](Category.md)

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

<a name="getcategoriesv2requestv2scopeidget"></a>
# **GetCategoriesV2Requestv2ScopeIdGet**
> CategoryList GetCategoriesV2Requestv2ScopeIdGet (string accept, string scopeId, string cultureName = null)

Retrieve the categories - {GetCategoriesV2Request}

Retrieve a flat list of the categories for a scope, the relationships will not be loaded

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoriesV2Requestv2ScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope id
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the categories - {GetCategoriesV2Request}
                CategoryList result = apiInstance.GetCategoriesV2Requestv2ScopeIdGet(accept, scopeId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoriesV2Requestv2ScopeIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope id | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**CategoryList**](CategoryList.md)

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

<a name="getcategorychildrenrequestscopeidcategoryidchildrenget"></a>
# **GetCategoryChildrenRequestScopeIdCategoryIdchildrenGet**
> List&lt;Category&gt; GetCategoryChildrenRequestScopeIdCategoryIdchildrenGet (string accept, string scopeId, string categoryId, string cultureName = null)

Retrieve the tree of child categories for a category - {GetCategoryChildrenRequest}

Retrieve the tree of child categories for a category, the relationships will not be loaded

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryChildrenRequestScopeIdCategoryIdchildrenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the tree of child categories for a category - {GetCategoryChildrenRequest}
                List<Category> result = apiInstance.GetCategoryChildrenRequestScopeIdCategoryIdchildrenGet(accept, scopeId, categoryId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryChildrenRequestScopeIdCategoryIdchildrenGet: " + e.Message );
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
 **categoryId** | **string**| The category id | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;Category&gt;**](Category.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Happened when the category is not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategorychildrenv2requestv2scopeidcategoryidchildrenget"></a>
# **GetCategoryChildrenV2Requestv2ScopeIdCategoryIdchildrenGet**
> CategoryList GetCategoryChildrenV2Requestv2ScopeIdCategoryIdchildrenGet (string accept, string scopeId, string categoryId, string cultureName = null)

Retrieve the tree of child categories for a category - {GetCategoryChildrenV2Request}

Retrieve the tree of child categories for a category, the relationships will not be loaded

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryChildrenV2Requestv2ScopeIdCategoryIdchildrenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the tree of child categories for a category - {GetCategoryChildrenV2Request}
                CategoryList result = apiInstance.GetCategoryChildrenV2Requestv2ScopeIdCategoryIdchildrenGet(accept, scopeId, categoryId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryChildrenV2Requestv2ScopeIdCategoryIdchildrenGet: " + e.Message );
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
 **categoryId** | **string**| The category id | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**CategoryList**](CategoryList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Happened when the category is not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategoryrelationshipsrequestscopeidcategoryidrelationshipsget"></a>
# **GetCategoryRelationshipsRequestScopeIdCategoryIdrelationshipsGet**
> List&lt;Relationship&gt; GetCategoryRelationshipsRequestScopeIdCategoryIdrelationshipsGet (string accept, string scopeId, string categoryId, string cultureName = null)

Retrieve all relationships for a category - {GetCategoryRelationshipsRequest}

Retrieve all relationships for a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryRelationshipsRequestScopeIdCategoryIdrelationshipsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve all relationships for a category - {GetCategoryRelationshipsRequest}
                List<Relationship> result = apiInstance.GetCategoryRelationshipsRequestScopeIdCategoryIdrelationshipsGet(accept, scopeId, categoryId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryRelationshipsRequestScopeIdCategoryIdrelationshipsGet: " + e.Message );
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
 **categoryId** | **string**| The category id | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;Relationship&gt;**](Relationship.md)

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

<a name="getcategoryrelationshipsv2requestv2scopeidcategoryidrelationshipsget"></a>
# **GetCategoryRelationshipsV2Requestv2ScopeIdCategoryIdrelationshipsGet**
> List&lt;Relationship&gt; GetCategoryRelationshipsV2Requestv2ScopeIdCategoryIdrelationshipsGet (string accept, string scopeId, string categoryId, string cultureName = null)

Retrieve all relationships for a category - {GetCategoryRelationshipsV2Request}

Retrieve all relationships for a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryRelationshipsV2Requestv2ScopeIdCategoryIdrelationshipsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve all relationships for a category - {GetCategoryRelationshipsV2Request}
                List<Relationship> result = apiInstance.GetCategoryRelationshipsV2Requestv2ScopeIdCategoryIdrelationshipsGet(accept, scopeId, categoryId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryRelationshipsV2Requestv2ScopeIdCategoryIdrelationshipsGet: " + e.Message );
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
 **categoryId** | **string**| The category id | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;Relationship&gt;**](Relationship.md)

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

<a name="getcategoryrequestscopeidcategoryidget"></a>
# **GetCategoryRequestScopeIdCategoryIdGet**
> Category GetCategoryRequestScopeIdCategoryIdGet (string accept, string scopeId, string categoryId, bool? includeRelationships = null, string cultureName = null)

Retrieve a category - {GetCategoryRequest}

Retrieve a category  without loading the children or relationships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryRequestScopeIdCategoryIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id
            var includeRelationships = true;  // bool? | Indicates if the relationships must be included in the response. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve a category - {GetCategoryRequest}
                Category result = apiInstance.GetCategoryRequestScopeIdCategoryIdGet(accept, scopeId, categoryId, includeRelationships, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryRequestScopeIdCategoryIdGet: " + e.Message );
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
 **categoryId** | **string**| The category id | 
 **includeRelationships** | **bool?**| Indicates if the relationships must be included in the response. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**Category**](Category.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested category id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategorytreeexistingitembystaterequestscopeidexistingget"></a>
# **GetCategoryTreeExistingItemByStateRequestScopeIdexistingGet**
> GetCategoryTreeExistingItemByStateResult GetCategoryTreeExistingItemByStateRequestScopeIdexistingGet (string accept, string scopeId, string cultureName = null, string draftState = null, bool? isNew = null, bool? hasNotification = null)

Retrieve the category tree existing items of the specified parameters - {GetCategoryTreeExistingItemByStateRequest}

Retrieve the category tree existing items of the specified parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryTreeExistingItemByStateRequestScopeIdexistingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture in which the data will be returned (optional) 
            var draftState = draftState_example;  // string | The draft state used to filter the products (optional) 
            var isNew = true;  // bool? | The flag to get only new or not new products (optional) 
            var hasNotification = true;  // bool? | The flag to get only or not products with change notification (optional) 

            try
            {
                // Retrieve the category tree existing items of the specified parameters - {GetCategoryTreeExistingItemByStateRequest}
                GetCategoryTreeExistingItemByStateResult result = apiInstance.GetCategoryTreeExistingItemByStateRequestScopeIdexistingGet(accept, scopeId, cultureName, draftState, isNew, hasNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryTreeExistingItemByStateRequestScopeIdexistingGet: " + e.Message );
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
 **cultureName** | **string**| The culture in which the data will be returned | [optional] 
 **draftState** | **string**| The draft state used to filter the products | [optional] 
 **isNew** | **bool?**| The flag to get only new or not new products | [optional] 
 **hasNotification** | **bool?**| The flag to get only or not products with change notification | [optional] 

### Return type

[**GetCategoryTreeExistingItemByStateResult**](GetCategoryTreeExistingItemByStateResult.md)

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

<a name="getcategorytreenodesforpathrequestscopeidtreenodesstartidendidget"></a>
# **GetCategoryTreeNodesForPathRequestScopeIdtreeNodesStartIdEndIdGet**
> CategoryTreeNode GetCategoryTreeNodesForPathRequestScopeIdtreeNodesStartIdEndIdGet (string accept, string scopeId, string startId, string endId, string cultureName)

Retrieve all nodes and their child nodes of a category tree node path - {GetCategoryTreeNodesForPathRequest}

Request to retrieve all nodes and their child nodes of a category tree node path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryTreeNodesForPathRequestScopeIdtreeNodesStartIdEndIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The ScopeId of the request.
            var startId = startId_example;  // string | The unique identifier of the first node of the path (a category id).
            var endId = endId_example;  // string | The unique identifier of the last node of the path (a category id).
            var cultureName = cultureName_example;  // string | The name of the culture to use to process the request.

            try
            {
                // Retrieve all nodes and their child nodes of a category tree node path - {GetCategoryTreeNodesForPathRequest}
                CategoryTreeNode result = apiInstance.GetCategoryTreeNodesForPathRequestScopeIdtreeNodesStartIdEndIdGet(accept, scopeId, startId, endId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryTreeNodesForPathRequestScopeIdtreeNodesStartIdEndIdGet: " + e.Message );
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
 **scopeId** | **string**| The ScopeId of the request. | 
 **startId** | **string**| The unique identifier of the first node of the path (a category id). | 
 **endId** | **string**| The unique identifier of the last node of the path (a category id). | 
 **cultureName** | **string**| The name of the culture to use to process the request. | 

### Return type

[**CategoryTreeNode**](CategoryTreeNode.md)

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

<a name="getcategorytreenodesrequestscopeidcategoryidtreenodesget"></a>
# **GetCategoryTreeNodesRequestScopeIdCategoryIdtreeNodesGet**
> CategoryTreeNode GetCategoryTreeNodesRequestScopeIdCategoryIdtreeNodesGet (string accept, string scopeId, string categoryId, string cultureName, int? maximumItems = null)

Retrieve all the child nodes of a category node - {GetCategoryTreeNodesRequest}

Request to retrieve all the child nodes of a category node

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryTreeNodesRequestScopeIdCategoryIdtreeNodesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The Scope of the request.
            var categoryId = categoryId_example;  // string | The root node category unique identifier
            var cultureName = cultureName_example;  // string | The name of the culture (language) to use to process the request.
            var maximumItems = 56;  // int? | A hint that the service will use to determine the maximum number of nodes to return (optional) 

            try
            {
                // Retrieve all the child nodes of a category node - {GetCategoryTreeNodesRequest}
                CategoryTreeNode result = apiInstance.GetCategoryTreeNodesRequestScopeIdCategoryIdtreeNodesGet(accept, scopeId, categoryId, cultureName, maximumItems);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryTreeNodesRequestScopeIdCategoryIdtreeNodesGet: " + e.Message );
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
 **scopeId** | **string**| The Scope of the request. | 
 **categoryId** | **string**| The root node category unique identifier | 
 **cultureName** | **string**| The name of the culture (language) to use to process the request. | 
 **maximumItems** | **int?**| A hint that the service will use to determine the maximum number of nodes to return | [optional] 

### Return type

[**CategoryTreeNode**](CategoryTreeNode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Category not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategorytreenodesv2requestv2scopeidcategoryidtreenodesget"></a>
# **GetCategoryTreeNodesV2Requestv2ScopeIdCategoryIdtreeNodesGet**
> CategoryTreeNode GetCategoryTreeNodesV2Requestv2ScopeIdCategoryIdtreeNodesGet (string accept, string scopeId, string categoryId, string cultureName, int? maximumItems = null)

Retrieve all the child nodes of a category node - {GetCategoryTreeNodesV2Request}

Request to retrieve all the child nodes of a category node

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryTreeNodesV2Requestv2ScopeIdCategoryIdtreeNodesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The Scope of the request.
            var categoryId = categoryId_example;  // string | The root node category unique identifier
            var cultureName = cultureName_example;  // string | The name of the culture (language) to use to process the request.
            var maximumItems = 56;  // int? | A hint that the service will use to determine the maximum number of nodes to return (optional) 

            try
            {
                // Retrieve all the child nodes of a category node - {GetCategoryTreeNodesV2Request}
                CategoryTreeNode result = apiInstance.GetCategoryTreeNodesV2Requestv2ScopeIdCategoryIdtreeNodesGet(accept, scopeId, categoryId, cultureName, maximumItems);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryTreeNodesV2Requestv2ScopeIdCategoryIdtreeNodesGet: " + e.Message );
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
 **scopeId** | **string**| The Scope of the request. | 
 **categoryId** | **string**| The root node category unique identifier | 
 **cultureName** | **string**| The name of the culture (language) to use to process the request. | 
 **maximumItems** | **int?**| A hint that the service will use to determine the maximum number of nodes to return | [optional] 

### Return type

[**CategoryTreeNode**](CategoryTreeNode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Category not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategoryv2requestv2scopeidcategoryidget"></a>
# **GetCategoryV2Requestv2ScopeIdCategoryIdGet**
> Category GetCategoryV2Requestv2ScopeIdCategoryIdGet (string accept, string scopeId, string categoryId, bool? includeChildren = null, bool? includeRelationships = null, string cultureName = null)

Retrieve a category - {GetCategoryV2Request}

Retrieve a category  without loading the children or relationships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCategoryV2Requestv2ScopeIdCategoryIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id
            var includeChildren = true;  // bool? | Indicates if the relationships must be included in the response. (optional) 
            var includeRelationships = true;  // bool? | Indicates if the relationships must be included in the response. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve a category - {GetCategoryV2Request}
                Category result = apiInstance.GetCategoryV2Requestv2ScopeIdCategoryIdGet(accept, scopeId, categoryId, includeChildren, includeRelationships, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryV2Requestv2ScopeIdCategoryIdGet: " + e.Message );
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
 **categoryId** | **string**| The category id | 
 **includeChildren** | **bool?**| Indicates if the relationships must be included in the response. | [optional] 
 **includeRelationships** | **bool?**| Indicates if the relationships must be included in the response. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**Category**](Category.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested category id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsbycategoryrequestscopeidcategoryidproductsget"></a>
# **GetProductsByCategoryRequestScopeIdCategoryIdproductsGet**
> List&lt;Product&gt; GetProductsByCategoryRequestScopeIdCategoryIdproductsGet (string accept, string scopeId, string categoryId, string cultureName = null, int? startingIndex = null, int? maximumItems = null, bool? includeVariants = null, bool? includePriceLists = null)

Retrieve products from a category - {GetProductsByCategoryRequest}

Retrieve products from a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsByCategoryRequestScopeIdCategoryIdproductsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id at which point in the category hierarchy should the 'get products' be started.
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 
            var startingIndex = 56;  // int? | the starting index in the results to start getting the products (used for paging purpose) (optional) 
            var maximumItems = 56;  // int? | The maximum number of results to return. Default value : 10 (optional) 
            var includeVariants = true;  // bool? | Whether or not to include the variants (if they exists) of the products. (optional) 
            var includePriceLists = true;  // bool? | Whether or not to include the price lists of the products. (optional) 

            try
            {
                // Retrieve products from a category - {GetProductsByCategoryRequest}
                List<Product> result = apiInstance.GetProductsByCategoryRequestScopeIdCategoryIdproductsGet(accept, scopeId, categoryId, cultureName, startingIndex, maximumItems, includeVariants, includePriceLists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetProductsByCategoryRequestScopeIdCategoryIdproductsGet: " + e.Message );
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
 **categoryId** | **string**| The category id at which point in the category hierarchy should the &#39;get products&#39; be started. | 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 
 **startingIndex** | **int?**| the starting index in the results to start getting the products (used for paging purpose) | [optional] 
 **maximumItems** | **int?**| The maximum number of results to return. Default value : 10 | [optional] 
 **includeVariants** | **bool?**| Whether or not to include the variants (if they exists) of the products. | [optional] 
 **includePriceLists** | **bool?**| Whether or not to include the price lists of the products. | [optional] 

### Return type

[**List&lt;Product&gt;**](Product.md)

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

<a name="getproductsbycategoryv2requestv2scopeidcategoryidproductsget"></a>
# **GetProductsByCategoryV2Requestv2ScopeIdCategoryIdproductsGet**
> ProductListPage GetProductsByCategoryV2Requestv2ScopeIdCategoryIdproductsGet (string accept, string scopeId, string categoryId, string continuationToken = null, int? pageSize = null, bool? includeVariants = null, bool? includePriceLists = null, bool? includeRelationships = null, bool? includeMedia = null, string cultureName = null)

Retrieve products from a category - {GetProductsByCategoryV2Request}

Retrieve products from a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsByCategoryV2Requestv2ScopeIdCategoryIdproductsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id at which point in the category hierarchy should the 'get products' be started.
            var continuationToken = continuationToken_example;  // string | The continuation token used for pagination (optional) 
            var pageSize = 56;  // int? | The maximum number of products to return. Default value : 10 (optional) 
            var includeVariants = true;  // bool? | whether or not to include the variants (if they exists) of the product. (optional) 
            var includePriceLists = true;  // bool? | whether or not to include the price lists of the product. (optional) 
            var includeRelationships = true;  // bool? |  Gets or sets a value indicating whether or not to include the relationships of the product. (optional) 
            var includeMedia = true;  // bool? |  Gets or sets a value indicating whether or not to include the media of the product. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve products from a category - {GetProductsByCategoryV2Request}
                ProductListPage result = apiInstance.GetProductsByCategoryV2Requestv2ScopeIdCategoryIdproductsGet(accept, scopeId, categoryId, continuationToken, pageSize, includeVariants, includePriceLists, includeRelationships, includeMedia, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetProductsByCategoryV2Requestv2ScopeIdCategoryIdproductsGet: " + e.Message );
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
 **categoryId** | **string**| The category id at which point in the category hierarchy should the &#39;get products&#39; be started. | 
 **continuationToken** | **string**| The continuation token used for pagination | [optional] 
 **pageSize** | **int?**| The maximum number of products to return. Default value : 10 | [optional] 
 **includeVariants** | **bool?**| whether or not to include the variants (if they exists) of the product. | [optional] 
 **includePriceLists** | **bool?**| whether or not to include the price lists of the product. | [optional] 
 **includeRelationships** | **bool?**|  Gets or sets a value indicating whether or not to include the relationships of the product. | [optional] 
 **includeMedia** | **bool?**|  Gets or sets a value indicating whether or not to include the media of the product. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**ProductListPage**](ProductListPage.md)

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

<a name="updatecategoryrequestscopeidcategoryidpost"></a>
# **UpdateCategoryRequestScopeIdCategoryIdPost**
> Category UpdateCategoryRequestScopeIdCategoryIdPost (string accept, string scopeId, string categoryId, UpdateCategoryRequest body = null)

Update an existing category - {UpdateCategoryRequest}

Update an existing category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCategoryRequestScopeIdCategoryIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category's id.
            var body = new UpdateCategoryRequest(); // UpdateCategoryRequest |  (optional) 

            try
            {
                // Update an existing category - {UpdateCategoryRequest}
                Category result = apiInstance.UpdateCategoryRequestScopeIdCategoryIdPost(accept, scopeId, categoryId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategoryRequestScopeIdCategoryIdPost: " + e.Message );
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
 **categoryId** | **string**| The category&#39;s id. | 
 **body** | [**UpdateCategoryRequest**](UpdateCategoryRequest.md)|  | [optional] 

### Return type

[**Category**](Category.md)

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

<a name="updatecategorysequencerequestscopeidcategoryidchildrensequencepost"></a>
# **UpdateCategorySequenceRequestScopeIdCategoryIdchildrensequencePost**
> UpdateCategorySequenceResponse UpdateCategorySequenceRequestScopeIdCategoryIdchildrensequencePost (string accept, string scopeId, string categoryId, UpdateCategorySequenceRequest body = null)

Update categories sequence - {UpdateCategorySequenceRequest}

Update categories sequence

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCategorySequenceRequestScopeIdCategoryIdchildrensequencePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category to which the child categories are associated.
            var body = new UpdateCategorySequenceRequest(); // UpdateCategorySequenceRequest |  (optional) 

            try
            {
                // Update categories sequence - {UpdateCategorySequenceRequest}
                UpdateCategorySequenceResponse result = apiInstance.UpdateCategorySequenceRequestScopeIdCategoryIdchildrensequencePost(accept, scopeId, categoryId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategorySequenceRequestScopeIdCategoryIdchildrensequencePost: " + e.Message );
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
 **categoryId** | **string**| The category to which the child categories are associated. | 
 **body** | [**UpdateCategorySequenceRequest**](UpdateCategorySequenceRequest.md)|  | [optional] 

### Return type

[**UpdateCategorySequenceResponse**](UpdateCategorySequenceResponse.md)

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

<a name="updatecategoryv2requestv2scopeidcategoryidcreate"></a>
# **UpdateCategoryV2Requestv2ScopeIdCategoryIdCreate**
> Category UpdateCategoryV2Requestv2ScopeIdCategoryIdCreate (string accept, string scopeId, string categoryId, UpdateCategoryV2Request body = null)

Update an existing category - {UpdateCategoryV2Request}

Update an existing category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCategoryV2Requestv2ScopeIdCategoryIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CategoriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category's id.
            var body = new UpdateCategoryV2Request(); // UpdateCategoryV2Request |  (optional) 

            try
            {
                // Update an existing category - {UpdateCategoryV2Request}
                Category result = apiInstance.UpdateCategoryV2Requestv2ScopeIdCategoryIdCreate(accept, scopeId, categoryId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategoryV2Requestv2ScopeIdCategoryIdCreate: " + e.Message );
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
 **categoryId** | **string**| The category&#39;s id. | 
 **body** | [**UpdateCategoryV2Request**](UpdateCategoryV2Request.md)|  | [optional] 

### Return type

[**Category**](Category.md)

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

