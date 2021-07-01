# Yaksa.OrckestraCommerce.Client.Api.AddressesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddressRequestAddressIdGet**](AddressesApi.md#getaddressrequestaddressidget) | **GET** /addresses/{AddressId} | Retrieve an address using its Id - {GetAddressRequest}
[**GetAddressesByIdsRequestbyIdsIdsGet**](AddressesApi.md#getaddressesbyidsrequestbyidsidsget) | **GET** /addresses/byIds/{Ids} | Retrieve a list of addresses by Ids - {GetAddressesByIdsRequest}
[**GetCustomerAddressRequestcustomerCustomerIdAddressIdGet**](AddressesApi.md#getcustomeraddressrequestcustomercustomeridaddressidget) | **GET** /addresses/customer/{CustomerId}/{AddressId} | Retrieve an address of a customer using its Id - {GetCustomerAddressRequest}
[**RemoveAddressRequestAddressIdDelete**](AddressesApi.md#removeaddressrequestaddressiddelete) | **DELETE** /addresses/{AddressId} | Remove an address - {RemoveAddressRequest}
[**RemoveCustomerAddressRequestcustomerCustomerIdAddressIdDelete**](AddressesApi.md#removecustomeraddressrequestcustomercustomeridaddressiddelete) | **DELETE** /addresses/customer/{CustomerId}/{AddressId} | Remove an address of a customer - {RemoveCustomerAddressRequest}
[**UpdateAddressRequestAddressIdCreate**](AddressesApi.md#updateaddressrequestaddressidcreate) | **PUT** /addresses/{AddressId} | Updates an address - {UpdateAddressRequest}
[**UpdateCustomerAddressRequestcustomerCustomerIdAddressIdCreate**](AddressesApi.md#updatecustomeraddressrequestcustomercustomeridaddressidcreate) | **PUT** /addresses/customer/{CustomerId}/{AddressId} | Updates a customer address - {UpdateCustomerAddressRequest}


<a name="getaddressrequestaddressidget"></a>
# **GetAddressRequestAddressIdGet**
> Address GetAddressRequestAddressIdGet (string accept, string addressId)

Retrieve an address using its Id - {GetAddressRequest}

Retrieve an address using its Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAddressRequestAddressIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AddressesApi(config);
            var accept = accept_example;  // string | Accept Header
            var addressId = addressId_example;  // string | The unique identifier of the address.

            try
            {
                // Retrieve an address using its Id - {GetAddressRequest}
                Address result = apiInstance.GetAddressRequestAddressIdGet(accept, addressId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.GetAddressRequestAddressIdGet: " + e.Message );
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
 **addressId** | **string**| The unique identifier of the address. | 

### Return type

[**Address**](Address.md)

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

<a name="getaddressesbyidsrequestbyidsidsget"></a>
# **GetAddressesByIdsRequestbyIdsIdsGet**
> List&lt;Address&gt; GetAddressesByIdsRequestbyIdsIdsGet (string accept, List<string> ids)

Retrieve a list of addresses by Ids - {GetAddressesByIdsRequest}

Retrieve a list of addresses by Ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAddressesByIdsRequestbyIdsIdsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AddressesApi(config);
            var accept = accept_example;  // string | Accept Header
            var ids = new List<string>(); // List<string> | The list of system-wide unique identifier for the Addresses to retrieve.

            try
            {
                // Retrieve a list of addresses by Ids - {GetAddressesByIdsRequest}
                List<Address> result = apiInstance.GetAddressesByIdsRequestbyIdsIdsGet(accept, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.GetAddressesByIdsRequestbyIdsIdsGet: " + e.Message );
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
 **ids** | [**List&lt;string&gt;**](string.md)| The list of system-wide unique identifier for the Addresses to retrieve. | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomeraddressrequestcustomercustomeridaddressidget"></a>
# **GetCustomerAddressRequestcustomerCustomerIdAddressIdGet**
> Address GetCustomerAddressRequestcustomerCustomerIdAddressIdGet (string accept, string customerId, string addressId)

Retrieve an address of a customer using its Id - {GetCustomerAddressRequest}

Retrieve an address of a customer using its Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerAddressRequestcustomerCustomerIdAddressIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AddressesApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer identifier.
            var addressId = addressId_example;  // string | The unique identifier of the address.

            try
            {
                // Retrieve an address of a customer using its Id - {GetCustomerAddressRequest}
                Address result = apiInstance.GetCustomerAddressRequestcustomerCustomerIdAddressIdGet(accept, customerId, addressId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.GetCustomerAddressRequestcustomerCustomerIdAddressIdGet: " + e.Message );
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
 **addressId** | **string**| The unique identifier of the address. | 

### Return type

[**Address**](Address.md)

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

<a name="removeaddressrequestaddressiddelete"></a>
# **RemoveAddressRequestAddressIdDelete**
> void RemoveAddressRequestAddressIdDelete (string accept, string addressId)

Remove an address - {RemoveAddressRequest}

Remove an address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveAddressRequestAddressIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AddressesApi(config);
            var accept = accept_example;  // string | Accept Header
            var addressId = addressId_example;  // string | The unique identifier of the address.

            try
            {
                // Remove an address - {RemoveAddressRequest}
                apiInstance.RemoveAddressRequestAddressIdDelete(accept, addressId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.RemoveAddressRequestAddressIdDelete: " + e.Message );
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
 **addressId** | **string**| The unique identifier of the address. | 

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

<a name="removecustomeraddressrequestcustomercustomeridaddressiddelete"></a>
# **RemoveCustomerAddressRequestcustomerCustomerIdAddressIdDelete**
> void RemoveCustomerAddressRequestcustomerCustomerIdAddressIdDelete (string accept, string customerId, string addressId)

Remove an address of a customer - {RemoveCustomerAddressRequest}

Remove an address of a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveCustomerAddressRequestcustomerCustomerIdAddressIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AddressesApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer identifier.
            var addressId = addressId_example;  // string | The unique identifier of the address.

            try
            {
                // Remove an address of a customer - {RemoveCustomerAddressRequest}
                apiInstance.RemoveCustomerAddressRequestcustomerCustomerIdAddressIdDelete(accept, customerId, addressId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.RemoveCustomerAddressRequestcustomerCustomerIdAddressIdDelete: " + e.Message );
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
 **addressId** | **string**| The unique identifier of the address. | 

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

<a name="updateaddressrequestaddressidcreate"></a>
# **UpdateAddressRequestAddressIdCreate**
> Address UpdateAddressRequestAddressIdCreate (string accept, string addressId, UpdateAddressRequest body = null)

Updates an address - {UpdateAddressRequest}

Updates an address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateAddressRequestAddressIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AddressesApi(config);
            var accept = accept_example;  // string | Accept Header
            var addressId = addressId_example;  // string | Unique identifier
            var body = new UpdateAddressRequest(); // UpdateAddressRequest |  (optional) 

            try
            {
                // Updates an address - {UpdateAddressRequest}
                Address result = apiInstance.UpdateAddressRequestAddressIdCreate(accept, addressId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.UpdateAddressRequestAddressIdCreate: " + e.Message );
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
 **addressId** | **string**| Unique identifier | 
 **body** | [**UpdateAddressRequest**](UpdateAddressRequest.md)|  | [optional] 

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

<a name="updatecustomeraddressrequestcustomercustomeridaddressidcreate"></a>
# **UpdateCustomerAddressRequestcustomerCustomerIdAddressIdCreate**
> Address UpdateCustomerAddressRequestcustomerCustomerIdAddressIdCreate (string accept, string customerId, string addressId, UpdateCustomerAddressRequest body = null)

Updates a customer address - {UpdateCustomerAddressRequest}

Updates a customer address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCustomerAddressRequestcustomerCustomerIdAddressIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AddressesApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer identifier.
            var addressId = addressId_example;  // string | Unique identifier
            var body = new UpdateCustomerAddressRequest(); // UpdateCustomerAddressRequest |  (optional) 

            try
            {
                // Updates a customer address - {UpdateCustomerAddressRequest}
                Address result = apiInstance.UpdateCustomerAddressRequestcustomerCustomerIdAddressIdCreate(accept, customerId, addressId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.UpdateCustomerAddressRequestcustomerCustomerIdAddressIdCreate: " + e.Message );
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
 **body** | [**UpdateCustomerAddressRequest**](UpdateCustomerAddressRequest.md)|  | [optional] 

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

