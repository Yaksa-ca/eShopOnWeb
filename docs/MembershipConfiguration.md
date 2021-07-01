# Yaksa.OrckestraCommerce.Client.Model.MembershipConfiguration
MembershipConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountLockDownMinutes** | **int** | The account lock down time (in minutes) | [optional] 
**EnablePasswordReset** | **bool** | Indicates whether the current membership provider is configured to allow customers to reset their passwords | [optional] 
**EnablePasswordRetrieval** | **bool** | Indicates whether the current membership provider is configured to allow users to retrieve their passwords | [optional] 
**MaxInvalidPasswordAttempts** | **int** | The number of invalid password or password-answer attempts allowed before the membership user is locked out | [optional] 
**MinRequiredNonAlphanumericCharacters** | **int** | The minimum number of special characters that must be present in a valid password | [optional] 
**MinRequiredPasswordLength** | **int** | The minimum required length for a password | [optional] 
**PasswordAttemptWindow** | **int** | The time window (in minutes) between which consecutive failed attempts to provide a valid password or password answer are tracked | [optional] 
**PasswordFailedAttemptDelaySeconds** | **double** | The delay to apply on a failed login attempt | [optional] 
**PasswordStrategy** | **string** | The strategy used to store the password MembershipPasswordStrategy | [optional] 
**PasswordStrengthRegularExpression** | **string** | The regular expression used to validate the strength level of a password | [optional] 
**RequiresQuestionAndAnswer** | **bool** | Indicates whether the default membership provider requires the user to answer a password question (and answer) for password reset and retrieval | [optional] 
**RequiresUniqueEmail** | **bool** | Indicating whether the customer email addresses should be unique across the system | [optional] 
**TokenExpirationMinutes** | **int** | The expiration time of reset password ticket (in minutes) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

