# Yaksa.OrckestraCommerce.Client.Api.CountriesApi

All URIs are relative to *https://dev-ocs-cm.develop.orckestra.cloud/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCountryRequestPost**](CountriesApi.md#addcountryrequestpost) | **POST** /countries | Adds a country - {AddCountryRequest}
[**GetCountriesRequestGet**](CountriesApi.md#getcountriesrequestget) | **GET** /countries | Retrieve all countries - {GetCountriesRequest}
[**GetCountryRequestCountryIsoCodeGet**](CountriesApi.md#getcountryrequestcountryisocodeget) | **GET** /countries/{CountryIsoCode} | Retrieve a country - {GetCountryRequest}
[**GetRegionsRequestCountryIsoCoderegionsGet**](CountriesApi.md#getregionsrequestcountryisocoderegionsget) | **GET** /countries/{CountryIsoCode}/regions | Retrieve all regions of a country - {GetRegionsRequest}
[**UpdateCountryAndRegionsRequestIsoCodeCreate**](CountriesApi.md#updatecountryandregionsrequestisocodecreate) | **PUT** /countries/{IsoCode} | Update a country and associated regions - {UpdateCountryAndRegionsRequest}


<a name="addcountryrequestpost"></a>
# **AddCountryRequestPost**
> Country AddCountryRequestPost (string accept, AddCountryRequest body = null)

Adds a country - {AddCountryRequest}

Adds a country.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class AddCountryRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CountriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var body = new AddCountryRequest(); // AddCountryRequest |  (optional) 

            try
            {
                // Adds a country - {AddCountryRequest}
                Country result = apiInstance.AddCountryRequestPost(accept, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CountriesApi.AddCountryRequestPost: " + e.Message );
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
 **body** | [**AddCountryRequest**](AddCountryRequest.md)|  | [optional] 

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |
| **404** | The specified country was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountriesrequestget"></a>
# **GetCountriesRequestGet**
> List&lt;Country&gt; GetCountriesRequestGet (string accept, string cultureName = null, bool? includeUnsupported = null, bool? includeRegions = null)

Retrieve all countries - {GetCountriesRequest}

Retrieve all countries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCountriesRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CountriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 
            var includeUnsupported = true;  // bool? | Whether to include the unsupported countries (optional) 
            var includeRegions = true;  // bool? | Whether to include the regions in each country (optional) 

            try
            {
                // Retrieve all countries - {GetCountriesRequest}
                List<Country> result = apiInstance.GetCountriesRequestGet(accept, cultureName, includeUnsupported, includeRegions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CountriesApi.GetCountriesRequestGet: " + e.Message );
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
 **includeUnsupported** | **bool?**| Whether to include the unsupported countries | [optional] 
 **includeRegions** | **bool?**| Whether to include the regions in each country | [optional] 

### Return type

[**List&lt;Country&gt;**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountryrequestcountryisocodeget"></a>
# **GetCountryRequestCountryIsoCodeGet**
> Country GetCountryRequestCountryIsoCodeGet (string accept, string countryIsoCode, string cultureName = null, bool? includeRegions = null)

Retrieve a country - {GetCountryRequest}

Retrieve a country using its ISO code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetCountryRequestCountryIsoCodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CountriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var countryIsoCode = countryIsoCode_example;  // string | The countryIsoCode (unique) that identifies the country to retrieve
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 
            var includeRegions = true;  // bool? | Whether to include the regions in each country (optional) 

            try
            {
                // Retrieve a country - {GetCountryRequest}
                Country result = apiInstance.GetCountryRequestCountryIsoCodeGet(accept, countryIsoCode, cultureName, includeRegions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CountriesApi.GetCountryRequestCountryIsoCodeGet: " + e.Message );
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
 **countryIsoCode** | **string**| The countryIsoCode (unique) that identifies the country to retrieve | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 
 **includeRegions** | **bool?**| Whether to include the regions in each country | [optional] 

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |
| **404** | The specified country was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregionsrequestcountryisocoderegionsget"></a>
# **GetRegionsRequestCountryIsoCoderegionsGet**
> List&lt;Region&gt; GetRegionsRequestCountryIsoCoderegionsGet (string accept, string countryIsoCode, string cultureName = null, bool? includeUnsupported = null)

Retrieve all regions of a country - {GetRegionsRequest}

Retrieve all regions of a country

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class GetRegionsRequestCountryIsoCoderegionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CountriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var countryIsoCode = countryIsoCode_example;  // string | The unique countryIsoCode that identifies the country whose regions will be retrieved
            var cultureName = cultureName_example;  // string | The culture name in which language the data will be returned (optional) 
            var includeUnsupported = true;  // bool? | Whether to include the unsupported regions (optional) 

            try
            {
                // Retrieve all regions of a country - {GetRegionsRequest}
                List<Region> result = apiInstance.GetRegionsRequestCountryIsoCoderegionsGet(accept, countryIsoCode, cultureName, includeUnsupported);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CountriesApi.GetRegionsRequestCountryIsoCoderegionsGet: " + e.Message );
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
 **countryIsoCode** | **string**| The unique countryIsoCode that identifies the country whose regions will be retrieved | 
 **cultureName** | **string**| The culture name in which language the data will be returned | [optional] 
 **includeUnsupported** | **bool?**| Whether to include the unsupported regions | [optional] 

### Return type

[**List&lt;Region&gt;**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |
| **404** | Requested country iso code not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecountryandregionsrequestisocodecreate"></a>
# **UpdateCountryAndRegionsRequestIsoCodeCreate**
> Country UpdateCountryAndRegionsRequestIsoCodeCreate (string accept, string isoCode, UpdateCountryAndRegionsRequest body = null)

Update a country and associated regions - {UpdateCountryAndRegionsRequest}

Updates a country and associated regions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yaksa.OrckestraCommerce.Client.Api;
using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Model;

namespace Example
{
    public class UpdateCountryAndRegionsRequestIsoCodeCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-ocs-cm.develop.orckestra.cloud/api";
            var apiInstance = new CountriesApi(config);
            var accept = accept_example;  // string | Accept Header
            var isoCode = isoCode_example;  // string | Two letter code that identifies Country uniquely (ISO 3166)
            var body = new UpdateCountryAndRegionsRequest(); // UpdateCountryAndRegionsRequest |  (optional) 

            try
            {
                // Update a country and associated regions - {UpdateCountryAndRegionsRequest}
                Country result = apiInstance.UpdateCountryAndRegionsRequestIsoCodeCreate(accept, isoCode, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CountriesApi.UpdateCountryAndRegionsRequestIsoCodeCreate: " + e.Message );
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
 **isoCode** | **string**| Two letter code that identifies Country uniquely (ISO 3166) | 
 **body** | [**UpdateCountryAndRegionsRequest**](UpdateCountryAndRegionsRequest.md)|  | [optional] 

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | You must be authenticated for using this request |  -  |
| **404** | The specified country was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

