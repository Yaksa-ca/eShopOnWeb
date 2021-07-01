# Yaksa.OrckestraCommerce.Client.Api.RelationshipsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearRelationshipsRequestScopeIdEntityTypeEntityIdDelete**](RelationshipsApi.md#clearrelationshipsrequestscopeidentitytypeentityiddelete) | **DELETE** /relationships/{ScopeId}/{EntityType}/{EntityId} | Clears all relationships on the specified entity - {ClearRelationshipsRequest}
[**ClearRelationshipsV2Requestv2ScopeIdEntityTypeEntityIdDelete**](RelationshipsApi.md#clearrelationshipsv2requestv2scopeidentitytypeentityiddelete) | **DELETE** /relationships/v2/{ScopeId}/{EntityType}/{EntityId} | Clears all relationships on the specified entity - {ClearRelationshipsV2Request}
[**CreateRelationshipsRequestScopeIdPost**](RelationshipsApi.md#createrelationshipsrequestscopeidpost) | **POST** /relationships/{ScopeId} | Creates relationships between entities - {CreateRelationshipsRequest}
[**CreateRelationshipsV2Requestv2ScopeIdPost**](RelationshipsApi.md#createrelationshipsv2requestv2scopeidpost) | **POST** /relationships/v2/{ScopeId} | Creates relationships between entities - {CreateRelationshipsV2Request}
[**CreateSelfReferencingRelationshipsRequestScopeIdselfPost**](RelationshipsApi.md#createselfreferencingrelationshipsrequestscopeidselfpost) | **POST** /relationships/{ScopeId}/self | Creates self-referencing relationships between entities - {CreateSelfReferencingRelationshipsRequest}
[**CreateSelfReferencingRelationshipsV2Requestv2ScopeIdselfPost**](RelationshipsApi.md#createselfreferencingrelationshipsv2requestv2scopeidselfpost) | **POST** /relationships/v2/{ScopeId}/self | Creates self-referencing relationships between entities - {CreateSelfReferencingRelationshipsV2Request}
[**DeleteRelationshipsRequestScopeIdDelete**](RelationshipsApi.md#deleterelationshipsrequestscopeiddelete) | **DELETE** /relationships/{ScopeId} | Deletes specified relationships - {DeleteRelationshipsRequest}
[**DeleteRelationshipsV2Requestv2ScopeIdDelete**](RelationshipsApi.md#deleterelationshipsv2requestv2scopeiddelete) | **DELETE** /relationships/v2/{ScopeId} | Deletes specified relationships - {DeleteRelationshipsV2Request}


<a name="clearrelationshipsrequestscopeidentitytypeentityiddelete"></a>
# **ClearRelationshipsRequestScopeIdEntityTypeEntityIdDelete**
> void ClearRelationshipsRequestScopeIdEntityTypeEntityIdDelete (string accept, string scopeId, string entityType, string entityId, string parentId = null)

Clears all relationships on the specified entity - {ClearRelationshipsRequest}

Clears all relationships on the specified entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ClearRelationshipsRequestScopeIdEntityTypeEntityIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityType = entityType_example;  // string | the type of the entity
            var entityId = entityId_example;  // string | the entity identifier
            var parentId = parentId_example;  // string | the parent identifier (optional) 

            try
            {
                // Clears all relationships on the specified entity - {ClearRelationshipsRequest}
                apiInstance.ClearRelationshipsRequestScopeIdEntityTypeEntityIdDelete(accept, scopeId, entityType, entityId, parentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.ClearRelationshipsRequestScopeIdEntityTypeEntityIdDelete: " + e.Message );
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
 **entityType** | **string**| the type of the entity | 
 **entityId** | **string**| the entity identifier | 
 **parentId** | **string**| the parent identifier | [optional] 

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

<a name="clearrelationshipsv2requestv2scopeidentitytypeentityiddelete"></a>
# **ClearRelationshipsV2Requestv2ScopeIdEntityTypeEntityIdDelete**
> void ClearRelationshipsV2Requestv2ScopeIdEntityTypeEntityIdDelete (string accept, string scopeId, string entityType, string entityId, string parentId = null)

Clears all relationships on the specified entity - {ClearRelationshipsV2Request}

Clears all relationships on the specified entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ClearRelationshipsV2Requestv2ScopeIdEntityTypeEntityIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityType = entityType_example;  // string | The type of the entity whose relationship should be deleted. For deleting relationships of a product variant, 'Product' should be specified and ParentId should be set to Product Id.
            var entityId = entityId_example;  // string | the entity identifier
            var parentId = parentId_example;  // string | This parameter should be specified when deleting a product variant. In this case this field will contain product's Id. (optional) 

            try
            {
                // Clears all relationships on the specified entity - {ClearRelationshipsV2Request}
                apiInstance.ClearRelationshipsV2Requestv2ScopeIdEntityTypeEntityIdDelete(accept, scopeId, entityType, entityId, parentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.ClearRelationshipsV2Requestv2ScopeIdEntityTypeEntityIdDelete: " + e.Message );
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
 **entityType** | **string**| The type of the entity whose relationship should be deleted. For deleting relationships of a product variant, &#39;Product&#39; should be specified and ParentId should be set to Product Id. | 
 **entityId** | **string**| the entity identifier | 
 **parentId** | **string**| This parameter should be specified when deleting a product variant. In this case this field will contain product&#39;s Id. | [optional] 

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

<a name="createrelationshipsrequestscopeidpost"></a>
# **CreateRelationshipsRequestScopeIdPost**
> CreateRelationshipsResult CreateRelationshipsRequestScopeIdPost (string accept, string scopeId, CreateRelationshipsRequest body = null)

Creates relationships between entities - {CreateRelationshipsRequest}

Creates relationships between entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateRelationshipsRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateRelationshipsRequest(); // CreateRelationshipsRequest |  (optional) 

            try
            {
                // Creates relationships between entities - {CreateRelationshipsRequest}
                CreateRelationshipsResult result = apiInstance.CreateRelationshipsRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.CreateRelationshipsRequestScopeIdPost: " + e.Message );
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
 **body** | [**CreateRelationshipsRequest**](CreateRelationshipsRequest.md)|  | [optional] 

### Return type

[**CreateRelationshipsResult**](CreateRelationshipsResult.md)

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

<a name="createrelationshipsv2requestv2scopeidpost"></a>
# **CreateRelationshipsV2Requestv2ScopeIdPost**
> CreateRelationshipsResult CreateRelationshipsV2Requestv2ScopeIdPost (string accept, string scopeId, CreateRelationshipsV2Request body = null)

Creates relationships between entities - {CreateRelationshipsV2Request}

Creates relationships between entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateRelationshipsV2Requestv2ScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateRelationshipsV2Request(); // CreateRelationshipsV2Request |  (optional) 

            try
            {
                // Creates relationships between entities - {CreateRelationshipsV2Request}
                CreateRelationshipsResult result = apiInstance.CreateRelationshipsV2Requestv2ScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.CreateRelationshipsV2Requestv2ScopeIdPost: " + e.Message );
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
 **body** | [**CreateRelationshipsV2Request**](CreateRelationshipsV2Request.md)|  | [optional] 

### Return type

[**CreateRelationshipsResult**](CreateRelationshipsResult.md)

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

<a name="createselfreferencingrelationshipsrequestscopeidselfpost"></a>
# **CreateSelfReferencingRelationshipsRequestScopeIdselfPost**
> CreateRelationshipsResult CreateSelfReferencingRelationshipsRequestScopeIdselfPost (string accept, string scopeId, CreateSelfReferencingRelationshipsRequest body = null)

Creates self-referencing relationships between entities - {CreateSelfReferencingRelationshipsRequest}

Creates self-referencing relationships between entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateSelfReferencingRelationshipsRequestScopeIdselfPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateSelfReferencingRelationshipsRequest(); // CreateSelfReferencingRelationshipsRequest |  (optional) 

            try
            {
                // Creates self-referencing relationships between entities - {CreateSelfReferencingRelationshipsRequest}
                CreateRelationshipsResult result = apiInstance.CreateSelfReferencingRelationshipsRequestScopeIdselfPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.CreateSelfReferencingRelationshipsRequestScopeIdselfPost: " + e.Message );
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
 **body** | [**CreateSelfReferencingRelationshipsRequest**](CreateSelfReferencingRelationshipsRequest.md)|  | [optional] 

### Return type

[**CreateRelationshipsResult**](CreateRelationshipsResult.md)

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

<a name="createselfreferencingrelationshipsv2requestv2scopeidselfpost"></a>
# **CreateSelfReferencingRelationshipsV2Requestv2ScopeIdselfPost**
> CreateRelationshipsResult CreateSelfReferencingRelationshipsV2Requestv2ScopeIdselfPost (string accept, string scopeId, CreateSelfReferencingRelationshipsV2Request body = null)

Creates self-referencing relationships between entities - {CreateSelfReferencingRelationshipsV2Request}

Creates self-referencing relationships between entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateSelfReferencingRelationshipsV2Requestv2ScopeIdselfPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateSelfReferencingRelationshipsV2Request(); // CreateSelfReferencingRelationshipsV2Request |  (optional) 

            try
            {
                // Creates self-referencing relationships between entities - {CreateSelfReferencingRelationshipsV2Request}
                CreateRelationshipsResult result = apiInstance.CreateSelfReferencingRelationshipsV2Requestv2ScopeIdselfPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.CreateSelfReferencingRelationshipsV2Requestv2ScopeIdselfPost: " + e.Message );
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
 **body** | [**CreateSelfReferencingRelationshipsV2Request**](CreateSelfReferencingRelationshipsV2Request.md)|  | [optional] 

### Return type

[**CreateRelationshipsResult**](CreateRelationshipsResult.md)

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

<a name="deleterelationshipsrequestscopeiddelete"></a>
# **DeleteRelationshipsRequestScopeIdDelete**
> void DeleteRelationshipsRequestScopeIdDelete (string accept, string scopeId, List<string> ids = null)

Deletes specified relationships - {DeleteRelationshipsRequest}

Deletes specified relationships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteRelationshipsRequestScopeIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var ids = new List<string>(); // List<string> | Ids of the relationships to delete (optional) 

            try
            {
                // Deletes specified relationships - {DeleteRelationshipsRequest}
                apiInstance.DeleteRelationshipsRequestScopeIdDelete(accept, scopeId, ids);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.DeleteRelationshipsRequestScopeIdDelete: " + e.Message );
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
 **ids** | [**List&lt;string&gt;**](string.md)| Ids of the relationships to delete | [optional] 

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

<a name="deleterelationshipsv2requestv2scopeiddelete"></a>
# **DeleteRelationshipsV2Requestv2ScopeIdDelete**
> void DeleteRelationshipsV2Requestv2ScopeIdDelete (string accept, string scopeId, List<string> ids = null)

Deletes specified relationships - {DeleteRelationshipsV2Request}

Deletes specified relationships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteRelationshipsV2Requestv2ScopeIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new RelationshipsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var ids = new List<string>(); // List<string> | Ids of the relationships to delete (optional) 

            try
            {
                // Deletes specified relationships - {DeleteRelationshipsV2Request}
                apiInstance.DeleteRelationshipsV2Requestv2ScopeIdDelete(accept, scopeId, ids);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.DeleteRelationshipsV2Requestv2ScopeIdDelete: " + e.Message );
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
 **ids** | [**List&lt;string&gt;**](string.md)| Ids of the relationships to delete | [optional] 

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

