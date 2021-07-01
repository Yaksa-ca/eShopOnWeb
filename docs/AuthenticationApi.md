# Yaksa.OrckestraCommerce.Client.Api.AuthenticationApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomerSignInRequestcustomersigninPost**](AuthenticationApi.md#customersigninrequestcustomersigninpost) | **POST** /authentication/customer/signin | Sign in the customer with credentials - {CustomerSignInRequest}
[**FederationSignoutReplyRequestfedsignoutreplyGet**](AuthenticationApi.md#federationsignoutreplyrequestfedsignoutreplyget) | **GET** /authentication/fedsignoutreply | Returns a redirect to the provided returl url. - {FederationSignoutReplyRequest}
[**GetAuthenticationConfigurationconfigurationGet**](AuthenticationApi.md#getauthenticationconfigurationconfigurationget) | **GET** /authentication/configuration | Get the authentication configuration. - {GetAuthenticationConfiguration}
[**GetAuthenticationStatusRequeststatusGet**](AuthenticationApi.md#getauthenticationstatusrequeststatusget) | **GET** /authentication/status | Get the authentication status. - {GetAuthenticationStatusRequest}
[**GetUserPermissionsRequestprofileGet**](AuthenticationApi.md#getuserpermissionsrequestprofileget) | **GET** /authentication/profile | Get the user profile. - {GetUserPermissionsRequest}
[**SignInRequestsigninPost**](AuthenticationApi.md#signinrequestsigninpost) | **POST** /authentication/signin | Redirect the user from where he came from - {SignInRequest}
[**SignInWithCredentialsRequestsigninwithcredentialsPost**](AuthenticationApi.md#signinwithcredentialsrequestsigninwithcredentialspost) | **POST** /authentication/signinwithcredentials | Sign in the user with credentials. - {SignInWithCredentialsRequest}
[**SignInWithIssuedTokenRequestsigninwithtokenPost**](AuthenticationApi.md#signinwithissuedtokenrequestsigninwithtokenpost) | **POST** /authentication/signinwithtoken | Sign in the user with a received token. - {SignInWithIssuedTokenRequest}
[**SignInWithJWTRequestsigninwithjwtPost**](AuthenticationApi.md#signinwithjwtrequestsigninwithjwtpost) | **POST** /authentication/signinwithjwt | Sign in user with JWT token. Set authentication cookies and return the current user permissions. - {SignInWithJWTRequest}
[**SignOutRequestsignoutPost**](AuthenticationApi.md#signoutrequestsignoutpost) | **POST** /authentication/signout | Signout the user - {SignOutRequest}


<a name="customersigninrequestcustomersigninpost"></a>
# **CustomerSignInRequestcustomersigninPost**
> Token CustomerSignInRequestcustomersigninPost (string accept, CustomerSignInRequest body = null)

Sign in the customer with credentials - {CustomerSignInRequest}

Sign in the customer with credentials.  Return a token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CustomerSignInRequestcustomersigninPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new CustomerSignInRequest(); // CustomerSignInRequest |  (optional) 

            try
            {
                // Sign in the customer with credentials - {CustomerSignInRequest}
                Token result = apiInstance.CustomerSignInRequestcustomersigninPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.CustomerSignInRequestcustomersigninPost: " + e.Message );
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
 **body** | [**CustomerSignInRequest**](CustomerSignInRequest.md)|  | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Invalid credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="federationsignoutreplyrequestfedsignoutreplyget"></a>
# **FederationSignoutReplyRequestfedsignoutreplyGet**
> Object FederationSignoutReplyRequestfedsignoutreplyGet (string accept, string returnUrl = null)

Returns a redirect to the provided returl url. - {FederationSignoutReplyRequest}

Returns a redirect to the provided returl url. This service acts as a pass-thru for Azure active directory reply from signout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class FederationSignoutReplyRequestfedsignoutreplyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header
            var returnUrl = returnUrl_example;  // string | the return URL. (optional) 

            try
            {
                // Returns a redirect to the provided returl url. - {FederationSignoutReplyRequest}
                Object result = apiInstance.FederationSignoutReplyRequestfedsignoutreplyGet(accept, returnUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.FederationSignoutReplyRequestfedsignoutreplyGet: " + e.Message );
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
 **returnUrl** | **string**| the return URL. | [optional] 

### Return type

**Object**

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

<a name="getauthenticationconfigurationconfigurationget"></a>
# **GetAuthenticationConfigurationconfigurationGet**
> AuthenticationConfiguration GetAuthenticationConfigurationconfigurationGet (string accept)

Get the authentication configuration. - {GetAuthenticationConfiguration}

Get the authentication configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAuthenticationConfigurationconfigurationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Get the authentication configuration. - {GetAuthenticationConfiguration}
                AuthenticationConfiguration result = apiInstance.GetAuthenticationConfigurationconfigurationGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetAuthenticationConfigurationconfigurationGet: " + e.Message );
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

[**AuthenticationConfiguration**](AuthenticationConfiguration.md)

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

<a name="getauthenticationstatusrequeststatusget"></a>
# **GetAuthenticationStatusRequeststatusGet**
> AuthenticatedStatus GetAuthenticationStatusRequeststatusGet (string accept)

Get the authentication status. - {GetAuthenticationStatusRequest}

Get the authentication status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetAuthenticationStatusRequeststatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Get the authentication status. - {GetAuthenticationStatusRequest}
                AuthenticatedStatus result = apiInstance.GetAuthenticationStatusRequeststatusGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetAuthenticationStatusRequeststatusGet: " + e.Message );
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

[**AuthenticatedStatus**](AuthenticatedStatus.md)

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

<a name="getuserpermissionsrequestprofileget"></a>
# **GetUserPermissionsRequestprofileGet**
> UserPermissions GetUserPermissionsRequestprofileGet (string accept)

Get the user profile. - {GetUserPermissionsRequest}

Get the user profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetUserPermissionsRequestprofileGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Get the user profile. - {GetUserPermissionsRequest}
                UserPermissions result = apiInstance.GetUserPermissionsRequestprofileGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetUserPermissionsRequestprofileGet: " + e.Message );
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

[**UserPermissions**](UserPermissions.md)

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

<a name="signinrequestsigninpost"></a>
# **SignInRequestsigninPost**
> Object SignInRequestsigninPost (string accept, SignInRequest body = null)

Redirect the user from where he came from - {SignInRequest}

Redirect the user from where he came from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SignInRequestsigninPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new SignInRequest(); // SignInRequest |  (optional) 

            try
            {
                // Redirect the user from where he came from - {SignInRequest}
                Object result = apiInstance.SignInRequestsigninPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SignInRequestsigninPost: " + e.Message );
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
 **body** | [**SignInRequest**](SignInRequest.md)|  | [optional] 

### Return type

**Object**

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

<a name="signinwithcredentialsrequestsigninwithcredentialspost"></a>
# **SignInWithCredentialsRequestsigninwithcredentialsPost**
> UserPermissions SignInWithCredentialsRequestsigninwithcredentialsPost (string accept, SignInWithCredentialsRequest body = null)

Sign in the user with credentials. - {SignInWithCredentialsRequest}

Sign in the user with credentials.  Return a security token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SignInWithCredentialsRequestsigninwithcredentialsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new SignInWithCredentialsRequest(); // SignInWithCredentialsRequest |  (optional) 

            try
            {
                // Sign in the user with credentials. - {SignInWithCredentialsRequest}
                UserPermissions result = apiInstance.SignInWithCredentialsRequestsigninwithcredentialsPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SignInWithCredentialsRequestsigninwithcredentialsPost: " + e.Message );
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
 **body** | [**SignInWithCredentialsRequest**](SignInWithCredentialsRequest.md)|  | [optional] 

### Return type

[**UserPermissions**](UserPermissions.md)

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

<a name="signinwithissuedtokenrequestsigninwithtokenpost"></a>
# **SignInWithIssuedTokenRequestsigninwithtokenPost**
> UserPermissions SignInWithIssuedTokenRequestsigninwithtokenPost (string accept, SignInWithIssuedTokenRequest body = null)

Sign in the user with a received token. - {SignInWithIssuedTokenRequest}

Sign in the user with a received token.  Return the user permissions when the authentication is successfull.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SignInWithIssuedTokenRequestsigninwithtokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new SignInWithIssuedTokenRequest(); // SignInWithIssuedTokenRequest |  (optional) 

            try
            {
                // Sign in the user with a received token. - {SignInWithIssuedTokenRequest}
                UserPermissions result = apiInstance.SignInWithIssuedTokenRequestsigninwithtokenPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SignInWithIssuedTokenRequestsigninwithtokenPost: " + e.Message );
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
 **body** | [**SignInWithIssuedTokenRequest**](SignInWithIssuedTokenRequest.md)|  | [optional] 

### Return type

[**UserPermissions**](UserPermissions.md)

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

<a name="signinwithjwtrequestsigninwithjwtpost"></a>
# **SignInWithJWTRequestsigninwithjwtPost**
> UserPermissions SignInWithJWTRequestsigninwithjwtPost (string accept, SignInWithJWTRequest body = null)

Sign in user with JWT token. Set authentication cookies and return the current user permissions. - {SignInWithJWTRequest}

Sign in user with JWT token. Set authentication cookies and return the current user permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SignInWithJWTRequestsigninwithjwtPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new SignInWithJWTRequest(); // SignInWithJWTRequest |  (optional) 

            try
            {
                // Sign in user with JWT token. Set authentication cookies and return the current user permissions. - {SignInWithJWTRequest}
                UserPermissions result = apiInstance.SignInWithJWTRequestsigninwithjwtPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SignInWithJWTRequestsigninwithjwtPost: " + e.Message );
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
 **body** | [**SignInWithJWTRequest**](SignInWithJWTRequest.md)|  | [optional] 

### Return type

[**UserPermissions**](UserPermissions.md)

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

<a name="signoutrequestsignoutpost"></a>
# **SignOutRequestsignoutPost**
> string SignOutRequestsignoutPost (string accept, SignOutRequest body = null)

Signout the user - {SignOutRequest}

Signout the user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class SignOutRequestsignoutPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new AuthenticationApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new SignOutRequest(); // SignOutRequest |  (optional) 

            try
            {
                // Signout the user - {SignOutRequest}
                string result = apiInstance.SignOutRequestsignoutPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SignOutRequestsignoutPost: " + e.Message );
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
 **body** | [**SignOutRequest**](SignOutRequest.md)|  | [optional] 

### Return type

**string**

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

