# Yaksa.OrckestraCommerce.Client.Model.Tax
Tax

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The tax code. For example, this could be GST or HST in Canada. | [optional] 
**DisplayName** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Id** | **string** | The unique identifier of the tax. | [optional] 
**IsShippingFeeTax** | **bool** | Indicates that this item is the tax for the additionbal shipping fees | [optional] 
**IsShippingTax** | **bool** | Indicates that this item is the tax for the shipping charge | [optional] 
**LineItemIds** | **List&lt;string&gt;** | The unique identifier of all the LineItem on which the tax is applied. | [optional] 
**Percentage** | **double** | The percentage to apply for this tax. | [optional] 
**TaxAmount** | **double** | The tax amount to apply this tax percentage on. This should be the total of the LineItem prices. | [optional] 
**TaxCategoryId** | **string** | The unique identifier of the tax category. | [optional] 
**TaxForShipmentId** | **string** | The id of the shipment if this tax IsShippingTax or IsShippingFeeTax. | [optional] 
**TaxTotal** | **double** | The cost of the tax to pay. This should be the rounded TaxAmount * Percentage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

