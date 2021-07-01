# Yaksa.OrckestraCommerce.Client.Model.CreateOrUpdateWarehouseByNumberRequest
Warehouses are entities which represents physical warehouses.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addresses** | [**List&lt;Address&gt;**](Address.md) | The warehouse&#39;s addresses. | [optional] 
**AssociatedScopes** | **List&lt;string&gt;** | The warehouse&#39;s associated scopes. | [optional] 
**DeliverySchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**DeliveryScheduleManaged** | **bool** | A value indicating whether this fulfillment location manage his own schedule for delivery | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Email** | **string** | the email of the warehouse. This could be a specific person&#39;s address or a general customerService@ address depending on the warehouse. | [optional] 
**FaxExtension** | **string** | the extension for the fax number of the warehouse. | [optional] 
**FaxNumber** | **string** | the fax number of the warehouse. | [optional] 
**InventoryLocationId** | **string** | The inventory location identifier related to this fulfillment location | [optional] 
**InventoryProviderId** | **string** | The inventory provider identifier to use with this fulfillment location | [optional] 
**IsActive** | **bool** | Is this warehouse currently active. Set this flag to false as an alternative to deleting it and then recreating it a a later date. This allows the warehouse to be hidden from many business processes until re-activated.  | [optional] 
**IsAtpEnabled** | **bool** | value indicating whether inventory availability to promise is enabled. | [optional] 
**IsInventoryEnabled** | **bool** | value indicating whether inventory is enabled for this fulfillment location. | [optional] 
**Manager** | **string** | the full name of the manager of the warehouse. | [optional] 
**Name** | **string** | the name of the warehouse. Each warehouse must have a name that unique in the system. | [optional] 
**Number** | **string** | a business centric number to identify the warehouse that could be used to link the warehouse to external data. | [optional] 
**OperatingStatus** | [**OperatingStatus**](OperatingStatus.md) |  | [optional] 
**PhoneExtension** | **string** | the extension for the telephone number of the warehouse. | [optional] 
**PhoneNumber** | **string** | the telephone number of the warehouse. | [optional] 
**PickUpSchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**PickUpScheduleManaged** | **bool** | A value indicating whether this fulfillment location manage his own schedule for pickup | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Schedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**SupportDelivery** | **bool** | a value indicating whether this warehouse supports delivery for order fulfillment. | [optional] 
**SupportPickUp** | **bool** | a value indicating whether this warehouse supports pickup for order fulfillment. | [optional] 
**SupportShipping** | **bool** | a value indicating whether this warehouse supports shipping for order fulfillment. | [optional] 
**SupportShipToStore** | **bool** | a value indicating whether this warehouse supports ship to store for order fulfillment. | [optional] 
**TimeZone** | **string** | The time zone of the schedules. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

