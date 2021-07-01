# Yaksa.OrckestraCommerce.Client.Api.MembershipApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePasswordRequestScopeIdChangePasswordUserNamePost**](MembershipApi.md#changepasswordrequestscopeidchangepasswordusernamepost) | **POST** /membership/{ScopeId}/ChangePassword/{UserName} | Change a Customer&#39;s password - {ChangePasswordRequest}
[**ChangeUserNameRequestScopeIdChangeUserNameOldUsernamePost**](MembershipApi.md#changeusernamerequestscopeidchangeusernameoldusernamepost) | **POST** /membership/{ScopeId}/ChangeUserName/{OldUsername} | Change a Customer&#39;s user name - {ChangeUserNameRequest}
[**CreateCustomerMembershipRequestScopeIdPost**](MembershipApi.md#createcustomermembershiprequestscopeidpost) | **POST** /membership/{ScopeId} | Create a new customer membership - {CreateCustomerMembershipRequest}
[**GetMembershipConfigurationRequestconfigurationGet**](MembershipApi.md#getmembershipconfigurationrequestconfigurationget) | **GET** /membership/configuration | Retrieve the membership configuration from the system - {GetMembershipConfigurationRequest}
[**LoginRequestScopeIdLoginCreate**](MembershipApi.md#loginrequestscopeidlogincreate) | **PUT** /membership/{ScopeId}/Login | Login the user with the values provided - {LoginRequest}
[**ResetPasswordRequestScopeIdResetPasswordPost**](MembershipApi.md#resetpasswordrequestscopeidresetpasswordpost) | **POST** /membership/{ScopeId}/ResetPassword | Send a password reset email or reset password directly - {ResetPasswordRequest}
[**UnlockUserRequestScopeIdUnlockUserUserNamePost**](MembershipApi.md#unlockuserrequestscopeidunlockuserusernamepost) | **POST** /membership/{ScopeId}/UnlockUser/{UserName} | Unlock a User account - {UnlockUserRequest}
[**ValidateUserRequestScopeIdValidateCreate**](MembershipApi.md#validateuserrequestscopeidvalidatecreate) | **PUT** /membership/{ScopeId}/Validate | Validate a username/password combination - {ValidateUserRequest}


<a name="changepasswordrequestscopeidchangepasswordusernamepost"></a>
# **ChangePasswordRequestScopeIdChangePasswordUserNamePost**
> ChangePasswordResponse ChangePasswordRequestScopeIdChangePasswordUserNamePost (string accept, string scopeId, string userName, ChangePasswordRequest body = null)

Change a Customer's password - {ChangePasswordRequest}

Change a Customer's password. Return information indicating whether the password was successfully changed or not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ChangePasswordRequestScopeIdChangePasswordUserNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var userName = userName_example;  // string | The UserName
            var body = new ChangePasswordRequest(); // ChangePasswordRequest |  (optional) 

            try
            {
                // Change a Customer's password - {ChangePasswordRequest}
                ChangePasswordResponse result = apiInstance.ChangePasswordRequestScopeIdChangePasswordUserNamePost(accept, scopeId, userName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.ChangePasswordRequestScopeIdChangePasswordUserNamePost: " + e.Message );
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
 **userName** | **string**| The UserName | 
 **body** | [**ChangePasswordRequest**](ChangePasswordRequest.md)|  | [optional] 

### Return type

[**ChangePasswordResponse**](ChangePasswordResponse.md)

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

<a name="changeusernamerequestscopeidchangeusernameoldusernamepost"></a>
# **ChangeUserNameRequestScopeIdChangeUserNameOldUsernamePost**
> ChangeUserNameResponse ChangeUserNameRequestScopeIdChangeUserNameOldUsernamePost (string accept, string scopeId, string oldUsername, ChangeUserNameRequest body = null)

Change a Customer's user name - {ChangeUserNameRequest}

Change a Customer's user name. Return information indicating whether the user name was successfully changed or not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ChangeUserNameRequestScopeIdChangeUserNameOldUsernamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var oldUsername = oldUsername_example;  // string | The old (current) username
            var body = new ChangeUserNameRequest(); // ChangeUserNameRequest |  (optional) 

            try
            {
                // Change a Customer's user name - {ChangeUserNameRequest}
                ChangeUserNameResponse result = apiInstance.ChangeUserNameRequestScopeIdChangeUserNameOldUsernamePost(accept, scopeId, oldUsername, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.ChangeUserNameRequestScopeIdChangeUserNameOldUsernamePost: " + e.Message );
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
 **oldUsername** | **string**| The old (current) username | 
 **body** | [**ChangeUserNameRequest**](ChangeUserNameRequest.md)|  | [optional] 

### Return type

[**ChangeUserNameResponse**](ChangeUserNameResponse.md)

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

<a name="createcustomermembershiprequestscopeidpost"></a>
# **CreateCustomerMembershipRequestScopeIdPost**
> Customer CreateCustomerMembershipRequestScopeIdPost (string accept, string scopeId, CreateCustomerMembershipRequest body = null)

Create a new customer membership - {CreateCustomerMembershipRequest}

Create a new customer membership. Return the customer if the operation succeeded but raise an error and provide details when there is a problem. The error could be : UserNameAlreadyUsed, InvalidPassword or PasswordQuestionNoSet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateCustomerMembershipRequestScopeIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new CreateCustomerMembershipRequest(); // CreateCustomerMembershipRequest |  (optional) 

            try
            {
                // Create a new customer membership - {CreateCustomerMembershipRequest}
                Customer result = apiInstance.CreateCustomerMembershipRequestScopeIdPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.CreateCustomerMembershipRequestScopeIdPost: " + e.Message );
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
 **body** | [**CreateCustomerMembershipRequest**](CreateCustomerMembershipRequest.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

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

<a name="getmembershipconfigurationrequestconfigurationget"></a>
# **GetMembershipConfigurationRequestconfigurationGet**
> MembershipConfiguration GetMembershipConfigurationRequestconfigurationGet (string accept)

Retrieve the membership configuration from the system - {GetMembershipConfigurationRequest}

Retrieve the membership configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetMembershipConfigurationRequestconfigurationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header

            try
            {
                // Retrieve the membership configuration from the system - {GetMembershipConfigurationRequest}
                MembershipConfiguration result = apiInstance.GetMembershipConfigurationRequestconfigurationGet(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.GetMembershipConfigurationRequestconfigurationGet: " + e.Message );
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

[**MembershipConfiguration**](MembershipConfiguration.md)

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

<a name="loginrequestscopeidlogincreate"></a>
# **LoginRequestScopeIdLoginCreate**
> LoginResponse LoginRequestScopeIdLoginCreate (string accept, string scopeId, LoginRequest body = null)

Login the user with the values provided - {LoginRequest}

Login the user. A result is returned that indicates if the operation succeeded but raise an error and provide details when there is a problem. The error could be : CustomerMembershipDoesNotExist, PasswordDoesNotMatch or CustomerMembershipAccountIsNotActive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class LoginRequestScopeIdLoginCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new LoginRequest(); // LoginRequest |  (optional) 

            try
            {
                // Login the user with the values provided - {LoginRequest}
                LoginResponse result = apiInstance.LoginRequestScopeIdLoginCreate(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.LoginRequestScopeIdLoginCreate: " + e.Message );
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
 **body** | [**LoginRequest**](LoginRequest.md)|  | [optional] 

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | No customer found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetpasswordrequestscopeidresetpasswordpost"></a>
# **ResetPasswordRequestScopeIdResetPasswordPost**
> ResetPasswordResponse ResetPasswordRequestScopeIdResetPasswordPost (string accept, string scopeId, ResetPasswordRequest body = null)

Send a password reset email or reset password directly - {ResetPasswordRequest}

Send a password reset email or reset password directly. Return information indicating whether the password was successfully reset or not.If an email is specified in the request, the method sends an email to reset the password. If not, set an username, the password answer and a new password to reset the password directly

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ResetPasswordRequestScopeIdResetPasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new ResetPasswordRequest(); // ResetPasswordRequest |  (optional) 

            try
            {
                // Send a password reset email or reset password directly - {ResetPasswordRequest}
                ResetPasswordResponse result = apiInstance.ResetPasswordRequestScopeIdResetPasswordPost(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.ResetPasswordRequestScopeIdResetPasswordPost: " + e.Message );
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
 **body** | [**ResetPasswordRequest**](ResetPasswordRequest.md)|  | [optional] 

### Return type

[**ResetPasswordResponse**](ResetPasswordResponse.md)

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

<a name="unlockuserrequestscopeidunlockuserusernamepost"></a>
# **UnlockUserRequestScopeIdUnlockUserUserNamePost**
> UnlockUserResponse UnlockUserRequestScopeIdUnlockUserUserNamePost (string accept, string scopeId, string userName, Object body = null)

Unlock a User account - {UnlockUserRequest}

Unlock a user. If the user is locked down, the request will unlock the account. If the user is not locked down, the request will succeed as if the account were locked down. If the user does not exists, the request will fail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UnlockUserRequestScopeIdUnlockUserUserNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var userName = userName_example;  // string | The username
            var body = ;  // Object |  (optional) 

            try
            {
                // Unlock a User account - {UnlockUserRequest}
                UnlockUserResponse result = apiInstance.UnlockUserRequestScopeIdUnlockUserUserNamePost(accept, scopeId, userName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.UnlockUserRequestScopeIdUnlockUserUserNamePost: " + e.Message );
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
 **userName** | **string**| The username | 
 **body** | **Object**|  | [optional] 

### Return type

[**UnlockUserResponse**](UnlockUserResponse.md)

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

<a name="validateuserrequestscopeidvalidatecreate"></a>
# **ValidateUserRequestScopeIdValidateCreate**
> ValidateUserResponse ValidateUserRequestScopeIdValidateCreate (string accept, string scopeId, ValidateUserRequest body = null)

Validate a username/password combination - {ValidateUserRequest}

Retrieve true if it's a valid combination

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ValidateUserRequestScopeIdValidateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new MembershipApi(config);
            var accept = accept_example;  // string | Accept Header
            var scopeId = scopeId_example;  // string | The id of the requested scope
            var body = new ValidateUserRequest(); // ValidateUserRequest |  (optional) 

            try
            {
                // Validate a username/password combination - {ValidateUserRequest}
                ValidateUserResponse result = apiInstance.ValidateUserRequestScopeIdValidateCreate(accept, scopeId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembershipApi.ValidateUserRequestScopeIdValidateCreate: " + e.Message );
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
 **body** | [**ValidateUserRequest**](ValidateUserRequest.md)|  | [optional] 

### Return type

[**ValidateUserResponse**](ValidateUserResponse.md)

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

