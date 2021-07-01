# Yaksa.OrckestraCommerce.Client.Model.GetProvidersRequest
Providers are generic entities containing configuration settings for various need.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**IncludeParentScopes** | **bool** | Determine if parent scopes are considered when retrieving providers. | [optional] 
**ProviderType** | **string** | Type of this provider: [&#39;Undefined&#39; or &#39;StoreLocator&#39; or &#39;Geolocation&#39; or &#39;PrintOrder&#39; or &#39;PrintShipment&#39; or &#39;OrderProcessing&#39; or &#39;Shipping&#39; or &#39;Payment&#39; or &#39;Tax&#39; or &#39;Rounding&#39; or &#39;TargetingContext&#39; or &#39;OrderNumberGenerator&#39; or &#39;RmaNumberGenerator&#39; or &#39;DigitalAssetManagement&#39; or &#39;DirectoryProvider&#39; or &#39;MembershipProvider&#39; or &#39;Inventory&#39; or &#39;Audit&#39; or &#39;SlotInstance&#39; or &#39;PriceCalculator&#39; or &#39;SearchPriceCalculator&#39; or &#39;Search&#39; or &#39;BlobStorage&#39; or &#39;ShipmentProcessingDate&#39; or &#39;ProductImportParser&#39; or &#39;DataExchange&#39; or &#39;ProductDataExchangeImport&#39; or &#39;ProductDataExchangeExport&#39; or &#39;ProductPriceDataExchangeImport&#39; or &#39;ProductPriceDataExchangeExport&#39; or &#39;MailProvider&#39; or &#39;NotificationProvider&#39; or &#39;OrderImportParser&#39; or &#39;PromotionLineItemValidator&#39; or &#39;PickingMissionNumberGenerator&#39; or &#39;FulfillmentCarrier&#39; or &#39;FulfillmentRouting&#39;]  // Note: &#39;Undefined&#39; retrieves all providers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

