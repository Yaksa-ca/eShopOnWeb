# Yaksa.OrckestraCommerce.Client.Api.CustomersApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAddressToCustomerRequestScopeIdCustomerIdaddressesPost**](CustomersApi.md#addaddresstocustomerrequestscopeidcustomeridaddressespost) | **POST** /customers/{ScopeId}/{CustomerId}/addresses | Add an address to a customer&#39;s addresses - {AddAddressToCustomerRequest}
[**AddCustomerNoteRequestScopeIdCustomerIdnotesPost**](CustomersApi.md#addcustomernoterequestscopeidcustomeridnotespost) | **POST** /customers/{ScopeId}/{CustomerId}/notes | Add a note to a customer - {AddCustomerNoteRequest}
[**AddCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfilePost**](CustomersApi.md#addcustomerpaymentprofilerequestscopeidcustomeridpaymentprovidernamepaymentprofilepost) | **POST** /customers/{ScopeId}/{CustomerId}/{PaymentProviderName}/paymentProfile | Add customer payment profile related to a specific payment provider - {AddCustomerPaymentProfileRequest}
[**AddOrUpdateCustomerAddressRequestCustomerIdaddressesAddressIdCreate**](CustomersApi.md#addorupdatecustomeraddressrequestcustomeridaddressesaddressidcreate) | **PUT** /customers/{CustomerId}/addresses/{AddressId} | Add or updates a customer address - {AddOrUpdateCustomerAddressRequest}
[**AddOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsPost**](CustomersApi.md#addorganizationstocustomerrequestscopeidcustomeridorganizationspost) | **POST** /customers/{ScopeId}/{CustomerId}/organizations | Add organizations to a customer - {AddOrganizationsToCustomerRequest}
[**AssociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdPost**](CustomersApi.md#associatecustomerentityrequestcustomeridcustomprofilesscopeidattributenameentityidpost) | **POST** /customers/{CustomerId}/customProfiles/{ScopeId}/{AttributeName}/{EntityId} | Associate a customer to an entity - {AssociateCustomerEntityRequest}
[**CreateCustomerRequestScopeIdPost**](CustomersApi.md#createcustomerrequestscopeidpost) | **POST** /customers/{ScopeId} | Create a customer - {CreateCustomerRequest}
[**DeleteCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIdDelete**](CustomersApi.md#deletecustomerpaymentmethodrequestscopeidcustomeridpaymentprovidernamepaymentmethodspaymentmethodiddelete) | **DELETE** /customers/{ScopeId}/{CustomerId}/{PaymentProviderName}/paymentMethods/{PaymentMethodId} | Remove the PaymentMethod associated with a customer - {DeleteCustomerPaymentMethodRequest}
[**DisassociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdDelete**](CustomersApi.md#disassociatecustomerentityrequestcustomeridcustomprofilesscopeidattributenameentityiddelete) | **DELETE** /customers/{CustomerId}/customProfiles/{ScopeId}/{AttributeName}/{EntityId} | Removes the association between a customer an entity - {DisassociateCustomerEntityRequest}
[**FindCustomersRequestScopeIdfindPost**](CustomersApi.md#findcustomersrequestscopeidfindpost) | **POST** /customers/{ScopeId}/find | Search for customers - {FindCustomersRequest}
[**GetCustomerAddressesRequestScopeIdCustomerIdaddressesGet**](CustomersApi.md#getcustomeraddressesrequestscopeidcustomeridaddressesget) | **GET** /customers/{ScopeId}/{CustomerId}/addresses | Retrieve the addresses of a customer - {GetCustomerAddressesRequest}
[**GetCustomerByUsernameRequestScopeIdbyUsernameUsernameGet**](CustomersApi.md#getcustomerbyusernamerequestscopeidbyusernameusernameget) | **GET** /customers/{ScopeId}/byUsername/{Username} | Retrieve a customer by user name - {GetCustomerByUsernameRequest}
[**GetCustomerFromPasswordTicketRequestbyTicketGet**](CustomersApi.md#getcustomerfrompasswordticketrequestbyticketget) | **GET** /customers/byTicket | Retrieve the customer from a password reset ticket - {GetCustomerFromPasswordTicketRequest}
[**GetCustomerNotesRequestScopeIdCustomerIdnotesGet**](CustomersApi.md#getcustomernotesrequestscopeidcustomeridnotesget) | **GET** /customers/{ScopeId}/{CustomerId}/notes | Get customer notes - {GetCustomerNotesRequest}
[**GetCustomerOrderHistoryRequestScopeIdCustomerIdordersGet**](CustomersApi.md#getcustomerorderhistoryrequestscopeidcustomeridordersget) | **GET** /customers/{ScopeId}/{CustomerId}/orders | Retrieve the order history of a customer - {GetCustomerOrderHistoryRequest}
[**GetCustomerOrganizationsRequestScopeIdCustomerIdorganizationsGet**](CustomersApi.md#getcustomerorganizationsrequestscopeidcustomeridorganizationsget) | **GET** /customers/{ScopeId}/{CustomerId}/organizations | Get customer organizations for a scope - {GetCustomerOrganizationsRequest}
[**GetCustomerPaymentMethodsRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsGet**](CustomersApi.md#getcustomerpaymentmethodsrequestscopeidcustomeridpaymentprovidernamepaymentmethodsget) | **GET** /customers/{ScopeId}/{CustomerId}/{PaymentProviderName}/paymentMethods | Retrieve the Payment methods from a payment provider for a customer - {GetCustomerPaymentMethodsRequest}
[**GetCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileGet**](CustomersApi.md#getcustomerpaymentprofilerequestscopeidcustomeridpaymentprovidernamepaymentprofileget) | **GET** /customers/{ScopeId}/{CustomerId}/{PaymentProviderName}/paymentProfile | Retrieve customer payment profile related to a specific payment provider - {GetCustomerPaymentProfileRequest}
[**GetCustomerPaymentProfilesRequestScopeIdCustomerIdpaymentProfilesGet**](CustomersApi.md#getcustomerpaymentprofilesrequestscopeidcustomeridpaymentprofilesget) | **GET** /customers/{ScopeId}/{CustomerId}/paymentProfiles | Get customer payment profiles for a scope - {GetCustomerPaymentProfilesRequest}
[**GetCustomerRequestScopeIdCustomerIdGet**](CustomersApi.md#getcustomerrequestscopeidcustomeridget) | **GET** /customers/{ScopeId}/{CustomerId} | Retrieve a customer - {GetCustomerRequest}
[**GetCustomerStoresRequestScopeIdCustomerIdstoresGet**](CustomersApi.md#getcustomerstoresrequestscopeidcustomeridstoresget) | **GET** /customers/{ScopeId}/{CustomerId}/stores | Retrieve the customer&#39;s stores - {GetCustomerStoresRequest}
[**RemoveOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsDelete**](CustomersApi.md#removeorganizationstocustomerrequestscopeidcustomeridorganizationsdelete) | **DELETE** /customers/{ScopeId}/{CustomerId}/organizations | Remove organizations from a customer - {RemoveOrganizationsToCustomerRequest}
[**SetDefaultCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIddefaultCreate**](CustomersApi.md#setdefaultcustomerpaymentmethodrequestscopeidcustomeridpaymentprovidernamepaymentmethodspaymentmethodiddefaultcreate) | **PUT** /customers/{ScopeId}/{CustomerId}/{PaymentProviderName}/paymentMethods/{PaymentMethodId}/default | Sets the default PaymentMethod for a customer profile - {SetDefaultCustomerPaymentMethodRequest}
[**UpdateCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileCreate**](CustomersApi.md#updatecustomerpaymentprofilerequestscopeidcustomeridpaymentprovidernamepaymentprofilecreate) | **PUT** /customers/{ScopeId}/{CustomerId}/{PaymentProviderName}/paymentProfile | Update a customer payment profile related to a specific payment provider - {UpdateCustomerPaymentProfileRequest}
[**UpdateCustomerRequestScopeIdCustomerIdCreate**](CustomersApi.md#updatecustomerrequestscopeidcustomeridcreate) | **PUT** /customers/{ScopeId}/{CustomerId} | Updates a customer - {UpdateCustomerRequest}
[**UpdatePreferredStoreRequestScopeIdCustomerIdpreferredstoreCreate**](CustomersApi.md#updatepreferredstorerequestscopeidcustomeridpreferredstorecreate) | **PUT** /customers/{ScopeId}/{CustomerId}/preferred/store | Updates the customer&#39;s preferred store - {UpdatePreferredStoreRequest}


<a name="addaddresstocustomerrequestscopeidcustomeridaddressespost"></a>
# **AddAddressToCustomerRequestScopeIdCustomerIdaddressesPost**
> Address AddAddressToCustomerRequestScopeIdCustomerIdaddressesPost (string accept, string scopeId, string customerId, AddAddressToCustomerRequest body = null)

Add an address to a customer's addresses - {AddAddressToCustomerRequest}

Add an address to a customer's addresses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddAddressToCustomerRequestScopeIdCustomerIdaddressesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | Customer unique identifier.
            var body = new AddAddressToCustomerRequest(); // AddAddressToCustomerRequest |  (optional) 

            try
            {
                // Add an address to a customer's addresses - {AddAddressToCustomerRequest}
                Address result = apiInstance.AddAddressToCustomerRequestScopeIdCustomerIdaddressesPost(accept, scopeId, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.AddAddressToCustomerRequestScopeIdCustomerIdaddressesPost: " + e.Message );
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
 **customerId** | **string**| Customer unique identifier. | 
 **body** | [**AddAddressToCustomerRequest**](AddAddressToCustomerRequest.md)|  | [optional] 

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

<a name="addcustomernoterequestscopeidcustomeridnotespost"></a>
# **AddCustomerNoteRequestScopeIdCustomerIdnotesPost**
> void AddCustomerNoteRequestScopeIdCustomerIdnotesPost (string accept, string scopeId, string customerId, AddCustomerNoteRequest body = null)

Add a note to a customer - {AddCustomerNoteRequest}

Add a note to a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddCustomerNoteRequestScopeIdCustomerIdnotesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer identifier.
            var body = new AddCustomerNoteRequest(); // AddCustomerNoteRequest |  (optional) 

            try
            {
                // Add a note to a customer - {AddCustomerNoteRequest}
                apiInstance.AddCustomerNoteRequestScopeIdCustomerIdnotesPost(accept, scopeId, customerId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.AddCustomerNoteRequestScopeIdCustomerIdnotesPost: " + e.Message );
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
 **customerId** | **string**| The customer identifier. | 
 **body** | [**AddCustomerNoteRequest**](AddCustomerNoteRequest.md)|  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomerpaymentprofilerequestscopeidcustomeridpaymentprovidernamepaymentprofilepost"></a>
# **AddCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfilePost**
> PaymentProfile AddCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfilePost (string accept, string scopeId, string customerId, string paymentProviderName, AddCustomerPaymentProfileRequest body = null)

Add customer payment profile related to a specific payment provider - {AddCustomerPaymentProfileRequest}

Add customer payment profile related to a specific payment provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer's unique identifier of the payment profile.
            var paymentProviderName = paymentProviderName_example;  // string | The unique identifier of the provider related to the payment profile.
            var body = new AddCustomerPaymentProfileRequest(); // AddCustomerPaymentProfileRequest |  (optional) 

            try
            {
                // Add customer payment profile related to a specific payment provider - {AddCustomerPaymentProfileRequest}
                PaymentProfile result = apiInstance.AddCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfilePost(accept, scopeId, customerId, paymentProviderName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.AddCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfilePost: " + e.Message );
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
 **customerId** | **string**| The customer&#39;s unique identifier of the payment profile. | 
 **paymentProviderName** | **string**| The unique identifier of the provider related to the payment profile. | 
 **body** | [**AddCustomerPaymentProfileRequest**](AddCustomerPaymentProfileRequest.md)|  | [optional] 

### Return type

[**PaymentProfile**](PaymentProfile.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorupdatecustomeraddressrequestcustomeridaddressesaddressidcreate"></a>
# **AddOrUpdateCustomerAddressRequestCustomerIdaddressesAddressIdCreate**
> Address AddOrUpdateCustomerAddressRequestCustomerIdaddressesAddressIdCreate (string accept, string customerId, string addressId, AddOrUpdateCustomerAddressRequest body = null)

Add or updates a customer address - {AddOrUpdateCustomerAddressRequest}

Add or updates a customer address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateCustomerAddressRequestCustomerIdaddressesAddressIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer identifier.
            var addressId = addressId_example;  // string | Unique identifier
            var body = new AddOrUpdateCustomerAddressRequest(); // AddOrUpdateCustomerAddressRequest |  (optional) 

            try
            {
                // Add or updates a customer address - {AddOrUpdateCustomerAddressRequest}
                Address result = apiInstance.AddOrUpdateCustomerAddressRequestCustomerIdaddressesAddressIdCreate(accept, customerId, addressId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.AddOrUpdateCustomerAddressRequestCustomerIdaddressesAddressIdCreate: " + e.Message );
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
 **customerId** | **string**| The customer identifier. | 
 **addressId** | **string**| Unique identifier | 
 **body** | [**AddOrUpdateCustomerAddressRequest**](AddOrUpdateCustomerAddressRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorganizationstocustomerrequestscopeidcustomeridorganizationspost"></a>
# **AddOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsPost**
> void AddOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsPost (string accept, string scopeId, string customerId, AddOrganizationsToCustomerRequest body = null)

Add organizations to a customer - {AddOrganizationsToCustomerRequest}

Add organizations to a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier for the customer.
            var body = new AddOrganizationsToCustomerRequest(); // AddOrganizationsToCustomerRequest |  (optional) 

            try
            {
                // Add organizations to a customer - {AddOrganizationsToCustomerRequest}
                apiInstance.AddOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsPost(accept, scopeId, customerId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.AddOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier for the customer. | 
 **body** | [**AddOrganizationsToCustomerRequest**](AddOrganizationsToCustomerRequest.md)|  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associatecustomerentityrequestcustomeridcustomprofilesscopeidattributenameentityidpost"></a>
# **AssociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdPost**
> void AssociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdPost (string accept, string customerId, string scopeId, string attributeName, string entityId, Object body = null)

Associate a customer to an entity - {AssociateCustomerEntityRequest}

Associate a customer to an entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AssociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer identifier.
            var scopeId = scopeId_example;  // string | The id of scope in which the parent entity belongs.
            var attributeName = attributeName_example;  // string | The name of the attribute in the parent definition under which the association is kept.
            var entityId = entityId_example;  // string | The unique identifier for the associated entity.
            var body = ;  // Object |  (optional) 

            try
            {
                // Associate a customer to an entity - {AssociateCustomerEntityRequest}
                apiInstance.AssociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdPost(accept, customerId, scopeId, attributeName, entityId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.AssociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdPost: " + e.Message );
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
 **customerId** | **string**| The customer identifier. | 
 **scopeId** | **string**| The id of scope in which the parent entity belongs. | 
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

<a name="createcustomerrequestscopeidpost"></a>
# **CreateCustomerRequestScopeIdPost**
> Customer CreateCustomerRequestScopeIdPost (string accept, string scopeId, CreateCustomerRequest body = null)

Create a customer - {CreateCustomerRequest}

Create a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCustomerRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope in which the customer belong.
            var body = new CreateCustomerRequest(); // CreateCustomerRequest |  (optional) 

            try
            {
                // Create a customer - {CreateCustomerRequest}
                Customer result = apiInstance.CreateCustomerRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerRequestScopeIdPost: " + e.Message );
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
 **scopeId** | **string**| The scope in which the customer belong. | 
 **body** | [**CreateCustomerRequest**](CreateCustomerRequest.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

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

<a name="deletecustomerpaymentmethodrequestscopeidcustomeridpaymentprovidernamepaymentmethodspaymentmethodiddelete"></a>
# **DeleteCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIdDelete**
> void DeleteCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIdDelete (string accept, string scopeId, string customerId, string paymentProviderName, string paymentMethodId)

Remove the PaymentMethod associated with a customer - {DeleteCustomerPaymentMethodRequest}

Remove the PaymentMethod associated with a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | the unique identifier of the Customer owning the cart.
            var paymentProviderName = paymentProviderName_example;  // string | the name of the payment provider to use. If null, all methods will be returned
            var paymentMethodId = paymentMethodId_example;  // string | the unique identifier of the payment method to be removed

            try
            {
                // Remove the PaymentMethod associated with a customer - {DeleteCustomerPaymentMethodRequest}
                apiInstance.DeleteCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIdDelete(accept, scopeId, customerId, paymentProviderName, paymentMethodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIdDelete: " + e.Message );
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
 **customerId** | **string**| the unique identifier of the Customer owning the cart. | 
 **paymentProviderName** | **string**| the name of the payment provider to use. If null, all methods will be returned | 
 **paymentMethodId** | **string**| the unique identifier of the payment method to be removed | 

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

<a name="disassociatecustomerentityrequestcustomeridcustomprofilesscopeidattributenameentityiddelete"></a>
# **DisassociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdDelete**
> void DisassociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdDelete (string accept, string customerId, string scopeId, string attributeName, string entityId)

Removes the association between a customer an entity - {DisassociateCustomerEntityRequest}

Removes the association between a customer an entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DisassociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer identifier.
            var scopeId = scopeId_example;  // string | The identifier of scope in which the parent entity belong.
            var attributeName = attributeName_example;  // string | The name of the attribute in the parent definition under which the association is kept.
            var entityId = entityId_example;  // string | The unique identifier for the associated entity.

            try
            {
                // Removes the association between a customer an entity - {DisassociateCustomerEntityRequest}
                apiInstance.DisassociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdDelete(accept, customerId, scopeId, attributeName, entityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.DisassociateCustomerEntityRequestCustomerIdcustomProfilesScopeIdAttributeNameEntityIdDelete: " + e.Message );
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
 **customerId** | **string**| The customer identifier. | 
 **scopeId** | **string**| The identifier of scope in which the parent entity belong. | 
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

<a name="findcustomersrequestscopeidfindpost"></a>
# **FindCustomersRequestScopeIdfindPost**
> CustomerQueryResult FindCustomersRequestScopeIdfindPost (string accept, string scopeId, FindCustomersRequest body = null)

Search for customers - {FindCustomersRequest}

Search for customers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindCustomersRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindCustomersRequest(); // FindCustomersRequest |  (optional) 

            try
            {
                // Search for customers - {FindCustomersRequest}
                CustomerQueryResult result = apiInstance.FindCustomersRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.FindCustomersRequestScopeIdfindPost: " + e.Message );
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
 **body** | [**FindCustomersRequest**](FindCustomersRequest.md)|  | [optional] 

### Return type

[**CustomerQueryResult**](CustomerQueryResult.md)

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
| **404** | No customers was found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomeraddressesrequestscopeidcustomeridaddressesget"></a>
# **GetCustomerAddressesRequestScopeIdCustomerIdaddressesGet**
> List&lt;Address&gt; GetCustomerAddressesRequestScopeIdCustomerIdaddressesGet (string accept, string scopeId, string customerId)

Retrieve the addresses of a customer - {GetCustomerAddressesRequest}

Retrieve the addresses of a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerAddressesRequestScopeIdCustomerIdaddressesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier associated to the requested customer

            try
            {
                // Retrieve the addresses of a customer - {GetCustomerAddressesRequest}
                List<Address> result = apiInstance.GetCustomerAddressesRequestScopeIdCustomerIdaddressesGet(accept, scopeId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerAddressesRequestScopeIdCustomerIdaddressesGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier associated to the requested customer | 

### Return type

[**List&lt;Address&gt;**](Address.md)

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
| **404** | Requested customer addresses not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerbyusernamerequestscopeidbyusernameusernameget"></a>
# **GetCustomerByUsernameRequestScopeIdbyUsernameUsernameGet**
> Customer GetCustomerByUsernameRequestScopeIdbyUsernameUsernameGet (string accept, string scopeId, string username, bool? includeAddresses = null)

Retrieve a customer by user name - {GetCustomerByUsernameRequest}

Retrieve a customer by user name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerByUsernameRequestScopeIdbyUsernameUsernameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var username = username_example;  // string | The username associated to the requested customer
            var includeAddresses = true;  // bool? | Specifies whether or not to fully load the collection of addresses linked to the customer. (optional) 

            try
            {
                // Retrieve a customer by user name - {GetCustomerByUsernameRequest}
                Customer result = apiInstance.GetCustomerByUsernameRequestScopeIdbyUsernameUsernameGet(accept, scopeId, username, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerByUsernameRequestScopeIdbyUsernameUsernameGet: " + e.Message );
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
 **username** | **string**| The username associated to the requested customer | 
 **includeAddresses** | **bool?**| Specifies whether or not to fully load the collection of addresses linked to the customer. | [optional] 

### Return type

[**Customer**](Customer.md)

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
| **404** | no customer has the username. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerfrompasswordticketrequestbyticketget"></a>
# **GetCustomerFromPasswordTicketRequestbyTicketGet**
> Customer GetCustomerFromPasswordTicketRequestbyTicketGet (string accept, string ticket)

Retrieve the customer from a password reset ticket - {GetCustomerFromPasswordTicketRequest}

Decrypts a password reset ticket and returns a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerFromPasswordTicketRequestbyTicketGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var ticket = ticket_example;  // string | The ticket

            try
            {
                // Retrieve the customer from a password reset ticket - {GetCustomerFromPasswordTicketRequest}
                Customer result = apiInstance.GetCustomerFromPasswordTicketRequestbyTicketGet(accept, ticket);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerFromPasswordTicketRequestbyTicketGet: " + e.Message );
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
 **ticket** | **string**| The ticket | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | CustomerId decrypted in the ticket does not match with an existing customer or is not valid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomernotesrequestscopeidcustomeridnotesget"></a>
# **GetCustomerNotesRequestScopeIdCustomerIdnotesGet**
> List&lt;Note&gt; GetCustomerNotesRequestScopeIdCustomerIdnotesGet (string accept, string scopeId, string customerId)

Get customer notes - {GetCustomerNotesRequest}

Get customer notes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerNotesRequestScopeIdCustomerIdnotesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the customer.

            try
            {
                // Get customer notes - {GetCustomerNotesRequest}
                List<Note> result = apiInstance.GetCustomerNotesRequestScopeIdCustomerIdnotesGet(accept, scopeId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerNotesRequestScopeIdCustomerIdnotesGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the customer. | 

### Return type

[**List&lt;Note&gt;**](Note.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerorderhistoryrequestscopeidcustomeridordersget"></a>
# **GetCustomerOrderHistoryRequestScopeIdCustomerIdordersGet**
> OrderQueryResult GetCustomerOrderHistoryRequestScopeIdCustomerIdordersGet (string accept, string scopeId, string customerId, DateTime? ordersCreatedAfter = null)

Retrieve the order history of a customer - {GetCustomerOrderHistoryRequest}

Retrieve the order history of a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerOrderHistoryRequestScopeIdCustomerIdordersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier associated to the requested customer
            var ordersCreatedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Shows the orders after this date. (optional) 

            try
            {
                // Retrieve the order history of a customer - {GetCustomerOrderHistoryRequest}
                OrderQueryResult result = apiInstance.GetCustomerOrderHistoryRequestScopeIdCustomerIdordersGet(accept, scopeId, customerId, ordersCreatedAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerOrderHistoryRequestScopeIdCustomerIdordersGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier associated to the requested customer | 
 **ordersCreatedAfter** | **DateTime?**| Shows the orders after this date. | [optional] 

### Return type

[**OrderQueryResult**](OrderQueryResult.md)

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
| **404** | Requested customer orders not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerorganizationsrequestscopeidcustomeridorganizationsget"></a>
# **GetCustomerOrganizationsRequestScopeIdCustomerIdorganizationsGet**
> List&lt;Organization&gt; GetCustomerOrganizationsRequestScopeIdCustomerIdorganizationsGet (string accept, string scopeId, string customerId, bool? includeAllAddresses = null)

Get customer organizations for a scope - {GetCustomerOrganizationsRequest}

Get customer organizations for a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerOrganizationsRequestScopeIdCustomerIdorganizationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the customer.
            var includeAllAddresses = true;  // bool? | Gets or sets a value indicating whether all addresses should be returned or only the first one. If False only one organization address will be returned using either IsPreferredBilling or IsPreferredShipping as priority. If True every organization addresses for the customer will be returned (optional) 

            try
            {
                // Get customer organizations for a scope - {GetCustomerOrganizationsRequest}
                List<Organization> result = apiInstance.GetCustomerOrganizationsRequestScopeIdCustomerIdorganizationsGet(accept, scopeId, customerId, includeAllAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerOrganizationsRequestScopeIdCustomerIdorganizationsGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the customer. | 
 **includeAllAddresses** | **bool?**| Gets or sets a value indicating whether all addresses should be returned or only the first one. If False only one organization address will be returned using either IsPreferredBilling or IsPreferredShipping as priority. If True every organization addresses for the customer will be returned | [optional] 

### Return type

[**List&lt;Organization&gt;**](Organization.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerpaymentmethodsrequestscopeidcustomeridpaymentprovidernamepaymentmethodsget"></a>
# **GetCustomerPaymentMethodsRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsGet**
> List&lt;PaymentMethod&gt; GetCustomerPaymentMethodsRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsGet (string accept, string scopeId, string customerId, string paymentProviderName)

Retrieve the Payment methods from a payment provider for a customer - {GetCustomerPaymentMethodsRequest}

Retrieve the payment methods from a provider previously used by a specific customer. This request calls the method GetPaymentMethods(string customerId) of the payment provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerPaymentMethodsRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | the unique identifier of the Customer
            var paymentProviderName = paymentProviderName_example;  // string | the name of the payment provider to use

            try
            {
                // Retrieve the Payment methods from a payment provider for a customer - {GetCustomerPaymentMethodsRequest}
                List<PaymentMethod> result = apiInstance.GetCustomerPaymentMethodsRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsGet(accept, scopeId, customerId, paymentProviderName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerPaymentMethodsRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsGet: " + e.Message );
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
 **customerId** | **string**| the unique identifier of the Customer | 
 **paymentProviderName** | **string**| the name of the payment provider to use | 

### Return type

[**List&lt;PaymentMethod&gt;**](PaymentMethod.md)

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

<a name="getcustomerpaymentprofilerequestscopeidcustomeridpaymentprovidernamepaymentprofileget"></a>
# **GetCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileGet**
> PaymentProfile GetCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileGet (string accept, string scopeId, string customerId, string paymentProviderName)

Retrieve customer payment profile related to a specific payment provider - {GetCustomerPaymentProfileRequest}

Retrieve the customer payment profile related to a specific payment provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the customer to retrieve.
            var paymentProviderName = paymentProviderName_example;  // string | The name of the payment provider.

            try
            {
                // Retrieve customer payment profile related to a specific payment provider - {GetCustomerPaymentProfileRequest}
                PaymentProfile result = apiInstance.GetCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileGet(accept, scopeId, customerId, paymentProviderName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the customer to retrieve. | 
 **paymentProviderName** | **string**| The name of the payment provider. | 

### Return type

[**PaymentProfile**](PaymentProfile.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerpaymentprofilesrequestscopeidcustomeridpaymentprofilesget"></a>
# **GetCustomerPaymentProfilesRequestScopeIdCustomerIdpaymentProfilesGet**
> List&lt;PaymentProfile&gt; GetCustomerPaymentProfilesRequestScopeIdCustomerIdpaymentProfilesGet (string accept, string scopeId, string customerId)

Get customer payment profiles for a scope - {GetCustomerPaymentProfilesRequest}

Get customer payment profiles for a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerPaymentProfilesRequestScopeIdCustomerIdpaymentProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the customer.

            try
            {
                // Get customer payment profiles for a scope - {GetCustomerPaymentProfilesRequest}
                List<PaymentProfile> result = apiInstance.GetCustomerPaymentProfilesRequestScopeIdCustomerIdpaymentProfilesGet(accept, scopeId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerPaymentProfilesRequestScopeIdCustomerIdpaymentProfilesGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the customer. | 

### Return type

[**List&lt;PaymentProfile&gt;**](PaymentProfile.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerrequestscopeidcustomeridget"></a>
# **GetCustomerRequestScopeIdCustomerIdGet**
> Customer GetCustomerRequestScopeIdCustomerIdGet (string accept, string scopeId, string customerId, bool? includeAddresses = null)

Retrieve a customer - {GetCustomerRequest}

Retrieve a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerRequestScopeIdCustomerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique id of the requested customer
            var includeAddresses = true;  // bool? | Specifies whether or not to fully load the collection of addresses linked to the customer. (optional) 

            try
            {
                // Retrieve a customer - {GetCustomerRequest}
                Customer result = apiInstance.GetCustomerRequestScopeIdCustomerIdGet(accept, scopeId, customerId, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerRequestScopeIdCustomerIdGet: " + e.Message );
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
 **customerId** | **string**| The unique id of the requested customer | 
 **includeAddresses** | **bool?**| Specifies whether or not to fully load the collection of addresses linked to the customer. | [optional] 

### Return type

[**Customer**](Customer.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerstoresrequestscopeidcustomeridstoresget"></a>
# **GetCustomerStoresRequestScopeIdCustomerIdstoresGet**
> CustomerStoresAssociations GetCustomerStoresRequestScopeIdCustomerIdstoresGet (string accept, string scopeId, string customerId, bool? includeAddresses = null)

Retrieve the customer's stores - {GetCustomerStoresRequest}

Retrieve the customer's stores.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerStoresRequestScopeIdCustomerIdstoresGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique id of the customer
            var includeAddresses = true;  // bool? | The value indicating whether the addresses should be included (optional) 

            try
            {
                // Retrieve the customer's stores - {GetCustomerStoresRequest}
                CustomerStoresAssociations result = apiInstance.GetCustomerStoresRequestScopeIdCustomerIdstoresGet(accept, scopeId, customerId, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerStoresRequestScopeIdCustomerIdstoresGet: " + e.Message );
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
 **customerId** | **string**| The unique id of the customer | 
 **includeAddresses** | **bool?**| The value indicating whether the addresses should be included | [optional] 

### Return type

[**CustomerStoresAssociations**](CustomerStoresAssociations.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeorganizationstocustomerrequestscopeidcustomeridorganizationsdelete"></a>
# **RemoveOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsDelete**
> void RemoveOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsDelete (string accept, string scopeId, string customerId, List<string> associatedIds = null)

Remove organizations from a customer - {RemoveOrganizationsToCustomerRequest}

Remove organizations from a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier for the customer
            var associatedIds = new List<string>(); // List<string> | The list of unique identifier for the associated entities (optional) 

            try
            {
                // Remove organizations from a customer - {RemoveOrganizationsToCustomerRequest}
                apiInstance.RemoveOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsDelete(accept, scopeId, customerId, associatedIds);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.RemoveOrganizationsToCustomerRequestScopeIdCustomerIdorganizationsDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier for the customer | 
 **associatedIds** | [**List&lt;string&gt;**](string.md)| The list of unique identifier for the associated entities | [optional] 

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

<a name="setdefaultcustomerpaymentmethodrequestscopeidcustomeridpaymentprovidernamepaymentmethodspaymentmethodiddefaultcreate"></a>
# **SetDefaultCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIddefaultCreate**
> PaymentMethod SetDefaultCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIddefaultCreate (string accept, string scopeId, string customerId, string paymentProviderName, string paymentMethodId, SetDefaultCustomerPaymentMethodRequest body = null)

Sets the default PaymentMethod for a customer profile - {SetDefaultCustomerPaymentMethodRequest}

Sets the default PaymentMethod for a customer profile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SetDefaultCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIddefaultCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | the unique identifier of the customer owning the cart.
            var paymentProviderName = paymentProviderName_example;  // string | the name of the payment provider to use. If null, all methods will be returned
            var paymentMethodId = paymentMethodId_example;  // string | the unique identifier of the payment method to set as default
            var body = new SetDefaultCustomerPaymentMethodRequest(); // SetDefaultCustomerPaymentMethodRequest |  (optional) 

            try
            {
                // Sets the default PaymentMethod for a customer profile - {SetDefaultCustomerPaymentMethodRequest}
                PaymentMethod result = apiInstance.SetDefaultCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIddefaultCreate(accept, scopeId, customerId, paymentProviderName, paymentMethodId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.SetDefaultCustomerPaymentMethodRequestScopeIdCustomerIdPaymentProviderNamepaymentMethodsPaymentMethodIddefaultCreate: " + e.Message );
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
 **customerId** | **string**| the unique identifier of the customer owning the cart. | 
 **paymentProviderName** | **string**| the name of the payment provider to use. If null, all methods will be returned | 
 **paymentMethodId** | **string**| the unique identifier of the payment method to set as default | 
 **body** | [**SetDefaultCustomerPaymentMethodRequest**](SetDefaultCustomerPaymentMethodRequest.md)|  | [optional] 

### Return type

[**PaymentMethod**](PaymentMethod.md)

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

<a name="updatecustomerpaymentprofilerequestscopeidcustomeridpaymentprovidernamepaymentprofilecreate"></a>
# **UpdateCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileCreate**
> PaymentProfile UpdateCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileCreate (string accept, string scopeId, string customerId, string paymentProviderName, UpdateCustomerPaymentProfileRequest body = null)

Update a customer payment profile related to a specific payment provider - {UpdateCustomerPaymentProfileRequest}

Update a customert payment profile related to a specific payment provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer's unique identifier of the payment profile.
            var paymentProviderName = paymentProviderName_example;  // string | The unique identifier of the provider related to the payment profile.
            var body = new UpdateCustomerPaymentProfileRequest(); // UpdateCustomerPaymentProfileRequest |  (optional) 

            try
            {
                // Update a customer payment profile related to a specific payment provider - {UpdateCustomerPaymentProfileRequest}
                PaymentProfile result = apiInstance.UpdateCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileCreate(accept, scopeId, customerId, paymentProviderName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomerPaymentProfileRequestScopeIdCustomerIdPaymentProviderNamepaymentProfileCreate: " + e.Message );
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
 **customerId** | **string**| The customer&#39;s unique identifier of the payment profile. | 
 **paymentProviderName** | **string**| The unique identifier of the provider related to the payment profile. | 
 **body** | [**UpdateCustomerPaymentProfileRequest**](UpdateCustomerPaymentProfileRequest.md)|  | [optional] 

### Return type

[**PaymentProfile**](PaymentProfile.md)

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
| **404** | Requested customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerrequestscopeidcustomeridcreate"></a>
# **UpdateCustomerRequestScopeIdCustomerIdCreate**
> Customer UpdateCustomerRequestScopeIdCustomerIdCreate (string accept, string scopeId, string customerId, UpdateCustomerRequest body = null)

Updates a customer - {UpdateCustomerRequest}

Updates a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCustomerRequestScopeIdCustomerIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the entity.
            var body = new UpdateCustomerRequest(); // UpdateCustomerRequest |  (optional) 

            try
            {
                // Updates a customer - {UpdateCustomerRequest}
                Customer result = apiInstance.UpdateCustomerRequestScopeIdCustomerIdCreate(accept, scopeId, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomerRequestScopeIdCustomerIdCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the entity. | 
 **body** | [**UpdateCustomerRequest**](UpdateCustomerRequest.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

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

<a name="updatepreferredstorerequestscopeidcustomeridpreferredstorecreate"></a>
# **UpdatePreferredStoreRequestScopeIdCustomerIdpreferredstoreCreate**
> Customer UpdatePreferredStoreRequestScopeIdCustomerIdpreferredstoreCreate (string accept, string scopeId, string customerId, UpdatePreferredStoreRequest body = null)

Updates the customer's preferred store - {UpdatePreferredStoreRequest}

Updates the customer's preferred store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePreferredStoreRequestScopeIdCustomerIdpreferredstoreCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CustomersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique id of the customer
            var body = new UpdatePreferredStoreRequest(); // UpdatePreferredStoreRequest |  (optional) 

            try
            {
                // Updates the customer's preferred store - {UpdatePreferredStoreRequest}
                Customer result = apiInstance.UpdatePreferredStoreRequestScopeIdCustomerIdpreferredstoreCreate(accept, scopeId, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdatePreferredStoreRequestScopeIdCustomerIdpreferredstoreCreate: " + e.Message );
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
 **customerId** | **string**| The unique id of the customer | 
 **body** | [**UpdatePreferredStoreRequest**](UpdatePreferredStoreRequest.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

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
| **404** | Requested customer or store not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

