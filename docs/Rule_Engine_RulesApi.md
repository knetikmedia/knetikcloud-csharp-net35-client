# com.knetikcloud.Api.Rule_Engine_RulesApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBRERule**](Rule_Engine_RulesApi.md#createbrerule) | **POST** /bre/rules | Create a rule
[**DeleteBRERule**](Rule_Engine_RulesApi.md#deletebrerule) | **DELETE** /bre/rules/{id} | Delete a rule
[**GetBREExpressionAsString**](Rule_Engine_RulesApi.md#getbreexpressionasstring) | **POST** /bre/rules/expression-as-string | Returns a string representation of the provided expression
[**GetBRERule**](Rule_Engine_RulesApi.md#getbrerule) | **GET** /bre/rules/{id} | Get a single rule
[**GetBRERules**](Rule_Engine_RulesApi.md#getbrerules) | **GET** /bre/rules | List rules
[**SetBRERule**](Rule_Engine_RulesApi.md#setbrerule) | **PUT** /bre/rules/{id}/enabled | Enable or disable a rule
[**UpdateBRERule**](Rule_Engine_RulesApi.md#updatebrerule) | **PUT** /bre/rules/{id} | Update a rule


<a name="createbrerule"></a>
# **CreateBRERule**
> BreRule CreateBRERule (BreRule breRule = null)

Create a rule

Rules define which actions to run when a given event verifies the specified condition. Full list of predicates and other type of expressions can be found at GET /bre/expressions/. <br><br><b>Permissions Needed:</b> BRE_RULE_ENGINE_RULES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateBRERuleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_RulesApi();
            var breRule = new BreRule(); // BreRule | The BRE rule object (optional) 

            try
            {
                // Create a rule
                BreRule result = apiInstance.CreateBRERule(breRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_RulesApi.CreateBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breRule** | [**BreRule**](BreRule.md)| The BRE rule object | [optional] 

### Return type

[**BreRule**](BreRule.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrerule"></a>
# **DeleteBRERule**
> void DeleteBRERule (string id)

Delete a rule

May fail if there are existing rules against it. Cannot delete core rules. <br><br><b>Permissions Needed:</b> BRE_RULE_ENGINE_RULES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteBRERuleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_RulesApi();
            var id = id_example;  // string | The id of the rule

            try
            {
                // Delete a rule
                apiInstance.DeleteBRERule(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_RulesApi.DeleteBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreexpressionasstring"></a>
# **GetBREExpressionAsString**
> string GetBREExpressionAsString (Expressionobject expression = null)

Returns a string representation of the provided expression

<b>Permissions Needed:</b> BRE_RULE_ENGINE_RULES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREExpressionAsStringExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_RulesApi();
            var expression = new Expressionobject(); // Expressionobject | The expression (optional) 

            try
            {
                // Returns a string representation of the provided expression
                string result = apiInstance.GetBREExpressionAsString(expression);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_RulesApi.GetBREExpressionAsString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expression** | [**Expressionobject**](Expressionobject.md)| The expression | [optional] 

### Return type

**string**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrerule"></a>
# **GetBRERule**
> BreRule GetBRERule (string id)

Get a single rule

<b>Permissions Needed:</b> BRE_RULE_ENGINE_RULES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBRERuleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_RulesApi();
            var id = id_example;  // string | The id of the rule

            try
            {
                // Get a single rule
                BreRule result = apiInstance.GetBRERule(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_RulesApi.GetBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 

### Return type

[**BreRule**](BreRule.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrerules"></a>
# **GetBRERules**
> PageResourceBreRule GetBRERules (string filterName = null, bool? filterEnabled = null, bool? filterSystem = null, string filterTrigger = null, string filterAction = null, string filterCondition = null, int? size = null, int? page = null)

List rules

<b>Permissions Needed:</b> BRE_RULE_ENGINE_RULES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBRERulesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_RulesApi();
            var filterName = filterName_example;  // string | Filter for rules containing the given name (optional) 
            var filterEnabled = true;  // bool? | Filter for rules by active status, null for both (optional)  (default to null)
            var filterSystem = true;  // bool? | Filter for rules that are system rules when true, or not when false. Leave off for both mixed (optional) 
            var filterTrigger = filterTrigger_example;  // string | Filter for rules that are for the trigger with the given name (optional) 
            var filterAction = filterAction_example;  // string | Filter for rules that use the action with the given name (optional) 
            var filterCondition = filterCondition_example;  // string | Filter for rules that have a condition containing the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List rules
                PageResourceBreRule result = apiInstance.GetBRERules(filterName, filterEnabled, filterSystem, filterTrigger, filterAction, filterCondition, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_RulesApi.GetBRERules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filter for rules containing the given name | [optional] 
 **filterEnabled** | **bool?**| Filter for rules by active status, null for both | [optional] [default to null]
 **filterSystem** | **bool?**| Filter for rules that are system rules when true, or not when false. Leave off for both mixed | [optional] 
 **filterTrigger** | **string**| Filter for rules that are for the trigger with the given name | [optional] 
 **filterAction** | **string**| Filter for rules that use the action with the given name | [optional] 
 **filterCondition** | **string**| Filter for rules that have a condition containing the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceBreRule**](PageResourceBreRule.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbrerule"></a>
# **SetBRERule**
> void SetBRERule (string id, BooleanResource enabled = null)

Enable or disable a rule

This is helpful for turning off systems rules which cannot be deleted or modified otherwise. <br><br><b>Permissions Needed:</b> BRE_RULE_ENGINE_RULES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetBRERuleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_RulesApi();
            var id = id_example;  // string | The id of the rule
            var enabled = new BooleanResource(); // BooleanResource | The boolean value (optional) 

            try
            {
                // Enable or disable a rule
                apiInstance.SetBRERule(id, enabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_RulesApi.SetBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 
 **enabled** | [**BooleanResource**](BooleanResource.md)| The boolean value | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebrerule"></a>
# **UpdateBRERule**
> BreRule UpdateBRERule (string id, BreRule breRule = null)

Update a rule

Cannot update system rules. <br><br><b>Permissions Needed:</b> BRE_RULE_ENGINE_RULES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateBRERuleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_RulesApi();
            var id = id_example;  // string | The id of the rule
            var breRule = new BreRule(); // BreRule | The BRE rule object (optional) 

            try
            {
                // Update a rule
                BreRule result = apiInstance.UpdateBRERule(id, breRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_RulesApi.UpdateBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 
 **breRule** | [**BreRule**](BreRule.md)| The BRE rule object | [optional] 

### Return type

[**BreRule**](BreRule.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

