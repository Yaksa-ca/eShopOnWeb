# Yaksa.OrckestraCommerce.Client.Api.MetadataApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategoryDefinitionRequestdefinitionscategoryNamePost**](MetadataApi.md#createcategorydefinitionrequestdefinitionscategorynamepost) | **POST** /metadata/definitions/category/{Name} | Create a category definition - {CreateCategoryDefinitionRequest}
[**CreateEntityTypeRequestEntityTypeEntityTypeNamePost**](MetadataApi.md#createentitytyperequestentitytypeentitytypenamepost) | **POST** /metadata/EntityType/{EntityTypeName} | Create a new custom profile definition - {CreateEntityTypeRequest}
[**CreateProductAttributeGroupRequestattributegroupsproductNamePost**](MetadataApi.md#createproductattributegrouprequestattributegroupsproductnamepost) | **POST** /metadata/attributegroups/product/{Name} | Create a product attribute group - {CreateProductAttributeGroupRequest}
[**CreateProductAttributeRequestattributesproductAttributeNamePost**](MetadataApi.md#createproductattributerequestattributesproductattributenamepost) | **POST** /metadata/attributes/product/{AttributeName} | Create a product attribute - {CreateProductAttributeRequest}
[**CreateProductDefinitionRequestdefinitionsproductNamePost**](MetadataApi.md#createproductdefinitionrequestdefinitionsproductnamepost) | **POST** /metadata/definitions/product/{Name} | Create a product definition - {CreateProductDefinitionRequest}
[**CreateProductLookupTypeDefinitionRequestlookupsproductLookupNamePost**](MetadataApi.md#createproductlookuptypedefinitionrequestlookupsproductlookupnamepost) | **POST** /metadata/lookups/product/{LookupName} | Creates a new product lookup type definition - {CreateProductLookupTypeDefinitionRequest}
[**DeleteProductAttributeGroupRequestattributegroupsproductNameDelete**](MetadataApi.md#deleteproductattributegrouprequestattributegroupsproductnamedelete) | **DELETE** /metadata/attributegroups/product/{Name} | Delete a product attribute group - {DeleteProductAttributeGroupRequest}
[**DeleteProductAttributeRequestattributesproductAttributeNameDelete**](MetadataApi.md#deleteproductattributerequestattributesproductattributenamedelete) | **DELETE** /metadata/attributes/product/{AttributeName} | Delete a product attribute - {DeleteProductAttributeRequest}
[**DeleteProductLookupValuesRequestlookupsproductLookupNamevaluesDelete**](MetadataApi.md#deleteproductlookupvaluesrequestlookupsproductlookupnamevaluesdelete) | **DELETE** /metadata/lookups/product/{LookupName}/values | Delete specified values from a product lookup type definition - {DeleteProductLookupValuesRequest}
[**FindProductAttributeGroupsRequestattributegroupsproductfindPost**](MetadataApi.md#findproductattributegroupsrequestattributegroupsproductfindpost) | **POST** /metadata/attributegroups/product/find | Get list of product attribute groups - {FindProductAttributeGroupsRequest}
[**GetCurrenciesRequestcurrenciesGet**](MetadataApi.md#getcurrenciesrequestcurrenciesget) | **GET** /metadata/currencies | Retrieve all currencies - {GetCurrenciesRequest}
[**GetCustomerDefinitionRequestdefinitionscustomerNameGet**](MetadataApi.md#getcustomerdefinitionrequestdefinitionscustomernameget) | **GET** /metadata/definitions/customer/{Name} | Retrieve the entity definition from Profiles entities - {GetCustomerDefinitionRequest}
[**GetCustomerDefinitionsRequestdefinitionscustomerGet**](MetadataApi.md#getcustomerdefinitionsrequestdefinitionscustomerget) | **GET** /metadata/definitions/customer | Retrieve the entity definitions in Profiles - {GetCustomerDefinitionsRequest}
[**GetCustomerLookupRequestlookupscustomerLookupNameGet**](MetadataApi.md#getcustomerlookuprequestlookupscustomerlookupnameget) | **GET** /metadata/lookups/customer/{LookupName} | Retrieve the lookup from Profiles lookups - {GetCustomerLookupRequest}
[**GetCustomerLookupsRequestlookupscustomerGet**](MetadataApi.md#getcustomerlookupsrequestlookupscustomerget) | **GET** /metadata/lookups/customer/ | Retrieve the Profiles lookups - {GetCustomerLookupsRequest}
[**GetMarketingLookupRequestlookupsmarketingLookupNameGet**](MetadataApi.md#getmarketinglookuprequestlookupsmarketinglookupnameget) | **GET** /metadata/lookups/marketing/{LookupName} | Retrieve the lookup from Marketing lookups - {GetMarketingLookupRequest}
[**GetMarketingLookupsRequestlookupsmarketingGet**](MetadataApi.md#getmarketinglookupsrequestlookupsmarketingget) | **GET** /metadata/lookups/marketing/ | Retrieve the Marketing lookups - {GetMarketingLookupsRequest}
[**GetOrderDefinitionRequestdefinitionsorderNameGet**](MetadataApi.md#getorderdefinitionrequestdefinitionsordernameget) | **GET** /metadata/definitions/order/{Name} | Retrieve the entity definition from Orders entities - {GetOrderDefinitionRequest}
[**GetOrderDefinitionsRequestdefinitionsorderGet**](MetadataApi.md#getorderdefinitionsrequestdefinitionsorderget) | **GET** /metadata/definitions/order | Retrieve the entity definitions defined in Orders - {GetOrderDefinitionsRequest}
[**GetOrderLookupRequestlookupsorderLookupNameGet**](MetadataApi.md#getorderlookuprequestlookupsorderlookupnameget) | **GET** /metadata/lookups/order/{LookupName} | Retrieve the lookup from Orders lookups - {GetOrderLookupRequest}
[**GetOrderLookupsRequestlookupsorderGet**](MetadataApi.md#getorderlookupsrequestlookupsorderget) | **GET** /metadata/lookups/order/ | Retrieve the Orders lookups - {GetOrderLookupsRequest}
[**GetProductLookupRequestlookupsproductLookupNameGet**](MetadataApi.md#getproductlookuprequestlookupsproductlookupnameget) | **GET** /metadata/lookups/product/{LookupName} | Retrieve the lookup from Products lookups - {GetProductLookupRequest}
[**GetProductLookupsRequestlookupsproductGet**](MetadataApi.md#getproductlookupsrequestlookupsproductget) | **GET** /metadata/lookups/product/ | Retrieve the Product lookups - {GetProductLookupsRequest}
[**GetTargetingMetadataRequesttargetingGet**](MetadataApi.md#gettargetingmetadatarequesttargetingget) | **GET** /metadata/targeting | Return the targeting items (metadata used to construct targeting expression) - {GetTargetingMetadataRequest}
[**UpdateCategoryDefinitionRequestdefinitionscategoryNameCreate**](MetadataApi.md#updatecategorydefinitionrequestdefinitionscategorynamecreate) | **PUT** /metadata/definitions/category/{Name} | Update a category definition - {UpdateCategoryDefinitionRequest}
[**UpdateMarketingLookupTypeDefinitionRequestLookupTypeMarketingLookupNamePost**](MetadataApi.md#updatemarketinglookuptypedefinitionrequestlookuptypemarketinglookupnamepost) | **POST** /metadata/LookupType/Marketing/{LookupName} | Update a marketing lookup type definition - {UpdateMarketingLookupTypeDefinitionRequest}
[**UpdateProductAttributeGroupRequestattributegroupsproductNameCreate**](MetadataApi.md#updateproductattributegrouprequestattributegroupsproductnamecreate) | **PUT** /metadata/attributegroups/product/{Name} | Update a product attribute group - {UpdateProductAttributeGroupRequest}
[**UpdateProductAttributeRequestattributesproductAttributeNameCreate**](MetadataApi.md#updateproductattributerequestattributesproductattributenamecreate) | **PUT** /metadata/attributes/product/{AttributeName} | Update a product attribute - {UpdateProductAttributeRequest}
[**UpdateProductDefinitionRequestdefinitionsproductNameCreate**](MetadataApi.md#updateproductdefinitionrequestdefinitionsproductnamecreate) | **PUT** /metadata/definitions/product/{Name} | Update a product definition - {UpdateProductDefinitionRequest}
[**UpdateProductLookupTypeDefinitionRequestlookupsproductLookupNameCreate**](MetadataApi.md#updateproductlookuptypedefinitionrequestlookupsproductlookupnamecreate) | **PUT** /metadata/lookups/product/{LookupName} | Update a product lookup type definition - {UpdateProductLookupTypeDefinitionRequest}


<a name="createcategorydefinitionrequestdefinitionscategorynamepost"></a>
# **CreateCategoryDefinitionRequestdefinitionscategoryNamePost**
> ProductDefinition CreateCategoryDefinitionRequestdefinitionscategoryNamePost (string accept, string name, CreateCategoryDefinitionRequest body = null)

Create a category definition - {CreateCategoryDefinitionRequest}

Create a category definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCategoryDefinitionRequestdefinitionscategoryNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the category definition.
            var body = new CreateCategoryDefinitionRequest(); // CreateCategoryDefinitionRequest |  (optional) 

            try
            {
                // Create a category definition - {CreateCategoryDefinitionRequest}
                ProductDefinition result = apiInstance.CreateCategoryDefinitionRequestdefinitionscategoryNamePost(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateCategoryDefinitionRequestdefinitionscategoryNamePost: " + e.Message );
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
 **name** | **string**| The name of the category definition. | 
 **body** | [**CreateCategoryDefinitionRequest**](CreateCategoryDefinitionRequest.md)|  | [optional] 

### Return type

[**ProductDefinition**](ProductDefinition.md)

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

<a name="createentitytyperequestentitytypeentitytypenamepost"></a>
# **CreateEntityTypeRequestEntityTypeEntityTypeNamePost**
> void CreateEntityTypeRequestEntityTypeEntityTypeNamePost (string accept, string entityTypeName, CreateEntityTypeRequest body = null)

Create a new custom profile definition - {CreateEntityTypeRequest}

Create a new entity type definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateEntityTypeRequestEntityTypeEntityTypeNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var entityTypeName = entityTypeName_example;  // string | The unique name for this entity type.
            var body = new CreateEntityTypeRequest(); // CreateEntityTypeRequest |  (optional) 

            try
            {
                // Create a new custom profile definition - {CreateEntityTypeRequest}
                apiInstance.CreateEntityTypeRequestEntityTypeEntityTypeNamePost(accept, entityTypeName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateEntityTypeRequestEntityTypeEntityTypeNamePost: " + e.Message );
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
 **entityTypeName** | **string**| The unique name for this entity type. | 
 **body** | [**CreateEntityTypeRequest**](CreateEntityTypeRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproductattributegrouprequestattributegroupsproductnamepost"></a>
# **CreateProductAttributeGroupRequestattributegroupsproductNamePost**
> ProductPropertyDefinitionGroup CreateProductAttributeGroupRequestattributegroupsproductNamePost (string accept, string name, CreateProductAttributeGroupRequest body = null)

Create a product attribute group - {CreateProductAttributeGroupRequest}

Create a product attribute group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateProductAttributeGroupRequestattributegroupsproductNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the attribute group
            var body = new CreateProductAttributeGroupRequest(); // CreateProductAttributeGroupRequest |  (optional) 

            try
            {
                // Create a product attribute group - {CreateProductAttributeGroupRequest}
                ProductPropertyDefinitionGroup result = apiInstance.CreateProductAttributeGroupRequestattributegroupsproductNamePost(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateProductAttributeGroupRequestattributegroupsproductNamePost: " + e.Message );
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
 **name** | **string**| The name of the attribute group | 
 **body** | [**CreateProductAttributeGroupRequest**](CreateProductAttributeGroupRequest.md)|  | [optional] 

### Return type

[**ProductPropertyDefinitionGroup**](ProductPropertyDefinitionGroup.md)

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

<a name="createproductattributerequestattributesproductattributenamepost"></a>
# **CreateProductAttributeRequestattributesproductAttributeNamePost**
> ProductPropertyDefinition CreateProductAttributeRequestattributesproductAttributeNamePost (string accept, string attributeName, CreateProductAttributeRequest body = null)

Create a product attribute - {CreateProductAttributeRequest}

Create a product attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateProductAttributeRequestattributesproductAttributeNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var attributeName = attributeName_example;  // string | The name of the attribute
            var body = new CreateProductAttributeRequest(); // CreateProductAttributeRequest |  (optional) 

            try
            {
                // Create a product attribute - {CreateProductAttributeRequest}
                ProductPropertyDefinition result = apiInstance.CreateProductAttributeRequestattributesproductAttributeNamePost(accept, attributeName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateProductAttributeRequestattributesproductAttributeNamePost: " + e.Message );
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
 **attributeName** | **string**| The name of the attribute | 
 **body** | [**CreateProductAttributeRequest**](CreateProductAttributeRequest.md)|  | [optional] 

### Return type

[**ProductPropertyDefinition**](ProductPropertyDefinition.md)

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

<a name="createproductdefinitionrequestdefinitionsproductnamepost"></a>
# **CreateProductDefinitionRequestdefinitionsproductNamePost**
> ProductDefinition CreateProductDefinitionRequestdefinitionsproductNamePost (string accept, string name, CreateProductDefinitionRequest body = null)

Create a product definition - {CreateProductDefinitionRequest}

Create a product definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateProductDefinitionRequestdefinitionsproductNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the product definition.
            var body = new CreateProductDefinitionRequest(); // CreateProductDefinitionRequest |  (optional) 

            try
            {
                // Create a product definition - {CreateProductDefinitionRequest}
                ProductDefinition result = apiInstance.CreateProductDefinitionRequestdefinitionsproductNamePost(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateProductDefinitionRequestdefinitionsproductNamePost: " + e.Message );
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
 **name** | **string**| The name of the product definition. | 
 **body** | [**CreateProductDefinitionRequest**](CreateProductDefinitionRequest.md)|  | [optional] 

### Return type

[**ProductDefinition**](ProductDefinition.md)

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

<a name="createproductlookuptypedefinitionrequestlookupsproductlookupnamepost"></a>
# **CreateProductLookupTypeDefinitionRequestlookupsproductLookupNamePost**
> Lookup CreateProductLookupTypeDefinitionRequestlookupsproductLookupNamePost (string accept, string lookupName, CreateProductLookupTypeDefinitionRequest body = null)

Creates a new product lookup type definition - {CreateProductLookupTypeDefinitionRequest}

Creates a new product lookup type definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateProductLookupTypeDefinitionRequestlookupsproductLookupNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The name of this lookup
            var body = new CreateProductLookupTypeDefinitionRequest(); // CreateProductLookupTypeDefinitionRequest |  (optional) 

            try
            {
                // Creates a new product lookup type definition - {CreateProductLookupTypeDefinitionRequest}
                Lookup result = apiInstance.CreateProductLookupTypeDefinitionRequestlookupsproductLookupNamePost(accept, lookupName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateProductLookupTypeDefinitionRequestlookupsproductLookupNamePost: " + e.Message );
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
 **lookupName** | **string**| The name of this lookup | 
 **body** | [**CreateProductLookupTypeDefinitionRequest**](CreateProductLookupTypeDefinitionRequest.md)|  | [optional] 

### Return type

[**Lookup**](Lookup.md)

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

<a name="deleteproductattributegrouprequestattributegroupsproductnamedelete"></a>
# **DeleteProductAttributeGroupRequestattributegroupsproductNameDelete**
> void DeleteProductAttributeGroupRequestattributegroupsproductNameDelete (string accept, string name)

Delete a product attribute group - {DeleteProductAttributeGroupRequest}

Delete a product attribute group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductAttributeGroupRequestattributegroupsproductNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the attribute group

            try
            {
                // Delete a product attribute group - {DeleteProductAttributeGroupRequest}
                apiInstance.DeleteProductAttributeGroupRequestattributegroupsproductNameDelete(accept, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteProductAttributeGroupRequestattributegroupsproductNameDelete: " + e.Message );
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
 **name** | **string**| The name of the attribute group | 

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

<a name="deleteproductattributerequestattributesproductattributenamedelete"></a>
# **DeleteProductAttributeRequestattributesproductAttributeNameDelete**
> void DeleteProductAttributeRequestattributesproductAttributeNameDelete (string accept, string attributeName)

Delete a product attribute - {DeleteProductAttributeRequest}

Delete a product attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductAttributeRequestattributesproductAttributeNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var attributeName = attributeName_example;  // string | The name of the attribute

            try
            {
                // Delete a product attribute - {DeleteProductAttributeRequest}
                apiInstance.DeleteProductAttributeRequestattributesproductAttributeNameDelete(accept, attributeName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteProductAttributeRequestattributesproductAttributeNameDelete: " + e.Message );
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
 **attributeName** | **string**| The name of the attribute | 

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

<a name="deleteproductlookupvaluesrequestlookupsproductlookupnamevaluesdelete"></a>
# **DeleteProductLookupValuesRequestlookupsproductLookupNamevaluesDelete**
> void DeleteProductLookupValuesRequestlookupsproductLookupNamevaluesDelete (string accept, string lookupName, List<string> values = null)

Delete specified values from a product lookup type definition - {DeleteProductLookupValuesRequest}

Delete specified values from a product lookup type definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductLookupValuesRequestlookupsproductLookupNamevaluesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The name of a lookup
            var values = new List<string>(); // List<string> | The list of values to be removed from this lookup. (optional) 

            try
            {
                // Delete specified values from a product lookup type definition - {DeleteProductLookupValuesRequest}
                apiInstance.DeleteProductLookupValuesRequestlookupsproductLookupNamevaluesDelete(accept, lookupName, values);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteProductLookupValuesRequestlookupsproductLookupNamevaluesDelete: " + e.Message );
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
 **lookupName** | **string**| The name of a lookup | 
 **values** | [**List&lt;string&gt;**](string.md)| The list of values to be removed from this lookup. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findproductattributegroupsrequestattributegroupsproductfindpost"></a>
# **FindProductAttributeGroupsRequestattributegroupsproductfindPost**
> ProductPropertyDefinitionGroupQueryResult FindProductAttributeGroupsRequestattributegroupsproductfindPost (string accept, FindProductAttributeGroupsRequest body = null)

Get list of product attribute groups - {FindProductAttributeGroupsRequest}

Get list of product attribute groups.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindProductAttributeGroupsRequestattributegroupsproductfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new FindProductAttributeGroupsRequest(); // FindProductAttributeGroupsRequest |  (optional) 

            try
            {
                // Get list of product attribute groups - {FindProductAttributeGroupsRequest}
                ProductPropertyDefinitionGroupQueryResult result = apiInstance.FindProductAttributeGroupsRequestattributegroupsproductfindPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.FindProductAttributeGroupsRequestattributegroupsproductfindPost: " + e.Message );
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
 **body** | [**FindProductAttributeGroupsRequest**](FindProductAttributeGroupsRequest.md)|  | [optional] 

### Return type

[**ProductPropertyDefinitionGroupQueryResult**](ProductPropertyDefinitionGroupQueryResult.md)

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

<a name="getcurrenciesrequestcurrenciesget"></a>
# **GetCurrenciesRequestcurrenciesGet**
> GetCurrenciesResponse GetCurrenciesRequestcurrenciesGet (string accept, string cultureName = null, bool? includeUnsupported = null)

Retrieve all currencies - {GetCurrenciesRequest}

Retrieve all currencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCurrenciesRequestcurrenciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 
            var includeUnsupported = true;  // bool? | Whether to include the unsupported currencies (optional) 

            try
            {
                // Retrieve all currencies - {GetCurrenciesRequest}
                GetCurrenciesResponse result = apiInstance.GetCurrenciesRequestcurrenciesGet(accept, cultureName, includeUnsupported);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetCurrenciesRequestcurrenciesGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 
 **includeUnsupported** | **bool?**| Whether to include the unsupported currencies | [optional] 

### Return type

[**GetCurrenciesResponse**](GetCurrenciesResponse.md)

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

<a name="getcustomerdefinitionrequestdefinitionscustomernameget"></a>
# **GetCustomerDefinitionRequestdefinitionscustomerNameGet**
> EntityDefinition GetCustomerDefinitionRequestdefinitionscustomerNameGet (string accept, string name, string cultureName = null)

Retrieve the entity definition from Profiles entities - {GetCustomerDefinitionRequest}

Retrieve the entity definition from Profiles entities. A definition is a list of properties that is allowed to be set to the instance being used. Warning : The name is case sensitive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerDefinitionRequestdefinitionscustomerNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The id to retrieve related entity definition
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the entity definition from Profiles entities - {GetCustomerDefinitionRequest}
                EntityDefinition result = apiInstance.GetCustomerDefinitionRequestdefinitionscustomerNameGet(accept, name, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetCustomerDefinitionRequestdefinitionscustomerNameGet: " + e.Message );
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
 **name** | **string**| The id to retrieve related entity definition | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**EntityDefinition**](EntityDefinition.md)

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
| **404** | Requested definition not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerdefinitionsrequestdefinitionscustomerget"></a>
# **GetCustomerDefinitionsRequestdefinitionscustomerGet**
> List&lt;EntityDefinition&gt; GetCustomerDefinitionsRequestdefinitionscustomerGet (string accept, string cultureName = null)

Retrieve the entity definitions in Profiles - {GetCustomerDefinitionsRequest}

Retrieve the customer entity definitions in Profiles. A definition is a list of properties that is allowed to be set to the instance of entity being used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerDefinitionsRequestdefinitionscustomerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 

            try
            {
                // Retrieve the entity definitions in Profiles - {GetCustomerDefinitionsRequest}
                List<EntityDefinition> result = apiInstance.GetCustomerDefinitionsRequestdefinitionscustomerGet(accept, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetCustomerDefinitionsRequestdefinitionscustomerGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 

### Return type

[**List&lt;EntityDefinition&gt;**](EntityDefinition.md)

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
| **404** | Requested definitions not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerlookuprequestlookupscustomerlookupnameget"></a>
# **GetCustomerLookupRequestlookupscustomerLookupNameGet**
> Lookup GetCustomerLookupRequestlookupscustomerLookupNameGet (string accept, string lookupName)

Retrieve the lookup from Profiles lookups - {GetCustomerLookupRequest}

This entity represents a lookup, defining its metadata for Customer entity. Overture provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerLookupRequestlookupscustomerLookupNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The id to retrieve related lookup

            try
            {
                // Retrieve the lookup from Profiles lookups - {GetCustomerLookupRequest}
                Lookup result = apiInstance.GetCustomerLookupRequestlookupscustomerLookupNameGet(accept, lookupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetCustomerLookupRequestlookupscustomerLookupNameGet: " + e.Message );
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
 **lookupName** | **string**| The id to retrieve related lookup | 

### Return type

[**Lookup**](Lookup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested lookup id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerlookupsrequestlookupscustomerget"></a>
# **GetCustomerLookupsRequestlookupscustomerGet**
> List&lt;Lookup&gt; GetCustomerLookupsRequestlookupscustomerGet (string accept)

Retrieve the Profiles lookups - {GetCustomerLookupsRequest}

This entity represents a lookup, defining its metadata for Customer entity. Orckestra provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerLookupsRequestlookupscustomerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the Profiles lookups - {GetCustomerLookupsRequest}
                List<Lookup> result = apiInstance.GetCustomerLookupsRequestlookupscustomerGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetCustomerLookupsRequestlookupscustomerGet: " + e.Message );
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

[**List&lt;Lookup&gt;**](Lookup.md)

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

<a name="getmarketinglookuprequestlookupsmarketinglookupnameget"></a>
# **GetMarketingLookupRequestlookupsmarketingLookupNameGet**
> Lookup GetMarketingLookupRequestlookupsmarketingLookupNameGet (string accept, string lookupName)

Retrieve the lookup from Marketing lookups - {GetMarketingLookupRequest}

This entity represents a lookup, defining its metadata for Marketing entity. Overture provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMarketingLookupRequestlookupsmarketingLookupNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The id to retrieve related lookup

            try
            {
                // Retrieve the lookup from Marketing lookups - {GetMarketingLookupRequest}
                Lookup result = apiInstance.GetMarketingLookupRequestlookupsmarketingLookupNameGet(accept, lookupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetMarketingLookupRequestlookupsmarketingLookupNameGet: " + e.Message );
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
 **lookupName** | **string**| The id to retrieve related lookup | 

### Return type

[**Lookup**](Lookup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested lookup id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketinglookupsrequestlookupsmarketingget"></a>
# **GetMarketingLookupsRequestlookupsmarketingGet**
> List&lt;Lookup&gt; GetMarketingLookupsRequestlookupsmarketingGet (string accept)

Retrieve the Marketing lookups - {GetMarketingLookupsRequest}

This entity represents a lookup, defining its metadata for Marketing entity. Orckestra provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMarketingLookupsRequestlookupsmarketingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the Marketing lookups - {GetMarketingLookupsRequest}
                List<Lookup> result = apiInstance.GetMarketingLookupsRequestlookupsmarketingGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetMarketingLookupsRequestlookupsmarketingGet: " + e.Message );
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

[**List&lt;Lookup&gt;**](Lookup.md)

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

<a name="getorderdefinitionrequestdefinitionsordernameget"></a>
# **GetOrderDefinitionRequestdefinitionsorderNameGet**
> EntityDefinition GetOrderDefinitionRequestdefinitionsorderNameGet (string accept, string name, string cultureName = null)

Retrieve the entity definition from Orders entities - {GetOrderDefinitionRequest}

Retrieve the entity definition from Orders entities. A definition is a list of properties that is allowed to be set to the instance being used. Warning : The name is case sensitive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderDefinitionRequestdefinitionsorderNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The id to retrieve related entity definition
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the entity definition from Orders entities - {GetOrderDefinitionRequest}
                EntityDefinition result = apiInstance.GetOrderDefinitionRequestdefinitionsorderNameGet(accept, name, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetOrderDefinitionRequestdefinitionsorderNameGet: " + e.Message );
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
 **name** | **string**| The id to retrieve related entity definition | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**EntityDefinition**](EntityDefinition.md)

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
| **404** | Requested definition not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderdefinitionsrequestdefinitionsorderget"></a>
# **GetOrderDefinitionsRequestdefinitionsorderGet**
> List&lt;EntityDefinition&gt; GetOrderDefinitionsRequestdefinitionsorderGet (string accept, string cultureName = null)

Retrieve the entity definitions defined in Orders - {GetOrderDefinitionsRequest}

Retrieve the entity definitions defined in Orders. A definition is a list of properties that is allowed to be set to the instance of entity being used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderDefinitionsRequestdefinitionsorderGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the entity definitions defined in Orders - {GetOrderDefinitionsRequest}
                List<EntityDefinition> result = apiInstance.GetOrderDefinitionsRequestdefinitionsorderGet(accept, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetOrderDefinitionsRequestdefinitionsorderGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;EntityDefinition&gt;**](EntityDefinition.md)

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
| **404** | Requested definitions not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlookuprequestlookupsorderlookupnameget"></a>
# **GetOrderLookupRequestlookupsorderLookupNameGet**
> Lookup GetOrderLookupRequestlookupsorderLookupNameGet (string accept, string lookupName)

Retrieve the lookup from Orders lookups - {GetOrderLookupRequest}

This entity represents a lookup, defining its metadata for Order entity. Overture provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderLookupRequestlookupsorderLookupNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The id to retrieve related lookup

            try
            {
                // Retrieve the lookup from Orders lookups - {GetOrderLookupRequest}
                Lookup result = apiInstance.GetOrderLookupRequestlookupsorderLookupNameGet(accept, lookupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetOrderLookupRequestlookupsorderLookupNameGet: " + e.Message );
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
 **lookupName** | **string**| The id to retrieve related lookup | 

### Return type

[**Lookup**](Lookup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested lookup id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlookupsrequestlookupsorderget"></a>
# **GetOrderLookupsRequestlookupsorderGet**
> List&lt;Lookup&gt; GetOrderLookupsRequestlookupsorderGet (string accept)

Retrieve the Orders lookups - {GetOrderLookupsRequest}

This entity represents a lookup, defining its metadata for Order entity. Orckestra provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderLookupsRequestlookupsorderGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the Orders lookups - {GetOrderLookupsRequest}
                List<Lookup> result = apiInstance.GetOrderLookupsRequestlookupsorderGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetOrderLookupsRequestlookupsorderGet: " + e.Message );
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

[**List&lt;Lookup&gt;**](Lookup.md)

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

<a name="getproductlookuprequestlookupsproductlookupnameget"></a>
# **GetProductLookupRequestlookupsproductLookupNameGet**
> Lookup GetProductLookupRequestlookupsproductLookupNameGet (string accept, string lookupName)

Retrieve the lookup from Products lookups - {GetProductLookupRequest}

This entity represents a lookup, defining its metadata for Product entity. Overture provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductLookupRequestlookupsproductLookupNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The id to retrieve related lookup

            try
            {
                // Retrieve the lookup from Products lookups - {GetProductLookupRequest}
                Lookup result = apiInstance.GetProductLookupRequestlookupsproductLookupNameGet(accept, lookupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetProductLookupRequestlookupsproductLookupNameGet: " + e.Message );
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
 **lookupName** | **string**| The id to retrieve related lookup | 

### Return type

[**Lookup**](Lookup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Requested lookup id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductlookupsrequestlookupsproductget"></a>
# **GetProductLookupsRequestlookupsproductGet**
> List&lt;Lookup&gt; GetProductLookupsRequestlookupsproductGet (string accept)

Retrieve the Product lookups - {GetProductLookupsRequest}

This entity represents a lookup, defining its metadata for Product entity. Orckestra provides, out-of-the-box, a list of lookups which can be enriched by the administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductLookupsRequestlookupsproductGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the Product lookups - {GetProductLookupsRequest}
                List<Lookup> result = apiInstance.GetProductLookupsRequestlookupsproductGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetProductLookupsRequestlookupsproductGet: " + e.Message );
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

[**List&lt;Lookup&gt;**](Lookup.md)

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

<a name="gettargetingmetadatarequesttargetingget"></a>
# **GetTargetingMetadataRequesttargetingGet**
> GetTargetingMetadataResponse GetTargetingMetadataRequesttargetingGet (string accept, string cultureName = null)

Return the targeting items (metadata used to construct targeting expression) - {GetTargetingMetadataRequest}

Return the targeting items (metadata used to construct targeting expression)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTargetingMetadataRequesttargetingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Return the targeting items (metadata used to construct targeting expression) - {GetTargetingMetadataRequest}
                GetTargetingMetadataResponse result = apiInstance.GetTargetingMetadataRequesttargetingGet(accept, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetTargetingMetadataRequesttargetingGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**GetTargetingMetadataResponse**](GetTargetingMetadataResponse.md)

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

<a name="updatecategorydefinitionrequestdefinitionscategorynamecreate"></a>
# **UpdateCategoryDefinitionRequestdefinitionscategoryNameCreate**
> ProductDefinition UpdateCategoryDefinitionRequestdefinitionscategoryNameCreate (string accept, string name, UpdateCategoryDefinitionRequest body = null)

Update a category definition - {UpdateCategoryDefinitionRequest}

Update a category definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCategoryDefinitionRequestdefinitionscategoryNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the category definition
            var body = new UpdateCategoryDefinitionRequest(); // UpdateCategoryDefinitionRequest |  (optional) 

            try
            {
                // Update a category definition - {UpdateCategoryDefinitionRequest}
                ProductDefinition result = apiInstance.UpdateCategoryDefinitionRequestdefinitionscategoryNameCreate(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateCategoryDefinitionRequestdefinitionscategoryNameCreate: " + e.Message );
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
 **name** | **string**| The name of the category definition | 
 **body** | [**UpdateCategoryDefinitionRequest**](UpdateCategoryDefinitionRequest.md)|  | [optional] 

### Return type

[**ProductDefinition**](ProductDefinition.md)

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

<a name="updatemarketinglookuptypedefinitionrequestlookuptypemarketinglookupnamepost"></a>
# **UpdateMarketingLookupTypeDefinitionRequestLookupTypeMarketingLookupNamePost**
> Lookup UpdateMarketingLookupTypeDefinitionRequestLookupTypeMarketingLookupNamePost (string accept, string lookupName, UpdateMarketingLookupTypeDefinitionRequest body = null)

Update a marketing lookup type definition - {UpdateMarketingLookupTypeDefinitionRequest}

Update a marketing lookup type definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateMarketingLookupTypeDefinitionRequestLookupTypeMarketingLookupNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The name of this lookup
            var body = new UpdateMarketingLookupTypeDefinitionRequest(); // UpdateMarketingLookupTypeDefinitionRequest |  (optional) 

            try
            {
                // Update a marketing lookup type definition - {UpdateMarketingLookupTypeDefinitionRequest}
                Lookup result = apiInstance.UpdateMarketingLookupTypeDefinitionRequestLookupTypeMarketingLookupNamePost(accept, lookupName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateMarketingLookupTypeDefinitionRequestLookupTypeMarketingLookupNamePost: " + e.Message );
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
 **lookupName** | **string**| The name of this lookup | 
 **body** | [**UpdateMarketingLookupTypeDefinitionRequest**](UpdateMarketingLookupTypeDefinitionRequest.md)|  | [optional] 

### Return type

[**Lookup**](Lookup.md)

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

<a name="updateproductattributegrouprequestattributegroupsproductnamecreate"></a>
# **UpdateProductAttributeGroupRequestattributegroupsproductNameCreate**
> ProductPropertyDefinitionGroup UpdateProductAttributeGroupRequestattributegroupsproductNameCreate (string accept, string name, UpdateProductAttributeGroupRequest body = null)

Update a product attribute group - {UpdateProductAttributeGroupRequest}

Update a product attribute group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductAttributeGroupRequestattributegroupsproductNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the attribute group
            var body = new UpdateProductAttributeGroupRequest(); // UpdateProductAttributeGroupRequest |  (optional) 

            try
            {
                // Update a product attribute group - {UpdateProductAttributeGroupRequest}
                ProductPropertyDefinitionGroup result = apiInstance.UpdateProductAttributeGroupRequestattributegroupsproductNameCreate(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateProductAttributeGroupRequestattributegroupsproductNameCreate: " + e.Message );
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
 **name** | **string**| The name of the attribute group | 
 **body** | [**UpdateProductAttributeGroupRequest**](UpdateProductAttributeGroupRequest.md)|  | [optional] 

### Return type

[**ProductPropertyDefinitionGroup**](ProductPropertyDefinitionGroup.md)

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

<a name="updateproductattributerequestattributesproductattributenamecreate"></a>
# **UpdateProductAttributeRequestattributesproductAttributeNameCreate**
> ProductPropertyDefinition UpdateProductAttributeRequestattributesproductAttributeNameCreate (string accept, string attributeName, UpdateProductAttributeRequest body = null)

Update a product attribute - {UpdateProductAttributeRequest}

Update a product attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductAttributeRequestattributesproductAttributeNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var attributeName = attributeName_example;  // string | The name of the attribute
            var body = new UpdateProductAttributeRequest(); // UpdateProductAttributeRequest |  (optional) 

            try
            {
                // Update a product attribute - {UpdateProductAttributeRequest}
                ProductPropertyDefinition result = apiInstance.UpdateProductAttributeRequestattributesproductAttributeNameCreate(accept, attributeName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateProductAttributeRequestattributesproductAttributeNameCreate: " + e.Message );
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
 **attributeName** | **string**| The name of the attribute | 
 **body** | [**UpdateProductAttributeRequest**](UpdateProductAttributeRequest.md)|  | [optional] 

### Return type

[**ProductPropertyDefinition**](ProductPropertyDefinition.md)

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

<a name="updateproductdefinitionrequestdefinitionsproductnamecreate"></a>
# **UpdateProductDefinitionRequestdefinitionsproductNameCreate**
> ProductDefinition UpdateProductDefinitionRequestdefinitionsproductNameCreate (string accept, string name, UpdateProductDefinitionRequest body = null)

Update a product definition - {UpdateProductDefinitionRequest}

Update a product definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductDefinitionRequestdefinitionsproductNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the product definition
            var body = new UpdateProductDefinitionRequest(); // UpdateProductDefinitionRequest |  (optional) 

            try
            {
                // Update a product definition - {UpdateProductDefinitionRequest}
                ProductDefinition result = apiInstance.UpdateProductDefinitionRequestdefinitionsproductNameCreate(accept, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateProductDefinitionRequestdefinitionsproductNameCreate: " + e.Message );
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
 **name** | **string**| The name of the product definition | 
 **body** | [**UpdateProductDefinitionRequest**](UpdateProductDefinitionRequest.md)|  | [optional] 

### Return type

[**ProductDefinition**](ProductDefinition.md)

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

<a name="updateproductlookuptypedefinitionrequestlookupsproductlookupnamecreate"></a>
# **UpdateProductLookupTypeDefinitionRequestlookupsproductLookupNameCreate**
> Lookup UpdateProductLookupTypeDefinitionRequestlookupsproductLookupNameCreate (string accept, string lookupName, UpdateProductLookupTypeDefinitionRequest body = null)

Update a product lookup type definition - {UpdateProductLookupTypeDefinitionRequest}

Update a product lookup type definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductLookupTypeDefinitionRequestlookupsproductLookupNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MetadataApi(config);
            var accept = accept_example;  // string | Accept Header
            var lookupName = lookupName_example;  // string | The name of this lookup
            var body = new UpdateProductLookupTypeDefinitionRequest(); // UpdateProductLookupTypeDefinitionRequest |  (optional) 

            try
            {
                // Update a product lookup type definition - {UpdateProductLookupTypeDefinitionRequest}
                Lookup result = apiInstance.UpdateProductLookupTypeDefinitionRequestlookupsproductLookupNameCreate(accept, lookupName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateProductLookupTypeDefinitionRequestlookupsproductLookupNameCreate: " + e.Message );
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
 **lookupName** | **string**| The name of this lookup | 
 **body** | [**UpdateProductLookupTypeDefinitionRequest**](UpdateProductLookupTypeDefinitionRequest.md)|  | [optional] 

### Return type

[**Lookup**](Lookup.md)

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

