# Yaksa.OrckestraCommerce.Client.Api.CampaignsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrUpdateCampaignRequestScopeIdCampaignIdfullCreate**](CampaignsApi.md#addorupdatecampaignrequestscopeidcampaignidfullcreate) | **PUT** /campaigns/{ScopeId}/{CampaignId}/full | Add or update a campaign - {AddOrUpdateCampaignRequest}
[**CancelCampaignRequestScopeIdIdcancelPost**](CampaignsApi.md#cancelcampaignrequestscopeididcancelpost) | **POST** /campaigns/{ScopeId}/{Id}/cancel | Cancel a Campaign - {CancelCampaignRequest}
[**CopyCampaignRequestScopeIdFromCampaignIdcopyPost**](CampaignsApi.md#copycampaignrequestscopeidfromcampaignidcopypost) | **POST** /campaigns/{ScopeId}/{FromCampaignId}/copy | Copy a campaign - {CopyCampaignRequest}
[**CreateCampaignRequestScopeIdPost**](CampaignsApi.md#createcampaignrequestscopeidpost) | **POST** /campaigns/{ScopeId} | Create a campaign - {CreateCampaignRequest}
[**CreatePromotionRequestScopeIdCampaignIdpromotionsPost**](CampaignsApi.md#createpromotionrequestscopeidcampaignidpromotionspost) | **POST** /campaigns/{ScopeId}/{CampaignId}/promotions | Add a promotion to an existing campaign - {CreatePromotionRequest}
[**DeletePromotionRequestScopeIdCampaignIdpromotionsPromotionIdDelete**](CampaignsApi.md#deletepromotionrequestscopeidcampaignidpromotionspromotioniddelete) | **DELETE** /campaigns/{ScopeId}/{CampaignId}/promotions/{PromotionId} | Delete the specified promotion - {DeletePromotionRequest}
[**FindCampaignsRequestScopeIdfindPost**](CampaignsApi.md#findcampaignsrequestscopeidfindpost) | **POST** /campaigns/{ScopeId}/find | Search for campaigns. - {FindCampaignsRequest}
[**GetCampaignPromotionsRequestScopeIdCampaignIdpromotionsGet**](CampaignsApi.md#getcampaignpromotionsrequestscopeidcampaignidpromotionsget) | **GET** /campaigns/{ScopeId}/{CampaignId}/promotions | Retrieve the promotions of a campaign - {GetCampaignPromotionsRequest}
[**GetCampaignRequestScopeIdCampaignIdGet**](CampaignsApi.md#getcampaignrequestscopeidcampaignidget) | **GET** /campaigns/{ScopeId}/{CampaignId} | Retrieve a campaign - {GetCampaignRequest}
[**GetCampaignsRequestScopeIdbyIdsCampaignIdsGet**](CampaignsApi.md#getcampaignsrequestscopeidbyidscampaignidsget) | **GET** /campaigns/{ScopeId}/byIds/{CampaignIds} | Retrieve a list of campaigns by ids - {GetCampaignsRequest}
[**GetLiveCampaignsRequestScopeIdgetliveGet**](CampaignsApi.md#getlivecampaignsrequestscopeidgetliveget) | **GET** /campaigns/{ScopeId}/getlive | Retrieve a list of live campaigns - {GetLiveCampaignsRequest}
[**GetPromotionRequestScopeIdCampaignIdpromotionsPromotionIdGet**](CampaignsApi.md#getpromotionrequestscopeidcampaignidpromotionspromotionidget) | **GET** /campaigns/{ScopeId}/{CampaignId}/promotions/{PromotionId} | Retrieve a promotion - {GetPromotionRequest}
[**GetPromotionSummariesRequestScopeIdCampaignIdpromotionssummariesGet**](CampaignsApi.md#getpromotionsummariesrequestscopeidcampaignidpromotionssummariesget) | **GET** /campaigns/{ScopeId}/{CampaignId}/promotions/summaries | Retrieve the summaries of all promotions of a campaign - {GetPromotionSummariesRequest}
[**PauseCampaignRequestScopeIdIdpausePost**](CampaignsApi.md#pausecampaignrequestscopeididpausepost) | **POST** /campaigns/{ScopeId}/{Id}/pause | Pause a Campaign - {PauseCampaignRequest}
[**PublishCampaignRequestScopeIdIdpublishPost**](CampaignsApi.md#publishcampaignrequestscopeididpublishpost) | **POST** /campaigns/{ScopeId}/{Id}/publish | Publish a Campaign - {PublishCampaignRequest}
[**RejectCampaignRequestScopeIdIdrejectPost**](CampaignsApi.md#rejectcampaignrequestscopeididrejectpost) | **POST** /campaigns/{ScopeId}/{Id}/reject | Reject a Campaign - {RejectCampaignRequest}
[**SubmitCampaignRequestScopeIdIdsubmitPost**](CampaignsApi.md#submitcampaignrequestscopeididsubmitpost) | **POST** /campaigns/{ScopeId}/{Id}/submit | Submit a Campaign - {SubmitCampaignRequest}
[**UpdateCampaignRequestScopeIdIdCreate**](CampaignsApi.md#updatecampaignrequestscopeididcreate) | **PUT** /campaigns/{ScopeId}/{Id} | Update a campaign - {UpdateCampaignRequest}
[**UpdateCampaignStatusRequestScopeIdIdstatusCreate**](CampaignsApi.md#updatecampaignstatusrequestscopeididstatuscreate) | **PUT** /campaigns/{ScopeId}/{Id}/status | Update the status of a campaign - {UpdateCampaignStatusRequest}
[**UpdatePromotionRequestScopeIdCampaignIdpromotionsPromotionIdCreate**](CampaignsApi.md#updatepromotionrequestscopeidcampaignidpromotionspromotionidcreate) | **PUT** /campaigns/{ScopeId}/{CampaignId}/promotions/{PromotionId} | Update an existing promotion - {UpdatePromotionRequest}


<a name="addorupdatecampaignrequestscopeidcampaignidfullcreate"></a>
# **AddOrUpdateCampaignRequestScopeIdCampaignIdfullCreate**
> Campaign AddOrUpdateCampaignRequestScopeIdCampaignIdfullCreate (string accept, string scopeId, string campaignId, AddOrUpdateCampaignRequest body = null)

Add or update a campaign - {AddOrUpdateCampaignRequest}

Add or update a campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddOrUpdateCampaignRequestScopeIdCampaignIdfullCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the campaign.
            var body = new AddOrUpdateCampaignRequest(); // AddOrUpdateCampaignRequest |  (optional) 

            try
            {
                // Add or update a campaign - {AddOrUpdateCampaignRequest}
                Campaign result = apiInstance.AddOrUpdateCampaignRequestScopeIdCampaignIdfullCreate(accept, scopeId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.AddOrUpdateCampaignRequestScopeIdCampaignIdfullCreate: " + e.Message );
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
 **campaignId** | **string**| The id of the campaign. | 
 **body** | [**AddOrUpdateCampaignRequest**](AddOrUpdateCampaignRequest.md)|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="cancelcampaignrequestscopeididcancelpost"></a>
# **CancelCampaignRequestScopeIdIdcancelPost**
> Campaign CancelCampaignRequestScopeIdIdcancelPost (string accept, string scopeId, string id, Object body = null)

Cancel a Campaign - {CancelCampaignRequest}

Cancel a Campaign. The status will be changed to Canceled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CancelCampaignRequestScopeIdIdcancelPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the campaign.
            var body = ;  // Object |  (optional) 

            try
            {
                // Cancel a Campaign - {CancelCampaignRequest}
                Campaign result = apiInstance.CancelCampaignRequestScopeIdIdcancelPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CancelCampaignRequestScopeIdIdcancelPost: " + e.Message );
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
 **id** | **string**| The id of the campaign. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="copycampaignrequestscopeidfromcampaignidcopypost"></a>
# **CopyCampaignRequestScopeIdFromCampaignIdcopyPost**
> Campaign CopyCampaignRequestScopeIdFromCampaignIdcopyPost (string accept, string scopeId, string fromCampaignId, CopyCampaignRequest body = null)

Copy a campaign - {CopyCampaignRequest}

Copy a campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CopyCampaignRequestScopeIdFromCampaignIdcopyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var fromCampaignId = fromCampaignId_example;  // string | The id of the campaign
            var body = new CopyCampaignRequest(); // CopyCampaignRequest |  (optional) 

            try
            {
                // Copy a campaign - {CopyCampaignRequest}
                Campaign result = apiInstance.CopyCampaignRequestScopeIdFromCampaignIdcopyPost(accept, scopeId, fromCampaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CopyCampaignRequestScopeIdFromCampaignIdcopyPost: " + e.Message );
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
 **fromCampaignId** | **string**| The id of the campaign | 
 **body** | [**CopyCampaignRequest**](CopyCampaignRequest.md)|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="createcampaignrequestscopeidpost"></a>
# **CreateCampaignRequestScopeIdPost**
> Campaign CreateCampaignRequestScopeIdPost (string accept, string scopeId, CreateCampaignRequest body = null)

Create a campaign - {CreateCampaignRequest}

Create a campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCampaignRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateCampaignRequest(); // CreateCampaignRequest |  (optional) 

            try
            {
                // Create a campaign - {CreateCampaignRequest}
                Campaign result = apiInstance.CreateCampaignRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateCampaignRequestScopeIdPost: " + e.Message );
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
 **body** | [**CreateCampaignRequest**](CreateCampaignRequest.md)|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="createpromotionrequestscopeidcampaignidpromotionspost"></a>
# **CreatePromotionRequestScopeIdCampaignIdpromotionsPost**
> Promotion CreatePromotionRequestScopeIdCampaignIdpromotionsPost (string accept, string scopeId, string campaignId, CreatePromotionRequest body = null)

Add a promotion to an existing campaign - {CreatePromotionRequest}

Add a promotion to an existing campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreatePromotionRequestScopeIdCampaignIdpromotionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the promotion's campaign
            var body = new CreatePromotionRequest(); // CreatePromotionRequest |  (optional) 

            try
            {
                // Add a promotion to an existing campaign - {CreatePromotionRequest}
                Promotion result = apiInstance.CreatePromotionRequestScopeIdCampaignIdpromotionsPost(accept, scopeId, campaignId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreatePromotionRequestScopeIdCampaignIdpromotionsPost: " + e.Message );
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
 **campaignId** | **string**| The id of the promotion&#39;s campaign | 
 **body** | [**CreatePromotionRequest**](CreatePromotionRequest.md)|  | [optional] 

### Return type

[**Promotion**](Promotion.md)

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

<a name="deletepromotionrequestscopeidcampaignidpromotionspromotioniddelete"></a>
# **DeletePromotionRequestScopeIdCampaignIdpromotionsPromotionIdDelete**
> void DeletePromotionRequestScopeIdCampaignIdpromotionsPromotionIdDelete (string accept, string scopeId, string campaignId, string promotionId)

Delete the specified promotion - {DeletePromotionRequest}

Delete the specified promotion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class DeletePromotionRequestScopeIdCampaignIdpromotionsPromotionIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the promotion's campaign
            var promotionId = promotionId_example;  // string | The id of the promotion to delete

            try
            {
                // Delete the specified promotion - {DeletePromotionRequest}
                apiInstance.DeletePromotionRequestScopeIdCampaignIdpromotionsPromotionIdDelete(accept, scopeId, campaignId, promotionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeletePromotionRequestScopeIdCampaignIdpromotionsPromotionIdDelete: " + e.Message );
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
 **campaignId** | **string**| The id of the promotion&#39;s campaign | 
 **promotionId** | **string**| The id of the promotion to delete | 

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

<a name="findcampaignsrequestscopeidfindpost"></a>
# **FindCampaignsRequestScopeIdfindPost**
> CampaignQueryResult FindCampaignsRequestScopeIdfindPost (string accept, string scopeId, FindCampaignsRequest body = null)

Search for campaigns. - {FindCampaignsRequest}

Search for campaigns. The search results do not return the promotions associated with the campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FindCampaignsRequestScopeIdfindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The scope to use to process the request
            var body = new FindCampaignsRequest(); // FindCampaignsRequest |  (optional) 

            try
            {
                // Search for campaigns. - {FindCampaignsRequest}
                CampaignQueryResult result = apiInstance.FindCampaignsRequestScopeIdfindPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.FindCampaignsRequestScopeIdfindPost: " + e.Message );
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
 **scopeId** | **string**| The scope to use to process the request | 
 **body** | [**FindCampaignsRequest**](FindCampaignsRequest.md)|  | [optional] 

### Return type

[**CampaignQueryResult**](CampaignQueryResult.md)

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

<a name="getcampaignpromotionsrequestscopeidcampaignidpromotionsget"></a>
# **GetCampaignPromotionsRequestScopeIdCampaignIdpromotionsGet**
> List&lt;Promotion&gt; GetCampaignPromotionsRequestScopeIdCampaignIdpromotionsGet (string accept, string scopeId, string campaignId, bool? validateTargeting = null)

Retrieve the promotions of a campaign - {GetCampaignPromotionsRequest}

Retrieve the promotions of a campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCampaignPromotionsRequestScopeIdCampaignIdpromotionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the campaign to retrieve.
            var validateTargeting = true;  // bool? | Indicates whether the targeting conditions in the promotions should be validated (only applicable if IncludePromotions is True) (optional) 

            try
            {
                // Retrieve the promotions of a campaign - {GetCampaignPromotionsRequest}
                List<Promotion> result = apiInstance.GetCampaignPromotionsRequestScopeIdCampaignIdpromotionsGet(accept, scopeId, campaignId, validateTargeting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignPromotionsRequestScopeIdCampaignIdpromotionsGet: " + e.Message );
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
 **campaignId** | **string**| The id of the campaign to retrieve. | 
 **validateTargeting** | **bool?**| Indicates whether the targeting conditions in the promotions should be validated (only applicable if IncludePromotions is True) | [optional] 

### Return type

[**List&lt;Promotion&gt;**](Promotion.md)

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
| **404** | Requested promotions not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignrequestscopeidcampaignidget"></a>
# **GetCampaignRequestScopeIdCampaignIdGet**
> Campaign GetCampaignRequestScopeIdCampaignIdGet (string accept, string scopeId, string campaignId, bool? includePromotions = null)

Retrieve a campaign - {GetCampaignRequest}

Retrieve a campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCampaignRequestScopeIdCampaignIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the campaign to retrieve.
            var includePromotions = true;  // bool? | Indicates whether the promotions be fully loaded. (optional) 

            try
            {
                // Retrieve a campaign - {GetCampaignRequest}
                Campaign result = apiInstance.GetCampaignRequestScopeIdCampaignIdGet(accept, scopeId, campaignId, includePromotions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignRequestScopeIdCampaignIdGet: " + e.Message );
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
 **campaignId** | **string**| The id of the campaign to retrieve. | 
 **includePromotions** | **bool?**| Indicates whether the promotions be fully loaded. | [optional] 

### Return type

[**Campaign**](Campaign.md)

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
| **404** | Requested campaign not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignsrequestscopeidbyidscampaignidsget"></a>
# **GetCampaignsRequestScopeIdbyIdsCampaignIdsGet**
> List&lt;Campaign&gt; GetCampaignsRequestScopeIdbyIdsCampaignIdsGet (string accept, string scopeId, List<string> campaignIds)

Retrieve a list of campaigns by ids - {GetCampaignsRequest}

Retrieve a list of campaigns by ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCampaignsRequestScopeIdbyIdsCampaignIdsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignIds = new List<string>(); // List<string> | Gets or sets the ids of the campaigns to retrieve.

            try
            {
                // Retrieve a list of campaigns by ids - {GetCampaignsRequest}
                List<Campaign> result = apiInstance.GetCampaignsRequestScopeIdbyIdsCampaignIdsGet(accept, scopeId, campaignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignsRequestScopeIdbyIdsCampaignIdsGet: " + e.Message );
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
 **campaignIds** | [**List&lt;string&gt;**](string.md)| Gets or sets the ids of the campaigns to retrieve. | 

### Return type

[**List&lt;Campaign&gt;**](Campaign.md)

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
| **404** | Requested campaigns not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlivecampaignsrequestscopeidgetliveget"></a>
# **GetLiveCampaignsRequestScopeIdgetliveGet**
> List&lt;Campaign&gt; GetLiveCampaignsRequestScopeIdgetliveGet (string accept, string scopeId, DateTime? effectiveDateTime = null, bool? includePromotions = null)

Retrieve a list of live campaigns - {GetLiveCampaignsRequest}

Retrieve a list of live campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetLiveCampaignsRequestScopeIdgetliveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var effectiveDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The date time at which the campaign must be effective. (optional) 
            var includePromotions = true;  // bool? | Indicates whether to include promotions of retrieved campaigns. (optional) 

            try
            {
                // Retrieve a list of live campaigns - {GetLiveCampaignsRequest}
                List<Campaign> result = apiInstance.GetLiveCampaignsRequestScopeIdgetliveGet(accept, scopeId, effectiveDateTime, includePromotions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetLiveCampaignsRequestScopeIdgetliveGet: " + e.Message );
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
 **effectiveDateTime** | **DateTime?**| The date time at which the campaign must be effective. | [optional] 
 **includePromotions** | **bool?**| Indicates whether to include promotions of retrieved campaigns. | [optional] 

### Return type

[**List&lt;Campaign&gt;**](Campaign.md)

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

<a name="getpromotionrequestscopeidcampaignidpromotionspromotionidget"></a>
# **GetPromotionRequestScopeIdCampaignIdpromotionsPromotionIdGet**
> Promotion GetPromotionRequestScopeIdCampaignIdpromotionsPromotionIdGet (string accept, string scopeId, string campaignId, string promotionId, bool? validateTargeting = null)

Retrieve a promotion - {GetPromotionRequest}

Retrieve a promotion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPromotionRequestScopeIdCampaignIdpromotionsPromotionIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the promotion's campaign
            var promotionId = promotionId_example;  // string | The id of the promotion to retrieve.
            var validateTargeting = true;  // bool? | Indicates whether the targeting conditions in the promotion should be validated (optional) 

            try
            {
                // Retrieve a promotion - {GetPromotionRequest}
                Promotion result = apiInstance.GetPromotionRequestScopeIdCampaignIdpromotionsPromotionIdGet(accept, scopeId, campaignId, promotionId, validateTargeting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetPromotionRequestScopeIdCampaignIdpromotionsPromotionIdGet: " + e.Message );
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
 **campaignId** | **string**| The id of the promotion&#39;s campaign | 
 **promotionId** | **string**| The id of the promotion to retrieve. | 
 **validateTargeting** | **bool?**| Indicates whether the targeting conditions in the promotion should be validated | [optional] 

### Return type

[**Promotion**](Promotion.md)

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
| **404** | Requested promotion not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpromotionsummariesrequestscopeidcampaignidpromotionssummariesget"></a>
# **GetPromotionSummariesRequestScopeIdCampaignIdpromotionssummariesGet**
> PromotionSummaries GetPromotionSummariesRequestScopeIdCampaignIdpromotionssummariesGet (string accept, string scopeId, string campaignId)

Retrieve the summaries of all promotions of a campaign - {GetPromotionSummariesRequest}

Retrieve the summaries of all promotions of a campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetPromotionSummariesRequestScopeIdCampaignIdpromotionssummariesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the campaign

            try
            {
                // Retrieve the summaries of all promotions of a campaign - {GetPromotionSummariesRequest}
                PromotionSummaries result = apiInstance.GetPromotionSummariesRequestScopeIdCampaignIdpromotionssummariesGet(accept, scopeId, campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetPromotionSummariesRequestScopeIdCampaignIdpromotionssummariesGet: " + e.Message );
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
 **campaignId** | **string**| The id of the campaign | 

### Return type

[**PromotionSummaries**](PromotionSummaries.md)

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
| **404** | Requested campaign not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pausecampaignrequestscopeididpausepost"></a>
# **PauseCampaignRequestScopeIdIdpausePost**
> Campaign PauseCampaignRequestScopeIdIdpausePost (string accept, string scopeId, string id, Object body = null)

Pause a Campaign - {PauseCampaignRequest}

Pause a Campaign. The status will be changed to Paused.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class PauseCampaignRequestScopeIdIdpausePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the campaign.
            var body = ;  // Object |  (optional) 

            try
            {
                // Pause a Campaign - {PauseCampaignRequest}
                Campaign result = apiInstance.PauseCampaignRequestScopeIdIdpausePost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.PauseCampaignRequestScopeIdIdpausePost: " + e.Message );
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
 **id** | **string**| The id of the campaign. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="publishcampaignrequestscopeididpublishpost"></a>
# **PublishCampaignRequestScopeIdIdpublishPost**
> Campaign PublishCampaignRequestScopeIdIdpublishPost (string accept, string scopeId, string id, Object body = null)

Publish a Campaign - {PublishCampaignRequest}

Publish a Campaign. The status will be changed to Ready or Live, depending on its processing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class PublishCampaignRequestScopeIdIdpublishPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the campaign.
            var body = ;  // Object |  (optional) 

            try
            {
                // Publish a Campaign - {PublishCampaignRequest}
                Campaign result = apiInstance.PublishCampaignRequestScopeIdIdpublishPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.PublishCampaignRequestScopeIdIdpublishPost: " + e.Message );
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
 **id** | **string**| The id of the campaign. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="rejectcampaignrequestscopeididrejectpost"></a>
# **RejectCampaignRequestScopeIdIdrejectPost**
> Campaign RejectCampaignRequestScopeIdIdrejectPost (string accept, string scopeId, string id, Object body = null)

Reject a Campaign - {RejectCampaignRequest}

Reject a Campaign. The status will be changed to Rejected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class RejectCampaignRequestScopeIdIdrejectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the campaign.
            var body = ;  // Object |  (optional) 

            try
            {
                // Reject a Campaign - {RejectCampaignRequest}
                Campaign result = apiInstance.RejectCampaignRequestScopeIdIdrejectPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.RejectCampaignRequestScopeIdIdrejectPost: " + e.Message );
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
 **id** | **string**| The id of the campaign. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="submitcampaignrequestscopeididsubmitpost"></a>
# **SubmitCampaignRequestScopeIdIdsubmitPost**
> Campaign SubmitCampaignRequestScopeIdIdsubmitPost (string accept, string scopeId, string id, Object body = null)

Submit a Campaign - {SubmitCampaignRequest}

Submit a Campaign. The status will be changed to PendingApproval.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SubmitCampaignRequestScopeIdIdsubmitPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the campaign.
            var body = ;  // Object |  (optional) 

            try
            {
                // Submit a Campaign - {SubmitCampaignRequest}
                Campaign result = apiInstance.SubmitCampaignRequestScopeIdIdsubmitPost(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.SubmitCampaignRequestScopeIdIdsubmitPost: " + e.Message );
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
 **id** | **string**| The id of the campaign. | 
 **body** | **Object**|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="updatecampaignrequestscopeididcreate"></a>
# **UpdateCampaignRequestScopeIdIdCreate**
> Campaign UpdateCampaignRequestScopeIdIdCreate (string accept, string scopeId, string id, UpdateCampaignRequest body = null)

Update a campaign - {UpdateCampaignRequest}

Update a campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCampaignRequestScopeIdIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the campaign.
            var body = new UpdateCampaignRequest(); // UpdateCampaignRequest |  (optional) 

            try
            {
                // Update a campaign - {UpdateCampaignRequest}
                Campaign result = apiInstance.UpdateCampaignRequestScopeIdIdCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateCampaignRequestScopeIdIdCreate: " + e.Message );
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
 **id** | **string**| The id of the campaign. | 
 **body** | [**UpdateCampaignRequest**](UpdateCampaignRequest.md)|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="updatecampaignstatusrequestscopeididstatuscreate"></a>
# **UpdateCampaignStatusRequestScopeIdIdstatusCreate**
> Campaign UpdateCampaignStatusRequestScopeIdIdstatusCreate (string accept, string scopeId, string id, UpdateCampaignStatusRequest body = null)

Update the status of a campaign - {UpdateCampaignStatusRequest}

Update the status of a campaign. The possible values are Ready, Paused, PendingApproval, Rejected, Cancelled. Live and Obsolete are computed values, so it is useless to use those statuses, use Ready instead. The status is updated without checking the campaign workflow (for example the campaign does not have to be paused before requesting its cancellation).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCampaignStatusRequestScopeIdIdstatusCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var id = id_example;  // string | The id of the campaign.
            var body = new UpdateCampaignStatusRequest(); // UpdateCampaignStatusRequest |  (optional) 

            try
            {
                // Update the status of a campaign - {UpdateCampaignStatusRequest}
                Campaign result = apiInstance.UpdateCampaignStatusRequestScopeIdIdstatusCreate(accept, scopeId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateCampaignStatusRequestScopeIdIdstatusCreate: " + e.Message );
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
 **id** | **string**| The id of the campaign. | 
 **body** | [**UpdateCampaignStatusRequest**](UpdateCampaignStatusRequest.md)|  | [optional] 

### Return type

[**Campaign**](Campaign.md)

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

<a name="updatepromotionrequestscopeidcampaignidpromotionspromotionidcreate"></a>
# **UpdatePromotionRequestScopeIdCampaignIdpromotionsPromotionIdCreate**
> Promotion UpdatePromotionRequestScopeIdCampaignIdpromotionsPromotionIdCreate (string accept, string scopeId, string campaignId, string promotionId, UpdatePromotionRequest body = null)

Update an existing promotion - {UpdatePromotionRequest}

Update an existing promotion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdatePromotionRequestScopeIdCampaignIdpromotionsPromotionIdCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CampaignsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var campaignId = campaignId_example;  // string | The id of the promotion's campaign
            var promotionId = promotionId_example;  // string | The id of the promotion to be updated
            var body = new UpdatePromotionRequest(); // UpdatePromotionRequest |  (optional) 

            try
            {
                // Update an existing promotion - {UpdatePromotionRequest}
                Promotion result = apiInstance.UpdatePromotionRequestScopeIdCampaignIdpromotionsPromotionIdCreate(accept, scopeId, campaignId, promotionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdatePromotionRequestScopeIdCampaignIdpromotionsPromotionIdCreate: " + e.Message );
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
 **campaignId** | **string**| The id of the promotion&#39;s campaign | 
 **promotionId** | **string**| The id of the promotion to be updated | 
 **body** | [**UpdatePromotionRequest**](UpdatePromotionRequest.md)|  | [optional] 

### Return type

[**Promotion**](Promotion.md)

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

