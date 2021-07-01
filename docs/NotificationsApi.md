# Yaksa.OrckestraCommerce.Client.Api.NotificationsApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomerCreatedNotificationRequestScopeIdcustomerCreatedPost**](NotificationsApi.md#customercreatednotificationrequestscopeidcustomercreatedpost) | **POST** /notifications/{ScopeId}/customerCreated | Sends a notification to a customer using the CustomerCreated template - {CustomerCreatedNotificationRequest}
[**CustomerInvitationNotificationRequestScopeIdcustomerInvitationPost**](NotificationsApi.md#customerinvitationnotificationrequestscopeidcustomerinvitationpost) | **POST** /notifications/{ScopeId}/customerInvitation | Sends a notification to an Eboutique customer using the CustomerInvitation template - {CustomerInvitationNotificationRequest}
[**CustomerPasswordChangedNotificationRequestScopeIdcustomerPasswordChangedPost**](NotificationsApi.md#customerpasswordchangednotificationrequestscopeidcustomerpasswordchangedpost) | **POST** /notifications/{ScopeId}/customerPasswordChanged | Sends a notification to a customer using the CustomerPasswordChanged template - {CustomerPasswordChangedNotificationRequest}
[**CustomerPasswordResetNotificationRequestScopeIdcustomerPasswordResetRequestedPost**](NotificationsApi.md#customerpasswordresetnotificationrequestscopeidcustomerpasswordresetrequestedpost) | **POST** /notifications/{ScopeId}/customerPasswordResetRequested | Sends a notification to a customer using the CustomerPasswordResetRequested template - {CustomerPasswordResetNotificationRequest}


<a name="customercreatednotificationrequestscopeidcustomercreatedpost"></a>
# **CustomerCreatedNotificationRequestScopeIdcustomerCreatedPost**
> void CustomerCreatedNotificationRequestScopeIdcustomerCreatedPost (string accept, string scopeId, CustomerCreatedNotificationRequest body = null)

Sends a notification to a customer using the CustomerCreated template - {CustomerCreatedNotificationRequest}

Sends a notification to a customer using the CustomerCreated template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CustomerCreatedNotificationRequestScopeIdcustomerCreatedPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new NotificationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CustomerCreatedNotificationRequest(); // CustomerCreatedNotificationRequest |  (optional) 

            try
            {
                // Sends a notification to a customer using the CustomerCreated template - {CustomerCreatedNotificationRequest}
                apiInstance.CustomerCreatedNotificationRequestScopeIdcustomerCreatedPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CustomerCreatedNotificationRequestScopeIdcustomerCreatedPost: " + e.Message );
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
 **body** | [**CustomerCreatedNotificationRequest**](CustomerCreatedNotificationRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerinvitationnotificationrequestscopeidcustomerinvitationpost"></a>
# **CustomerInvitationNotificationRequestScopeIdcustomerInvitationPost**
> void CustomerInvitationNotificationRequestScopeIdcustomerInvitationPost (string accept, string scopeId, CustomerInvitationNotificationRequest body = null)

Sends a notification to an Eboutique customer using the CustomerInvitation template - {CustomerInvitationNotificationRequest}

Sends a notification to an Eboutique customer using the CustomerInvitation template. Please specifiy a dependant scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CustomerInvitationNotificationRequestScopeIdcustomerInvitationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new NotificationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CustomerInvitationNotificationRequest(); // CustomerInvitationNotificationRequest |  (optional) 

            try
            {
                // Sends a notification to an Eboutique customer using the CustomerInvitation template - {CustomerInvitationNotificationRequest}
                apiInstance.CustomerInvitationNotificationRequestScopeIdcustomerInvitationPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CustomerInvitationNotificationRequestScopeIdcustomerInvitationPost: " + e.Message );
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
 **body** | [**CustomerInvitationNotificationRequest**](CustomerInvitationNotificationRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerpasswordchangednotificationrequestscopeidcustomerpasswordchangedpost"></a>
# **CustomerPasswordChangedNotificationRequestScopeIdcustomerPasswordChangedPost**
> void CustomerPasswordChangedNotificationRequestScopeIdcustomerPasswordChangedPost (string accept, string scopeId, CustomerPasswordChangedNotificationRequest body = null)

Sends a notification to a customer using the CustomerPasswordChanged template - {CustomerPasswordChangedNotificationRequest}

Sends a notification to a customer using the CustomerPasswordChanged template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CustomerPasswordChangedNotificationRequestScopeIdcustomerPasswordChangedPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new NotificationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CustomerPasswordChangedNotificationRequest(); // CustomerPasswordChangedNotificationRequest |  (optional) 

            try
            {
                // Sends a notification to a customer using the CustomerPasswordChanged template - {CustomerPasswordChangedNotificationRequest}
                apiInstance.CustomerPasswordChangedNotificationRequestScopeIdcustomerPasswordChangedPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CustomerPasswordChangedNotificationRequestScopeIdcustomerPasswordChangedPost: " + e.Message );
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
 **body** | [**CustomerPasswordChangedNotificationRequest**](CustomerPasswordChangedNotificationRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerpasswordresetnotificationrequestscopeidcustomerpasswordresetrequestedpost"></a>
# **CustomerPasswordResetNotificationRequestScopeIdcustomerPasswordResetRequestedPost**
> void CustomerPasswordResetNotificationRequestScopeIdcustomerPasswordResetRequestedPost (string accept, string scopeId, CustomerPasswordResetNotificationRequest body = null)

Sends a notification to a customer using the CustomerPasswordResetRequested template - {CustomerPasswordResetNotificationRequest}

Sends a notification to a customer using the CustomerPasswordResetRequested template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CustomerPasswordResetNotificationRequestScopeIdcustomerPasswordResetRequestedPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new NotificationsApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CustomerPasswordResetNotificationRequest(); // CustomerPasswordResetNotificationRequest |  (optional) 

            try
            {
                // Sends a notification to a customer using the CustomerPasswordResetRequested template - {CustomerPasswordResetNotificationRequest}
                apiInstance.CustomerPasswordResetNotificationRequestScopeIdcustomerPasswordResetRequestedPost(accept, scopeId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CustomerPasswordResetNotificationRequestScopeIdcustomerPasswordResetRequestedPost: " + e.Message );
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
 **body** | [**CustomerPasswordResetNotificationRequest**](CustomerPasswordResetNotificationRequest.md)|  | [optional] 

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
| **401** | You must be authenticated to use this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

