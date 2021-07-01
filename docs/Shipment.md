# Yaksa.OrckestraCommerce.Client.Model.Shipment
Shipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**AdditionalFeeAmount** | **double** | The amount for all shipment additional fees applied to this shipment. This value is usually computed during the workflow execution. When null, indicates that the value has not been calculated. | [optional] 
**AdditionalFees** | [**List&lt;ShipmentAdditionalFee&gt;**](ShipmentAdditionalFee.md) | The collection of additional fees to apply on this line item. | [optional] 
**Address** | [**Address**](Address.md) |  | [optional] 
**AdjustmentAmount** | **double** | The shipment adjustment amount. | [optional] 
**AdjustmentNote** | **string** | The shipment adjustment note. | [optional] 
**Amount** | **double** | The amount to pay for the shipment. The amount is usually set using the shipping method during the workflow execution. | [optional] 
**Created** | **DateTime** | the date when the order as created. | [optional] 
**CreatedBy** | **string** | the user id of the user that created the shipment. | [optional] 
**DiscountAmount** | **double** | The discount amount to apply on the shipment. The sum of all applicable discounts, usually calculated during the workflow execution. | [optional] 
**ExpectedDeliveryDate** | **DateTime** | The expected delivery date. | [optional] 
**FulfillmentLastAssignedDate** | **DateTime** | The last assigned date for the fulfillment. | [optional] 
**FulfillmentLocationId** | **string** | The fulfillment location id. | [optional] 
**FulfillmentLocationType** | **string** | The fulfillment location type. | [optional] 
**FulfillmentMethod** | [**FulfillmentMethod**](FulfillmentMethod.md) |  | [optional] 
**FulfillmentScheduledTimeBeginDate** | **DateTime** | The begin date and time scheduled for the fulfillment. | [optional] 
**FulfillmentScheduledTimeEndDate** | **DateTime** | The end date and time scheduled for the fulfillment. | [optional] 
**FulfillmentScheduleMode** | **string** | The fulfillment schedule mode. | [optional] 
**FulfillmentScheduleReservationDate** | **DateTime** | the date the fulfillment reservation was done. | [optional] 
**FulfillmentScheduleReservationNumber** | **string** | the reservation number for the scheduled fulfillment date and time. | [optional] 
**LastModified** | **DateTime** | the date when the shipment was last modified. | [optional] 
**LastModifiedBy** | **string** | the user id of the user that last modified the shipment. | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) | The collection of items included in the order. A line item represents a product and its quantity that the customer places in the cart. | [optional] 
**PickUpLocationId** | **string** | The pick-up location identifier required when the selected shipping method type is ship to store; any value will be ignored otherwise. | [optional] 
**ProcessingDate** | **DateTime** | the date the shipment is processed. | [optional] 
**ReturnTrackingNumber** | **string** | The shipment return tracking number provided by the shipping provider. | [optional] 
**Rewards** | [**List&lt;Reward&gt;**](Reward.md) | The collection of rewards to apply on this shipment. The collection is usually filled during the workflow execution. | [optional] 
**Status** | **string** | The shipment status, according to the Shipping Status lookup. | [optional] 
**Taxes** | [**List&lt;Tax&gt;**](Tax.md) | The collection of taxes to apply on this shipment line items. The collection is usually filled during the workflow execution. | [optional] 
**TaxProviderId** | **string** | The id of the tax provider that will be used to calculate taxes on this shipment line items. The provider is usually used during the workflow execution, in the CalculateTaxes activity. | [optional] 
**TaxTotal** | **double** | the total of all taxes to apply on the shipment. The sum of all applicable taxes, usually calculated during the workflow execution. | [optional] 
**Total** | **double** | The total amount for the shipment, including discounts. | [optional] 
**TrackingNumber** | **string** | The shipment tracking number provided by the shipping provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

