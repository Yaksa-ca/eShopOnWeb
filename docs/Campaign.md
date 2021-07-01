# Yaksa.OrckestraCommerce.Client.Model.Campaign
Campaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Created** | **DateTime** | Date the entity was created | [optional] 
**CreatedBy** | **string** | Identifier of the operator who created the entity | [optional] 
**LastModified** | **DateTime** | Date that the last modification was applied to the entity | [optional] 
**LastModifiedBy** | **string** | Identifier of the operator who last modified the entity | [optional] 
**AllowOptOut** | **bool** | Indicates whether the campaign allows opting out. | [optional] 
**ChildScopesInheritance** | **Dictionary&lt;string, bool&gt;** | Dictionary&lt;String,Boolean&gt; | [optional] 
**Description** | **string** | The description of the campaign. | [optional] 
**EndDate** | **DateTime** | The end date of the campaign. | [optional] 
**IsEditionStep1Completed** | **bool** | Indicates whether a person editing the campaign marked the step as complete. | [optional] 
**IsEditionStep2Completed** | **bool** | Indicates whether a person editing the campaign marked the step as complete. | [optional] 
**IsEditionStep3Completed** | **bool** | Indicates whether a person editing the campaign marked the step as complete. | [optional] 
**Name** | **string** | The name of the campaign. | [optional] 
**Priority** | **int** | The priority of the campaign. | [optional] 
**Promotions** | [**List&lt;Promotion&gt;**](Promotion.md) | The promotions that are in the campaign. | [optional] 
**Scope** | **string** | The id of the scope of the campaign. | [optional] 
**StartDate** | **DateTime** | The start date of the campaign. | [optional] 
**Status** | **string** | The status of the campaign. | [optional] 
**TimeZone** | **string** | The time zone to use in conjunction with the date properties (Start/End) of this campaign. | [optional] 
**Type** | **string** | The type of the campaign (CampaignType Lookup) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

