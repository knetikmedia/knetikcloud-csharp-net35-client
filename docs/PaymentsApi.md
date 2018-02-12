# com.knetikcloud.Api.PaymentsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentMethod**](PaymentsApi.md#createpaymentmethod) | **POST** /users/{user_id}/payment-methods | Create a new payment method for a user
[**DeletePaymentMethod**](PaymentsApi.md#deletepaymentmethod) | **DELETE** /users/{user_id}/payment-methods/{id} | Delete an existing payment method for a user
[**GetPaymentMethod**](PaymentsApi.md#getpaymentmethod) | **GET** /users/{user_id}/payment-methods/{id} | Get a single payment method for a user
[**GetPaymentMethodType**](PaymentsApi.md#getpaymentmethodtype) | **GET** /payment/types/{id} | Get a single payment method type
[**GetPaymentMethodTypes**](PaymentsApi.md#getpaymentmethodtypes) | **GET** /payment/types | Get all payment method types
[**GetPaymentMethods**](PaymentsApi.md#getpaymentmethods) | **GET** /users/{user_id}/payment-methods | Get all payment methods for a user
[**PaymentAuthorization**](PaymentsApi.md#paymentauthorization) | **POST** /payment/authorizations | Authorize payment of an invoice for later capture
[**PaymentCapture**](PaymentsApi.md#paymentcapture) | **POST** /payment/authorizations/{id}/capture | Capture an existing invoice payment authorization
[**UpdatePaymentMethod**](PaymentsApi.md#updatepaymentmethod) | **PUT** /users/{user_id}/payment-methods/{id} | Update an existing payment method for a user


<a name="createpaymentmethod"></a>
# **CreatePaymentMethod**
> PaymentMethodResource CreatePaymentMethod (int? userId, PaymentMethodResource paymentMethod = null)

Create a new payment method for a user

<b>Permissions Needed:</b> PAYMENTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreatePaymentMethodExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being created
            var paymentMethod = new PaymentMethodResource(); // PaymentMethodResource | Payment method being created (optional) 

            try
            {
                // Create a new payment method for a user
                PaymentMethodResource result = apiInstance.CreatePaymentMethod(userId, paymentMethod);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreatePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being created | 
 **paymentMethod** | [**PaymentMethodResource**](PaymentMethodResource.md)| Payment method being created | [optional] 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaymentmethod"></a>
# **DeletePaymentMethod**
> void DeletePaymentMethod (int? userId, int? id)

Delete an existing payment method for a user

<b>Permissions Needed:</b> PAYMENTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeletePaymentMethodExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being updated
            var id = 56;  // int? | ID of the payment method being deleted

            try
            {
                // Delete an existing payment method for a user
                apiInstance.DeletePaymentMethod(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.DeletePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being updated | 
 **id** | **int?**| ID of the payment method being deleted | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentmethod"></a>
# **GetPaymentMethod**
> PaymentMethodResource GetPaymentMethod (int? userId, int? id)

Get a single payment method for a user

<b>Permissions Needed:</b> PAYMENTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPaymentMethodExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being retrieved
            var id = 56;  // int? | ID of the payment method being retrieved

            try
            {
                // Get a single payment method for a user
                PaymentMethodResource result = apiInstance.GetPaymentMethod(userId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being retrieved | 
 **id** | **int?**| ID of the payment method being retrieved | 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentmethodtype"></a>
# **GetPaymentMethodType**
> PaymentMethodTypeResource GetPaymentMethodType (int? id)

Get a single payment method type

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
    public class GetPaymentMethodTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var id = 56;  // int? | ID of the payment method type being retrieved

            try
            {
                // Get a single payment method type
                PaymentMethodTypeResource result = apiInstance.GetPaymentMethodType(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentMethodType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the payment method type being retrieved | 

### Return type

[**PaymentMethodTypeResource**](PaymentMethodTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentmethodtypes"></a>
# **GetPaymentMethodTypes**
> PageResourcePaymentMethodTypeResource GetPaymentMethodTypes (string filterName = null, int? size = null, int? page = null, string order = null)

Get all payment method types

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
    public class GetPaymentMethodTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var filterName = filterName_example;  // string | Filter for payment method types whose name matches a given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get all payment method types
                PageResourcePaymentMethodTypeResource result = apiInstance.GetPaymentMethodTypes(filterName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentMethodTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filter for payment method types whose name matches a given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourcePaymentMethodTypeResource**](PageResourcePaymentMethodTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentmethods"></a>
# **GetPaymentMethods**
> List<PaymentMethodResource> GetPaymentMethods (int? userId, string filterName = null, string filterPaymentType = null, int? filterPaymentMethodTypeId = null, string filterPaymentMethodTypeName = null, int? size = null, int? page = null, string order = null)

Get all payment methods for a user

<b>Permissions Needed:</b> PAYMENTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPaymentMethodsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment methods are being retrieved
            var filterName = filterName_example;  // string | Filter for payment methods whose name starts with a given string (optional) 
            var filterPaymentType = filterPaymentType_example;  // string | Filter for payment methods with a specific payment type (optional) 
            var filterPaymentMethodTypeId = 56;  // int? | Filter for payment methods with a specific payment method type by id (optional) 
            var filterPaymentMethodTypeName = filterPaymentMethodTypeName_example;  // string | Filter for payment methods whose payment method type name starts with a given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get all payment methods for a user
                List&lt;PaymentMethodResource&gt; result = apiInstance.GetPaymentMethods(userId, filterName, filterPaymentType, filterPaymentMethodTypeId, filterPaymentMethodTypeName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment methods are being retrieved | 
 **filterName** | **string**| Filter for payment methods whose name starts with a given string | [optional] 
 **filterPaymentType** | **string**| Filter for payment methods with a specific payment type | [optional] 
 **filterPaymentMethodTypeId** | **int?**| Filter for payment methods with a specific payment method type by id | [optional] 
 **filterPaymentMethodTypeName** | **string**| Filter for payment methods whose payment method type name starts with a given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**List<PaymentMethodResource>**](PaymentMethodResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentauthorization"></a>
# **PaymentAuthorization**
> PaymentAuthorizationResource PaymentAuthorization (PaymentAuthorizationResource request = null)

Authorize payment of an invoice for later capture

<b>Permissions Needed:</b> PAYMENTS_ADMIN or PAYMENTS_USER

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PaymentAuthorizationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var request = new PaymentAuthorizationResource(); // PaymentAuthorizationResource | Payment authorization request (optional) 

            try
            {
                // Authorize payment of an invoice for later capture
                PaymentAuthorizationResource result = apiInstance.PaymentAuthorization(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentAuthorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PaymentAuthorizationResource**](PaymentAuthorizationResource.md)| Payment authorization request | [optional] 

### Return type

[**PaymentAuthorizationResource**](PaymentAuthorizationResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentcapture"></a>
# **PaymentCapture**
> void PaymentCapture (int? id)

Capture an existing invoice payment authorization

<b>Permissions Needed:</b> PAYMENTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PaymentCaptureExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var id = 56;  // int? | ID of the payment authorization to capture

            try
            {
                // Capture an existing invoice payment authorization
                apiInstance.PaymentCapture(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentCapture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the payment authorization to capture | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentmethod"></a>
# **UpdatePaymentMethod**
> PaymentMethodResource UpdatePaymentMethod (int? userId, int? id, PaymentMethodResource paymentMethod = null)

Update an existing payment method for a user

<b>Permissions Needed:</b> PAYMENTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdatePaymentMethodExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var userId = 56;  // int? | ID of the user for whom the payment method is being updated
            var id = 56;  // int? | ID of the payment method being updated
            var paymentMethod = new PaymentMethodResource(); // PaymentMethodResource | The updated payment method data (optional) 

            try
            {
                // Update an existing payment method for a user
                PaymentMethodResource result = apiInstance.UpdatePaymentMethod(userId, id, paymentMethod);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdatePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user for whom the payment method is being updated | 
 **id** | **int?**| ID of the payment method being updated | 
 **paymentMethod** | [**PaymentMethodResource**](PaymentMethodResource.md)| The updated payment method data | [optional] 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

