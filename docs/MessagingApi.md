# com.knetikcloud.Api.MessagingApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendRawEmail**](MessagingApi.md#sendrawemail) | **POST** /messaging/raw-email | Send a raw email to one or more users
[**SendRawPush**](MessagingApi.md#sendrawpush) | **POST** /messaging/raw-push | Send a raw push notification
[**SendRawSMS**](MessagingApi.md#sendrawsms) | **POST** /messaging/raw-sms | Send a raw SMS
[**SendTemplatedEmail**](MessagingApi.md#sendtemplatedemail) | **POST** /messaging/templated-email | Send a templated email to one or more users
[**SendTemplatedPush**](MessagingApi.md#sendtemplatedpush) | **POST** /messaging/templated-push | Send a templated push notification
[**SendTemplatedSMS**](MessagingApi.md#sendtemplatedsms) | **POST** /messaging/templated-sms | Send a new templated SMS


<a name="sendrawemail"></a>
# **SendRawEmail**
> void SendRawEmail (RawEmailResource rawEmailResource = null)

Send a raw email to one or more users

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendRawEmailExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawEmailResource = new RawEmailResource(); // RawEmailResource | The new raw email to be sent (optional) 

            try
            {
                // Send a raw email to one or more users
                apiInstance.SendRawEmail(rawEmailResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawEmailResource** | [**RawEmailResource**](RawEmailResource.md)| The new raw email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawpush"></a>
# **SendRawPush**
> void SendRawPush (RawPushResource rawPushResource = null)

Send a raw push notification

Sends a raw push notification message to one or more users. User's without registered mobile device for the application will be skipped.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendRawPushExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawPushResource = new RawPushResource(); // RawPushResource | The new raw push notification to be sent (optional) 

            try
            {
                // Send a raw push notification
                apiInstance.SendRawPush(rawPushResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawPush: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawPushResource** | [**RawPushResource**](RawPushResource.md)| The new raw push notification to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawsms"></a>
# **SendRawSMS**
> void SendRawSMS (RawSMSResource rawSMSResource = null)

Send a raw SMS

Sends a raw SMS text message to one or more users. User's without registered mobile numbers will be skipped.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendRawSMSExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawSMSResource = new RawSMSResource(); // RawSMSResource | The new raw SMS to be sent (optional) 

            try
            {
                // Send a raw SMS
                apiInstance.SendRawSMS(rawSMSResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawSMS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawSMSResource** | [**RawSMSResource**](RawSMSResource.md)| The new raw SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedemail"></a>
# **SendTemplatedEmail**
> void SendTemplatedEmail (TemplateEmailResource messageResource = null)

Send a templated email to one or more users

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendTemplatedEmailExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageResource = new TemplateEmailResource(); // TemplateEmailResource | The new template email to be sent (optional) 

            try
            {
                // Send a templated email to one or more users
                apiInstance.SendTemplatedEmail(messageResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendTemplatedEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageResource** | [**TemplateEmailResource**](TemplateEmailResource.md)| The new template email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedpush"></a>
# **SendTemplatedPush**
> void SendTemplatedPush (TemplatePushResource templatePushResource = null)

Send a templated push notification

Sends a templated push notification message to one or more users. User's without registered mobile device for the application will be skipped.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendTemplatedPushExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var templatePushResource = new TemplatePushResource(); // TemplatePushResource | The new templated push notification to be sent (optional) 

            try
            {
                // Send a templated push notification
                apiInstance.SendTemplatedPush(templatePushResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendTemplatedPush: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templatePushResource** | [**TemplatePushResource**](TemplatePushResource.md)| The new templated push notification to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedsms"></a>
# **SendTemplatedSMS**
> void SendTemplatedSMS (TemplateSMSResource templateSMSResource = null)

Send a new templated SMS

Sends a templated SMS text message to one or more users. User's without registered mobile numbers will be skipped.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendTemplatedSMSExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var templateSMSResource = new TemplateSMSResource(); // TemplateSMSResource | The new template SMS to be sent (optional) 

            try
            {
                // Send a new templated SMS
                apiInstance.SendTemplatedSMS(templateSMSResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendTemplatedSMS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateSMSResource** | [**TemplateSMSResource**](TemplateSMSResource.md)| The new template SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

