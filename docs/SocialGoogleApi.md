# com.knetikcloud.Api.SocialGoogleApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LinkAccounts1**](SocialGoogleApi.md#linkaccounts1) | **POST** /social/google/users | Link facebook account


<a name="linkaccounts1"></a>
# **LinkAccounts1**
> void LinkAccounts1 (GoogleToken facebookToken = null)

Link facebook account

Links the current user account to a facebook account, using the acccess token from facebook. Can also be used to update the access token after it has expired.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class LinkAccounts1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialGoogleApi();
            var facebookToken = new GoogleToken(); // GoogleToken | The token from facebook (optional) 

            try
            {
                // Link facebook account
                apiInstance.LinkAccounts1(facebookToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialGoogleApi.LinkAccounts1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **facebookToken** | [**GoogleToken**](GoogleToken.md)| The token from facebook | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

