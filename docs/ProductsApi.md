# Yaksa.OrckestraCommerce.Client.Api.ProductsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFromGlobalRequestScopeIdfromGlobalPost**](ProductsApi.md#addfromglobalrequestscopeidfromglobalpost) | **POST** /products/{ScopeId}/fromGlobal | Copies products from Global scope to a sales scope - {AddFromGlobalRequest}
[**AddOrUpdatePriceListRequestScopeIdpriceListsPost**](ProductsApi.md#addorupdatepricelistrequestscopeidpricelistspost) | **POST** /products/{ScopeId}/priceLists | Adds or updates the given price lists into the specified scope - {AddOrUpdatePriceListRequest}
[**AddPriceListEntryRequestScopeIdProductIdpriceListEntriesPost**](ProductsApi.md#addpricelistentryrequestscopeidproductidpricelistentriespost) | **POST** /products/{ScopeId}/{ProductId}/priceListEntries | Adds a price List Entry - {AddPriceListEntryRequest}
[**BulkAssignProductCategoriesRequestScopeIdbulkAssignCategoriesPost**](ProductsApi.md#bulkassignproductcategoriesrequestscopeidbulkassigncategoriespost) | **POST** /products/{ScopeId}/bulkAssignCategories | Starts a task that updates category associations for multiple products - {BulkAssignProductCategoriesRequest}
[**BulkRevertProductChangesRequestScopeIdbulkRevertPost**](ProductsApi.md#bulkrevertproductchangesrequestscopeidbulkrevertpost) | **POST** /products/{ScopeId}/bulkRevert | Starts a task that reverts not published product changes for multiple products by replacing working copies of products with their published counterparts - {BulkRevertProductChangesRequest}
[**BulkUpdatePublicationStatusRequestScopeIdbulkUpdatePublicationStatusPost**](ProductsApi.md#bulkupdatepublicationstatusrequestscopeidbulkupdatepublicationstatuspost) | **POST** /products/{ScopeId}/bulkUpdatePublicationStatus | Starts a task that updates publication status for multiple products - {BulkUpdatePublicationStatusRequest}
[**CalculatePricesofProductsRequestScopeIdpricesPost**](ProductsApi.md#calculatepricesofproductsrequestscopeidpricespost) | **POST** /products/{ScopeId}/prices | Retrieve the price of a product - {CalculatePricesofProductsRequest}
[**CalculateProductPriceRequestScopeIdProductIdpricePost**](ProductsApi.md#calculateproductpricerequestscopeidproductidpricepost) | **POST** /products/{ScopeId}/{ProductId}/price | Retrieve the price of a product - {CalculateProductPriceRequest}
[**CopyProductRequestScopeIdProductIdcopyNewProductIdCreate**](ProductsApi.md#copyproductrequestscopeidproductidcopynewproductidcreate) | **PUT** /products/{ScopeId}/{ProductId}/copy/{NewProductId} | A request to copy a product - {CopyProductRequest}
[**CreatePriceListRequestScopeIdpriceListsPriceListIdPost**](ProductsApi.md#createpricelistrequestscopeidpricelistspricelistidpost) | **POST** /products/{ScopeId}/priceLists/{PriceListId} | Creates a price list into the specified scope - {CreatePriceListRequest}
[**CreateProductRequestScopeIdPost**](ProductsApi.md#createproductrequestscopeidpost) | **POST** /products/{ScopeId} | Creates a product in the specified scope - {CreateProductRequest}
[**DeletePriceListEntryRequestScopeIdProductIdpriceListEntriesPriceListIdDelete**](ProductsApi.md#deletepricelistentryrequestscopeidproductidpricelistentriespricelistiddelete) | **DELETE** /products/{ScopeId}/{ProductId}/priceListEntries/{PriceListId} | Deletes a price List Entry - {DeletePriceListEntryRequest}
[**DeletePriceListRequestScopeIdpriceListsPriceListIdDelete**](ProductsApi.md#deletepricelistrequestscopeidpricelistspricelistiddelete) | **DELETE** /products/{ScopeId}/priceLists/{PriceListId} | Deletes a price list - {DeletePriceListRequest}
[**DeleteProductByIdRequestScopeIdproductProductIdDelete**](ProductsApi.md#deleteproductbyidrequestscopeidproductproductiddelete) | **DELETE** /products/{ScopeId}/product/{ProductId} | Deletes product from the scope and all child scopes - {DeleteProductByIdRequest}
[**DeleteProductByIdV2Requestv2ScopeIdProductIdDelete**](ProductsApi.md#deleteproductbyidv2requestv2scopeidproductiddelete) | **DELETE** /products/v2/{ScopeId}/{ProductId} | Deletes product from the scope and all child scopes - {DeleteProductByIdV2Request}
[**DeleteProductDraftRequestScopeIddraftProductIdDelete**](ProductsApi.md#deleteproductdraftrequestscopeiddraftproductiddelete) | **DELETE** /products/{ScopeId}/draft/{ProductId} | Delete a product draft - {DeleteProductDraftRequest}
[**DeleteProductSettingsEntryRequestsettingsEntryDelete**](ProductsApi.md#deleteproductsettingsentryrequestsettingsentrydelete) | **DELETE** /products/settings/{Entry} | Delete a setting used in product module - {DeleteProductSettingsEntryRequest}
[**DeleteProductsRequestScopeIdbulkDeletePost**](ProductsApi.md#deleteproductsrequestscopeidbulkdeletepost) | **POST** /products/{ScopeId}/bulkDelete | Starts a task that deletes multiple products - {DeleteProductsRequest}
[**DeleteUnusedMediaStorageRequestmediastorageDelete**](ProductsApi.md#deleteunusedmediastoragerequestmediastoragedelete) | **DELETE** /products/media/storage | Cleanup unused media storage - {DeleteUnusedMediaStorageRequest}
[**FindPriceListsRequestScopeIdpriceListsfindGet**](ProductsApi.md#findpricelistsrequestscopeidpricelistsfindget) | **GET** /products/{ScopeId}/priceLists/find | Find all price lists - {FindPriceListsRequest}
[**FindProductPricesRequestScopeIdproductPricesPost**](ProductsApi.md#findproductpricesrequestscopeidproductpricespost) | **POST** /products/{ScopeId}/productPrices | Retrieve the price of a set of Product and its Variants - {FindProductPricesRequest}
[**GetEffectivePriceEntryInfoRequestScopeIdProductIdeffectivePriceEntryInfoGet**](ProductsApi.md#geteffectivepriceentryinforequestscopeidproductideffectivepriceentryinfoget) | **GET** /products/{ScopeId}/{ProductId}/effectivePriceEntryInfo | Retrieves the Price List Info for a product at a specific DateTime - {GetEffectivePriceEntryInfoRequest}
[**GetMediaBySkuRequestScopeIdbySkuSkumediaPost**](ProductsApi.md#getmediabyskurequestscopeidbyskuskumediapost) | **POST** /products/{ScopeId}/bySku/{Sku}/media | Retrieve the media by sku, it can be the product or the variant sku - {GetMediaBySkuRequest}
[**GetMediaRequestScopeIdProductIdmediaMediaIdGet**](ProductsApi.md#getmediarequestscopeidproductidmediamediaidget) | **GET** /products/{ScopeId}/{ProductId}/media/{MediaId} | Retrieve a media by Id - {GetMediaRequest}
[**GetMediaSettingsRequestmediasettingsGet**](ProductsApi.md#getmediasettingsrequestmediasettingsget) | **GET** /products/media/settings | Get the settings used in products media - {GetMediaSettingsRequest}
[**GetPriceListEntriesRequestScopeIdProductIdpriceListEntriesGet**](ProductsApi.md#getpricelistentriesrequestscopeidproductidpricelistentriesget) | **GET** /products/{ScopeId}/{ProductId}/priceListEntries | Retrieve price list entries - {GetPriceListEntriesRequest}
[**GetPriceListsRequestScopeIdpriceListsGet**](ProductsApi.md#getpricelistsrequestscopeidpricelistsget) | **GET** /products/{ScopeId}/priceLists | Gets all price lists - {GetPriceListsRequest}
[**GetProductAttributesRequestattributesGet**](ProductsApi.md#getproductattributesrequestattributesget) | **GET** /products/attributes/ | Retrieve and merge all the product attributes from all product definitions - {GetProductAttributesRequest}
[**GetProductDefinitionRequestdefinitionsNameGet**](ProductsApi.md#getproductdefinitionrequestdefinitionsnameget) | **GET** /products/definitions/{Name} | Retrieve the entity definition defined in the system related to the Name parameter specified in the request - {GetProductDefinitionRequest}
[**GetProductDefinitionsRequestdefinitionsGet**](ProductsApi.md#getproductdefinitionsrequestdefinitionsget) | **GET** /products/definitions | Retrieve the entity definitions defined in the system related to the EntityType parameter specified in the request - {GetProductDefinitionsRequest}
[**GetProductDraftRequestScopeIddraftProductIdGet**](ProductsApi.md#getproductdraftrequestscopeiddraftproductidget) | **GET** /products/{ScopeId}/draft/{ProductId} | Retrieve a product draft by product id - {GetProductDraftRequest}
[**GetProductDraftStatesRequestScopeIddraftStatesProductIdGet**](ProductsApi.md#getproductdraftstatesrequestscopeiddraftstatesproductidget) | **GET** /products/{ScopeId}/draftStates/{ProductId} | Retrieve a product draft states by product id - {GetProductDraftStatesRequest}
[**GetProductPriceEntriesRequestScopeIdProductIdproductPriceEntriesPost**](ProductsApi.md#getproductpriceentriesrequestscopeidproductidproductpriceentriespost) | **POST** /products/{ScopeId}/{ProductId}/productPriceEntries | Retrieve product prices by Id - {GetProductPriceEntriesRequest}
[**GetProductRelationshipsRequestScopeIdProductIdrelationshipsGet**](ProductsApi.md#getproductrelationshipsrequestscopeidproductidrelationshipsget) | **GET** /products/{ScopeId}/{ProductId}/relationships | Retrieve a product relationships - {GetProductRelationshipsRequest}
[**GetProductRequestScopeIdProductIdGet**](ProductsApi.md#getproductrequestscopeidproductidget) | **GET** /products/{ScopeId}/{ProductId} | Retrieve a product by Id - {GetProductRequest}
[**GetProductSettingsRequestsettingsGet**](ProductsApi.md#getproductsettingsrequestsettingsget) | **GET** /products/settings | Get the settings used in product module - {GetProductSettingsRequest}
[**GetProductV2Requestv2ScopeIdProductIdGet**](ProductsApi.md#getproductv2requestv2scopeidproductidget) | **GET** /products/v2/{ScopeId}/{ProductId} | Retrieve a product by Id - {GetProductV2Request}
[**GetProductsByIdsRequestScopeIdbyIdsPost**](ProductsApi.md#getproductsbyidsrequestscopeidbyidspost) | **POST** /products/{ScopeId}/byIds | Retrieve products by Ids - {GetProductsByIdsRequest}
[**GetProductsByIdsV2Requestv2ScopeIdbyIdsPost**](ProductsApi.md#getproductsbyidsv2requestv2scopeidbyidspost) | **POST** /products/v2/{ScopeId}/byIds | Retrieve products by Ids - {GetProductsByIdsV2Request}
[**GetProductsByPublicationStatusRequestScopeIdbyPublicationStatusPost**](ProductsApi.md#getproductsbypublicationstatusrequestscopeidbypublicationstatuspost) | **POST** /products/{ScopeId}/byPublicationStatus | Retrieve specified properties of all products with a given publication status and categories - {GetProductsByPublicationStatusRequest}
[**GetProductsBySkuRequestScopeIdbySkuSkuGet**](ProductsApi.md#getproductsbyskurequestscopeidbyskuskuget) | **GET** /products/{ScopeId}/bySku/{Sku} | Retrieve the products by sku, it can be the product or the variant sku - {GetProductsBySkuRequest}
[**GetProductsBySkuV2Requestv2ScopeIdbySkuSkuGet**](ProductsApi.md#getproductsbyskuv2requestv2scopeidbyskuskuget) | **GET** /products/v2/{ScopeId}/bySku/{Sku} | Retrieve the products by sku, it can be the product or the variant sku - {GetProductsBySkuV2Request}
[**GetProductsBySkusV2Requestv2ScopeIdbySkusPost**](ProductsApi.md#getproductsbyskusv2requestv2scopeidbyskuspost) | **POST** /products/v2/{ScopeId}/bySkus | Retrieve products by SKU-s - {GetProductsBySkusV2Request}
[**GetProductsCountByCategoryRequestScopeIdCategoryIdcountGet**](ProductsApi.md#getproductscountbycategoryrequestscopeidcategoryidcountget) | **GET** /products/{ScopeId}/{CategoryId}/count | Retrieve the numbers of products by category - {GetProductsCountByCategoryRequest}
[**GetProductsPriceEntriesRequestScopeIdproductPriceEntriesPost**](ProductsApi.md#getproductspriceentriesrequestscopeidproductpriceentriespost) | **POST** /products/{ScopeId}/productPriceEntries | Retrieve product prices by Id - {GetProductsPriceEntriesRequest}
[**GetProductsPropertiesByCategoryRequestScopeIdbyCategoryIdCategoryIdGet**](ProductsApi.md#getproductspropertiesbycategoryrequestscopeidbycategoryidcategoryidget) | **GET** /products/{ScopeId}/byCategoryId/{CategoryId} | Retrieve specified properties of all products in a given category - {GetProductsPropertiesByCategoryRequest}
[**GetProductsPropertiesByDraftStateAndCategoriesRequestScopeIdbyDraftStateAndCategoriesPost**](ProductsApi.md#getproductspropertiesbydraftstateandcategoriesrequestscopeidbydraftstateandcategoriespost) | **POST** /products/{ScopeId}/byDraftStateAndCategories | Retrieve specified properties of all products in a given state and categories - {GetProductsPropertiesByDraftStateAndCategoriesRequest}
[**GetProductsPropertiesByDraftStateRequestScopeIdbyDraftStateDraftStateGet**](ProductsApi.md#getproductspropertiesbydraftstaterequestscopeidbydraftstatedraftstateget) | **GET** /products/{ScopeId}/byDraftState/{DraftState} | Retrieve specified properties of all products in a given state - {GetProductsPropertiesByDraftStateRequest}
[**GetProductsPropertiesFlagAsNewRequestScopeIdflagAsNewGet**](ProductsApi.md#getproductspropertiesflagasnewrequestscopeidflagasnewget) | **GET** /products/{ScopeId}/flagAsNew | Retrieve specified properties of all products flagged as new - {GetProductsPropertiesFlagAsNewRequest}
[**GetProductsPropertiesWithNotificationRequestScopeIdwithNotificationGet**](ProductsApi.md#getproductspropertieswithnotificationrequestscopeidwithnotificationget) | **GET** /products/{ScopeId}/withNotification | Retrieve properties of all product with notification - {GetProductsPropertiesWithNotificationRequest}
[**GetProductsStatisticsRequestScopeIdstatisticsGet**](ProductsApi.md#getproductsstatisticsrequestscopeidstatisticsget) | **GET** /products/{ScopeId}/statistics | Gets statistics for products - {GetProductsStatisticsRequest}
[**GetQuickLinksCountDetailsRequestquicklinksGet**](ProductsApi.md#getquicklinkscountdetailsrequestquicklinksget) | **GET** /products/quicklinks | Retrieve the products quick links count - {GetQuickLinksCountDetailsRequest}
[**GetVariantsByProductRequestScopeIdProductIdvariantsGet**](ProductsApi.md#getvariantsbyproductrequestscopeidproductidvariantsget) | **GET** /products/{ScopeId}/{ProductId}/variants | Retrieve all the product&#39;s variants - {GetVariantsByProductRequest}
[**ProductExistsRequestexistsScopeIdProductIdGet**](ProductsApi.md#productexistsrequestexistsscopeidproductidget) | **GET** /products/exists/{ScopeId}/{ProductId} | Checks whether the product exists in the specified scope - {ProductExistsRequest}
[**RepairProductInheritanceRequestScopeIdProductIdrepairInheritanceCreate**](ProductsApi.md#repairproductinheritancerequestscopeidproductidrepairinheritancecreate) | **PUT** /products/{ScopeId}/{ProductId}/repairInheritance | Repair Broken Inheritence for the product - {RepairProductInheritanceRequest}
[**RevertProductChangesRequestScopeIdrevertPost**](ProductsApi.md#revertproductchangesrequestscopeidrevertpost) | **POST** /products/{ScopeId}/revert | Reverts not published product changes by replacing working copies of products with their published counterparts - {RevertProductChangesRequest}
[**SyncProductRequestsyncScopeIdProductIdCreate**](ProductsApi.md#syncproductrequestsyncscopeidproductidcreate) | **PUT** /products/sync/{ScopeId}/{ProductId} | Synchronizes a product - {SyncProductRequest}
[**UpdateMediaResizedInstancesRequestScopeIdProductIdmediaMediaIdresizedCreate**](ProductsApi.md#updatemediaresizedinstancesrequestscopeidproductidmediamediaidresizedcreate) | **PUT** /products/{ScopeId}/{ProductId}/media/{MediaId}/resized | Update media resized instances - {UpdateMediaResizedInstancesRequest}
[**UpdateMediaSettingsRequestmediasettingsCreate**](ProductsApi.md#updatemediasettingsrequestmediasettingscreate) | **PUT** /products/media/settings | Update the settings used in product media - {UpdateMediaSettingsRequest}
[**UpdatePriceListEntryRequestScopeIdProductIdpriceListEntriesCreate**](ProductsApi.md#updatepricelistentryrequestscopeidproductidpricelistentriescreate) | **PUT** /products/{ScopeId}/{ProductId}/priceListEntries | Updates a price List Entry - {UpdatePriceListEntryRequest}
[**UpdatePriceListRequestScopeIdpriceListsPriceListIdCreate**](ProductsApi.md#updatepricelistrequestscopeidpricelistspricelistidcreate) | **PUT** /products/{ScopeId}/priceLists/{PriceListId} | Updates a price list in the specified scope - {UpdatePriceListRequest}
[**UpdateProductDraftRequestScopeIddraftProductIdPost**](ProductsApi.md#updateproductdraftrequestscopeiddraftproductidpost) | **POST** /products/{ScopeId}/draft/{ProductId} | Update a product draft - {UpdateProductDraftRequest}
[**UpdateProductPublicationStatusRequestScopeIdpublicationStatusPost**](ProductsApi.md#updateproductpublicationstatusrequestscopeidpublicationstatuspost) | **POST** /products/{ScopeId}/publicationStatus | Updates publication status for a list of products - {UpdateProductPublicationStatusRequest}
[**UpdateProductRequestScopeIdProductIdCreate**](ProductsApi.md#updateproductrequestscopeidproductidcreate) | **PUT** /products/{ScopeId}/{ProductId} | Updates a product - {UpdateProductRequest}
[**UpdateProductSettingsRequestsettingsCreate**](ProductsApi.md#updateproductsettingsrequestsettingscreate) | **PUT** /products/settings | Update the settings used in product module - {UpdateProductSettingsRequest}
[**UpdateVariantsPriceListEntryRequestScopeIdProductIdvariantsPricesPriceListIdCreate**](ProductsApi.md#updatevariantspricelistentryrequestscopeidproductidvariantspricespricelistidcreate) | **PUT** /products/{ScopeId}/{ProductId}/variantsPrices/{PriceListId} | Batch update all variants price for a product for a specific pricelist - {UpdateVariantsPriceListEntryRequest}
[**UploadMediaRequestmediaScopeIdProductIduploadPost**](ProductsApi.md#uploadmediarequestmediascopeidproductiduploadpost) | **POST** /products/media/{ScopeId}/{ProductId}/upload | Uploads a media file and attaches it to the product/variant - {UploadMediaRequest}


<a name="addfromglobalrequestscopeidfromglobalpost"></a>
# **AddFromGlobalRequestScopeIdfromGlobalPost**
> TaskInfo AddFromGlobalRequestScopeIdfromGlobalPost (string accept, string scopeId, AddFromGlobalRequest body = null)

Copies products from Global scope to a sales scope - {AddFromGlobalRequest}

Copies products from Global scope to a sales scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddFromGlobalRequestScopeIdfromGlobalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new AddFromGlobalRequest(); // AddFromGlobalRequest |  (optional) 

            try
            {
                // Copies products from Global scope to a sales scope - {AddFromGlobalRequest}
                TaskInfo result = apiInstance.AddFromGlobalRequestScopeIdfromGlobalPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.AddFromGlobalRequestScopeIdfromGlobalPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**AddFromGlobalRequest**](AddFromGlobalRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorupdatepricelistrequestscopeidpricelistspost"></a>
# **AddOrUpdatePriceListRequestScopeIdpriceListsPost**
> void AddOrUpdatePriceListRequestScopeIdpriceListsPost (string accept, string scopeId, AddOrUpdatePriceListRequest body = null)

Adds or updates the given price lists into the specified scope - {AddOrUpdatePriceListRequest}

Adds or updates the given price lists into the specified scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdatePriceListRequestScopeIdpriceListsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new AddOrUpdatePriceListRequest(); // AddOrUpdatePriceListRequest |  (optional) 

            try
            {
                // Adds or updates the given price lists into the specified scope - {AddOrUpdatePriceListRequest}
                apiInstance.AddOrUpdatePriceListRequestScopeIdpriceListsPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.AddOrUpdatePriceListRequestScopeIdpriceListsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**AddOrUpdatePriceListRequest**](AddOrUpdatePriceListRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpricelistentryrequestscopeidproductidpricelistentriespost"></a>
# **AddPriceListEntryRequestScopeIdProductIdpriceListEntriesPost**
> PriceListEntry AddPriceListEntryRequestScopeIdProductIdpriceListEntriesPost (string accept, string scopeId, string productId, AddPriceListEntryRequest body = null)

Adds a price List Entry - {AddPriceListEntryRequest}

Adds a price List Entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddPriceListEntryRequestScopeIdProductIdpriceListEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product for which we want to add a price list entry
            var body = new AddPriceListEntryRequest(); // AddPriceListEntryRequest |  (optional) 

            try
            {
                // Adds a price List Entry - {AddPriceListEntryRequest}
                PriceListEntry result = apiInstance.AddPriceListEntryRequestScopeIdProductIdpriceListEntriesPost(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.AddPriceListEntryRequestScopeIdProductIdpriceListEntriesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product for which we want to add a price list entry | 
 **body** | [**AddPriceListEntryRequest**](AddPriceListEntryRequest.md)|  | [optional] 

### Return type

[**PriceListEntry**](PriceListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkassignproductcategoriesrequestscopeidbulkassigncategoriespost"></a>
# **BulkAssignProductCategoriesRequestScopeIdbulkAssignCategoriesPost**
> TaskInfo BulkAssignProductCategoriesRequestScopeIdbulkAssignCategoriesPost (string accept, string scopeId, BulkAssignProductCategoriesRequest body = null)

Starts a task that updates category associations for multiple products - {BulkAssignProductCategoriesRequest}

Starts a task that updates category associations for multiple products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class BulkAssignProductCategoriesRequestScopeIdbulkAssignCategoriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new BulkAssignProductCategoriesRequest(); // BulkAssignProductCategoriesRequest |  (optional) 

            try
            {
                // Starts a task that updates category associations for multiple products - {BulkAssignProductCategoriesRequest}
                TaskInfo result = apiInstance.BulkAssignProductCategoriesRequestScopeIdbulkAssignCategoriesPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.BulkAssignProductCategoriesRequestScopeIdbulkAssignCategoriesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**BulkAssignProductCategoriesRequest**](BulkAssignProductCategoriesRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkrevertproductchangesrequestscopeidbulkrevertpost"></a>
# **BulkRevertProductChangesRequestScopeIdbulkRevertPost**
> TaskInfo BulkRevertProductChangesRequestScopeIdbulkRevertPost (string accept, string scopeId, BulkRevertProductChangesRequest body = null)

Starts a task that reverts not published product changes for multiple products by replacing working copies of products with their published counterparts - {BulkRevertProductChangesRequest}

Starts a task that reverts not published product changes for multiple products by replacing working copies of products with their published counterparts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class BulkRevertProductChangesRequestScopeIdbulkRevertPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new BulkRevertProductChangesRequest(); // BulkRevertProductChangesRequest |  (optional) 

            try
            {
                // Starts a task that reverts not published product changes for multiple products by replacing working copies of products with their published counterparts - {BulkRevertProductChangesRequest}
                TaskInfo result = apiInstance.BulkRevertProductChangesRequestScopeIdbulkRevertPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.BulkRevertProductChangesRequestScopeIdbulkRevertPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**BulkRevertProductChangesRequest**](BulkRevertProductChangesRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatepublicationstatusrequestscopeidbulkupdatepublicationstatuspost"></a>
# **BulkUpdatePublicationStatusRequestScopeIdbulkUpdatePublicationStatusPost**
> TaskInfo BulkUpdatePublicationStatusRequestScopeIdbulkUpdatePublicationStatusPost (string accept, string scopeId, BulkUpdatePublicationStatusRequest body = null)

Starts a task that updates publication status for multiple products - {BulkUpdatePublicationStatusRequest}

Starts a task that updates publication status for multiple products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class BulkUpdatePublicationStatusRequestScopeIdbulkUpdatePublicationStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new BulkUpdatePublicationStatusRequest(); // BulkUpdatePublicationStatusRequest |  (optional) 

            try
            {
                // Starts a task that updates publication status for multiple products - {BulkUpdatePublicationStatusRequest}
                TaskInfo result = apiInstance.BulkUpdatePublicationStatusRequestScopeIdbulkUpdatePublicationStatusPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.BulkUpdatePublicationStatusRequestScopeIdbulkUpdatePublicationStatusPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**BulkUpdatePublicationStatusRequest**](BulkUpdatePublicationStatusRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="calculatepricesofproductsrequestscopeidpricespost"></a>
# **CalculatePricesofProductsRequestScopeIdpricesPost**
> List&lt;ProductPrice&gt; CalculatePricesofProductsRequestScopeIdpricesPost (string accept, string scopeId, CalculatePricesofProductsRequest body = null)

Retrieve the price of a product - {CalculatePricesofProductsRequest}

Retrieve the price product by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CalculatePricesofProductsRequestScopeIdpricesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CalculatePricesofProductsRequest(); // CalculatePricesofProductsRequest |  (optional) 

            try
            {
                // Retrieve the price of a product - {CalculatePricesofProductsRequest}
                List<ProductPrice> result = apiInstance.CalculatePricesofProductsRequestScopeIdpricesPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CalculatePricesofProductsRequestScopeIdpricesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**CalculatePricesofProductsRequest**](CalculatePricesofProductsRequest.md)|  | [optional] 

### Return type

[**List&lt;ProductPrice&gt;**](ProductPrice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When no price was found for the product or the product doesn&#39;t exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="calculateproductpricerequestscopeidproductidpricepost"></a>
# **CalculateProductPriceRequestScopeIdProductIdpricePost**
> ProductPrice CalculateProductPriceRequestScopeIdProductIdpricePost (string accept, string scopeId, string productId, CalculateProductPriceRequest body = null)

Retrieve the price of a product - {CalculateProductPriceRequest}

Retrieve the price product by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CalculateProductPriceRequestScopeIdProductIdpricePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | the business id for the product to retrieve
            var body = new CalculateProductPriceRequest(); // CalculateProductPriceRequest |  (optional) 

            try
            {
                // Retrieve the price of a product - {CalculateProductPriceRequest}
                ProductPrice result = apiInstance.CalculateProductPriceRequestScopeIdProductIdpricePost(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CalculateProductPriceRequestScopeIdProductIdpricePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| the business id for the product to retrieve | 
 **body** | [**CalculateProductPriceRequest**](CalculateProductPriceRequest.md)|  | [optional] 

### Return type

[**ProductPrice**](ProductPrice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When no price was found for the product or the product doesn&#39;t exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copyproductrequestscopeidproductidcopynewproductidcreate"></a>
# **CopyProductRequestScopeIdProductIdcopyNewProductIdCreate**
> Product CopyProductRequestScopeIdProductIdcopyNewProductIdCreate (string accept, string scopeId, string productId, string newProductId, Object body = null)

A request to copy a product - {CopyProductRequest}

A request to copy a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CopyProductRequestScopeIdProductIdcopyNewProductIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product to be copied
            var newProductId = newProductId_example;  // string | The id of the product to be created
            var body = ;  // Object |  (optional) 

            try
            {
                // A request to copy a product - {CopyProductRequest}
                Product result = apiInstance.CopyProductRequestScopeIdProductIdcopyNewProductIdCreate(accept, scopeId, productId, newProductId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CopyProductRequestScopeIdProductIdcopyNewProductIdCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product to be copied | 
 **newProductId** | **string**| The id of the product to be created | 
 **body** | **Object**|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpricelistrequestscopeidpricelistspricelistidpost"></a>
# **CreatePriceListRequestScopeIdpriceListsPriceListIdPost**
> PriceList CreatePriceListRequestScopeIdpriceListsPriceListIdPost (string accept, string scopeId, string priceListId, CreatePriceListRequest body = null)

Creates a price list into the specified scope - {CreatePriceListRequest}

Creates a price list into the specified scope. Its priority sequence is automatically calculated according to the specified price list with the next higher priority sequence.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreatePriceListRequestScopeIdpriceListsPriceListIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var priceListId = priceListId_example;  // string | The identifier of the PriceList.
            var body = new CreatePriceListRequest(); // CreatePriceListRequest |  (optional) 

            try
            {
                // Creates a price list into the specified scope - {CreatePriceListRequest}
                PriceList result = apiInstance.CreatePriceListRequestScopeIdpriceListsPriceListIdPost(accept, scopeId, priceListId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CreatePriceListRequestScopeIdpriceListsPriceListIdPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **priceListId** | **string**| The identifier of the PriceList. | 
 **body** | [**CreatePriceListRequest**](CreatePriceListRequest.md)|  | [optional] 

### Return type

[**PriceList**](PriceList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproductrequestscopeidpost"></a>
# **CreateProductRequestScopeIdPost**
> Product CreateProductRequestScopeIdPost (string accept, string scopeId, CreateProductRequest body = null)

Creates a product in the specified scope - {CreateProductRequest}

Creates a product in the specified scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateProductRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateProductRequest(); // CreateProductRequest |  (optional) 

            try
            {
                // Creates a product in the specified scope - {CreateProductRequest}
                Product result = apiInstance.CreateProductRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProductRequestScopeIdPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**CreateProductRequest**](CreateProductRequest.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepricelistentryrequestscopeidproductidpricelistentriespricelistiddelete"></a>
# **DeletePriceListEntryRequestScopeIdProductIdpriceListEntriesPriceListIdDelete**
> void DeletePriceListEntryRequestScopeIdProductIdpriceListEntriesPriceListIdDelete (string accept, string scopeId, string productId, string priceListId, string variantId = null)

Deletes a price List Entry - {DeletePriceListEntryRequest}

Deletes a price List Entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeletePriceListEntryRequestScopeIdProductIdpriceListEntriesPriceListIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product for which we want to delete a price list entry
            var priceListId = priceListId_example;  // string | The id of the price list for which we want to delete a price list entry
            var variantId = variantId_example;  // string | The id of the variant for which we want to delete a price list entry (optional) 

            try
            {
                // Deletes a price List Entry - {DeletePriceListEntryRequest}
                apiInstance.DeletePriceListEntryRequestScopeIdProductIdpriceListEntriesPriceListIdDelete(accept, scopeId, productId, priceListId, variantId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeletePriceListEntryRequestScopeIdProductIdpriceListEntriesPriceListIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product for which we want to delete a price list entry | 
 **priceListId** | **string**| The id of the price list for which we want to delete a price list entry | 
 **variantId** | **string**| The id of the variant for which we want to delete a price list entry | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepricelistrequestscopeidpricelistspricelistiddelete"></a>
# **DeletePriceListRequestScopeIdpriceListsPriceListIdDelete**
> void DeletePriceListRequestScopeIdpriceListsPriceListIdDelete (string accept, string scopeId, string priceListId, bool? deletePriceListEntries = null)

Deletes a price list - {DeletePriceListRequest}

Deletes a price list only if that price list does not have any price list entries neither in the scope nor in its dependent scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeletePriceListRequestScopeIdpriceListsPriceListIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var priceListId = priceListId_example;  // string | The identifier of the price list.
            var deletePriceListEntries = true;  // bool? | The value indicating whether the related price list entries should be deleted as well. (optional) 

            try
            {
                // Deletes a price list - {DeletePriceListRequest}
                apiInstance.DeletePriceListRequestScopeIdpriceListsPriceListIdDelete(accept, scopeId, priceListId, deletePriceListEntries);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeletePriceListRequestScopeIdpriceListsPriceListIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **priceListId** | **string**| The identifier of the price list. | 
 **deletePriceListEntries** | **bool?**| The value indicating whether the related price list entries should be deleted as well. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductbyidrequestscopeidproductproductiddelete"></a>
# **DeleteProductByIdRequestScopeIdproductProductIdDelete**
> void DeleteProductByIdRequestScopeIdproductProductIdDelete (string accept, string scopeId, string productId)

Deletes product from the scope and all child scopes - {DeleteProductByIdRequest}

Deletes product from the scope and all child scopes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductByIdRequestScopeIdproductProductIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The product's id.

            try
            {
                // Deletes product from the scope and all child scopes - {DeleteProductByIdRequest}
                apiInstance.DeleteProductByIdRequestScopeIdproductProductIdDelete(accept, scopeId, productId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductByIdRequestScopeIdproductProductIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The product&#39;s id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductbyidv2requestv2scopeidproductiddelete"></a>
# **DeleteProductByIdV2Requestv2ScopeIdProductIdDelete**
> void DeleteProductByIdV2Requestv2ScopeIdProductIdDelete (string accept, string scopeId, string productId)

Deletes product from the scope and all child scopes - {DeleteProductByIdV2Request}

Deletes product from the scope and all child scopes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductByIdV2Requestv2ScopeIdProductIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The product's id.

            try
            {
                // Deletes product from the scope and all child scopes - {DeleteProductByIdV2Request}
                apiInstance.DeleteProductByIdV2Requestv2ScopeIdProductIdDelete(accept, scopeId, productId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductByIdV2Requestv2ScopeIdProductIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The product&#39;s id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductdraftrequestscopeiddraftproductiddelete"></a>
# **DeleteProductDraftRequestScopeIddraftProductIdDelete**
> void DeleteProductDraftRequestScopeIddraftProductIdDelete (string accept, string scopeId, string productId)

Delete a product draft - {DeleteProductDraftRequest}

Delete a product draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductDraftRequestScopeIddraftProductIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | Gets or sets the id of the product for which we want to delete the draft

            try
            {
                // Delete a product draft - {DeleteProductDraftRequest}
                apiInstance.DeleteProductDraftRequestScopeIddraftProductIdDelete(accept, scopeId, productId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductDraftRequestScopeIddraftProductIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| Gets or sets the id of the product for which we want to delete the draft | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductsettingsentryrequestsettingsentrydelete"></a>
# **DeleteProductSettingsEntryRequestsettingsEntryDelete**
> void DeleteProductSettingsEntryRequestsettingsEntryDelete (string accept, string entry)

Delete a setting used in product module - {DeleteProductSettingsEntryRequest}

Delete a setting used in product module

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductSettingsEntryRequestsettingsEntryDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var entry = entry_example;  // string | the product settings entry to delete

            try
            {
                // Delete a setting used in product module - {DeleteProductSettingsEntryRequest}
                apiInstance.DeleteProductSettingsEntryRequestsettingsEntryDelete(accept, entry);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductSettingsEntryRequestsettingsEntryDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **entry** | **string**| the product settings entry to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductsrequestscopeidbulkdeletepost"></a>
# **DeleteProductsRequestScopeIdbulkDeletePost**
> TaskInfo DeleteProductsRequestScopeIdbulkDeletePost (string accept, string scopeId, DeleteProductsRequest body = null)

Starts a task that deletes multiple products - {DeleteProductsRequest}

Starts a task that deletes multiple products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteProductsRequestScopeIdbulkDeletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new DeleteProductsRequest(); // DeleteProductsRequest |  (optional) 

            try
            {
                // Starts a task that deletes multiple products - {DeleteProductsRequest}
                TaskInfo result = apiInstance.DeleteProductsRequestScopeIdbulkDeletePost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductsRequestScopeIdbulkDeletePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**DeleteProductsRequest**](DeleteProductsRequest.md)|  | [optional] 

### Return type

[**TaskInfo**](TaskInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteunusedmediastoragerequestmediastoragedelete"></a>
# **DeleteUnusedMediaStorageRequestmediastorageDelete**
> DeleteUnusedMediaStorageResponse DeleteUnusedMediaStorageRequestmediastorageDelete (string accept, string url = null)

Cleanup unused media storage - {DeleteUnusedMediaStorageRequest}

Delete unused media storage request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeleteUnusedMediaStorageRequestmediastorageDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var url = url_example;  // string | the Url of the media. (optional) 

            try
            {
                // Cleanup unused media storage - {DeleteUnusedMediaStorageRequest}
                DeleteUnusedMediaStorageResponse result = apiInstance.DeleteUnusedMediaStorageRequestmediastorageDelete(accept, url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteUnusedMediaStorageRequestmediastorageDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **url** | **string**| the Url of the media. | [optional] 

### Return type

[**DeleteUnusedMediaStorageResponse**](DeleteUnusedMediaStorageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findpricelistsrequestscopeidpricelistsfindget"></a>
# **FindPriceListsRequestScopeIdpriceListsfindGet**
> List&lt;PriceList&gt; FindPriceListsRequestScopeIdpriceListsfindGet (string accept, string scopeId, string cultureName = null, bool? includeExpiredEntries = null, DateTime? startDate = null, DateTime? endDate = null)

Find all price lists - {FindPriceListsRequest}

Find all price lists. Represents a group of prices that are applied to products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindPriceListsRequestScopeIdpriceListsfindGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 
            var includeExpiredEntries = true;  // bool? | Gets or sets a value indicating whether expired entries should be returned. Default is false. (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the lower bound of dates used to filter returned priceLists (optional). Set this date to filter the results to price lists active after this date. (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the upper bound of dates used to filter returned priceLists (optional). Set this date to filter the results to price lists active before this date. (optional) 

            try
            {
                // Find all price lists - {FindPriceListsRequest}
                List<PriceList> result = apiInstance.FindPriceListsRequestScopeIdpriceListsfindGet(accept, scopeId, cultureName, includeExpiredEntries, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.FindPriceListsRequestScopeIdpriceListsfindGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 
 **includeExpiredEntries** | **bool?**| Gets or sets a value indicating whether expired entries should be returned. Default is false. | [optional] 
 **startDate** | **DateTime?**| Gets or sets the lower bound of dates used to filter returned priceLists (optional). Set this date to filter the results to price lists active after this date. | [optional] 
 **endDate** | **DateTime?**| Gets or sets the upper bound of dates used to filter returned priceLists (optional). Set this date to filter the results to price lists active before this date. | [optional] 

### Return type

[**List&lt;PriceList&gt;**](PriceList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findproductpricesrequestscopeidproductpricespost"></a>
# **FindProductPricesRequestScopeIdproductPricesPost**
> List&lt;ProductPrice&gt; FindProductPricesRequestScopeIdproductPricesPost (string accept, string scopeId, FindProductPricesRequest body = null)

Retrieve the price of a set of Product and its Variants - {FindProductPricesRequest}

Retrieve the price of a set of Product and its Variants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindProductPricesRequestScopeIdproductPricesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The Scope of the request.
            var body = new FindProductPricesRequest(); // FindProductPricesRequest |  (optional) 

            try
            {
                // Retrieve the price of a set of Product and its Variants - {FindProductPricesRequest}
                List<ProductPrice> result = apiInstance.FindProductPricesRequestScopeIdproductPricesPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.FindProductPricesRequestScopeIdproductPricesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The Scope of the request. | 
 **body** | [**FindProductPricesRequest**](FindProductPricesRequest.md)|  | [optional] 

### Return type

[**List&lt;ProductPrice&gt;**](ProductPrice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteffectivepriceentryinforequestscopeidproductideffectivepriceentryinfoget"></a>
# **GetEffectivePriceEntryInfoRequestScopeIdProductIdeffectivePriceEntryInfoGet**
> EffectivePriceEntryInfo GetEffectivePriceEntryInfoRequestScopeIdProductIdeffectivePriceEntryInfoGet (string accept, string scopeId, string productId, string variantId = null, DateTime? referenceDate = null)

Retrieves the Price List Info for a product at a specific DateTime - {GetEffectivePriceEntryInfoRequest}

Retrieves the Price List Info for a product at a specific DateTime

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetEffectivePriceEntryInfoRequestScopeIdProductIdeffectivePriceEntryInfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product for which we want to retrieve the effective price
            var variantId = variantId_example;  // string | The id of the variant for which we want to retrieve the effective price (optional) 
            var referenceDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The Reference Date, null = Now (optional) 

            try
            {
                // Retrieves the Price List Info for a product at a specific DateTime - {GetEffectivePriceEntryInfoRequest}
                EffectivePriceEntryInfo result = apiInstance.GetEffectivePriceEntryInfoRequestScopeIdProductIdeffectivePriceEntryInfoGet(accept, scopeId, productId, variantId, referenceDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetEffectivePriceEntryInfoRequestScopeIdProductIdeffectivePriceEntryInfoGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product for which we want to retrieve the effective price | 
 **variantId** | **string**| The id of the variant for which we want to retrieve the effective price | [optional] 
 **referenceDate** | **DateTime?**| The Reference Date, null &#x3D; Now | [optional] 

### Return type

[**EffectivePriceEntryInfo**](EffectivePriceEntryInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmediabyskurequestscopeidbyskuskumediapost"></a>
# **GetMediaBySkuRequestScopeIdbySkuSkumediaPost**
> MediaList GetMediaBySkuRequestScopeIdbySkuSkumediaPost (string accept, string scopeId, string sku, GetMediaBySkuRequest body = null)

Retrieve the media by sku, it can be the product or the variant sku - {GetMediaBySkuRequest}

Retrieve the media by the specified the stock keeping unit code (SKU). It is either the Sku of the product or the Sku of one of its variants.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMediaBySkuRequestScopeIdbySkuSkumediaPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | the stock keeping unit code (SKU) for the products to retrieve
            var body = new GetMediaBySkuRequest(); // GetMediaBySkuRequest |  (optional) 

            try
            {
                // Retrieve the media by sku, it can be the product or the variant sku - {GetMediaBySkuRequest}
                MediaList result = apiInstance.GetMediaBySkuRequestScopeIdbySkuSkumediaPost(accept, scopeId, sku, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetMediaBySkuRequestScopeIdbySkuSkumediaPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **sku** | **string**| the stock keeping unit code (SKU) for the products to retrieve | 
 **body** | [**GetMediaBySkuRequest**](GetMediaBySkuRequest.md)|  | [optional] 

### Return type

[**MediaList**](MediaList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the media was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmediarequestscopeidproductidmediamediaidget"></a>
# **GetMediaRequestScopeIdProductIdmediaMediaIdGet**
> ProductMedia GetMediaRequestScopeIdProductIdmediaMediaIdGet (string accept, string scopeId, string productId, string mediaId)

Retrieve a media by Id - {GetMediaRequest}

Retrieve a media by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMediaRequestScopeIdProductIdmediaMediaIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | the business id for the product to retrieve
            var mediaId = mediaId_example;  // string | a media id

            try
            {
                // Retrieve a media by Id - {GetMediaRequest}
                ProductMedia result = apiInstance.GetMediaRequestScopeIdProductIdmediaMediaIdGet(accept, scopeId, productId, mediaId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetMediaRequestScopeIdProductIdmediaMediaIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| the business id for the product to retrieve | 
 **mediaId** | **string**| a media id | 

### Return type

[**ProductMedia**](ProductMedia.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the media was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmediasettingsrequestmediasettingsget"></a>
# **GetMediaSettingsRequestmediasettingsGet**
> MediaSettings GetMediaSettingsRequestmediasettingsGet (string accept)

Get the settings used in products media - {GetMediaSettingsRequest}

Get the settings used in products media

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMediaSettingsRequestmediasettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Get the settings used in products media - {GetMediaSettingsRequest}
                MediaSettings result = apiInstance.GetMediaSettingsRequestmediasettingsGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetMediaSettingsRequestmediasettingsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 

### Return type

[**MediaSettings**](MediaSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpricelistentriesrequestscopeidproductidpricelistentriesget"></a>
# **GetPriceListEntriesRequestScopeIdProductIdpriceListEntriesGet**
> List&lt;PriceListEntry&gt; GetPriceListEntriesRequestScopeIdProductIdpriceListEntriesGet (string accept, string scopeId, string productId, string variantId = null, bool? useParentScope = null, bool? includeExpiredEntries = null)

Retrieve price list entries - {GetPriceListEntriesRequest}

Retrieves price list entries for a given product or variant in a specific scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPriceListEntriesRequestScopeIdProductIdpriceListEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product for which we want to retrieve price list entries
            var variantId = variantId_example;  // string | The id of the variant for which we want to retrieve price list entries (optional) 
            var useParentScope = true;  // bool? | Returns values from the parent scope of the one provided in the request or not, default is false (optional) 
            var includeExpiredEntries = true;  // bool? | Gets or sets a value indicating whether expired entries should be returned. Default is false. (optional) 

            try
            {
                // Retrieve price list entries - {GetPriceListEntriesRequest}
                List<PriceListEntry> result = apiInstance.GetPriceListEntriesRequestScopeIdProductIdpriceListEntriesGet(accept, scopeId, productId, variantId, useParentScope, includeExpiredEntries);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetPriceListEntriesRequestScopeIdProductIdpriceListEntriesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product for which we want to retrieve price list entries | 
 **variantId** | **string**| The id of the variant for which we want to retrieve price list entries | [optional] 
 **useParentScope** | **bool?**| Returns values from the parent scope of the one provided in the request or not, default is false | [optional] 
 **includeExpiredEntries** | **bool?**| Gets or sets a value indicating whether expired entries should be returned. Default is false. | [optional] 

### Return type

[**List&lt;PriceListEntry&gt;**](PriceListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpricelistsrequestscopeidpricelistsget"></a>
# **GetPriceListsRequestScopeIdpriceListsGet**
> List&lt;PriceList&gt; GetPriceListsRequestScopeIdpriceListsGet (string accept, string scopeId, string cultureName = null)

Gets all price lists - {GetPriceListsRequest}

Gets all price lists. Represents a group of prices that are applied to products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPriceListsRequestScopeIdpriceListsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Gets all price lists - {GetPriceListsRequest}
                List<PriceList> result = apiInstance.GetPriceListsRequestScopeIdpriceListsGet(accept, scopeId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetPriceListsRequestScopeIdpriceListsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;PriceList&gt;**](PriceList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductattributesrequestattributesget"></a>
# **GetProductAttributesRequestattributesGet**
> ProductAttributes GetProductAttributesRequestattributesGet (string accept)

Retrieve and merge all the product attributes from all product definitions - {GetProductAttributesRequest}

Retrieve and merge all the product attributes from all product definitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductAttributesRequestattributesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve and merge all the product attributes from all product definitions - {GetProductAttributesRequest}
                ProductAttributes result = apiInstance.GetProductAttributesRequestattributesGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductAttributesRequestattributesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 

### Return type

[**ProductAttributes**](ProductAttributes.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductdefinitionrequestdefinitionsnameget"></a>
# **GetProductDefinitionRequestdefinitionsNameGet**
> ProductDefinition GetProductDefinitionRequestdefinitionsNameGet (string accept, string name, string cultureName = null)

Retrieve the entity definition defined in the system related to the Name parameter specified in the request - {GetProductDefinitionRequest}

A definition is a list of properties that is allowed to be set to the instance of product or category being used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductDefinitionRequestdefinitionsNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var name = name_example;  // string | The id to retrieve the related entity definition
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve the entity definition defined in the system related to the Name parameter specified in the request - {GetProductDefinitionRequest}
                ProductDefinition result = apiInstance.GetProductDefinitionRequestdefinitionsNameGet(accept, name, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductDefinitionRequestdefinitionsNameGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **name** | **string**| The id to retrieve the related entity definition | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**ProductDefinition**](ProductDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |
| **404** | Requested prodict definition not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductdefinitionsrequestdefinitionsget"></a>
# **GetProductDefinitionsRequestdefinitionsGet**
> List&lt;ProductDefinition&gt; GetProductDefinitionsRequestdefinitionsGet (string accept, string productType, string cultureName = null)

Retrieve the entity definitions defined in the system related to the EntityType parameter specified in the request - {GetProductDefinitionsRequest}

A definition is a list of properties that is allowed to be set to the instance of product or category being used. You could also specify a list of entity definitions name to retrieve. If you don't specify this list, all entity definitions will be return

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductDefinitionsRequestdefinitionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var productType = productType_example;  // string | The type of definition, either Product or Category are the possible values
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 

            try
            {
                // Retrieve the entity definitions defined in the system related to the EntityType parameter specified in the request - {GetProductDefinitionsRequest}
                List<ProductDefinition> result = apiInstance.GetProductDefinitionsRequestdefinitionsGet(accept, productType, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductDefinitionsRequestdefinitionsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **productType** | **string**| The type of definition, either Product or Category are the possible values | 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 

### Return type

[**List&lt;ProductDefinition&gt;**](ProductDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |
| **404** | Requested product definitions not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductdraftrequestscopeiddraftproductidget"></a>
# **GetProductDraftRequestScopeIddraftProductIdGet**
> ProductDraft GetProductDraftRequestScopeIddraftProductIdGet (string accept, string scopeId, string productId, string cultureName = null)

Retrieve a product draft by product id - {GetProductDraftRequest}

Retrieve a product draft by product id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductDraftRequestScopeIddraftProductIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | the business id for the product to retrieve
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve a product draft by product id - {GetProductDraftRequest}
                ProductDraft result = apiInstance.GetProductDraftRequestScopeIddraftProductIdGet(accept, scopeId, productId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductDraftRequestScopeIddraftProductIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| the business id for the product to retrieve | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**ProductDraft**](ProductDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product draft was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductdraftstatesrequestscopeiddraftstatesproductidget"></a>
# **GetProductDraftStatesRequestScopeIddraftStatesProductIdGet**
> LocalizedDraftState GetProductDraftStatesRequestScopeIddraftStatesProductIdGet (string accept, string scopeId, string productId)

Retrieve a product draft states by product id - {GetProductDraftStatesRequest}

Retrieve a product draft states by product id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductDraftStatesRequestScopeIddraftStatesProductIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | the business id for the product to retrieve

            try
            {
                // Retrieve a product draft states by product id - {GetProductDraftStatesRequest}
                LocalizedDraftState result = apiInstance.GetProductDraftStatesRequestScopeIddraftStatesProductIdGet(accept, scopeId, productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductDraftStatesRequestScopeIddraftStatesProductIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| the business id for the product to retrieve | 

### Return type

[**LocalizedDraftState**](LocalizedDraftState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductpriceentriesrequestscopeidproductidproductpriceentriespost"></a>
# **GetProductPriceEntriesRequestScopeIdProductIdproductPriceEntriesPost**
> GetProductPriceEntriesResult GetProductPriceEntriesRequestScopeIdProductIdproductPriceEntriesPost (string accept, string scopeId, string productId, GetProductPriceEntriesRequest body = null)

Retrieve product prices by Id - {GetProductPriceEntriesRequest}

Retrieve product's prices by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductPriceEntriesRequestScopeIdProductIdproductPriceEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | the business id for the product to retrieve
            var body = new GetProductPriceEntriesRequest(); // GetProductPriceEntriesRequest |  (optional) 

            try
            {
                // Retrieve product prices by Id - {GetProductPriceEntriesRequest}
                GetProductPriceEntriesResult result = apiInstance.GetProductPriceEntriesRequestScopeIdProductIdproductPriceEntriesPost(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductPriceEntriesRequestScopeIdProductIdproductPriceEntriesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| the business id for the product to retrieve | 
 **body** | [**GetProductPriceEntriesRequest**](GetProductPriceEntriesRequest.md)|  | [optional] 

### Return type

[**GetProductPriceEntriesResult**](GetProductPriceEntriesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductrelationshipsrequestscopeidproductidrelationshipsget"></a>
# **GetProductRelationshipsRequestScopeIdProductIdrelationshipsGet**
> List&lt;Relationship&gt; GetProductRelationshipsRequestScopeIdProductIdrelationshipsGet (string accept, string scopeId, string productId, string cultureName = null)

Retrieve a product relationships - {GetProductRelationshipsRequest}

Retrieve a product relationships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductRelationshipsRequestScopeIdProductIdrelationshipsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The product id
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve a product relationships - {GetProductRelationshipsRequest}
                List<Relationship> result = apiInstance.GetProductRelationshipsRequestScopeIdProductIdrelationshipsGet(accept, scopeId, productId, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductRelationshipsRequestScopeIdProductIdrelationshipsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The product id | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;Relationship&gt;**](Relationship.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductrequestscopeidproductidget"></a>
# **GetProductRequestScopeIdProductIdGet**
> Product GetProductRequestScopeIdProductIdGet (string accept, string scopeId, string productId, bool? includeImageUrl = null, bool? includeVariants = null, bool? includePriceLists = null, bool? includeRelationships = null, bool? includeMedia = null, string cultureName = null)

Retrieve a product by Id - {GetProductRequest}

Retrieve a product by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductRequestScopeIdProductIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | the business id for the product to retrieve
            var includeImageUrl = true;  // bool? |  Gets or sets a value indicating whether or not to include the image url. (optional) 
            var includeVariants = true;  // bool? | whether or not to include the variants (if they exists) of the product. (optional) 
            var includePriceLists = true;  // bool? | whether or not to include the price lists of the product. (optional) 
            var includeRelationships = true;  // bool? |  Gets or sets a value indicating whether or not to include the relationships of the product. (optional) 
            var includeMedia = true;  // bool? |  Gets or sets a value indicating whether or not to include the media of the product. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve a product by Id - {GetProductRequest}
                Product result = apiInstance.GetProductRequestScopeIdProductIdGet(accept, scopeId, productId, includeImageUrl, includeVariants, includePriceLists, includeRelationships, includeMedia, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductRequestScopeIdProductIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| the business id for the product to retrieve | 
 **includeImageUrl** | **bool?**|  Gets or sets a value indicating whether or not to include the image url. | [optional] 
 **includeVariants** | **bool?**| whether or not to include the variants (if they exists) of the product. | [optional] 
 **includePriceLists** | **bool?**| whether or not to include the price lists of the product. | [optional] 
 **includeRelationships** | **bool?**|  Gets or sets a value indicating whether or not to include the relationships of the product. | [optional] 
 **includeMedia** | **bool?**|  Gets or sets a value indicating whether or not to include the media of the product. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsettingsrequestsettingsget"></a>
# **GetProductSettingsRequestsettingsGet**
> ProductSettings GetProductSettingsRequestsettingsGet (string accept, string scopeId = null)

Get the settings used in product module - {GetProductSettingsRequest}

Get the settings used in product module

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductSettingsRequestsettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Get the settings used in product module - {GetProductSettingsRequest}
                ProductSettings result = apiInstance.GetProductSettingsRequestsettingsGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductSettingsRequestsettingsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | [optional] 

### Return type

[**ProductSettings**](ProductSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductv2requestv2scopeidproductidget"></a>
# **GetProductV2Requestv2ScopeIdProductIdGet**
> Product GetProductV2Requestv2ScopeIdProductIdGet (string accept, string scopeId, string productId, bool? includeImageUrl = null, bool? publishedVersion = null, bool? includeInheritanceInformation = null, bool? includeVariants = null, bool? includePriceLists = null, bool? includeRelationships = null, bool? includeMedia = null, string cultureName = null)

Retrieve a product by Id - {GetProductV2Request}

Retrieve a product by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductV2Requestv2ScopeIdProductIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The business id for the product to retrieve
            var includeImageUrl = true;  // bool? | A value indicating whether or not to include the image url. (optional) 
            var publishedVersion = true;  // bool? | A value indicating whether the published version of the product should be returned. (optional) 
            var includeInheritanceInformation = true;  // bool? | A value indicating whether to include the list of overridden properties and variants. Applicable for sales scopes. (optional) 
            var includeVariants = true;  // bool? | whether or not to include the variants (if they exists) of the product. (optional) 
            var includePriceLists = true;  // bool? | whether or not to include the price lists of the product. (optional) 
            var includeRelationships = true;  // bool? |  Gets or sets a value indicating whether or not to include the relationships of the product. (optional) 
            var includeMedia = true;  // bool? |  Gets or sets a value indicating whether or not to include the media of the product. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve a product by Id - {GetProductV2Request}
                Product result = apiInstance.GetProductV2Requestv2ScopeIdProductIdGet(accept, scopeId, productId, includeImageUrl, publishedVersion, includeInheritanceInformation, includeVariants, includePriceLists, includeRelationships, includeMedia, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductV2Requestv2ScopeIdProductIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The business id for the product to retrieve | 
 **includeImageUrl** | **bool?**| A value indicating whether or not to include the image url. | [optional] 
 **publishedVersion** | **bool?**| A value indicating whether the published version of the product should be returned. | [optional] 
 **includeInheritanceInformation** | **bool?**| A value indicating whether to include the list of overridden properties and variants. Applicable for sales scopes. | [optional] 
 **includeVariants** | **bool?**| whether or not to include the variants (if they exists) of the product. | [optional] 
 **includePriceLists** | **bool?**| whether or not to include the price lists of the product. | [optional] 
 **includeRelationships** | **bool?**|  Gets or sets a value indicating whether or not to include the relationships of the product. | [optional] 
 **includeMedia** | **bool?**|  Gets or sets a value indicating whether or not to include the media of the product. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsbyidsrequestscopeidbyidspost"></a>
# **GetProductsByIdsRequestScopeIdbyIdsPost**
> ProductList GetProductsByIdsRequestScopeIdbyIdsPost (string accept, string scopeId, GetProductsByIdsRequest body = null)

Retrieve products by Ids - {GetProductsByIdsRequest}

Retrieve a list of products by ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsByIdsRequestScopeIdbyIdsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetProductsByIdsRequest(); // GetProductsByIdsRequest |  (optional) 

            try
            {
                // Retrieve products by Ids - {GetProductsByIdsRequest}
                ProductList result = apiInstance.GetProductsByIdsRequestScopeIdbyIdsPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsByIdsRequestScopeIdbyIdsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**GetProductsByIdsRequest**](GetProductsByIdsRequest.md)|  | [optional] 

### Return type

[**ProductList**](ProductList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsbyidsv2requestv2scopeidbyidspost"></a>
# **GetProductsByIdsV2Requestv2ScopeIdbyIdsPost**
> ProductList GetProductsByIdsV2Requestv2ScopeIdbyIdsPost (string accept, string scopeId, GetProductsByIdsV2Request body = null)

Retrieve products by Ids - {GetProductsByIdsV2Request}

Retrieve products by ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsByIdsV2Requestv2ScopeIdbyIdsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetProductsByIdsV2Request(); // GetProductsByIdsV2Request |  (optional) 

            try
            {
                // Retrieve products by Ids - {GetProductsByIdsV2Request}
                ProductList result = apiInstance.GetProductsByIdsV2Requestv2ScopeIdbyIdsPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsByIdsV2Requestv2ScopeIdbyIdsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**GetProductsByIdsV2Request**](GetProductsByIdsV2Request.md)|  | [optional] 

### Return type

[**ProductList**](ProductList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsbypublicationstatusrequestscopeidbypublicationstatuspost"></a>
# **GetProductsByPublicationStatusRequestScopeIdbyPublicationStatusPost**
> GetProductsByPublicationStatusResult GetProductsByPublicationStatusRequestScopeIdbyPublicationStatusPost (string accept, string scopeId, GetProductsByPublicationStatusRequest body = null)

Retrieve specified properties of all products with a given publication status and categories - {GetProductsByPublicationStatusRequest}

Retrieve specified properties of all products with a given publication status and categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsByPublicationStatusRequestScopeIdbyPublicationStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetProductsByPublicationStatusRequest(); // GetProductsByPublicationStatusRequest |  (optional) 

            try
            {
                // Retrieve specified properties of all products with a given publication status and categories - {GetProductsByPublicationStatusRequest}
                GetProductsByPublicationStatusResult result = apiInstance.GetProductsByPublicationStatusRequestScopeIdbyPublicationStatusPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsByPublicationStatusRequestScopeIdbyPublicationStatusPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**GetProductsByPublicationStatusRequest**](GetProductsByPublicationStatusRequest.md)|  | [optional] 

### Return type

[**GetProductsByPublicationStatusResult**](GetProductsByPublicationStatusResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsbyskurequestscopeidbyskuskuget"></a>
# **GetProductsBySkuRequestScopeIdbySkuSkuGet**
> List&lt;Product&gt; GetProductsBySkuRequestScopeIdbySkuSkuGet (string accept, string scopeId, string sku, bool? includePriceLists = null, bool? includeRelationships = null, string cultureName = null)

Retrieve the products by sku, it can be the product or the variant sku - {GetProductsBySkuRequest}

Retrieve the products by the specified the stock keeping unit code (SKU). It is either the Sku of the product or the Sku of one of its variants. The products variants are always returned. According to the sku uniqueness level defined, more than one product may be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsBySkuRequestScopeIdbySkuSkuGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | the stock keeping unit code (SKU) for the products to retrieve
            var includePriceLists = true;  // bool? | whether or not to include the price lists of the products. (optional) 
            var includeRelationships = true;  // bool? |  Gets or sets a value indicating whether or not to include the relationships of the products. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 

            try
            {
                // Retrieve the products by sku, it can be the product or the variant sku - {GetProductsBySkuRequest}
                List<Product> result = apiInstance.GetProductsBySkuRequestScopeIdbySkuSkuGet(accept, scopeId, sku, includePriceLists, includeRelationships, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsBySkuRequestScopeIdbySkuSkuGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **sku** | **string**| the stock keeping unit code (SKU) for the products to retrieve | 
 **includePriceLists** | **bool?**| whether or not to include the price lists of the products. | [optional] 
 **includeRelationships** | **bool?**|  Gets or sets a value indicating whether or not to include the relationships of the products. | [optional] 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 

### Return type

[**List&lt;Product&gt;**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsbyskuv2requestv2scopeidbyskuskuget"></a>
# **GetProductsBySkuV2Requestv2ScopeIdbySkuSkuGet**
> ProductList GetProductsBySkuV2Requestv2ScopeIdbySkuSkuGet (string accept, string scopeId, string sku, bool? searchVariantSkus = null, bool? includePriceLists = null, bool? includeRelationships = null, string cultureName = null)

Retrieve the products by sku, it can be the product or the variant sku - {GetProductsBySkuV2Request}

Retrieve the products by the specified the stock keeping unit code (SKU). It is either the Sku of the product or the Sku of one of its variants. The products variants are always returned. According to the sku uniqueness level defined, more than one product may be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsBySkuV2Requestv2ScopeIdbySkuSkuGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var sku = sku_example;  // string | the stock keeping unit code (SKU) for the products to retrieve
            var searchVariantSkus = true;  // bool? | Gets or sets a value indicating whether or not to search for variant SKU-s, in addition to searching in product SKU-s. (optional) 
            var includePriceLists = true;  // bool? | whether or not to include the price lists of the products. (optional) 
            var includeRelationships = true;  // bool? |  Gets or sets a value indicating whether or not to include the relationships of the products. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language tha data will be returned (optional) 

            try
            {
                // Retrieve the products by sku, it can be the product or the variant sku - {GetProductsBySkuV2Request}
                ProductList result = apiInstance.GetProductsBySkuV2Requestv2ScopeIdbySkuSkuGet(accept, scopeId, sku, searchVariantSkus, includePriceLists, includeRelationships, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsBySkuV2Requestv2ScopeIdbySkuSkuGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **sku** | **string**| the stock keeping unit code (SKU) for the products to retrieve | 
 **searchVariantSkus** | **bool?**| Gets or sets a value indicating whether or not to search for variant SKU-s, in addition to searching in product SKU-s. | [optional] 
 **includePriceLists** | **bool?**| whether or not to include the price lists of the products. | [optional] 
 **includeRelationships** | **bool?**|  Gets or sets a value indicating whether or not to include the relationships of the products. | [optional] 
 **cultureName** | **string**| The culture name in which language tha data will be returned | [optional] 

### Return type

[**ProductList**](ProductList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsbyskusv2requestv2scopeidbyskuspost"></a>
# **GetProductsBySkusV2Requestv2ScopeIdbySkusPost**
> ProductList GetProductsBySkusV2Requestv2ScopeIdbySkusPost (string accept, string scopeId, GetProductsBySkusV2Request body = null)

Retrieve products by SKU-s - {GetProductsBySkusV2Request}

Retrieve products by ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsBySkusV2Requestv2ScopeIdbySkusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetProductsBySkusV2Request(); // GetProductsBySkusV2Request |  (optional) 

            try
            {
                // Retrieve products by SKU-s - {GetProductsBySkusV2Request}
                ProductList result = apiInstance.GetProductsBySkusV2Requestv2ScopeIdbySkusPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsBySkusV2Requestv2ScopeIdbySkusPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**GetProductsBySkusV2Request**](GetProductsBySkusV2Request.md)|  | [optional] 

### Return type

[**ProductList**](ProductList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | When the product was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductscountbycategoryrequestscopeidcategoryidcountget"></a>
# **GetProductsCountByCategoryRequestScopeIdCategoryIdcountGet**
> GetProductsCountByCategoryResponse GetProductsCountByCategoryRequestScopeIdCategoryIdcountGet (string accept, string scopeId, string categoryId, bool? includeDescendantsCategories = null)

Retrieve the numbers of products by category - {GetProductsCountByCategoryRequest}

Retrieve the numbers of products by category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsCountByCategoryRequestScopeIdCategoryIdcountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id at which point in the category hierarchy the 'get products' should  be started. If nothing is specified the root is used as starting point
            var includeDescendantsCategories = true;  // bool? | Whether or not the descendant categories content should be recursively included below the specified starting categoryId (optional) 

            try
            {
                // Retrieve the numbers of products by category - {GetProductsCountByCategoryRequest}
                GetProductsCountByCategoryResponse result = apiInstance.GetProductsCountByCategoryRequestScopeIdCategoryIdcountGet(accept, scopeId, categoryId, includeDescendantsCategories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsCountByCategoryRequestScopeIdCategoryIdcountGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **categoryId** | **string**| The category id at which point in the category hierarchy the &#39;get products&#39; should  be started. If nothing is specified the root is used as starting point | 
 **includeDescendantsCategories** | **bool?**| Whether or not the descendant categories content should be recursively included below the specified starting categoryId | [optional] 

### Return type

[**GetProductsCountByCategoryResponse**](GetProductsCountByCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductspriceentriesrequestscopeidproductpriceentriespost"></a>
# **GetProductsPriceEntriesRequestScopeIdproductPriceEntriesPost**
> List&lt;GetProductPriceEntriesResult&gt; GetProductsPriceEntriesRequestScopeIdproductPriceEntriesPost (string accept, string scopeId, GetProductsPriceEntriesRequest body = null)

Retrieve product prices by Id - {GetProductsPriceEntriesRequest}

Retrieve product's prices by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsPriceEntriesRequestScopeIdproductPriceEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetProductsPriceEntriesRequest(); // GetProductsPriceEntriesRequest |  (optional) 

            try
            {
                // Retrieve product prices by Id - {GetProductsPriceEntriesRequest}
                List<GetProductPriceEntriesResult> result = apiInstance.GetProductsPriceEntriesRequestScopeIdproductPriceEntriesPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsPriceEntriesRequestScopeIdproductPriceEntriesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**GetProductsPriceEntriesRequest**](GetProductsPriceEntriesRequest.md)|  | [optional] 

### Return type

[**List&lt;GetProductPriceEntriesResult&gt;**](GetProductPriceEntriesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductspropertiesbycategoryrequestscopeidbycategoryidcategoryidget"></a>
# **GetProductsPropertiesByCategoryRequestScopeIdbyCategoryIdCategoryIdGet**
> GetProductsPropertiesResult GetProductsPropertiesByCategoryRequestScopeIdbyCategoryIdCategoryIdGet (string accept, string scopeId, string categoryId, string cultureName = null, List<string> propertiesNames = null, int? startingIndex = null, int? maximumItems = null, string sortBy = null, string sortDirection = null)

Retrieve specified properties of all products in a given category - {GetProductsPropertiesByCategoryRequest}

Retrieve specified properties of all products in a given category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsPropertiesByCategoryRequestScopeIdbyCategoryIdCategoryIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var categoryId = categoryId_example;  // string | The category id at which point in the category hierarchy should the 'get products' be started.
            var cultureName = cultureName_example;  // string | The culture in which the data will be returned (optional) 
            var propertiesNames = new List<string>(); // List<string> | the list of properties to return (optional) 
            var startingIndex = 56;  // int? | the starting index in the results to start getting the products (used for paging purpose) (optional) 
            var maximumItems = 56;  // int? | The maximum number of results to return. Default value : 10 (optional) 
            var sortBy = sortBy_example;  // string | The name of the property to be sorted (optional) 
            var sortDirection = sortDirection_example;  // string | The sorting direction (optional) 

            try
            {
                // Retrieve specified properties of all products in a given category - {GetProductsPropertiesByCategoryRequest}
                GetProductsPropertiesResult result = apiInstance.GetProductsPropertiesByCategoryRequestScopeIdbyCategoryIdCategoryIdGet(accept, scopeId, categoryId, cultureName, propertiesNames, startingIndex, maximumItems, sortBy, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsPropertiesByCategoryRequestScopeIdbyCategoryIdCategoryIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **categoryId** | **string**| The category id at which point in the category hierarchy should the &#39;get products&#39; be started. | 
 **cultureName** | **string**| The culture in which the data will be returned | [optional] 
 **propertiesNames** | [**List&lt;string&gt;**](string.md)| the list of properties to return | [optional] 
 **startingIndex** | **int?**| the starting index in the results to start getting the products (used for paging purpose) | [optional] 
 **maximumItems** | **int?**| The maximum number of results to return. Default value : 10 | [optional] 
 **sortBy** | **string**| The name of the property to be sorted | [optional] 
 **sortDirection** | **string**| The sorting direction | [optional] 

### Return type

[**GetProductsPropertiesResult**](GetProductsPropertiesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductspropertiesbydraftstateandcategoriesrequestscopeidbydraftstateandcategoriespost"></a>
# **GetProductsPropertiesByDraftStateAndCategoriesRequestScopeIdbyDraftStateAndCategoriesPost**
> GetProductByCategoryAndStateResults GetProductsPropertiesByDraftStateAndCategoriesRequestScopeIdbyDraftStateAndCategoriesPost (string accept, string scopeId, GetProductsPropertiesByDraftStateAndCategoriesRequest body = null)

Retrieve specified properties of all products in a given state and categories - {GetProductsPropertiesByDraftStateAndCategoriesRequest}

Retrieve specified properties of all products in a given state and categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsPropertiesByDraftStateAndCategoriesRequestScopeIdbyDraftStateAndCategoriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new GetProductsPropertiesByDraftStateAndCategoriesRequest(); // GetProductsPropertiesByDraftStateAndCategoriesRequest |  (optional) 

            try
            {
                // Retrieve specified properties of all products in a given state and categories - {GetProductsPropertiesByDraftStateAndCategoriesRequest}
                GetProductByCategoryAndStateResults result = apiInstance.GetProductsPropertiesByDraftStateAndCategoriesRequestScopeIdbyDraftStateAndCategoriesPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsPropertiesByDraftStateAndCategoriesRequestScopeIdbyDraftStateAndCategoriesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**GetProductsPropertiesByDraftStateAndCategoriesRequest**](GetProductsPropertiesByDraftStateAndCategoriesRequest.md)|  | [optional] 

### Return type

[**GetProductByCategoryAndStateResults**](GetProductByCategoryAndStateResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductspropertiesbydraftstaterequestscopeidbydraftstatedraftstateget"></a>
# **GetProductsPropertiesByDraftStateRequestScopeIdbyDraftStateDraftStateGet**
> GetProductsPropertiesResult GetProductsPropertiesByDraftStateRequestScopeIdbyDraftStateDraftStateGet (string accept, string scopeId, string draftState, string cultureName = null, List<string> propertiesNames = null, int? startingIndex = null, int? maximumItems = null, string sortBy = null, string sortDirection = null)

Retrieve specified properties of all products in a given state - {GetProductsPropertiesByDraftStateRequest}

Retrieve specified properties of all products in a given state

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsPropertiesByDraftStateRequestScopeIdbyDraftStateDraftStateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var draftState = draftState_example;  // string | The draft state used to filter the products
            var cultureName = cultureName_example;  // string | The culture in which the data will be returned (optional) 
            var propertiesNames = new List<string>(); // List<string> | the list of properties to return (optional) 
            var startingIndex = 56;  // int? | the starting index in the results to start getting the products (used for paging purpose) (optional) 
            var maximumItems = 56;  // int? | The maximum number of results to return. Default value : 10 (optional) 
            var sortBy = sortBy_example;  // string | The name of the property to be sorted (optional) 
            var sortDirection = sortDirection_example;  // string | The sorting direction (optional) 

            try
            {
                // Retrieve specified properties of all products in a given state - {GetProductsPropertiesByDraftStateRequest}
                GetProductsPropertiesResult result = apiInstance.GetProductsPropertiesByDraftStateRequestScopeIdbyDraftStateDraftStateGet(accept, scopeId, draftState, cultureName, propertiesNames, startingIndex, maximumItems, sortBy, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsPropertiesByDraftStateRequestScopeIdbyDraftStateDraftStateGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **draftState** | **string**| The draft state used to filter the products | 
 **cultureName** | **string**| The culture in which the data will be returned | [optional] 
 **propertiesNames** | [**List&lt;string&gt;**](string.md)| the list of properties to return | [optional] 
 **startingIndex** | **int?**| the starting index in the results to start getting the products (used for paging purpose) | [optional] 
 **maximumItems** | **int?**| The maximum number of results to return. Default value : 10 | [optional] 
 **sortBy** | **string**| The name of the property to be sorted | [optional] 
 **sortDirection** | **string**| The sorting direction | [optional] 

### Return type

[**GetProductsPropertiesResult**](GetProductsPropertiesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductspropertiesflagasnewrequestscopeidflagasnewget"></a>
# **GetProductsPropertiesFlagAsNewRequestScopeIdflagAsNewGet**
> GetProductsPropertiesResult GetProductsPropertiesFlagAsNewRequestScopeIdflagAsNewGet (string accept, string scopeId, string cultureName = null, List<string> propertiesNames = null, int? startingIndex = null, int? maximumItems = null, string sortBy = null, string sortDirection = null)

Retrieve specified properties of all products flagged as new - {GetProductsPropertiesFlagAsNewRequest}

Retrieve specified properties of all products flagged as new

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsPropertiesFlagAsNewRequestScopeIdflagAsNewGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture in which the data will be returned (optional) 
            var propertiesNames = new List<string>(); // List<string> | the list of properties to return (optional) 
            var startingIndex = 56;  // int? | the starting index in the results to start getting the products (used for paging purpose) (optional) 
            var maximumItems = 56;  // int? | The maximum number of results to return. Default value : 10 (optional) 
            var sortBy = sortBy_example;  // string | The name of the property to be sorted (optional) 
            var sortDirection = sortDirection_example;  // string | The sorting direction (optional) 

            try
            {
                // Retrieve specified properties of all products flagged as new - {GetProductsPropertiesFlagAsNewRequest}
                GetProductsPropertiesResult result = apiInstance.GetProductsPropertiesFlagAsNewRequestScopeIdflagAsNewGet(accept, scopeId, cultureName, propertiesNames, startingIndex, maximumItems, sortBy, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsPropertiesFlagAsNewRequestScopeIdflagAsNewGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **cultureName** | **string**| The culture in which the data will be returned | [optional] 
 **propertiesNames** | [**List&lt;string&gt;**](string.md)| the list of properties to return | [optional] 
 **startingIndex** | **int?**| the starting index in the results to start getting the products (used for paging purpose) | [optional] 
 **maximumItems** | **int?**| The maximum number of results to return. Default value : 10 | [optional] 
 **sortBy** | **string**| The name of the property to be sorted | [optional] 
 **sortDirection** | **string**| The sorting direction | [optional] 

### Return type

[**GetProductsPropertiesResult**](GetProductsPropertiesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductspropertieswithnotificationrequestscopeidwithnotificationget"></a>
# **GetProductsPropertiesWithNotificationRequestScopeIdwithNotificationGet**
> GetProductsPropertiesResult GetProductsPropertiesWithNotificationRequestScopeIdwithNotificationGet (string accept, string scopeId, string cultureName = null, List<string> propertiesNames = null, int? startingIndex = null, int? maximumItems = null, string sortBy = null, string sortDirection = null)

Retrieve properties of all product with notification - {GetProductsPropertiesWithNotificationRequest}

Retrieve properties of all products with notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsPropertiesWithNotificationRequestScopeIdwithNotificationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var cultureName = cultureName_example;  // string | The culture in which the data will be returned (optional) 
            var propertiesNames = new List<string>(); // List<string> | the list of properties to return (optional) 
            var startingIndex = 56;  // int? | the starting index in the results to start getting the products (used for paging purpose) (optional) 
            var maximumItems = 56;  // int? | The maximum number of results to return. Default value : 10 (optional) 
            var sortBy = sortBy_example;  // string | The name of the property to be sorted (optional) 
            var sortDirection = sortDirection_example;  // string | The sorting direction (optional) 

            try
            {
                // Retrieve properties of all product with notification - {GetProductsPropertiesWithNotificationRequest}
                GetProductsPropertiesResult result = apiInstance.GetProductsPropertiesWithNotificationRequestScopeIdwithNotificationGet(accept, scopeId, cultureName, propertiesNames, startingIndex, maximumItems, sortBy, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsPropertiesWithNotificationRequestScopeIdwithNotificationGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **cultureName** | **string**| The culture in which the data will be returned | [optional] 
 **propertiesNames** | [**List&lt;string&gt;**](string.md)| the list of properties to return | [optional] 
 **startingIndex** | **int?**| the starting index in the results to start getting the products (used for paging purpose) | [optional] 
 **maximumItems** | **int?**| The maximum number of results to return. Default value : 10 | [optional] 
 **sortBy** | **string**| The name of the property to be sorted | [optional] 
 **sortDirection** | **string**| The sorting direction | [optional] 

### Return type

[**GetProductsPropertiesResult**](GetProductsPropertiesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsstatisticsrequestscopeidstatisticsget"></a>
# **GetProductsStatisticsRequestScopeIdstatisticsGet**
> GetProductsStatisticsResult GetProductsStatisticsRequestScopeIdstatisticsGet (string accept, string scopeId)

Gets statistics for products - {GetProductsStatisticsRequest}

Gets statistics for products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetProductsStatisticsRequestScopeIdstatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope

            try
            {
                // Gets statistics for products - {GetProductsStatisticsRequest}
                GetProductsStatisticsResult result = apiInstance.GetProductsStatisticsRequestScopeIdstatisticsGet(accept, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductsStatisticsRequestScopeIdstatisticsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 

### Return type

[**GetProductsStatisticsResult**](GetProductsStatisticsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | model for products&#39; statistics info |  -  |
| **404** | Requested catalog id not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquicklinkscountdetailsrequestquicklinksget"></a>
# **GetQuickLinksCountDetailsRequestquicklinksGet**
> List&lt;QuickLinkCountDetails&gt; GetQuickLinksCountDetailsRequestquicklinksGet (string accept, string catalogName, string cultureName)

Retrieve the products quick links count - {GetQuickLinksCountDetailsRequest}

Represents items of quick links count related to products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetQuickLinksCountDetailsRequestquicklinksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var catalogName = catalogName_example;  // string | The catalog name to be used for quick links count
            var cultureName = cultureName_example;  // string | The culture name that should be used to retrieve data

            try
            {
                // Retrieve the products quick links count - {GetQuickLinksCountDetailsRequest}
                List<QuickLinkCountDetails> result = apiInstance.GetQuickLinksCountDetailsRequestquicklinksGet(accept, catalogName, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetQuickLinksCountDetailsRequestquicklinksGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **catalogName** | **string**| The catalog name to be used for quick links count | 
 **cultureName** | **string**| The culture name that should be used to retrieve data | 

### Return type

[**List&lt;QuickLinkCountDetails&gt;**](QuickLinkCountDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvariantsbyproductrequestscopeidproductidvariantsget"></a>
# **GetVariantsByProductRequestScopeIdProductIdvariantsGet**
> List&lt;Variant&gt; GetVariantsByProductRequestScopeIdProductIdvariantsGet (string accept, string scopeId, string productId, bool? includePriceLists = null, string cultureName = null)

Retrieve all the product's variants - {GetVariantsByProductRequest}

Retrieve all the product's variants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetVariantsByProductRequestScopeIdProductIdvariantsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope associated to the requested product
            var productId = productId_example;  // string | the business id for the product to retrieve
            var includePriceLists = true;  // bool? | whether or not to include the price lists of the product. (optional) 
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve all the product's variants - {GetVariantsByProductRequest}
                List<Variant> result = apiInstance.GetVariantsByProductRequestScopeIdProductIdvariantsGet(accept, scopeId, productId, includePriceLists, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetVariantsByProductRequestScopeIdProductIdvariantsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The scope associated to the requested product | 
 **productId** | **string**| the business id for the product to retrieve | 
 **includePriceLists** | **bool?**| whether or not to include the price lists of the product. | [optional] 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

[**List&lt;Variant&gt;**](Variant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productexistsrequestexistsscopeidproductidget"></a>
# **ProductExistsRequestexistsScopeIdProductIdGet**
> ProductExistsResponse ProductExistsRequestexistsScopeIdProductIdGet (string accept, string scopeId, string productId)

Checks whether the product exists in the specified scope - {ProductExistsRequest}

Checks whether the product exists in the specified scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ProductExistsRequestexistsScopeIdProductIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product.

            try
            {
                // Checks whether the product exists in the specified scope - {ProductExistsRequest}
                ProductExistsResponse result = apiInstance.ProductExistsRequestexistsScopeIdProductIdGet(accept, scopeId, productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductExistsRequestexistsScopeIdProductIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product. | 

### Return type

[**ProductExistsResponse**](ProductExistsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repairproductinheritancerequestscopeidproductidrepairinheritancecreate"></a>
# **RepairProductInheritanceRequestScopeIdProductIdrepairInheritanceCreate**
> void RepairProductInheritanceRequestScopeIdProductIdrepairInheritanceCreate (string accept, string scopeId, string productId, Object body = null)

Repair Broken Inheritence for the product - {RepairProductInheritanceRequest}

Repair Broken Inheritence From Global:  a. adds the properties that exist in global but not in sales  b. revert the properties that has been changed compare to global   c. keep the properties that have been added in sales but do not exist in global  d. revert variants to the global version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RepairProductInheritanceRequestScopeIdProductIdrepairInheritanceCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | Gets or sets the id of the product for which we want to repair the inheritence
            var body = ;  // Object |  (optional) 

            try
            {
                // Repair Broken Inheritence for the product - {RepairProductInheritanceRequest}
                apiInstance.RepairProductInheritanceRequestScopeIdProductIdrepairInheritanceCreate(accept, scopeId, productId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.RepairProductInheritanceRequestScopeIdProductIdrepairInheritanceCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| Gets or sets the id of the product for which we want to repair the inheritence | 
 **body** | **Object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revertproductchangesrequestscopeidrevertpost"></a>
# **RevertProductChangesRequestScopeIdrevertPost**
> void RevertProductChangesRequestScopeIdrevertPost (string accept, string scopeId, RevertProductChangesRequest body = null)

Reverts not published product changes by replacing working copies of products with their published counterparts - {RevertProductChangesRequest}

Reverts not published product changes by replacing working copies of products with their published counterparts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RevertProductChangesRequestScopeIdrevertPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new RevertProductChangesRequest(); // RevertProductChangesRequest |  (optional) 

            try
            {
                // Reverts not published product changes by replacing working copies of products with their published counterparts - {RevertProductChangesRequest}
                apiInstance.RevertProductChangesRequestScopeIdrevertPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.RevertProductChangesRequestScopeIdrevertPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**RevertProductChangesRequest**](RevertProductChangesRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncproductrequestsyncscopeidproductidcreate"></a>
# **SyncProductRequestsyncScopeIdProductIdCreate**
> void SyncProductRequestsyncScopeIdProductIdCreate (string accept, string scopeId, string productId, SyncProductRequest body = null)

Synchronizes a product - {SyncProductRequest}

Synchronizes a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SyncProductRequestsyncScopeIdProductIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | Gets or sets the id of the product for which we want to update
            var body = new SyncProductRequest(); // SyncProductRequest |  (optional) 

            try
            {
                // Synchronizes a product - {SyncProductRequest}
                apiInstance.SyncProductRequestsyncScopeIdProductIdCreate(accept, scopeId, productId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.SyncProductRequestsyncScopeIdProductIdCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| Gets or sets the id of the product for which we want to update | 
 **body** | [**SyncProductRequest**](SyncProductRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemediaresizedinstancesrequestscopeidproductidmediamediaidresizedcreate"></a>
# **UpdateMediaResizedInstancesRequestScopeIdProductIdmediaMediaIdresizedCreate**
> ProductMedia UpdateMediaResizedInstancesRequestScopeIdProductIdmediaMediaIdresizedCreate (string accept, string scopeId, string productId, string mediaId, UpdateMediaResizedInstancesRequest body = null)

Update media resized instances - {UpdateMediaResizedInstancesRequest}

Update media resized instances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateMediaResizedInstancesRequestScopeIdProductIdmediaMediaIdresizedCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | the business id for the product to retrieve
            var mediaId = mediaId_example;  // string | a media id
            var body = new UpdateMediaResizedInstancesRequest(); // UpdateMediaResizedInstancesRequest |  (optional) 

            try
            {
                // Update media resized instances - {UpdateMediaResizedInstancesRequest}
                ProductMedia result = apiInstance.UpdateMediaResizedInstancesRequestScopeIdProductIdmediaMediaIdresizedCreate(accept, scopeId, productId, mediaId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateMediaResizedInstancesRequestScopeIdProductIdmediaMediaIdresizedCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| the business id for the product to retrieve | 
 **mediaId** | **string**| a media id | 
 **body** | [**UpdateMediaResizedInstancesRequest**](UpdateMediaResizedInstancesRequest.md)|  | [optional] 

### Return type

[**ProductMedia**](ProductMedia.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | No product or media found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemediasettingsrequestmediasettingscreate"></a>
# **UpdateMediaSettingsRequestmediasettingsCreate**
> MediaSettings UpdateMediaSettingsRequestmediasettingsCreate (string accept, UpdateMediaSettingsRequest body = null)

Update the settings used in product media - {UpdateMediaSettingsRequest}

Update the settings used in product media

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateMediaSettingsRequestmediasettingsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new UpdateMediaSettingsRequest(); // UpdateMediaSettingsRequest |  (optional) 

            try
            {
                // Update the settings used in product media - {UpdateMediaSettingsRequest}
                MediaSettings result = apiInstance.UpdateMediaSettingsRequestmediasettingsCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateMediaSettingsRequestmediasettingsCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **body** | [**UpdateMediaSettingsRequest**](UpdateMediaSettingsRequest.md)|  | [optional] 

### Return type

[**MediaSettings**](MediaSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepricelistentryrequestscopeidproductidpricelistentriescreate"></a>
# **UpdatePriceListEntryRequestScopeIdProductIdpriceListEntriesCreate**
> PriceListEntry UpdatePriceListEntryRequestScopeIdProductIdpriceListEntriesCreate (string accept, string scopeId, string productId, UpdatePriceListEntryRequest body = null)

Updates a price List Entry - {UpdatePriceListEntryRequest}

Updates a price List Entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePriceListEntryRequestScopeIdProductIdpriceListEntriesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product for which we want to update a price list entry
            var body = new UpdatePriceListEntryRequest(); // UpdatePriceListEntryRequest |  (optional) 

            try
            {
                // Updates a price List Entry - {UpdatePriceListEntryRequest}
                PriceListEntry result = apiInstance.UpdatePriceListEntryRequestScopeIdProductIdpriceListEntriesCreate(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdatePriceListEntryRequestScopeIdProductIdpriceListEntriesCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product for which we want to update a price list entry | 
 **body** | [**UpdatePriceListEntryRequest**](UpdatePriceListEntryRequest.md)|  | [optional] 

### Return type

[**PriceListEntry**](PriceListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepricelistrequestscopeidpricelistspricelistidcreate"></a>
# **UpdatePriceListRequestScopeIdpriceListsPriceListIdCreate**
> PriceList UpdatePriceListRequestScopeIdpriceListsPriceListIdCreate (string accept, string scopeId, string priceListId, UpdatePriceListRequest body = null)

Updates a price list in the specified scope - {UpdatePriceListRequest}

Updates a price list in the specified scope. Its priority sequence is automatically calculated according to the specified price list with the next higher priority sequence.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePriceListRequestScopeIdpriceListsPriceListIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var priceListId = priceListId_example;  // string | The identifier of the PriceList.
            var body = new UpdatePriceListRequest(); // UpdatePriceListRequest |  (optional) 

            try
            {
                // Updates a price list in the specified scope - {UpdatePriceListRequest}
                PriceList result = apiInstance.UpdatePriceListRequestScopeIdpriceListsPriceListIdCreate(accept, scopeId, priceListId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdatePriceListRequestScopeIdpriceListsPriceListIdCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **priceListId** | **string**| The identifier of the PriceList. | 
 **body** | [**UpdatePriceListRequest**](UpdatePriceListRequest.md)|  | [optional] 

### Return type

[**PriceList**](PriceList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductdraftrequestscopeiddraftproductidpost"></a>
# **UpdateProductDraftRequestScopeIddraftProductIdPost**
> ProductDraft UpdateProductDraftRequestScopeIddraftProductIdPost (string accept, string scopeId, string productId, UpdateProductDraftRequest body = null)

Update a product draft - {UpdateProductDraftRequest}

Update a product draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductDraftRequestScopeIddraftProductIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | Gets or sets the id of the product for which we want to update the draft
            var body = new UpdateProductDraftRequest(); // UpdateProductDraftRequest |  (optional) 

            try
            {
                // Update a product draft - {UpdateProductDraftRequest}
                ProductDraft result = apiInstance.UpdateProductDraftRequestScopeIddraftProductIdPost(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductDraftRequestScopeIddraftProductIdPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| Gets or sets the id of the product for which we want to update the draft | 
 **body** | [**UpdateProductDraftRequest**](UpdateProductDraftRequest.md)|  | [optional] 

### Return type

[**ProductDraft**](ProductDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductpublicationstatusrequestscopeidpublicationstatuspost"></a>
# **UpdateProductPublicationStatusRequestScopeIdpublicationStatusPost**
> void UpdateProductPublicationStatusRequestScopeIdpublicationStatusPost (string accept, string scopeId, UpdateProductPublicationStatusRequest body = null)

Updates publication status for a list of products - {UpdateProductPublicationStatusRequest}

Updates publication status for a list of products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductPublicationStatusRequestScopeIdpublicationStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new UpdateProductPublicationStatusRequest(); // UpdateProductPublicationStatusRequest |  (optional) 

            try
            {
                // Updates publication status for a list of products - {UpdateProductPublicationStatusRequest}
                apiInstance.UpdateProductPublicationStatusRequestScopeIdpublicationStatusPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductPublicationStatusRequestScopeIdpublicationStatusPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **body** | [**UpdateProductPublicationStatusRequest**](UpdateProductPublicationStatusRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductrequestscopeidproductidcreate"></a>
# **UpdateProductRequestScopeIdProductIdCreate**
> Product UpdateProductRequestScopeIdProductIdCreate (string accept, string scopeId, string productId, UpdateProductRequest body = null)

Updates a product - {UpdateProductRequest}

Updates a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductRequestScopeIdProductIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | Gets or sets the id of the product for which we want to update
            var body = new UpdateProductRequest(); // UpdateProductRequest |  (optional) 

            try
            {
                // Updates a product - {UpdateProductRequest}
                Product result = apiInstance.UpdateProductRequestScopeIdProductIdCreate(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductRequestScopeIdProductIdCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| Gets or sets the id of the product for which we want to update | 
 **body** | [**UpdateProductRequest**](UpdateProductRequest.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductsettingsrequestsettingscreate"></a>
# **UpdateProductSettingsRequestsettingsCreate**
> ProductSettings UpdateProductSettingsRequestsettingsCreate (string accept, UpdateProductSettingsRequest body = null)

Update the settings used in product module - {UpdateProductSettingsRequest}

Update the settings used in product module

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateProductSettingsRequestsettingsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new UpdateProductSettingsRequest(); // UpdateProductSettingsRequest |  (optional) 

            try
            {
                // Update the settings used in product module - {UpdateProductSettingsRequest}
                ProductSettings result = apiInstance.UpdateProductSettingsRequestsettingsCreate(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductSettingsRequestsettingsCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **body** | [**UpdateProductSettingsRequest**](UpdateProductSettingsRequest.md)|  | [optional] 

### Return type

[**ProductSettings**](ProductSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated to use this request |  -  |
| **404** | Requested settings not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevariantspricelistentryrequestscopeidproductidvariantspricespricelistidcreate"></a>
# **UpdateVariantsPriceListEntryRequestScopeIdProductIdvariantsPricesPriceListIdCreate**
> void UpdateVariantsPriceListEntryRequestScopeIdProductIdvariantsPricesPriceListIdCreate (string accept, string scopeId, string productId, string priceListId, UpdateVariantsPriceListEntryRequest body = null)

Batch update all variants price for a product for a specific pricelist - {UpdateVariantsPriceListEntryRequest}

Batch update all variants price for a product for a specific pricelist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateVariantsPriceListEntryRequestScopeIdProductIdvariantsPricesPriceListIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string | The id of the product for which we want to update the price list entries
            var priceListId = priceListId_example;  // string | The id of the the price list for which we want to update the price list entries
            var body = new UpdateVariantsPriceListEntryRequest(); // UpdateVariantsPriceListEntryRequest |  (optional) 

            try
            {
                // Batch update all variants price for a product for a specific pricelist - {UpdateVariantsPriceListEntryRequest}
                apiInstance.UpdateVariantsPriceListEntryRequestScopeIdProductIdvariantsPricesPriceListIdCreate(accept, scopeId, productId, priceListId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateVariantsPriceListEntryRequestScopeIdProductIdvariantsPricesPriceListIdCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**| The id of the product for which we want to update the price list entries | 
 **priceListId** | **string**| The id of the the price list for which we want to update the price list entries | 
 **body** | [**UpdateVariantsPriceListEntryRequest**](UpdateVariantsPriceListEntryRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmediarequestmediascopeidproductiduploadpost"></a>
# **UploadMediaRequestmediaScopeIdProductIduploadPost**
> Product UploadMediaRequestmediaScopeIdProductIduploadPost (string accept, string scopeId, string productId, UploadMediaRequest body = null)

Uploads a media file and attaches it to the product/variant - {UploadMediaRequest}

Uploads a media file Send media files via multipart/form-data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UploadMediaRequestmediaScopeIdProductIduploadPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ProductsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var productId = productId_example;  // string |  the id of the product for which we want to upload media.
            var body = new UploadMediaRequest(); // UploadMediaRequest |  (optional) 

            try
            {
                // Uploads a media file and attaches it to the product/variant - {UploadMediaRequest}
                Product result = apiInstance.UploadMediaRequestmediaScopeIdProductIduploadPost(accept, scopeId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UploadMediaRequestmediaScopeIdProductIduploadPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **scopeId** | **string**| The id of the requested scope | 
 **productId** | **string**|  the id of the product for which we want to upload media. | 
 **body** | [**UploadMediaRequest**](UploadMediaRequest.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

