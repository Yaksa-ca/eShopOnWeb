# Yaksa.OrckestraCommerce.Client.Model.ProductMedia
ProductMedia

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the entity. | 
**PropertyBag** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Created** | **DateTime** | Date the entity was created | [optional] 
**CreatedBy** | **string** | Identifier of the operator who created the entity | [optional] 
**LastModified** | **DateTime** | Date that the last modification was applied to the entity | [optional] 
**LastModifiedBy** | **string** | Identifier of the operator who last modified the entity | [optional] 
**CleanUpOnDelete** | **bool** | Indicates whether the related media file should be deleted from the Azure Storage when this reference to it is removed. | [optional] 
**Description** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**IsCover** | **bool** | a cover of the Product. | [optional] 
**MediaType** | **string** | the MediaType of the media. | [optional] 
**Position** | **int** | a position of the Media. | [optional] 
**ResizedInstances** | [**List&lt;ResizedMediaLink&gt;**](ResizedMediaLink.md) | a resized instances of the Media | [optional] 
**Role** | **string** | a role of the Media. | [optional] 
**Tag** | **string** | a tag of the Media. | [optional] 
**Title** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Url** | **string** | the Url of the media. | [optional] 
**IsRemoved** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

