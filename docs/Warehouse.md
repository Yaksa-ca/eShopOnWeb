# Yaksa.OrckestraCommerce.Client.Model.Warehouse
Warehouse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssociatedScopes** | **List&lt;string&gt;** | The warehouse&#39;s associated scopes. | [optional] 
**Created** | **DateTime** | the date the Warehouse was created. | [optional] 
**CreatedBy** | **string** | the identifier of the user who created the Warehouse. | [optional] 
**DeliverySchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Email** | **string** | the email of the warehouse. This could be a specific person&#39;s address or a general customerService address depending on the warehouse. | [optional] 
**FaxExtension** | **string** | the extension for the fax number of the warehouse. | [optional] 
**FaxNumber** | **string** | the fax number of the warehouse. | [optional] 
**FulfillmentLocation** | [**FulfillmentLocation**](FulfillmentLocation.md) |  | [optional] 
**Id** | **string** | the unique identifier of the Warehouse. | [optional] 
**IsActive** | **bool** | Is this warehouse currently active. Set this flag to false as an alternative to deleting it and then recreating it a a later date. This allows the warehouse to be hidden from many business processes until re-activated.  | [optional] 
**LastModified** | **DateTime** | The date of the last modification to the Warehouse. | [optional] 
**LastModifiedBy** | **string** | the identifier of the user who last modified the Warehouse. | [optional] 
**Manager** | **string** | the full name of the manager of the warehouse. | [optional] 
**Name** | **string** | the name of the warehouse. Each warehouse must have a name that unique in the system. | [optional] 
**Number** | **string** | a business centric number to identify the warehouse that could be used to link the warehouse to external data. | [optional] 
**OperatingStatus** | [**OperatingStatus**](OperatingStatus.md) |  | [optional] 
**PhoneExtension** | **string** | the extension for the telephone number of the warehouse. | [optional] 
**PhoneNumber** | **string** | the telephone number of the warehouse. | [optional] 
**PickUpSchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**WarehouseSchedule** | [**FulfillmentSchedule**](FulfillmentSchedule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

