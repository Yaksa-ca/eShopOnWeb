# Yaksa.OrckestraCommerce.Client.Model.Store
Store

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **DateTime** | the date the Store was created. | [optional] 
**CreatedBy** | **string** | the identifier of the user who created the Store. | [optional] 
**DeliverySchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Email** | **string** | the email of the store. This could be a specific person&#39;s address or a general customerService address depending on the store. | [optional] 
**FaxExtension** | **string** | the extension for the fax number of the organization. | [optional] 
**FaxNumber** | **string** | the fax number of the store. | [optional] 
**FulfillmentLocation** | [**FulfillmentLocation**](FulfillmentLocation.md) |  | [optional] 
**Id** | **string** | the unique identifier of the Store. | [optional] 
**IsActive** | **bool** | Is this store currently active. Set this flag to false as an alternative to deleting it and then recreating it a a later date. This allows the store to be hidden from many business processes until re-activated.  | [optional] 
**LastModified** | **DateTime** | The date of the last modification to the Store. | [optional] 
**LastModifiedBy** | **string** | the identifier of the user who last modified the Store. | [optional] 
**Manager** | **string** | the full name of the manager of the store. | [optional] 
**Name** | **string** | the name of the store. Each store must have a name that unique in the system. | [optional] 
**Number** | **string** | a business centric number to identify the store that could be used to link the store to external data. | [optional] 
**OperatingStatus** | [**OperatingStatus**](OperatingStatus.md) |  | [optional] 
**PhoneExtension** | **string** | the extension for the telephone number of the store. | [optional] 
**PhoneNumber** | **string** | the telephone number of the store. | [optional] 
**PickUpSchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**ScopeId** | **string** | the scope associated to the store. This value is not loaded by default. | [optional] 
**StoreSchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**StoreType** | **string** | Indicates if this is a physical or virtual store. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

