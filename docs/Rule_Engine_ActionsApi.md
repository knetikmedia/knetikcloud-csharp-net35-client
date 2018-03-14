# com.knetikcloud.Api.Rule_Engine_ActionsApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBREActions**](Rule_Engine_ActionsApi.md#getbreactions) | **GET** /bre/actions | Get a list of available actions


<a name="getbreactions"></a>
# **GetBREActions**
> List<ActionResource> GetBREActions (string filterCategory = null, string filterName = null, string filterTags = null, string filterSearch = null)

Get a list of available actions

<b>Permissions Needed:</b> BRE_RULE_ENGINE_ACTIONS_USER

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_ActionsApi();
            var filterCategory = filterCategory_example;  // string | Filter for actions that are within a specific category (optional) 
            var filterName = filterName_example;  // string | Filter for actions that have names containing the given string (optional) 
            var filterTags = filterTags_example;  // string | Filter for actions that have all of the given tags (comma separated list) (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for actions containing the given words somewhere within name, description and tags (optional) 

            try
            {
                // Get a list of available actions
                List&lt;ActionResource&gt; result = apiInstance.GetBREActions(filterCategory, filterName, filterTags, filterSearch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_ActionsApi.GetBREActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterCategory** | **string**| Filter for actions that are within a specific category | [optional] 
 **filterName** | **string**| Filter for actions that have names containing the given string | [optional] 
 **filterTags** | **string**| Filter for actions that have all of the given tags (comma separated list) | [optional] 
 **filterSearch** | **string**| Filter for actions containing the given words somewhere within name, description and tags | [optional] 

### Return type

[**List<ActionResource>**](ActionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

