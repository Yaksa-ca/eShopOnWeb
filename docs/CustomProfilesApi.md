# Yaksa.OrckestraCommerce.Client.Api.CustomProfilesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAddressToCustomProfileRequestScopeIdEntityIdaddressesPost**](CustomProfilesApi.md#addaddresstocustomprofilerequestscopeidentityidaddressespost) | **POST** /customProfiles/{ScopeId}/{EntityId}/addresses | Add an address to a custom profile&#39;s addresses - {AddAddressToCustomProfileRequest}
[**AssociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdPost**](CustomProfilesApi.md#associateentityrequestscopeidparententitytypenameparentidattributenameentityidpost) | **POST** /customProfiles/{ScopeId}/{ParentEntityTypeName}/{ParentId}/{AttributeName}/{EntityId} | Associate two entities together - {AssociateEntityRequest}
[**CreateCustomProfileRequestScopeIdEntityTypeNamePost**](CustomProfilesApi.md#createcustomprofilerequestscopeidentitytypenamepost) | **POST** /customProfiles/{ScopeId}/{EntityTypeName} | Create a new custom profile - {CreateCustomProfileRequest}
[**DeleteCustomProfileRequestScopeIdEntityTypeNameEntityIdDelete**](CustomProfilesApi.md#deletecustomprofilerequestscopeidentitytypenameentityiddelete) | **DELETE** /customProfiles/{ScopeId}/{EntityTypeName}/{EntityId} | Deletes a existing custom profile - {DeleteCustomProfileRequest}
[**DisassociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdDelete**](CustomProfilesApi.md#disassociateentityrequestscopeidparententitytypenameparentidattributenameentityiddelete) | **DELETE** /customProfiles/{ScopeId}/{ParentEntityTypeName}/{ParentId}/{AttributeName}/{EntityId} | Removes the association between two entities - {DisassociateEntityRequest}
[**FindProfileInstancesRequestScopeIdEntityTypeNamefindPost**](CustomProfilesApi.md#findprofileinstancesrequestscopeidentitytypenamefindpost) | **POST** /customProfiles/{ScopeId}/{EntityTypeName}/find | Search for custom profiles based on search terms - {FindProfileInstancesRequest}
[**GetAssociatedScopesRequestScopeIdEntityTypeNameEntityIdscopesGet**](CustomProfilesApi.md#getassociatedscopesrequestscopeidentitytypenameentityidscopesget) | **GET** /customProfiles/{ScopeId}/{EntityTypeName}/{EntityId}/scopes | Retrieve the associated scopes - {GetAssociatedScopesRequest}
[**GetProfileInstanceByNameRequestScopeIdEntityTypeNamebyNameNameGet**](CustomProfilesApi.md#getprofileinstancebynamerequestscopeidentitytypenamebynamenameget) | **GET** /customProfiles/{ScopeId}/{EntityTypeName}/byName/{Name} | Retrieve custom profile instance by type and name - {GetProfileInstanceByNameRequest}
[**GetProfileInstanceRequestScopeIdEntityTypeNameEntityIdGet**](CustomProfilesApi.md#getprofileinstancerequestscopeidentitytypenameentityidget) | **GET** /customProfiles/{ScopeId}/{EntityTypeName}/{EntityId} | Retrieve a custom profile instance by type and id - {GetProfileInstanceRequest}
[**GetProfileInstancesRequestScopeIdEntityTypeNamebyIdsPost**](CustomProfilesApi.md#getprofileinstancesrequestscopeidentitytypenamebyidspost) | **POST** /customProfiles/{ScopeId}/{EntityTypeName}/byIds/ | Retrieve custom profile instances by type and id - {GetProfileInstancesRequest}
[**RemoveScopeAssociationRequestScopeIdEntityTypeNameEntityIdscopesDelete**](CustomProfilesApi.md#removescopeassociationrequestscopeidentitytypenameentityidscopesdelete) | **DELETE** /customProfiles/{ScopeId}/{EntityTypeName}/{EntityId}/scopes | Remove the association between a scope and a custom profile - {RemoveScopeAssociationRequest}
[**UpdateCustomProfileRequestScopeIdEntityTypeNameEntityIdCreate**](CustomProfilesApi.md#updatecustomprofilerequestscopeidentitytypenameentityidcreate) | **PUT** /customProfiles/{ScopeId}/{EntityTypeName}/{EntityId} | Updates a custom profile - {UpdateCustomProfileRequest}
[**UpdateScopeAssociationsRequestScopeIdEntityTypeNameEntityIdscopesCreate**](CustomProfilesApi.md#updatescopeassociationsrequestscopeidentitytypenameentityidscopescreate) | **PUT** /customProfiles/{ScopeId}/{EntityTypeName}/{EntityId}/scopes | Adds/Updates the association between scopes and an entity - {UpdateScopeAssociationsRequest}


<a name="addaddresstocustomprofilerequestscopeidentityidaddressespost"></a>
# **AddAddressToCustomProfileRequestScopeIdEntityIdaddressesPost**
> Address AddAddressToCustomProfileRequestScopeIdEntityIdaddressesPost (string accept, string scopeId, string entityId, AddAddressToCustomProfileRequest body = null)

Add an address to a custom profile's addresses - {AddAddressToCustomProfileRequest}

Add an address to a custom profiles's addresses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddAddressToCustomProfileRequestScopeIdEntityIdaddressesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityId = entityId_example;  // string | The unique identifier.
            var body = new AddAddressToCustomProfileRequest(); // AddAddressToCustomProfileRequest |  (optional) 

            try
            {
                // Add an address to a custom profile's addresses - {AddAddressToCustomProfileRequest}
                Address result = apiInstance.AddAddressToCustomProfileRequestScopeIdEntityIdaddressesPost(accept, scopeId, entityId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.AddAddressToCustomProfileRequestScopeIdEntityIdaddressesPost: " + e.Message );
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
 **entityId** | **string**| The unique identifier. | 
 **body** | [**AddAddressToCustomProfileRequest**](AddAddressToCustomProfileRequest.md)|  | [optional] 

### Return type

[**Address**](Address.md)

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

<a name="associateentityrequestscopeidparententitytypenameparentidattributenameentityidpost"></a>
# **AssociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdPost**
> void AssociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdPost (string accept, string scopeId, string parentEntityTypeName, string parentId, string attributeName, string entityId, Object body = null)

Associate two entities together - {AssociateEntityRequest}

Associate two entities together

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AssociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of scope in which the parent entity belongs.
            var parentEntityTypeName = parentEntityTypeName_example;  // string | Gets the name (business key) of the entity type of the profile instance to which the entity will be associated.
            var parentId = parentId_example;  // string | The unique identifier for the parent entity.
            var attributeName = attributeName_example;  // string | The name of the attribute in the parent definition under which the association is kept.
            var entityId = entityId_example;  // string | The unique identifier for the associated entity.
            var body = ;  // Object |  (optional) 

            try
            {
                // Associate two entities together - {AssociateEntityRequest}
                apiInstance.AssociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdPost(accept, scopeId, parentEntityTypeName, parentId, attributeName, entityId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.AssociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdPost: " + e.Message );
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
 **scopeId** | **string**| The id of scope in which the parent entity belongs. | 
 **parentEntityTypeName** | **string**| Gets the name (business key) of the entity type of the profile instance to which the entity will be associated. | 
 **parentId** | **string**| The unique identifier for the parent entity. | 
 **attributeName** | **string**| The name of the attribute in the parent definition under which the association is kept. | 
 **entityId** | **string**| The unique identifier for the associated entity. | 
 **body** | **Object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **422** | Validation error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomprofilerequestscopeidentitytypenamepost"></a>
# **CreateCustomProfileRequestScopeIdEntityTypeNamePost**
> CustomProfile CreateCustomProfileRequestScopeIdEntityTypeNamePost (string accept, string scopeId, string entityTypeName, CreateCustomProfileRequest body = null)

Create a new custom profile - {CreateCustomProfileRequest}

Create a new custom profile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCustomProfileRequestScopeIdEntityTypeNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityTypeName = entityTypeName_example;  // string | Entity type name.
            var body = new CreateCustomProfileRequest(); // CreateCustomProfileRequest |  (optional) 

            try
            {
                // Create a new custom profile - {CreateCustomProfileRequest}
                CustomProfile result = apiInstance.CreateCustomProfileRequestScopeIdEntityTypeNamePost(accept, scopeId, entityTypeName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.CreateCustomProfileRequestScopeIdEntityTypeNamePost: " + e.Message );
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
 **entityTypeName** | **string**| Entity type name. | 
 **body** | [**CreateCustomProfileRequest**](CreateCustomProfileRequest.md)|  | [optional] 

### Return type

[**CustomProfile**](CustomProfile.md)

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

<a name="deletecustomprofilerequestscopeidentitytypenameentityiddelete"></a>
# **DeleteCustomProfileRequestScopeIdEntityTypeNameEntityIdDelete**
> void DeleteCustomProfileRequestScopeIdEntityTypeNameEntityIdDelete (string accept, string scopeId, string entityTypeName, string entityId)

Deletes a existing custom profile - {DeleteCustomProfileRequest}

Deletes an existing custom profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteCustomProfileRequestScopeIdEntityTypeNameEntityIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityTypeName = entityTypeName_example;  // string | Entity type name.
            var entityId = entityId_example;  // string | The unique identifier of the entity.

            try
            {
                // Deletes a existing custom profile - {DeleteCustomProfileRequest}
                apiInstance.DeleteCustomProfileRequestScopeIdEntityTypeNameEntityIdDelete(accept, scopeId, entityTypeName, entityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.DeleteCustomProfileRequestScopeIdEntityTypeNameEntityIdDelete: " + e.Message );
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
 **entityTypeName** | **string**| Entity type name. | 
 **entityId** | **string**| The unique identifier of the entity. | 

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
| **404** | Custom profile to be deleted was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disassociateentityrequestscopeidparententitytypenameparentidattributenameentityiddelete"></a>
# **DisassociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdDelete**
> void DisassociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdDelete (string accept, string scopeId, string parentEntityTypeName, string parentId, string attributeName, string entityId)

Removes the association between two entities - {DisassociateEntityRequest}

Removes the association between two entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DisassociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of scope in which the parent entity belong.
            var parentEntityTypeName = parentEntityTypeName_example;  // string | Gets the name (business key) of the custom type of the profile instance to which the entity will be associated.
            var parentId = parentId_example;  // string | The unique identifier for the parent entity.
            var attributeName = attributeName_example;  // string | The name of the attribute in the parent definition under which the association is kept.
            var entityId = entityId_example;  // string | The unique identifier for the associated entity.

            try
            {
                // Removes the association between two entities - {DisassociateEntityRequest}
                apiInstance.DisassociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdDelete(accept, scopeId, parentEntityTypeName, parentId, attributeName, entityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.DisassociateEntityRequestScopeIdParentEntityTypeNameParentIdAttributeNameEntityIdDelete: " + e.Message );
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
 **scopeId** | **string**| The identifier of scope in which the parent entity belong. | 
 **parentEntityTypeName** | **string**| Gets the name (business key) of the custom type of the profile instance to which the entity will be associated. | 
 **parentId** | **string**| The unique identifier for the parent entity. | 
 **attributeName** | **string**| The name of the attribute in the parent definition under which the association is kept. | 
 **entityId** | **string**| The unique identifier for the associated entity. | 

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

<a name="findprofileinstancesrequestscopeidentitytypenamefindpost"></a>
# **FindProfileInstancesRequestScopeIdEntityTypeNamefindPost**
> FindProfileInstancesQueryResult FindProfileInstancesRequestScopeIdEntityTypeNamefindPost (string accept, string scopeId, string entityTypeName, FindProfileInstancesRequest body = null)

Search for custom profiles based on search terms - {FindProfileInstancesRequest}

Search for custom profiles based on search terms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindProfileInstancesRequestScopeIdEntityTypeNamefindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var entityTypeName = entityTypeName_example;  // string |  Gets or sets the entity type name of the profile instance.
            var body = new FindProfileInstancesRequest(); // FindProfileInstancesRequest |  (optional) 

            try
            {
                // Search for custom profiles based on search terms - {FindProfileInstancesRequest}
                FindProfileInstancesQueryResult result = apiInstance.FindProfileInstancesRequestScopeIdEntityTypeNamefindPost(accept, scopeId, entityTypeName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.FindProfileInstancesRequestScopeIdEntityTypeNamefindPost: " + e.Message );
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
 **entityTypeName** | **string**|  Gets or sets the entity type name of the profile instance. | 
 **body** | [**FindProfileInstancesRequest**](FindProfileInstancesRequest.md)|  | [optional] 

### Return type

[**FindProfileInstancesQueryResult**](FindProfileInstancesQueryResult.md)

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

<a name="getassociatedscopesrequestscopeidentitytypenameentityidscopesget"></a>
# **GetAssociatedScopesRequestScopeIdEntityTypeNameEntityIdscopesGet**
> List&lt;ScopeAssociation&gt; GetAssociatedScopesRequestScopeIdEntityTypeNameEntityIdscopesGet (string accept, string scopeId, string entityTypeName, string entityId)

Retrieve the associated scopes - {GetAssociatedScopesRequest}

Retrieve the associated scopes  for a given profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAssociatedScopesRequestScopeIdEntityTypeNameEntityIdscopesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the scope.
            var entityTypeName = entityTypeName_example;  // string | The EntityTypeName of the profile instance to which the scopes are linked.
            var entityId = entityId_example;  // string | The identifier (business key) of the instance of entity to which the scopes are associated.

            try
            {
                // Retrieve the associated scopes - {GetAssociatedScopesRequest}
                List<ScopeAssociation> result = apiInstance.GetAssociatedScopesRequestScopeIdEntityTypeNameEntityIdscopesGet(accept, scopeId, entityTypeName, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.GetAssociatedScopesRequestScopeIdEntityTypeNameEntityIdscopesGet: " + e.Message );
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
 **scopeId** | **string**| The identifier of the scope. | 
 **entityTypeName** | **string**| The EntityTypeName of the profile instance to which the scopes are linked. | 
 **entityId** | **string**| The identifier (business key) of the instance of entity to which the scopes are associated. | 

### Return type

[**List&lt;ScopeAssociation&gt;**](ScopeAssociation.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofileinstancebynamerequestscopeidentitytypenamebynamenameget"></a>
# **GetProfileInstanceByNameRequestScopeIdEntityTypeNamebyNameNameGet**
> CustomProfile GetProfileInstanceByNameRequestScopeIdEntityTypeNamebyNameNameGet (string accept, string scopeId, string entityTypeName, string name)

Retrieve custom profile instance by type and name - {GetProfileInstanceByNameRequest}

Retrieve custom profile instance by type and name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProfileInstanceByNameRequestScopeIdEntityTypeNamebyNameNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityTypeName = entityTypeName_example;  // string | Name of the custom type of the profile instance represented by this entity.
            var name = name_example;  // string | Unique identifier name for the entity.

            try
            {
                // Retrieve custom profile instance by type and name - {GetProfileInstanceByNameRequest}
                CustomProfile result = apiInstance.GetProfileInstanceByNameRequestScopeIdEntityTypeNamebyNameNameGet(accept, scopeId, entityTypeName, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.GetProfileInstanceByNameRequestScopeIdEntityTypeNamebyNameNameGet: " + e.Message );
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
 **entityTypeName** | **string**| Name of the custom type of the profile instance represented by this entity. | 
 **name** | **string**| Unique identifier name for the entity. | 

### Return type

[**CustomProfile**](CustomProfile.md)

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

<a name="getprofileinstancerequestscopeidentitytypenameentityidget"></a>
# **GetProfileInstanceRequestScopeIdEntityTypeNameEntityIdGet**
> CustomProfile GetProfileInstanceRequestScopeIdEntityTypeNameEntityIdGet (string accept, string scopeId, string entityTypeName, string entityId)

Retrieve a custom profile instance by type and id - {GetProfileInstanceRequest}

Retrieve a custom profile instance by type and id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProfileInstanceRequestScopeIdEntityTypeNameEntityIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityTypeName = entityTypeName_example;  // string | Name of the custom type of the profile instance represented by this entity.
            var entityId = entityId_example;  // string | Unique identifier for the entity.

            try
            {
                // Retrieve a custom profile instance by type and id - {GetProfileInstanceRequest}
                CustomProfile result = apiInstance.GetProfileInstanceRequestScopeIdEntityTypeNameEntityIdGet(accept, scopeId, entityTypeName, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.GetProfileInstanceRequestScopeIdEntityTypeNameEntityIdGet: " + e.Message );
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
 **entityTypeName** | **string**| Name of the custom type of the profile instance represented by this entity. | 
 **entityId** | **string**| Unique identifier for the entity. | 

### Return type

[**CustomProfile**](CustomProfile.md)

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

<a name="getprofileinstancesrequestscopeidentitytypenamebyidspost"></a>
# **GetProfileInstancesRequestScopeIdEntityTypeNamebyIdsPost**
> List&lt;CustomProfile&gt; GetProfileInstancesRequestScopeIdEntityTypeNamebyIdsPost (string accept, string scopeId, string entityTypeName, GetProfileInstancesRequest body = null)

Retrieve custom profile instances by type and id - {GetProfileInstancesRequest}

Retrieve custom profile instances by type and id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProfileInstancesRequestScopeIdEntityTypeNamebyIdsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityTypeName = entityTypeName_example;  // string | Name of the custom type of the profile instance represented by these entities.
            var body = new GetProfileInstancesRequest(); // GetProfileInstancesRequest |  (optional) 

            try
            {
                // Retrieve custom profile instances by type and id - {GetProfileInstancesRequest}
                List<CustomProfile> result = apiInstance.GetProfileInstancesRequestScopeIdEntityTypeNamebyIdsPost(accept, scopeId, entityTypeName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.GetProfileInstancesRequestScopeIdEntityTypeNamebyIdsPost: " + e.Message );
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
 **entityTypeName** | **string**| Name of the custom type of the profile instance represented by these entities. | 
 **body** | [**GetProfileInstancesRequest**](GetProfileInstancesRequest.md)|  | [optional] 

### Return type

[**List&lt;CustomProfile&gt;**](CustomProfile.md)

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

<a name="removescopeassociationrequestscopeidentitytypenameentityidscopesdelete"></a>
# **RemoveScopeAssociationRequestScopeIdEntityTypeNameEntityIdscopesDelete**
> List&lt;ScopeAssociation&gt; RemoveScopeAssociationRequestScopeIdEntityTypeNameEntityIdscopesDelete (string accept, string scopeId, string entityTypeName, string entityId)

Remove the association between a scope and a custom profile - {RemoveScopeAssociationRequest}

Remove the association between a scope and a custom profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveScopeAssociationRequestScopeIdEntityTypeNameEntityIdscopesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The Id (business key) of the Scope to which the associations must be deleted.
            var entityTypeName = entityTypeName_example;  // string | The name (business key) of the entity type of the instance to which the scopes are linked.
            var entityId = entityId_example;  // string | The Id (business key) of the instance of entity to which the scopes are associated.

            try
            {
                // Remove the association between a scope and a custom profile - {RemoveScopeAssociationRequest}
                List<ScopeAssociation> result = apiInstance.RemoveScopeAssociationRequestScopeIdEntityTypeNameEntityIdscopesDelete(accept, scopeId, entityTypeName, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.RemoveScopeAssociationRequestScopeIdEntityTypeNameEntityIdscopesDelete: " + e.Message );
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
 **scopeId** | **string**| The Id (business key) of the Scope to which the associations must be deleted. | 
 **entityTypeName** | **string**| The name (business key) of the entity type of the instance to which the scopes are linked. | 
 **entityId** | **string**| The Id (business key) of the instance of entity to which the scopes are associated. | 

### Return type

[**List&lt;ScopeAssociation&gt;**](ScopeAssociation.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomprofilerequestscopeidentitytypenameentityidcreate"></a>
# **UpdateCustomProfileRequestScopeIdEntityTypeNameEntityIdCreate**
> CustomProfile UpdateCustomProfileRequestScopeIdEntityTypeNameEntityIdCreate (string accept, string scopeId, string entityTypeName, string entityId, UpdateCustomProfileRequest body = null)

Updates a custom profile - {UpdateCustomProfileRequest}

Updates a custom profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCustomProfileRequestScopeIdEntityTypeNameEntityIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var entityTypeName = entityTypeName_example;  // string | The entity type name.
            var entityId = entityId_example;  // string | The unique identifier for the entity.
            var body = new UpdateCustomProfileRequest(); // UpdateCustomProfileRequest |  (optional) 

            try
            {
                // Updates a custom profile - {UpdateCustomProfileRequest}
                CustomProfile result = apiInstance.UpdateCustomProfileRequestScopeIdEntityTypeNameEntityIdCreate(accept, scopeId, entityTypeName, entityId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.UpdateCustomProfileRequestScopeIdEntityTypeNameEntityIdCreate: " + e.Message );
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
 **entityTypeName** | **string**| The entity type name. | 
 **entityId** | **string**| The unique identifier for the entity. | 
 **body** | [**UpdateCustomProfileRequest**](UpdateCustomProfileRequest.md)|  | [optional] 

### Return type

[**CustomProfile**](CustomProfile.md)

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

<a name="updatescopeassociationsrequestscopeidentitytypenameentityidscopescreate"></a>
# **UpdateScopeAssociationsRequestScopeIdEntityTypeNameEntityIdscopesCreate**
> List&lt;ScopeAssociation&gt; UpdateScopeAssociationsRequestScopeIdEntityTypeNameEntityIdscopesCreate (string accept, string scopeId, string entityTypeName, string entityId, UpdateScopeAssociationsRequest body = null)

Adds/Updates the association between scopes and an entity - {UpdateScopeAssociationsRequest}

Adds/Updates the association between scopes and an entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateScopeAssociationsRequestScopeIdEntityTypeNameEntityIdscopesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomProfilesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope in which the profile instance belongs.
            var entityTypeName = entityTypeName_example;  // string | The name (business key) of the entity type of the instance to which the scopes are linked.
            var entityId = entityId_example;  // string | The Id (business key) of the instance of entity to which the scopes are associated.
            var body = new UpdateScopeAssociationsRequest(); // UpdateScopeAssociationsRequest |  (optional) 

            try
            {
                // Adds/Updates the association between scopes and an entity - {UpdateScopeAssociationsRequest}
                List<ScopeAssociation> result = apiInstance.UpdateScopeAssociationsRequestScopeIdEntityTypeNameEntityIdscopesCreate(accept, scopeId, entityTypeName, entityId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomProfilesApi.UpdateScopeAssociationsRequestScopeIdEntityTypeNameEntityIdscopesCreate: " + e.Message );
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
 **scopeId** | **string**| The scope in which the profile instance belongs. | 
 **entityTypeName** | **string**| The name (business key) of the entity type of the instance to which the scopes are linked. | 
 **entityId** | **string**| The Id (business key) of the instance of entity to which the scopes are associated. | 
 **body** | [**UpdateScopeAssociationsRequest**](UpdateScopeAssociationsRequest.md)|  | [optional] 

### Return type

[**List&lt;ScopeAssociation&gt;**](ScopeAssociation.md)

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

