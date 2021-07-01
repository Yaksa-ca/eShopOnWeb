# Yaksa.OrckestraCommerce.Client.Model.TransferFulfillmentPackageItemsRequest
API calls used during the fulfillment process.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationFulfillmentPackageId** | **string** | The fulfillment package identifier to transfer items to. Set to null to create a new fulfillment package using default package type. | [optional] 
**FulfillmentPackageItemTransferInfos** | [**List&lt;FulfillmentPackageItemTransferInfo&gt;**](FulfillmentPackageItemTransferInfo.md) | A list containing information about fulfillment package items that needs to be transfer from one package to another. | [optional] 
**SourceFulfillmentPackageId** | **string** | The fulfillment package identifier to transfer items from. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

