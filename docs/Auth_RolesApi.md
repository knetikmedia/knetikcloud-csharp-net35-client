# com.knetikcloud.Api.Auth_RolesApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRole**](Auth_RolesApi.md#createrole) | **POST** /auth/roles | Create a new role
[**DeleteRole**](Auth_RolesApi.md#deleterole) | **DELETE** /auth/roles/{role} | Delete a role
[**GetClientRoles**](Auth_RolesApi.md#getclientroles) | **GET** /auth/clients/{client_key}/roles | Get roles for a client
[**GetRole**](Auth_RolesApi.md#getrole) | **GET** /auth/roles/{role} | Get a single role
[**GetRoles**](Auth_RolesApi.md#getroles) | **GET** /auth/roles | List and search roles
[**GetUserRoles**](Auth_RolesApi.md#getuserroles) | **GET** /auth/users/{user_id}/roles | Get roles for a user
[**SetClientRoles**](Auth_RolesApi.md#setclientroles) | **PUT** /auth/clients/{client_key}/roles | Set roles for a client
[**SetPermissionsForRole**](Auth_RolesApi.md#setpermissionsforrole) | **PUT** /auth/roles/{role}/permissions | Set permissions for a role
[**SetUserRoles**](Auth_RolesApi.md#setuserroles) | **PUT** /auth/users/{user_id}/roles | Set roles for a user
[**UpdateRole**](Auth_RolesApi.md#updaterole) | **PUT** /auth/roles/{role} | Update a role


<a name="createrole"></a>
# **CreateRole**
> RoleResource CreateRole (RoleResource roleResource = null)

Create a new role

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var roleResource = new RoleResource(); // RoleResource | The role resource object (optional) 

            try
            {
                // Create a new role
                RoleResource result = apiInstance.CreateRole(roleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.CreateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleResource** | [**RoleResource**](RoleResource.md)| The role resource object | [optional] 

### Return type

[**RoleResource**](RoleResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterole"></a>
# **DeleteRole**
> void DeleteRole (string role, bool? force = null)

Delete a role

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var role = role_example;  // string | The role value
            var force = true;  // bool? | If true, removes role from users/clients (optional) 

            try
            {
                // Delete a role
                apiInstance.DeleteRole(role, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.DeleteRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **force** | **bool?**| If true, removes role from users/clients | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientroles"></a>
# **GetClientRoles**
> List<RoleResource> GetClientRoles (string clientKey)

Get roles for a client

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetClientRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var clientKey = clientKey_example;  // string | The client key

            try
            {
                // Get roles for a client
                List&lt;RoleResource&gt; result = apiInstance.GetClientRoles(clientKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.GetClientRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The client key | 

### Return type

[**List<RoleResource>**](RoleResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrole"></a>
# **GetRole**
> RoleResource GetRole (string role)

Get a single role

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var role = role_example;  // string | The role value

            try
            {
                // Get a single role
                RoleResource result = apiInstance.GetRole(role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.GetRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 

### Return type

[**RoleResource**](RoleResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> PageResourceRoleResource GetRoles (string filterName = null, string filterRole = null, int? size = null, int? page = null, string order = null)

List and search roles

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var filterName = filterName_example;  // string | Filter for roles that have a name starting with specified string (optional) 
            var filterRole = filterRole_example;  // string | Filter for roles that have a role starting with specified string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // List and search roles
                PageResourceRoleResource result = apiInstance.GetRoles(filterName, filterRole, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.GetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filter for roles that have a name starting with specified string | [optional] 
 **filterRole** | **string**| Filter for roles that have a role starting with specified string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceRoleResource**](PageResourceRoleResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserroles"></a>
# **GetUserRoles**
> List<RoleResource> GetUserRoles (int? userId)

Get roles for a user

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var userId = 56;  // int? | The user's id

            try
            {
                // Get roles for a user
                List&lt;RoleResource&gt; result = apiInstance.GetUserRoles(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.GetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 

### Return type

[**List<RoleResource>**](RoleResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setclientroles"></a>
# **SetClientRoles**
> ClientResource SetClientRoles (string clientKey, List<string> rolesList = null)

Set roles for a client

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetClientRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var clientKey = clientKey_example;  // string | The client key
            var rolesList = ;  // List<string> | The list of unique roles (optional) 

            try
            {
                // Set roles for a client
                ClientResource result = apiInstance.SetClientRoles(clientKey, rolesList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.SetClientRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The client key | 
 **rolesList** | **List&lt;string&gt;**| The list of unique roles | [optional] 

### Return type

[**ClientResource**](ClientResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpermissionsforrole"></a>
# **SetPermissionsForRole**
> RoleResource SetPermissionsForRole (string role, List<string> permissionsList = null)

Set permissions for a role

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetPermissionsForRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var role = role_example;  // string | The role value
            var permissionsList = ;  // List<string> | The list of unique permissions (optional) 

            try
            {
                // Set permissions for a role
                RoleResource result = apiInstance.SetPermissionsForRole(role, permissionsList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.SetPermissionsForRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **permissionsList** | **List&lt;string&gt;**| The list of unique permissions | [optional] 

### Return type

[**RoleResource**](RoleResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserroles"></a>
# **SetUserRoles**
> UserResource SetUserRoles (int? userId, List<string> rolesList = null)

Set roles for a user

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetUserRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var userId = 56;  // int? | The user's id
            var rolesList = ;  // List<string> | The list of unique roles (optional) 

            try
            {
                // Set roles for a user
                UserResource result = apiInstance.SetUserRoles(userId, rolesList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.SetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **rolesList** | **List&lt;string&gt;**| The list of unique roles | [optional] 

### Return type

[**UserResource**](UserResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterole"></a>
# **UpdateRole**
> RoleResource UpdateRole (string role, RoleResource roleResource = null)

Update a role

<b>Permissions Needed:</b> ROLES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Auth_RolesApi();
            var role = role_example;  // string | The role value
            var roleResource = new RoleResource(); // RoleResource | The role resource object (optional) 

            try
            {
                // Update a role
                RoleResource result = apiInstance.UpdateRole(role, roleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Auth_RolesApi.UpdateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **roleResource** | [**RoleResource**](RoleResource.md)| The role resource object | [optional] 

### Return type

[**RoleResource**](RoleResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

