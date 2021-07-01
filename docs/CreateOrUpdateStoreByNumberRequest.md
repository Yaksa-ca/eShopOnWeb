# Yaksa.OrckestraCommerce.Client.Model.CreateOrUpdateStoreByNumberRequest
Stores are entities which represents physical stores or an online/web stores.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addresses** | [**List&lt;Address&gt;**](Address.md) | The store&#39;s addresses. | [optional] 
**DeliverySchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**DeliveryScheduleManaged** | **bool** | A value indicating whether this fulfillment location manage his own schedule for delivery | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Email** | **string** | the email of the store. This could be a specific person&#39;s address or a general customerService@ address depending on the store. | [optional] 
**FaxExtension** | **string** | the extension for the fax number of the store. | [optional] 
**FaxNumber** | **string** | the fax number of the store. | [optional] 
**InventoryLocationId** | **string** | The inventory location identifier related to this fulfillment location | [optional] 
**InventoryProviderId** | **string** | The inventory provider identifier to use with this fulfillment location | [optional] 
**IsActive** | **bool** | Is this store currently active. Set this flag to false as an alternative to deleting it and then recreating it a a later date. This allows the store to be hidden from many business processes until re-activated.  | [optional] 
**IsAtpEnabled** | **bool** | value indicating whether inventory availability to promise is enabled | [optional] 
**IsInventoryEnabled** | **bool** | value indicating whether this store has inventory enabled | [optional] 
**IsPickUpLocation** | **bool** | a value indicating whether this store is a pickup location for order fulfillment. | [optional] 
**Manager** | **string** | the full name of the manager of the store. | [optional] 
**Name** | **string** | the name of the store. Each store must have a name that unique in the system. | [optional] 
**OperatingStatus** | [**OperatingStatus**](OperatingStatus.md) |  | [optional] 
**PhoneExtension** | **string** | the extension for the telephone number of the store. | [optional] 
**PhoneNumber** | **string** | the telephone number of the store. | [optional] 
**PickUpSchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**PickUpScheduleManaged** | **bool** | A value indicating whether this fulfillment location manage his own schedule for pickup | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Schedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**StoreType** | **string** | Indicates if this is a physical or virtual store. | [optional] 
**SupportDelivery** | **bool** | a value indicating whether this store supports delivery for order fulfillment. | [optional] 
**SupportPickUp** | **bool** | a value indicating whether this store supports pickup for order fulfillment. | [optional] 
**SupportShipping** | **bool** | a value indicating whether this store supports shipping for order fulfillment. | [optional] 
**SupportShipToStore** | **bool** | a value indicating whether this store supports ship to store for order fulfillment. | [optional] 
**TimeZone** | **string** | The time zone of the schedules. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

