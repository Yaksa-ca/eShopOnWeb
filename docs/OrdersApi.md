# Yaksa.OrckestraCommerce.Client.Api.OrdersApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderHistoryRequestScopeIdorderhistoryPost**](OrdersApi.md#addorderhistoryrequestscopeidorderhistorypost) | **POST** /orders/{ScopeId}/orderhistory | Add new history item related to specified order - {AddOrderHistoryRequest}
[**AddOrderNoteRequestScopeIdOrderIdnotesPost**](OrdersApi.md#addordernoterequestscopeidorderidnotespost) | **POST** /orders/{ScopeId}/{OrderId}/notes | Add a note to an order - {AddOrderNoteRequest}
[**AddShipmentFulfillmentMessagesRequestScopeIdOrderIdshipmentsShipmentIdstatemessagesPost**](OrdersApi.md#addshipmentfulfillmentmessagesrequestscopeidorderidshipmentsshipmentidstatemessagespost) | **POST** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/state/messages | Return the fulfillment state of an order and each of its shipments - {AddShipmentFulfillmentMessagesRequest}
[**AddShipmentNoteRequestScopeIdOrderIdshipmentsShipmentIdnotesPost**](OrdersApi.md#addshipmentnoterequestscopeidorderidshipmentsshipmentidnotespost) | **POST** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/notes | Add a note to an order shipment - {AddShipmentNoteRequest}
[**ChangeOrderStatusRequestScopeIdOrderIdfulfillmentStatePost**](OrdersApi.md#changeorderstatusrequestscopeidorderidfulfillmentstatepost) | **POST** /orders/{ScopeId}/{OrderId}/fulfillmentState | Request that all shipments statuses be transitioned from their current status to the submitted status. - {ChangeOrderStatusRequest}
[**ChangeShipmentStatusRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatePost**](OrdersApi.md#changeshipmentstatusrequestscopeidorderidshipmentsshipmentidfulfillmentstatepost) | **POST** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/fulfillmentState | Request that a shipment status be transitioned from its current status to the submitted status. - {ChangeShipmentStatusRequest}
[**CopyCartFromOrderRequestScopeIdOrderIdcopycartPost**](OrdersApi.md#copycartfromorderrequestscopeidorderidcopycartpost) | **POST** /orders/{ScopeId}/{OrderId}/copycart | Copy cart from an existing order - {CopyCartFromOrderRequest}
[**CopyOrderRequestScopeIdOrderIdcopyPost**](OrdersApi.md#copyorderrequestscopeidorderidcopypost) | **POST** /orders/{ScopeId}/{OrderId}/copy | Copy an order - {CopyOrderRequest}
[**CreateOrderRequestPost**](OrdersApi.md#createorderrequestpost) | **POST** /orders | Create a new order from a cart - {CreateOrderRequest}
[**CreateRmaGuestRequestRMAScopeIdOrderNumberGuestPost**](OrdersApi.md#creatermaguestrequestrmascopeidordernumberguestpost) | **POST** /orders/RMA/{ScopeId}/{OrderNumber}/Guest | Create RMA Guest - {CreateRmaGuestRequest}
[**CreateRmaRegisteredRequestRMAScopeIdOrderNumberCustomerIdRegisteredPost**](OrdersApi.md#creatermaregisteredrequestrmascopeidordernumbercustomeridregisteredpost) | **POST** /orders/RMA/{ScopeId}/{OrderNumber}/{CustomerId}/Registered | Create RMA registered customer - {CreateRmaRegisteredRequest}
[**CreateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNamePost**](OrdersApi.md#createshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnamepost) | **POST** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/documents/{Name} | Create a shipment document. - {CreateShipmentDocumentRequest}
[**DeleteShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameDelete**](OrdersApi.md#deleteshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnamedelete) | **DELETE** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/documents/{Name} | Delete a shipment document. - {DeleteShipmentDocumentRequest}
[**FindOrdersCountRequestScopeIdcountPost**](OrdersApi.md#findorderscountrequestscopeidcountpost) | **POST** /orders/{ScopeId}/count | Return to number of orders matching the search criteria - {FindOrdersCountRequest}
[**FindOrdersRequestScopeIdfindPost**](OrdersApi.md#findordersrequestscopeidfindpost) | **POST** /orders/{ScopeId}/find | Search for orders - {FindOrdersRequest}
[**FindShipmentDocumentsRequestScopeIdshipmentsdocumentsfindPost**](OrdersApi.md#findshipmentdocumentsrequestscopeidshipmentsdocumentsfindpost) | **POST** /orders/{ScopeId}/shipments/documents/find | Retrieve shipment documents - {FindShipmentDocumentsRequest}
[**FindShipmentDocumentsSummariesRequestScopeIdshipmentsdocumentssummariesfindPost**](OrdersApi.md#findshipmentdocumentssummariesrequestscopeidshipmentsdocumentssummariesfindpost) | **POST** /orders/{ScopeId}/shipments/documents/summaries/find | Retrieve shipment documents summaries - {FindShipmentDocumentsSummariesRequest}
[**GetAvailableTaxProvidersRequestavailableTaxProvidersGet**](OrdersApi.md#getavailabletaxprovidersrequestavailabletaxprovidersget) | **GET** /orders/availableTaxProviders | Retrieve all the tax providers available in the system - {GetAvailableTaxProvidersRequest}
[**GetCustomerLastOrderRequestScopeIdCustomerIdlastOrderGet**](OrdersApi.md#getcustomerlastorderrequestscopeidcustomeridlastorderget) | **GET** /orders/{ScopeId}/{CustomerId}/lastOrder | Get customer last order - {GetCustomerLastOrderRequest}
[**GetOrderByIdRequestScopeIdOrderIdGet**](OrdersApi.md#getorderbyidrequestscopeidorderidget) | **GET** /orders/{ScopeId}/{OrderId} | Retrieve an order - {GetOrderByIdRequest}
[**GetOrderByNumberRequestScopeIdbyNumberOrderNumberGet**](OrdersApi.md#getorderbynumberrequestscopeidbynumberordernumberget) | **GET** /orders/{ScopeId}/byNumber/{OrderNumber} | Retrieve an order - {GetOrderByNumberRequest}
[**GetOrderFulfillmentStateRequestScopeIdOrderIdfulfillmentStateGet**](OrdersApi.md#getorderfulfillmentstaterequestscopeidorderidfulfillmentstateget) | **GET** /orders/{ScopeId}/{OrderId}/fulfillmentState | Retrieve the fulfillment state of an order and each of its shipments - {GetOrderFulfillmentStateRequest}
[**GetOrderHistoryRequestScopeIdorderhistoryGet**](OrdersApi.md#getorderhistoryrequestscopeidorderhistoryget) | **GET** /orders/{ScopeId}/orderhistory | Get history items related to specified order - {GetOrderHistoryRequest}
[**GetOrderNotesRequestScopeIdOrderIdnotesGet**](OrdersApi.md#getordernotesrequestscopeidorderidnotesget) | **GET** /orders/{ScopeId}/{OrderId}/notes | Get order notes - {GetOrderNotesRequest}
[**GetOrderSettingsRequestsettingsGet**](OrdersApi.md#getordersettingsrequestsettingsget) | **GET** /orders/settings | Get the order settings - {GetOrderSettingsRequest}
[**GetPrintableOrderUriRequestScopeIdOrderIdprinturiGet**](OrdersApi.md#getprintableorderurirequestscopeidorderidprinturiget) | **GET** /orders/{ScopeId}/{OrderId}/printuri | Get the uri of printable version of the order - {GetPrintableOrderUriRequest}
[**GetPrintableOrdersUriRequestScopeIdprintOrdersPost**](OrdersApi.md#getprintableordersurirequestscopeidprintorderspost) | **POST** /orders/{ScopeId}/printOrders | Get the uri of printable version of a list of order - {GetPrintableOrdersUriRequest}
[**GetRmaRequestRMAScopeIdOrderNumberRmaNumberGet**](OrdersApi.md#getrmarequestrmascopeidordernumberrmanumberget) | **GET** /orders/RMA/{ScopeId}/{OrderNumber}/{RmaNumber} | Retrieves RMA and items - {GetRmaRequest}
[**GetRmasByOrderRequestRMAScopeIdOrderNumberGet**](OrdersApi.md#getrmasbyorderrequestrmascopeidordernumberget) | **GET** /orders/RMA/{ScopeId}/{OrderNumber} | Retrieves all RMAs for an order - {GetRmasByOrderRequest}
[**GetShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameGet**](OrdersApi.md#getshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnameget) | **GET** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/documents/{Name} | Retrieve a shipment document - {GetShipmentDocumentRequest}
[**GetShipmentNotesRequestScopeIdShipmentIdshipmentnotesGet**](OrdersApi.md#getshipmentnotesrequestscopeidshipmentidshipmentnotesget) | **GET** /orders/{ScopeId}/{ShipmentId}/shipment/notes | Get shipment notes - {GetShipmentNotesRequest}
[**GetTaxCategoriesRequesttaxCategoriesGet**](OrdersApi.md#gettaxcategoriesrequesttaxcategoriesget) | **GET** /orders/taxCategories | Retrieve the list of tax categories in the system - {GetTaxCategoriesRequest}
[**GetTaxProviderByScopeRequesttaxProviderByScopeGet**](OrdersApi.md#gettaxproviderbyscoperequesttaxproviderbyscopeget) | **GET** /orders/taxProviderByScope | Retrieve the tax provider for a scope - {GetTaxProviderByScopeRequest}
[**PostProcessOrderRequestScopeIdOrderIdpostProcessPost**](OrdersApi.md#postprocessorderrequestscopeidorderidpostprocesspost) | **POST** /orders/{ScopeId}/{OrderId}/postProcess | Queue a post processing task for a given order - {PostProcessOrderRequest}
[**RefreshPaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdrefreshPost**](OrdersApi.md#refreshpaymentorderrequestscopeidorderidpaymentspaymentidrefreshpost) | **POST** /orders/{ScopeId}/{OrderId}/payments/{PaymentId}/refresh | Refresh the payment of an order - {RefreshPaymentOrderRequest}
[**RefundPaymentRequestScopeIdOrderIdpaymentsPaymentIdrefundPost**](OrdersApi.md#refundpaymentrequestscopeidorderidpaymentspaymentidrefundpost) | **POST** /orders/{ScopeId}/{OrderId}/payments/{PaymentId}/refund | Refund the payment of an order - {RefundPaymentRequest}
[**RenderOrderShipmentTemplateRequestScopeIdOrderIdshipmentsShipmentIdrenderTemplateGet**](OrdersApi.md#renderordershipmenttemplaterequestscopeidorderidshipmentsshipmentidrendertemplateget) | **GET** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/renderTemplate | Render a shipment&#39;s template. - {RenderOrderShipmentTemplateRequest}
[**ReportShipmentFulfillmentFailureRequestScopeIdOrderIdshipmentsShipmentIdstatefailurePost**](OrdersApi.md#reportshipmentfulfillmentfailurerequestscopeidorderidshipmentsshipmentidstatefailurepost) | **POST** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/state/failure | Sets the state of a shipment to failed and halts all further processing - {ReportShipmentFulfillmentFailureRequest}
[**RestartShipmentFulfillmentProcessingRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStaterestartTaskPost**](OrdersApi.md#restartshipmentfulfillmentprocessingrequestscopeidorderidshipmentsshipmentidfulfillmentstaterestarttaskpost) | **POST** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/fulfillmentState/restartTask | Restart the processing of a fulfillment after a failure - {RestartShipmentFulfillmentProcessingRequest}
[**ResumeOrderRequestScopeIdOrderIdresumePost**](OrdersApi.md#resumeorderrequestscopeidorderidresumepost) | **POST** /orders/{ScopeId}/{OrderId}/resume | Resume the order which was on hold - {ResumeOrderRequest}
[**SaveOrderRequestScopeIdOrderIdPost**](OrdersApi.md#saveorderrequestscopeidorderidpost) | **POST** /orders/{ScopeId}/{OrderId} | Used to update an existing order based on the provided Order. - {SaveOrderRequest}
[**SetAdjustmentOrderRequestScopeIdOrderIdshipmentsShipmentIdadjustmentCreate**](OrdersApi.md#setadjustmentorderrequestscopeidorderidshipmentsshipmentidadjustmentcreate) | **PUT** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/adjustment | Set the adjustment of a shipment - {SetAdjustmentOrderRequest}
[**SettlePaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdsettlePost**](OrdersApi.md#settlepaymentorderrequestscopeidorderidpaymentspaymentidsettlepost) | **POST** /orders/{ScopeId}/{OrderId}/payments/{PaymentId}/settle | Settle the payment of an order - {SettlePaymentOrderRequest}
[**ShipmentSplitRequestScopeIdOrderIdshipmentsShipmentIdsplitCreate**](OrdersApi.md#shipmentsplitrequestscopeidorderidshipmentsshipmentidsplitcreate) | **PUT** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/split | Splits a shipment and queues post processing on the new shipment - {ShipmentSplitRequest}
[**StartNewShipmentFulfillmentWorkflowRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatestartNewWorkflowPost**](OrdersApi.md#startnewshipmentfulfillmentworkflowrequestscopeidorderidshipmentsshipmentidfulfillmentstatestartnewworkflowpost) | **POST** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/fulfillmentState/startNewWorkflow | Start the workflow of a fulfillment from the beginning - {StartNewShipmentFulfillmentWorkflowRequest}
[**UpdateRmaRequestRMAScopeIdOrderNumberRmaNumberCreate**](OrdersApi.md#updatermarequestrmascopeidordernumberrmanumbercreate) | **PUT** /orders/RMA/{ScopeId}/{OrderNumber}/{RmaNumber} | Update RMA and items - {UpdateRmaRequest}
[**UpdateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameCreate**](OrdersApi.md#updateshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnamecreate) | **PUT** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/documents/{Name} | Update a shipment document. - {UpdateShipmentDocumentRequest}
[**UpdateShipmentFulfillmentStateRequestScopeIdOrderIdshipmentsShipmentIdstateCreate**](OrdersApi.md#updateshipmentfulfillmentstaterequestscopeidorderidshipmentsshipmentidstatecreate) | **PUT** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/state | Update the current state of a shipment - {UpdateShipmentFulfillmentStateRequest}
[**UpdateShipmentFulfillmentWorkflowXamlPathRequestScopeIdOrderIdshipmentsShipmentIdWorkflowXamlPathCreate**](OrdersApi.md#updateshipmentfulfillmentworkflowxamlpathrequestscopeidorderidshipmentsshipmentidworkflowxamlpathcreate) | **PUT** /orders/{ScopeId}/{OrderId}/shipments/{ShipmentId}/WorkflowXamlPath | Update the path of the fulfillment workflow of a shipment. - {UpdateShipmentFulfillmentWorkflowXamlPathRequest}


<a name="addorderhistoryrequestscopeidorderhistorypost"></a>
# **AddOrderHistoryRequestScopeIdorderhistoryPost**
> void AddOrderHistoryRequestScopeIdorderhistoryPost (string accept, string scopeId, AddOrderHistoryRequest body = null)

Add new history item related to specified order - {AddOrderHistoryRequest}

Add history item related to a specified order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrderHistoryRequestScopeIdorderhistoryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new AddOrderHistoryRequest(); // AddOrderHistoryRequest |  (optional) 

            try
            {
                // Add new history item related to specified order - {AddOrderHistoryRequest}
                apiInstance.AddOrderHistoryRequestScopeIdorderhistoryPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.AddOrderHistoryRequestScopeIdorderhistoryPost: " + e.Message );
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
 **body** | [**AddOrderHistoryRequest**](AddOrderHistoryRequest.md)|  | [optional] 

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

<a name="addordernoterequestscopeidorderidnotespost"></a>
# **AddOrderNoteRequestScopeIdOrderIdnotesPost**
> void AddOrderNoteRequestScopeIdOrderIdnotesPost (string accept, string scopeId, string orderId, AddOrderNoteRequest body = null)

Add a note to an order - {AddOrderNoteRequest}

Add a note to an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrderNoteRequestScopeIdOrderIdnotesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The parent id of the note.
            var body = new AddOrderNoteRequest(); // AddOrderNoteRequest |  (optional) 

            try
            {
                // Add a note to an order - {AddOrderNoteRequest}
                apiInstance.AddOrderNoteRequestScopeIdOrderIdnotesPost(accept, scopeId, orderId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.AddOrderNoteRequestScopeIdOrderIdnotesPost: " + e.Message );
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
 **orderId** | **string**| The parent id of the note. | 
 **body** | [**AddOrderNoteRequest**](AddOrderNoteRequest.md)|  | [optional] 

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

<a name="addshipmentfulfillmentmessagesrequestscopeidorderidshipmentsshipmentidstatemessagespost"></a>
# **AddShipmentFulfillmentMessagesRequestScopeIdOrderIdshipmentsShipmentIdstatemessagesPost**
> OrderFulfillmentState AddShipmentFulfillmentMessagesRequestScopeIdOrderIdshipmentsShipmentIdstatemessagesPost (string accept, string scopeId, string orderId, string shipmentId, AddShipmentFulfillmentMessagesRequest body = null)

Return the fulfillment state of an order and each of its shipments - {AddShipmentFulfillmentMessagesRequest}

Update the ExecutionMessages and ValidationResults of a ShipmentFulfillmentState.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddShipmentFulfillmentMessagesRequestScopeIdOrderIdshipmentsShipmentIdstatemessagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | the unique system order identifier.
            var shipmentId = shipmentId_example;  // string | the unique system shipment identifier.
            var body = new AddShipmentFulfillmentMessagesRequest(); // AddShipmentFulfillmentMessagesRequest |  (optional) 

            try
            {
                // Return the fulfillment state of an order and each of its shipments - {AddShipmentFulfillmentMessagesRequest}
                OrderFulfillmentState result = apiInstance.AddShipmentFulfillmentMessagesRequestScopeIdOrderIdshipmentsShipmentIdstatemessagesPost(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.AddShipmentFulfillmentMessagesRequestScopeIdOrderIdshipmentsShipmentIdstatemessagesPost: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| the unique system order identifier. | 
 **shipmentId** | **string**| the unique system shipment identifier. | 
 **body** | [**AddShipmentFulfillmentMessagesRequest**](AddShipmentFulfillmentMessagesRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="addshipmentnoterequestscopeidorderidshipmentsshipmentidnotespost"></a>
# **AddShipmentNoteRequestScopeIdOrderIdshipmentsShipmentIdnotesPost**
> void AddShipmentNoteRequestScopeIdOrderIdshipmentsShipmentIdnotesPost (string accept, string scopeId, string orderId, string shipmentId, AddShipmentNoteRequest body = null)

Add a note to an order shipment - {AddShipmentNoteRequest}

Add a note to an order shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddShipmentNoteRequestScopeIdOrderIdshipmentsShipmentIdnotesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order identifier.
            var shipmentId = shipmentId_example;  // string | The shipment identifier.
            var body = new AddShipmentNoteRequest(); // AddShipmentNoteRequest |  (optional) 

            try
            {
                // Add a note to an order shipment - {AddShipmentNoteRequest}
                apiInstance.AddShipmentNoteRequestScopeIdOrderIdshipmentsShipmentIdnotesPost(accept, scopeId, orderId, shipmentId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.AddShipmentNoteRequestScopeIdOrderIdshipmentsShipmentIdnotesPost: " + e.Message );
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
 **orderId** | **string**| The order identifier. | 
 **shipmentId** | **string**| The shipment identifier. | 
 **body** | [**AddShipmentNoteRequest**](AddShipmentNoteRequest.md)|  | [optional] 

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

<a name="changeorderstatusrequestscopeidorderidfulfillmentstatepost"></a>
# **ChangeOrderStatusRequestScopeIdOrderIdfulfillmentStatePost**
> OrderFulfillmentState ChangeOrderStatusRequestScopeIdOrderIdfulfillmentStatePost (string accept, string scopeId, string orderId, ChangeOrderStatusRequest body = null)

Request that all shipments statuses be transitioned from their current status to the submitted status. - {ChangeOrderStatusRequest}

Request that the status of all shipments be transitioned from their current status to the given status. This request issues a request to resume the long running fulfillment workflow of each shipment and transition them to the given state.If all transitions succeed the order status will be updated

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ChangeOrderStatusRequestScopeIdOrderIdfulfillmentStatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The unique system identifier for the order
            var body = new ChangeOrderStatusRequest(); // ChangeOrderStatusRequest |  (optional) 

            try
            {
                // Request that all shipments statuses be transitioned from their current status to the submitted status. - {ChangeOrderStatusRequest}
                OrderFulfillmentState result = apiInstance.ChangeOrderStatusRequestScopeIdOrderIdfulfillmentStatePost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ChangeOrderStatusRequestScopeIdOrderIdfulfillmentStatePost: " + e.Message );
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
 **orderId** | **string**| The unique system identifier for the order | 
 **body** | [**ChangeOrderStatusRequest**](ChangeOrderStatusRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="changeshipmentstatusrequestscopeidorderidshipmentsshipmentidfulfillmentstatepost"></a>
# **ChangeShipmentStatusRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatePost**
> OrderFulfillmentState ChangeShipmentStatusRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatePost (string accept, string scopeId, string orderId, string shipmentId, ChangeShipmentStatusRequest body = null)

Request that a shipment status be transitioned from its current status to the submitted status. - {ChangeShipmentStatusRequest}

Request that a shipment status be transitioned from its current status to the submitted status. This request will issue a request to resume the long running fulfillment workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ChangeShipmentStatusRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The unique system identifier for the order
            var shipmentId = shipmentId_example;  // string | The unique shipment identifier
            var body = new ChangeShipmentStatusRequest(); // ChangeShipmentStatusRequest |  (optional) 

            try
            {
                // Request that a shipment status be transitioned from its current status to the submitted status. - {ChangeShipmentStatusRequest}
                OrderFulfillmentState result = apiInstance.ChangeShipmentStatusRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatePost(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ChangeShipmentStatusRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatePost: " + e.Message );
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
 **orderId** | **string**| The unique system identifier for the order | 
 **shipmentId** | **string**| The unique shipment identifier | 
 **body** | [**ChangeShipmentStatusRequest**](ChangeShipmentStatusRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="copycartfromorderrequestscopeidorderidcopycartpost"></a>
# **CopyCartFromOrderRequestScopeIdOrderIdcopycartPost**
> Cart CopyCartFromOrderRequestScopeIdOrderIdcopycartPost (string accept, string scopeId, string orderId, CopyCartFromOrderRequest body = null)

Copy cart from an existing order - {CopyCartFromOrderRequest}

Copy a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CopyCartFromOrderRequestScopeIdOrderIdcopycartPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The unique identifier of the order to be used for copy.
            var body = new CopyCartFromOrderRequest(); // CopyCartFromOrderRequest |  (optional) 

            try
            {
                // Copy cart from an existing order - {CopyCartFromOrderRequest}
                Cart result = apiInstance.CopyCartFromOrderRequestScopeIdOrderIdcopycartPost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CopyCartFromOrderRequestScopeIdOrderIdcopycartPost: " + e.Message );
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
 **orderId** | **string**| The unique identifier of the order to be used for copy. | 
 **body** | [**CopyCartFromOrderRequest**](CopyCartFromOrderRequest.md)|  | [optional] 

### Return type

[**Cart**](Cart.md)

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

<a name="copyorderrequestscopeidorderidcopypost"></a>
# **CopyOrderRequestScopeIdOrderIdcopyPost**
> Cart CopyOrderRequestScopeIdOrderIdcopyPost (string accept, string scopeId, string orderId, Object body = null)

Copy an order - {CopyOrderRequest}

Copy an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CopyOrderRequestScopeIdOrderIdcopyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The unique identifier of the order to be copied.
            var body = ;  // Object |  (optional) 

            try
            {
                // Copy an order - {CopyOrderRequest}
                Cart result = apiInstance.CopyOrderRequestScopeIdOrderIdcopyPost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CopyOrderRequestScopeIdOrderIdcopyPost: " + e.Message );
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
 **orderId** | **string**| The unique identifier of the order to be copied. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Cart**](Cart.md)

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

<a name="createorderrequestpost"></a>
# **CreateOrderRequestPost**
> Order CreateOrderRequestPost (string accept, CreateOrderRequest body = null)

Create a new order from a cart - {CreateOrderRequest}

Create a new order from a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateOrderRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new CreateOrderRequest(); // CreateOrderRequest |  (optional) 

            try
            {
                // Create a new order from a cart - {CreateOrderRequest}
                Order result = apiInstance.CreateOrderRequestPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrderRequestPost: " + e.Message );
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
 **body** | [**CreateOrderRequest**](CreateOrderRequest.md)|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="creatermaguestrequestrmascopeidordernumberguestpost"></a>
# **CreateRmaGuestRequestRMAScopeIdOrderNumberGuestPost**
> RmaRequestResult CreateRmaGuestRequestRMAScopeIdOrderNumberGuestPost (string accept, string scopeId, string orderNumber, CreateRmaGuestRequest body = null)

Create RMA Guest - {CreateRmaGuestRequest}

Create an RMA for a Guest or Unregistered customer. You must fill at least one of the 'Postal Code', 'Last name', or 'Email' fields. The specified field(s) will be used for validation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateRmaGuestRequestRMAScopeIdOrderNumberGuestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderNumber = orderNumber_example;  // string | The Order Number related to the RMA
            var body = new CreateRmaGuestRequest(); // CreateRmaGuestRequest |  (optional) 

            try
            {
                // Create RMA Guest - {CreateRmaGuestRequest}
                RmaRequestResult result = apiInstance.CreateRmaGuestRequestRMAScopeIdOrderNumberGuestPost(accept, scopeId, orderNumber, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateRmaGuestRequestRMAScopeIdOrderNumberGuestPost: " + e.Message );
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
 **orderNumber** | **string**| The Order Number related to the RMA | 
 **body** | [**CreateRmaGuestRequest**](CreateRmaGuestRequest.md)|  | [optional] 

### Return type

[**RmaRequestResult**](RmaRequestResult.md)

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

<a name="creatermaregisteredrequestrmascopeidordernumbercustomeridregisteredpost"></a>
# **CreateRmaRegisteredRequestRMAScopeIdOrderNumberCustomerIdRegisteredPost**
> RmaRequestResult CreateRmaRegisteredRequestRMAScopeIdOrderNumberCustomerIdRegisteredPost (string accept, string scopeId, string orderNumber, string customerId, CreateRmaRegisteredRequest body = null)

Create RMA registered customer - {CreateRmaRegisteredRequest}

Create an RMA for a registered customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateRmaRegisteredRequestRMAScopeIdOrderNumberCustomerIdRegisteredPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderNumber = orderNumber_example;  // string | The Order Number related to the RMA
            var customerId = customerId_example;  // string | the Identifier of the Customer who owns the RMA
            var body = new CreateRmaRegisteredRequest(); // CreateRmaRegisteredRequest |  (optional) 

            try
            {
                // Create RMA registered customer - {CreateRmaRegisteredRequest}
                RmaRequestResult result = apiInstance.CreateRmaRegisteredRequestRMAScopeIdOrderNumberCustomerIdRegisteredPost(accept, scopeId, orderNumber, customerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateRmaRegisteredRequestRMAScopeIdOrderNumberCustomerIdRegisteredPost: " + e.Message );
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
 **orderNumber** | **string**| The Order Number related to the RMA | 
 **customerId** | **string**| the Identifier of the Customer who owns the RMA | 
 **body** | [**CreateRmaRegisteredRequest**](CreateRmaRegisteredRequest.md)|  | [optional] 

### Return type

[**RmaRequestResult**](RmaRequestResult.md)

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

<a name="createshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnamepost"></a>
# **CreateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNamePost**
> ShipmentDocument CreateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNamePost (string accept, string scopeId, string orderId, string shipmentId, string name, CreateShipmentDocumentRequest body = null)

Create a shipment document. - {CreateShipmentDocumentRequest}

Create a shipment document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order id.
            var shipmentId = shipmentId_example;  // string | The shipment id.
            var name = name_example;  // string | The name of the document.
            var body = new CreateShipmentDocumentRequest(); // CreateShipmentDocumentRequest |  (optional) 

            try
            {
                // Create a shipment document. - {CreateShipmentDocumentRequest}
                ShipmentDocument result = apiInstance.CreateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNamePost(accept, scopeId, orderId, shipmentId, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNamePost: " + e.Message );
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
 **orderId** | **string**| The order id. | 
 **shipmentId** | **string**| The shipment id. | 
 **name** | **string**| The name of the document. | 
 **body** | [**CreateShipmentDocumentRequest**](CreateShipmentDocumentRequest.md)|  | [optional] 

### Return type

[**ShipmentDocument**](ShipmentDocument.md)

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

<a name="deleteshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnamedelete"></a>
# **DeleteShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameDelete**
> ShipmentDocument DeleteShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameDelete (string accept, string scopeId, string orderId, string shipmentId, string name)

Delete a shipment document. - {DeleteShipmentDocumentRequest}

Delete a shipment document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order id.
            var shipmentId = shipmentId_example;  // string | The shipment id.
            var name = name_example;  // string | The shipment document name.

            try
            {
                // Delete a shipment document. - {DeleteShipmentDocumentRequest}
                ShipmentDocument result = apiInstance.DeleteShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameDelete(accept, scopeId, orderId, shipmentId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.DeleteShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameDelete: " + e.Message );
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
 **orderId** | **string**| The order id. | 
 **shipmentId** | **string**| The shipment id. | 
 **name** | **string**| The shipment document name. | 

### Return type

[**ShipmentDocument**](ShipmentDocument.md)

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

<a name="findorderscountrequestscopeidcountpost"></a>
# **FindOrdersCountRequestScopeIdcountPost**
> QueryCountResult FindOrdersCountRequestScopeIdcountPost (string accept, string scopeId, FindOrdersCountRequest body = null)

Return to number of orders matching the search criteria - {FindOrdersCountRequest}

Return to number of orders matching the search criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindOrdersCountRequestScopeIdcountPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindOrdersCountRequest(); // FindOrdersCountRequest |  (optional) 

            try
            {
                // Return to number of orders matching the search criteria - {FindOrdersCountRequest}
                QueryCountResult result = apiInstance.FindOrdersCountRequestScopeIdcountPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.FindOrdersCountRequestScopeIdcountPost: " + e.Message );
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
 **body** | [**FindOrdersCountRequest**](FindOrdersCountRequest.md)|  | [optional] 

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

<a name="findordersrequestscopeidfindpost"></a>
# **FindOrdersRequestScopeIdfindPost**
> OrderQueryResult FindOrdersRequestScopeIdfindPost (string accept, string scopeId, FindOrdersRequest body = null)

Search for orders - {FindOrdersRequest}

Search for orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindOrdersRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindOrdersRequest(); // FindOrdersRequest |  (optional) 

            try
            {
                // Search for orders - {FindOrdersRequest}
                OrderQueryResult result = apiInstance.FindOrdersRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.FindOrdersRequestScopeIdfindPost: " + e.Message );
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
 **body** | [**FindOrdersRequest**](FindOrdersRequest.md)|  | [optional] 

### Return type

[**OrderQueryResult**](OrderQueryResult.md)

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

<a name="findshipmentdocumentsrequestscopeidshipmentsdocumentsfindpost"></a>
# **FindShipmentDocumentsRequestScopeIdshipmentsdocumentsfindPost**
> ShipmentDocumentQueryResult FindShipmentDocumentsRequestScopeIdshipmentsdocumentsfindPost (string accept, string scopeId, FindShipmentDocumentsRequest body = null)

Retrieve shipment documents - {FindShipmentDocumentsRequest}

Retrieve shipment documents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindShipmentDocumentsRequestScopeIdshipmentsdocumentsfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindShipmentDocumentsRequest(); // FindShipmentDocumentsRequest |  (optional) 

            try
            {
                // Retrieve shipment documents - {FindShipmentDocumentsRequest}
                ShipmentDocumentQueryResult result = apiInstance.FindShipmentDocumentsRequestScopeIdshipmentsdocumentsfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.FindShipmentDocumentsRequestScopeIdshipmentsdocumentsfindPost: " + e.Message );
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
 **body** | [**FindShipmentDocumentsRequest**](FindShipmentDocumentsRequest.md)|  | [optional] 

### Return type

[**ShipmentDocumentQueryResult**](ShipmentDocumentQueryResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Documents not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findshipmentdocumentssummariesrequestscopeidshipmentsdocumentssummariesfindpost"></a>
# **FindShipmentDocumentsSummariesRequestScopeIdshipmentsdocumentssummariesfindPost**
> ShipmentDocumentSummaryQueryResult FindShipmentDocumentsSummariesRequestScopeIdshipmentsdocumentssummariesfindPost (string accept, string scopeId, FindShipmentDocumentsSummariesRequest body = null)

Retrieve shipment documents summaries - {FindShipmentDocumentsSummariesRequest}

Retrieve shipment documents summaries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindShipmentDocumentsSummariesRequestScopeIdshipmentsdocumentssummariesfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new FindShipmentDocumentsSummariesRequest(); // FindShipmentDocumentsSummariesRequest |  (optional) 

            try
            {
                // Retrieve shipment documents summaries - {FindShipmentDocumentsSummariesRequest}
                ShipmentDocumentSummaryQueryResult result = apiInstance.FindShipmentDocumentsSummariesRequestScopeIdshipmentsdocumentssummariesfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.FindShipmentDocumentsSummariesRequestScopeIdshipmentsdocumentssummariesfindPost: " + e.Message );
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
 **body** | [**FindShipmentDocumentsSummariesRequest**](FindShipmentDocumentsSummariesRequest.md)|  | [optional] 

### Return type

[**ShipmentDocumentSummaryQueryResult**](ShipmentDocumentSummaryQueryResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Documents not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailabletaxprovidersrequestavailabletaxprovidersget"></a>
# **GetAvailableTaxProvidersRequestavailableTaxProvidersGet**
> List&lt;TaxProviderDetails&gt; GetAvailableTaxProvidersRequestavailableTaxProvidersGet (string accept, string cultureName = null)

Retrieve all the tax providers available in the system - {GetAvailableTaxProvidersRequest}

Retrieve all the tax providers available in the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAvailableTaxProvidersRequestavailableTaxProvidersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language that data will be returned (optional) 

            try
            {
                // Retrieve all the tax providers available in the system - {GetAvailableTaxProvidersRequest}
                List<TaxProviderDetails> result = apiInstance.GetAvailableTaxProvidersRequestavailableTaxProvidersGet(accept, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetAvailableTaxProvidersRequestavailableTaxProvidersGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language that data will be returned | [optional] 

### Return type

[**List&lt;TaxProviderDetails&gt;**](TaxProviderDetails.md)

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

<a name="getcustomerlastorderrequestscopeidcustomeridlastorderget"></a>
# **GetCustomerLastOrderRequestScopeIdCustomerIdlastOrderGet**
> Order GetCustomerLastOrderRequestScopeIdCustomerIdlastOrderGet (string accept, string scopeId, string customerId)

Get customer last order - {GetCustomerLastOrderRequest}

Get customer last order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCustomerLastOrderRequestScopeIdCustomerIdlastOrderGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer to retrieve last order from.

            try
            {
                // Get customer last order - {GetCustomerLastOrderRequest}
                Order result = apiInstance.GetCustomerLastOrderRequestScopeIdCustomerIdlastOrderGet(accept, scopeId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetCustomerLastOrderRequestScopeIdCustomerIdlastOrderGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer to retrieve last order from. | 

### Return type

[**Order**](Order.md)

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

<a name="getorderbyidrequestscopeidorderidget"></a>
# **GetOrderByIdRequestScopeIdOrderIdGet**
> Order GetOrderByIdRequestScopeIdOrderIdGet (string accept, string scopeId, string orderId, bool? includeLineItems = null, bool? includeShipment = null, bool? includePayment = null)

Retrieve an order - {GetOrderByIdRequest}

Retrieve an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderByIdRequestScopeIdOrderIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order id for the request.
            var includeLineItems = true;  // bool? | a value indicating whether include line items or not. (optional) 
            var includeShipment = true;  // bool? | a value indicating whether include shipment or not. (optional) 
            var includePayment = true;  // bool? | a value indicating whether include payments or not. (optional) 

            try
            {
                // Retrieve an order - {GetOrderByIdRequest}
                Order result = apiInstance.GetOrderByIdRequestScopeIdOrderIdGet(accept, scopeId, orderId, includeLineItems, includeShipment, includePayment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderByIdRequestScopeIdOrderIdGet: " + e.Message );
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
 **orderId** | **string**| The order id for the request. | 
 **includeLineItems** | **bool?**| a value indicating whether include line items or not. | [optional] 
 **includeShipment** | **bool?**| a value indicating whether include shipment or not. | [optional] 
 **includePayment** | **bool?**| a value indicating whether include payments or not. | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="getorderbynumberrequestscopeidbynumberordernumberget"></a>
# **GetOrderByNumberRequestScopeIdbyNumberOrderNumberGet**
> Order GetOrderByNumberRequestScopeIdbyNumberOrderNumberGet (string accept, string scopeId, string orderNumber, bool? includeLineItems = null, bool? includeShipment = null, bool? includePayment = null, string customerId = null)

Retrieve an order - {GetOrderByNumberRequest}

Retrieve an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderByNumberRequestScopeIdbyNumberOrderNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderNumber = orderNumber_example;  // string | The order number for the request.
            var includeLineItems = true;  // bool? | a value indicating whether include line items or not. (optional) 
            var includeShipment = true;  // bool? | a value indicating whether include shipment or not. (optional) 
            var includePayment = true;  // bool? | a value indicating whether include payments or not. (optional) 
            var customerId = customerId_example;  // string | The customer identifier for the request (optional) 

            try
            {
                // Retrieve an order - {GetOrderByNumberRequest}
                Order result = apiInstance.GetOrderByNumberRequestScopeIdbyNumberOrderNumberGet(accept, scopeId, orderNumber, includeLineItems, includeShipment, includePayment, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderByNumberRequestScopeIdbyNumberOrderNumberGet: " + e.Message );
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
 **orderNumber** | **string**| The order number for the request. | 
 **includeLineItems** | **bool?**| a value indicating whether include line items or not. | [optional] 
 **includeShipment** | **bool?**| a value indicating whether include shipment or not. | [optional] 
 **includePayment** | **bool?**| a value indicating whether include payments or not. | [optional] 
 **customerId** | **string**| The customer identifier for the request | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="getorderfulfillmentstaterequestscopeidorderidfulfillmentstateget"></a>
# **GetOrderFulfillmentStateRequestScopeIdOrderIdfulfillmentStateGet**
> OrderFulfillmentState GetOrderFulfillmentStateRequestScopeIdOrderIdfulfillmentStateGet (string accept, string scopeId, string orderId)

Retrieve the fulfillment state of an order and each of its shipments - {GetOrderFulfillmentStateRequest}

Retrieve the fulfillment state of an order and each of its shipments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderFulfillmentStateRequestScopeIdOrderIdfulfillmentStateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | The unique system identifier for the Order

            try
            {
                // Retrieve the fulfillment state of an order and each of its shipments - {GetOrderFulfillmentStateRequest}
                OrderFulfillmentState result = apiInstance.GetOrderFulfillmentStateRequestScopeIdOrderIdfulfillmentStateGet(accept, scopeId, orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderFulfillmentStateRequestScopeIdOrderIdfulfillmentStateGet: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| The unique system identifier for the Order | 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="getorderhistoryrequestscopeidorderhistoryget"></a>
# **GetOrderHistoryRequestScopeIdorderhistoryGet**
> List&lt;OrderHistoryItem&gt; GetOrderHistoryRequestScopeIdorderhistoryGet (string accept, string scopeId, string orderNumber = null, string shipmentId = null, string fulfillmentLocationId = null)

Get history items related to specified order - {GetOrderHistoryRequest}

Get history items related to specified order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderHistoryRequestScopeIdorderhistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderNumber = orderNumber_example;  // string | The identifier of the order to be used for retrieving items. (optional) 
            var shipmentId = shipmentId_example;  // string | The shipment identifier to be used to filter items from the order (optional). (optional) 
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The fulfillment location identifier to be used to filter items from the order (optional). (optional) 

            try
            {
                // Get history items related to specified order - {GetOrderHistoryRequest}
                List<OrderHistoryItem> result = apiInstance.GetOrderHistoryRequestScopeIdorderhistoryGet(accept, scopeId, orderNumber, shipmentId, fulfillmentLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderHistoryRequestScopeIdorderhistoryGet: " + e.Message );
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
 **orderNumber** | **string**| The identifier of the order to be used for retrieving items. | [optional] 
 **shipmentId** | **string**| The shipment identifier to be used to filter items from the order (optional). | [optional] 
 **fulfillmentLocationId** | **string**| The fulfillment location identifier to be used to filter items from the order (optional). | [optional] 

### Return type

[**List&lt;OrderHistoryItem&gt;**](OrderHistoryItem.md)

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

<a name="getordernotesrequestscopeidorderidnotesget"></a>
# **GetOrderNotesRequestScopeIdOrderIdnotesGet**
> List&lt;Note&gt; GetOrderNotesRequestScopeIdOrderIdnotesGet (string accept, string scopeId, string orderId)

Get order notes - {GetOrderNotesRequest}

Get order notes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderNotesRequestScopeIdOrderIdnotesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The unique identifier of the Order.

            try
            {
                // Get order notes - {GetOrderNotesRequest}
                List<Note> result = apiInstance.GetOrderNotesRequestScopeIdOrderIdnotesGet(accept, scopeId, orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderNotesRequestScopeIdOrderIdnotesGet: " + e.Message );
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
 **orderId** | **string**| The unique identifier of the Order. | 

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
| **404** | Requested order not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersettingsrequestsettingsget"></a>
# **GetOrderSettingsRequestsettingsGet**
> OrderSettings GetOrderSettingsRequestsettingsGet (string accept, string scopeId = null)

Get the order settings - {GetOrderSettingsRequest}

Get the order settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOrderSettingsRequestsettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Get the order settings - {GetOrderSettingsRequest}
                OrderSettings result = apiInstance.GetOrderSettingsRequestsettingsGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderSettingsRequestsettingsGet: " + e.Message );
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
 **scopeId** | **string**| The id of the requested scope | [optional] 

### Return type

[**OrderSettings**](OrderSettings.md)

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
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprintableorderurirequestscopeidorderidprinturiget"></a>
# **GetPrintableOrderUriRequestScopeIdOrderIdprinturiGet**
> string GetPrintableOrderUriRequestScopeIdOrderIdprinturiGet (string accept, string scopeId, string orderId)

Get the uri of printable version of the order - {GetPrintableOrderUriRequest}

Get the uri of printable version of the order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPrintableOrderUriRequestScopeIdOrderIdprinturiGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order id for the request.

            try
            {
                // Get the uri of printable version of the order - {GetPrintableOrderUriRequest}
                string result = apiInstance.GetPrintableOrderUriRequestScopeIdOrderIdprinturiGet(accept, scopeId, orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetPrintableOrderUriRequestScopeIdOrderIdprinturiGet: " + e.Message );
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
 **orderId** | **string**| The order id for the request. | 

### Return type

**string**

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
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprintableordersurirequestscopeidprintorderspost"></a>
# **GetPrintableOrdersUriRequestScopeIdprintOrdersPost**
> string GetPrintableOrdersUriRequestScopeIdprintOrdersPost (string accept, string scopeId, GetPrintableOrdersUriRequest body = null)

Get the uri of printable version of a list of order - {GetPrintableOrdersUriRequest}

Get the uri of printable version of a list of order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPrintableOrdersUriRequestScopeIdprintOrdersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetPrintableOrdersUriRequest(); // GetPrintableOrdersUriRequest |  (optional) 

            try
            {
                // Get the uri of printable version of a list of order - {GetPrintableOrdersUriRequest}
                string result = apiInstance.GetPrintableOrdersUriRequestScopeIdprintOrdersPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetPrintableOrdersUriRequestScopeIdprintOrdersPost: " + e.Message );
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
 **body** | [**GetPrintableOrdersUriRequest**](GetPrintableOrdersUriRequest.md)|  | [optional] 

### Return type

**string**

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
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrmarequestrmascopeidordernumberrmanumberget"></a>
# **GetRmaRequestRMAScopeIdOrderNumberRmaNumberGet**
> Rma GetRmaRequestRMAScopeIdOrderNumberRmaNumberGet (string accept, string scopeId, string orderNumber, string rmaNumber)

Retrieves RMA and items - {GetRmaRequest}

Retrieves a RMA using order number and RMA number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRmaRequestRMAScopeIdOrderNumberRmaNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderNumber = orderNumber_example;  // string | the order number
            var rmaNumber = rmaNumber_example;  // string | the RMA number

            try
            {
                // Retrieves RMA and items - {GetRmaRequest}
                Rma result = apiInstance.GetRmaRequestRMAScopeIdOrderNumberRmaNumberGet(accept, scopeId, orderNumber, rmaNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetRmaRequestRMAScopeIdOrderNumberRmaNumberGet: " + e.Message );
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
 **orderNumber** | **string**| the order number | 
 **rmaNumber** | **string**| the RMA number | 

### Return type

[**Rma**](Rma.md)

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

<a name="getrmasbyorderrequestrmascopeidordernumberget"></a>
# **GetRmasByOrderRequestRMAScopeIdOrderNumberGet**
> RmaListResult GetRmasByOrderRequestRMAScopeIdOrderNumberGet (string accept, string scopeId, string orderNumber)

Retrieves all RMAs for an order - {GetRmasByOrderRequest}

Retrieves all RMAs for a specified order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRmasByOrderRequestRMAScopeIdOrderNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderNumber = orderNumber_example;  // string | the order number

            try
            {
                // Retrieves all RMAs for an order - {GetRmasByOrderRequest}
                RmaListResult result = apiInstance.GetRmasByOrderRequestRMAScopeIdOrderNumberGet(accept, scopeId, orderNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetRmasByOrderRequestRMAScopeIdOrderNumberGet: " + e.Message );
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
 **orderNumber** | **string**| the order number | 

### Return type

[**RmaListResult**](RmaListResult.md)

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

<a name="getshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnameget"></a>
# **GetShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameGet**
> ShipmentDocument GetShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameGet (string accept, string scopeId, string orderId, string shipmentId, string name)

Retrieve a shipment document - {GetShipmentDocumentRequest}

Retrieve a shipment document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order id for the request.
            var shipmentId = shipmentId_example;  // string | The shipment id for the request.
            var name = name_example;  // string | The name of the document.

            try
            {
                // Retrieve a shipment document - {GetShipmentDocumentRequest}
                ShipmentDocument result = apiInstance.GetShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameGet(accept, scopeId, orderId, shipmentId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameGet: " + e.Message );
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
 **orderId** | **string**| The order id for the request. | 
 **shipmentId** | **string**| The shipment id for the request. | 
 **name** | **string**| The name of the document. | 

### Return type

[**ShipmentDocument**](ShipmentDocument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Document not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentnotesrequestscopeidshipmentidshipmentnotesget"></a>
# **GetShipmentNotesRequestScopeIdShipmentIdshipmentnotesGet**
> List&lt;Note&gt; GetShipmentNotesRequestScopeIdShipmentIdshipmentnotesGet (string accept, string scopeId, string shipmentId)

Get shipment notes - {GetShipmentNotesRequest}

Get shipment notes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetShipmentNotesRequestScopeIdShipmentIdshipmentnotesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var shipmentId = shipmentId_example;  // string | The unique identifier of the Shipment.

            try
            {
                // Get shipment notes - {GetShipmentNotesRequest}
                List<Note> result = apiInstance.GetShipmentNotesRequestScopeIdShipmentIdshipmentnotesGet(accept, scopeId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetShipmentNotesRequestScopeIdShipmentIdshipmentnotesGet: " + e.Message );
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
 **shipmentId** | **string**| The unique identifier of the Shipment. | 

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
| **404** | Requested shipment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxcategoriesrequesttaxcategoriesget"></a>
# **GetTaxCategoriesRequesttaxCategoriesGet**
> List&lt;TaxCategory&gt; GetTaxCategoriesRequesttaxCategoriesGet (string accept, bool? getSystemCategories = null, bool? getOnlySupportedCategories = null)

Retrieve the list of tax categories in the system - {GetTaxCategoriesRequest}

Retrieve the list of tax categories in the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTaxCategoriesRequesttaxCategoriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var getSystemCategories = true;  // bool? | a value indicating whether include system categories or not. (optional) 
            var getOnlySupportedCategories = true;  // bool? | a value indicating whether include only supported categories or not. (optional) 

            try
            {
                // Retrieve the list of tax categories in the system - {GetTaxCategoriesRequest}
                List<TaxCategory> result = apiInstance.GetTaxCategoriesRequesttaxCategoriesGet(accept, getSystemCategories, getOnlySupportedCategories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetTaxCategoriesRequesttaxCategoriesGet: " + e.Message );
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
 **getSystemCategories** | **bool?**| a value indicating whether include system categories or not. | [optional] 
 **getOnlySupportedCategories** | **bool?**| a value indicating whether include only supported categories or not. | [optional] 

### Return type

[**List&lt;TaxCategory&gt;**](TaxCategory.md)

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

<a name="gettaxproviderbyscoperequesttaxproviderbyscopeget"></a>
# **GetTaxProviderByScopeRequesttaxProviderByScopeGet**
> TaxProviderDetails GetTaxProviderByScopeRequesttaxProviderByScopeGet (string accept, string name = null, string cultureName = null, string scopeId = null)

Retrieve the tax provider for a scope - {GetTaxProviderByScopeRequest}

Retrieve the tax provider for a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetTaxProviderByScopeRequesttaxProviderByScopeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The name of the provider (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language that data will be returned (optional) 
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Retrieve the tax provider for a scope - {GetTaxProviderByScopeRequest}
                TaxProviderDetails result = apiInstance.GetTaxProviderByScopeRequesttaxProviderByScopeGet(accept, name, cultureName, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetTaxProviderByScopeRequesttaxProviderByScopeGet: " + e.Message );
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
 **name** | **string**| The name of the provider | [optional] 
 **cultureName** | **string**| The culture name in which language that data will be returned | [optional] 
 **scopeId** | **string**| The id of the requested scope | [optional] 

### Return type

[**TaxProviderDetails**](TaxProviderDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the provider was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postprocessorderrequestscopeidorderidpostprocesspost"></a>
# **PostProcessOrderRequestScopeIdOrderIdpostProcessPost**
> OrderFulfillmentState PostProcessOrderRequestScopeIdOrderIdpostProcessPost (string accept, string scopeId, string orderId, PostProcessOrderRequest body = null)

Queue a post processing task for a given order - {PostProcessOrderRequest}

Queue a post processing task for a given order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class PostProcessOrderRequestScopeIdOrderIdpostProcessPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | The unique system identifier of the order to post process
            var body = new PostProcessOrderRequest(); // PostProcessOrderRequest |  (optional) 

            try
            {
                // Queue a post processing task for a given order - {PostProcessOrderRequest}
                OrderFulfillmentState result = apiInstance.PostProcessOrderRequestScopeIdOrderIdpostProcessPost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.PostProcessOrderRequestScopeIdOrderIdpostProcessPost: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| The unique system identifier of the order to post process | 
 **body** | [**PostProcessOrderRequest**](PostProcessOrderRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="refreshpaymentorderrequestscopeidorderidpaymentspaymentidrefreshpost"></a>
# **RefreshPaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdrefreshPost**
> Order RefreshPaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdrefreshPost (string accept, string scopeId, string orderId, string paymentId, Object body = null)

Refresh the payment of an order - {RefreshPaymentOrderRequest}

Refresh the payment of an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RefreshPaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdrefreshPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order identifier.
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to settle.
            var body = ;  // Object |  (optional) 

            try
            {
                // Refresh the payment of an order - {RefreshPaymentOrderRequest}
                Order result = apiInstance.RefreshPaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdrefreshPost(accept, scopeId, orderId, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.RefreshPaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdrefreshPost: " + e.Message );
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
 **orderId** | **string**| The order identifier. | 
 **paymentId** | **string**| The unique identifier of the payment to settle. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="refundpaymentrequestscopeidorderidpaymentspaymentidrefundpost"></a>
# **RefundPaymentRequestScopeIdOrderIdpaymentsPaymentIdrefundPost**
> Order RefundPaymentRequestScopeIdOrderIdpaymentsPaymentIdrefundPost (string accept, string scopeId, string orderId, string paymentId, Object body = null)

Refund the payment of an order - {RefundPaymentRequest}

Refund the payment of an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RefundPaymentRequestScopeIdOrderIdpaymentsPaymentIdrefundPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order identifier.
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to refund.
            var body = ;  // Object |  (optional) 

            try
            {
                // Refund the payment of an order - {RefundPaymentRequest}
                Order result = apiInstance.RefundPaymentRequestScopeIdOrderIdpaymentsPaymentIdrefundPost(accept, scopeId, orderId, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.RefundPaymentRequestScopeIdOrderIdpaymentsPaymentIdrefundPost: " + e.Message );
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
 **orderId** | **string**| The order identifier. | 
 **paymentId** | **string**| The unique identifier of the payment to refund. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="renderordershipmenttemplaterequestscopeidorderidshipmentsshipmentidrendertemplateget"></a>
# **RenderOrderShipmentTemplateRequestScopeIdOrderIdshipmentsShipmentIdrenderTemplateGet**
> RenderOrderShipmentTemplateResponse RenderOrderShipmentTemplateRequestScopeIdOrderIdshipmentsShipmentIdrenderTemplateGet (string accept, string scopeId, string orderId, string shipmentId, string cultureName, string templateName = null, string contentName = null)

Render a shipment's template. - {RenderOrderShipmentTemplateRequest}

Render a shipment's template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RenderOrderShipmentTemplateRequestScopeIdOrderIdshipmentsShipmentIdrenderTemplateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The orderId related to the shipment.
            var shipmentId = shipmentId_example;  // string | The shipment id.
            var cultureName = cultureName_example;  // string | The name of the culture (language) to use to render the template.
            var templateName = templateName_example;  // string | The name of the template to render. (optional) 
            var contentName = contentName_example;  // string | The name of the content to render. (optional) 

            try
            {
                // Render a shipment's template. - {RenderOrderShipmentTemplateRequest}
                RenderOrderShipmentTemplateResponse result = apiInstance.RenderOrderShipmentTemplateRequestScopeIdOrderIdshipmentsShipmentIdrenderTemplateGet(accept, scopeId, orderId, shipmentId, cultureName, templateName, contentName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.RenderOrderShipmentTemplateRequestScopeIdOrderIdshipmentsShipmentIdrenderTemplateGet: " + e.Message );
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
 **orderId** | **string**| The orderId related to the shipment. | 
 **shipmentId** | **string**| The shipment id. | 
 **cultureName** | **string**| The name of the culture (language) to use to render the template. | 
 **templateName** | **string**| The name of the template to render. | [optional] 
 **contentName** | **string**| The name of the content to render. | [optional] 

### Return type

[**RenderOrderShipmentTemplateResponse**](RenderOrderShipmentTemplateResponse.md)

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

<a name="reportshipmentfulfillmentfailurerequestscopeidorderidshipmentsshipmentidstatefailurepost"></a>
# **ReportShipmentFulfillmentFailureRequestScopeIdOrderIdshipmentsShipmentIdstatefailurePost**
> OrderFulfillmentState ReportShipmentFulfillmentFailureRequestScopeIdOrderIdshipmentsShipmentIdstatefailurePost (string accept, string scopeId, string orderId, string shipmentId, ReportShipmentFulfillmentFailureRequest body = null)

Sets the state of a shipment to failed and halts all further processing - {ReportShipmentFulfillmentFailureRequest}

Sets the state of a shipment to failed and halts all further processing. Updates the flag WorkflowInError and IsResumable for a specific shipment fulfillment state. After setting the state of a shipment to failed, the shipment can only be cancelled

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ReportShipmentFulfillmentFailureRequestScopeIdOrderIdshipmentsShipmentIdstatefailurePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | The unique system order identifier.
            var shipmentId = shipmentId_example;  // string | The unique system shipment identifier.
            var body = new ReportShipmentFulfillmentFailureRequest(); // ReportShipmentFulfillmentFailureRequest |  (optional) 

            try
            {
                // Sets the state of a shipment to failed and halts all further processing - {ReportShipmentFulfillmentFailureRequest}
                OrderFulfillmentState result = apiInstance.ReportShipmentFulfillmentFailureRequestScopeIdOrderIdshipmentsShipmentIdstatefailurePost(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ReportShipmentFulfillmentFailureRequestScopeIdOrderIdshipmentsShipmentIdstatefailurePost: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| The unique system order identifier. | 
 **shipmentId** | **string**| The unique system shipment identifier. | 
 **body** | [**ReportShipmentFulfillmentFailureRequest**](ReportShipmentFulfillmentFailureRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="restartshipmentfulfillmentprocessingrequestscopeidorderidshipmentsshipmentidfulfillmentstaterestarttaskpost"></a>
# **RestartShipmentFulfillmentProcessingRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStaterestartTaskPost**
> OrderFulfillmentState RestartShipmentFulfillmentProcessingRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStaterestartTaskPost (string accept, string scopeId, string orderId, string shipmentId, Object body = null)

Restart the processing of a fulfillment after a failure - {RestartShipmentFulfillmentProcessingRequest}

Restart the processing of a fulfillment after a failure. According to the situation, this request will :- start a new workflow if there is no task id or no execution id for the task of the shipment fulfillment state- replace the task status Faulted by IdleAfterErrorRecovery if the task of the shipment fulfillment state is faulted with a faulted error code- reset the flag WorkflowInError to false and clear execution messages if WorkflowInError = true and IsResumble = false- reset the flags WorkflowInError and IsResumable to false, clear execution message and resume the bookmark created when the error happened if WorkflowInError = true and IsResumble = true

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RestartShipmentFulfillmentProcessingRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStaterestartTaskPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | the unique system order identifier.
            var shipmentId = shipmentId_example;  // string | the unique system shipment identifier.
            var body = ;  // Object |  (optional) 

            try
            {
                // Restart the processing of a fulfillment after a failure - {RestartShipmentFulfillmentProcessingRequest}
                OrderFulfillmentState result = apiInstance.RestartShipmentFulfillmentProcessingRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStaterestartTaskPost(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.RestartShipmentFulfillmentProcessingRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStaterestartTaskPost: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| the unique system order identifier. | 
 **shipmentId** | **string**| the unique system shipment identifier. | 
 **body** | **Object**|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="resumeorderrequestscopeidorderidresumepost"></a>
# **ResumeOrderRequestScopeIdOrderIdresumePost**
> OrderFulfillmentState ResumeOrderRequestScopeIdOrderIdresumePost (string accept, string scopeId, string orderId, Object body = null)

Resume the order which was on hold - {ResumeOrderRequest}

Update the current status of the shipments and order to set them back to their previous status (before being on hold)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ResumeOrderRequestScopeIdOrderIdresumePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | the unique system order identifier.
            var body = ;  // Object |  (optional) 

            try
            {
                // Resume the order which was on hold - {ResumeOrderRequest}
                OrderFulfillmentState result = apiInstance.ResumeOrderRequestScopeIdOrderIdresumePost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ResumeOrderRequestScopeIdOrderIdresumePost: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| the unique system order identifier. | 
 **body** | **Object**|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="saveorderrequestscopeidorderidpost"></a>
# **SaveOrderRequestScopeIdOrderIdPost**
> Order SaveOrderRequestScopeIdOrderIdPost (string accept, string scopeId, string orderId, SaveOrderRequest body = null)

Used to update an existing order based on the provided Order. - {SaveOrderRequest}

Update an existing order based on the provided Order. This request does not perform validation nor does it process the order using workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SaveOrderRequestScopeIdOrderIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | the unique system idenfitifier for the request.
            var body = new SaveOrderRequest(); // SaveOrderRequest |  (optional) 

            try
            {
                // Used to update an existing order based on the provided Order. - {SaveOrderRequest}
                Order result = apiInstance.SaveOrderRequestScopeIdOrderIdPost(accept, scopeId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.SaveOrderRequestScopeIdOrderIdPost: " + e.Message );
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
 **orderId** | **string**| the unique system idenfitifier for the request. | 
 **body** | [**SaveOrderRequest**](SaveOrderRequest.md)|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="setadjustmentorderrequestscopeidorderidshipmentsshipmentidadjustmentcreate"></a>
# **SetAdjustmentOrderRequestScopeIdOrderIdshipmentsShipmentIdadjustmentCreate**
> Order SetAdjustmentOrderRequestScopeIdOrderIdshipmentsShipmentIdadjustmentCreate (string accept, string scopeId, string orderId, string shipmentId, SetAdjustmentOrderRequest body = null)

Set the adjustment of a shipment - {SetAdjustmentOrderRequest}

Set the adjustment of a shipment - setting Amount to null or not providing an Amount will remove the adjustment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SetAdjustmentOrderRequestScopeIdOrderIdshipmentsShipmentIdadjustmentCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order identifier.
            var shipmentId = shipmentId_example;  // string | The unique identifier of the shipment to adjust
            var body = new SetAdjustmentOrderRequest(); // SetAdjustmentOrderRequest |  (optional) 

            try
            {
                // Set the adjustment of a shipment - {SetAdjustmentOrderRequest}
                Order result = apiInstance.SetAdjustmentOrderRequestScopeIdOrderIdshipmentsShipmentIdadjustmentCreate(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.SetAdjustmentOrderRequestScopeIdOrderIdshipmentsShipmentIdadjustmentCreate: " + e.Message );
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
 **orderId** | **string**| The order identifier. | 
 **shipmentId** | **string**| The unique identifier of the shipment to adjust | 
 **body** | [**SetAdjustmentOrderRequest**](SetAdjustmentOrderRequest.md)|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="settlepaymentorderrequestscopeidorderidpaymentspaymentidsettlepost"></a>
# **SettlePaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdsettlePost**
> Order SettlePaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdsettlePost (string accept, string scopeId, string orderId, string paymentId, Object body = null)

Settle the payment of an order - {SettlePaymentOrderRequest}

Settle the payment of an order - The payment has to be authorized to be able to settle it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SettlePaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdsettlePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order identifier.
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to settle.
            var body = ;  // Object |  (optional) 

            try
            {
                // Settle the payment of an order - {SettlePaymentOrderRequest}
                Order result = apiInstance.SettlePaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdsettlePost(accept, scopeId, orderId, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.SettlePaymentOrderRequestScopeIdOrderIdpaymentsPaymentIdsettlePost: " + e.Message );
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
 **orderId** | **string**| The order identifier. | 
 **paymentId** | **string**| The unique identifier of the payment to settle. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="shipmentsplitrequestscopeidorderidshipmentsshipmentidsplitcreate"></a>
# **ShipmentSplitRequestScopeIdOrderIdshipmentsShipmentIdsplitCreate**
> Order ShipmentSplitRequestScopeIdOrderIdshipmentsShipmentIdsplitCreate (string accept, string scopeId, string orderId, string shipmentId, ShipmentSplitRequest body = null)

Splits a shipment and queues post processing on the new shipment - {ShipmentSplitRequest}

Splits a shipment and queues post processing on the new shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ShipmentSplitRequestScopeIdOrderIdshipmentsShipmentIdsplitCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The identifier of the order.
            var shipmentId = shipmentId_example;  // string | The identifier of the shipment.
            var body = new ShipmentSplitRequest(); // ShipmentSplitRequest |  (optional) 

            try
            {
                // Splits a shipment and queues post processing on the new shipment - {ShipmentSplitRequest}
                Order result = apiInstance.ShipmentSplitRequestScopeIdOrderIdshipmentsShipmentIdsplitCreate(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ShipmentSplitRequestScopeIdOrderIdshipmentsShipmentIdsplitCreate: " + e.Message );
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
 **orderId** | **string**| The identifier of the order. | 
 **shipmentId** | **string**| The identifier of the shipment. | 
 **body** | [**ShipmentSplitRequest**](ShipmentSplitRequest.md)|  | [optional] 

### Return type

[**Order**](Order.md)

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

<a name="startnewshipmentfulfillmentworkflowrequestscopeidorderidshipmentsshipmentidfulfillmentstatestartnewworkflowpost"></a>
# **StartNewShipmentFulfillmentWorkflowRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatestartNewWorkflowPost**
> OrderFulfillmentState StartNewShipmentFulfillmentWorkflowRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatestartNewWorkflowPost (string accept, string scopeId, string orderId, string shipmentId, StartNewShipmentFulfillmentWorkflowRequest body = null)

Start the workflow of a fulfillment from the beginning - {StartNewShipmentFulfillmentWorkflowRequest}

Start the workflow of a fulfillment from the beginning. The workflow to use can be specified, if not, the workflow that normally applies is used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class StartNewShipmentFulfillmentWorkflowRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatestartNewWorkflowPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | the unique system order identifier.
            var shipmentId = shipmentId_example;  // string | the unique system shipment identifier.
            var body = new StartNewShipmentFulfillmentWorkflowRequest(); // StartNewShipmentFulfillmentWorkflowRequest |  (optional) 

            try
            {
                // Start the workflow of a fulfillment from the beginning - {StartNewShipmentFulfillmentWorkflowRequest}
                OrderFulfillmentState result = apiInstance.StartNewShipmentFulfillmentWorkflowRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatestartNewWorkflowPost(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.StartNewShipmentFulfillmentWorkflowRequestScopeIdOrderIdshipmentsShipmentIdfulfillmentStatestartNewWorkflowPost: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| the unique system order identifier. | 
 **shipmentId** | **string**| the unique system shipment identifier. | 
 **body** | [**StartNewShipmentFulfillmentWorkflowRequest**](StartNewShipmentFulfillmentWorkflowRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="updatermarequestrmascopeidordernumberrmanumbercreate"></a>
# **UpdateRmaRequestRMAScopeIdOrderNumberRmaNumberCreate**
> RmaRequestResult UpdateRmaRequestRMAScopeIdOrderNumberRmaNumberCreate (string accept, string scopeId, string orderNumber, string rmaNumber, UpdateRmaRequest body = null)

Update RMA and items - {UpdateRmaRequest}

Update an RMA status or the item details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateRmaRequestRMAScopeIdOrderNumberRmaNumberCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | Scope Id
            var orderNumber = orderNumber_example;  // string | the Order Number related to the RMA
            var rmaNumber = rmaNumber_example;  // string | the RMA Number
            var body = new UpdateRmaRequest(); // UpdateRmaRequest |  (optional) 

            try
            {
                // Update RMA and items - {UpdateRmaRequest}
                RmaRequestResult result = apiInstance.UpdateRmaRequestRMAScopeIdOrderNumberRmaNumberCreate(accept, scopeId, orderNumber, rmaNumber, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateRmaRequestRMAScopeIdOrderNumberRmaNumberCreate: " + e.Message );
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
 **scopeId** | **string**| Scope Id | 
 **orderNumber** | **string**| the Order Number related to the RMA | 
 **rmaNumber** | **string**| the RMA Number | 
 **body** | [**UpdateRmaRequest**](UpdateRmaRequest.md)|  | [optional] 

### Return type

[**RmaRequestResult**](RmaRequestResult.md)

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

<a name="updateshipmentdocumentrequestscopeidorderidshipmentsshipmentiddocumentsnamecreate"></a>
# **UpdateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameCreate**
> ShipmentDocument UpdateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameCreate (string accept, string scopeId, string orderId, string shipmentId, string name, UpdateShipmentDocumentRequest body = null)

Update a shipment document. - {UpdateShipmentDocumentRequest}

Update a shipment document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var orderId = orderId_example;  // string | The order id.
            var shipmentId = shipmentId_example;  // string | The shipment id.
            var name = name_example;  // string | The name of the document.
            var body = new UpdateShipmentDocumentRequest(); // UpdateShipmentDocumentRequest |  (optional) 

            try
            {
                // Update a shipment document. - {UpdateShipmentDocumentRequest}
                ShipmentDocument result = apiInstance.UpdateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameCreate(accept, scopeId, orderId, shipmentId, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateShipmentDocumentRequestScopeIdOrderIdshipmentsShipmentIddocumentsNameCreate: " + e.Message );
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
 **orderId** | **string**| The order id. | 
 **shipmentId** | **string**| The shipment id. | 
 **name** | **string**| The name of the document. | 
 **body** | [**UpdateShipmentDocumentRequest**](UpdateShipmentDocumentRequest.md)|  | [optional] 

### Return type

[**ShipmentDocument**](ShipmentDocument.md)

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

<a name="updateshipmentfulfillmentstaterequestscopeidorderidshipmentsshipmentidstatecreate"></a>
# **UpdateShipmentFulfillmentStateRequestScopeIdOrderIdshipmentsShipmentIdstateCreate**
> OrderFulfillmentState UpdateShipmentFulfillmentStateRequestScopeIdOrderIdshipmentsShipmentIdstateCreate (string accept, string scopeId, string orderId, string shipmentId, UpdateShipmentFulfillmentStateRequest body = null)

Update the current state of a shipment - {UpdateShipmentFulfillmentStateRequest}

This is for internal use only. Update the current state of a shipment. If order fulfillment is enabled and the update is not valid or the fulfillment does not transition, the request will fail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateShipmentFulfillmentStateRequestScopeIdOrderIdshipmentsShipmentIdstateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | the unique system order identifier.
            var shipmentId = shipmentId_example;  // string | the unique system shipment identifier.
            var body = new UpdateShipmentFulfillmentStateRequest(); // UpdateShipmentFulfillmentStateRequest |  (optional) 

            try
            {
                // Update the current state of a shipment - {UpdateShipmentFulfillmentStateRequest}
                OrderFulfillmentState result = apiInstance.UpdateShipmentFulfillmentStateRequestScopeIdOrderIdshipmentsShipmentIdstateCreate(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateShipmentFulfillmentStateRequestScopeIdOrderIdshipmentsShipmentIdstateCreate: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| the unique system order identifier. | 
 **shipmentId** | **string**| the unique system shipment identifier. | 
 **body** | [**UpdateShipmentFulfillmentStateRequest**](UpdateShipmentFulfillmentStateRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

<a name="updateshipmentfulfillmentworkflowxamlpathrequestscopeidorderidshipmentsshipmentidworkflowxamlpathcreate"></a>
# **UpdateShipmentFulfillmentWorkflowXamlPathRequestScopeIdOrderIdshipmentsShipmentIdWorkflowXamlPathCreate**
> OrderFulfillmentState UpdateShipmentFulfillmentWorkflowXamlPathRequestScopeIdOrderIdshipmentsShipmentIdWorkflowXamlPathCreate (string accept, string scopeId, string orderId, string shipmentId, UpdateShipmentFulfillmentWorkflowXamlPathRequest body = null)

Update the path of the fulfillment workflow of a shipment. - {UpdateShipmentFulfillmentWorkflowXamlPathRequest}

Update the path of the fulfillment workflow of a shipment. This is the path from App_Config folder, example of value : App_data\\Workflows\\Orders\\Canada\\FulfillmentWorkflow.xaml

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateShipmentFulfillmentWorkflowXamlPathRequestScopeIdOrderIdshipmentsShipmentIdWorkflowXamlPathCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new OrdersApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The identifier of the sales or dependant scope in which the order is processed
            var orderId = orderId_example;  // string | the unique system order identifier.
            var shipmentId = shipmentId_example;  // string | the unique system shipment identifier.
            var body = new UpdateShipmentFulfillmentWorkflowXamlPathRequest(); // UpdateShipmentFulfillmentWorkflowXamlPathRequest |  (optional) 

            try
            {
                // Update the path of the fulfillment workflow of a shipment. - {UpdateShipmentFulfillmentWorkflowXamlPathRequest}
                OrderFulfillmentState result = apiInstance.UpdateShipmentFulfillmentWorkflowXamlPathRequestScopeIdOrderIdshipmentsShipmentIdWorkflowXamlPathCreate(accept, scopeId, orderId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateShipmentFulfillmentWorkflowXamlPathRequestScopeIdOrderIdshipmentsShipmentIdWorkflowXamlPathCreate: " + e.Message );
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
 **scopeId** | **string**| The identifier of the sales or dependant scope in which the order is processed | 
 **orderId** | **string**| the unique system order identifier. | 
 **shipmentId** | **string**| the unique system shipment identifier. | 
 **body** | [**UpdateShipmentFulfillmentWorkflowXamlPathRequest**](UpdateShipmentFulfillmentWorkflowXamlPathRequest.md)|  | [optional] 

### Return type

[**OrderFulfillmentState**](OrderFulfillmentState.md)

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

