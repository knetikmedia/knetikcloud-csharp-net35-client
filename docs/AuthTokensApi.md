# com.knetikcloud.Api.AuthTokensApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTokens**](AuthTokensApi.md#deletetokens) | **DELETE** /auth/tokens | Delete tokens by username, client id, or both
[**GetToken**](AuthTokensApi.md#gettoken) | **GET** /auth/tokens/{username}/{client_id} | Get a single token by username and client id
[**GetTokens**](AuthTokensApi.md#gettokens) | **GET** /auth/tokens | List usernames and client ids


<a name="deletetokens"></a>
# **DeleteTokens**
> void DeleteTokens (string username = null, string clientId = null)

Delete tokens by username, client id, or both

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteTokensExample
    {
        public void main()
        {
            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user (optional) 
            var clientId = clientId_example;  // string | The id of the client (optional) 

            try
            {
                // Delete tokens by username, client id, or both
                apiInstance.DeleteTokens(username, clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.DeleteTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | [optional] 
 **clientId** | **string**| The id of the client | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettoken"></a>
# **GetToken**
> OauthAccessTokenResource GetToken (string username, string clientId)

Get a single token by username and client id

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user
            var clientId = clientId_example;  // string | The id of the client

            try
            {
                // Get a single token by username and client id
                OauthAccessTokenResource result = apiInstance.GetToken(username, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.GetToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | 
 **clientId** | **string**| The id of the client | 

### Return type

[**OauthAccessTokenResource**](OauthAccessTokenResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokens"></a>
# **GetTokens**
> PageResourceOauthAccessTokenResource GetTokens (string filterClientId = null, string filterUsername = null, int? size = null, int? page = null, string order = null)

List usernames and client ids

Token value not shown

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTokensExample
    {
        public void main()
        {
            var apiInstance = new AuthTokensApi();
            var filterClientId = filterClientId_example;  // string | Filters for token whose client id matches provided string (optional) 
            var filterUsername = filterUsername_example;  // string | Filters for token whose username matches provided string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // List usernames and client ids
                PageResourceOauthAccessTokenResource result = apiInstance.GetTokens(filterClientId, filterUsername, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.GetTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterClientId** | **string**| Filters for token whose client id matches provided string | [optional] 
 **filterUsername** | **string**| Filters for token whose username matches provided string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceOauthAccessTokenResource**](PageResourceOauthAccessTokenResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

