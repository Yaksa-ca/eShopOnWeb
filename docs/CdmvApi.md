# Yaksa.OrckestraCommerce.Client.Api.CdmvApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMonerisPaymentMethodRequestmonerisCanadaVaultProfileScopeIdCustomerIdaddpaymentmethodPost**](CdmvApi.md#addmonerispaymentmethodrequestmoneriscanadavaultprofilescopeidcustomeridaddpaymentmethodpost) | **POST** /cdmv/monerisCanadaVaultProfile/{ScopeId}/{CustomerId}/addpaymentmethod | Adds a new payment method for a customer - {AddMonerisPaymentMethodRequest}
[**AddOrUpdateProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernamePost**](CdmvApi.md#addorupdateproductauthorizationsbyusernamerequestproductauthorizationsscopeidbyusernamepost) | **POST** /cdmv/productauthorizations/{ScopeId}/byUsername | Add a new product authorizations or update if it already exists. - {AddOrUpdateProductAuthorizationsByUsernameRequest}
[**AddOrUpdateProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdPost**](CdmvApi.md#addorupdateproductauthorizationsrequestproductauthorizationsscopeidcustomeridpost) | **POST** /cdmv/productauthorizations/{ScopeId}/{CustomerId} | Add a new product authorizations or update if it already exists. - {AddOrUpdateProductAuthorizationsRequest}
[**CDMVCreateCustomerRequestcustomerScopeIdPost**](CdmvApi.md#cdmvcreatecustomerrequestcustomerscopeidpost) | **POST** /cdmv/customer/{ScopeId} | Creates a customer - {CDMVCreateCustomerRequest}
[**CDMVSelfServiceAccountCreationRequestcustomerScopeIdselfServiceAccountCreationRequestPost**](CdmvApi.md#cdmvselfserviceaccountcreationrequestcustomerscopeidselfserviceaccountcreationrequestpost) | **POST** /cdmv/customer/{ScopeId}/self-service-account-creation-request | Sends an email to a customer to continue its account creation for a clinic - {CDMVSelfServiceAccountCreationRequest}
[**CDMVSelfServiceAccountCreationValidationRequestcustomerselfServiceAccountCreationRequestValidatePost**](CdmvApi.md#cdmvselfserviceaccountcreationvalidationrequestcustomerselfserviceaccountcreationrequestvalidatepost) | **POST** /cdmv/customer/self-service-account-creation-request/Validate | Validate an encrypted Token and return info - {CDMVSelfServiceAccountCreationValidationRequest}
[**ClinicProductInformationImportRequestdataexchangeproductsClinicCodeimportPost**](CdmvApi.md#clinicproductinformationimportrequestdataexchangeproductscliniccodeimportpost) | **POST** /cdmv/dataexchange/products/{ClinicCode}/import | Import Metadatas, Products, Prices, Categories and RelationShips using a clinic code - {ClinicProductInformationImportRequest}
[**ConfirmShipmentRequestordersconfirmshipmentPost**](CdmvApi.md#confirmshipmentrequestordersconfirmshipmentpost) | **POST** /cdmv/orders/confirmshipment | Confirm that shipments have been shipped, either fully or partially - {ConfirmShipmentRequest}
[**DeactivateProductRequestproductsScopeIdProductIddeactivateCreate**](CdmvApi.md#deactivateproductrequestproductsscopeidproductiddeactivatecreate) | **PUT** /cdmv/products/{ScopeId}/{ProductId}/deactivate | Dectivate a product in the provided dependant scope - {DeactivateProductRequest}
[**DeletePaymentMethodRequestcustomerScopeIdwalletDelete**](CdmvApi.md#deletepaymentmethodrequestcustomerscopeidwalletdelete) | **DELETE** /cdmv/customer/{ScopeId}/wallet | Deletes a payment method from the customer wallet - {DeletePaymentMethodRequest}
[**DeleteProductAuthorizationRequestproductauthorizationScopeIdIdDelete**](CdmvApi.md#deleteproductauthorizationrequestproductauthorizationscopeididdelete) | **DELETE** /cdmv/productauthorization/{ScopeId}/{Id} | Delete an existing product authorization based on its Id - {DeleteProductAuthorizationRequest}
[**DocumentsRequestsolrAuthenticationTokenPost**](CdmvApi.md#documentsrequestsolrauthenticationtokenpost) | **POST** /cdmv/solr/{AuthenticationToken} | Receives solr index documents to allow for custom index fields - {DocumentsRequest}
[**FindProductAuthorizationsByStatusRequestproductauthorizationsScopeIdfindbyStatusPost**](CdmvApi.md#findproductauthorizationsbystatusrequestproductauthorizationsscopeidfindbystatuspost) | **POST** /cdmv/productauthorizations/{ScopeId}/find/byStatus | Retrieves all product authorizations by status for a given scope - {FindProductAuthorizationsByStatusRequest}
[**FindStoresRequeststoresScopeIdfindPost**](CdmvApi.md#findstoresrequeststoresscopeidfindpost) | **POST** /cdmv/stores/{ScopeId}/find | Search for Stores based on search terms - {FindStoresRequest}
[**GetB2CSiteProfileRequestb2csiteprofileScopeIdCustomerIdGet**](CdmvApi.md#getb2csiteprofilerequestb2csiteprofilescopeidcustomeridget) | **GET** /cdmv/b2csiteprofile/{ScopeId}/{CustomerId} | Get the B2C site profile of a customer. - {GetB2CSiteProfileRequest}
[**GetClinicInfoForCustomerByUsernameRequestcustomerbyUsernameclinicGet**](CdmvApi.md#getclinicinfoforcustomerbyusernamerequestcustomerbyusernameclinicget) | **GET** /cdmv/customer/byUsername/clinic | Returns information about the clinic a customer is associated to,using the customer&#39;s username to identify him. - {GetClinicInfoForCustomerByUsernameRequest}
[**GetClinicInfoForCustomerRequestcustomerCustomerIdclinicGet**](CdmvApi.md#getclinicinfoforcustomerrequestcustomercustomeridclinicget) | **GET** /cdmv/customer/{CustomerId}/clinic | Returns information about the clinic a customer is associated to. - {GetClinicInfoForCustomerRequest}
[**GetClinicInfoRequestclinicClinicIdGet**](CdmvApi.md#getclinicinforequestclinicclinicidget) | **GET** /cdmv/clinic/{ClinicId} | Retrieves a clinic&#39;s information using its id - {GetClinicInfoRequest}
[**GetCustomerWalletRequestcustomerScopeIdwalletGet**](CdmvApi.md#getcustomerwalletrequestcustomerscopeidwalletget) | **GET** /cdmv/customer/{ScopeId}/wallet | Gets a customer wallet - {GetCustomerWalletRequest}
[**GetCustomersKpiRequestcustomerskpiScopeIdGet**](CdmvApi.md#getcustomerskpirequestcustomerskpiscopeidget) | **GET** /cdmv/customerskpi/{ScopeId} | Get the list of Customer KPI. - {GetCustomersKpiRequest}
[**GetFeatureFlagsRequestfeatureflagsScopeIdGet**](CdmvApi.md#getfeatureflagsrequestfeatureflagsscopeidget) | **GET** /cdmv/featureflags/{ScopeId} | Retrieves all feature flags that applies to a given scope applying scope inheritance. - {GetFeatureFlagsRequest}
[**GetMonerisCaptureSettingsRequestpaymentScopeIdmonerisPaymentProviderNamecaptureSettingsGet**](CdmvApi.md#getmoneriscapturesettingsrequestpaymentscopeidmonerispaymentprovidernamecapturesettingsget) | **GET** /cdmv/payment/{ScopeId}/moneris/{PaymentProviderName}/captureSettings | Gets the payment capture settings for Moneris - {GetMonerisCaptureSettingsRequest}
[**GetPendingApprovalAccountsRequestb2csiteprofileScopeIdpendingaccountsGet**](CdmvApi.md#getpendingapprovalaccountsrequestb2csiteprofilescopeidpendingaccountsget) | **GET** /cdmv/b2csiteprofile/{ScopeId}/pendingaccounts | Get the list of all B2C accounts waiting for approval. - {GetPendingApprovalAccountsRequest}
[**GetProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameGet**](CdmvApi.md#getproductauthorizationsbyusernamerequestproductauthorizationsscopeidbyusernameget) | **GET** /cdmv/productauthorizations/{ScopeId}/byUsername | Retrieves all product authorizations associated to a customer, identified by its username - {GetProductAuthorizationsByUsernameRequest}
[**GetProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdGet**](CdmvApi.md#getproductauthorizationsrequestproductauthorizationsscopeidcustomeridget) | **GET** /cdmv/productauthorizations/{ScopeId}/{CustomerId} | Retrieves all product authorizations associated to a customer - {GetProductAuthorizationsRequest}
[**InactiveProductsReportRequestreportsproductsScopeIdCultureNamedeactivatedGet**](CdmvApi.md#inactiveproductsreportrequestreportsproductsscopeidculturenamedeactivatedget) | **GET** /cdmv/reports/products/{ScopeId}/{CultureName}/deactivated | Return CSV report for inactive products of each scope - {InactiveProductsReportRequest}
[**InviteNewCustomerRequestcustomerScopeIdinvitePost**](CdmvApi.md#invitenewcustomerrequestcustomerscopeidinvitepost) | **POST** /cdmv/customer/{ScopeId}/invite | Sends an email invitation to a new customer to create an account for a clinic - {InviteNewCustomerRequest}
[**InviteNewOrganizationalCustomerRequestcustomerScopeIdOrganizationIdinvitePost**](CdmvApi.md#inviteneworganizationalcustomerrequestcustomerscopeidorganizationidinvitepost) | **POST** /cdmv/customer/{ScopeId}/{OrganizationId}/invite | Sends an email invitation to a new customer to create an account associated with and organization - {InviteNewOrganizationalCustomerRequest}
[**InvoiceOrderToCDMVRequestordersinvoiceToCDMVPost**](CdmvApi.md#invoiceordertocdmvrequestordersinvoicetocdmvpost) | **POST** /cdmv/orders/invoiceToCDMV | Sends to CDMV the invoice for a given order - {InvoiceOrderToCDMVRequest}
[**RemoveActivationOverrideRequestproductsScopeIdProductIdremoveActivationOverrideDelete**](CdmvApi.md#removeactivationoverriderequestproductsscopeidproductidremoveactivationoverridedelete) | **DELETE** /cdmv/products/{ScopeId}/{ProductId}/removeActivationOverride | Removed activation overrride in the provided dependant scope - {RemoveActivationOverrideRequest}
[**RemoveProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameDelete**](CdmvApi.md#removeproductauthorizationsbyusernamerequestproductauthorizationsscopeidbyusernamedelete) | **DELETE** /cdmv/productauthorizations/{ScopeId}/byUsername | Remove product authorizations - {RemoveProductAuthorizationsByUsernameRequest}
[**RemoveProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdDelete**](CdmvApi.md#removeproductauthorizationsrequestproductauthorizationsscopeidcustomeriddelete) | **DELETE** /cdmv/productauthorizations/{ScopeId}/{CustomerId} | Remove product authorizations - {RemoveProductAuthorizationsRequest}
[**UpdatePendingApprovalAccountRequestb2csiteprofileScopeIdpendingaccountsIdCreate**](CdmvApi.md#updatependingapprovalaccountrequestb2csiteprofilescopeidpendingaccountsidcreate) | **PUT** /cdmv/b2csiteprofile/{ScopeId}/pendingaccounts/{Id} | Update a B2C site profile to complete the customer account approval. - {UpdatePendingApprovalAccountRequest}
[**UpdateProductAuthorizationRequestproductauthorizationScopeIdIdCreate**](CdmvApi.md#updateproductauthorizationrequestproductauthorizationscopeididcreate) | **PUT** /cdmv/productauthorization/{ScopeId}/{Id} | Update an existing product authorization based on its Id - {UpdateProductAuthorizationRequest}
[**UpdateShipmentTrackingRequestordersupdateShipmentTrackingPost**](CdmvApi.md#updateshipmenttrackingrequestordersupdateshipmenttrackingpost) | **POST** /cdmv/orders/updateShipmentTracking | Confirm shipments tracking information about an order when it is shipped or about to ship after CDMV shipment manifest - {UpdateShipmentTrackingRequest}
[**UpdateWalletCreditCardRequestcustomerScopeIdwalletPaymentMethodIdCreate**](CdmvApi.md#updatewalletcreditcardrequestcustomerscopeidwalletpaymentmethodidcreate) | **PUT** /cdmv/customer/{ScopeId}/wallet/{PaymentMethodId} | Updates a credit card in the customer wallet - {UpdateWalletCreditCardRequest}
[**UpdateWalletDefaultCreditCardRequestcustomerScopeIdwalletdefaultPaymentMethodIdCreate**](CdmvApi.md#updatewalletdefaultcreditcardrequestcustomerscopeidwalletdefaultpaymentmethodidcreate) | **PUT** /cdmv/customer/{ScopeId}/wallet/default/{PaymentMethodId} | Updates the default credit card in the customer wallet - {UpdateWalletDefaultCreditCardRequest}


<a name="addmonerispaymentmethodrequestmoneriscanadavaultprofilescopeidcustomeridaddpaymentmethodpost"></a>
# **AddMonerisPaymentMethodRequestmonerisCanadaVaultProfileScopeIdCustomerIdaddpaymentmethodPost**
> AddMonerisPaymentMethodResponse AddMonerisPaymentMethodRequestmonerisCanadaVaultProfileScopeIdCustomerIdaddpaymentmethodPost (string accept, string scopeId, string customerId, AddMonerisPaymentMethodRequest body = null)

Adds a new payment method for a customer - {AddMonerisPaymentMethodRequest}

Adds a new payment method for a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddMonerisPaymentMethodRequestmonerisCanadaVaultProfileScopeIdCustomerIdaddpaymentmethodPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | Customer Id
            var body = new AddMonerisPaymentMethodRequest(); // AddMonerisPaymentMethodRequest |  (optional) 

            try
            {
                // Adds a new payment method for a customer - {AddMonerisPaymentMethodRequest}
                AddMonerisPaymentMethodResponse result = apiInstance.AddMonerisPaymentMethodRequestmonerisCanadaVaultProfileScopeIdCustomerIdaddpaymentmethodPost(accept, scopeId, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.AddMonerisPaymentMethodRequestmonerisCanadaVaultProfileScopeIdCustomerIdaddpaymentmethodPost: " + e.Message );
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
 **customerId** | **string**| Customer Id | 
 **body** | [**AddMonerisPaymentMethodRequest**](AddMonerisPaymentMethodRequest.md)|  | [optional] 

### Return type

[**AddMonerisPaymentMethodResponse**](AddMonerisPaymentMethodResponse.md)

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

<a name="addorupdateproductauthorizationsbyusernamerequestproductauthorizationsscopeidbyusernamepost"></a>
# **AddOrUpdateProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernamePost**
> AddOrUpdateProductAuthorizationsResponse AddOrUpdateProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernamePost (string accept, string scopeId, AddOrUpdateProductAuthorizationsByUsernameRequest body = null)

Add a new product authorizations or update if it already exists. - {AddOrUpdateProductAuthorizationsByUsernameRequest}

Add new or update product authorizations. For new authorizations, if no date is specified, then a default date will be given based on the default expiry configuration. If an authorization already exists, update its expiry date (if there is an expiry date in the request). If an add/update operation fails, no error will surface. The response contains only the what was added or successfully updated. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new AddOrUpdateProductAuthorizationsByUsernameRequest(); // AddOrUpdateProductAuthorizationsByUsernameRequest |  (optional) 

            try
            {
                // Add a new product authorizations or update if it already exists. - {AddOrUpdateProductAuthorizationsByUsernameRequest}
                AddOrUpdateProductAuthorizationsResponse result = apiInstance.AddOrUpdateProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernamePost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.AddOrUpdateProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernamePost: " + e.Message );
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
 **body** | [**AddOrUpdateProductAuthorizationsByUsernameRequest**](AddOrUpdateProductAuthorizationsByUsernameRequest.md)|  | [optional] 

### Return type

[**AddOrUpdateProductAuthorizationsResponse**](AddOrUpdateProductAuthorizationsResponse.md)

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

<a name="addorupdateproductauthorizationsrequestproductauthorizationsscopeidcustomeridpost"></a>
# **AddOrUpdateProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdPost**
> AddOrUpdateProductAuthorizationsResponse AddOrUpdateProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdPost (string accept, string scopeId, string customerId, AddOrUpdateProductAuthorizationsRequest body = null)

Add a new product authorizations or update if it already exists. - {AddOrUpdateProductAuthorizationsRequest}

Add new or update product authorizations. For new authorizations, if no date is specified, then a default date will be given based on the default expiry configuration. If an authorization already exists, update its expiry date (if there is an expiry date in the request). If an add/update operation fails, no error will surface. The response contains only the what was added or successfully updated. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer's unique identifier
            var body = new AddOrUpdateProductAuthorizationsRequest(); // AddOrUpdateProductAuthorizationsRequest |  (optional) 

            try
            {
                // Add a new product authorizations or update if it already exists. - {AddOrUpdateProductAuthorizationsRequest}
                AddOrUpdateProductAuthorizationsResponse result = apiInstance.AddOrUpdateProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdPost(accept, scopeId, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.AddOrUpdateProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdPost: " + e.Message );
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
 **customerId** | **string**| The customer&#39;s unique identifier | 
 **body** | [**AddOrUpdateProductAuthorizationsRequest**](AddOrUpdateProductAuthorizationsRequest.md)|  | [optional] 

### Return type

[**AddOrUpdateProductAuthorizationsResponse**](AddOrUpdateProductAuthorizationsResponse.md)

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
| **404** | Customer was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cdmvcreatecustomerrequestcustomerscopeidpost"></a>
# **CDMVCreateCustomerRequestcustomerScopeIdPost**
> Customer CDMVCreateCustomerRequestcustomerScopeIdPost (string accept, string scopeId, CDMVCreateCustomerRequest body = null)

Creates a customer - {CDMVCreateCustomerRequest}

Creates a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CDMVCreateCustomerRequestcustomerScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CDMVCreateCustomerRequest(); // CDMVCreateCustomerRequest |  (optional) 

            try
            {
                // Creates a customer - {CDMVCreateCustomerRequest}
                Customer result = apiInstance.CDMVCreateCustomerRequestcustomerScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.CDMVCreateCustomerRequestcustomerScopeIdPost: " + e.Message );
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
 **body** | [**CDMVCreateCustomerRequest**](CDMVCreateCustomerRequest.md)|  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cdmvselfserviceaccountcreationrequestcustomerscopeidselfserviceaccountcreationrequestpost"></a>
# **CDMVSelfServiceAccountCreationRequestcustomerScopeIdselfServiceAccountCreationRequestPost**
> SelfServiceAccountCreatedEvent CDMVSelfServiceAccountCreationRequestcustomerScopeIdselfServiceAccountCreationRequestPost (string accept, string scopeId, CDMVSelfServiceAccountCreationRequest body = null)

Sends an email to a customer to continue its account creation for a clinic - {CDMVSelfServiceAccountCreationRequest}

Sends an email to a customer to continue its account creation for a clinic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CDMVSelfServiceAccountCreationRequestcustomerScopeIdselfServiceAccountCreationRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CDMVSelfServiceAccountCreationRequest(); // CDMVSelfServiceAccountCreationRequest |  (optional) 

            try
            {
                // Sends an email to a customer to continue its account creation for a clinic - {CDMVSelfServiceAccountCreationRequest}
                SelfServiceAccountCreatedEvent result = apiInstance.CDMVSelfServiceAccountCreationRequestcustomerScopeIdselfServiceAccountCreationRequestPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.CDMVSelfServiceAccountCreationRequestcustomerScopeIdselfServiceAccountCreationRequestPost: " + e.Message );
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
 **body** | [**CDMVSelfServiceAccountCreationRequest**](CDMVSelfServiceAccountCreationRequest.md)|  | [optional] 

### Return type

[**SelfServiceAccountCreatedEvent**](SelfServiceAccountCreatedEvent.md)

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

<a name="cdmvselfserviceaccountcreationvalidationrequestcustomerselfserviceaccountcreationrequestvalidatepost"></a>
# **CDMVSelfServiceAccountCreationValidationRequestcustomerselfServiceAccountCreationRequestValidatePost**
> CDMVSelfServiceAccountValidationResponse CDMVSelfServiceAccountCreationValidationRequestcustomerselfServiceAccountCreationRequestValidatePost (string accept, CDMVSelfServiceAccountCreationValidationRequest body = null)

Validate an encrypted Token and return info - {CDMVSelfServiceAccountCreationValidationRequest}

Validate an encrypted Token and return info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CDMVSelfServiceAccountCreationValidationRequestcustomerselfServiceAccountCreationRequestValidatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new CDMVSelfServiceAccountCreationValidationRequest(); // CDMVSelfServiceAccountCreationValidationRequest |  (optional) 

            try
            {
                // Validate an encrypted Token and return info - {CDMVSelfServiceAccountCreationValidationRequest}
                CDMVSelfServiceAccountValidationResponse result = apiInstance.CDMVSelfServiceAccountCreationValidationRequestcustomerselfServiceAccountCreationRequestValidatePost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.CDMVSelfServiceAccountCreationValidationRequestcustomerselfServiceAccountCreationRequestValidatePost: " + e.Message );
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
 **body** | [**CDMVSelfServiceAccountCreationValidationRequest**](CDMVSelfServiceAccountCreationValidationRequest.md)|  | [optional] 

### Return type

[**CDMVSelfServiceAccountValidationResponse**](CDMVSelfServiceAccountValidationResponse.md)

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

<a name="clinicproductinformationimportrequestdataexchangeproductscliniccodeimportpost"></a>
# **ClinicProductInformationImportRequestdataexchangeproductsClinicCodeimportPost**
> TaskInfo ClinicProductInformationImportRequestdataexchangeproductsClinicCodeimportPost (string accept, string clinicCode, ClinicProductInformationImportRequest body = null)

Import Metadatas, Products, Prices, Categories and RelationShips using a clinic code - {ClinicProductInformationImportRequest}

Import Metadatas, Products, Prices, Categories and RelationShips using a clinic code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ClinicProductInformationImportRequestdataexchangeproductsClinicCodeimportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var clinicCode = clinicCode_example;  // string | The code of the clinic this import is for
            var body = new ClinicProductInformationImportRequest(); // ClinicProductInformationImportRequest |  (optional) 

            try
            {
                // Import Metadatas, Products, Prices, Categories and RelationShips using a clinic code - {ClinicProductInformationImportRequest}
                TaskInfo result = apiInstance.ClinicProductInformationImportRequestdataexchangeproductsClinicCodeimportPost(accept, clinicCode, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.ClinicProductInformationImportRequestdataexchangeproductsClinicCodeimportPost: " + e.Message );
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
 **clinicCode** | **string**| The code of the clinic this import is for | 
 **body** | [**ClinicProductInformationImportRequest**](ClinicProductInformationImportRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="confirmshipmentrequestordersconfirmshipmentpost"></a>
# **ConfirmShipmentRequestordersconfirmshipmentPost**
> ConfirmShipmentResponse ConfirmShipmentRequestordersconfirmshipmentPost (string accept, ConfirmShipmentRequest body = null)

Confirm that shipments have been shipped, either fully or partially - {ConfirmShipmentRequest}

Confirm that shipments have been shipped, either fully or partially. Split shipments are not allowed - so any line items that are not included in this request or any partial quantities will be considered as unshipped and will be cancelled. If no line items are provided, then the entire shipment is cancelled

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ConfirmShipmentRequestordersconfirmshipmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new ConfirmShipmentRequest(); // ConfirmShipmentRequest |  (optional) 

            try
            {
                // Confirm that shipments have been shipped, either fully or partially - {ConfirmShipmentRequest}
                ConfirmShipmentResponse result = apiInstance.ConfirmShipmentRequestordersconfirmshipmentPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.ConfirmShipmentRequestordersconfirmshipmentPost: " + e.Message );
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
 **body** | [**ConfirmShipmentRequest**](ConfirmShipmentRequest.md)|  | [optional] 

### Return type

[**ConfirmShipmentResponse**](ConfirmShipmentResponse.md)

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

<a name="deactivateproductrequestproductsscopeidproductiddeactivatecreate"></a>
# **DeactivateProductRequestproductsScopeIdProductIddeactivateCreate**
> Product DeactivateProductRequestproductsScopeIdProductIddeactivateCreate (string accept, string scopeId, string productId, Object body = null)

Dectivate a product in the provided dependant scope - {DeactivateProductRequest}

Deactivate a product in the provided dependant scope. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeactivateProductRequestproductsScopeIdProductIddeactivateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The unique product Id
            var body = ;  // Object |  (optional) 

            try
            {
                // Dectivate a product in the provided dependant scope - {DeactivateProductRequest}
                Product result = apiInstance.DeactivateProductRequestproductsScopeIdProductIddeactivateCreate(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.DeactivateProductRequestproductsScopeIdProductIddeactivateCreate: " + e.Message );
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
 **productId** | **string**| The unique product Id | 
 **body** | **Object**|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | This operation is not allowed.See logs for additional details. |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaymentmethodrequestcustomerscopeidwalletdelete"></a>
# **DeletePaymentMethodRequestcustomerScopeIdwalletDelete**
> DeletePaymentMethodResponse DeletePaymentMethodRequestcustomerScopeIdwalletDelete (string accept, string scopeId, string customerId = null, string paymentMethodId = null, string paymentProviderName = null)

Deletes a payment method from the customer wallet - {DeletePaymentMethodRequest}

Deletes a payment method from the customer wallet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeletePaymentMethodRequestcustomerScopeIdwalletDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | Customer Id (optional) 
            var paymentMethodId = paymentMethodId_example;  // string | Payment method Id (optional) 
            var paymentProviderName = paymentProviderName_example;  // string | Payment provider name (optional) 

            try
            {
                // Deletes a payment method from the customer wallet - {DeletePaymentMethodRequest}
                DeletePaymentMethodResponse result = apiInstance.DeletePaymentMethodRequestcustomerScopeIdwalletDelete(accept, scopeId, customerId, paymentMethodId, paymentProviderName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.DeletePaymentMethodRequestcustomerScopeIdwalletDelete: " + e.Message );
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
 **customerId** | **string**| Customer Id | [optional] 
 **paymentMethodId** | **string**| Payment method Id | [optional] 
 **paymentProviderName** | **string**| Payment provider name | [optional] 

### Return type

[**DeletePaymentMethodResponse**](DeletePaymentMethodResponse.md)

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

<a name="deleteproductauthorizationrequestproductauthorizationscopeididdelete"></a>
# **DeleteProductAuthorizationRequestproductauthorizationScopeIdIdDelete**
> DeleteProductAuthorizationResponse DeleteProductAuthorizationRequestproductauthorizationScopeIdIdDelete (string accept, string scopeId, string id)

Delete an existing product authorization based on its Id - {DeleteProductAuthorizationRequest}

Delete an existing product authorization based on its Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductAuthorizationRequestproductauthorizationScopeIdIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the product authorization to delete (currently, this is the custom profile id of the product authorization)

            try
            {
                // Delete an existing product authorization based on its Id - {DeleteProductAuthorizationRequest}
                DeleteProductAuthorizationResponse result = apiInstance.DeleteProductAuthorizationRequestproductauthorizationScopeIdIdDelete(accept, scopeId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.DeleteProductAuthorizationRequestproductauthorizationScopeIdIdDelete: " + e.Message );
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
 **id** | **string**| The id of the product authorization to delete (currently, this is the custom profile id of the product authorization) | 

### Return type

[**DeleteProductAuthorizationResponse**](DeleteProductAuthorizationResponse.md)

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
| **404** | If the product authorization was not found using the provided id |  -  |
| **500** | If the delete failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsrequestsolrauthenticationtokenpost"></a>
# **DocumentsRequestsolrAuthenticationTokenPost**
> HttpResult DocumentsRequestsolrAuthenticationTokenPost (string accept, string authenticationToken, DocumentsRequest body = null)

Receives solr index documents to allow for custom index fields - {DocumentsRequest}

Receives solr index documents to allow for custom index fields

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DocumentsRequestsolrAuthenticationTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var authenticationToken = authenticationToken_example;  // string | The secret authentication token
            var body = new DocumentsRequest(); // DocumentsRequest |  (optional) 

            try
            {
                // Receives solr index documents to allow for custom index fields - {DocumentsRequest}
                HttpResult result = apiInstance.DocumentsRequestsolrAuthenticationTokenPost(accept, authenticationToken, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.DocumentsRequestsolrAuthenticationTokenPost: " + e.Message );
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
 **authenticationToken** | **string**| The secret authentication token | 
 **body** | [**DocumentsRequest**](DocumentsRequest.md)|  | [optional] 

### Return type

[**HttpResult**](HttpResult.md)

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

<a name="findproductauthorizationsbystatusrequestproductauthorizationsscopeidfindbystatuspost"></a>
# **FindProductAuthorizationsByStatusRequestproductauthorizationsScopeIdfindbyStatusPost**
> FindProductAuthorizationsByStatusResponse FindProductAuthorizationsByStatusRequestproductauthorizationsScopeIdfindbyStatusPost (string accept, string scopeId, FindProductAuthorizationsByStatusRequest body = null)

Retrieves all product authorizations by status for a given scope - {FindProductAuthorizationsByStatusRequest}

Retrieves all product authorizations by status for a given scope. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindProductAuthorizationsByStatusRequestproductauthorizationsScopeIdfindbyStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindProductAuthorizationsByStatusRequest(); // FindProductAuthorizationsByStatusRequest |  (optional) 

            try
            {
                // Retrieves all product authorizations by status for a given scope - {FindProductAuthorizationsByStatusRequest}
                FindProductAuthorizationsByStatusResponse result = apiInstance.FindProductAuthorizationsByStatusRequestproductauthorizationsScopeIdfindbyStatusPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.FindProductAuthorizationsByStatusRequestproductauthorizationsScopeIdfindbyStatusPost: " + e.Message );
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
 **body** | [**FindProductAuthorizationsByStatusRequest**](FindProductAuthorizationsByStatusRequest.md)|  | [optional] 

### Return type

[**FindProductAuthorizationsByStatusResponse**](FindProductAuthorizationsByStatusResponse.md)

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

<a name="findstoresrequeststoresscopeidfindpost"></a>
# **FindStoresRequeststoresScopeIdfindPost**
> FindStoresQueryResult FindStoresRequeststoresScopeIdfindPost (string accept, string scopeId, FindStoresRequest body = null)

Search for Stores based on search terms - {FindStoresRequest}

This request is identical to the out of the box feature from OCC but will fetch the store display name as part of it's default behavior to work around an OCC missing limitation.Its signature is the same to minimize re-work should the OCC platform implement it in the future. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindStoresRequeststoresScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindStoresRequest(); // FindStoresRequest |  (optional) 

            try
            {
                // Search for Stores based on search terms - {FindStoresRequest}
                FindStoresQueryResult result = apiInstance.FindStoresRequeststoresScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.FindStoresRequeststoresScopeIdfindPost: " + e.Message );
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

<a name="getb2csiteprofilerequestb2csiteprofilescopeidcustomeridget"></a>
# **GetB2CSiteProfileRequestb2csiteprofileScopeIdCustomerIdGet**
> GetB2CSiteProfileResponse GetB2CSiteProfileRequestb2csiteprofileScopeIdCustomerIdGet (string accept, string scopeId, string customerId)

Get the B2C site profile of a customer. - {GetB2CSiteProfileRequest}

Get the B2C site profile of a customer. For new customers, a profile always exists, if a customer doesn't have a profile, it is assumed it has been invited by a clinic admin. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetB2CSiteProfileRequestb2csiteprofileScopeIdCustomerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer's unique identifier

            try
            {
                // Get the B2C site profile of a customer. - {GetB2CSiteProfileRequest}
                GetB2CSiteProfileResponse result = apiInstance.GetB2CSiteProfileRequestb2csiteprofileScopeIdCustomerIdGet(accept, scopeId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetB2CSiteProfileRequestb2csiteprofileScopeIdCustomerIdGet: " + e.Message );
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
 **customerId** | **string**| The customer&#39;s unique identifier | 

### Return type

[**GetB2CSiteProfileResponse**](GetB2CSiteProfileResponse.md)

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
| **404** | Customer or B2C site profile was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclinicinfoforcustomerbyusernamerequestcustomerbyusernameclinicget"></a>
# **GetClinicInfoForCustomerByUsernameRequestcustomerbyUsernameclinicGet**
> GetClinicInfoForCustomerResponse GetClinicInfoForCustomerByUsernameRequestcustomerbyUsernameclinicGet (string accept, string username = null)

Returns information about the clinic a customer is associated to,using the customer's username to identify him. - {GetClinicInfoForCustomerByUsernameRequest}

Returns information about the clinic a customer is associated to 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetClinicInfoForCustomerByUsernameRequestcustomerbyUsernameclinicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var username = username_example;  // string | The customer's username. (optional) 

            try
            {
                // Returns information about the clinic a customer is associated to,using the customer's username to identify him. - {GetClinicInfoForCustomerByUsernameRequest}
                GetClinicInfoForCustomerResponse result = apiInstance.GetClinicInfoForCustomerByUsernameRequestcustomerbyUsernameclinicGet(accept, username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetClinicInfoForCustomerByUsernameRequestcustomerbyUsernameclinicGet: " + e.Message );
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
 **username** | **string**| The customer&#39;s username. | [optional] 

### Return type

[**GetClinicInfoForCustomerResponse**](GetClinicInfoForCustomerResponse.md)

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
| **404** | Customer was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclinicinfoforcustomerrequestcustomercustomeridclinicget"></a>
# **GetClinicInfoForCustomerRequestcustomerCustomerIdclinicGet**
> GetClinicInfoForCustomerResponse GetClinicInfoForCustomerRequestcustomerCustomerIdclinicGet (string accept, string customerId)

Returns information about the clinic a customer is associated to. - {GetClinicInfoForCustomerRequest}

Returns information about the clinic a customer is associated to

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetClinicInfoForCustomerRequestcustomerCustomerIdclinicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var customerId = customerId_example;  // string | The customer's unique identifier

            try
            {
                // Returns information about the clinic a customer is associated to. - {GetClinicInfoForCustomerRequest}
                GetClinicInfoForCustomerResponse result = apiInstance.GetClinicInfoForCustomerRequestcustomerCustomerIdclinicGet(accept, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetClinicInfoForCustomerRequestcustomerCustomerIdclinicGet: " + e.Message );
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
 **customerId** | **string**| The customer&#39;s unique identifier | 

### Return type

[**GetClinicInfoForCustomerResponse**](GetClinicInfoForCustomerResponse.md)

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
| **404** | Customer was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclinicinforequestclinicclinicidget"></a>
# **GetClinicInfoRequestclinicClinicIdGet**
> ClinicInfo GetClinicInfoRequestclinicClinicIdGet (string accept, string clinicId)

Retrieves a clinic's information using its id - {GetClinicInfoRequest}

Retrieves a clinic's information using its id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetClinicInfoRequestclinicClinicIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var clinicId = clinicId_example;  // string | The clinic identifier

            try
            {
                // Retrieves a clinic's information using its id - {GetClinicInfoRequest}
                ClinicInfo result = apiInstance.GetClinicInfoRequestclinicClinicIdGet(accept, clinicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetClinicInfoRequestclinicClinicIdGet: " + e.Message );
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
 **clinicId** | **string**| The clinic identifier | 

### Return type

[**ClinicInfo**](ClinicInfo.md)

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
| **404** | If the clinic is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerwalletrequestcustomerscopeidwalletget"></a>
# **GetCustomerWalletRequestcustomerScopeIdwalletGet**
> GetCustomerWalletResponse GetCustomerWalletRequestcustomerScopeIdwalletGet (string accept, string scopeId, string customerId = null, string paymentProviderName = null)

Gets a customer wallet - {GetCustomerWalletRequest}

Gets a customer wallet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerWalletRequestcustomerScopeIdwalletGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | Customer Id (optional) 
            var paymentProviderName = paymentProviderName_example;  // string | Payment provider name (optional) 

            try
            {
                // Gets a customer wallet - {GetCustomerWalletRequest}
                GetCustomerWalletResponse result = apiInstance.GetCustomerWalletRequestcustomerScopeIdwalletGet(accept, scopeId, customerId, paymentProviderName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetCustomerWalletRequestcustomerScopeIdwalletGet: " + e.Message );
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
 **customerId** | **string**| Customer Id | [optional] 
 **paymentProviderName** | **string**| Payment provider name | [optional] 

### Return type

[**GetCustomerWalletResponse**](GetCustomerWalletResponse.md)

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

<a name="getcustomerskpirequestcustomerskpiscopeidget"></a>
# **GetCustomersKpiRequestcustomerskpiScopeIdGet**
> GetAdminKpiResponse GetCustomersKpiRequestcustomerskpiScopeIdGet (string accept, string scopeId)

Get the list of Customer KPI. - {GetCustomersKpiRequest}

Get the list of Customer KPI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomersKpiRequestcustomerskpiScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Get the list of Customer KPI. - {GetCustomersKpiRequest}
                GetAdminKpiResponse result = apiInstance.GetCustomersKpiRequestcustomerskpiScopeIdGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetCustomersKpiRequestcustomerskpiScopeIdGet: " + e.Message );
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

[**GetAdminKpiResponse**](GetAdminKpiResponse.md)

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

<a name="getfeatureflagsrequestfeatureflagsscopeidget"></a>
# **GetFeatureFlagsRequestfeatureflagsScopeIdGet**
> GetFeatureFlagsResponse GetFeatureFlagsRequestfeatureflagsScopeIdGet (string accept, string scopeId)

Retrieves all feature flags that applies to a given scope applying scope inheritance. - {GetFeatureFlagsRequest}

Retrieves all feature flags that applies to a given scope applying scope inheritance. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFeatureFlagsRequestfeatureflagsScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Retrieves all feature flags that applies to a given scope applying scope inheritance. - {GetFeatureFlagsRequest}
                GetFeatureFlagsResponse result = apiInstance.GetFeatureFlagsRequestfeatureflagsScopeIdGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetFeatureFlagsRequestfeatureflagsScopeIdGet: " + e.Message );
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

[**GetFeatureFlagsResponse**](GetFeatureFlagsResponse.md)

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

<a name="getmoneriscapturesettingsrequestpaymentscopeidmonerispaymentprovidernamecapturesettingsget"></a>
# **GetMonerisCaptureSettingsRequestpaymentScopeIdmonerisPaymentProviderNamecaptureSettingsGet**
> GetMonerisCaptureSettingsResponse GetMonerisCaptureSettingsRequestpaymentScopeIdmonerisPaymentProviderNamecaptureSettingsGet (string accept, string scopeId, string paymentProviderName)

Gets the payment capture settings for Moneris - {GetMonerisCaptureSettingsRequest}

Gets the payment capture settings for Moneris

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMonerisCaptureSettingsRequestpaymentScopeIdmonerisPaymentProviderNamecaptureSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var paymentProviderName = paymentProviderName_example;  // string | Payment provider name

            try
            {
                // Gets the payment capture settings for Moneris - {GetMonerisCaptureSettingsRequest}
                GetMonerisCaptureSettingsResponse result = apiInstance.GetMonerisCaptureSettingsRequestpaymentScopeIdmonerisPaymentProviderNamecaptureSettingsGet(accept, scopeId, paymentProviderName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetMonerisCaptureSettingsRequestpaymentScopeIdmonerisPaymentProviderNamecaptureSettingsGet: " + e.Message );
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
 **paymentProviderName** | **string**| Payment provider name | 

### Return type

[**GetMonerisCaptureSettingsResponse**](GetMonerisCaptureSettingsResponse.md)

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

<a name="getpendingapprovalaccountsrequestb2csiteprofilescopeidpendingaccountsget"></a>
# **GetPendingApprovalAccountsRequestb2csiteprofileScopeIdpendingaccountsGet**
> GetPendingApprovalAccountsResponse GetPendingApprovalAccountsRequestb2csiteprofileScopeIdpendingaccountsGet (string accept, string scopeId, bool? includePendingOrderCount = null, int? resultsPerPage = null, int? startingPage = null)

Get the list of all B2C accounts waiting for approval. - {GetPendingApprovalAccountsRequest}

Get the list of all B2C accounts waiting for approval.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPendingApprovalAccountsRequestb2csiteprofileScopeIdpendingaccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var includePendingOrderCount = true;  // bool? | Whether to include the number of pending orders for each customer (optional) 
            var resultsPerPage = 56;  // int? | The maximum number of results that can be returned at once. Defaults to 50 (optional) 
            var startingPage = 56;  // int? | If the results are returned on multiple pages, this indicates which page of results to return (optional) 

            try
            {
                // Get the list of all B2C accounts waiting for approval. - {GetPendingApprovalAccountsRequest}
                GetPendingApprovalAccountsResponse result = apiInstance.GetPendingApprovalAccountsRequestb2csiteprofileScopeIdpendingaccountsGet(accept, scopeId, includePendingOrderCount, resultsPerPage, startingPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetPendingApprovalAccountsRequestb2csiteprofileScopeIdpendingaccountsGet: " + e.Message );
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
 **includePendingOrderCount** | **bool?**| Whether to include the number of pending orders for each customer | [optional] 
 **resultsPerPage** | **int?**| The maximum number of results that can be returned at once. Defaults to 50 | [optional] 
 **startingPage** | **int?**| If the results are returned on multiple pages, this indicates which page of results to return | [optional] 

### Return type

[**GetPendingApprovalAccountsResponse**](GetPendingApprovalAccountsResponse.md)

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

<a name="getproductauthorizationsbyusernamerequestproductauthorizationsscopeidbyusernameget"></a>
# **GetProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameGet**
> GetProductAuthorizationsResponse GetProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameGet (string accept, string scopeId, string username = null, bool? includeProductDetails = null, bool? includeVariants = null, string cultureName = null)

Retrieves all product authorizations associated to a customer, identified by its username - {GetProductAuthorizationsByUsernameRequest}

Retrieves all product authorizations associated to a customer, identified by its username. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var username = username_example;  // string | Customer's username (optional) 
            var includeProductDetails = true;  // bool? | Whether to include the details of the products (optional) 
            var includeVariants = true;  // bool? | Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered (optional) 
            var cultureName = cultureName_example;  // string | The culture name which dictates in which language localized values are returned in (optional) 

            try
            {
                // Retrieves all product authorizations associated to a customer, identified by its username - {GetProductAuthorizationsByUsernameRequest}
                GetProductAuthorizationsResponse result = apiInstance.GetProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameGet(accept, scopeId, username, includeProductDetails, includeVariants, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameGet: " + e.Message );
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
 **username** | **string**| Customer&#39;s username | [optional] 
 **includeProductDetails** | **bool?**| Whether to include the details of the products | [optional] 
 **includeVariants** | **bool?**| Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered | [optional] 
 **cultureName** | **string**| The culture name which dictates in which language localized values are returned in | [optional] 

### Return type

[**GetProductAuthorizationsResponse**](GetProductAuthorizationsResponse.md)

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

<a name="getproductauthorizationsrequestproductauthorizationsscopeidcustomeridget"></a>
# **GetProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdGet**
> GetProductAuthorizationsResponse GetProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdGet (string accept, string scopeId, string customerId, bool? includeProductDetails = null, bool? includeVariants = null, string cultureName = null, string phoneNumber = null)

Retrieves all product authorizations associated to a customer - {GetProductAuthorizationsRequest}

Retrieves all product authorizations associated to a customer. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer's unique identifier
            var includeProductDetails = true;  // bool? | Whether to include the details of the products (optional) 
            var includeVariants = true;  // bool? | Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered (optional) 
            var cultureName = cultureName_example;  // string | The culture name which dictates in which language localized values are returned in (optional) 
            var phoneNumber = phoneNumber_example;  // string | The customer's phone number (optional) 

            try
            {
                // Retrieves all product authorizations associated to a customer - {GetProductAuthorizationsRequest}
                GetProductAuthorizationsResponse result = apiInstance.GetProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdGet(accept, scopeId, customerId, includeProductDetails, includeVariants, cultureName, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.GetProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdGet: " + e.Message );
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
 **customerId** | **string**| The customer&#39;s unique identifier | 
 **includeProductDetails** | **bool?**| Whether to include the details of the products | [optional] 
 **includeVariants** | **bool?**| Whether to include the variants of the authorized products. IncludeProductDetails must be set to true for this to be considered | [optional] 
 **cultureName** | **string**| The culture name which dictates in which language localized values are returned in | [optional] 
 **phoneNumber** | **string**| The customer&#39;s phone number | [optional] 

### Return type

[**GetProductAuthorizationsResponse**](GetProductAuthorizationsResponse.md)

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
| **404** | Customer was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inactiveproductsreportrequestreportsproductsscopeidculturenamedeactivatedget"></a>
# **InactiveProductsReportRequestreportsproductsScopeIdCultureNamedeactivatedGet**
> Product InactiveProductsReportRequestreportsproductsScopeIdCultureNamedeactivatedGet (string accept, string scopeId, string cultureName)

Return CSV report for inactive products of each scope - {InactiveProductsReportRequest}

Return CSV report for inactive products. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class InactiveProductsReportRequestreportsproductsScopeIdCultureNamedeactivatedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture name which dictates in which language localized values are returned in

            try
            {
                // Return CSV report for inactive products of each scope - {InactiveProductsReportRequest}
                Product result = apiInstance.InactiveProductsReportRequestreportsproductsScopeIdCultureNamedeactivatedGet(accept, scopeId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.InactiveProductsReportRequestreportsproductsScopeIdCultureNamedeactivatedGet: " + e.Message );
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
 **cultureName** | **string**| The culture name which dictates in which language localized values are returned in | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | This operation is not allowed.See logs for additional details. |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitenewcustomerrequestcustomerscopeidinvitepost"></a>
# **InviteNewCustomerRequestcustomerScopeIdinvitePost**
> void InviteNewCustomerRequestcustomerScopeIdinvitePost (string accept, string scopeId, InviteNewCustomerRequest body = null)

Sends an email invitation to a new customer to create an account for a clinic - {InviteNewCustomerRequest}

Sends an email invitation to a new customer to create an account for a clinic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class InviteNewCustomerRequestcustomerScopeIdinvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new InviteNewCustomerRequest(); // InviteNewCustomerRequest |  (optional) 

            try
            {
                // Sends an email invitation to a new customer to create an account for a clinic - {InviteNewCustomerRequest}
                apiInstance.InviteNewCustomerRequestcustomerScopeIdinvitePost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.InviteNewCustomerRequestcustomerScopeIdinvitePost: " + e.Message );
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
 **body** | [**InviteNewCustomerRequest**](InviteNewCustomerRequest.md)|  | [optional] 

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
| **500** | If the invitation could not be sent. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteneworganizationalcustomerrequestcustomerscopeidorganizationidinvitepost"></a>
# **InviteNewOrganizationalCustomerRequestcustomerScopeIdOrganizationIdinvitePost**
> void InviteNewOrganizationalCustomerRequestcustomerScopeIdOrganizationIdinvitePost (string accept, string scopeId, string organizationId, InviteNewOrganizationalCustomerRequest body = null)

Sends an email invitation to a new customer to create an account associated with and organization - {InviteNewOrganizationalCustomerRequest}

Sends an email invitation to a new customer to create an account associated with and organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class InviteNewOrganizationalCustomerRequestcustomerScopeIdOrganizationIdinvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var organizationId = organizationId_example;  // string | The organizations unique identifier.
            var body = new InviteNewOrganizationalCustomerRequest(); // InviteNewOrganizationalCustomerRequest |  (optional) 

            try
            {
                // Sends an email invitation to a new customer to create an account associated with and organization - {InviteNewOrganizationalCustomerRequest}
                apiInstance.InviteNewOrganizationalCustomerRequestcustomerScopeIdOrganizationIdinvitePost(accept, scopeId, organizationId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.InviteNewOrganizationalCustomerRequestcustomerScopeIdOrganizationIdinvitePost: " + e.Message );
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
 **organizationId** | **string**| The organizations unique identifier. | 
 **body** | [**InviteNewOrganizationalCustomerRequest**](InviteNewOrganizationalCustomerRequest.md)|  | [optional] 

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
| **500** | If the invitation could not be sent. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoiceordertocdmvrequestordersinvoicetocdmvpost"></a>
# **InvoiceOrderToCDMVRequestordersinvoiceToCDMVPost**
> InvoiceOrderToCDMVResponse InvoiceOrderToCDMVRequestordersinvoiceToCDMVPost (string accept, InvoiceOrderToCDMVRequest body = null)

Sends to CDMV the invoice for a given order - {InvoiceOrderToCDMVRequest}

Sends to CDMV the invoice for a given order. A note is added on the order to indicate the invoice was requested.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class InvoiceOrderToCDMVRequestordersinvoiceToCDMVPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new InvoiceOrderToCDMVRequest(); // InvoiceOrderToCDMVRequest |  (optional) 

            try
            {
                // Sends to CDMV the invoice for a given order - {InvoiceOrderToCDMVRequest}
                InvoiceOrderToCDMVResponse result = apiInstance.InvoiceOrderToCDMVRequestordersinvoiceToCDMVPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.InvoiceOrderToCDMVRequestordersinvoiceToCDMVPost: " + e.Message );
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
 **body** | [**InvoiceOrderToCDMVRequest**](InvoiceOrderToCDMVRequest.md)|  | [optional] 

### Return type

[**InvoiceOrderToCDMVResponse**](InvoiceOrderToCDMVResponse.md)

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

<a name="removeactivationoverriderequestproductsscopeidproductidremoveactivationoverridedelete"></a>
# **RemoveActivationOverrideRequestproductsScopeIdProductIdremoveActivationOverrideDelete**
> Product RemoveActivationOverrideRequestproductsScopeIdProductIdremoveActivationOverrideDelete (string accept, string scopeId, string productId)

Removed activation overrride in the provided dependant scope - {RemoveActivationOverrideRequest}

Removed activation overrride the provided dependant scope. If the product was disabled this restores the inheritance from the sales scope activation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveActivationOverrideRequestproductsScopeIdProductIdremoveActivationOverrideDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The unique product Id

            try
            {
                // Removed activation overrride in the provided dependant scope - {RemoveActivationOverrideRequest}
                Product result = apiInstance.RemoveActivationOverrideRequestproductsScopeIdProductIdremoveActivationOverrideDelete(accept, scopeId, productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.RemoveActivationOverrideRequestproductsScopeIdProductIdremoveActivationOverrideDelete: " + e.Message );
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
 **productId** | **string**| The unique product Id | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | This operation is not allowed.See logs for additional details. |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeproductauthorizationsbyusernamerequestproductauthorizationsscopeidbyusernamedelete"></a>
# **RemoveProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameDelete**
> RemoveProductAuthorizationsResponse RemoveProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameDelete (string accept, string scopeId, string username = null, List<string> productIds = null)

Remove product authorizations - {RemoveProductAuthorizationsByUsernameRequest}

Remove product authorizations. If a delete operation fails, it will do so silently.The response contains only the product ids that were removed successfully. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var username = username_example;  // string | Customer's username. (optional) 
            var productIds = new List<string>(); // List<string> | List of product ids matching product authorizations to be removed. (optional) 

            try
            {
                // Remove product authorizations - {RemoveProductAuthorizationsByUsernameRequest}
                RemoveProductAuthorizationsResponse result = apiInstance.RemoveProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameDelete(accept, scopeId, username, productIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.RemoveProductAuthorizationsByUsernameRequestproductauthorizationsScopeIdbyUsernameDelete: " + e.Message );
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
 **username** | **string**| Customer&#39;s username. | [optional] 
 **productIds** | [**List&lt;string&gt;**](string.md)| List of product ids matching product authorizations to be removed. | [optional] 

### Return type

[**RemoveProductAuthorizationsResponse**](RemoveProductAuthorizationsResponse.md)

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

<a name="removeproductauthorizationsrequestproductauthorizationsscopeidcustomeriddelete"></a>
# **RemoveProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdDelete**
> RemoveProductAuthorizationsResponse RemoveProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdDelete (string accept, string scopeId, string customerId, List<string> productIds = null)

Remove product authorizations - {RemoveProductAuthorizationsRequest}

Remove product authorizations. If a delete operation fails, it will do so silently.The response contains only the product ids that were removed successfully. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The customer's unique identifier
            var productIds = new List<string>(); // List<string> | List of product ids matching product authorizations to be removed. (optional) 

            try
            {
                // Remove product authorizations - {RemoveProductAuthorizationsRequest}
                RemoveProductAuthorizationsResponse result = apiInstance.RemoveProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdDelete(accept, scopeId, customerId, productIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.RemoveProductAuthorizationsRequestproductauthorizationsScopeIdCustomerIdDelete: " + e.Message );
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
 **customerId** | **string**| The customer&#39;s unique identifier | 
 **productIds** | [**List&lt;string&gt;**](string.md)| List of product ids matching product authorizations to be removed. | [optional] 

### Return type

[**RemoveProductAuthorizationsResponse**](RemoveProductAuthorizationsResponse.md)

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
| **404** | Customer was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatependingapprovalaccountrequestb2csiteprofilescopeidpendingaccountsidcreate"></a>
# **UpdatePendingApprovalAccountRequestb2csiteprofileScopeIdpendingaccountsIdCreate**
> UpdatePendingApprovalAccountResponse UpdatePendingApprovalAccountRequestb2csiteprofileScopeIdpendingaccountsIdCreate (string accept, string scopeId, string id, UpdatePendingApprovalAccountRequest body = null)

Update a B2C site profile to complete the customer account approval. - {UpdatePendingApprovalAccountRequest}

The ID is the guid of the B2C site profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePendingApprovalAccountRequestb2csiteprofileScopeIdpendingaccountsIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The ID of the B2C site profile to update
            var body = new UpdatePendingApprovalAccountRequest(); // UpdatePendingApprovalAccountRequest |  (optional) 

            try
            {
                // Update a B2C site profile to complete the customer account approval. - {UpdatePendingApprovalAccountRequest}
                UpdatePendingApprovalAccountResponse result = apiInstance.UpdatePendingApprovalAccountRequestb2csiteprofileScopeIdpendingaccountsIdCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.UpdatePendingApprovalAccountRequestb2csiteprofileScopeIdpendingaccountsIdCreate: " + e.Message );
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
 **id** | **string**| The ID of the B2C site profile to update | 
 **body** | [**UpdatePendingApprovalAccountRequest**](UpdatePendingApprovalAccountRequest.md)|  | [optional] 

### Return type

[**UpdatePendingApprovalAccountResponse**](UpdatePendingApprovalAccountResponse.md)

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

<a name="updateproductauthorizationrequestproductauthorizationscopeididcreate"></a>
# **UpdateProductAuthorizationRequestproductauthorizationScopeIdIdCreate**
> ProductAuthorization UpdateProductAuthorizationRequestproductauthorizationScopeIdIdCreate (string accept, string scopeId, string id, UpdateProductAuthorizationRequest body = null)

Update an existing product authorization based on its Id - {UpdateProductAuthorizationRequest}

Update an existing product authorization based on its Id, and returns its updated values. All DateTimes are in UTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductAuthorizationRequestproductauthorizationScopeIdIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the product authorization to update (currently, this is the custom profile id of the product authorization)
            var body = new UpdateProductAuthorizationRequest(); // UpdateProductAuthorizationRequest |  (optional) 

            try
            {
                // Update an existing product authorization based on its Id - {UpdateProductAuthorizationRequest}
                ProductAuthorization result = apiInstance.UpdateProductAuthorizationRequestproductauthorizationScopeIdIdCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.UpdateProductAuthorizationRequestproductauthorizationScopeIdIdCreate: " + e.Message );
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
 **id** | **string**| The id of the product authorization to update (currently, this is the custom profile id of the product authorization) | 
 **body** | [**UpdateProductAuthorizationRequest**](UpdateProductAuthorizationRequest.md)|  | [optional] 

### Return type

[**ProductAuthorization**](ProductAuthorization.md)

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
| **404** | If the product authorization was not found using the provided id |  -  |
| **500** | If the update failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshipmenttrackingrequestordersupdateshipmenttrackingpost"></a>
# **UpdateShipmentTrackingRequestordersupdateShipmentTrackingPost**
> UpdateShipmentTrackingResponse UpdateShipmentTrackingRequestordersupdateShipmentTrackingPost (string accept, UpdateShipmentTrackingRequest body = null)

Confirm shipments tracking information about an order when it is shipped or about to ship after CDMV shipment manifest - {UpdateShipmentTrackingRequest}

Confirm shipments tracking information about an order when it is shipped or about to ship after CDMV shipment manifest. This information is update at the Masnifest stage in CDMV Order Express AFTER an initial confirmation via the api /cdmv/orders/confirmshipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateShipmentTrackingRequestordersupdateShipmentTrackingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new UpdateShipmentTrackingRequest(); // UpdateShipmentTrackingRequest |  (optional) 

            try
            {
                // Confirm shipments tracking information about an order when it is shipped or about to ship after CDMV shipment manifest - {UpdateShipmentTrackingRequest}
                UpdateShipmentTrackingResponse result = apiInstance.UpdateShipmentTrackingRequestordersupdateShipmentTrackingPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.UpdateShipmentTrackingRequestordersupdateShipmentTrackingPost: " + e.Message );
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
 **body** | [**UpdateShipmentTrackingRequest**](UpdateShipmentTrackingRequest.md)|  | [optional] 

### Return type

[**UpdateShipmentTrackingResponse**](UpdateShipmentTrackingResponse.md)

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

<a name="updatewalletcreditcardrequestcustomerscopeidwalletpaymentmethodidcreate"></a>
# **UpdateWalletCreditCardRequestcustomerScopeIdwalletPaymentMethodIdCreate**
> UpdateWalletCreditCardResponse UpdateWalletCreditCardRequestcustomerScopeIdwalletPaymentMethodIdCreate (string accept, string scopeId, string paymentMethodId, UpdateWalletCreditCardRequest body = null)

Updates a credit card in the customer wallet - {UpdateWalletCreditCardRequest}

Updates a credit card in the customer wallet, dates in the past are accepted for non-prod environments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateWalletCreditCardRequestcustomerScopeIdwalletPaymentMethodIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var paymentMethodId = paymentMethodId_example;  // string | Payment method Id
            var body = new UpdateWalletCreditCardRequest(); // UpdateWalletCreditCardRequest |  (optional) 

            try
            {
                // Updates a credit card in the customer wallet - {UpdateWalletCreditCardRequest}
                UpdateWalletCreditCardResponse result = apiInstance.UpdateWalletCreditCardRequestcustomerScopeIdwalletPaymentMethodIdCreate(accept, scopeId, paymentMethodId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.UpdateWalletCreditCardRequestcustomerScopeIdwalletPaymentMethodIdCreate: " + e.Message );
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
 **paymentMethodId** | **string**| Payment method Id | 
 **body** | [**UpdateWalletCreditCardRequest**](UpdateWalletCreditCardRequest.md)|  | [optional] 

### Return type

[**UpdateWalletCreditCardResponse**](UpdateWalletCreditCardResponse.md)

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

<a name="updatewalletdefaultcreditcardrequestcustomerscopeidwalletdefaultpaymentmethodidcreate"></a>
# **UpdateWalletDefaultCreditCardRequestcustomerScopeIdwalletdefaultPaymentMethodIdCreate**
> UpdateWalletDefaultCreditCardResponse UpdateWalletDefaultCreditCardRequestcustomerScopeIdwalletdefaultPaymentMethodIdCreate (string accept, string scopeId, string paymentMethodId, UpdateWalletDefaultCreditCardRequest body = null)

Updates the default credit card in the customer wallet - {UpdateWalletDefaultCreditCardRequest}

Updates the default credit card in the customer wallet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateWalletDefaultCreditCardRequestcustomerScopeIdwalletdefaultPaymentMethodIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CdmvApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var paymentMethodId = paymentMethodId_example;  // string | Payment method Id
            var body = new UpdateWalletDefaultCreditCardRequest(); // UpdateWalletDefaultCreditCardRequest |  (optional) 

            try
            {
                // Updates the default credit card in the customer wallet - {UpdateWalletDefaultCreditCardRequest}
                UpdateWalletDefaultCreditCardResponse result = apiInstance.UpdateWalletDefaultCreditCardRequestcustomerScopeIdwalletdefaultPaymentMethodIdCreate(accept, scopeId, paymentMethodId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CdmvApi.UpdateWalletDefaultCreditCardRequestcustomerScopeIdwalletdefaultPaymentMethodIdCreate: " + e.Message );
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
 **paymentMethodId** | **string**| Payment method Id | 
 **body** | [**UpdateWalletDefaultCreditCardRequest**](UpdateWalletDefaultCreditCardRequest.md)|  | [optional] 

### Return type

[**UpdateWalletDefaultCreditCardResponse**](UpdateWalletDefaultCreditCardResponse.md)

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

