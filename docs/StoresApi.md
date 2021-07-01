# Yaksa.OrckestraCommerce.Client.Api.StoresApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateStoreByNumberRequestScopeIdNumberPost**](StoresApi.md#createorupdatestorebynumberrequestscopeidnumberpost) | **POST** /stores/{ScopeId}/{Number} | Create or update a store using its number - {CreateOrUpdateStoreByNumberRequest}
[**DeleteStoreRequestScopeIdIdDelete**](StoresApi.md#deletestorerequestscopeididdelete) | **DELETE** /stores/{ScopeId}/{Id} | Deletes a store using its Id - {DeleteStoreRequest}
[**FindNearestStoresRequestScopeIdnearSearchTermsGet**](StoresApi.md#findneareststoresrequestscopeidnearsearchtermsget) | **GET** /stores/{ScopeId}/near/{SearchTerms} | Find the nearest stores based on search terms - {FindNearestStoresRequest}
[**FindStoresRequestScopeIdfindPost**](StoresApi.md#findstoresrequestscopeidfindpost) | **POST** /stores/{ScopeId}/find | Search for Stores based on search terms - {FindStoresRequest}
[**GetStoreByNameRequestScopeIdbyNameNameGet**](StoresApi.md#getstorebynamerequestscopeidbynamenameget) | **GET** /stores/{ScopeId}/byName/{Name} | Retrieve a store using its name - {GetStoreByNameRequest}
[**GetStoreByNumberRequestScopeIdbyNumberNumberGet**](StoresApi.md#getstorebynumberrequestscopeidbynumbernumberget) | **GET** /stores/{ScopeId}/byNumber/{Number} | Retrieve a store using its number - {GetStoreByNumberRequest}
[**GetStoreRequestScopeIdIdGet**](StoresApi.md#getstorerequestscopeididget) | **GET** /stores/{ScopeId}/{Id} | Retrieves a store using its Id - {GetStoreRequest}


<a name="createorupdatestorebynumberrequestscopeidnumberpost"></a>
# **CreateOrUpdateStoreByNumberRequestScopeIdNumberPost**
> Store CreateOrUpdateStoreByNumberRequestScopeIdNumberPost (string accept, string scopeId, string number, CreateOrUpdateStoreByNumberRequest body = null)

Create or update a store using its number - {CreateOrUpdateStoreByNumberRequest}

Creates or updates a store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrUpdateStoreByNumberRequestScopeIdNumberPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new StoresApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var number = number_example;  // string | a business centric number to identify the store that could be used to link the store to external data.
            var body = new CreateOrUpdateStoreByNumberRequest(); // CreateOrUpdateStoreByNumberRequest |  (optional) 

            try
            {
                // Create or update a store using its number - {CreateOrUpdateStoreByNumberRequest}
                Store result = apiInstance.CreateOrUpdateStoreByNumberRequestScopeIdNumberPost(accept, scopeId, number, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoresApi.CreateOrUpdateStoreByNumberRequestScopeIdNumberPost: " + e.Message );
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
 **number** | **string**| a business centric number to identify the store that could be used to link the store to external data. | 
 **body** | [**CreateOrUpdateStoreByNumberRequest**](CreateOrUpdateStoreByNumberRequest.md)|  | [optional] 

### Return type

[**Store**](Store.md)

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

<a name="deletestorerequestscopeididdelete"></a>
# **DeleteStoreRequestScopeIdIdDelete**
> void DeleteStoreRequestScopeIdIdDelete (string accept, string scopeId, string id)

Deletes a store using its Id - {DeleteStoreRequest}

Deletes a specific store using its Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteStoreRequestScopeIdIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new StoresApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | the unique id of the Store

            try
            {
                // Deletes a store using its Id - {DeleteStoreRequest}
                apiInstance.DeleteStoreRequestScopeIdIdDelete(accept, scopeId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoresApi.DeleteStoreRequestScopeIdIdDelete: " + e.Message );
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
 **id** | **string**| the unique id of the Store | 

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
| **401** | You must be authenticated to use this request |  -  |
| **404** | Requested store not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findneareststoresrequestscopeidnearsearchtermsget"></a>
# **FindNearestStoresRequestScopeIdnearSearchTermsGet**
> FindNearestStoresResult FindNearestStoresRequestScopeIdnearSearchTermsGet (string accept, string scopeId, string searchTerms, int? startingIndex = null, int? maximumItemsCount = null, string fulfillmentMethodType = null)

Find the nearest stores based on search terms - {FindNearestStoresRequest}

Search for the nearest Stores based on search terms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindNearestStoresRequestScopeIdnearSearchTermsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new StoresApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var searchTerms = searchTerms_example;  // string | The search terms.
            var startingIndex = 56;  // int? | The starting index used to find the stores (optional) 
            var maximumItemsCount = 56;  // int? | The maximum number of stores (optional) 
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | The fulfillment method type used to filter the stores. (optional) 

            try
            {
                // Find the nearest stores based on search terms - {FindNearestStoresRequest}
                FindNearestStoresResult result = apiInstance.FindNearestStoresRequestScopeIdnearSearchTermsGet(accept, scopeId, searchTerms, startingIndex, maximumItemsCount, fulfillmentMethodType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoresApi.FindNearestStoresRequestScopeIdnearSearchTermsGet: " + e.Message );
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
 **searchTerms** | **string**| The search terms. | 
 **startingIndex** | **int?**| The starting index used to find the stores | [optional] 
 **maximumItemsCount** | **int?**| The maximum number of stores | [optional] 
 **fulfillmentMethodType** | **string**| The fulfillment method type used to filter the stores. | [optional] 

### Return type

[**FindNearestStoresResult**](FindNearestStoresResult.md)

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

<a name="findstoresrequestscopeidfindpost"></a>
# **FindStoresRequestScopeIdfindPost**
> FindStoresQueryResult FindStoresRequestScopeIdfindPost (string accept, string scopeId, FindStoresRequest body = null)

Search for Stores based on search terms - {FindStoresRequest}

Search for Stores based on search terms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindStoresRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new StoresApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindStoresRequest(); // FindStoresRequest |  (optional) 

            try
            {
                // Search for Stores based on search terms - {FindStoresRequest}
                FindStoresQueryResult result = apiInstance.FindStoresRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoresApi.FindStoresRequestScopeIdfindPost: " + e.Message );
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
 **body** | [**FindStoresRequest**](FindStoresRequest.md)|  | [optional] 

### Return type

[**FindStoresQueryResult**](FindStoresQueryResult.md)

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

<a name="getstorebynamerequestscopeidbynamenameget"></a>
# **GetStoreByNameRequestScopeIdbyNameNameGet**
> Store GetStoreByNameRequestScopeIdbyNameNameGet (string accept, string scopeId, string name, string cultureName = null, bool? includeAddresses = null, bool? includeSchedules = null, bool? includeOperatingStatus = null)

Retrieve a store using its name - {GetStoreByNameRequest}

Retrieve a specific store using its name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetStoreByNameRequestScopeIdbyNameNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new StoresApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var name = name_example;  // string | the name of the store.
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load the collection of addresses linked to the store. (optional) 
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the store. (optional) 
            var includeOperatingStatus = true;  // bool? | Specifies whether or not to load the operating status the store. (optional) 

            try
            {
                // Retrieve a store using its name - {GetStoreByNameRequest}
                Store result = apiInstance.GetStoreByNameRequestScopeIdbyNameNameGet(accept, scopeId, name, cultureName, includeAddresses, includeSchedules, includeOperatingStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreByNameRequestScopeIdbyNameNameGet: " + e.Message );
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
 **name** | **string**| the name of the store. | 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load the collection of addresses linked to the store. | [optional] 
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the store. | [optional] 
 **includeOperatingStatus** | **bool?**| Specifies whether or not to load the operating status the store. | [optional] 

### Return type

[**Store**](Store.md)

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
| **404** | Requested store not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorebynumberrequestscopeidbynumbernumberget"></a>
# **GetStoreByNumberRequestScopeIdbyNumberNumberGet**
> Store GetStoreByNumberRequestScopeIdbyNumberNumberGet (string accept, string scopeId, string number, string cultureName = null, bool? includeAddresses = null, bool? includeSchedules = null, bool? includeOperatingStatus = null)

Retrieve a store using its number - {GetStoreByNumberRequest}

Retrieve a specific store using its number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetStoreByNumberRequestScopeIdbyNumberNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new StoresApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var number = number_example;  // string | the number of the store.
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load the collection of addresses linked to the store. (optional) 
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the store. (optional) 
            var includeOperatingStatus = true;  // bool? | Specifies whether or not to load the operating status the store. (optional) 

            try
            {
                // Retrieve a store using its number - {GetStoreByNumberRequest}
                Store result = apiInstance.GetStoreByNumberRequestScopeIdbyNumberNumberGet(accept, scopeId, number, cultureName, includeAddresses, includeSchedules, includeOperatingStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreByNumberRequestScopeIdbyNumberNumberGet: " + e.Message );
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
 **number** | **string**| the number of the store. | 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load the collection of addresses linked to the store. | [optional] 
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the store. | [optional] 
 **includeOperatingStatus** | **bool?**| Specifies whether or not to load the operating status the store. | [optional] 

### Return type

[**Store**](Store.md)

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
| **404** | Requested store not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorerequestscopeididget"></a>
# **GetStoreRequestScopeIdIdGet**
> Store GetStoreRequestScopeIdIdGet (string accept, string scopeId, string id, string cultureName = null, bool? includeAddresses = null, bool? includeSchedules = null, bool? includeOperatingStatus = null)

Retrieves a store using its Id - {GetStoreRequest}

Retrieve a specific store using its Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetStoreRequestScopeIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new StoresApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | the unique id of the Store
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load the collection of addresses linked to the store. (optional) 
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the store. (optional) 
            var includeOperatingStatus = true;  // bool? | Specifies whether or not to load the operating status the store. (optional) 

            try
            {
                // Retrieves a store using its Id - {GetStoreRequest}
                Store result = apiInstance.GetStoreRequestScopeIdIdGet(accept, scopeId, id, cultureName, includeAddresses, includeSchedules, includeOperatingStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreRequestScopeIdIdGet: " + e.Message );
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
 **id** | **string**| the unique id of the Store | 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load the collection of addresses linked to the store. | [optional] 
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the store. | [optional] 
 **includeOperatingStatus** | **bool?**| Specifies whether or not to load the operating status the store. | [optional] 

### Return type

[**Store**](Store.md)

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
| **404** | Requested store not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

