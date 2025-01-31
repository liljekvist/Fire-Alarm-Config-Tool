# FireAlarmConfigTool.Logic.Http.Client.Api.DefaultApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TestGet**](DefaultApi.md#testget) | **GET** /test | Test endpoint |

<a id="testget"></a>
# **TestGet**
> string TestGet (int num)

Test endpoint

Returns a greeting that includes the provided number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireAlarmConfigTool.Logic.Http.Client.Api;
using FireAlarmConfigTool.Logic.Http.Client.Client;
using FireAlarmConfigTool.Logic.Http.Client.Model;

namespace Example
{
    public class TestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DefaultApi(config);
            var num = 56;  // int | A number to include in the greeting

            try
            {
                // Test endpoint
                string result = apiInstance.TestGet(num);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test endpoint
    ApiResponse<string> response = apiInstance.TestGetWithHttpInfo(num);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **num** | **int** | A number to include in the greeting |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

