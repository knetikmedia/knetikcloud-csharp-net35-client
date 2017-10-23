# com.knetikcloud.Api.UsersFriendshipsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFriend**](UsersFriendshipsApi.md#addfriend) | **POST** /users/{user_id}/friends/{id} | Add a friend
[**GetFriends**](UsersFriendshipsApi.md#getfriends) | **GET** /users/{user_id}/friends | Get friends list
[**GetInviteToken**](UsersFriendshipsApi.md#getinvitetoken) | **GET** /users/{user_id}/invite-token | Returns the invite token
[**GetInvites**](UsersFriendshipsApi.md#getinvites) | **GET** /users/{user_id}/invites | Get pending invites
[**RedeemFriendshipToken**](UsersFriendshipsApi.md#redeemfriendshiptoken) | **POST** /users/{user_id}/friends/tokens | Redeem friendship token
[**RemoveOrDeclineFriend**](UsersFriendshipsApi.md#removeordeclinefriend) | **DELETE** /users/{user_id}/friends/{id} | Remove or decline a friend


<a name="addfriend"></a>
# **AddFriend**
> void AddFriend (string userId, int? id)

Add a friend

As a user, either creates or confirm a pending request. As an admin, call this endpoint twice while inverting the IDs to create a confirmed friendship.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddFriendExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in
            var id = 56;  // int? | The id of the user to befriend

            try
            {
                // Add a friend
                apiInstance.AddFriend(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.AddFriend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 
 **id** | **int?**| The id of the user to befriend | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfriends"></a>
# **GetFriends**
> PageResourceSimpleUserResource GetFriends (string userId, string filterUsername = null, int? filterUserId = null, int? size = null, int? page = null)

Get friends list

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetFriendsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me'
            var filterUsername = filterUsername_example;  // string | Filter for friends with the given username (optional) 
            var filterUserId = 56;  // int? | Filter for friends by user id (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get friends list
                PageResourceSimpleUserResource result = apiInstance.GetFriends(userId, filterUsername, filterUserId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.GetFriends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; | 
 **filterUsername** | **string**| Filter for friends with the given username | [optional] 
 **filterUserId** | **int?**| Filter for friends by user id | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceSimpleUserResource**](PageResourceSimpleUserResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitetoken"></a>
# **GetInviteToken**
> string GetInviteToken (string userId)

Returns the invite token

This is a unique invite token that allows direct connection to the request user.  Exposing that token presents privacy issues if the token is leaked. Use friend request flow instead if confirmation is required

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInviteTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in

            try
            {
                // Returns the invite token
                string result = apiInstance.GetInviteToken(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.GetInviteToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 

### Return type

**string**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvites"></a>
# **GetInvites**
> PageResourceSimpleUserResource GetInvites (string userId, int? size = null, int? page = null)

Get pending invites

Invites that the specified user received

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInvitesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me'
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get pending invites
                PageResourceSimpleUserResource result = apiInstance.GetInvites(userId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.GetInvites: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceSimpleUserResource**](PageResourceSimpleUserResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redeemfriendshiptoken"></a>
# **RedeemFriendshipToken**
> void RedeemFriendshipToken (string userId, StringWrapper token = null)

Redeem friendship token

Immediately connects the requested user with the user mapped by the provided invite token

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RedeemFriendshipTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in
            var token = new StringWrapper(); // StringWrapper | The invite token (optional) 

            try
            {
                // Redeem friendship token
                apiInstance.RedeemFriendshipToken(userId, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.RedeemFriendshipToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 
 **token** | [**StringWrapper**](StringWrapper.md)| The invite token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeordeclinefriend"></a>
# **RemoveOrDeclineFriend**
> void RemoveOrDeclineFriend (string userId, int? id)

Remove or decline a friend

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveOrDeclineFriendExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFriendshipsApi();
            var userId = userId_example;  // string | The id of the user or 'me' if logged in
            var id = 56;  // int? | The id of the user to befriend

            try
            {
                // Remove or decline a friend
                apiInstance.RemoveOrDeclineFriend(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersFriendshipsApi.RemoveOrDeclineFriend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; if logged in | 
 **id** | **int?**| The id of the user to befriend | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

