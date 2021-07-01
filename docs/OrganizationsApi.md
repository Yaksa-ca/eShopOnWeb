# Yaksa.OrckestraCommerce.Client.Api.OrganizationsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrganizationRequestScopeIdPost**](OrganizationsApi.md#createorganizationrequestscopeidpost) | **POST** /organizations/{ScopeId} | Create an organization - {CreateOrganizationRequest}
[**FindOrganizationsRequestScopeIdfindPost**](OrganizationsApi.md#findorganizationsrequestscopeidfindpost) | **POST** /organizations/{ScopeId}/find | Search for Organizations based on search terms - {FindOrganizationsRequest}
[**GetCustomersByOrganizationNameRequestScopeIdbyNameNamecustomersGet**](OrganizationsApi.md#getcustomersbyorganizationnamerequestscopeidbynamenamecustomersget) | **GET** /organizations/{ScopeId}/byName/{Name}/customers | Retrieve Customers based on the organization name - {GetCustomersByOrganizationNameRequest}
[**GetCustomersByOrganizationRequestScopeIdOrganizationIdcustomersGet**](OrganizationsApi.md#getcustomersbyorganizationrequestscopeidorganizationidcustomersget) | **GET** /organizations/{ScopeId}/{OrganizationId}/customers | Retrieve Customers based on the organization id - {GetCustomersByOrganizationRequest}
[**GetOrganizationByNameRequestScopeIdbyNameNameGet**](OrganizationsApi.md#getorganizationbynamerequestscopeidbynamenameget) | **GET** /organizations/{ScopeId}/byName/{Name} | Retreive a specific organization by name - {GetOrganizationByNameRequest}
[**GetOrganizationRequestScopeIdOrganizationIdGet**](OrganizationsApi.md#getorganizationrequestscopeidorganizationidget) | **GET** /organizations/{ScopeId}/{OrganizationId} | Retreive a specific organization - {GetOrganizationRequest}
[**UpdateOrganizationRequestScopeIdOrganizationIdCreate**](OrganizationsApi.md#updateorganizationrequestscopeidorganizationidcreate) | **PUT** /organizations/{ScopeId}/{OrganizationId} | Update an organization - {UpdateOrganizationRequest}


<a name="createorganizationrequestscopeidpost"></a>
# **CreateOrganizationRequestScopeIdPost**
> Organization CreateOrganizationRequestScopeIdPost (string accept, string scopeId, CreateOrganizationRequest body = null)

Create an organization - {CreateOrganizationRequest}

Create an organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrganizationRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrganizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope in which the organization belong.
            var body = new CreateOrganizationRequest(); // CreateOrganizationRequest |  (optional) 

            try
            {
                // Create an organization - {CreateOrganizationRequest}
                Organization result = apiInstance.CreateOrganizationRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.CreateOrganizationRequestScopeIdPost: " + e.Message );
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
 **scopeId** | **string**| The scope in which the organization belong. | 
 **body** | [**CreateOrganizationRequest**](CreateOrganizationRequest.md)|  | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findorganizationsrequestscopeidfindpost"></a>
# **FindOrganizationsRequestScopeIdfindPost**
> FindOrganizationsQueryResult FindOrganizationsRequestScopeIdfindPost (string accept, string scopeId, FindOrganizationsRequest body = null)

Search for Organizations based on search terms - {FindOrganizationsRequest}

Search for Organizations based on search terms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindOrganizationsRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrganizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindOrganizationsRequest(); // FindOrganizationsRequest |  (optional) 

            try
            {
                // Search for Organizations based on search terms - {FindOrganizationsRequest}
                FindOrganizationsQueryResult result = apiInstance.FindOrganizationsRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FindOrganizationsRequestScopeIdfindPost: " + e.Message );
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
 **body** | [**FindOrganizationsRequest**](FindOrganizationsRequest.md)|  | [optional] 

### Return type

[**FindOrganizationsQueryResult**](FindOrganizationsQueryResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomersbyorganizationnamerequestscopeidbynamenamecustomersget"></a>
# **GetCustomersByOrganizationNameRequestScopeIdbyNameNamecustomersGet**
> GetCustomersByOrganizationQueryResult GetCustomersByOrganizationNameRequestScopeIdbyNameNamecustomersGet (string accept, string scopeId, string name, int? startingIndex = null, int? maximumItems = null, bool? includeAddresses = null)

Retrieve Customers based on the organization name - {GetCustomersByOrganizationNameRequest}

Retrieve the customers of an organization. Paging is available

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomersByOrganizationNameRequestScopeIdbyNameNamecustomersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrganizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var name = name_example;  // string | The organization name of the Customer to search for.
            var startingIndex = 56;  // int? | The starting index. (optional) 
            var maximumItems = 56;  // int? | The maximum items returned by the search query. (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to fully load the collection of addresses linked to the customer. (optional) 

            try
            {
                // Retrieve Customers based on the organization name - {GetCustomersByOrganizationNameRequest}
                GetCustomersByOrganizationQueryResult result = apiInstance.GetCustomersByOrganizationNameRequestScopeIdbyNameNamecustomersGet(accept, scopeId, name, startingIndex, maximumItems, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetCustomersByOrganizationNameRequestScopeIdbyNameNamecustomersGet: " + e.Message );
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
 **name** | **string**| The organization name of the Customer to search for. | 
 **startingIndex** | **int?**| The starting index. | [optional] 
 **maximumItems** | **int?**| The maximum items returned by the search query. | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to fully load the collection of addresses linked to the customer. | [optional] 

### Return type

[**GetCustomersByOrganizationQueryResult**](GetCustomersByOrganizationQueryResult.md)

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

<a name="getcustomersbyorganizationrequestscopeidorganizationidcustomersget"></a>
# **GetCustomersByOrganizationRequestScopeIdOrganizationIdcustomersGet**
> GetCustomersByOrganizationQueryResult GetCustomersByOrganizationRequestScopeIdOrganizationIdcustomersGet (string accept, string scopeId, string organizationId, int? startingIndex = null, int? maximumItems = null, bool? includeAddresses = null)

Retrieve Customers based on the organization id - {GetCustomersByOrganizationRequest}

Retrieve the Customers based on the organization id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomersByOrganizationRequestScopeIdOrganizationIdcustomersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrganizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var organizationId = organizationId_example;  // string | The organization identifier of the customer to search for.
            var startingIndex = 56;  // int? | The starting index. (optional) 
            var maximumItems = 56;  // int? | The maximum items returned by the search query. (optional) 
            var includeAddresses = true;  // bool? | Whether or not to fully load the collection of addresses linked to the customer. (optional) 

            try
            {
                // Retrieve Customers based on the organization id - {GetCustomersByOrganizationRequest}
                GetCustomersByOrganizationQueryResult result = apiInstance.GetCustomersByOrganizationRequestScopeIdOrganizationIdcustomersGet(accept, scopeId, organizationId, startingIndex, maximumItems, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetCustomersByOrganizationRequestScopeIdOrganizationIdcustomersGet: " + e.Message );
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
 **organizationId** | **string**| The organization identifier of the customer to search for. | 
 **startingIndex** | **int?**| The starting index. | [optional] 
 **maximumItems** | **int?**| The maximum items returned by the search query. | [optional] 
 **includeAddresses** | **bool?**| Whether or not to fully load the collection of addresses linked to the customer. | [optional] 

### Return type

[**GetCustomersByOrganizationQueryResult**](GetCustomersByOrganizationQueryResult.md)

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

<a name="getorganizationbynamerequestscopeidbynamenameget"></a>
# **GetOrganizationByNameRequestScopeIdbyNameNameGet**
> Organization GetOrganizationByNameRequestScopeIdbyNameNameGet (string accept, string scopeId, string name, bool? includeAddresses = null)

Retreive a specific organization by name - {GetOrganizationByNameRequest}

Retrieve a specific organization by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrganizationByNameRequestScopeIdbyNameNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrganizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var name = name_example;  // string | The name of the organization to retrieve.
            var includeAddresses = true;  // bool? | Specifies whether or not to fully load the addresses. (optional) 

            try
            {
                // Retreive a specific organization by name - {GetOrganizationByNameRequest}
                Organization result = apiInstance.GetOrganizationByNameRequestScopeIdbyNameNameGet(accept, scopeId, name, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationByNameRequestScopeIdbyNameNameGet: " + e.Message );
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
 **name** | **string**| The name of the organization to retrieve. | 
 **includeAddresses** | **bool?**| Specifies whether or not to fully load the addresses. | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Organization with provided name does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationrequestscopeidorganizationidget"></a>
# **GetOrganizationRequestScopeIdOrganizationIdGet**
> Organization GetOrganizationRequestScopeIdOrganizationIdGet (string accept, string scopeId, string organizationId, bool? includeAddresses = null)

Retreive a specific organization - {GetOrganizationRequest}

Retrieve a specific organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrganizationRequestScopeIdOrganizationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrganizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var organizationId = organizationId_example;  // string | The identifier of the organization to retrieve.
            var includeAddresses = true;  // bool? | Specifies whether or not to fully load the addresses. (optional) 

            try
            {
                // Retreive a specific organization - {GetOrganizationRequest}
                Organization result = apiInstance.GetOrganizationRequestScopeIdOrganizationIdGet(accept, scopeId, organizationId, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationRequestScopeIdOrganizationIdGet: " + e.Message );
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
 **organizationId** | **string**| The identifier of the organization to retrieve. | 
 **includeAddresses** | **bool?**| Specifies whether or not to fully load the addresses. | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Organization with provided id does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganizationrequestscopeidorganizationidcreate"></a>
# **UpdateOrganizationRequestScopeIdOrganizationIdCreate**
> Organization UpdateOrganizationRequestScopeIdOrganizationIdCreate (string accept, string scopeId, string organizationId, UpdateOrganizationRequest body = null)

Update an organization - {UpdateOrganizationRequest}

Update an organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateOrganizationRequestScopeIdOrganizationIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrganizationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope in which the organization belong.
            var organizationId = organizationId_example;  // string | The unique identifier of the entity.
            var body = new UpdateOrganizationRequest(); // UpdateOrganizationRequest |  (optional) 

            try
            {
                // Update an organization - {UpdateOrganizationRequest}
                Organization result = apiInstance.UpdateOrganizationRequestScopeIdOrganizationIdCreate(accept, scopeId, organizationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationRequestScopeIdOrganizationIdCreate: " + e.Message );
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
 **scopeId** | **string**| The scope in which the organization belong. | 
 **organizationId** | **string**| The unique identifier of the entity. | 
 **body** | [**UpdateOrganizationRequest**](UpdateOrganizationRequest.md)|  | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

