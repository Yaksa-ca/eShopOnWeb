# Yaksa.OrckestraCommerce.Client.Model.CustomerInfo
CustomerInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountStatus** | **string** | The current status (active/inactive/requires approval) of the customer account. | [optional] 
**Addresses** | [**List&lt;AddressInfo&gt;**](AddressInfo.md) | The preferred address. (selected by business rule) | [optional] 
**AddressIds** | **List&lt;string&gt;** | The preferred address&#39;s Id. (selected by business rule) | [optional] 
**Created** | **DateTime** | The date the customer was created. | [optional] 
**CustomerType** | **string** | The type of customer (Registered, Guest). | [optional] 
**Email** | **string** | The email associated to the customer. | [optional] 
**FirstName** | **string** | The first name of the customer. | [optional] 
**Id** | **string** | The unique identifier of the entity. | 
**IsRecurringBuyer** | **bool** | A value indicating whether this customer is a recurring buyer. | [optional] 
**Language** | **string** | The preferred communication language of the customer. | [optional] 
**LastActivityDate** | **DateTime** | The date where the customer last interacted with the system. | [optional] 
**LastLoginDate** | **DateTime** | The date where the customer last logged in the e-commerce website. | [optional] 
**LastModified** | **DateTime** | The date that the last modification was applied to the customer. | [optional] 
**LastName** | **string** | The last name of the customer. | [optional] 
**LastOrderDate** | **DateTime** | The date at which the customer last order was created. | [optional] 
**LastOrderItemsCount** | **int** | The total quantity of items for the last order of the customer. | [optional] 
**LastOrderLineItemsCount** | **int** | the total quantity of line items for the last order of the customer. | [optional] 
**LastOrderTotal** | **double** | The total amount of the customer last order. | [optional] 
**LastPasswordChanged** | **DateTime** | The date where the customer last changed his password. | [optional] 
**PhoneExtension** | **string** | The extension, if any, for the telephone number of the customer. | [optional] 
**PhoneNumber** | **string** | The telephone number of the customer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

