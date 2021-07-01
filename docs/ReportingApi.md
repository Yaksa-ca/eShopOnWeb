# Yaksa.OrckestraCommerce.Client.Api.ReportingApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPost**](ReportingApi.md#createssrsreportpreviewrequestssrsreportsreportidpreviewspost) | **POST** /reporting/ssrs/reports/{ReportId}/previews | Retrieve a preview image of a report in Ssrs - {CreateSsrsReportPreviewRequest}
[**ExportSsrsReportRequestssrsreportsReportIdexportPost**](ReportingApi.md#exportssrsreportrequestssrsreportsreportidexportpost) | **POST** /reporting/ssrs/reports/{ReportId}/export | Export a report from Ssrs - {ExportSsrsReportRequest}
[**GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGet**](ReportingApi.md#getssrsrenderingformatsrequestssrsreportsrenderingformatsget) | **GET** /reporting/ssrs/reports/renderingformats | Retrieve a list of supported rendering formats for an Ssrs export - {GetSsrsRenderingFormatsRequest}
[**GetSsrsReportParametersRequestssrsreportsReportIdparametersPost**](ReportingApi.md#getssrsreportparametersrequestssrsreportsreportidparameterspost) | **POST** /reporting/ssrs/reports/{ReportId}/parameters | Retrieve a list of all report parameterss in Ssrs - {GetSsrsReportParametersRequest}
[**GetSsrsReportsRequestssrsreportsGet**](ReportingApi.md#getssrsreportsrequestssrsreportsget) | **GET** /reporting/ssrs/reports | Retrieve a list of all reports in Ssrs - {GetSsrsReportsRequest}


<a name="createssrsreportpreviewrequestssrsreportsreportidpreviewspost"></a>
# **CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPost**
> ReportPreview CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPost (string accept, string reportId, CreateSsrsReportPreviewRequest body = null)

Retrieve a preview image of a report in Ssrs - {CreateSsrsReportPreviewRequest}

Retrieve a preview image of a report in Ssrs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ReportingApi(config);
            var accept = accept_example;  // string | Accept Header
            var reportId = reportId_example;  // string | The report to be used for retrieving the preview image.
            var body = new CreateSsrsReportPreviewRequest(); // CreateSsrsReportPreviewRequest |  (optional) 

            try
            {
                // Retrieve a preview image of a report in Ssrs - {CreateSsrsReportPreviewRequest}
                ReportPreview result = apiInstance.CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPost(accept, reportId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.CreateSsrsReportPreviewRequestssrsreportsReportIdpreviewsPost: " + e.Message );
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
 **reportId** | **string**| The report to be used for retrieving the preview image. | 
 **body** | [**CreateSsrsReportPreviewRequest**](CreateSsrsReportPreviewRequest.md)|  | [optional] 

### Return type

[**ReportPreview**](ReportPreview.md)

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

<a name="exportssrsreportrequestssrsreportsreportidexportpost"></a>
# **ExportSsrsReportRequestssrsreportsReportIdexportPost**
> TaskInfo ExportSsrsReportRequestssrsreportsReportIdexportPost (string accept, string reportId, ExportSsrsReportRequest body = null)

Export a report from Ssrs - {ExportSsrsReportRequest}

Export a report from Ssrs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class ExportSsrsReportRequestssrsreportsReportIdexportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ReportingApi(config);
            var accept = accept_example;  // string | Accept Header
            var reportId = reportId_example;  // string | The report to be used for retrieving the preview image.
            var body = new ExportSsrsReportRequest(); // ExportSsrsReportRequest |  (optional) 

            try
            {
                // Export a report from Ssrs - {ExportSsrsReportRequest}
                TaskInfo result = apiInstance.ExportSsrsReportRequestssrsreportsReportIdexportPost(accept, reportId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.ExportSsrsReportRequestssrsreportsReportIdexportPost: " + e.Message );
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
 **reportId** | **string**| The report to be used for retrieving the preview image. | 
 **body** | [**ExportSsrsReportRequest**](ExportSsrsReportRequest.md)|  | [optional] 

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

<a name="getssrsrenderingformatsrequestssrsreportsrenderingformatsget"></a>
# **GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGet**
> List&lt;string&gt; GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGet (string accept, string cultureName = null)

Retrieve a list of supported rendering formats for an Ssrs export - {GetSsrsRenderingFormatsRequest}

Retrieve a list of supported rendering formats for an Ssrs export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ReportingApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 

            try
            {
                // Retrieve a list of supported rendering formats for an Ssrs export - {GetSsrsRenderingFormatsRequest}
                List<string> result = apiInstance.GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGet(accept, cultureName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.GetSsrsRenderingFormatsRequestssrsreportsrenderingformatsGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 

### Return type

**List<string>**

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

<a name="getssrsreportparametersrequestssrsreportsreportidparameterspost"></a>
# **GetSsrsReportParametersRequestssrsreportsReportIdparametersPost**
> List&lt;ReportParameter&gt; GetSsrsReportParametersRequestssrsreportsReportIdparametersPost (string accept, string reportId, GetSsrsReportParametersRequest body = null)

Retrieve a list of all report parameterss in Ssrs - {GetSsrsReportParametersRequest}

Retrieve a list of all reports in Ssrs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetSsrsReportParametersRequestssrsreportsReportIdparametersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ReportingApi(config);
            var accept = accept_example;  // string | Accept Header
            var reportId = reportId_example;  // string | The report to be used for retrieving report parameters.
            var body = new GetSsrsReportParametersRequest(); // GetSsrsReportParametersRequest |  (optional) 

            try
            {
                // Retrieve a list of all report parameterss in Ssrs - {GetSsrsReportParametersRequest}
                List<ReportParameter> result = apiInstance.GetSsrsReportParametersRequestssrsreportsReportIdparametersPost(accept, reportId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.GetSsrsReportParametersRequestssrsreportsReportIdparametersPost: " + e.Message );
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
 **reportId** | **string**| The report to be used for retrieving report parameters. | 
 **body** | [**GetSsrsReportParametersRequest**](GetSsrsReportParametersRequest.md)|  | [optional] 

### Return type

[**List&lt;ReportParameter&gt;**](ReportParameter.md)

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

<a name="getssrsreportsrequestssrsreportsget"></a>
# **GetSsrsReportsRequestssrsreportsGet**
> List&lt;Report&gt; GetSsrsReportsRequestssrsreportsGet (string accept, string cultureName = null, string scopeId = null)

Retrieve a list of all reports in Ssrs - {GetSsrsReportsRequest}

Retrieve a list of all reports in Ssrs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetSsrsReportsRequestssrsreportsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new ReportingApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 
            var scopeId = scopeId_example;  // string | The id of the requested scope (optional) 

            try
            {
                // Retrieve a list of all reports in Ssrs - {GetSsrsReportsRequest}
                List<Report> result = apiInstance.GetSsrsReportsRequestssrsreportsGet(accept, cultureName, scopeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.GetSsrsReportsRequestssrsreportsGet: " + e.Message );
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
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 
 **scopeId** | **string**| The id of the requested scope | [optional] 

### Return type

[**List&lt;Report&gt;**](Report.md)

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

