# Yaksa.OrckestraCommerce.Client.Model.GetTemplatesRequest
Scoped templatable content either for notification (email) purposes or Reports such as printable order invoices.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeId** | **string** | The id of the requested scope | [optional] 
**ActiveOnly** | **bool** | Determines whether the result will include inactive templates | [optional] 
**Cultures** | **List&lt;string&gt;** | List of cultures for which to retrieve the content | [optional] 
**IncludeContents** | **bool** | Determines whether the template content will be included with the result | [optional] 
**ReplaceTemplateVariables** | **bool** | Determines if the template variable tags will be replaced with their actual values. | [optional] 
**Type** | **string** | Template type to retrieve | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

