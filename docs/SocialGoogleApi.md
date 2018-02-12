# com.knetikcloud.Api.SocialGoogleApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LinkAccounts1**](SocialGoogleApi.md#linkaccounts1) | **POST** /social/google/users | Link google account


<a name="linkaccounts1"></a>
# **LinkAccounts1**
> void LinkAccounts1 (GoogleToken googleToken = null)

Link google account

Links the current user account to a google account, using the acccess token from google. Can also be used to update the access token after it has expired. <br><br><b>Permissions Needed:</b> Non-google user token

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
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialGoogleApi();
            var googleToken = new GoogleToken(); // GoogleToken | The token from google (optional) 

            try
            {
                // Link google account
                apiInstance.LinkAccounts1(googleToken);
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
 **googleToken** | [**GoogleToken**](GoogleToken.md)| The token from google | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

