# Yaksa.OrckestraCommerce.Client.Model.FulfillmentLocation
FulfillmentLocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addresses** | [**List&lt;Address&gt;**](Address.md) | The fulfillment location&#39;s addresses. | [optional] 
**AddressIds** | **List&lt;string&gt;** | the unique identifiers of the addresses. | [optional] 
**Created** | **DateTime** | the date the Store/Warehouse was created. | [optional] 
**CreatedBy** | **string** | the identifier of the user who created the fulfillment location. | [optional] 
**DeliveryScheduleManaged** | **bool** | a value indicating whether this fulfillment location manage his own schedule for delivery | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Id** | **string** | The unique identifier of the fulfillment location. | 
**InventoryLocationId** | **string** | the inventory location identifier | [optional] 
**InventoryProviderId** | **string** | the inventory provider identifier to use for this fulfillment location | [optional] 
**IsActive** | **bool** | The state of the fulfillment location | [optional] 
**IsAtpEnabled** | **bool** | a value indicating whether inventory availability to promise is enabled | [optional] 
**IsInventoryEnabled** | **bool** | a value indicating whether this fulfillment location has inventory enabled | [optional] 
**IsPickUpLocation** | **bool** | a value indicating whether this store is a pickup location. | [optional] 
**LastModified** | **DateTime** | The date of the last modification to the fulfillment location. | [optional] 
**LastModifiedBy** | **string** | the identifier of the user who last modified the Store or Warehouse. | [optional] 
**Name** | **string** | The name of the fulfillment location | [optional] 
**Number** | **string** | A business centric number to identify the fulfillment location | [optional] 
**PickUpScheduleManaged** | **bool** | a value indicating whether this fulfillment location manage his own schedule for pickup | [optional] 
**Schedules** | [**List&lt;FulfillmentSchedule&gt;**](FulfillmentSchedule.md) | The list of &#39;Schedule&#39; of the fulfillment location. | [optional] 
**SupportDelivery** | **bool** | a value indicating whether this store supports delivery for order fulfillment. | [optional] 
**SupportedFulfillmentMethodTypes** | **Object** | ICollection&lt;FulfillmentMethodType&gt; | [optional] 
**SupportPickUp** | **bool** | a value indicating whether this store supports pick-up for order fulfillment. | [optional] 
**SupportShipping** | **bool** | a value indicating whether this store supports shipping for order fulfillment. | [optional] 
**SupportShipToStore** | **bool** | a value indicating whether this store supports ship to store for order fulfillment. | [optional] 
**TimeZone** | **string** | the timezone in which the schedule hours were set. | [optional] 
**Type** | **string** | The type of the fulfillment location. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

