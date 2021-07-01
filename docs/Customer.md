# Yaksa.OrckestraCommerce.Client.Model.Customer
Customer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**AccountLockedDownUntil** | **DateTime** | the time when the account lock down expires. | [optional] 
**AccountStatus** | **string** | The current status of the customer account. | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) | A list of the Customer&#39;s Addresses. | [optional] 
**AddressIds** | **List&lt;string&gt;** | A list of system-wide identifier uniquely identifying each Customer Address. | [optional] 
**CellNumber** | **string** | the number for the cellular of the customer. | [optional] 
**Created** | **DateTime** | the date the customer was created. | [optional] 
**CreatedBy** | **string** | the identifier of the operator who created the customer. | [optional] 
**CustomerType** | **string** | the type of customer (Registered, Guest). | [optional] 
**Email** | **string** | the email associated with the customer. | [optional] 
**FaxExtension** | **string** | the extension, if any, for the customer fax. | [optional] 
**FaxNumber** | **string** | the number to use for the customer fax. | [optional] 
**FirstName** | **string** | the first name of the customer. | [optional] 
**IsRecurringBuyer** | **bool** | a value indicating whether this customer is a recurring buyer. | [optional] 
**Language** | **string** | the preferred communication language of the customer. | [optional] 
**LastActivityDate** | **DateTime** | the date where the customer last interacted with the system. | [optional] 
**LastLoginDate** | **DateTime** | the date where the customer last logged in the e-commerce website. | [optional] 
**LastModified** | **DateTime** | the date that the last modification was applied to the customer. | [optional] 
**LastModifiedBy** | **string** | the identifier of the operator who last modified the customer. | [optional] 
**LastName** | **string** | the last name of the customer. | [optional] 
**LastOrderCurrency** | **string** | the currency used for the customer last order. | [optional] 
**LastOrderDate** | **DateTime** | the date at which the customer last order was created. | [optional] 
**LastOrderItemsCount** | **int** | the total quantity of items for the last order of the customer. | [optional] 
**LastOrderLineItemsCount** | **int** | the total quantity of line items for the last order of the customer. | [optional] 
**LastOrderNumber** | **string** | the order number of the last order of the customer. | [optional] 
**LastOrderStatus** | **string** | the status of the customer last order. | [optional] 
**LastOrderTotal** | **double** | the total amount of the customer last order. | [optional] 
**LastPasswordChanged** | **DateTime** | the date where the customer last changed his password. | [optional] 
**MiddleName** | **string** | the middle name of the person. | [optional] 
**OrganizationIds** | **List&lt;string&gt;** | A list of system-wide identifier uniquely identifying each customer&#39;s Organization. | [optional] 
**PasswordQuestion** | **string** | the secret question for the customer. | [optional] 
**PaymentProfileIds** | **List&lt;string&gt;** | A list of system-wide identifier uniquely identifying each customer&#39;s Payment Profile. | [optional] 
**PhoneExtension** | **string** | the extension, if any, for the telephone number of the customer. | [optional] 
**PhoneExtensionWork** | **string** | the extension, if any, for the work phone number. | [optional] 
**PhoneNumber** | **string** | the telephone number of the customer. | [optional] 
**PhoneNumberWork** | **string** | the phone number at the work place of the customer. | [optional] 
**PreferredStoreId** | **string** | the id of the customer&#39;s preferred store. | [optional] 
**StoreIds** | **List&lt;string&gt;** | A list of system-wide identifier uniquely identifying each customer&#39;s Store. | [optional] 
**Username** | **string** | a string of character representing a unique name used for the customer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

