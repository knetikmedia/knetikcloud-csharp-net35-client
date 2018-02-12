# com.knetikcloud.Api.UsersApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserTag**](UsersApi.md#addusertag) | **POST** /users/{user_id}/tags | Add a tag to a user
[**CreateUserTemplate**](UsersApi.md#createusertemplate) | **POST** /users/templates | Create a user template
[**DeleteUserTemplate**](UsersApi.md#deleteusertemplate) | **DELETE** /users/templates/{id} | Delete a user template
[**GetDirectMessages1**](UsersApi.md#getdirectmessages1) | **GET** /users/users/{recipient_id}/messages | Get a list of direct messages with this user
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{id} | Get a single user
[**GetUserTags**](UsersApi.md#getusertags) | **GET** /users/{user_id}/tags | List tags for a user
[**GetUserTemplate**](UsersApi.md#getusertemplate) | **GET** /users/templates/{id} | Get a single user template
[**GetUserTemplates**](UsersApi.md#getusertemplates) | **GET** /users/templates | List and search user templates
[**GetUsers**](UsersApi.md#getusers) | **GET** /users | List and search users
[**PasswordReset**](UsersApi.md#passwordreset) | **PUT** /users/{id}/password-reset | Choose a new password after a reset
[**PostUserMessage**](UsersApi.md#postusermessage) | **POST** /users/{recipient_id}/messages | Send a user message
[**RegisterUser**](UsersApi.md#registeruser) | **POST** /users | Register a new user
[**RemoveUserTag**](UsersApi.md#removeusertag) | **DELETE** /users/{user_id}/tags/{tag} | Remove a tag from a user
[**SetPassword**](UsersApi.md#setpassword) | **PUT** /users/{id}/password | Set a user&#39;s password
[**StartPasswordReset**](UsersApi.md#startpasswordreset) | **POST** /users/{id}/password-reset | Reset a user&#39;s password
[**SubmitPasswordReset**](UsersApi.md#submitpasswordreset) | **POST** /users/password-reset | Reset a user&#39;s password without user id
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{id} | Update a user
[**UpdateUserTemplate**](UsersApi.md#updateusertemplate) | **PUT** /users/templates/{id} | Update a user template


<a name="addusertag"></a>
# **AddUserTag**
> void AddUserTag (int? userId, StringWrapper tag)

Add a tag to a user

<b>Permissions Needed:</b> USERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddUserTagExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | The id of the user
            var tag = new StringWrapper(); // StringWrapper | tag

            try
            {
                // Add a tag to a user
                apiInstance.AddUserTag(userId, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AddUserTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **tag** | [**StringWrapper**](StringWrapper.md)| tag | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createusertemplate"></a>
# **CreateUserTemplate**
> TemplateResource CreateUserTemplate (TemplateResource userTemplateResource = null)

Create a user template

User Templates define a type of user and the properties they have. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateUserTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userTemplateResource = new TemplateResource(); // TemplateResource | The user template resource object (optional) 

            try
            {
                // Create a user template
                TemplateResource result = apiInstance.CreateUserTemplate(userTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userTemplateResource** | [**TemplateResource**](TemplateResource.md)| The user template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusertemplate"></a>
# **DeleteUserTemplate**
> void DeleteUserTemplate (string id, string cascade = null)

Delete a user template

If cascade = 'detach', it will force delete the template even if it's attached to other objects. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteUserTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a user template
                apiInstance.DeleteUserTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| The value needed to delete used templates | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdirectmessages1"></a>
# **GetDirectMessages1**
> PageResourceChatMessageResource GetDirectMessages1 (int? recipientId, int? size = null, int? page = null)

Get a list of direct messages with this user

<b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDirectMessages1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var recipientId = 56;  // int? | The user id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get a list of direct messages with this user
                PageResourceChatMessageResource result = apiInstance.GetDirectMessages1(recipientId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetDirectMessages1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipientId** | **int?**| The user id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceChatMessageResource**](PageResourceChatMessageResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> UserResource GetUser (string id)

Get a single user

Additional private info is included as USERS_ADMIN. <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the user or 'me'

            try
            {
                // Get a single user
                UserResource result = apiInstance.GetUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the user or &#39;me&#39; | 

### Return type

[**UserResource**](UserResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertags"></a>
# **GetUserTags**
> List<string> GetUserTags (int? userId)

List tags for a user

<b>Permissions Needed:</b> USERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserTagsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // List tags for a user
                List&lt;string&gt; result = apiInstance.GetUserTags(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 

### Return type

**List<string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertemplate"></a>
# **GetUserTemplate**
> TemplateResource GetUserTemplate (string id)

Get a single user template

<b>Permissions Needed:</b> TEMPLATE_ADMIN or USERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single user template
                TemplateResource result = apiInstance.GetUserTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertemplates"></a>
# **GetUserTemplates**
> PageResourceTemplateResource GetUserTemplates (int? size = null, int? page = null, string order = null)

List and search user templates

<b>Permissions Needed:</b> TEMPLATE_ADMIN or USERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserTemplatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search user templates
                PageResourceTemplateResource result = apiInstance.GetUserTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceTemplateResource**](PageResourceTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> PageResourceUserBaseResource GetUsers (string filterDisplayname = null, string filterEmail = null, string filterFirstname = null, string filterFullname = null, string filterLastname = null, string filterUsername = null, string filterTag = null, string filterGroup = null, string filterRole = null, string filterLastActivity = null, string filterIdList = null, string filterSearch = null, int? size = null, int? page = null, string order = null)

List and search users

Additional private info is included as USERS_ADMIN. <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var filterDisplayname = filterDisplayname_example;  // string | Filter for users whose display name starts with provided string. (optional) 
            var filterEmail = filterEmail_example;  // string | Filter for users whose email starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterFirstname = filterFirstname_example;  // string | Filter for users whose first name starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterFullname = filterFullname_example;  // string | Filter for users whose full name starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterLastname = filterLastname_example;  // string | Filter for users whose last name starts with provided string. Requires USERS_ADMIN permission (optional) 
            var filterUsername = filterUsername_example;  // string | Filter for users whose username starts with the provided string. Requires USERS_ADMIN permission (optional) 
            var filterTag = filterTag_example;  // string | Filter for users who have a given tag (optional) 
            var filterGroup = filterGroup_example;  // string | Filter for users in a given group, by unique name (optional) 
            var filterRole = filterRole_example;  // string | Filter for users with a given role (optional) 
            var filterLastActivity = filterLastActivity_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterIdList = filterIdList_example;  // string | A comma separated list of ids. (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for users whose display_name starts with the provided string, or username if display_name is null (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search users
                PageResourceUserBaseResource result = apiInstance.GetUsers(filterDisplayname, filterEmail, filterFirstname, filterFullname, filterLastname, filterUsername, filterTag, filterGroup, filterRole, filterLastActivity, filterIdList, filterSearch, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterDisplayname** | **string**| Filter for users whose display name starts with provided string. | [optional] 
 **filterEmail** | **string**| Filter for users whose email starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterFirstname** | **string**| Filter for users whose first name starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterFullname** | **string**| Filter for users whose full name starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterLastname** | **string**| Filter for users whose last name starts with provided string. Requires USERS_ADMIN permission | [optional] 
 **filterUsername** | **string**| Filter for users whose username starts with the provided string. Requires USERS_ADMIN permission | [optional] 
 **filterTag** | **string**| Filter for users who have a given tag | [optional] 
 **filterGroup** | **string**| Filter for users in a given group, by unique name | [optional] 
 **filterRole** | **string**| Filter for users with a given role | [optional] 
 **filterLastActivity** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterIdList** | **string**| A comma separated list of ids. | [optional] 
 **filterSearch** | **string**| Filter for users whose display_name starts with the provided string, or username if display_name is null | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceUserBaseResource**](PageResourceUserBaseResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="passwordreset"></a>
# **PasswordReset**
> void PasswordReset (int? id, NewPasswordRequest newPasswordRequest = null)

Choose a new password after a reset

Finish resetting a user's password using the secret provided from the password-reset endpoint.  Password should be in plain text and will be encrypted on receipt. Use SSL for security. <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PasswordResetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The id of the user
            var newPasswordRequest = new NewPasswordRequest(); // NewPasswordRequest | The new password request object (optional) 

            try
            {
                // Choose a new password after a reset
                apiInstance.PasswordReset(id, newPasswordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **newPasswordRequest** | [**NewPasswordRequest**](NewPasswordRequest.md)| The new password request object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusermessage"></a>
# **PostUserMessage**
> ChatMessageResource PostUserMessage (int? recipientId, ChatMessageRequest chatMessageRequest = null)

Send a user message

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PostUserMessageExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var recipientId = 56;  // int? | The user id
            var chatMessageRequest = new ChatMessageRequest(); // ChatMessageRequest | The chat message request (optional) 

            try
            {
                // Send a user message
                ChatMessageResource result = apiInstance.PostUserMessage(recipientId, chatMessageRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUserMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipientId** | **int?**| The user id | 
 **chatMessageRequest** | [**ChatMessageRequest**](ChatMessageRequest.md)| The chat message request | [optional] 

### Return type

[**ChatMessageResource**](ChatMessageResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeruser"></a>
# **RegisterUser**
> UserResource RegisterUser (UserResource userResource = null)

Register a new user

Password should be in plain text and will be encrypted on receipt. Use SSL for security. <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RegisterUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userResource = new UserResource(); // UserResource | The user resource object (optional) 

            try
            {
                // Register a new user
                UserResource result = apiInstance.RegisterUser(userResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RegisterUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userResource** | [**UserResource**](UserResource.md)| The user resource object | [optional] 

### Return type

[**UserResource**](UserResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeusertag"></a>
# **RemoveUserTag**
> void RemoveUserTag (int? userId, string tag)

Remove a tag from a user

<b>Permissions Needed:</b> USERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveUserTagExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | The id of the user
            var tag = tag_example;  // string | The tag to remove

            try
            {
                // Remove a tag from a user
                apiInstance.RemoveUserTag(userId, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RemoveUserTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **tag** | **string**| The tag to remove | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpassword"></a>
# **SetPassword**
> void SetPassword (int? id, StringWrapper password = null)

Set a user's password

Password should be in plain text and will be encrypted on receipt. Use SSL for security. <br><br><b>Permissions Needed:</b> USERS_ADMIN or (USERS_USER and owner)

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetPasswordExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The id of the user
            var password = new StringWrapper(); // StringWrapper | The new plain text password (optional) 

            try
            {
                // Set a user's password
                apiInstance.SetPassword(id, password);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **password** | [**StringWrapper**](StringWrapper.md)| The new plain text password | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startpasswordreset"></a>
# **StartPasswordReset**
> void StartPasswordReset (int? id)

Reset a user's password

A reset code will be generated and a 'forgot_password' BRE event will be fired with that code.  The default system rule will send an email to the selected user if an email service has been setup. You can modify that rule in BRE to send an SMS instead or any other type of notification as you see fit. <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class StartPasswordResetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The id of the user

            try
            {
                // Reset a user's password
                apiInstance.StartPasswordReset(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.StartPasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitpasswordreset"></a>
# **SubmitPasswordReset**
> void SubmitPasswordReset (PasswordResetRequest passwordReset = null)

Reset a user's password without user id

A reset code will be generated and a 'forgot_password' BRE event will be fired with that code.  The default system rule will send an email to the selected user if an email service has been setup. You can modify that rule in BRE to send an SMS instead or any other type of notification as you see fit.  Must submit their email, username, or mobile phone number. <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SubmitPasswordResetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var passwordReset = new PasswordResetRequest(); // PasswordResetRequest | An object containing one of three methods to look up a user (optional) 

            try
            {
                // Reset a user's password without user id
                apiInstance.SubmitPasswordReset(passwordReset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SubmitPasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passwordReset** | [**PasswordResetRequest**](PasswordResetRequest.md)| An object containing one of three methods to look up a user | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (string id, UserResource userResource = null)

Update a user

Password will not be edited on this endpoint, use password specific endpoints. <br><br><b>Permissions Needed:</b> USERS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the user or 'me'
            var userResource = new UserResource(); // UserResource | The user resource object (optional) 

            try
            {
                // Update a user
                apiInstance.UpdateUser(id, userResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the user or &#39;me&#39; | 
 **userResource** | [**UserResource**](UserResource.md)| The user resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusertemplate"></a>
# **UpdateUserTemplate**
> TemplateResource UpdateUserTemplate (string id, TemplateResource userTemplateResource = null)

Update a user template

<b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateUserTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | The id of the template
            var userTemplateResource = new TemplateResource(); // TemplateResource | The user template resource object (optional) 

            try
            {
                // Update a user template
                TemplateResource result = apiInstance.UpdateUserTemplate(id, userTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **userTemplateResource** | [**TemplateResource**](TemplateResource.md)| The user template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

