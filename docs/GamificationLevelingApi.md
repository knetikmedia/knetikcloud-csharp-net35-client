# com.knetikcloud.Api.GamificationLevelingApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLevel**](GamificationLevelingApi.md#createlevel) | **POST** /leveling | Create a level schema
[**DeleteLevel**](GamificationLevelingApi.md#deletelevel) | **DELETE** /leveling/{name} | Delete a level
[**GetLevel**](GamificationLevelingApi.md#getlevel) | **GET** /leveling/{name} | Retrieve a level
[**GetLevelTriggers**](GamificationLevelingApi.md#getleveltriggers) | **GET** /leveling/triggers | Get the list of triggers that can be used to trigger a leveling progress update
[**GetLevels**](GamificationLevelingApi.md#getlevels) | **GET** /leveling | List and search levels
[**GetUserLevel**](GamificationLevelingApi.md#getuserlevel) | **GET** /users/{user_id}/leveling/{name} | Get a user&#39;s progress for a given level schema
[**GetUserLevels**](GamificationLevelingApi.md#getuserlevels) | **GET** /users/{user_id}/leveling | Get a user&#39;s progress for all level schemas
[**IncrementProgress**](GamificationLevelingApi.md#incrementprogress) | **POST** /users/{user_id}/leveling/{name}/progress | Update or create a leveling progress record for a user
[**SetProgress**](GamificationLevelingApi.md#setprogress) | **PUT** /users/{user_id}/leveling/{name}/progress | Set leveling progress for a user
[**UpdateLevel**](GamificationLevelingApi.md#updatelevel) | **PUT** /leveling/{name} | Update a level


<a name="createlevel"></a>
# **CreateLevel**
> LevelingResource CreateLevel (LevelingResource level = null)

Create a level schema

<b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateLevelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var level = new LevelingResource(); // LevelingResource | The level schema definition (optional) 

            try
            {
                // Create a level schema
                LevelingResource result = apiInstance.CreateLevel(level);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.CreateLevel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **level** | [**LevelingResource**](LevelingResource.md)| The level schema definition | [optional] 

### Return type

[**LevelingResource**](LevelingResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelevel"></a>
# **DeleteLevel**
> void DeleteLevel (string name)

Delete a level

<b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteLevelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var name = name_example;  // string | The level schema name

            try
            {
                // Delete a level
                apiInstance.DeleteLevel(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.DeleteLevel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The level schema name | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlevel"></a>
# **GetLevel**
> LevelingResource GetLevel (string name)

Retrieve a level

<b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetLevelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var name = name_example;  // string | The level schema name

            try
            {
                // Retrieve a level
                LevelingResource result = apiInstance.GetLevel(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetLevel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The level schema name | 

### Return type

[**LevelingResource**](LevelingResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getleveltriggers"></a>
# **GetLevelTriggers**
> List<BreTriggerResource> GetLevelTriggers ()

Get the list of triggers that can be used to trigger a leveling progress update

<b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetLevelTriggersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();

            try
            {
                // Get the list of triggers that can be used to trigger a leveling progress update
                List&lt;BreTriggerResource&gt; result = apiInstance.GetLevelTriggers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetLevelTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BreTriggerResource>**](BreTriggerResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlevels"></a>
# **GetLevels**
> PageResourceLevelingResource GetLevels (string filterName = null, int? size = null, int? page = null, string order = null)

List and search levels

Get a list of levels schemas with optional filtering. <br><br><b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetLevelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var filterName = filterName_example;  // string | Filter for level schemas whose name contains a given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search levels
                PageResourceLevelingResource result = apiInstance.GetLevels(filterName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetLevels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filter for level schemas whose name contains a given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceLevelingResource**](PageResourceLevelingResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlevel"></a>
# **GetUserLevel**
> UserLevelingResource GetUserLevel (string userId, string name)

Get a user's progress for a given level schema

<b>Permissions Needed:</b> LEVELING_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserLevelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var userId = userId_example;  // string | The id of the user or 'me'
            var name = name_example;  // string | The level schema name

            try
            {
                // Get a user's progress for a given level schema
                UserLevelingResource result = apiInstance.GetUserLevel(userId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetUserLevel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; | 
 **name** | **string**| The level schema name | 

### Return type

[**UserLevelingResource**](UserLevelingResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlevels"></a>
# **GetUserLevels**
> PageResourceUserLevelingResource GetUserLevels (string userId, string filterName = null, int? size = null, int? page = null, string order = null)

Get a user's progress for all level schemas

Filtering and sorting is based on the LevelingResource object, not the UserLevelingResource that is returned here. <br><br><b>Permissions Needed:</b> LEVELING_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserLevelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var userId = userId_example;  // string | The id of the user or 'me'
            var filterName = filterName_example;  // string | Filter for level schemas whose name contains a given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // Get a user's progress for all level schemas
                PageResourceUserLevelingResource result = apiInstance.GetUserLevels(userId, filterName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.GetUserLevels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; | 
 **filterName** | **string**| Filter for level schemas whose name contains a given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceUserLevelingResource**](PageResourceUserLevelingResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incrementprogress"></a>
# **IncrementProgress**
> void IncrementProgress (int? userId, string name, IntWrapper progress = null)

Update or create a leveling progress record for a user

If no progress record yet exists for the user, it will be created. Otherwise the provided value will be added to it. May be negative. If progress meets or exceeds the level's max_value it will be marked as earned and a BRE event will be triggered for the <code>BreAchievementEarnedTrigger</code>. <br><br><b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class IncrementProgressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var userId = 56;  // int? | The id of the user
            var name = name_example;  // string | The level schema name
            var progress = new IntWrapper(); // IntWrapper | The amount of progress to add (optional) 

            try
            {
                // Update or create a leveling progress record for a user
                apiInstance.IncrementProgress(userId, name, progress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.IncrementProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **name** | **string**| The level schema name | 
 **progress** | [**IntWrapper**](IntWrapper.md)| The amount of progress to add | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setprogress"></a>
# **SetProgress**
> void SetProgress (int? userId, string name, IntWrapper progress = null)

Set leveling progress for a user

If no progress record yet exists for the user, it will be created. Otherwise it will be updated to the provided value. If progress meets or exceeds the level's max_value it will be marked as earned and a BRE event will be triggered for the <code>BreAchievementEarnedTrigger</code>. <br><br><b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetProgressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var userId = 56;  // int? | The id of the user
            var name = name_example;  // string | The level schema name
            var progress = new IntWrapper(); // IntWrapper | The new progress amount (optional) 

            try
            {
                // Set leveling progress for a user
                apiInstance.SetProgress(userId, name, progress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.SetProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **name** | **string**| The level schema name | 
 **progress** | [**IntWrapper**](IntWrapper.md)| The new progress amount | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelevel"></a>
# **UpdateLevel**
> LevelingResource UpdateLevel (string name, LevelingResource newLevel = null)

Update a level

<b>Permissions Needed:</b> LEVELING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateLevelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLevelingApi();
            var name = name_example;  // string | The level schema name
            var newLevel = new LevelingResource(); // LevelingResource | The level schema definition (optional) 

            try
            {
                // Update a level
                LevelingResource result = apiInstance.UpdateLevel(name, newLevel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLevelingApi.UpdateLevel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The level schema name | 
 **newLevel** | [**LevelingResource**](LevelingResource.md)| The level schema definition | [optional] 

### Return type

[**LevelingResource**](LevelingResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

