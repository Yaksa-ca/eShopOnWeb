# Yaksa.OrckestraCommerce.Client.Model.PromotionEngineResult
PromotionEngineResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvailablePromotions** | [**List&lt;Promotion&gt;**](Promotion.md) | The list of all the processed promotions considered available for the customer (i.e. the targeting condition was met), at a given time. | [optional] 
**Cart** | [**Cart**](Cart.md) |  | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**IsMaxProcessedPromotionsReached** | **bool** | The maximum of processed promotions (500) is reached. | [optional] 
**LiveCampaigns** | [**List&lt;Campaign&gt;**](Campaign.md) | The live campaigns. | [optional] 
**ProcessedPromotions** | [**List&lt;PromotionProcessingResult&gt;**](PromotionProcessingResult.md) | The list of all the processed promotions considered, at a given time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

