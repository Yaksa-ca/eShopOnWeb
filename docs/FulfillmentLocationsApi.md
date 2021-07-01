# Yaksa.OrckestraCommerce.Client.Api.FulfillmentLocationsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsPost**](FulfillmentLocationsApi.md#addfulfillmentlocationtimeslotrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotspost) | **POST** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots/ | Adds a time slot from a fulfillment location for a specific scope - {AddFulfillmentLocationTimeSlotRequest}
[**AddFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotIdPost**](FulfillmentLocationsApi.md#addfulfillmentlocationtimeslotreservationrequestscopeidfulfillmentlocationidreservationsslotidpost) | **POST** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/reservations/{SlotId} | Adds a time slot reservation for a specific time slot - {AddFulfillmentLocationTimeSlotReservationRequest}
[**AddFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsseveralPost**](FulfillmentLocationsApi.md#addfulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsseveralpost) | **POST** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots/several | Adds a list of time slots from a fulfillment location for a specific scope - {AddFulfillmentLocationTimeSlotsRequest}
[**CalculateFulfillmentLocationsDelayRequestScopeIdcalculateDelayPost**](FulfillmentLocationsApi.md#calculatefulfillmentlocationsdelayrequestscopeidcalculatedelaypost) | **POST** /fulfillmentLocations/{ScopeId}/calculateDelay | Calculate the delay for a list of fulfillment locations - {CalculateFulfillmentLocationsDelayRequest}
[**CalculateScheduleAvailabilitySlotsRequestFulfillmentLocationIdFulfillmentTypePost**](FulfillmentLocationsApi.md#calculatescheduleavailabilityslotsrequestfulfillmentlocationidfulfillmenttypepost) | **POST** /fulfillmentLocations/{FulfillmentLocationId}/{FulfillmentType} |  Combines a schedule and slot plan to calculate the availability of slots for the specified dates. - {CalculateScheduleAvailabilitySlotsRequest}
[**CheckAvailabilitySlotRequestforSlotFulfillmentLocationIdFulfillmentTypePost**](FulfillmentLocationsApi.md#checkavailabilityslotrequestforslotfulfillmentlocationidfulfillmenttypepost) | **POST** /fulfillmentLocations/forSlot/{FulfillmentLocationId}/{FulfillmentType} | Checks the availability of a specific slot time on a specific date using the calculated schedule availability. - {CheckAvailabilitySlotRequest}
[**DeleteFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdDelete**](FulfillmentLocationsApi.md#deletefulfillmentlocationtimeslotrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsslotiddelete) | **DELETE** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots/{SlotId} | Deletes a time slot from a fulfillment location for a specific scope - {DeleteFulfillmentLocationTimeSlotRequest}
[**DeleteFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdDelete**](FulfillmentLocationsApi.md#deletefulfillmentlocationtimeslotreservationrequestscopeidfulfillmentlocationidreservationsbyidslotreservationiddelete) | **DELETE** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/reservations/byId/{SlotReservationId} | Deletes a time slot reservation - {DeleteFulfillmentLocationTimeSlotReservationRequest}
[**DeleteFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsDelete**](FulfillmentLocationsApi.md#deletefulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsdelete) | **DELETE** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots | Deletes a time slot from a fulfillment location for a specific scope - {DeleteFulfillmentLocationTimeSlotsRequest}
[**FindFulfillmentLocationsRequestScopeIdfindPost**](FulfillmentLocationsApi.md#findfulfillmentlocationsrequestscopeidfindpost) | **POST** /fulfillmentLocations/{ScopeId}/find | Search for fulfillment locations - {FindFulfillmentLocationsRequest}
[**GetDeliveryFulfillmentLocationsByScopeRequestScopeIddeliveryGet**](FulfillmentLocationsApi.md#getdeliveryfulfillmentlocationsbyscoperequestscopeiddeliveryget) | **GET** /fulfillmentLocations/{ScopeId}/delivery | Retrieve fulfillment locations supporting delivery as Fulfillment method for a specific scope - {GetDeliveryFulfillmentLocationsByScopeRequest}
[**GetFulfillmentAvailabilityRequestScopeIdavailabiltyPost**](FulfillmentLocationsApi.md#getfulfillmentavailabilityrequestscopeidavailabiltypost) | **POST** /fulfillmentLocations/{ScopeId}/availabilty | Get the availability of a fulfillment location depending on specific time for a specific scope - {GetFulfillmentAvailabilityRequest}
[**GetFulfillmentLocationByIdElapsedTimeRequestScopeIdFulfillmentLocationIdelapsedTimeGet**](FulfillmentLocationsApi.md#getfulfillmentlocationbyidelapsedtimerequestscopeidfulfillmentlocationidelapsedtimeget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/elapsedTime | Retrieve an elapsed time based on fulfillment location schedules - {GetFulfillmentLocationByIdElapsedTimeRequest}
[**GetFulfillmentLocationByIdRequestScopeIdFulfillmentLocationIdGet**](FulfillmentLocationsApi.md#getfulfillmentlocationbyidrequestscopeidfulfillmentlocationidget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId} | Retrieve a fulfillment location for a specific scope - {GetFulfillmentLocationByIdRequest}
[**GetFulfillmentLocationTimeSlotByIdRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdGet**](FulfillmentLocationsApi.md#getfulfillmentlocationtimeslotbyidrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsslotidget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots/{SlotId} | Retrieves a time slot from a fulfillment location for a specific scope - {GetFulfillmentLocationTimeSlotByIdRequest}
[**GetFulfillmentLocationTimeSlotReservationByIdRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdGet**](FulfillmentLocationsApi.md#getfulfillmentlocationtimeslotreservationbyidrequestscopeidfulfillmentlocationidreservationsbyidslotreservationidget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/reservations/byId/{SlotReservationId} | Retrieves a time slot reservation - {GetFulfillmentLocationTimeSlotReservationByIdRequest}
[**GetFulfillmentLocationTimeSlotReservationsRequestScopeIdFulfillmentLocationIdreservationsSlotIdGet**](FulfillmentLocationsApi.md#getfulfillmentlocationtimeslotreservationsrequestscopeidfulfillmentlocationidreservationsslotidget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/reservations/{SlotId} | Retrieves time slot reservations - {GetFulfillmentLocationTimeSlotReservationsRequest}
[**GetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsGet**](FulfillmentLocationsApi.md#getfulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots/ | Retrieves time slots from a fulfillment location for a specific scope - {GetFulfillmentLocationTimeSlotsRequest}
[**GetFulfillmentLocationsByInventoryLocationIdsRequestScopeIdInventoryLocationIdsGet**](FulfillmentLocationsApi.md#getfulfillmentlocationsbyinventorylocationidsrequestscopeidinventorylocationidsget) | **GET** /fulfillmentLocations/{ScopeId}/{InventoryLocationIds} | Retrieves a list of fulfillment locations for scpecific inventory locations identifiers - {GetFulfillmentLocationsByInventoryLocationIdsRequest}
[**GetFulfillmentLocationsByScopeRequestScopeIdGet**](FulfillmentLocationsApi.md#getfulfillmentlocationsbyscoperequestscopeidget) | **GET** /fulfillmentLocations/{ScopeId} | Retrieve fulfillment locations for a specific scope - {GetFulfillmentLocationsByScopeRequest}
[**GetOperatingStatusRequestScopeIdFulfillmentLocationIdoperatingStatusGet**](FulfillmentLocationsApi.md#getoperatingstatusrequestscopeidfulfillmentlocationidoperatingstatusget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/operatingStatus | Retreive a specific store&#39;s OperatingStatus - {GetOperatingStatusRequest}
[**GetPickupFulfillmentLocationsByScopeRequestScopeIdpickupGet**](FulfillmentLocationsApi.md#getpickupfulfillmentlocationsbyscoperequestscopeidpickupget) | **GET** /fulfillmentLocations/{ScopeId}/pickup | Retrieve fulfillment locations supporting pickup as shipping method for a specific scope - {GetPickupFulfillmentLocationsByScopeRequest}
[**GetScheduleRequestScopeIdFulfillmentLocationIdscheduleGet**](FulfillmentLocationsApi.md#getschedulerequestscopeidfulfillmentlocationidscheduleget) | **GET** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/schedule | Retreive a specific store&#39;s Schedule - {GetScheduleRequest}
[**GetShippingFulfillmentLocationsByScopeRequestScopeIdshippingGet**](FulfillmentLocationsApi.md#getshippingfulfillmentlocationsbyscoperequestscopeidshippingget) | **GET** /fulfillmentLocations/{ScopeId}/shipping | Retrieve fulfillment locations supporting shipping as shipping method for a specific scope - {GetShippingFulfillmentLocationsByScopeRequest}
[**ReserveAvailabilitySlotRequestreserveSlotFulfillmentLocationIdPost**](FulfillmentLocationsApi.md#reserveavailabilityslotrequestreserveslotfulfillmentlocationidpost) | **POST** /fulfillmentLocations/reserveSlot/{FulfillmentLocationId} | Reserves a fulfillment slot for the Shipment of an Order. (Not implemented in default provider) - {ReserveAvailabilitySlotRequest}
[**ResetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsresetCreate**](FulfillmentLocationsApi.md#resetfulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsresetcreate) | **PUT** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots/reset | Delete all time slot from a fulfillment location for a specific scope and add the list of time slots - {ResetFulfillmentLocationTimeSlotsRequest}
[**SetFulfillmentLocationInventoryManagementRequestScopeIdFulfillmentLocationIdinventoryCreate**](FulfillmentLocationsApi.md#setfulfillmentlocationinventorymanagementrequestscopeidfulfillmentlocationidinventorycreate) | **PUT** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/inventory | Updates the inventory informations for a specified fulfillment location. - {SetFulfillmentLocationInventoryManagementRequest}
[**UpdateFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdCreate**](FulfillmentLocationsApi.md#updatefulfillmentlocationtimeslotrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsslotidcreate) | **PUT** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/{FulfillmentMethodType}/slots/{SlotId} | Updates a time slot from a fulfillment location for a specific scope - {UpdateFulfillmentLocationTimeSlotRequest}
[**UpdateFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotReservationIdCreate**](FulfillmentLocationsApi.md#updatefulfillmentlocationtimeslotreservationrequestscopeidfulfillmentlocationidreservationsslotreservationidcreate) | **PUT** /fulfillmentLocations/{ScopeId}/{FulfillmentLocationId}/reservations/{SlotReservationId} | Updates a time slot reservation - {UpdateFulfillmentLocationTimeSlotReservationRequest}


<a name="addfulfillmentlocationtimeslotrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotspost"></a>
# **AddFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsPost**
> TimeSlot AddFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsPost (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType, AddFulfillmentLocationTimeSlotRequest body = null)

Adds a time slot from a fulfillment location for a specific scope - {AddFulfillmentLocationTimeSlotRequest}

Adds a time slot from a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var body = new AddFulfillmentLocationTimeSlotRequest(); // AddFulfillmentLocationTimeSlotRequest |  (optional) 

            try
            {
                // Adds a time slot from a fulfillment location for a specific scope - {AddFulfillmentLocationTimeSlotRequest}
                TimeSlot result = apiInstance.AddFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsPost(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.AddFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsPost: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **body** | [**AddFulfillmentLocationTimeSlotRequest**](AddFulfillmentLocationTimeSlotRequest.md)|  | [optional] 

### Return type

[**TimeSlot**](TimeSlot.md)

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

<a name="addfulfillmentlocationtimeslotreservationrequestscopeidfulfillmentlocationidreservationsslotidpost"></a>
# **AddFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotIdPost**
> TimeSlotReservation AddFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotIdPost (string accept, string scopeId, string fulfillmentLocationId, string slotId, AddFulfillmentLocationTimeSlotReservationRequest body = null)

Adds a time slot reservation for a specific time slot - {AddFulfillmentLocationTimeSlotReservationRequest}

Adds a time slot reservation for a specific time slot.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var slotId = slotId_example;  // string | The unique identifier of the time slot.
            var body = new AddFulfillmentLocationTimeSlotReservationRequest(); // AddFulfillmentLocationTimeSlotReservationRequest |  (optional) 

            try
            {
                // Adds a time slot reservation for a specific time slot - {AddFulfillmentLocationTimeSlotReservationRequest}
                TimeSlotReservation result = apiInstance.AddFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotIdPost(accept, scopeId, fulfillmentLocationId, slotId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.AddFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotIdPost: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **slotId** | **string**| The unique identifier of the time slot. | 
 **body** | [**AddFulfillmentLocationTimeSlotReservationRequest**](AddFulfillmentLocationTimeSlotReservationRequest.md)|  | [optional] 

### Return type

[**TimeSlotReservation**](TimeSlotReservation.md)

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

<a name="addfulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsseveralpost"></a>
# **AddFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsseveralPost**
> List&lt;TimeSlot&gt; AddFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsseveralPost (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType, AddFulfillmentLocationTimeSlotsRequest body = null)

Adds a list of time slots from a fulfillment location for a specific scope - {AddFulfillmentLocationTimeSlotsRequest}

Adds a list of time slots from a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsseveralPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var body = new AddFulfillmentLocationTimeSlotsRequest(); // AddFulfillmentLocationTimeSlotsRequest |  (optional) 

            try
            {
                // Adds a list of time slots from a fulfillment location for a specific scope - {AddFulfillmentLocationTimeSlotsRequest}
                List<TimeSlot> result = apiInstance.AddFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsseveralPost(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.AddFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsseveralPost: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **body** | [**AddFulfillmentLocationTimeSlotsRequest**](AddFulfillmentLocationTimeSlotsRequest.md)|  | [optional] 

### Return type

[**List&lt;TimeSlot&gt;**](TimeSlot.md)

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

<a name="calculatefulfillmentlocationsdelayrequestscopeidcalculatedelaypost"></a>
# **CalculateFulfillmentLocationsDelayRequestScopeIdcalculateDelayPost**
> FulfillmentLocationsDelayCalculationResult CalculateFulfillmentLocationsDelayRequestScopeIdcalculateDelayPost (string accept, string scopeId, CalculateFulfillmentLocationsDelayRequest body = null)

Calculate the delay for a list of fulfillment locations - {CalculateFulfillmentLocationsDelayRequest}

Calculate the delay for a list of fulfillment locations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CalculateFulfillmentLocationsDelayRequestScopeIdcalculateDelayPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CalculateFulfillmentLocationsDelayRequest(); // CalculateFulfillmentLocationsDelayRequest |  (optional) 

            try
            {
                // Calculate the delay for a list of fulfillment locations - {CalculateFulfillmentLocationsDelayRequest}
                FulfillmentLocationsDelayCalculationResult result = apiInstance.CalculateFulfillmentLocationsDelayRequestScopeIdcalculateDelayPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.CalculateFulfillmentLocationsDelayRequestScopeIdcalculateDelayPost: " + e.Message );
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
 **body** | [**CalculateFulfillmentLocationsDelayRequest**](CalculateFulfillmentLocationsDelayRequest.md)|  | [optional] 

### Return type

[**FulfillmentLocationsDelayCalculationResult**](FulfillmentLocationsDelayCalculationResult.md)

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

<a name="calculatescheduleavailabilityslotsrequestfulfillmentlocationidfulfillmenttypepost"></a>
# **CalculateScheduleAvailabilitySlotsRequestFulfillmentLocationIdFulfillmentTypePost**
> DayAvailabilityResult CalculateScheduleAvailabilitySlotsRequestFulfillmentLocationIdFulfillmentTypePost (string accept, string fulfillmentLocationId, string fulfillmentType, CalculateScheduleAvailabilitySlotsRequest body = null)

 Combines a schedule and slot plan to calculate the availability of slots for the specified dates. - {CalculateScheduleAvailabilitySlotsRequest}

Combines a schedule and slot plan to calculate the availability of slots for the specified dates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CalculateScheduleAvailabilitySlotsRequestFulfillmentLocationIdFulfillmentTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentType = fulfillmentType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var body = new CalculateScheduleAvailabilitySlotsRequest(); // CalculateScheduleAvailabilitySlotsRequest |  (optional) 

            try
            {
                //  Combines a schedule and slot plan to calculate the availability of slots for the specified dates. - {CalculateScheduleAvailabilitySlotsRequest}
                DayAvailabilityResult result = apiInstance.CalculateScheduleAvailabilitySlotsRequestFulfillmentLocationIdFulfillmentTypePost(accept, fulfillmentLocationId, fulfillmentType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.CalculateScheduleAvailabilitySlotsRequestFulfillmentLocationIdFulfillmentTypePost: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **body** | [**CalculateScheduleAvailabilitySlotsRequest**](CalculateScheduleAvailabilitySlotsRequest.md)|  | [optional] 

### Return type

[**DayAvailabilityResult**](DayAvailabilityResult.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkavailabilityslotrequestforslotfulfillmentlocationidfulfillmenttypepost"></a>
# **CheckAvailabilitySlotRequestforSlotFulfillmentLocationIdFulfillmentTypePost**
> string CheckAvailabilitySlotRequestforSlotFulfillmentLocationIdFulfillmentTypePost (string accept, string fulfillmentLocationId, string fulfillmentType, CheckAvailabilitySlotRequest body = null)

Checks the availability of a specific slot time on a specific date using the calculated schedule availability. - {CheckAvailabilitySlotRequest}

Checks the availability of a specific slot time on a specific date using the calculated schedule availability.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CheckAvailabilitySlotRequestforSlotFulfillmentLocationIdFulfillmentTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentType = fulfillmentType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var body = new CheckAvailabilitySlotRequest(); // CheckAvailabilitySlotRequest |  (optional) 

            try
            {
                // Checks the availability of a specific slot time on a specific date using the calculated schedule availability. - {CheckAvailabilitySlotRequest}
                string result = apiInstance.CheckAvailabilitySlotRequestforSlotFulfillmentLocationIdFulfillmentTypePost(accept, fulfillmentLocationId, fulfillmentType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.CheckAvailabilitySlotRequestforSlotFulfillmentLocationIdFulfillmentTypePost: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **body** | [**CheckAvailabilitySlotRequest**](CheckAvailabilitySlotRequest.md)|  | [optional] 

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentlocationtimeslotrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsslotiddelete"></a>
# **DeleteFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdDelete**
> void DeleteFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdDelete (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType, string slotId)

Deletes a time slot from a fulfillment location for a specific scope - {DeleteFulfillmentLocationTimeSlotRequest}

Deletes a time slot from a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var slotId = slotId_example;  // string | the unique identifier of the time slot.

            try
            {
                // Deletes a time slot from a fulfillment location for a specific scope - {DeleteFulfillmentLocationTimeSlotRequest}
                apiInstance.DeleteFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdDelete(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType, slotId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.DeleteFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdDelete: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **slotId** | **string**| the unique identifier of the time slot. | 

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

<a name="deletefulfillmentlocationtimeslotreservationrequestscopeidfulfillmentlocationidreservationsbyidslotreservationiddelete"></a>
# **DeleteFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdDelete**
> void DeleteFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdDelete (string accept, string scopeId, string fulfillmentLocationId, string slotReservationId, string slotId = null)

Deletes a time slot reservation - {DeleteFulfillmentLocationTimeSlotReservationRequest}

Deletes a time slot reservation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var slotReservationId = slotReservationId_example;  // string | the unique identifier of the time slot reservation.
            var slotId = slotId_example;  // string | The unique identifier of the time slot. (optional) 

            try
            {
                // Deletes a time slot reservation - {DeleteFulfillmentLocationTimeSlotReservationRequest}
                apiInstance.DeleteFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdDelete(accept, scopeId, fulfillmentLocationId, slotReservationId, slotId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.DeleteFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdDelete: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **slotReservationId** | **string**| the unique identifier of the time slot reservation. | 
 **slotId** | **string**| The unique identifier of the time slot. | [optional] 

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

<a name="deletefulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsdelete"></a>
# **DeleteFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsDelete**
> void DeleteFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsDelete (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType)

Deletes a time slot from a fulfillment location for a specific scope - {DeleteFulfillmentLocationTimeSlotsRequest}

Deletes all time slot from a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].

            try
            {
                // Deletes a time slot from a fulfillment location for a specific scope - {DeleteFulfillmentLocationTimeSlotsRequest}
                apiInstance.DeleteFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsDelete(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.DeleteFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsDelete: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 

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

<a name="findfulfillmentlocationsrequestscopeidfindpost"></a>
# **FindFulfillmentLocationsRequestScopeIdfindPost**
> FindFulfillmentLocationsQueryResult FindFulfillmentLocationsRequestScopeIdfindPost (string accept, string scopeId, FindFulfillmentLocationsRequest body = null)

Search for fulfillment locations - {FindFulfillmentLocationsRequest}

Search for fulfillment locations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindFulfillmentLocationsRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindFulfillmentLocationsRequest(); // FindFulfillmentLocationsRequest |  (optional) 

            try
            {
                // Search for fulfillment locations - {FindFulfillmentLocationsRequest}
                FindFulfillmentLocationsQueryResult result = apiInstance.FindFulfillmentLocationsRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.FindFulfillmentLocationsRequestScopeIdfindPost: " + e.Message );
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
 **body** | [**FindFulfillmentLocationsRequest**](FindFulfillmentLocationsRequest.md)|  | [optional] 

### Return type

[**FindFulfillmentLocationsQueryResult**](FindFulfillmentLocationsQueryResult.md)

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

<a name="getdeliveryfulfillmentlocationsbyscoperequestscopeiddeliveryget"></a>
# **GetDeliveryFulfillmentLocationsByScopeRequestScopeIddeliveryGet**
> List&lt;FulfillmentLocation&gt; GetDeliveryFulfillmentLocationsByScopeRequestScopeIddeliveryGet (string accept, string scopeId, bool? includeSchedules = null, bool? includeChildScopes = null, bool? onlyActive = null, bool? onlyInventoryEnabled = null, bool? includeAddresses = null)

Retrieve fulfillment locations supporting delivery as Fulfillment method for a specific scope - {GetDeliveryFulfillmentLocationsByScopeRequest}

Retrieve fulfillment locations supporting delivery as Fulfillment method for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetDeliveryFulfillmentLocationsByScopeRequestScopeIddeliveryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the fulfillment location. (optional) 
            var includeChildScopes = true;  // bool? | Includes the results for the child scopes. (optional) 
            var onlyActive = true;  // bool? | Filter the results to return only active. (optional) 
            var onlyInventoryEnabled = true;  // bool? | Filter the results to return only inventory enabled. (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load addresses of the fulfillment location. (optional) 

            try
            {
                // Retrieve fulfillment locations supporting delivery as Fulfillment method for a specific scope - {GetDeliveryFulfillmentLocationsByScopeRequest}
                List<FulfillmentLocation> result = apiInstance.GetDeliveryFulfillmentLocationsByScopeRequestScopeIddeliveryGet(accept, scopeId, includeSchedules, includeChildScopes, onlyActive, onlyInventoryEnabled, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetDeliveryFulfillmentLocationsByScopeRequestScopeIddeliveryGet: " + e.Message );
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
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the fulfillment location. | [optional] 
 **includeChildScopes** | **bool?**| Includes the results for the child scopes. | [optional] 
 **onlyActive** | **bool?**| Filter the results to return only active. | [optional] 
 **onlyInventoryEnabled** | **bool?**| Filter the results to return only inventory enabled. | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load addresses of the fulfillment location. | [optional] 

### Return type

[**List&lt;FulfillmentLocation&gt;**](FulfillmentLocation.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentavailabilityrequestscopeidavailabiltypost"></a>
# **GetFulfillmentAvailabilityRequestScopeIdavailabiltyPost**
> FulfillmentAvailability GetFulfillmentAvailabilityRequestScopeIdavailabiltyPost (string accept, string scopeId, GetFulfillmentAvailabilityRequest body = null)

Get the availability of a fulfillment location depending on specific time for a specific scope - {GetFulfillmentAvailabilityRequest}

Get the availability of a fulfillment location depending on specific time (in store timezone) for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentAvailabilityRequestScopeIdavailabiltyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetFulfillmentAvailabilityRequest(); // GetFulfillmentAvailabilityRequest |  (optional) 

            try
            {
                // Get the availability of a fulfillment location depending on specific time for a specific scope - {GetFulfillmentAvailabilityRequest}
                FulfillmentAvailability result = apiInstance.GetFulfillmentAvailabilityRequestScopeIdavailabiltyPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentAvailabilityRequestScopeIdavailabiltyPost: " + e.Message );
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
 **body** | [**GetFulfillmentAvailabilityRequest**](GetFulfillmentAvailabilityRequest.md)|  | [optional] 

### Return type

[**FulfillmentAvailability**](FulfillmentAvailability.md)

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

<a name="getfulfillmentlocationbyidelapsedtimerequestscopeidfulfillmentlocationidelapsedtimeget"></a>
# **GetFulfillmentLocationByIdElapsedTimeRequestScopeIdFulfillmentLocationIdelapsedTimeGet**
> GetFulfillmentLocationByIdElapsedTimeResult GetFulfillmentLocationByIdElapsedTimeRequestScopeIdFulfillmentLocationIdelapsedTimeGet (string accept, string scopeId, string fulfillmentLocationId, DateTime? startDate = null, DateTime? endDate = null, string scheduleType = null)

Retrieve an elapsed time based on fulfillment location schedules - {GetFulfillmentLocationByIdElapsedTimeRequest}

Retrieve an elapsed time based on fulfillment location schedules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationByIdElapsedTimeRequestScopeIdFulfillmentLocationIdelapsedTimeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The unique identifier of the fulfillment location.
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date to determine elapsed time. (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date to determine elapsed time. (optional) 
            var scheduleType = scheduleType_example;  // string | The schedule type to use (optional) 

            try
            {
                // Retrieve an elapsed time based on fulfillment location schedules - {GetFulfillmentLocationByIdElapsedTimeRequest}
                GetFulfillmentLocationByIdElapsedTimeResult result = apiInstance.GetFulfillmentLocationByIdElapsedTimeRequestScopeIdFulfillmentLocationIdelapsedTimeGet(accept, scopeId, fulfillmentLocationId, startDate, endDate, scheduleType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationByIdElapsedTimeRequestScopeIdFulfillmentLocationIdelapsedTimeGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| The unique identifier of the fulfillment location. | 
 **startDate** | **DateTime?**| The start date to determine elapsed time. | [optional] 
 **endDate** | **DateTime?**| The end date to determine elapsed time. | [optional] 
 **scheduleType** | **string**| The schedule type to use | [optional] 

### Return type

[**GetFulfillmentLocationByIdElapsedTimeResult**](GetFulfillmentLocationByIdElapsedTimeResult.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlocationbyidrequestscopeidfulfillmentlocationidget"></a>
# **GetFulfillmentLocationByIdRequestScopeIdFulfillmentLocationIdGet**
> FulfillmentLocation GetFulfillmentLocationByIdRequestScopeIdFulfillmentLocationIdGet (string accept, string scopeId, string fulfillmentLocationId)

Retrieve a fulfillment location for a specific scope - {GetFulfillmentLocationByIdRequest}

Retrieve a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationByIdRequestScopeIdFulfillmentLocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.

            try
            {
                // Retrieve a fulfillment location for a specific scope - {GetFulfillmentLocationByIdRequest}
                FulfillmentLocation result = apiInstance.GetFulfillmentLocationByIdRequestScopeIdFulfillmentLocationIdGet(accept, scopeId, fulfillmentLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationByIdRequestScopeIdFulfillmentLocationIdGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 

### Return type

[**FulfillmentLocation**](FulfillmentLocation.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlocationtimeslotbyidrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsslotidget"></a>
# **GetFulfillmentLocationTimeSlotByIdRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdGet**
> TimeSlot GetFulfillmentLocationTimeSlotByIdRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdGet (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType, string slotId)

Retrieves a time slot from a fulfillment location for a specific scope - {GetFulfillmentLocationTimeSlotByIdRequest}

Retrieves a time slot from a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationTimeSlotByIdRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var slotId = slotId_example;  // string | the unique identifier of the time slot.

            try
            {
                // Retrieves a time slot from a fulfillment location for a specific scope - {GetFulfillmentLocationTimeSlotByIdRequest}
                TimeSlot result = apiInstance.GetFulfillmentLocationTimeSlotByIdRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdGet(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType, slotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationTimeSlotByIdRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **slotId** | **string**| the unique identifier of the time slot. | 

### Return type

[**TimeSlot**](TimeSlot.md)

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
| **404** | Requested time slot not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlocationtimeslotreservationbyidrequestscopeidfulfillmentlocationidreservationsbyidslotreservationidget"></a>
# **GetFulfillmentLocationTimeSlotReservationByIdRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdGet**
> TimeSlotReservation GetFulfillmentLocationTimeSlotReservationByIdRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdGet (string accept, string scopeId, string fulfillmentLocationId, string slotReservationId, string slotId = null)

Retrieves a time slot reservation - {GetFulfillmentLocationTimeSlotReservationByIdRequest}

Retrieves a time slot reservation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationTimeSlotReservationByIdRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var slotReservationId = slotReservationId_example;  // string | the unique identifier of the time slot reservation.
            var slotId = slotId_example;  // string | The unique identifier of the time slot. (optional) 

            try
            {
                // Retrieves a time slot reservation - {GetFulfillmentLocationTimeSlotReservationByIdRequest}
                TimeSlotReservation result = apiInstance.GetFulfillmentLocationTimeSlotReservationByIdRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdGet(accept, scopeId, fulfillmentLocationId, slotReservationId, slotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationTimeSlotReservationByIdRequestScopeIdFulfillmentLocationIdreservationsbyIdSlotReservationIdGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **slotReservationId** | **string**| the unique identifier of the time slot reservation. | 
 **slotId** | **string**| The unique identifier of the time slot. | [optional] 

### Return type

[**TimeSlotReservation**](TimeSlotReservation.md)

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
| **404** | Requested time slot not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlocationtimeslotreservationsrequestscopeidfulfillmentlocationidreservationsslotidget"></a>
# **GetFulfillmentLocationTimeSlotReservationsRequestScopeIdFulfillmentLocationIdreservationsSlotIdGet**
> TimeSlotReservationResult GetFulfillmentLocationTimeSlotReservationsRequestScopeIdFulfillmentLocationIdreservationsSlotIdGet (string accept, string scopeId, string fulfillmentLocationId, string slotId, DateTime reservationDate)

Retrieves time slot reservations - {GetFulfillmentLocationTimeSlotReservationsRequest}

Retrieves time slot reservations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationTimeSlotReservationsRequestScopeIdFulfillmentLocationIdreservationsSlotIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var slotId = slotId_example;  // string | The unique identifier of the time slot to be found (if not set, all timeslot ids are retrieved).
            var reservationDate = 2013-10-20T19:20:30+01:00;  // DateTime | The reservation date.

            try
            {
                // Retrieves time slot reservations - {GetFulfillmentLocationTimeSlotReservationsRequest}
                TimeSlotReservationResult result = apiInstance.GetFulfillmentLocationTimeSlotReservationsRequestScopeIdFulfillmentLocationIdreservationsSlotIdGet(accept, scopeId, fulfillmentLocationId, slotId, reservationDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationTimeSlotReservationsRequestScopeIdFulfillmentLocationIdreservationsSlotIdGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **slotId** | **string**| The unique identifier of the time slot to be found (if not set, all timeslot ids are retrieved). | 
 **reservationDate** | **DateTime**| The reservation date. | 

### Return type

[**TimeSlotReservationResult**](TimeSlotReservationResult.md)

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
| **404** | Requested time slot reservation(s) not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsget"></a>
# **GetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsGet**
> List&lt;TimeSlot&gt; GetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsGet (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType)

Retrieves time slots from a fulfillment location for a specific scope - {GetFulfillmentLocationTimeSlotsRequest}

Retrieves time slots from a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].

            try
            {
                // Retrieves time slots from a fulfillment location for a specific scope - {GetFulfillmentLocationTimeSlotsRequest}
                List<TimeSlot> result = apiInstance.GetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsGet(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 

### Return type

[**List&lt;TimeSlot&gt;**](TimeSlot.md)

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
| **404** | Requested time slot(s) not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlocationsbyinventorylocationidsrequestscopeidinventorylocationidsget"></a>
# **GetFulfillmentLocationsByInventoryLocationIdsRequestScopeIdInventoryLocationIdsGet**
> List&lt;FulfillmentLocation&gt; GetFulfillmentLocationsByInventoryLocationIdsRequestScopeIdInventoryLocationIdsGet (string accept, string scopeId, List<string> inventoryLocationIds)

Retrieves a list of fulfillment locations for scpecific inventory locations identifiers - {GetFulfillmentLocationsByInventoryLocationIdsRequest}

Retrieves a list of fulfillment locations for specific inventory locations identifiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationsByInventoryLocationIdsRequestScopeIdInventoryLocationIdsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var inventoryLocationIds = new List<string>(); // List<string> | the unique identifiers of the inventory locations.

            try
            {
                // Retrieves a list of fulfillment locations for scpecific inventory locations identifiers - {GetFulfillmentLocationsByInventoryLocationIdsRequest}
                List<FulfillmentLocation> result = apiInstance.GetFulfillmentLocationsByInventoryLocationIdsRequestScopeIdInventoryLocationIdsGet(accept, scopeId, inventoryLocationIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationsByInventoryLocationIdsRequestScopeIdInventoryLocationIdsGet: " + e.Message );
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
 **inventoryLocationIds** | [**List&lt;string&gt;**](string.md)| the unique identifiers of the inventory locations. | 

### Return type

[**List&lt;FulfillmentLocation&gt;**](FulfillmentLocation.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlocationsbyscoperequestscopeidget"></a>
# **GetFulfillmentLocationsByScopeRequestScopeIdGet**
> List&lt;FulfillmentLocation&gt; GetFulfillmentLocationsByScopeRequestScopeIdGet (string accept, string scopeId, bool? includeSchedules = null, bool? includeChildScopes = null, bool? onlyActive = null, bool? onlyInventoryEnabled = null, bool? includeAddresses = null)

Retrieve fulfillment locations for a specific scope - {GetFulfillmentLocationsByScopeRequest}

Retrieve fulfillment locations for a specific scope. The addresses are not included in the result.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetFulfillmentLocationsByScopeRequestScopeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the fulfillment location. (optional) 
            var includeChildScopes = true;  // bool? | Includes the results for the child scopes. (optional) 
            var onlyActive = true;  // bool? | Filter the results to return only active. (optional) 
            var onlyInventoryEnabled = true;  // bool? | Filter the results to return only inventory enabled. (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load addresses of the fulfillment location. (optional) 

            try
            {
                // Retrieve fulfillment locations for a specific scope - {GetFulfillmentLocationsByScopeRequest}
                List<FulfillmentLocation> result = apiInstance.GetFulfillmentLocationsByScopeRequestScopeIdGet(accept, scopeId, includeSchedules, includeChildScopes, onlyActive, onlyInventoryEnabled, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetFulfillmentLocationsByScopeRequestScopeIdGet: " + e.Message );
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
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the fulfillment location. | [optional] 
 **includeChildScopes** | **bool?**| Includes the results for the child scopes. | [optional] 
 **onlyActive** | **bool?**| Filter the results to return only active. | [optional] 
 **onlyInventoryEnabled** | **bool?**| Filter the results to return only inventory enabled. | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load addresses of the fulfillment location. | [optional] 

### Return type

[**List&lt;FulfillmentLocation&gt;**](FulfillmentLocation.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoperatingstatusrequestscopeidfulfillmentlocationidoperatingstatusget"></a>
# **GetOperatingStatusRequestScopeIdFulfillmentLocationIdoperatingStatusGet**
> OperatingStatus GetOperatingStatusRequestScopeIdFulfillmentLocationIdoperatingStatusGet (string accept, string scopeId, string fulfillmentLocationId)

Retreive a specific store's OperatingStatus - {GetOperatingStatusRequest}

Retrieve a specific store's OperatingStatus

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetOperatingStatusRequestScopeIdFulfillmentLocationIdoperatingStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The unique identifier of the FulfillmentLocation (Store or other) to retrieve.

            try
            {
                // Retreive a specific store's OperatingStatus - {GetOperatingStatusRequest}
                OperatingStatus result = apiInstance.GetOperatingStatusRequestScopeIdFulfillmentLocationIdoperatingStatusGet(accept, scopeId, fulfillmentLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetOperatingStatusRequestScopeIdFulfillmentLocationIdoperatingStatusGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| The unique identifier of the FulfillmentLocation (Store or other) to retrieve. | 

### Return type

[**OperatingStatus**](OperatingStatus.md)

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
| **404** | Requested store or operating status not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpickupfulfillmentlocationsbyscoperequestscopeidpickupget"></a>
# **GetPickupFulfillmentLocationsByScopeRequestScopeIdpickupGet**
> List&lt;FulfillmentLocation&gt; GetPickupFulfillmentLocationsByScopeRequestScopeIdpickupGet (string accept, string scopeId, bool? includeSchedules = null, bool? includeChildScopes = null, bool? onlyActive = null, bool? onlyInventoryEnabled = null, bool? includeAddresses = null)

Retrieve fulfillment locations supporting pickup as shipping method for a specific scope - {GetPickupFulfillmentLocationsByScopeRequest}

Retrieve fulfillment locations supporting pickup as shipping method for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPickupFulfillmentLocationsByScopeRequestScopeIdpickupGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the fulfillment location. (optional) 
            var includeChildScopes = true;  // bool? | Includes the results for the child scopes. (optional) 
            var onlyActive = true;  // bool? | Filter the results to return only active. (optional) 
            var onlyInventoryEnabled = true;  // bool? | Filter the results to return only inventory enabled. (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load addresses of the fulfillment location. (optional) 

            try
            {
                // Retrieve fulfillment locations supporting pickup as shipping method for a specific scope - {GetPickupFulfillmentLocationsByScopeRequest}
                List<FulfillmentLocation> result = apiInstance.GetPickupFulfillmentLocationsByScopeRequestScopeIdpickupGet(accept, scopeId, includeSchedules, includeChildScopes, onlyActive, onlyInventoryEnabled, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetPickupFulfillmentLocationsByScopeRequestScopeIdpickupGet: " + e.Message );
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
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the fulfillment location. | [optional] 
 **includeChildScopes** | **bool?**| Includes the results for the child scopes. | [optional] 
 **onlyActive** | **bool?**| Filter the results to return only active. | [optional] 
 **onlyInventoryEnabled** | **bool?**| Filter the results to return only inventory enabled. | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load addresses of the fulfillment location. | [optional] 

### Return type

[**List&lt;FulfillmentLocation&gt;**](FulfillmentLocation.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschedulerequestscopeidfulfillmentlocationidscheduleget"></a>
# **GetScheduleRequestScopeIdFulfillmentLocationIdscheduleGet**
> FulfillmentSchedule GetScheduleRequestScopeIdFulfillmentLocationIdscheduleGet (string accept, string scopeId, string fulfillmentLocationId, string scheduleType = null)

Retreive a specific store's Schedule - {GetScheduleRequest}

Retrieve a specific store's Schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetScheduleRequestScopeIdFulfillmentLocationIdscheduleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | The unique identifier of the Store to retrieve.
            var scheduleType = scheduleType_example;  // string |  Gets or sets the type of the schedule. The possible values are : OpeningHours, Delivery or PickUp. (optional) 

            try
            {
                // Retreive a specific store's Schedule - {GetScheduleRequest}
                FulfillmentSchedule result = apiInstance.GetScheduleRequestScopeIdFulfillmentLocationIdscheduleGet(accept, scopeId, fulfillmentLocationId, scheduleType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetScheduleRequestScopeIdFulfillmentLocationIdscheduleGet: " + e.Message );
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
 **fulfillmentLocationId** | **string**| The unique identifier of the Store to retrieve. | 
 **scheduleType** | **string**|  Gets or sets the type of the schedule. The possible values are : OpeningHours, Delivery or PickUp. | [optional] 

### Return type

[**FulfillmentSchedule**](FulfillmentSchedule.md)

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
| **404** | Requested Store or Schedule not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingfulfillmentlocationsbyscoperequestscopeidshippingget"></a>
# **GetShippingFulfillmentLocationsByScopeRequestScopeIdshippingGet**
> List&lt;FulfillmentLocation&gt; GetShippingFulfillmentLocationsByScopeRequestScopeIdshippingGet (string accept, string scopeId, bool? includeSchedules = null, bool? includeChildScopes = null, bool? onlyActive = null, bool? onlyInventoryEnabled = null, bool? includeAddresses = null)

Retrieve fulfillment locations supporting shipping as shipping method for a specific scope - {GetShippingFulfillmentLocationsByScopeRequest}

Retrieve fulfillment locations supporting shipping as shipping method for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetShippingFulfillmentLocationsByScopeRequestScopeIdshippingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var includeSchedules = true;  // bool? | Specifies whether or not to load schedules of the fulfillment location. (optional) 
            var includeChildScopes = true;  // bool? | Includes the results for the child scopes. (optional) 
            var onlyActive = true;  // bool? | Filter the results to return only active. (optional) 
            var onlyInventoryEnabled = true;  // bool? | Filter the results to return only inventory enabled. (optional) 
            var includeAddresses = true;  // bool? | Specifies whether or not to load addresses of the fulfillment location. (optional) 

            try
            {
                // Retrieve fulfillment locations supporting shipping as shipping method for a specific scope - {GetShippingFulfillmentLocationsByScopeRequest}
                List<FulfillmentLocation> result = apiInstance.GetShippingFulfillmentLocationsByScopeRequestScopeIdshippingGet(accept, scopeId, includeSchedules, includeChildScopes, onlyActive, onlyInventoryEnabled, includeAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.GetShippingFulfillmentLocationsByScopeRequestScopeIdshippingGet: " + e.Message );
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
 **includeSchedules** | **bool?**| Specifies whether or not to load schedules of the fulfillment location. | [optional] 
 **includeChildScopes** | **bool?**| Includes the results for the child scopes. | [optional] 
 **onlyActive** | **bool?**| Filter the results to return only active. | [optional] 
 **onlyInventoryEnabled** | **bool?**| Filter the results to return only inventory enabled. | [optional] 
 **includeAddresses** | **bool?**| Specifies whether or not to load addresses of the fulfillment location. | [optional] 

### Return type

[**List&lt;FulfillmentLocation&gt;**](FulfillmentLocation.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reserveavailabilityslotrequestreserveslotfulfillmentlocationidpost"></a>
# **ReserveAvailabilitySlotRequestreserveSlotFulfillmentLocationIdPost**
> string ReserveAvailabilitySlotRequestreserveSlotFulfillmentLocationIdPost (string accept, string fulfillmentLocationId, ReserveAvailabilitySlotRequest body = null)

Reserves a fulfillment slot for the Shipment of an Order. (Not implemented in default provider) - {ReserveAvailabilitySlotRequest}

Reserves a fulfillment slot for the Shipment of an Order. (Not implemented in default provider) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ReserveAvailabilitySlotRequestreserveSlotFulfillmentLocationIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var body = new ReserveAvailabilitySlotRequest(); // ReserveAvailabilitySlotRequest |  (optional) 

            try
            {
                // Reserves a fulfillment slot for the Shipment of an Order. (Not implemented in default provider) - {ReserveAvailabilitySlotRequest}
                string result = apiInstance.ReserveAvailabilitySlotRequestreserveSlotFulfillmentLocationIdPost(accept, fulfillmentLocationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.ReserveAvailabilitySlotRequestreserveSlotFulfillmentLocationIdPost: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **body** | [**ReserveAvailabilitySlotRequest**](ReserveAvailabilitySlotRequest.md)|  | [optional] 

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetfulfillmentlocationtimeslotsrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsresetcreate"></a>
# **ResetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsresetCreate**
> List&lt;TimeSlot&gt; ResetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsresetCreate (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType, ResetFulfillmentLocationTimeSlotsRequest body = null)

Delete all time slot from a fulfillment location for a specific scope and add the list of time slots - {ResetFulfillmentLocationTimeSlotsRequest}

Delete all time slot from a fulfillment location for a specific scope and add the list of time slots

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ResetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsresetCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var body = new ResetFulfillmentLocationTimeSlotsRequest(); // ResetFulfillmentLocationTimeSlotsRequest |  (optional) 

            try
            {
                // Delete all time slot from a fulfillment location for a specific scope and add the list of time slots - {ResetFulfillmentLocationTimeSlotsRequest}
                List<TimeSlot> result = apiInstance.ResetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsresetCreate(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.ResetFulfillmentLocationTimeSlotsRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsresetCreate: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **body** | [**ResetFulfillmentLocationTimeSlotsRequest**](ResetFulfillmentLocationTimeSlotsRequest.md)|  | [optional] 

### Return type

[**List&lt;TimeSlot&gt;**](TimeSlot.md)

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

<a name="setfulfillmentlocationinventorymanagementrequestscopeidfulfillmentlocationidinventorycreate"></a>
# **SetFulfillmentLocationInventoryManagementRequestScopeIdFulfillmentLocationIdinventoryCreate**
> SetFulfillmentLocationInventoryManagementResult SetFulfillmentLocationInventoryManagementRequestScopeIdFulfillmentLocationIdinventoryCreate (string accept, string scopeId, string fulfillmentLocationId, SetFulfillmentLocationInventoryManagementRequest body = null)

Updates the inventory informations for a specified fulfillment location. - {SetFulfillmentLocationInventoryManagementRequest}

Updates the inventory details for a specified fulfillment location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SetFulfillmentLocationInventoryManagementRequestScopeIdFulfillmentLocationIdinventoryCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var body = new SetFulfillmentLocationInventoryManagementRequest(); // SetFulfillmentLocationInventoryManagementRequest |  (optional) 

            try
            {
                // Updates the inventory informations for a specified fulfillment location. - {SetFulfillmentLocationInventoryManagementRequest}
                SetFulfillmentLocationInventoryManagementResult result = apiInstance.SetFulfillmentLocationInventoryManagementRequestScopeIdFulfillmentLocationIdinventoryCreate(accept, scopeId, fulfillmentLocationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.SetFulfillmentLocationInventoryManagementRequestScopeIdFulfillmentLocationIdinventoryCreate: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **body** | [**SetFulfillmentLocationInventoryManagementRequest**](SetFulfillmentLocationInventoryManagementRequest.md)|  | [optional] 

### Return type

[**SetFulfillmentLocationInventoryManagementResult**](SetFulfillmentLocationInventoryManagementResult.md)

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
| **404** | Requested Fulfillment location not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentlocationtimeslotrequestscopeidfulfillmentlocationidfulfillmentmethodtypeslotsslotidcreate"></a>
# **UpdateFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdCreate**
> TimeSlot UpdateFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdCreate (string accept, string scopeId, string fulfillmentLocationId, string fulfillmentMethodType, string slotId, UpdateFulfillmentLocationTimeSlotRequest body = null)

Updates a time slot from a fulfillment location for a specific scope - {UpdateFulfillmentLocationTimeSlotRequest}

Updates a time slot from a fulfillment location for a specific scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var fulfillmentMethodType = fulfillmentMethodType_example;  // string | the type of the fulfillment, valid options are [Pickup, Delivery and Shipping].
            var slotId = slotId_example;  // string | the unique identifier of the time slot.
            var body = new UpdateFulfillmentLocationTimeSlotRequest(); // UpdateFulfillmentLocationTimeSlotRequest |  (optional) 

            try
            {
                // Updates a time slot from a fulfillment location for a specific scope - {UpdateFulfillmentLocationTimeSlotRequest}
                TimeSlot result = apiInstance.UpdateFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdCreate(accept, scopeId, fulfillmentLocationId, fulfillmentMethodType, slotId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.UpdateFulfillmentLocationTimeSlotRequestScopeIdFulfillmentLocationIdFulfillmentMethodTypeslotsSlotIdCreate: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **fulfillmentMethodType** | **string**| the type of the fulfillment, valid options are [Pickup, Delivery and Shipping]. | 
 **slotId** | **string**| the unique identifier of the time slot. | 
 **body** | [**UpdateFulfillmentLocationTimeSlotRequest**](UpdateFulfillmentLocationTimeSlotRequest.md)|  | [optional] 

### Return type

[**TimeSlot**](TimeSlot.md)

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

<a name="updatefulfillmentlocationtimeslotreservationrequestscopeidfulfillmentlocationidreservationsslotreservationidcreate"></a>
# **UpdateFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotReservationIdCreate**
> TimeSlotReservation UpdateFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotReservationIdCreate (string accept, string scopeId, string fulfillmentLocationId, string slotReservationId, UpdateFulfillmentLocationTimeSlotReservationRequest body = null)

Updates a time slot reservation - {UpdateFulfillmentLocationTimeSlotReservationRequest}

Updates a time slot reservation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotReservationIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new FulfillmentLocationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fulfillmentLocationId = fulfillmentLocationId_example;  // string | the unique identifier of the Fulfillment location.
            var slotReservationId = slotReservationId_example;  // string | the unique identifier of the time slot reservation.
            var body = new UpdateFulfillmentLocationTimeSlotReservationRequest(); // UpdateFulfillmentLocationTimeSlotReservationRequest |  (optional) 

            try
            {
                // Updates a time slot reservation - {UpdateFulfillmentLocationTimeSlotReservationRequest}
                TimeSlotReservation result = apiInstance.UpdateFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotReservationIdCreate(accept, scopeId, fulfillmentLocationId, slotReservationId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FulfillmentLocationsApi.UpdateFulfillmentLocationTimeSlotReservationRequestScopeIdFulfillmentLocationIdreservationsSlotReservationIdCreate: " + e.Message );
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
 **fulfillmentLocationId** | **string**| the unique identifier of the Fulfillment location. | 
 **slotReservationId** | **string**| the unique identifier of the time slot reservation. | 
 **body** | [**UpdateFulfillmentLocationTimeSlotReservationRequest**](UpdateFulfillmentLocationTimeSlotReservationRequest.md)|  | [optional] 

### Return type

[**TimeSlotReservation**](TimeSlotReservation.md)

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

