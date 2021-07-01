# Yaksa.OrckestraCommerce.Client.Api.SearchqueriesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSearchQueryRequestScopeIdQueryTypeNamePost**](SearchqueriesApi.md#createsearchqueryrequestscopeidquerytypenamepost) | **POST** /searchqueries/{ScopeId}/{QueryType}/{Name} | Creates a Search Query. - {CreateSearchQueryRequest}
[**DeleteSearchQueryRequestScopeIdQueryTypeNameDelete**](SearchqueriesApi.md#deletesearchqueryrequestscopeidquerytypenamedelete) | **DELETE** /searchqueries/{ScopeId}/{QueryType}/{Name} | Deletes a search query based on its Scope, its type and its name. - {DeleteSearchQueryRequest}
[**FindSearchQueriesRequestScopeIdfindPost**](SearchqueriesApi.md#findsearchqueriesrequestscopeidfindpost) | **POST** /searchqueries/{ScopeId}/find | Finds search queries based on the Scope and the specified filters. - {FindSearchQueriesRequest}
[**GetSearchQueryByNameRequestScopeIdQueryTypeNameGet**](SearchqueriesApi.md#getsearchquerybynamerequestscopeidquerytypenameget) | **GET** /searchqueries/{ScopeId}/{QueryType}/{Name} | Gets a search query based on its Scope, its type and its name. - {GetSearchQueryByNameRequest}
[**UpdateSearchQueryRequestScopeIdQueryTypeNameCreate**](SearchqueriesApi.md#updatesearchqueryrequestscopeidquerytypenamecreate) | **PUT** /searchqueries/{ScopeId}/{QueryType}/{Name} | Updates a Search Query. - {UpdateSearchQueryRequest}


<a name="createsearchqueryrequestscopeidquerytypenamepost"></a>
# **CreateSearchQueryRequestScopeIdQueryTypeNamePost**
> SearchQuery CreateSearchQueryRequestScopeIdQueryTypeNamePost (string accept, string scopeId, string queryType, string name, CreateSearchQueryRequest body = null)

Creates a Search Query. - {CreateSearchQueryRequest}

Creates a Search Query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateSearchQueryRequestScopeIdQueryTypeNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchqueriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var queryType = queryType_example;  // string | The type of the requested search query
            var name = name_example;  // string | The name of the requested search query
            var body = new CreateSearchQueryRequest(); // CreateSearchQueryRequest |  (optional) 

            try
            {
                // Creates a Search Query. - {CreateSearchQueryRequest}
                SearchQuery result = apiInstance.CreateSearchQueryRequestScopeIdQueryTypeNamePost(accept, scopeId, queryType, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchqueriesApi.CreateSearchQueryRequestScopeIdQueryTypeNamePost: " + e.Message );
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
 **queryType** | **string**| The type of the requested search query | 
 **name** | **string**| The name of the requested search query | 
 **body** | [**CreateSearchQueryRequest**](CreateSearchQueryRequest.md)|  | [optional] 

### Return type

[**SearchQuery**](SearchQuery.md)

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

<a name="deletesearchqueryrequestscopeidquerytypenamedelete"></a>
# **DeleteSearchQueryRequestScopeIdQueryTypeNameDelete**
> void DeleteSearchQueryRequestScopeIdQueryTypeNameDelete (string accept, string scopeId, string queryType, string name)

Deletes a search query based on its Scope, its type and its name. - {DeleteSearchQueryRequest}

Deletes a search query based on its Scope, its type and its name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteSearchQueryRequestScopeIdQueryTypeNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchqueriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var queryType = queryType_example;  // string | The type of the requested search query
            var name = name_example;  // string | The name of the requested search query

            try
            {
                // Deletes a search query based on its Scope, its type and its name. - {DeleteSearchQueryRequest}
                apiInstance.DeleteSearchQueryRequestScopeIdQueryTypeNameDelete(accept, scopeId, queryType, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchqueriesApi.DeleteSearchQueryRequestScopeIdQueryTypeNameDelete: " + e.Message );
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
 **queryType** | **string**| The type of the requested search query | 
 **name** | **string**| The name of the requested search query | 

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

<a name="findsearchqueriesrequestscopeidfindpost"></a>
# **FindSearchQueriesRequestScopeIdfindPost**
> FindSearchQueriesResult FindSearchQueriesRequestScopeIdfindPost (string accept, string scopeId, FindSearchQueriesRequest body = null)

Finds search queries based on the Scope and the specified filters. - {FindSearchQueriesRequest}

Finds search queries based on the Scope and the specified filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindSearchQueriesRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchqueriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindSearchQueriesRequest(); // FindSearchQueriesRequest |  (optional) 

            try
            {
                // Finds search queries based on the Scope and the specified filters. - {FindSearchQueriesRequest}
                FindSearchQueriesResult result = apiInstance.FindSearchQueriesRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchqueriesApi.FindSearchQueriesRequestScopeIdfindPost: " + e.Message );
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
 **body** | [**FindSearchQueriesRequest**](FindSearchQueriesRequest.md)|  | [optional] 

### Return type

[**FindSearchQueriesResult**](FindSearchQueriesResult.md)

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

<a name="getsearchquerybynamerequestscopeidquerytypenameget"></a>
# **GetSearchQueryByNameRequestScopeIdQueryTypeNameGet**
> SearchQuery GetSearchQueryByNameRequestScopeIdQueryTypeNameGet (string accept, string scopeId, string queryType, string name, bool? useScopeStrictMode = null)

Gets a search query based on its Scope, its type and its name. - {GetSearchQueryByNameRequest}

Gets a search query based on its Scope, its type and its name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetSearchQueryByNameRequestScopeIdQueryTypeNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchqueriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var queryType = queryType_example;  // string | The type of the requested search query
            var name = name_example;  // string | The name of the requested search query
            var useScopeStrictMode = true;  // bool? | Indicates whether the system should use a strict mode (allow only Sales Scope), or should search for a parent Sales Scope (optional) 

            try
            {
                // Gets a search query based on its Scope, its type and its name. - {GetSearchQueryByNameRequest}
                SearchQuery result = apiInstance.GetSearchQueryByNameRequestScopeIdQueryTypeNameGet(accept, scopeId, queryType, name, useScopeStrictMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchqueriesApi.GetSearchQueryByNameRequestScopeIdQueryTypeNameGet: " + e.Message );
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
 **queryType** | **string**| The type of the requested search query | 
 **name** | **string**| The name of the requested search query | 
 **useScopeStrictMode** | **bool?**| Indicates whether the system should use a strict mode (allow only Sales Scope), or should search for a parent Sales Scope | [optional] 

### Return type

[**SearchQuery**](SearchQuery.md)

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
| **404** | No search query matching the provided parameters could be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesearchqueryrequestscopeidquerytypenamecreate"></a>
# **UpdateSearchQueryRequestScopeIdQueryTypeNameCreate**
> SearchQuery UpdateSearchQueryRequestScopeIdQueryTypeNameCreate (string accept, string scopeId, string queryType, string name, UpdateSearchQueryRequest body = null)

Updates a Search Query. - {UpdateSearchQueryRequest}

Updates a Search Query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateSearchQueryRequestScopeIdQueryTypeNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new SearchqueriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var queryType = queryType_example;  // string | The type of the requested search query
            var name = name_example;  // string | The name of the requested search query
            var body = new UpdateSearchQueryRequest(); // UpdateSearchQueryRequest |  (optional) 

            try
            {
                // Updates a Search Query. - {UpdateSearchQueryRequest}
                SearchQuery result = apiInstance.UpdateSearchQueryRequestScopeIdQueryTypeNameCreate(accept, scopeId, queryType, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchqueriesApi.UpdateSearchQueryRequestScopeIdQueryTypeNameCreate: " + e.Message );
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
 **queryType** | **string**| The type of the requested search query | 
 **name** | **string**| The name of the requested search query | 
 **body** | [**UpdateSearchQueryRequest**](UpdateSearchQueryRequest.md)|  | [optional] 

### Return type

[**SearchQuery**](SearchQuery.md)

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

