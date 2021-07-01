# Yaksa.OrckestraCommerce.Client.Api.FulfillmentsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPost**](FulfillmentsApi.md#addfulfillmentcompetitionlocationsrequestcompetitionsscopeidfulfillmentcompetitionidlocationspost) | **POST** /fulfillments/competitions/{ScopeId}/{FulfillmentCompetitionId}/locations | Adds one or more fulfillment locations to a fulfillment competition. - {AddFulfillmentCompetitionLocationsRequest}
[**ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreate**](FulfillmentsApi.md#changefulfillmentcompetitionlocationstatusrequestcompetitionsscopeidfulfillmentcompetitionidlocationsfulfillmentlocationidstatuscreate) | **PUT** /fulfillments/competitions/{ScopeId}/{FulfillmentCompetitionId}/locations/{FulfillmentLocationId}/status | Changes the status of a fulfillment competition location. - {ChangeFulfillmentCompetitionLocationStatusRequest}
[**ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreate**](FulfillmentsApi.md#changefulfillmentcompetitionstatusrequestcompetitionsscopeidfulfillmentcompetitionidstatuscreate) | **PUT** /fulfillments/competitions/{ScopeId}/{FulfillmentCompetitionId}/status | Change the status of a fulfillment competition. - {ChangeFulfillmentCompetitionStatusRequest}
[**ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPost**](FulfillmentsApi.md#confirmfulfillmentcarrierquotesrequestcarriersscopeidfulfillmentcarrieridquotesconfirmpost) | **POST** /fulfillments/carriers/{ScopeId}/{FulfillmentCarrierId}/quotes/confirm | Confirm shipping quotes for a package with a carrier - {ConfirmFulfillmentCarrierQuotesRequest}
[**CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPost**](FulfillmentsApi.md#createfulfillmentcarriermanifestrequestcarriersscopeidfulfillmentcarrieridmanifestspost) | **POST** /fulfillments/carriers/{ScopeId}/{FulfillmentCarrierId}/manifests | Create manifests for a list of packages with a carrier - {CreateFulfillmentCarrierManifestRequest}
[**CreateFulfillmentCompetitionRequestcompetitionsScopeIdPost**](FulfillmentsApi.md#createfulfillmentcompetitionrequestcompetitionsscopeidpost) | **POST** /fulfillments/competitions/{ScopeId} | Creates a new fulfillment competition in order to provide an opportunity for fulfillment locations to compete over fulfilling a shipment - {CreateFulfillmentCompetitionRequest}
[**CreateFulfillmentPackageRequestpackagesScopeIdPost**](FulfillmentsApi.md#createfulfillmentpackagerequestpackagesscopeidpost) | **POST** /fulfillments/packages/{ScopeId} | Creates a new fulfillment package with a list of line items - {CreateFulfillmentPackageRequest}
[**CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPost**](FulfillmentsApi.md#createfulfillmentpackagetyperequestpackagetypesscopeidpost) | **POST** /fulfillments/packageTypes/{ScopeId} | Creates a new fulfillment package type - {CreateFulfillmentPackageTypeRequest}
[**CreateFulfillmentSLARequestSLAsScopeIdPost**](FulfillmentsApi.md#createfulfillmentslarequestslasscopeidpost) | **POST** /fulfillments/SLAs/{ScopeId} | Create a fulfillment SLA for a specific fulfillment location - {CreateFulfillmentSLARequest}
[**CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreate**](FulfillmentsApi.md#createorupdatefulfillmentexceptionrequestexceptionsscopeidfulfillmentlocationidorderidshipmentidlineitemidcreate) | **PUT** /fulfillments/exceptions/{ScopeId}/{FulfillmentLocationId}/{OrderId}/{ShipmentId}/{LineItemId} | Creates or updates a fulfillment exception for a lineitem - {CreateOrUpdateFulfillmentExceptionRequest}
[**DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDelete**](FulfillmentsApi.md#deletefulfillmentcompetitionrequestcompetitionsscopeidfulfillmentcompetitioniddelete) | **DELETE** /fulfillments/competitions/{ScopeId}/{FulfillmentCompetitionId} | Deletes a fulfillment competition - {DeleteFulfillmentCompetitionRequest}
[**DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDelete**](FulfillmentsApi.md#deletefulfillmentexceptionrequestexceptionsscopeidfulfillmentlocationidorderidshipmentidlineitemiddelete) | **DELETE** /fulfillments/exceptions/{ScopeId}/{FulfillmentLocationId}/{OrderId}/{ShipmentId}/{LineItemId} | Deletes a fulfillment exception for a lineitem - {DeleteFulfillmentExceptionRequest}
[**DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDelete**](FulfillmentsApi.md#deletefulfillmentpackageforshipmentrequestpackagesscopeidbyshipmentshipmentiddelete) | **DELETE** /fulfillments/packages/{ScopeId}/byShipment/{ShipmentId} | Delete all fulfillment packages for a specific shipment id - {DeleteFulfillmentPackageForShipmentRequest}
[**DeleteFulfillmentPackageRequestpackagesScopeIdIdDelete**](FulfillmentsApi.md#deletefulfillmentpackagerequestpackagesscopeididdelete) | **DELETE** /fulfillments/packages/{ScopeId}/{Id} | Delete a fulfillment package for a specific id - {DeleteFulfillmentPackageRequest}
[**DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDelete**](FulfillmentsApi.md#deletefulfillmentpackagetyperequestpackagetypesscopeididdelete) | **DELETE** /fulfillments/packageTypes/{ScopeId}/{Id} | Delete a fulfillment package type for a specific id - {DeleteFulfillmentPackageTypeRequest}
[**DisableFulfillmentSLARequestSLAsdisablePost**](FulfillmentsApi.md#disablefulfillmentslarequestslasdisablepost) | **POST** /fulfillments/SLAs/disable | Disable a fulfillment SLA for a specific id - {DisableFulfillmentSLARequest}
[**FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPost**](FulfillmentsApi.md#findfulfillmentcompetitionscountrequestcompetitionsscopeidcountpost) | **POST** /fulfillments/competitions/{ScopeId}/count | Gets the number of fulfillment competitions - {FindFulfillmentCompetitionsCountRequest}
[**FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPost**](FulfillmentsApi.md#findfulfillmentcompetitionsrequestcompetitionsscopeidfindpost) | **POST** /fulfillments/competitions/{ScopeId}/find | Search for a list of fulfillment competitions - {FindFulfillmentCompetitionsRequest}
[**FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGet**](FulfillmentsApi.md#findfulfillmentmanifestpackagesrequestpackagesscopeidfindmanifestget) | **GET** /fulfillments/packages/{ScopeId}/findmanifest | Search for a list of fulfillment packages - {FindFulfillmentManifestPackagesRequest}
[**FindFulfillmentOrdersRequestordersScopeIdfindPost**](FulfillmentsApi.md#findfulfillmentordersrequestordersscopeidfindpost) | **POST** /fulfillments/orders/{ScopeId}/find | Search for fulfillment orders - {FindFulfillmentOrdersRequest}
[**FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPost**](FulfillmentsApi.md#findfulfillmentpackagetypesrequestpackagetypesscopeidfindpost) | **POST** /fulfillments/packageTypes/{ScopeId}/find | Search for fulfillment package types - {FindFulfillmentPackageTypesRequest}
[**FindFulfillmentPackagesRequestpackagesScopeIdfindGet**](FulfillmentsApi.md#findfulfillmentpackagesrequestpackagesscopeidfindget) | **GET** /fulfillments/packages/{ScopeId}/find | Search for a list of fulfillment packages - {FindFulfillmentPackagesRequest}
[**FindFulfillmentSLARequestSLAsScopeIdfindPost**](FulfillmentsApi.md#findfulfillmentslarequestslasscopeidfindpost) | **POST** /fulfillments/SLAs/{ScopeId}/find | Search for fulfillment SLA - {FindFulfillmentSLARequest}
[**GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPost**](FulfillmentsApi.md#getfulfillmentcarrierdocumentsrequestcarriersscopeidfulfillmentcarrieridquotesdocumentspost) | **POST** /fulfillments/carriers/{ScopeId}/{FulfillmentCarrierId}/quotes/documents | Get shipping documents from a carrier - {GetFulfillmentCarrierDocumentsRequest}
[**GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPost**](FulfillmentsApi.md#getfulfillmentcarrierquotesrequestcarriersscopeidfulfillmentcarrieridquotespost) | **POST** /fulfillments/carriers/{ScopeId}/{FulfillmentCarrierId}/quotes | Get shipping quotes for a package from a carrier - {GetFulfillmentCarrierQuotesRequest}
[**GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGet**](FulfillmentsApi.md#getfulfillmentcompetitionrequestcompetitionsscopeidfulfillmentcompetitionidget) | **GET** /fulfillments/competitions/{ScopeId}/{FulfillmentCompetitionId} | Gets a fulfillment competition by its identifier - {GetFulfillmentCompetitionRequest}
[**GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGet**](FulfillmentsApi.md#getfulfillmentexceptionsrequestexceptionsscopeidfulfillmentlocationidorderidget) | **GET** /fulfillments/exceptions/{ScopeId}/{FulfillmentLocationId}/{OrderId} | Gets the fulfillment exceptions for an order at a fulfillment location - {GetFulfillmentExceptionsRequest}
[**GetFulfillmentPackageRequestpackagesScopeIdIdGet**](FulfillmentsApi.md#getfulfillmentpackagerequestpackagesscopeididget) | **GET** /fulfillments/packages/{ScopeId}/{Id} | Gets a fulfillment package by its identifier - {GetFulfillmentPackageRequest}
[**GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGet**](FulfillmentsApi.md#getfulfillmentpackagetyperequestpackagetypesscopeididget) | **GET** /fulfillments/packageTypes/{ScopeId}/{Id} | Gets a fulfillment package type by its identifier - {GetFulfillmentPackageTypeRequest}
[**GetFulfillmentSLARequestSLAsScopeIdIdGet**](FulfillmentsApi.md#getfulfillmentslarequestslasscopeididget) | **GET** /fulfillments/SLAs/{ScopeId}/{Id} | Gets a fulfillment SLA by its identifier - {GetFulfillmentSLARequest}
[**RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPost**](FulfillmentsApi.md#refundfulfillmentcarrierquotesrequestcarriersscopeidfulfillmentcarrieridquotesrefundpost) | **POST** /fulfillments/carriers/{ScopeId}/{FulfillmentCarrierId}/quotes/refund | Refund shipping quotes from a carrier - {RefundFulfillmentCarrierQuotesRequest}
[**RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDelete**](FulfillmentsApi.md#removefulfillmentcompetitionlocationsrequestcompetitionsscopeidfulfillmentcompetitionidlocationsdelete) | **DELETE** /fulfillments/competitions/{ScopeId}/{FulfillmentCompetitionId}/locations | Removes a list of fulfillment competition locations from a specific fulfillment competition - {RemoveFulfillmentCompetitionLocationsRequest}
[**TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPost**](FulfillmentsApi.md#transferfulfillmentpackageitemsrequestpackagesscopeidtransferfulfillmentpackageitemspost) | **POST** /fulfillments/packages/{ScopeId}/transferFulfillmentPackageItems | Transfers a list of fulfillment package items from one fulfillment package to another - {TransferFulfillmentPackageItemsRequest}
[**UpdateFulfillmentPackageRequestpackagesScopeIdIdCreate**](FulfillmentsApi.md#updatefulfillmentpackagerequestpackagesscopeididcreate) | **PUT** /fulfillments/packages/{ScopeId}/{Id} | Updates a fulfillment package - {UpdateFulfillmentPackageRequest}
[**UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreate**](FulfillmentsApi.md#updatefulfillmentpackagetyperequestpackagetypesscopeididcreate) | **PUT** /fulfillments/packageTypes/{ScopeId}/{Id} | Updates a fulfillment package type - {UpdateFulfillmentPackageTypeRequest}


<a name="addfulfillmentcompetitionlocationsrequestcompetitionsscopeidfulfillmentcompetitionidlocationspost"></a>
# **AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPost**
> FulfillmentCompetition AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPost (string accept, string scopeId, string fulfillmentCompetitionId, AddFulfillmentCompetitionLocationsRequest body = null)

Adds one or more fulfillment locations to a fulfillment competition. - {AddFulfillmentCompetitionLocationsRequest}

Adds one or more fulfillment locations to a fulfillment competition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentCompetitionId = fulfillmentCompetitionId_example;  // string | The identifier of the fulfillment competition to which the fulfillment locations are added.
            var body = new AddFulfillmentCompetitionLocationsRequest(); // AddFulfillmentCompetitionLocationsRequest |  (optional) 

            try
            {
                // Adds one or more fulfillment locations to a fulfillment competition. - {AddFulfillmentCompetitionLocationsRequest}
                FulfillmentCompetition result = apiInstance.AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPost(accept, scopeId, fulfillmentCompetitionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.AddFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsPost: " + e.Message );
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
 **fulfillmentCompetitionId** | **string**| The identifier of the fulfillment competition to which the fulfillment locations are added. | 
 **body** | [**AddFulfillmentCompetitionLocationsRequest**](AddFulfillmentCompetitionLocationsRequest.md)|  | [optional] 

### Return type

[**FulfillmentCompetition**](FulfillmentCompetition.md)

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

<a name="changefulfillmentcompetitionlocationstatusrequestcompetitionsscopeidfulfillmentcompetitionidlocationsfulfillmentlocationidstatuscreate"></a>
# **ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreate**
> FulfillmentCompetition ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreate (string accept, string scopeId, string fulfillmentCompetitionId, string fulfillmentLocationId, ChangeFulfillmentCompetitionLocationStatusRequest body = null)

Changes the status of a fulfillment competition location. - {ChangeFulfillmentCompetitionLocationStatusRequest}

Changes the status of a fulfillment competition location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentCompetitionId = fulfillmentCompetitionId_example;  // string | The identifier of the fulfillment competition whose fulfillment competition location status is changing.
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The identifier of the fulfillment location whose status is changing.
            var body = new ChangeFulfillmentCompetitionLocationStatusRequest(); // ChangeFulfillmentCompetitionLocationStatusRequest |  (optional) 

            try
            {
                // Changes the status of a fulfillment competition location. - {ChangeFulfillmentCompetitionLocationStatusRequest}
                FulfillmentCompetition result = apiInstance.ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreate(accept, scopeId, fulfillmentCompetitionId, fulfillmentLocationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.ChangeFulfillmentCompetitionLocationStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsFulfillmentLocationIdstatusCreate: " + e.Message );
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
 **fulfillmentCompetitionId** | **string**| The identifier of the fulfillment competition whose fulfillment competition location status is changing. | 
 **fulfillmentLocationId** | **string**| The identifier of the fulfillment location whose status is changing. | 
 **body** | [**ChangeFulfillmentCompetitionLocationStatusRequest**](ChangeFulfillmentCompetitionLocationStatusRequest.md)|  | [optional] 

### Return type

[**FulfillmentCompetition**](FulfillmentCompetition.md)

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

<a name="changefulfillmentcompetitionstatusrequestcompetitionsscopeidfulfillmentcompetitionidstatuscreate"></a>
# **ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreate**
> FulfillmentCompetition ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreate (string accept, string scopeId, string fulfillmentCompetitionId, ChangeFulfillmentCompetitionStatusRequest body = null)

Change the status of a fulfillment competition. - {ChangeFulfillmentCompetitionStatusRequest}

Change the status of a fulfillment competition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentCompetitionId = fulfillmentCompetitionId_example;  // string | The identifier of the fulfillment competition to which the status is changing.
            var body = new ChangeFulfillmentCompetitionStatusRequest(); // ChangeFulfillmentCompetitionStatusRequest |  (optional) 

            try
            {
                // Change the status of a fulfillment competition. - {ChangeFulfillmentCompetitionStatusRequest}
                FulfillmentCompetition result = apiInstance.ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreate(accept, scopeId, fulfillmentCompetitionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.ChangeFulfillmentCompetitionStatusRequestcompetitionsScopeIdFulfillmentCompetitionIdstatusCreate: " + e.Message );
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
 **fulfillmentCompetitionId** | **string**| The identifier of the fulfillment competition to which the status is changing. | 
 **body** | [**ChangeFulfillmentCompetitionStatusRequest**](ChangeFulfillmentCompetitionStatusRequest.md)|  | [optional] 

### Return type

[**FulfillmentCompetition**](FulfillmentCompetition.md)

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

<a name="confirmfulfillmentcarrierquotesrequestcarriersscopeidfulfillmentcarrieridquotesconfirmpost"></a>
# **ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPost**
> ConfirmFulfillmentCarrierQuotesResponse ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPost (string accept, string scopeId, string fulfillmentCarrierId, ConfirmFulfillmentCarrierQuotesRequest body = null)

Confirm shipping quotes for a package with a carrier - {ConfirmFulfillmentCarrierQuotesRequest}

Confirm shipping quotes for a package with a carrier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var fulfillmentCarrierId = fulfillmentCarrierId_example;  // string | The fulfillment carrier identifier.
            var body = new ConfirmFulfillmentCarrierQuotesRequest(); // ConfirmFulfillmentCarrierQuotesRequest |  (optional) 

            try
            {
                // Confirm shipping quotes for a package with a carrier - {ConfirmFulfillmentCarrierQuotesRequest}
                ConfirmFulfillmentCarrierQuotesResponse result = apiInstance.ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPost(accept, scopeId, fulfillmentCarrierId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.ConfirmFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesconfirmPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **fulfillmentCarrierId** | **string**| The fulfillment carrier identifier. | 
 **body** | [**ConfirmFulfillmentCarrierQuotesRequest**](ConfirmFulfillmentCarrierQuotesRequest.md)|  | [optional] 

### Return type

[**ConfirmFulfillmentCarrierQuotesResponse**](ConfirmFulfillmentCarrierQuotesResponse.md)

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

<a name="createfulfillmentcarriermanifestrequestcarriersscopeidfulfillmentcarrieridmanifestspost"></a>
# **CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPost**
> CreateFulfillmentCarrierManifestResponse CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPost (string accept, string scopeId, string fulfillmentCarrierId, CreateFulfillmentCarrierManifestRequest body = null)

Create manifests for a list of packages with a carrier - {CreateFulfillmentCarrierManifestRequest}

Create manifests for a list of packages with a carrier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var fulfillmentCarrierId = fulfillmentCarrierId_example;  // string | The fulfillment carrier identifier.
            var body = new CreateFulfillmentCarrierManifestRequest(); // CreateFulfillmentCarrierManifestRequest |  (optional) 

            try
            {
                // Create manifests for a list of packages with a carrier - {CreateFulfillmentCarrierManifestRequest}
                CreateFulfillmentCarrierManifestResponse result = apiInstance.CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPost(accept, scopeId, fulfillmentCarrierId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.CreateFulfillmentCarrierManifestRequestcarriersScopeIdFulfillmentCarrierIdmanifestsPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **fulfillmentCarrierId** | **string**| The fulfillment carrier identifier. | 
 **body** | [**CreateFulfillmentCarrierManifestRequest**](CreateFulfillmentCarrierManifestRequest.md)|  | [optional] 

### Return type

[**CreateFulfillmentCarrierManifestResponse**](CreateFulfillmentCarrierManifestResponse.md)

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

<a name="createfulfillmentcompetitionrequestcompetitionsscopeidpost"></a>
# **CreateFulfillmentCompetitionRequestcompetitionsScopeIdPost**
> FulfillmentCompetition CreateFulfillmentCompetitionRequestcompetitionsScopeIdPost (string accept, string scopeId, CreateFulfillmentCompetitionRequest body = null)

Creates a new fulfillment competition in order to provide an opportunity for fulfillment locations to compete over fulfilling a shipment - {CreateFulfillmentCompetitionRequest}

Creates a new fulfillment competition in order to provide an opportunity for fulfillment locations to compete over fulfilling a shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateFulfillmentCompetitionRequestcompetitionsScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateFulfillmentCompetitionRequest(); // CreateFulfillmentCompetitionRequest |  (optional) 

            try
            {
                // Creates a new fulfillment competition in order to provide an opportunity for fulfillment locations to compete over fulfilling a shipment - {CreateFulfillmentCompetitionRequest}
                FulfillmentCompetition result = apiInstance.CreateFulfillmentCompetitionRequestcompetitionsScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.CreateFulfillmentCompetitionRequestcompetitionsScopeIdPost: " + e.Message );
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
 **body** | [**CreateFulfillmentCompetitionRequest**](CreateFulfillmentCompetitionRequest.md)|  | [optional] 

### Return type

[**FulfillmentCompetition**](FulfillmentCompetition.md)

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

<a name="createfulfillmentpackagerequestpackagesscopeidpost"></a>
# **CreateFulfillmentPackageRequestpackagesScopeIdPost**
> FulfillmentPackage CreateFulfillmentPackageRequestpackagesScopeIdPost (string accept, string scopeId, CreateFulfillmentPackageRequest body = null)

Creates a new fulfillment package with a list of line items - {CreateFulfillmentPackageRequest}

Creates a new fulfillment package with a list of line items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateFulfillmentPackageRequestpackagesScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var body = new CreateFulfillmentPackageRequest(); // CreateFulfillmentPackageRequest |  (optional) 

            try
            {
                // Creates a new fulfillment package with a list of line items - {CreateFulfillmentPackageRequest}
                FulfillmentPackage result = apiInstance.CreateFulfillmentPackageRequestpackagesScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.CreateFulfillmentPackageRequestpackagesScopeIdPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **body** | [**CreateFulfillmentPackageRequest**](CreateFulfillmentPackageRequest.md)|  | [optional] 

### Return type

[**FulfillmentPackage**](FulfillmentPackage.md)

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

<a name="createfulfillmentpackagetyperequestpackagetypesscopeidpost"></a>
# **CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPost**
> FulfillmentPackageType CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPost (string accept, string scopeId, CreateFulfillmentPackageTypeRequest body = null)

Creates a new fulfillment package type - {CreateFulfillmentPackageTypeRequest}

Creates a new fulfillment package type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var body = new CreateFulfillmentPackageTypeRequest(); // CreateFulfillmentPackageTypeRequest |  (optional) 

            try
            {
                // Creates a new fulfillment package type - {CreateFulfillmentPackageTypeRequest}
                FulfillmentPackageType result = apiInstance.CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.CreateFulfillmentPackageTypeRequestpackageTypesScopeIdPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **body** | [**CreateFulfillmentPackageTypeRequest**](CreateFulfillmentPackageTypeRequest.md)|  | [optional] 

### Return type

[**FulfillmentPackageType**](FulfillmentPackageType.md)

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

<a name="createfulfillmentslarequestslasscopeidpost"></a>
# **CreateFulfillmentSLARequestSLAsScopeIdPost**
> FulfillmentSLA CreateFulfillmentSLARequestSLAsScopeIdPost (string accept, string scopeId, CreateFulfillmentSLARequest body = null)

Create a fulfillment SLA for a specific fulfillment location - {CreateFulfillmentSLARequest}

Create a fulfillment SLA for a specific fulfillment location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateFulfillmentSLARequestSLAsScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope id.
            var body = new CreateFulfillmentSLARequest(); // CreateFulfillmentSLARequest |  (optional) 

            try
            {
                // Create a fulfillment SLA for a specific fulfillment location - {CreateFulfillmentSLARequest}
                FulfillmentSLA result = apiInstance.CreateFulfillmentSLARequestSLAsScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.CreateFulfillmentSLARequestSLAsScopeIdPost: " + e.Message );
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
 **scopeId** | **string**| The scope id. | 
 **body** | [**CreateFulfillmentSLARequest**](CreateFulfillmentSLARequest.md)|  | [optional] 

### Return type

[**FulfillmentSLA**](FulfillmentSLA.md)

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

<a name="createorupdatefulfillmentexceptionrequestexceptionsscopeidfulfillmentlocationidorderidshipmentidlineitemidcreate"></a>
# **CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreate**
> FulfillmentException CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreate (string accept, string scopeId, string fulfillmentLocationId, string orderId, string shipmentId, string lineItemId, CreateOrUpdateFulfillmentExceptionRequest body = null)

Creates or updates a fulfillment exception for a lineitem - {CreateOrUpdateFulfillmentExceptionRequest}

Creates or updates a fulfillment exception for a lineitem

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The fulfillment location identifier.
            var orderId = orderId_example;  // string | The identifier of the order.
            var shipmentId = shipmentId_example;  // string | The identifier of the shipment.
            var lineItemId = lineItemId_example;  // string | The identifier of the line item.
            var body = new CreateOrUpdateFulfillmentExceptionRequest(); // CreateOrUpdateFulfillmentExceptionRequest |  (optional) 

            try
            {
                // Creates or updates a fulfillment exception for a lineitem - {CreateOrUpdateFulfillmentExceptionRequest}
                FulfillmentException result = apiInstance.CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreate(accept, scopeId, fulfillmentLocationId, orderId, shipmentId, lineItemId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.CreateOrUpdateFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdCreate: " + e.Message );
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
 **fulfillmentLocationId** | **string**| The fulfillment location identifier. | 
 **orderId** | **string**| The identifier of the order. | 
 **shipmentId** | **string**| The identifier of the shipment. | 
 **lineItemId** | **string**| The identifier of the line item. | 
 **body** | [**CreateOrUpdateFulfillmentExceptionRequest**](CreateOrUpdateFulfillmentExceptionRequest.md)|  | [optional] 

### Return type

[**FulfillmentException**](FulfillmentException.md)

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

<a name="deletefulfillmentcompetitionrequestcompetitionsscopeidfulfillmentcompetitioniddelete"></a>
# **DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDelete**
> void DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDelete (string accept, string scopeId, string fulfillmentCompetitionId)

Deletes a fulfillment competition - {DeleteFulfillmentCompetitionRequest}

Deletes a fulfillment competition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentCompetitionId = fulfillmentCompetitionId_example;  // string | The identifier of the fulfillment competition to be removed.

            try
            {
                // Deletes a fulfillment competition - {DeleteFulfillmentCompetitionRequest}
                apiInstance.DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDelete(accept, scopeId, fulfillmentCompetitionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.DeleteFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdDelete: " + e.Message );
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
 **fulfillmentCompetitionId** | **string**| The identifier of the fulfillment competition to be removed. | 

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

<a name="deletefulfillmentexceptionrequestexceptionsscopeidfulfillmentlocationidorderidshipmentidlineitemiddelete"></a>
# **DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDelete**
> void DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDelete (string accept, string scopeId, string fulfillmentLocationId, string orderId, string shipmentId, string lineItemId)

Deletes a fulfillment exception for a lineitem - {DeleteFulfillmentExceptionRequest}

Deletes a fulfillment exception for a lineitem

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The fulfillment location identifier.
            var orderId = orderId_example;  // string | The identifier of the order.
            var shipmentId = shipmentId_example;  // string | The identifier of the shipment.
            var lineItemId = lineItemId_example;  // string | The identifier of the line item.

            try
            {
                // Deletes a fulfillment exception for a lineitem - {DeleteFulfillmentExceptionRequest}
                apiInstance.DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDelete(accept, scopeId, fulfillmentLocationId, orderId, shipmentId, lineItemId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.DeleteFulfillmentExceptionRequestexceptionsScopeIdFulfillmentLocationIdOrderIdShipmentIdLineItemIdDelete: " + e.Message );
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
 **fulfillmentLocationId** | **string**| The fulfillment location identifier. | 
 **orderId** | **string**| The identifier of the order. | 
 **shipmentId** | **string**| The identifier of the shipment. | 
 **lineItemId** | **string**| The identifier of the line item. | 

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

<a name="deletefulfillmentpackageforshipmentrequestpackagesscopeidbyshipmentshipmentiddelete"></a>
# **DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDelete**
> void DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDelete (string accept, string scopeId, string shipmentId)

Delete all fulfillment packages for a specific shipment id - {DeleteFulfillmentPackageForShipmentRequest}

Delete all fulfillment packages for a specific shipment id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var shipmentId = shipmentId_example;  // string | The shipment identifier.

            try
            {
                // Delete all fulfillment packages for a specific shipment id - {DeleteFulfillmentPackageForShipmentRequest}
                apiInstance.DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDelete(accept, scopeId, shipmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.DeleteFulfillmentPackageForShipmentRequestpackagesScopeIdbyShipmentShipmentIdDelete: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **shipmentId** | **string**| The shipment identifier. | 

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

<a name="deletefulfillmentpackagerequestpackagesscopeididdelete"></a>
# **DeleteFulfillmentPackageRequestpackagesScopeIdIdDelete**
> void DeleteFulfillmentPackageRequestpackagesScopeIdIdDelete (string accept, string scopeId, string id)

Delete a fulfillment package for a specific id - {DeleteFulfillmentPackageRequest}

Delete a fulfillment package for a specific id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentPackageRequestpackagesScopeIdIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var id = id_example;  // string | The fulfillment package id.

            try
            {
                // Delete a fulfillment package for a specific id - {DeleteFulfillmentPackageRequest}
                apiInstance.DeleteFulfillmentPackageRequestpackagesScopeIdIdDelete(accept, scopeId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.DeleteFulfillmentPackageRequestpackagesScopeIdIdDelete: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **id** | **string**| The fulfillment package id. | 

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

<a name="deletefulfillmentpackagetyperequestpackagetypesscopeididdelete"></a>
# **DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDelete**
> void DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDelete (string accept, string scopeId, string id)

Delete a fulfillment package type for a specific id - {DeleteFulfillmentPackageTypeRequest}

Delete a fulfillment package type for a specific id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var id = id_example;  // string | The fulfillment package type id.

            try
            {
                // Delete a fulfillment package type for a specific id - {DeleteFulfillmentPackageTypeRequest}
                apiInstance.DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDelete(accept, scopeId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.DeleteFulfillmentPackageTypeRequestpackageTypesScopeIdIdDelete: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **id** | **string**| The fulfillment package type id. | 

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

<a name="disablefulfillmentslarequestslasdisablepost"></a>
# **DisableFulfillmentSLARequestSLAsdisablePost**
> FulfillmentSLA DisableFulfillmentSLARequestSLAsdisablePost (string accept, DisableFulfillmentSLARequest body = null)

Disable a fulfillment SLA for a specific id - {DisableFulfillmentSLARequest}

Disable a fulfillment SLA for a specific id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DisableFulfillmentSLARequestSLAsdisablePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new DisableFulfillmentSLARequest(); // DisableFulfillmentSLARequest |  (optional) 

            try
            {
                // Disable a fulfillment SLA for a specific id - {DisableFulfillmentSLARequest}
                FulfillmentSLA result = apiInstance.DisableFulfillmentSLARequestSLAsdisablePost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.DisableFulfillmentSLARequestSLAsdisablePost: " + e.Message );
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
 **body** | [**DisableFulfillmentSLARequest**](DisableFulfillmentSLARequest.md)|  | [optional] 

### Return type

[**FulfillmentSLA**](FulfillmentSLA.md)

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

<a name="findfulfillmentcompetitionscountrequestcompetitionsscopeidcountpost"></a>
# **FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPost**
> QueryCountResult FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPost (string accept, string scopeId, FindFulfillmentCompetitionsCountRequest body = null)

Gets the number of fulfillment competitions - {FindFulfillmentCompetitionsCountRequest}

Gets the number of fulfillment competitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindFulfillmentCompetitionsCountRequest(); // FindFulfillmentCompetitionsCountRequest |  (optional) 

            try
            {
                // Gets the number of fulfillment competitions - {FindFulfillmentCompetitionsCountRequest}
                QueryCountResult result = apiInstance.FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.FindFulfillmentCompetitionsCountRequestcompetitionsScopeIdcountPost: " + e.Message );
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
 **body** | [**FindFulfillmentCompetitionsCountRequest**](FindFulfillmentCompetitionsCountRequest.md)|  | [optional] 

### Return type

[**QueryCountResult**](QueryCountResult.md)

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

<a name="findfulfillmentcompetitionsrequestcompetitionsscopeidfindpost"></a>
# **FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPost**
> FulfillmentCompetitionQueryResult FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPost (string accept, string scopeId, FindFulfillmentCompetitionsRequest body = null)

Search for a list of fulfillment competitions - {FindFulfillmentCompetitionsRequest}

Search for a list of fulfillment competitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindFulfillmentCompetitionsRequest(); // FindFulfillmentCompetitionsRequest |  (optional) 

            try
            {
                // Search for a list of fulfillment competitions - {FindFulfillmentCompetitionsRequest}
                FulfillmentCompetitionQueryResult result = apiInstance.FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.FindFulfillmentCompetitionsRequestcompetitionsScopeIdfindPost: " + e.Message );
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
 **body** | [**FindFulfillmentCompetitionsRequest**](FindFulfillmentCompetitionsRequest.md)|  | [optional] 

### Return type

[**FulfillmentCompetitionQueryResult**](FulfillmentCompetitionQueryResult.md)

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

<a name="findfulfillmentmanifestpackagesrequestpackagesscopeidfindmanifestget"></a>
# **FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGet**
> FulfillmentPackageResult FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGet (string accept, string scopeId, string fulfillmentLocationId = null, string shippingProviderId = null, string fulfillmentStatus = null, DateTime? manifestedFrom = null, DateTime? manifestedTo = null, string manifestReferenceId = null, bool? includePackagesWithManifest = null, bool? includePackagesWithoutManifest = null, bool? includePackageItems = null, string carrierAccountIdOutbound = null, string carrierAccountNameOutbound = null, string carrierNameOutbound = null, string carrierServiceLevelOutbound = null, string carrierManifestRequirement = null)

Search for a list of fulfillment packages - {FindFulfillmentManifestPackagesRequest}

Search for a list of fulfillment packages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The fulfillment location identifier. (optional) 
            var shippingProviderId = shippingProviderId_example;  // string | The optional shipping provider identifier. (optional) 
            var fulfillmentStatus = fulfillmentStatus_example;  // string | The optional fulfillment status. (optional) 
            var manifestedFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | The optional manifested from date filter (utc). (optional) 
            var manifestedTo = 2013-10-20T19:20:30+01:00;  // DateTime? | The optional manifested from date filter (utc). (optional) 
            var manifestReferenceId = manifestReferenceId_example;  // string | The optional manifest reference id. (optional) 
            var includePackagesWithManifest = true;  // bool? | A value indicating whether fulfillment packages with a manifest are returned. (optional) 
            var includePackagesWithoutManifest = true;  // bool? | A value indicating whether fulfillment packages without a manifest are returned. (optional) 
            var includePackageItems = true;  // bool? | A value indicating whether fulfillment package items are retrieved with each package. (optional) 
            var carrierAccountIdOutbound = carrierAccountIdOutbound_example;  // string | The carrier account id for outbound. (optional) 
            var carrierAccountNameOutbound = carrierAccountNameOutbound_example;  // string | The carrier account name for outbound. (optional) 
            var carrierNameOutbound = carrierNameOutbound_example;  // string | The carrier name for outbound. (optional) 
            var carrierServiceLevelOutbound = carrierServiceLevelOutbound_example;  // string | The carrier service level for outbound. (optional) 
            var carrierManifestRequirement = carrierManifestRequirement_example;  // string | The optional carrier manifest requirement to find. (optional) 

            try
            {
                // Search for a list of fulfillment packages - {FindFulfillmentManifestPackagesRequest}
                FulfillmentPackageResult result = apiInstance.FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGet(accept, scopeId, fulfillmentLocationId, shippingProviderId, fulfillmentStatus, manifestedFrom, manifestedTo, manifestReferenceId, includePackagesWithManifest, includePackagesWithoutManifest, includePackageItems, carrierAccountIdOutbound, carrierAccountNameOutbound, carrierNameOutbound, carrierServiceLevelOutbound, carrierManifestRequirement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.FindFulfillmentManifestPackagesRequestpackagesScopeIdfindmanifestGet: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **fulfillmentLocationId** | **string**| The fulfillment location identifier. | [optional] 
 **shippingProviderId** | **string**| The optional shipping provider identifier. | [optional] 
 **fulfillmentStatus** | **string**| The optional fulfillment status. | [optional] 
 **manifestedFrom** | **DateTime?**| The optional manifested from date filter (utc). | [optional] 
 **manifestedTo** | **DateTime?**| The optional manifested from date filter (utc). | [optional] 
 **manifestReferenceId** | **string**| The optional manifest reference id. | [optional] 
 **includePackagesWithManifest** | **bool?**| A value indicating whether fulfillment packages with a manifest are returned. | [optional] 
 **includePackagesWithoutManifest** | **bool?**| A value indicating whether fulfillment packages without a manifest are returned. | [optional] 
 **includePackageItems** | **bool?**| A value indicating whether fulfillment package items are retrieved with each package. | [optional] 
 **carrierAccountIdOutbound** | **string**| The carrier account id for outbound. | [optional] 
 **carrierAccountNameOutbound** | **string**| The carrier account name for outbound. | [optional] 
 **carrierNameOutbound** | **string**| The carrier name for outbound. | [optional] 
 **carrierServiceLevelOutbound** | **string**| The carrier service level for outbound. | [optional] 
 **carrierManifestRequirement** | **string**| The optional carrier manifest requirement to find. | [optional] 

### Return type

[**FulfillmentPackageResult**](FulfillmentPackageResult.md)

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

<a name="findfulfillmentordersrequestordersscopeidfindpost"></a>
# **FindFulfillmentOrdersRequestordersScopeIdfindPost**
> FulfillmentOrderQueryResult FindFulfillmentOrdersRequestordersScopeIdfindPost (string accept, string scopeId, FindFulfillmentOrdersRequest body = null)

Search for fulfillment orders - {FindFulfillmentOrdersRequest}

Search for fulfillment orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentOrdersRequestordersScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindFulfillmentOrdersRequest(); // FindFulfillmentOrdersRequest |  (optional) 

            try
            {
                // Search for fulfillment orders - {FindFulfillmentOrdersRequest}
                FulfillmentOrderQueryResult result = apiInstance.FindFulfillmentOrdersRequestordersScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.FindFulfillmentOrdersRequestordersScopeIdfindPost: " + e.Message );
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
 **body** | [**FindFulfillmentOrdersRequest**](FindFulfillmentOrdersRequest.md)|  | [optional] 

### Return type

[**FulfillmentOrderQueryResult**](FulfillmentOrderQueryResult.md)

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

<a name="findfulfillmentpackagetypesrequestpackagetypesscopeidfindpost"></a>
# **FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPost**
> FulfillmentPackageTypeResult FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPost (string accept, string scopeId, FindFulfillmentPackageTypesRequest body = null)

Search for fulfillment package types - {FindFulfillmentPackageTypesRequest}

Search for fulfillment package types for a Scope (and its parents)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | Scope to retrieve fulfillment package types for
            var body = new FindFulfillmentPackageTypesRequest(); // FindFulfillmentPackageTypesRequest |  (optional) 

            try
            {
                // Search for fulfillment package types - {FindFulfillmentPackageTypesRequest}
                FulfillmentPackageTypeResult result = apiInstance.FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.FindFulfillmentPackageTypesRequestpackageTypesScopeIdfindPost: " + e.Message );
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
 **scopeId** | **string**| Scope to retrieve fulfillment package types for | 
 **body** | [**FindFulfillmentPackageTypesRequest**](FindFulfillmentPackageTypesRequest.md)|  | [optional] 

### Return type

[**FulfillmentPackageTypeResult**](FulfillmentPackageTypeResult.md)

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

<a name="findfulfillmentpackagesrequestpackagesscopeidfindget"></a>
# **FindFulfillmentPackagesRequestpackagesScopeIdfindGet**
> FulfillmentPackageResult FindFulfillmentPackagesRequestpackagesScopeIdfindGet (string accept, string scopeId, string orderId = null, List<string> shipmentIds = null, string cultureName = null, bool? includeFulfillmentPackageType = null)

Search for a list of fulfillment packages - {FindFulfillmentPackagesRequest}

Search for a list of fulfillment packages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentPackagesRequestpackagesScopeIdfindGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var orderId = orderId_example;  // string | The order identifier. (optional) 
            var shipmentIds = new List<string>(); // List<string> | A list of shipment identifier. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data for the fulfillment package type will be returned (optional) 
            var includeFulfillmentPackageType = true;  // bool? | A value indicating whether the fulfillment package type should be returns along each fulfillment package. (optional) 

            try
            {
                // Search for a list of fulfillment packages - {FindFulfillmentPackagesRequest}
                FulfillmentPackageResult result = apiInstance.FindFulfillmentPackagesRequestpackagesScopeIdfindGet(accept, scopeId, orderId, shipmentIds, cultureName, includeFulfillmentPackageType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.FindFulfillmentPackagesRequestpackagesScopeIdfindGet: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **orderId** | **string**| The order identifier. | [optional] 
 **shipmentIds** | [**List&lt;string&gt;**](string.md)| A list of shipment identifier. | [optional] 
 **cultureName** | **string**| The culture name in which language the data for the fulfillment package type will be returned | [optional] 
 **includeFulfillmentPackageType** | **bool?**| A value indicating whether the fulfillment package type should be returns along each fulfillment package. | [optional] 

### Return type

[**FulfillmentPackageResult**](FulfillmentPackageResult.md)

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

<a name="findfulfillmentslarequestslasscopeidfindpost"></a>
# **FindFulfillmentSLARequestSLAsScopeIdfindPost**
> FulfillmentSLAQueryResult FindFulfillmentSLARequestSLAsScopeIdfindPost (string accept, string scopeId, FindFulfillmentSLARequest body = null)

Search for fulfillment SLA - {FindFulfillmentSLARequest}

Search for fulfillment SLA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentSLARequestSLAsScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindFulfillmentSLARequest(); // FindFulfillmentSLARequest |  (optional) 

            try
            {
                // Search for fulfillment SLA - {FindFulfillmentSLARequest}
                FulfillmentSLAQueryResult result = apiInstance.FindFulfillmentSLARequestSLAsScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.FindFulfillmentSLARequestSLAsScopeIdfindPost: " + e.Message );
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
 **body** | [**FindFulfillmentSLARequest**](FindFulfillmentSLARequest.md)|  | [optional] 

### Return type

[**FulfillmentSLAQueryResult**](FulfillmentSLAQueryResult.md)

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

<a name="getfulfillmentcarrierdocumentsrequestcarriersscopeidfulfillmentcarrieridquotesdocumentspost"></a>
# **GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPost**
> GetFulfillmentCarrierDocumentsResponse GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPost (string accept, string scopeId, string fulfillmentCarrierId, GetFulfillmentCarrierDocumentsRequest body = null)

Get shipping documents from a carrier - {GetFulfillmentCarrierDocumentsRequest}

Get shipping documents from a carrier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var fulfillmentCarrierId = fulfillmentCarrierId_example;  // string | The fulfillment carrier identifier.
            var body = new GetFulfillmentCarrierDocumentsRequest(); // GetFulfillmentCarrierDocumentsRequest |  (optional) 

            try
            {
                // Get shipping documents from a carrier - {GetFulfillmentCarrierDocumentsRequest}
                GetFulfillmentCarrierDocumentsResponse result = apiInstance.GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPost(accept, scopeId, fulfillmentCarrierId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.GetFulfillmentCarrierDocumentsRequestcarriersScopeIdFulfillmentCarrierIdquotesdocumentsPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **fulfillmentCarrierId** | **string**| The fulfillment carrier identifier. | 
 **body** | [**GetFulfillmentCarrierDocumentsRequest**](GetFulfillmentCarrierDocumentsRequest.md)|  | [optional] 

### Return type

[**GetFulfillmentCarrierDocumentsResponse**](GetFulfillmentCarrierDocumentsResponse.md)

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

<a name="getfulfillmentcarrierquotesrequestcarriersscopeidfulfillmentcarrieridquotespost"></a>
# **GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPost**
> GetFulfillmentCarrierQuotesResponse GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPost (string accept, string scopeId, string fulfillmentCarrierId, GetFulfillmentCarrierQuotesRequest body = null)

Get shipping quotes for a package from a carrier - {GetFulfillmentCarrierQuotesRequest}

Get shipping quotes for a package from a carrier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var fulfillmentCarrierId = fulfillmentCarrierId_example;  // string | The fulfillment carrier identifier.
            var body = new GetFulfillmentCarrierQuotesRequest(); // GetFulfillmentCarrierQuotesRequest |  (optional) 

            try
            {
                // Get shipping quotes for a package from a carrier - {GetFulfillmentCarrierQuotesRequest}
                GetFulfillmentCarrierQuotesResponse result = apiInstance.GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPost(accept, scopeId, fulfillmentCarrierId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.GetFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **fulfillmentCarrierId** | **string**| The fulfillment carrier identifier. | 
 **body** | [**GetFulfillmentCarrierQuotesRequest**](GetFulfillmentCarrierQuotesRequest.md)|  | [optional] 

### Return type

[**GetFulfillmentCarrierQuotesResponse**](GetFulfillmentCarrierQuotesResponse.md)

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

<a name="getfulfillmentcompetitionrequestcompetitionsscopeidfulfillmentcompetitionidget"></a>
# **GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGet**
> FulfillmentCompetition GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGet (string accept, string scopeId, string fulfillmentCompetitionId)

Gets a fulfillment competition by its identifier - {GetFulfillmentCompetitionRequest}

Gets a fulfillment competition by its identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentCompetitionId = fulfillmentCompetitionId_example;  // string | The fulfillment competition identifier.

            try
            {
                // Gets a fulfillment competition by its identifier - {GetFulfillmentCompetitionRequest}
                FulfillmentCompetition result = apiInstance.GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGet(accept, scopeId, fulfillmentCompetitionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.GetFulfillmentCompetitionRequestcompetitionsScopeIdFulfillmentCompetitionIdGet: " + e.Message );
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
 **fulfillmentCompetitionId** | **string**| The fulfillment competition identifier. | 

### Return type

[**FulfillmentCompetition**](FulfillmentCompetition.md)

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
| **404** | Requested competition not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentexceptionsrequestexceptionsscopeidfulfillmentlocationidorderidget"></a>
# **GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGet**
> FulfillmentExceptionResult GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGet (string accept, string scopeId, string fulfillmentLocationId, string orderId)

Gets the fulfillment exceptions for an order at a fulfillment location - {GetFulfillmentExceptionsRequest}

Gets the fulfillment exceptions for an order at a fulfillment location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The fulfillment location identifier.
            var orderId = orderId_example;  // string | The order identifier.

            try
            {
                // Gets the fulfillment exceptions for an order at a fulfillment location - {GetFulfillmentExceptionsRequest}
                FulfillmentExceptionResult result = apiInstance.GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGet(accept, scopeId, fulfillmentLocationId, orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.GetFulfillmentExceptionsRequestexceptionsScopeIdFulfillmentLocationIdOrderIdGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| The fulfillment location identifier. | 
 **orderId** | **string**| The order identifier. | 

### Return type

[**FulfillmentExceptionResult**](FulfillmentExceptionResult.md)

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

<a name="getfulfillmentpackagerequestpackagesscopeididget"></a>
# **GetFulfillmentPackageRequestpackagesScopeIdIdGet**
> FulfillmentPackage GetFulfillmentPackageRequestpackagesScopeIdIdGet (string accept, string scopeId, string id, string cultureName = null, bool? includeFulfillmentPackageType = null)

Gets a fulfillment package by its identifier - {GetFulfillmentPackageRequest}

Gets a fulfillment package by its identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentPackageRequestpackagesScopeIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope id.
            var id = id_example;  // string | The fulfillment package identifier.
            var cultureName = cultureName_example;  // string | The culture name in which language the data for the fulfillment package type will be returned (optional) 
            var includeFulfillmentPackageType = true;  // bool? | A value indicating whether the fulfillment package type should be returns along the fulfillment package. (optional) 

            try
            {
                // Gets a fulfillment package by its identifier - {GetFulfillmentPackageRequest}
                FulfillmentPackage result = apiInstance.GetFulfillmentPackageRequestpackagesScopeIdIdGet(accept, scopeId, id, cultureName, includeFulfillmentPackageType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.GetFulfillmentPackageRequestpackagesScopeIdIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope id. | 
 **id** | **string**| The fulfillment package identifier. | 
 **cultureName** | **string**| The culture name in which language the data for the fulfillment package type will be returned | [optional] 
 **includeFulfillmentPackageType** | **bool?**| A value indicating whether the fulfillment package type should be returns along the fulfillment package. | [optional] 

### Return type

[**FulfillmentPackage**](FulfillmentPackage.md)

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
| **404** | Requested fulfillment package not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentpackagetyperequestpackagetypesscopeididget"></a>
# **GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGet**
> FulfillmentPackageType GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGet (string accept, string scopeId, string id, bool? includeParentScopes = null)

Gets a fulfillment package type by its identifier - {GetFulfillmentPackageTypeRequest}

Gets a fulfillment package type by its identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope id.
            var id = id_example;  // string | The fulfillment package type identifier.
            var includeParentScopes = true;  // bool? | Determine if parent scopes should be considered when searching fulfillment package type. (optional) 

            try
            {
                // Gets a fulfillment package type by its identifier - {GetFulfillmentPackageTypeRequest}
                FulfillmentPackageType result = apiInstance.GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGet(accept, scopeId, id, includeParentScopes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.GetFulfillmentPackageTypeRequestpackageTypesScopeIdIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope id. | 
 **id** | **string**| The fulfillment package type identifier. | 
 **includeParentScopes** | **bool?**| Determine if parent scopes should be considered when searching fulfillment package type. | [optional] 

### Return type

[**FulfillmentPackageType**](FulfillmentPackageType.md)

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

<a name="getfulfillmentslarequestslasscopeididget"></a>
# **GetFulfillmentSLARequestSLAsScopeIdIdGet**
> FulfillmentSLA GetFulfillmentSLARequestSLAsScopeIdIdGet (string accept, string scopeId, string id)

Gets a fulfillment SLA by its identifier - {GetFulfillmentSLARequest}

Gets a fulfillment SLA by its identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentSLARequestSLAsScopeIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope id.
            var id = id_example;  // string | The fulfillment SLA identifier.

            try
            {
                // Gets a fulfillment SLA by its identifier - {GetFulfillmentSLARequest}
                FulfillmentSLA result = apiInstance.GetFulfillmentSLARequestSLAsScopeIdIdGet(accept, scopeId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.GetFulfillmentSLARequestSLAsScopeIdIdGet: " + e.Message );
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
 **scopeId** | **string**| The scope id. | 
 **id** | **string**| The fulfillment SLA identifier. | 

### Return type

[**FulfillmentSLA**](FulfillmentSLA.md)

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
| **404** | Requested fulfillment SLA not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundfulfillmentcarrierquotesrequestcarriersscopeidfulfillmentcarrieridquotesrefundpost"></a>
# **RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPost**
> void RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPost (string accept, string scopeId, string fulfillmentCarrierId, RefundFulfillmentCarrierQuotesRequest body = null)

Refund shipping quotes from a carrier - {RefundFulfillmentCarrierQuotesRequest}

Refund shipping quotes from a carrier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var fulfillmentCarrierId = fulfillmentCarrierId_example;  // string | The fulfillment carrier identifier.
            var body = new RefundFulfillmentCarrierQuotesRequest(); // RefundFulfillmentCarrierQuotesRequest |  (optional) 

            try
            {
                // Refund shipping quotes from a carrier - {RefundFulfillmentCarrierQuotesRequest}
                apiInstance.RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPost(accept, scopeId, fulfillmentCarrierId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.RefundFulfillmentCarrierQuotesRequestcarriersScopeIdFulfillmentCarrierIdquotesrefundPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **fulfillmentCarrierId** | **string**| The fulfillment carrier identifier. | 
 **body** | [**RefundFulfillmentCarrierQuotesRequest**](RefundFulfillmentCarrierQuotesRequest.md)|  | [optional] 

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

<a name="removefulfillmentcompetitionlocationsrequestcompetitionsscopeidfulfillmentcompetitionidlocationsdelete"></a>
# **RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDelete**
> FulfillmentCompetition RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDelete (string accept, string scopeId, string fulfillmentCompetitionId, List<string> fulfillmentLocationIds = null)

Removes a list of fulfillment competition locations from a specific fulfillment competition - {RemoveFulfillmentCompetitionLocationsRequest}

Removes a list of fulfillment competition locations from a specific fulfillment competition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentCompetitionId = fulfillmentCompetitionId_example;  // string | The identifier of the fulfillment competition from which the fulfillment competition locations are removed.
            var fulfillmentLocationIds = new List<string>(); // List<string> | The list of the fulfillment location identifiers which will be removed from the fulfillment competition. (optional) 

            try
            {
                // Removes a list of fulfillment competition locations from a specific fulfillment competition - {RemoveFulfillmentCompetitionLocationsRequest}
                FulfillmentCompetition result = apiInstance.RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDelete(accept, scopeId, fulfillmentCompetitionId, fulfillmentLocationIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.RemoveFulfillmentCompetitionLocationsRequestcompetitionsScopeIdFulfillmentCompetitionIdlocationsDelete: " + e.Message );
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
 **fulfillmentCompetitionId** | **string**| The identifier of the fulfillment competition from which the fulfillment competition locations are removed. | 
 **fulfillmentLocationIds** | [**List&lt;string&gt;**](string.md)| The list of the fulfillment location identifiers which will be removed from the fulfillment competition. | [optional] 

### Return type

[**FulfillmentCompetition**](FulfillmentCompetition.md)

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

<a name="transferfulfillmentpackageitemsrequestpackagesscopeidtransferfulfillmentpackageitemspost"></a>
# **TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPost**
> FulfillmentPackage TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPost (string accept, string scopeId, TransferFulfillmentPackageItemsRequest body = null)

Transfers a list of fulfillment package items from one fulfillment package to another - {TransferFulfillmentPackageItemsRequest}

Transfers a list of fulfillment package items from one fulfillment package to another.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var body = new TransferFulfillmentPackageItemsRequest(); // TransferFulfillmentPackageItemsRequest |  (optional) 

            try
            {
                // Transfers a list of fulfillment package items from one fulfillment package to another - {TransferFulfillmentPackageItemsRequest}
                FulfillmentPackage result = apiInstance.TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.TransferFulfillmentPackageItemsRequestpackagesScopeIdtransferFulfillmentPackageItemsPost: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **body** | [**TransferFulfillmentPackageItemsRequest**](TransferFulfillmentPackageItemsRequest.md)|  | [optional] 

### Return type

[**FulfillmentPackage**](FulfillmentPackage.md)

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

<a name="updatefulfillmentpackagerequestpackagesscopeididcreate"></a>
# **UpdateFulfillmentPackageRequestpackagesScopeIdIdCreate**
> FulfillmentPackage UpdateFulfillmentPackageRequestpackagesScopeIdIdCreate (string accept, string scopeId, string id, UpdateFulfillmentPackageRequest body = null)

Updates a fulfillment package - {UpdateFulfillmentPackageRequest}

Updates a fulfillment package.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateFulfillmentPackageRequestpackagesScopeIdIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var id = id_example;  // string | The fulfillment package identifier.
            var body = new UpdateFulfillmentPackageRequest(); // UpdateFulfillmentPackageRequest |  (optional) 

            try
            {
                // Updates a fulfillment package - {UpdateFulfillmentPackageRequest}
                FulfillmentPackage result = apiInstance.UpdateFulfillmentPackageRequestpackagesScopeIdIdCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.UpdateFulfillmentPackageRequestpackagesScopeIdIdCreate: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **id** | **string**| The fulfillment package identifier. | 
 **body** | [**UpdateFulfillmentPackageRequest**](UpdateFulfillmentPackageRequest.md)|  | [optional] 

### Return type

[**FulfillmentPackage**](FulfillmentPackage.md)

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

<a name="updatefulfillmentpackagetyperequestpackagetypesscopeididcreate"></a>
# **UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreate**
> FulfillmentPackageType UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreate (string accept, string scopeId, string id, UpdateFulfillmentPackageTypeRequest body = null)

Updates a fulfillment package type - {UpdateFulfillmentPackageTypeRequest}

Updates a fulfillment package type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope identifier.
            var id = id_example;  // string | The fulfillment package type identifier.
            var body = new UpdateFulfillmentPackageTypeRequest(); // UpdateFulfillmentPackageTypeRequest |  (optional) 

            try
            {
                // Updates a fulfillment package type - {UpdateFulfillmentPackageTypeRequest}
                FulfillmentPackageType result = apiInstance.UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentsApi.UpdateFulfillmentPackageTypeRequestpackageTypesScopeIdIdCreate: " + e.Message );
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
 **scopeId** | **string**| The scope identifier. | 
 **id** | **string**| The fulfillment package type identifier. | 
 **body** | [**UpdateFulfillmentPackageTypeRequest**](UpdateFulfillmentPackageTypeRequest.md)|  | [optional] 

### Return type

[**FulfillmentPackageType**](FulfillmentPackageType.md)

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

