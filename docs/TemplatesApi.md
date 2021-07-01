# Yaksa.OrckestraCommerce.Client.Api.TemplatesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreate**](TemplatesApi.md#createorupdatetemplatevariablerequestscopeidvariablesnamecreate) | **PUT** /templates/{ScopeId}/Variables/{Name} | Create or update a template variable - {CreateOrUpdateTemplateVariableRequest}
[**CreateTemplateRequestScopeIdTypeNamePost**](TemplatesApi.md#createtemplaterequestscopeidtypenamepost) | **POST** /templates/{ScopeId}/{Type}/{Name} | Create a new template - {CreateTemplateRequest}
[**DeleteTemplateRequestScopeIdTypeNameDelete**](TemplatesApi.md#deletetemplaterequestscopeidtypenamedelete) | **DELETE** /templates/{ScopeId}/{Type}/{Name} | Delete a template - {DeleteTemplateRequest}
[**DeleteTemplateVariableRequestScopeIdVariablesNameDelete**](TemplatesApi.md#deletetemplatevariablerequestscopeidvariablesnamedelete) | **DELETE** /templates/{ScopeId}/Variables/{Name} | Deletes a template variable - {DeleteTemplateVariableRequest}
[**GetTemplateByNameRequestScopeIdTypeNameGet**](TemplatesApi.md#gettemplatebynamerequestscopeidtypenameget) | **GET** /templates/{ScopeId}/{Type}/{Name} | Retrieves a template available for a scope and a name - {GetTemplateByNameRequest}
[**GetTemplateVariablesRequestScopeIdVariablesGet**](TemplatesApi.md#gettemplatevariablesrequestscopeidvariablesget) | **GET** /templates/{ScopeId}/Variables | Gets a list of template variables for a scope - {GetTemplateVariablesRequest}
[**GetTemplatesRequestScopeIdTypeGet**](TemplatesApi.md#gettemplatesrequestscopeidtypeget) | **GET** /templates/{ScopeId}/{Type} | Retrieve a list of all templates available for a scope and a type - {GetTemplatesRequest}
[**UpdateTemplateRequestScopeIdTypeNameCultureCreate**](TemplatesApi.md#updatetemplaterequestscopeidtypenameculturecreate) | **PUT** /templates/{ScopeId}/{Type}/{Name}/{Culture} | Update a template - {UpdateTemplateRequest}


<a name="createorupdatetemplatevariablerequestscopeidvariablesnamecreate"></a>
# **CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreate**
> TemplateVariable CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreate (string accept, string scopeId, string name, CreateOrUpdateTemplateVariableRequest body = null)

Create or update a template variable - {CreateOrUpdateTemplateVariableRequest}

Create or update a template variable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var name = name_example;  // string | The template variable's name.
            var body = new CreateOrUpdateTemplateVariableRequest(); // CreateOrUpdateTemplateVariableRequest |  (optional) 

            try
            {
                // Create or update a template variable - {CreateOrUpdateTemplateVariableRequest}
                TemplateVariable result = apiInstance.CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreate(accept, scopeId, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateOrUpdateTemplateVariableRequestScopeIdVariablesNameCreate: " + e.Message );
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
 **name** | **string**| The template variable&#39;s name. | 
 **body** | [**CreateOrUpdateTemplateVariableRequest**](CreateOrUpdateTemplateVariableRequest.md)|  | [optional] 

### Return type

[**TemplateVariable**](TemplateVariable.md)

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

<a name="createtemplaterequestscopeidtypenamepost"></a>
# **CreateTemplateRequestScopeIdTypeNamePost**
> Template CreateTemplateRequestScopeIdTypeNamePost (string accept, string scopeId, string type, string name, CreateTemplateRequest body = null)

Create a new template - {CreateTemplateRequest}

Create a new template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateTemplateRequestScopeIdTypeNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var type = type_example;  // string | Template type to create
            var name = name_example;  // string | Template name
            var body = new CreateTemplateRequest(); // CreateTemplateRequest |  (optional) 

            try
            {
                // Create a new template - {CreateTemplateRequest}
                Template result = apiInstance.CreateTemplateRequestScopeIdTypeNamePost(accept, scopeId, type, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateTemplateRequestScopeIdTypeNamePost: " + e.Message );
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
 **type** | **string**| Template type to create | 
 **name** | **string**| Template name | 
 **body** | [**CreateTemplateRequest**](CreateTemplateRequest.md)|  | [optional] 

### Return type

[**Template**](Template.md)

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

<a name="deletetemplaterequestscopeidtypenamedelete"></a>
# **DeleteTemplateRequestScopeIdTypeNameDelete**
> void DeleteTemplateRequestScopeIdTypeNameDelete (string accept, string scopeId, string type, string name)

Delete a template - {DeleteTemplateRequest}

Delete a template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteTemplateRequestScopeIdTypeNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var type = type_example;  // string | the type of the template
            var name = name_example;  // string | the name of the template

            try
            {
                // Delete a template - {DeleteTemplateRequest}
                apiInstance.DeleteTemplateRequestScopeIdTypeNameDelete(accept, scopeId, type, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteTemplateRequestScopeIdTypeNameDelete: " + e.Message );
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
 **type** | **string**| the type of the template | 
 **name** | **string**| the name of the template | 

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

<a name="deletetemplatevariablerequestscopeidvariablesnamedelete"></a>
# **DeleteTemplateVariableRequestScopeIdVariablesNameDelete**
> void DeleteTemplateVariableRequestScopeIdVariablesNameDelete (string accept, string scopeId, string name)

Deletes a template variable - {DeleteTemplateVariableRequest}

Deletes a template variable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteTemplateVariableRequestScopeIdVariablesNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var name = name_example;  // string | The name of the template variable to be deleted from the scope.

            try
            {
                // Deletes a template variable - {DeleteTemplateVariableRequest}
                apiInstance.DeleteTemplateVariableRequestScopeIdVariablesNameDelete(accept, scopeId, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteTemplateVariableRequestScopeIdVariablesNameDelete: " + e.Message );
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
 **name** | **string**| The name of the template variable to be deleted from the scope. | 

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

<a name="gettemplatebynamerequestscopeidtypenameget"></a>
# **GetTemplateByNameRequestScopeIdTypeNameGet**
> Template GetTemplateByNameRequestScopeIdTypeNameGet (string accept, string scopeId, string type, string name, bool? includeContents = null, List<string> cultures = null, bool? activeOnly = null, bool? replaceTemplateVariables = null)

Retrieves a template available for a scope and a name - {GetTemplateByNameRequest}

Retrieve a template available for a scope and a name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTemplateByNameRequestScopeIdTypeNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var type = type_example;  // string | Type of the template to retrieve
            var name = name_example;  // string | Name of the template to retrieve
            var includeContents = true;  // bool? | Determines whether the template content will be included with the result (optional) 
            var cultures = new List<string>(); // List<string> | List of cultures for which to retrieve the content (optional) 
            var activeOnly = true;  // bool? | Determines whether the result will include inactive templates (optional) 
            var replaceTemplateVariables = true;  // bool? | Determines if the template variable tags will be replaced with their actual values. (optional) 

            try
            {
                // Retrieves a template available for a scope and a name - {GetTemplateByNameRequest}
                Template result = apiInstance.GetTemplateByNameRequestScopeIdTypeNameGet(accept, scopeId, type, name, includeContents, cultures, activeOnly, replaceTemplateVariables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetTemplateByNameRequestScopeIdTypeNameGet: " + e.Message );
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
 **type** | **string**| Type of the template to retrieve | 
 **name** | **string**| Name of the template to retrieve | 
 **includeContents** | **bool?**| Determines whether the template content will be included with the result | [optional] 
 **cultures** | [**List&lt;string&gt;**](string.md)| List of cultures for which to retrieve the content | [optional] 
 **activeOnly** | **bool?**| Determines whether the result will include inactive templates | [optional] 
 **replaceTemplateVariables** | **bool?**| Determines if the template variable tags will be replaced with their actual values. | [optional] 

### Return type

[**Template**](Template.md)

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

<a name="gettemplatevariablesrequestscopeidvariablesget"></a>
# **GetTemplateVariablesRequestScopeIdVariablesGet**
> List&lt;TemplateVariable&gt; GetTemplateVariablesRequestScopeIdVariablesGet (string accept, string scopeId)

Gets a list of template variables for a scope - {GetTemplateVariablesRequest}

Gets a list of template variables for a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTemplateVariablesRequestScopeIdVariablesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Gets a list of template variables for a scope - {GetTemplateVariablesRequest}
                List<TemplateVariable> result = apiInstance.GetTemplateVariablesRequestScopeIdVariablesGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetTemplateVariablesRequestScopeIdVariablesGet: " + e.Message );
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

[**List&lt;TemplateVariable&gt;**](TemplateVariable.md)

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

<a name="gettemplatesrequestscopeidtypeget"></a>
# **GetTemplatesRequestScopeIdTypeGet**
> List&lt;Template&gt; GetTemplatesRequestScopeIdTypeGet (string accept, string scopeId, string type, bool? includeContents = null, bool? activeOnly = null, List<string> cultures = null, bool? replaceTemplateVariables = null)

Retrieve a list of all templates available for a scope and a type - {GetTemplatesRequest}

Retrieve a list of all templates available for a scope and a type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTemplatesRequestScopeIdTypeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var type = type_example;  // string | Template type to retrieve
            var includeContents = true;  // bool? | Determines whether the template content will be included with the result (optional) 
            var activeOnly = true;  // bool? | Determines whether the result will include inactive templates (optional) 
            var cultures = new List<string>(); // List<string> | List of cultures for which to retrieve the content (optional) 
            var replaceTemplateVariables = true;  // bool? | Determines if the template variable tags will be replaced with their actual values. (optional) 

            try
            {
                // Retrieve a list of all templates available for a scope and a type - {GetTemplatesRequest}
                List<Template> result = apiInstance.GetTemplatesRequestScopeIdTypeGet(accept, scopeId, type, includeContents, activeOnly, cultures, replaceTemplateVariables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetTemplatesRequestScopeIdTypeGet: " + e.Message );
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
 **type** | **string**| Template type to retrieve | 
 **includeContents** | **bool?**| Determines whether the template content will be included with the result | [optional] 
 **activeOnly** | **bool?**| Determines whether the result will include inactive templates | [optional] 
 **cultures** | [**List&lt;string&gt;**](string.md)| List of cultures for which to retrieve the content | [optional] 
 **replaceTemplateVariables** | **bool?**| Determines if the template variable tags will be replaced with their actual values. | [optional] 

### Return type

[**List&lt;Template&gt;**](Template.md)

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

<a name="updatetemplaterequestscopeidtypenameculturecreate"></a>
# **UpdateTemplateRequestScopeIdTypeNameCultureCreate**
> Template UpdateTemplateRequestScopeIdTypeNameCultureCreate (string accept, string scopeId, string type, string name, string culture, UpdateTemplateRequest body = null)

Update a template - {UpdateTemplateRequest}

Update a template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateTemplateRequestScopeIdTypeNameCultureCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var type = type_example;  // string | the type of the template
            var name = name_example;  // string | the name of the template
            var culture = culture_example;  // string | the culture of the template
            var body = new UpdateTemplateRequest(); // UpdateTemplateRequest |  (optional) 

            try
            {
                // Update a template - {UpdateTemplateRequest}
                Template result = apiInstance.UpdateTemplateRequestScopeIdTypeNameCultureCreate(accept, scopeId, type, name, culture, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateTemplateRequestScopeIdTypeNameCultureCreate: " + e.Message );
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
 **type** | **string**| the type of the template | 
 **name** | **string**| the name of the template | 
 **culture** | **string**| the culture of the template | 
 **body** | [**UpdateTemplateRequest**](UpdateTemplateRequest.md)|  | [optional] 

### Return type

[**Template**](Template.md)

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

