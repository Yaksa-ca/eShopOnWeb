# Yaksa.OrckestraCommerce.Client.Api.CartsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodePost**](CartsApi.md#addcouponrequestscopeidcustomeridcartnamecouponscouponcodepost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/coupons/{CouponCode} | Add a coupon to a cart - {AddCouponRequest}
[**AddLineItemInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsPost**](CartsApi.md#addlineiteminshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemspost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{ShipmentId}/lineItems | Add a line item to a specified shipment of a cart - {AddLineItemInShipmentRequest}
[**AddLineItemRequestScopeIdCustomerIdCartNamelineItemsPost**](CartsApi.md#addlineitemrequestscopeidcustomeridcartnamelineitemspost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/lineItems | Add a line item to the first shipment of a cart - {AddLineItemRequest}
[**AddOrUpdateLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsbatchPost**](CartsApi.md#addorupdatelineitemsinshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemsbatchpost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{ShipmentId}/lineItems/batch | Add or update multiple line items to a specific shipment of a cart - {AddOrUpdateLineItemsInShipmentRequest}
[**AddOrUpdateLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchPost**](CartsApi.md#addorupdatelineitemsrequestscopeidcustomeridcartnamelineitemsbatchpost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/lineItems/batch | Add or update multiple line items to the first shipment of a cart - {AddOrUpdateLineItemsRequest}
[**AddPaymentRequestScopeIdCustomerIdCartNamepaymentsPost**](CartsApi.md#addpaymentrequestscopeidcustomeridcartnamepaymentspost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/payments | Add a payment in a cart - {AddPaymentRequest}
[**AddShipmentRequestScopeIdCustomerIdCartNameshipmentsPost**](CartsApi.md#addshipmentrequestscopeidcustomeridcartnameshipmentspost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments | Add a shipment to a cart - {AddShipmentRequest}
[**AuthorizePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdauthorizePost**](CartsApi.md#authorizepaymentrequestscopeidcustomeridcartnamepaymentspaymentidauthorizepost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/authorize | Authorize the payment in a cart - {AuthorizePaymentRequest}
[**ClearCartRequestScopeIdCustomerIdCartNameclearDelete**](CartsApi.md#clearcartrequestscopeidcustomeridcartnamecleardelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/clear | Clears a cart by name - {ClearCartRequest}
[**CompleteCheckoutRequestScopeIdCustomerIdCartNamecompleteCheckoutPost**](CartsApi.md#completecheckoutrequestscopeidcustomeridcartnamecompletecheckoutpost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/completeCheckout | Complete the checkout of the cart - {CompleteCheckoutRequest}
[**CopyCartToCustomerRequestScopeIdCustomerIdCartNamecopyToNewCustomerIdCreate**](CartsApi.md#copycarttocustomerrequestscopeidcustomeridcartnamecopytonewcustomeridcreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/copyTo/{NewCustomerId} | Copy an existing cart to another customer - {CopyCartToCustomerRequest}
[**DeleteCartRequestScopeIdCustomerIdCartNameDelete**](CartsApi.md#deletecartrequestscopeidcustomeridcartnamedelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName} | Delete a cart by name - {DeleteCartRequest}
[**FindCartPaymentMethodsRequestScopeIdCustomerIdCartNamePaymentProviderNamepaymentMethodsPost**](CartsApi.md#findcartpaymentmethodsrequestscopeidcustomeridcartnamepaymentprovidernamepaymentmethodspost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/{PaymentProviderName}/paymentMethods | Retrieve the payment method available for a specific payment provider - {FindCartPaymentMethodsRequest}
[**GetCartRequestScopeIdCustomerIdCartNameGet**](CartsApi.md#getcartrequestscopeidcustomeridcartnameget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName} | Retrieve a cart - {GetCartRequest}
[**GetCartStatesRequestScopeIdCustomerIdCartNamestatesGet**](CartsApi.md#getcartstatesrequestscopeidcustomeridcartnamestatesget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/states | Retrieve the states of a cart, its shipments and its line items - {GetCartStatesRequest}
[**GetCartSummaryRequestScopeIdCustomerIdCartNameSummaryGet**](CartsApi.md#getcartsummaryrequestscopeidcustomeridcartnamesummaryget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/Summary | Retrieve the summary of a cart - {GetCartSummaryRequest}
[**GetCartsByCustomerIdRequestScopeIdCustomerIdGet**](CartsApi.md#getcartsbycustomeridrequestscopeidcustomeridget) | **GET** /carts/{ScopeId}/{CustomerId} | Retrieves the list of carts belonging to a customer - {GetCartsByCustomerIdRequest}
[**GetLineItemRequestScopeIdCustomerIdCartNamelineItemsIdGet**](CartsApi.md#getlineitemrequestscopeidcustomeridcartnamelineitemsidget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/lineItems/{Id} | Get a line item of a cart - {GetLineItemRequest}
[**GetLineItemsInCartRequestScopeIdCustomerIdCartNamelineItemsGet**](CartsApi.md#getlineitemsincartrequestscopeidcustomeridcartnamelineitemsget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/lineItems | Get all the line items of a cart - {GetLineItemsInCartRequest}
[**GetLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsGet**](CartsApi.md#getlineitemsinshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemsget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{ShipmentId}/lineItems | Get all the line items of a shipment - {GetLineItemsInShipmentRequest}
[**GetPaymentRequestScopeIdCustomerIdCartNamepaymentsIdGet**](CartsApi.md#getpaymentrequestscopeidcustomeridcartnamepaymentsidget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{Id} | Get a payment of a cart - {GetPaymentRequest}
[**GetPaymentsInCartRequestScopeIdCustomerIdCartNamepaymentsGet**](CartsApi.md#getpaymentsincartrequestscopeidcustomeridcartnamepaymentsget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/payments | Get all the payments of a cart - {GetPaymentsInCartRequest}
[**GetShipmentRequestScopeIdCustomerIdCartNameshipmentsIdGet**](CartsApi.md#getshipmentrequestscopeidcustomeridcartnameshipmentsidget) | **GET** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{Id} | Get a shipment of a cart - {GetShipmentRequest}
[**InitializePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdinitializePost**](CartsApi.md#initializepaymentrequestscopeidcustomeridcartnamepaymentspaymentidinitializepost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/initialize | Initialize the payment in a cart - {InitializePaymentRequest}
[**RefreshPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdrefreshPost**](CartsApi.md#refreshpaymentrequestscopeidcustomeridcartnamepaymentspaymentidrefreshpost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/refresh | Refresh the payment in a cart - {RefreshPaymentRequest}
[**RemoveAllLineItemsRequestScopeIdCustomerIdCartNameremoveAllLineItemsDelete**](CartsApi.md#removealllineitemsrequestscopeidcustomeridcartnameremovealllineitemsdelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/removeAllLineItems | Remove all the line items from a cart - {RemoveAllLineItemsRequest}
[**RemoveCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodeDelete**](CartsApi.md#removecouponrequestscopeidcustomeridcartnamecouponscouponcodedelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/coupons/{CouponCode} | Remove a coupon from a cart - {RemoveCouponRequest}
[**RemoveLineItemRequestScopeIdCustomerIdCartNamelineItemsIdDelete**](CartsApi.md#removelineitemrequestscopeidcustomeridcartnamelineitemsiddelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/lineItems/{Id} | Remove a line item from a cart - {RemoveLineItemRequest}
[**RemoveLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsDelete**](CartsApi.md#removelineitemsinshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemsdelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{ShipmentId}/lineItems | Remove all the line items from a shipment - {RemoveLineItemsInShipmentRequest}
[**RemoveLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchDelete**](CartsApi.md#removelineitemsrequestscopeidcustomeridcartnamelineitemsbatchdelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/lineItems/batch | Remove multiple line items from a cart - {RemoveLineItemsRequest}
[**RemovePaymentRequestScopeIdCustomerIdCartNamepaymentsIdDelete**](CartsApi.md#removepaymentrequestscopeidcustomeridcartnamepaymentsiddelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{Id} | Removes a payment from a cart - {RemovePaymentRequest}
[**RemoveShipmentRequestScopeIdCustomerIdCartNameshipmentsIdDelete**](CartsApi.md#removeshipmentrequestscopeidcustomeridcartnameshipmentsiddelete) | **DELETE** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{Id} | Removes a shipment from a cart - {RemoveShipmentRequest}
[**ReserveTimeSlotRequestScopeIdCustomerIdCartNameshipmentsShipmentIdTimeSlotIdPost**](CartsApi.md#reservetimeslotrequestscopeidcustomeridcartnameshipmentsshipmentidtimeslotidpost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{ShipmentId}/{TimeSlotId} | Adds or renew a timeslot reservation for a cart - {ReserveTimeSlotRequest}
[**SetAdjustmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdadjustmentCreate**](CartsApi.md#setadjustmentrequestscopeidcustomeridcartnameshipmentsshipmentidadjustmentcreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{ShipmentId}/adjustment | Set the adjustment of a shipment - {SetAdjustmentRequest}
[**SettlePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdsettlePost**](CartsApi.md#settlepaymentrequestscopeidcustomeridcartnamepaymentspaymentidsettlepost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/settle | Settle the payment in a cart - {SettlePaymentRequest}
[**UpdateBillingAddressRequestScopeIdCustomerIdCartNamepaymentsPaymentIdbillingAddressCreate**](CartsApi.md#updatebillingaddressrequestscopeidcustomeridcartnamepaymentspaymentidbillingaddresscreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/billingAddress | Update the billing address of a payment - {UpdateBillingAddressRequest}
[**UpdateCartRequestScopeIdCustomerIdCartNameCreate**](CartsApi.md#updatecartrequestscopeidcustomeridcartnamecreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName} | Update the cart - {UpdateCartRequest}
[**UpdateCustomerSummaryRequestScopeIdCustomerIdCartNamecustomerCreate**](CartsApi.md#updatecustomersummaryrequestscopeidcustomeridcartnamecustomercreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/customer | Update the customer summary of a cart - {UpdateCustomerSummaryRequest}
[**UpdateLineItemRequestScopeIdCustomerIdCartNamelineItemsIdCreate**](CartsApi.md#updatelineitemrequestscopeidcustomeridcartnamelineitemsidcreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/lineItems/{Id} | Update a line item of a cart - {UpdateLineItemRequest}
[**UpdatePaymentAmountRequestScopeIdCustomerIdCartNamepaymentsPaymentIdamountCreate**](CartsApi.md#updatepaymentamountrequestscopeidcustomeridcartnamepaymentspaymentidamountcreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/amount | Update the amount of a payment - {UpdatePaymentAmountRequest}
[**UpdatePaymentMethodRequestScopeIdCustomerIdCartNamepaymentsPaymentIdmethodCreate**](CartsApi.md#updatepaymentmethodrequestscopeidcustomeridcartnamepaymentspaymentidmethodcreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/method | Update a payment method of a payment - {UpdatePaymentMethodRequest}
[**UpdatePaymentRequestScopeIdCustomerIdCartNamepaymentsIdCreate**](CartsApi.md#updatepaymentrequestscopeidcustomeridcartnamepaymentsidcreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{Id} | Update a payment of a cart - {UpdatePaymentRequest}
[**UpdateShipmentRequestScopeIdCustomerIdCartNameshipmentsIdCreate**](CartsApi.md#updateshipmentrequestscopeidcustomeridcartnameshipmentsidcreate) | **PUT** /carts/{ScopeId}/{CustomerId}/{CartName}/shipments/{Id} | Update a shipment of a cart - {UpdateShipmentRequest}
[**VoidPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdvoidPost**](CartsApi.md#voidpaymentrequestscopeidcustomeridcartnamepaymentspaymentidvoidpost) | **POST** /carts/{ScopeId}/{CustomerId}/{CartName}/payments/{PaymentId}/void | Void the payment in a cart - {VoidPaymentRequest}


<a name="addcouponrequestscopeidcustomeridcartnamecouponscouponcodepost"></a>
# **AddCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodePost**
> ProcessedCart AddCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodePost (string accept, string scopeId, string customerId, string cartName, string couponCode, AddCouponRequest body = null)

Add a coupon to a cart - {AddCouponRequest}

Add a coupon to a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var couponCode = couponCode_example;  // string | the coupon code. This is the string that is to be entered on the Cart or Order to be able to fetch the coupon and apply the promotion. It is unique in the system.
            var body = new AddCouponRequest(); // AddCouponRequest |  (optional) 

            try
            {
                // Add a coupon to a cart - {AddCouponRequest}
                ProcessedCart result = apiInstance.AddCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodePost(accept, scopeId, customerId, cartName, couponCode, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AddCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodePost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **couponCode** | **string**| the coupon code. This is the string that is to be entered on the Cart or Order to be able to fetch the coupon and apply the promotion. It is unique in the system. | 
 **body** | [**AddCouponRequest**](AddCouponRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="addlineiteminshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemspost"></a>
# **AddLineItemInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsPost**
> ProcessedCart AddLineItemInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsPost (string accept, string scopeId, string customerId, string cartName, string shipmentId, AddLineItemInShipmentRequest body = null)

Add a line item to a specified shipment of a cart - {AddLineItemInShipmentRequest}

Add a line item to a specified shipment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddLineItemInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var shipmentId = shipmentId_example;  // string | The unique identifier of the Shipment to consider.
            var body = new AddLineItemInShipmentRequest(); // AddLineItemInShipmentRequest |  (optional) 

            try
            {
                // Add a line item to a specified shipment of a cart - {AddLineItemInShipmentRequest}
                ProcessedCart result = apiInstance.AddLineItemInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsPost(accept, scopeId, customerId, cartName, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AddLineItemInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **shipmentId** | **string**| The unique identifier of the Shipment to consider. | 
 **body** | [**AddLineItemInShipmentRequest**](AddLineItemInShipmentRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="addlineitemrequestscopeidcustomeridcartnamelineitemspost"></a>
# **AddLineItemRequestScopeIdCustomerIdCartNamelineItemsPost**
> ProcessedCart AddLineItemRequestScopeIdCustomerIdCartNamelineItemsPost (string accept, string scopeId, string customerId, string cartName, AddLineItemRequest body = null)

Add a line item to the first shipment of a cart - {AddLineItemRequest}

Add a line item to the first shipment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddLineItemRequestScopeIdCustomerIdCartNamelineItemsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var body = new AddLineItemRequest(); // AddLineItemRequest |  (optional) 

            try
            {
                // Add a line item to the first shipment of a cart - {AddLineItemRequest}
                ProcessedCart result = apiInstance.AddLineItemRequestScopeIdCustomerIdCartNamelineItemsPost(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AddLineItemRequestScopeIdCustomerIdCartNamelineItemsPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **body** | [**AddLineItemRequest**](AddLineItemRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="addorupdatelineitemsinshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemsbatchpost"></a>
# **AddOrUpdateLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsbatchPost**
> ProcessedCart AddOrUpdateLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsbatchPost (string accept, string scopeId, string customerId, string cartName, string shipmentId, AddOrUpdateLineItemsInShipmentRequest body = null)

Add or update multiple line items to a specific shipment of a cart - {AddOrUpdateLineItemsInShipmentRequest}

Add or update multiple line items to a specific shipment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsbatchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var shipmentId = shipmentId_example;  // string | The unique identifier of the shipment where to create line item.
            var body = new AddOrUpdateLineItemsInShipmentRequest(); // AddOrUpdateLineItemsInShipmentRequest |  (optional) 

            try
            {
                // Add or update multiple line items to a specific shipment of a cart - {AddOrUpdateLineItemsInShipmentRequest}
                ProcessedCart result = apiInstance.AddOrUpdateLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsbatchPost(accept, scopeId, customerId, cartName, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AddOrUpdateLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsbatchPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **shipmentId** | **string**| The unique identifier of the shipment where to create line item. | 
 **body** | [**AddOrUpdateLineItemsInShipmentRequest**](AddOrUpdateLineItemsInShipmentRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="addorupdatelineitemsrequestscopeidcustomeridcartnamelineitemsbatchpost"></a>
# **AddOrUpdateLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchPost**
> ProcessedCart AddOrUpdateLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchPost (string accept, string scopeId, string customerId, string cartName, AddOrUpdateLineItemsRequest body = null)

Add or update multiple line items to the first shipment of a cart - {AddOrUpdateLineItemsRequest}

Add or update multiple line items to the first shipment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var body = new AddOrUpdateLineItemsRequest(); // AddOrUpdateLineItemsRequest |  (optional) 

            try
            {
                // Add or update multiple line items to the first shipment of a cart - {AddOrUpdateLineItemsRequest}
                ProcessedCart result = apiInstance.AddOrUpdateLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchPost(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AddOrUpdateLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **body** | [**AddOrUpdateLineItemsRequest**](AddOrUpdateLineItemsRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="addpaymentrequestscopeidcustomeridcartnamepaymentspost"></a>
# **AddPaymentRequestScopeIdCustomerIdCartNamepaymentsPost**
> ProcessedCart AddPaymentRequestScopeIdCustomerIdCartNamepaymentsPost (string accept, string scopeId, string customerId, string cartName, AddPaymentRequest body = null)

Add a payment in a cart - {AddPaymentRequest}

Add a payment in a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddPaymentRequestScopeIdCustomerIdCartNamepaymentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var body = new AddPaymentRequest(); // AddPaymentRequest |  (optional) 

            try
            {
                // Add a payment in a cart - {AddPaymentRequest}
                ProcessedCart result = apiInstance.AddPaymentRequestScopeIdCustomerIdCartNamepaymentsPost(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AddPaymentRequestScopeIdCustomerIdCartNamepaymentsPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **body** | [**AddPaymentRequest**](AddPaymentRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="addshipmentrequestscopeidcustomeridcartnameshipmentspost"></a>
# **AddShipmentRequestScopeIdCustomerIdCartNameshipmentsPost**
> ProcessedCart AddShipmentRequestScopeIdCustomerIdCartNameshipmentsPost (string accept, string scopeId, string customerId, string cartName, AddShipmentRequest body = null)

Add a shipment to a cart - {AddShipmentRequest}

Add a shipment to a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddShipmentRequestScopeIdCustomerIdCartNameshipmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var body = new AddShipmentRequest(); // AddShipmentRequest |  (optional) 

            try
            {
                // Add a shipment to a cart - {AddShipmentRequest}
                ProcessedCart result = apiInstance.AddShipmentRequestScopeIdCustomerIdCartNameshipmentsPost(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AddShipmentRequestScopeIdCustomerIdCartNameshipmentsPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **body** | [**AddShipmentRequest**](AddShipmentRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="authorizepaymentrequestscopeidcustomeridcartnamepaymentspaymentidauthorizepost"></a>
# **AuthorizePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdauthorizePost**
> Cart AuthorizePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdauthorizePost (string accept, string scopeId, string customerId, string cartName, string paymentId, AuthorizePaymentRequest body = null)

Authorize the payment in a cart - {AuthorizePaymentRequest}

Authorize the payment in a cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AuthorizePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdauthorizePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to authorize.
            var body = new AuthorizePaymentRequest(); // AuthorizePaymentRequest |  (optional) 

            try
            {
                // Authorize the payment in a cart - {AuthorizePaymentRequest}
                Cart result = apiInstance.AuthorizePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdauthorizePost(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.AuthorizePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdauthorizePost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The unique identifier of the payment to authorize. | 
 **body** | [**AuthorizePaymentRequest**](AuthorizePaymentRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearcartrequestscopeidcustomeridcartnamecleardelete"></a>
# **ClearCartRequestScopeIdCustomerIdCartNameclearDelete**
> void ClearCartRequestScopeIdCustomerIdCartNameclearDelete (string accept, string scopeId, string customerId, string cartName, string cultureName = null)

Clears a cart by name - {ClearCartRequest}

Clears a cart by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ClearCartRequestScopeIdCustomerIdCartNameclearDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Clears a cart by name - {ClearCartRequest}
                apiInstance.ClearCartRequestScopeIdCustomerIdCartNameclearDelete(accept, scopeId, customerId, cartName, cultureName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.ClearCartRequestScopeIdCustomerIdCartNameclearDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

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

<a name="completecheckoutrequestscopeidcustomeridcartnamecompletecheckoutpost"></a>
# **CompleteCheckoutRequestScopeIdCustomerIdCartNamecompleteCheckoutPost**
> Order CompleteCheckoutRequestScopeIdCustomerIdCartNamecompleteCheckoutPost (string accept, string scopeId, string customerId, string cartName, CompleteCheckoutRequest body = null)

Complete the checkout of the cart - {CompleteCheckoutRequest}

Complete the checkout of the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CompleteCheckoutRequestScopeIdCustomerIdCartNamecompleteCheckoutPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var body = new CompleteCheckoutRequest(); // CompleteCheckoutRequest |  (optional) 

            try
            {
                // Complete the checkout of the cart - {CompleteCheckoutRequest}
                Order result = apiInstance.CompleteCheckoutRequestScopeIdCustomerIdCartNamecompleteCheckoutPost(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.CompleteCheckoutRequestScopeIdCustomerIdCartNamecompleteCheckoutPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **body** | [**CompleteCheckoutRequest**](CompleteCheckoutRequest.md)|  | [optional] 

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

<a name="copycarttocustomerrequestscopeidcustomeridcartnamecopytonewcustomeridcreate"></a>
# **CopyCartToCustomerRequestScopeIdCustomerIdCartNamecopyToNewCustomerIdCreate**
> ProcessedCart CopyCartToCustomerRequestScopeIdCustomerIdCartNamecopyToNewCustomerIdCreate (string accept, string scopeId, string customerId, string cartName, string newCustomerId, CopyCartToCustomerRequest body = null)

Copy an existing cart to another customer - {CopyCartToCustomerRequest}

Copy an existing cart to another customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CopyCartToCustomerRequestScopeIdCustomerIdCartNamecopyToNewCustomerIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var newCustomerId = newCustomerId_example;  // string | the id of the customer who receives the cart.
            var body = new CopyCartToCustomerRequest(); // CopyCartToCustomerRequest |  (optional) 

            try
            {
                // Copy an existing cart to another customer - {CopyCartToCustomerRequest}
                ProcessedCart result = apiInstance.CopyCartToCustomerRequestScopeIdCustomerIdCartNamecopyToNewCustomerIdCreate(accept, scopeId, customerId, cartName, newCustomerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.CopyCartToCustomerRequestScopeIdCustomerIdCartNamecopyToNewCustomerIdCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **newCustomerId** | **string**| the id of the customer who receives the cart. | 
 **body** | [**CopyCartToCustomerRequest**](CopyCartToCustomerRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="deletecartrequestscopeidcustomeridcartnamedelete"></a>
# **DeleteCartRequestScopeIdCustomerIdCartNameDelete**
> void DeleteCartRequestScopeIdCustomerIdCartNameDelete (string accept, string scopeId, string customerId, string cartName, string cultureName = null)

Delete a cart by name - {DeleteCartRequest}

Delete a cart by name, nothing is preserved, to remove only the items, use the ClearCartRequest instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteCartRequestScopeIdCustomerIdCartNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Delete a cart by name - {DeleteCartRequest}
                apiInstance.DeleteCartRequestScopeIdCustomerIdCartNameDelete(accept, scopeId, customerId, cartName, cultureName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.DeleteCartRequestScopeIdCustomerIdCartNameDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

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

<a name="findcartpaymentmethodsrequestscopeidcustomeridcartnamepaymentprovidernamepaymentmethodspost"></a>
# **FindCartPaymentMethodsRequestScopeIdCustomerIdCartNamePaymentProviderNamepaymentMethodsPost**
> List&lt;PaymentMethod&gt; FindCartPaymentMethodsRequestScopeIdCustomerIdCartNamePaymentProviderNamepaymentMethodsPost (string accept, string scopeId, string customerId, string cartName, string paymentProviderName, FindCartPaymentMethodsRequest body = null)

Retrieve the payment method available for a specific payment provider - {FindCartPaymentMethodsRequest}

Retrieve all the payment methods available for the cart, as well as the payment methods previously used by the customer.The request calls the method GetPaymentMethods(Cart cart, Dictionary<string, object> parameters) of the payment provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindCartPaymentMethodsRequestScopeIdCustomerIdCartNamePaymentProviderNamepaymentMethodsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | the unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | the name of the cart to retrieve
            var paymentProviderName = paymentProviderName_example;  // string | the name of the payment provider to use
            var body = new FindCartPaymentMethodsRequest(); // FindCartPaymentMethodsRequest |  (optional) 

            try
            {
                // Retrieve the payment method available for a specific payment provider - {FindCartPaymentMethodsRequest}
                List<PaymentMethod> result = apiInstance.FindCartPaymentMethodsRequestScopeIdCustomerIdCartNamePaymentProviderNamepaymentMethodsPost(accept, scopeId, customerId, cartName, paymentProviderName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.FindCartPaymentMethodsRequestScopeIdCustomerIdCartNamePaymentProviderNamepaymentMethodsPost: " + e.Message );
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
 **customerId** | **string**| the unique identifier of the Customer owning the cart | 
 **cartName** | **string**| the name of the cart to retrieve | 
 **paymentProviderName** | **string**| the name of the payment provider to use | 
 **body** | [**FindCartPaymentMethodsRequest**](FindCartPaymentMethodsRequest.md)|  | [optional] 

### Return type

[**List&lt;PaymentMethod&gt;**](PaymentMethod.md)

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

<a name="getcartrequestscopeidcustomeridcartnameget"></a>
# **GetCartRequestScopeIdCustomerIdCartNameGet**
> ProcessedCart GetCartRequestScopeIdCustomerIdCartNameGet (string accept, string scopeId, string customerId, string cartName, bool? executeWorkflow = null, string cultureName = null, string workflowToExecute = null)

Retrieve a cart - {GetCartRequest}

Retrieve a cart. The cart is created if it does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCartRequestScopeIdCustomerIdCartNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var executeWorkflow = true;  // bool? | Whether or not to execute the specified workflow before returning the cart. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Retrieve a cart - {GetCartRequest}
                ProcessedCart result = apiInstance.GetCartRequestScopeIdCustomerIdCartNameGet(accept, scopeId, customerId, cartName, executeWorkflow, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetCartRequestScopeIdCustomerIdCartNameGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **executeWorkflow** | **bool?**| Whether or not to execute the specified workflow before returning the cart. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="getcartstatesrequestscopeidcustomeridcartnamestatesget"></a>
# **GetCartStatesRequestScopeIdCustomerIdCartNamestatesGet**
> List&lt;EntityState&gt; GetCartStatesRequestScopeIdCustomerIdCartNamestatesGet (string accept, string scopeId, string customerId, string cartName, string cultureName = null)

Retrieve the states of a cart, its shipments and its line items - {GetCartStatesRequest}

Retrieve the states of a cart, its shipments and its line items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCartStatesRequestScopeIdCustomerIdCartNamestatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Retrieve the states of a cart, its shipments and its line items - {GetCartStatesRequest}
                List<EntityState> result = apiInstance.GetCartStatesRequestScopeIdCustomerIdCartNamestatesGet(accept, scopeId, customerId, cartName, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetCartStatesRequestScopeIdCustomerIdCartNamestatesGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

### Return type

[**List&lt;EntityState&gt;**](EntityState.md)

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

<a name="getcartsummaryrequestscopeidcustomeridcartnamesummaryget"></a>
# **GetCartSummaryRequestScopeIdCustomerIdCartNameSummaryGet**
> CartSummary GetCartSummaryRequestScopeIdCustomerIdCartNameSummaryGet (string accept, string scopeId, string customerId, string cartName, bool? executeWorkflow = null, string cultureName = null, string workflowToExecute = null)

Retrieve the summary of a cart - {GetCartSummaryRequest}

Retrieve the summary of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCartSummaryRequestScopeIdCustomerIdCartNameSummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var executeWorkflow = true;  // bool? | Whether or not to execute the specified workflow before returning the cart. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Retrieve the summary of a cart - {GetCartSummaryRequest}
                CartSummary result = apiInstance.GetCartSummaryRequestScopeIdCustomerIdCartNameSummaryGet(accept, scopeId, customerId, cartName, executeWorkflow, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetCartSummaryRequestScopeIdCustomerIdCartNameSummaryGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **executeWorkflow** | **bool?**| Whether or not to execute the specified workflow before returning the cart. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**CartSummary**](CartSummary.md)

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
| **404** | Requested cart not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartsbycustomeridrequestscopeidcustomeridget"></a>
# **GetCartsByCustomerIdRequestScopeIdCustomerIdGet**
> List&lt;CartSummary&gt; GetCartsByCustomerIdRequestScopeIdCustomerIdGet (string accept, string scopeId, string customerId, bool? includeChildScopes = null, string cultureName = null, string cartType = null)

Retrieves the list of carts belonging to a customer - {GetCartsByCustomerIdRequest}

Retrieves the list of carts belonging to a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCartsByCustomerIdRequestScopeIdCustomerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var includeChildScopes = true;  // bool? | a value indicating whether to include carts found in child scopes. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var cartType = cartType_example;  // string | The optional cart type. Only the carts of this specific type will be returned. (optional) 

            try
            {
                // Retrieves the list of carts belonging to a customer - {GetCartsByCustomerIdRequest}
                List<CartSummary> result = apiInstance.GetCartsByCustomerIdRequestScopeIdCustomerIdGet(accept, scopeId, customerId, includeChildScopes, cultureName, cartType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetCartsByCustomerIdRequestScopeIdCustomerIdGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **includeChildScopes** | **bool?**| a value indicating whether to include carts found in child scopes. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **cartType** | **string**| The optional cart type. Only the carts of this specific type will be returned. | [optional] 

### Return type

[**List&lt;CartSummary&gt;**](CartSummary.md)

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

<a name="getlineitemrequestscopeidcustomeridcartnamelineitemsidget"></a>
# **GetLineItemRequestScopeIdCustomerIdCartNamelineItemsIdGet**
> LineItem GetLineItemRequestScopeIdCustomerIdCartNamelineItemsIdGet (string accept, string scopeId, string customerId, string cartName, string id, string cultureName = null)

Get a line item of a cart - {GetLineItemRequest}

Get a line item of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetLineItemRequestScopeIdCustomerIdCartNamelineItemsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the LineItem to retreive
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Get a line item of a cart - {GetLineItemRequest}
                LineItem result = apiInstance.GetLineItemRequestScopeIdCustomerIdCartNamelineItemsIdGet(accept, scopeId, customerId, cartName, id, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetLineItemRequestScopeIdCustomerIdCartNamelineItemsIdGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the LineItem to retreive | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

### Return type

[**LineItem**](LineItem.md)

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
| **404** | Requested lineItem not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlineitemsincartrequestscopeidcustomeridcartnamelineitemsget"></a>
# **GetLineItemsInCartRequestScopeIdCustomerIdCartNamelineItemsGet**
> List&lt;LineItem&gt; GetLineItemsInCartRequestScopeIdCustomerIdCartNamelineItemsGet (string accept, string scopeId, string customerId, string cartName, string cultureName = null)

Get all the line items of a cart - {GetLineItemsInCartRequest}

Get all the line items of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetLineItemsInCartRequestScopeIdCustomerIdCartNamelineItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Get all the line items of a cart - {GetLineItemsInCartRequest}
                List<LineItem> result = apiInstance.GetLineItemsInCartRequestScopeIdCustomerIdCartNamelineItemsGet(accept, scopeId, customerId, cartName, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetLineItemsInCartRequestScopeIdCustomerIdCartNamelineItemsGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

### Return type

[**List&lt;LineItem&gt;**](LineItem.md)

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
| **404** | Requested lineItem not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlineitemsinshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemsget"></a>
# **GetLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsGet**
> List&lt;LineItem&gt; GetLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsGet (string accept, string scopeId, string customerId, string cartName, string shipmentId, string cultureName = null)

Get all the line items of a shipment - {GetLineItemsInShipmentRequest}

Get all the line items of a shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var shipmentId = shipmentId_example;  // string | The unique identifier of the Shipment to consider.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Get all the line items of a shipment - {GetLineItemsInShipmentRequest}
                List<LineItem> result = apiInstance.GetLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsGet(accept, scopeId, customerId, cartName, shipmentId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **shipmentId** | **string**| The unique identifier of the Shipment to consider. | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

### Return type

[**List&lt;LineItem&gt;**](LineItem.md)

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
| **404** | Requested lineItem not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentrequestscopeidcustomeridcartnamepaymentsidget"></a>
# **GetPaymentRequestScopeIdCustomerIdCartNamepaymentsIdGet**
> Payment GetPaymentRequestScopeIdCustomerIdCartNamepaymentsIdGet (string accept, string scopeId, string customerId, string cartName, string id, string cultureName = null)

Get a payment of a cart - {GetPaymentRequest}

Get a payment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPaymentRequestScopeIdCustomerIdCartNamepaymentsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the Payment to retreive
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Get a payment of a cart - {GetPaymentRequest}
                Payment result = apiInstance.GetPaymentRequestScopeIdCustomerIdCartNamepaymentsIdGet(accept, scopeId, customerId, cartName, id, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetPaymentRequestScopeIdCustomerIdCartNamepaymentsIdGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the Payment to retreive | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

### Return type

[**Payment**](Payment.md)

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
| **404** | Requested payment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsincartrequestscopeidcustomeridcartnamepaymentsget"></a>
# **GetPaymentsInCartRequestScopeIdCustomerIdCartNamepaymentsGet**
> List&lt;Payment&gt; GetPaymentsInCartRequestScopeIdCustomerIdCartNamepaymentsGet (string accept, string scopeId, string customerId, string cartName, string cultureName = null)

Get all the payments of a cart - {GetPaymentsInCartRequest}

Get all the payments of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPaymentsInCartRequestScopeIdCustomerIdCartNamepaymentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Get all the payments of a cart - {GetPaymentsInCartRequest}
                List<Payment> result = apiInstance.GetPaymentsInCartRequestScopeIdCustomerIdCartNamepaymentsGet(accept, scopeId, customerId, cartName, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetPaymentsInCartRequestScopeIdCustomerIdCartNamepaymentsGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

### Return type

[**List&lt;Payment&gt;**](Payment.md)

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
| **404** | Requested payment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentrequestscopeidcustomeridcartnameshipmentsidget"></a>
# **GetShipmentRequestScopeIdCustomerIdCartNameshipmentsIdGet**
> Shipment GetShipmentRequestScopeIdCustomerIdCartNameshipmentsIdGet (string accept, string scopeId, string customerId, string cartName, string id, string cultureName = null)

Get a shipment of a cart - {GetShipmentRequest}

Get a shipment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetShipmentRequestScopeIdCustomerIdCartNameshipmentsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the Shipment to retreive
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 

            try
            {
                // Get a shipment of a cart - {GetShipmentRequest}
                Shipment result = apiInstance.GetShipmentRequestScopeIdCustomerIdCartNameshipmentsIdGet(accept, scopeId, customerId, cartName, id, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.GetShipmentRequestScopeIdCustomerIdCartNameshipmentsIdGet: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the Shipment to retreive | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 

### Return type

[**Shipment**](Shipment.md)

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

<a name="initializepaymentrequestscopeidcustomeridcartnamepaymentspaymentidinitializepost"></a>
# **InitializePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdinitializePost**
> Cart InitializePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdinitializePost (string accept, string scopeId, string customerId, string cartName, string paymentId, InitializePaymentRequest body = null)

Initialize the payment in a cart - {InitializePaymentRequest}

Initialize the payment in a cart, Payment method of the payment should already exists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class InitializePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdinitializePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to initialize.
            var body = new InitializePaymentRequest(); // InitializePaymentRequest |  (optional) 

            try
            {
                // Initialize the payment in a cart - {InitializePaymentRequest}
                Cart result = apiInstance.InitializePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdinitializePost(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.InitializePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdinitializePost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The unique identifier of the payment to initialize. | 
 **body** | [**InitializePaymentRequest**](InitializePaymentRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshpaymentrequestscopeidcustomeridcartnamepaymentspaymentidrefreshpost"></a>
# **RefreshPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdrefreshPost**
> Cart RefreshPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdrefreshPost (string accept, string scopeId, string customerId, string cartName, string paymentId, RefreshPaymentRequest body = null)

Refresh the payment in a cart - {RefreshPaymentRequest}

Refresh the payment in a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RefreshPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdrefreshPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to refresh.
            var body = new RefreshPaymentRequest(); // RefreshPaymentRequest |  (optional) 

            try
            {
                // Refresh the payment in a cart - {RefreshPaymentRequest}
                Cart result = apiInstance.RefreshPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdrefreshPost(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RefreshPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdrefreshPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The unique identifier of the payment to refresh. | 
 **body** | [**RefreshPaymentRequest**](RefreshPaymentRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removealllineitemsrequestscopeidcustomeridcartnameremovealllineitemsdelete"></a>
# **RemoveAllLineItemsRequestScopeIdCustomerIdCartNameremoveAllLineItemsDelete**
> ProcessedCart RemoveAllLineItemsRequestScopeIdCustomerIdCartNameremoveAllLineItemsDelete (string accept, string scopeId, string customerId, string cartName, string cultureName = null, string workflowToExecute = null)

Remove all the line items from a cart - {RemoveAllLineItemsRequest}

Remove all the line items from a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveAllLineItemsRequestScopeIdCustomerIdCartNameremoveAllLineItemsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Remove all the line items from a cart - {RemoveAllLineItemsRequest}
                ProcessedCart result = apiInstance.RemoveAllLineItemsRequestScopeIdCustomerIdCartNameremoveAllLineItemsDelete(accept, scopeId, customerId, cartName, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RemoveAllLineItemsRequestScopeIdCustomerIdCartNameremoveAllLineItemsDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="removecouponrequestscopeidcustomeridcartnamecouponscouponcodedelete"></a>
# **RemoveCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodeDelete**
> ProcessedCart RemoveCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodeDelete (string accept, string scopeId, string customerId, string cartName, string couponCode, string cultureName = null, string workflowToExecute = null)

Remove a coupon from a cart - {RemoveCouponRequest}

Remove a coupon from a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodeDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var couponCode = couponCode_example;  // string | The unique identifier of the Coupon to be removed.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Remove a coupon from a cart - {RemoveCouponRequest}
                ProcessedCart result = apiInstance.RemoveCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodeDelete(accept, scopeId, customerId, cartName, couponCode, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RemoveCouponRequestScopeIdCustomerIdCartNamecouponsCouponCodeDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **couponCode** | **string**| The unique identifier of the Coupon to be removed. | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="removelineitemrequestscopeidcustomeridcartnamelineitemsiddelete"></a>
# **RemoveLineItemRequestScopeIdCustomerIdCartNamelineItemsIdDelete**
> ProcessedCart RemoveLineItemRequestScopeIdCustomerIdCartNamelineItemsIdDelete (string accept, string scopeId, string customerId, string cartName, string id, string cultureName = null, string workflowToExecute = null)

Remove a line item from a cart - {RemoveLineItemRequest}

Remove a line item from a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveLineItemRequestScopeIdCustomerIdCartNamelineItemsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the LineItem to be removed.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Remove a line item from a cart - {RemoveLineItemRequest}
                ProcessedCart result = apiInstance.RemoveLineItemRequestScopeIdCustomerIdCartNamelineItemsIdDelete(accept, scopeId, customerId, cartName, id, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RemoveLineItemRequestScopeIdCustomerIdCartNamelineItemsIdDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the LineItem to be removed. | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="removelineitemsinshipmentrequestscopeidcustomeridcartnameshipmentsshipmentidlineitemsdelete"></a>
# **RemoveLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsDelete**
> ProcessedCart RemoveLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsDelete (string accept, string scopeId, string customerId, string cartName, string shipmentId, string cultureName = null, string workflowToExecute = null)

Remove all the line items from a shipment - {RemoveLineItemsInShipmentRequest}

Remove all the line items from a shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var shipmentId = shipmentId_example;  // string | The unique identifier of the Shipment to consider.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Remove all the line items from a shipment - {RemoveLineItemsInShipmentRequest}
                ProcessedCart result = apiInstance.RemoveLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsDelete(accept, scopeId, customerId, cartName, shipmentId, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RemoveLineItemsInShipmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdlineItemsDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **shipmentId** | **string**| The unique identifier of the Shipment to consider. | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="removelineitemsrequestscopeidcustomeridcartnamelineitemsbatchdelete"></a>
# **RemoveLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchDelete**
> ProcessedCart RemoveLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchDelete (string accept, string scopeId, string customerId, string cartName, List<string> lineItemIds, string cultureName = null, string workflowToExecute = null)

Remove multiple line items from a cart - {RemoveLineItemsRequest}

Remove multiple line items from a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var lineItemIds = new List<string>(); // List<string> | The unique identifier of the LineItems to be removed.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Remove multiple line items from a cart - {RemoveLineItemsRequest}
                ProcessedCart result = apiInstance.RemoveLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchDelete(accept, scopeId, customerId, cartName, lineItemIds, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RemoveLineItemsRequestScopeIdCustomerIdCartNamelineItemsbatchDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **lineItemIds** | [**List&lt;string&gt;**](string.md)| The unique identifier of the LineItems to be removed. | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="removepaymentrequestscopeidcustomeridcartnamepaymentsiddelete"></a>
# **RemovePaymentRequestScopeIdCustomerIdCartNamepaymentsIdDelete**
> ProcessedCart RemovePaymentRequestScopeIdCustomerIdCartNamepaymentsIdDelete (string accept, string scopeId, string customerId, string cartName, string id, string cultureName = null, string workflowToExecute = null)

Removes a payment from a cart - {RemovePaymentRequest}

Removes a payment from a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemovePaymentRequestScopeIdCustomerIdCartNamepaymentsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the Payment to be removed.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Removes a payment from a cart - {RemovePaymentRequest}
                ProcessedCart result = apiInstance.RemovePaymentRequestScopeIdCustomerIdCartNamepaymentsIdDelete(accept, scopeId, customerId, cartName, id, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RemovePaymentRequestScopeIdCustomerIdCartNamepaymentsIdDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the Payment to be removed. | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="removeshipmentrequestscopeidcustomeridcartnameshipmentsiddelete"></a>
# **RemoveShipmentRequestScopeIdCustomerIdCartNameshipmentsIdDelete**
> ProcessedCart RemoveShipmentRequestScopeIdCustomerIdCartNameshipmentsIdDelete (string accept, string scopeId, string customerId, string cartName, string id, string cultureName = null, string workflowToExecute = null)

Removes a shipment from a cart - {RemoveShipmentRequest}

Removes a shipment from a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RemoveShipmentRequestScopeIdCustomerIdCartNameshipmentsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the Shipment to be removed.
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned. (optional) 
            var workflowToExecute = workflowToExecute_example;  // string | The name of the workflow that should be executed. (optional) 

            try
            {
                // Removes a shipment from a cart - {RemoveShipmentRequest}
                ProcessedCart result = apiInstance.RemoveShipmentRequestScopeIdCustomerIdCartNameshipmentsIdDelete(accept, scopeId, customerId, cartName, id, cultureName, workflowToExecute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.RemoveShipmentRequestScopeIdCustomerIdCartNameshipmentsIdDelete: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the Shipment to be removed. | 
 **cultureName** | **string**| The culture name in which language the data will be returned. | [optional] 
 **workflowToExecute** | **string**| The name of the workflow that should be executed. | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="reservetimeslotrequestscopeidcustomeridcartnameshipmentsshipmentidtimeslotidpost"></a>
# **ReserveTimeSlotRequestScopeIdCustomerIdCartNameshipmentsShipmentIdTimeSlotIdPost**
> ProcessedCart ReserveTimeSlotRequestScopeIdCustomerIdCartNameshipmentsShipmentIdTimeSlotIdPost (string accept, string scopeId, string customerId, string cartName, string shipmentId, string timeSlotId, ReserveTimeSlotRequest body = null)

Adds or renew a timeslot reservation for a cart - {ReserveTimeSlotRequest}

Adds or renew a timeslot reservation for a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ReserveTimeSlotRequestScopeIdCustomerIdCartNameshipmentsShipmentIdTimeSlotIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var shipmentId = shipmentId_example;  // string | The unique identifier of the Shipment.
            var timeSlotId = timeSlotId_example;  // string | The unique identifier of the fullfilment timeslot to reserve.
            var body = new ReserveTimeSlotRequest(); // ReserveTimeSlotRequest |  (optional) 

            try
            {
                // Adds or renew a timeslot reservation for a cart - {ReserveTimeSlotRequest}
                ProcessedCart result = apiInstance.ReserveTimeSlotRequestScopeIdCustomerIdCartNameshipmentsShipmentIdTimeSlotIdPost(accept, scopeId, customerId, cartName, shipmentId, timeSlotId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.ReserveTimeSlotRequestScopeIdCustomerIdCartNameshipmentsShipmentIdTimeSlotIdPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **shipmentId** | **string**| The unique identifier of the Shipment. | 
 **timeSlotId** | **string**| The unique identifier of the fullfilment timeslot to reserve. | 
 **body** | [**ReserveTimeSlotRequest**](ReserveTimeSlotRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="setadjustmentrequestscopeidcustomeridcartnameshipmentsshipmentidadjustmentcreate"></a>
# **SetAdjustmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdadjustmentCreate**
> ProcessedCart SetAdjustmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdadjustmentCreate (string accept, string scopeId, string customerId, string cartName, string shipmentId, SetAdjustmentRequest body = null)

Set the adjustment of a shipment - {SetAdjustmentRequest}

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
    public class SetAdjustmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdadjustmentCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var shipmentId = shipmentId_example;  // string | The unique identifier of the shipment to adjust
            var body = new SetAdjustmentRequest(); // SetAdjustmentRequest |  (optional) 

            try
            {
                // Set the adjustment of a shipment - {SetAdjustmentRequest}
                ProcessedCart result = apiInstance.SetAdjustmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdadjustmentCreate(accept, scopeId, customerId, cartName, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.SetAdjustmentRequestScopeIdCustomerIdCartNameshipmentsShipmentIdadjustmentCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **shipmentId** | **string**| The unique identifier of the shipment to adjust | 
 **body** | [**SetAdjustmentRequest**](SetAdjustmentRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="settlepaymentrequestscopeidcustomeridcartnamepaymentspaymentidsettlepost"></a>
# **SettlePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdsettlePost**
> Cart SettlePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdsettlePost (string accept, string scopeId, string customerId, string cartName, string paymentId, SettlePaymentRequest body = null)

Settle the payment in a cart - {SettlePaymentRequest}

Settle the payment in a cart - The payment has to be authorized before being settled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SettlePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdsettlePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to settle.
            var body = new SettlePaymentRequest(); // SettlePaymentRequest |  (optional) 

            try
            {
                // Settle the payment in a cart - {SettlePaymentRequest}
                Cart result = apiInstance.SettlePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdsettlePost(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.SettlePaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdsettlePost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The unique identifier of the payment to settle. | 
 **body** | [**SettlePaymentRequest**](SettlePaymentRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingaddressrequestscopeidcustomeridcartnamepaymentspaymentidbillingaddresscreate"></a>
# **UpdateBillingAddressRequestScopeIdCustomerIdCartNamepaymentsPaymentIdbillingAddressCreate**
> ProcessedCart UpdateBillingAddressRequestScopeIdCustomerIdCartNamepaymentsPaymentIdbillingAddressCreate (string accept, string scopeId, string customerId, string cartName, string paymentId, UpdateBillingAddressRequest body = null)

Update the billing address of a payment - {UpdateBillingAddressRequest}

Update the billing address of a payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateBillingAddressRequestScopeIdCustomerIdCartNamepaymentsPaymentIdbillingAddressCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The Id of the payment
            var body = new UpdateBillingAddressRequest(); // UpdateBillingAddressRequest |  (optional) 

            try
            {
                // Update the billing address of a payment - {UpdateBillingAddressRequest}
                ProcessedCart result = apiInstance.UpdateBillingAddressRequestScopeIdCustomerIdCartNamepaymentsPaymentIdbillingAddressCreate(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdateBillingAddressRequestScopeIdCustomerIdCartNamepaymentsPaymentIdbillingAddressCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The Id of the payment | 
 **body** | [**UpdateBillingAddressRequest**](UpdateBillingAddressRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="updatecartrequestscopeidcustomeridcartnamecreate"></a>
# **UpdateCartRequestScopeIdCustomerIdCartNameCreate**
> ProcessedCart UpdateCartRequestScopeIdCustomerIdCartNameCreate (string accept, string scopeId, string customerId, string cartName, UpdateCartRequest body = null)

Update the cart - {UpdateCartRequest}

Update the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCartRequestScopeIdCustomerIdCartNameCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var body = new UpdateCartRequest(); // UpdateCartRequest |  (optional) 

            try
            {
                // Update the cart - {UpdateCartRequest}
                ProcessedCart result = apiInstance.UpdateCartRequestScopeIdCustomerIdCartNameCreate(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdateCartRequestScopeIdCustomerIdCartNameCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **body** | [**UpdateCartRequest**](UpdateCartRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="updatecustomersummaryrequestscopeidcustomeridcartnamecustomercreate"></a>
# **UpdateCustomerSummaryRequestScopeIdCustomerIdCartNamecustomerCreate**
> CustomerSummary UpdateCustomerSummaryRequestScopeIdCustomerIdCartNamecustomerCreate (string accept, string scopeId, string customerId, string cartName, UpdateCustomerSummaryRequest body = null)

Update the customer summary of a cart - {UpdateCustomerSummaryRequest}

Update the customer summary of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCustomerSummaryRequestScopeIdCustomerIdCartNamecustomerCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var body = new UpdateCustomerSummaryRequest(); // UpdateCustomerSummaryRequest |  (optional) 

            try
            {
                // Update the customer summary of a cart - {UpdateCustomerSummaryRequest}
                CustomerSummary result = apiInstance.UpdateCustomerSummaryRequestScopeIdCustomerIdCartNamecustomerCreate(accept, scopeId, customerId, cartName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdateCustomerSummaryRequestScopeIdCustomerIdCartNamecustomerCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **body** | [**UpdateCustomerSummaryRequest**](UpdateCustomerSummaryRequest.md)|  | [optional] 

### Return type

[**CustomerSummary**](CustomerSummary.md)

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

<a name="updatelineitemrequestscopeidcustomeridcartnamelineitemsidcreate"></a>
# **UpdateLineItemRequestScopeIdCustomerIdCartNamelineItemsIdCreate**
> ProcessedCart UpdateLineItemRequestScopeIdCustomerIdCartNamelineItemsIdCreate (string accept, string scopeId, string customerId, string cartName, string id, UpdateLineItemRequest body = null)

Update a line item of a cart - {UpdateLineItemRequest}

Update a line item of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateLineItemRequestScopeIdCustomerIdCartNamelineItemsIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the LineItem to update.
            var body = new UpdateLineItemRequest(); // UpdateLineItemRequest |  (optional) 

            try
            {
                // Update a line item of a cart - {UpdateLineItemRequest}
                ProcessedCart result = apiInstance.UpdateLineItemRequestScopeIdCustomerIdCartNamelineItemsIdCreate(accept, scopeId, customerId, cartName, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdateLineItemRequestScopeIdCustomerIdCartNamelineItemsIdCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the LineItem to update. | 
 **body** | [**UpdateLineItemRequest**](UpdateLineItemRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="updatepaymentamountrequestscopeidcustomeridcartnamepaymentspaymentidamountcreate"></a>
# **UpdatePaymentAmountRequestScopeIdCustomerIdCartNamepaymentsPaymentIdamountCreate**
> ProcessedCart UpdatePaymentAmountRequestScopeIdCustomerIdCartNamepaymentsPaymentIdamountCreate (string accept, string scopeId, string customerId, string cartName, string paymentId, UpdatePaymentAmountRequest body = null)

Update the amount of a payment - {UpdatePaymentAmountRequest}

Update the amount of a payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePaymentAmountRequestScopeIdCustomerIdCartNamepaymentsPaymentIdamountCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The Id of the payment
            var body = new UpdatePaymentAmountRequest(); // UpdatePaymentAmountRequest |  (optional) 

            try
            {
                // Update the amount of a payment - {UpdatePaymentAmountRequest}
                ProcessedCart result = apiInstance.UpdatePaymentAmountRequestScopeIdCustomerIdCartNamepaymentsPaymentIdamountCreate(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdatePaymentAmountRequestScopeIdCustomerIdCartNamepaymentsPaymentIdamountCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The Id of the payment | 
 **body** | [**UpdatePaymentAmountRequest**](UpdatePaymentAmountRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="updatepaymentmethodrequestscopeidcustomeridcartnamepaymentspaymentidmethodcreate"></a>
# **UpdatePaymentMethodRequestScopeIdCustomerIdCartNamepaymentsPaymentIdmethodCreate**
> ProcessedCart UpdatePaymentMethodRequestScopeIdCustomerIdCartNamepaymentsPaymentIdmethodCreate (string accept, string scopeId, string customerId, string cartName, string paymentId, UpdatePaymentMethodRequest body = null)

Update a payment method of a payment - {UpdatePaymentMethodRequest}

Update a payment method of a payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePaymentMethodRequestScopeIdCustomerIdCartNamepaymentsPaymentIdmethodCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The Id of the payment
            var body = new UpdatePaymentMethodRequest(); // UpdatePaymentMethodRequest |  (optional) 

            try
            {
                // Update a payment method of a payment - {UpdatePaymentMethodRequest}
                ProcessedCart result = apiInstance.UpdatePaymentMethodRequestScopeIdCustomerIdCartNamepaymentsPaymentIdmethodCreate(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdatePaymentMethodRequestScopeIdCustomerIdCartNamepaymentsPaymentIdmethodCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The Id of the payment | 
 **body** | [**UpdatePaymentMethodRequest**](UpdatePaymentMethodRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="updatepaymentrequestscopeidcustomeridcartnamepaymentsidcreate"></a>
# **UpdatePaymentRequestScopeIdCustomerIdCartNamepaymentsIdCreate**
> ProcessedCart UpdatePaymentRequestScopeIdCustomerIdCartNamepaymentsIdCreate (string accept, string scopeId, string customerId, string cartName, string id, UpdatePaymentRequest body = null)

Update a payment of a cart - {UpdatePaymentRequest}

Update a payment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePaymentRequestScopeIdCustomerIdCartNamepaymentsIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the Payment to update.
            var body = new UpdatePaymentRequest(); // UpdatePaymentRequest |  (optional) 

            try
            {
                // Update a payment of a cart - {UpdatePaymentRequest}
                ProcessedCart result = apiInstance.UpdatePaymentRequestScopeIdCustomerIdCartNamepaymentsIdCreate(accept, scopeId, customerId, cartName, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdatePaymentRequestScopeIdCustomerIdCartNamepaymentsIdCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the Payment to update. | 
 **body** | [**UpdatePaymentRequest**](UpdatePaymentRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="updateshipmentrequestscopeidcustomeridcartnameshipmentsidcreate"></a>
# **UpdateShipmentRequestScopeIdCustomerIdCartNameshipmentsIdCreate**
> ProcessedCart UpdateShipmentRequestScopeIdCustomerIdCartNameshipmentsIdCreate (string accept, string scopeId, string customerId, string cartName, string id, UpdateShipmentRequest body = null)

Update a shipment of a cart - {UpdateShipmentRequest}

Update a shipment of a cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateShipmentRequestScopeIdCustomerIdCartNameshipmentsIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var id = id_example;  // string | The unique identifier of the Shipment to update.
            var body = new UpdateShipmentRequest(); // UpdateShipmentRequest |  (optional) 

            try
            {
                // Update a shipment of a cart - {UpdateShipmentRequest}
                ProcessedCart result = apiInstance.UpdateShipmentRequestScopeIdCustomerIdCartNameshipmentsIdCreate(accept, scopeId, customerId, cartName, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.UpdateShipmentRequestScopeIdCustomerIdCartNameshipmentsIdCreate: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **id** | **string**| The unique identifier of the Shipment to update. | 
 **body** | [**UpdateShipmentRequest**](UpdateShipmentRequest.md)|  | [optional] 

### Return type

[**ProcessedCart**](ProcessedCart.md)

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

<a name="voidpaymentrequestscopeidcustomeridcartnamepaymentspaymentidvoidpost"></a>
# **VoidPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdvoidPost**
> Cart VoidPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdvoidPost (string accept, string scopeId, string customerId, string cartName, string paymentId, VoidPaymentRequest body = null)

Void the payment in a cart - {VoidPaymentRequest}

Void the payment in a cart. A payment already with status Paid cannot be voided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class VoidPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdvoidPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CartsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var customerId = customerId_example;  // string | The unique identifier of the Customer owning the cart
            var cartName = cartName_example;  // string | The name associated to the requested cart
            var paymentId = paymentId_example;  // string | The unique identifier of the payment to void.
            var body = new VoidPaymentRequest(); // VoidPaymentRequest |  (optional) 

            try
            {
                // Void the payment in a cart - {VoidPaymentRequest}
                Cart result = apiInstance.VoidPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdvoidPost(accept, scopeId, customerId, cartName, paymentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartsApi.VoidPaymentRequestScopeIdCustomerIdCartNamepaymentsPaymentIdvoidPost: " + e.Message );
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
 **customerId** | **string**| The unique identifier of the Customer owning the cart | 
 **cartName** | **string**| The name associated to the requested cart | 
 **paymentId** | **string**| The unique identifier of the payment to void. | 
 **body** | [**VoidPaymentRequest**](VoidPaymentRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

