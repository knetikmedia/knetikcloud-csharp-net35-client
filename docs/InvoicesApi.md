# com.knetikcloud.Api.InvoicesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoice**](InvoicesApi.md#createinvoice) | **POST** /invoices | Create an invoice
[**GetFulFillmentStatuses**](InvoicesApi.md#getfulfillmentstatuses) | **GET** /invoices/fulfillment-statuses | Lists available fulfillment statuses
[**GetInvoice**](InvoicesApi.md#getinvoice) | **GET** /invoices/{id} | Retrieve an invoice
[**GetInvoiceLogs**](InvoicesApi.md#getinvoicelogs) | **GET** /invoices/{id}/logs | List invoice logs
[**GetInvoices**](InvoicesApi.md#getinvoices) | **GET** /invoices | Retrieve invoices
[**GetPaymentStatuses**](InvoicesApi.md#getpaymentstatuses) | **GET** /invoices/payment-statuses | Lists available payment statuses
[**PayInvoice**](InvoicesApi.md#payinvoice) | **POST** /invoices/{id}/payments | Trigger payment of an invoice
[**SetExternalRef**](InvoicesApi.md#setexternalref) | **PUT** /invoices/{id}/external-ref | Set the external reference of an invoice
[**SetInvoiceItemFulfillmentStatus**](InvoicesApi.md#setinvoiceitemfulfillmentstatus) | **PUT** /invoices/{id}/items/{sku}/fulfillment-status | Set the fulfillment status of an invoice item
[**SetOrderNotes**](InvoicesApi.md#setordernotes) | **PUT** /invoices/{id}/order-notes | Set the order notes of an invoice
[**SetPaymentStatus**](InvoicesApi.md#setpaymentstatus) | **PUT** /invoices/{id}/payment-status | Set the payment status of an invoice
[**UpdateBillingInfo**](InvoicesApi.md#updatebillinginfo) | **PUT** /invoices/{id}/billing-address | Set or update billing info


<a name="createinvoice"></a>
# **CreateInvoice**
> List<InvoiceResource> CreateInvoice (InvoiceCreateRequest req = null)

Create an invoice

Create an invoice(s) by providing a cart GUID. Note that there may be multiple invoices created, one per vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var req = new InvoiceCreateRequest(); // InvoiceCreateRequest | Invoice to be created (optional) 

            try
            {
                // Create an invoice
                List&lt;InvoiceResource&gt; result = apiInstance.CreateInvoice(req);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **req** | [**InvoiceCreateRequest**](InvoiceCreateRequest.md)| Invoice to be created | [optional] 

### Return type

[**List<InvoiceResource>**](InvoiceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentstatuses"></a>
# **GetFulFillmentStatuses**
> List<string> GetFulFillmentStatuses ()

Lists available fulfillment statuses

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetFulFillmentStatusesExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();

            try
            {
                // Lists available fulfillment statuses
                List&lt;string&gt; result = apiInstance.GetFulFillmentStatuses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetFulFillmentStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoice"></a>
# **GetInvoice**
> InvoiceResource GetInvoice (int? id)

Retrieve an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice

            try
            {
                // Retrieve an invoice
                InvoiceResource result = apiInstance.GetInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicelogs"></a>
# **GetInvoiceLogs**
> PageResourceInvoiceLogEntry GetInvoiceLogs (int? id, int? size = null, int? page = null)

List invoice logs

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInvoiceLogsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List invoice logs
                PageResourceInvoiceLogEntry result = apiInstance.GetInvoiceLogs(id, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceInvoiceLogEntry**](PageResourceInvoiceLogEntry.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoices"></a>
# **GetInvoices**
> PageResourceInvoiceResource GetInvoices (int? filterUser = null, string filterEmail = null, string filterFulfillmentStatus = null, string filterPaymentStatus = null, string filterItemName = null, string filterExternalRef = null, string filterCreatedDate = null, string filterVendorIds = null, string filterCurrency = null, string filterShippingStateName = null, string filterShippingCountryName = null, float? filterShipping = null, string filterVendorName = null, string filterSku = null, int? size = null, int? page = null, string order = null)

Retrieve invoices

Without INVOICES_ADMIN permission the results are automatically filtered for only the logged in user's invoices. It is recomended however that filter_user be added to avoid issues for admin users accidentally getting additional invoices.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var filterUser = 56;  // int? | The id of a user to get invoices for. Automtically added if not being called with admin permissions. (optional) 
            var filterEmail = filterEmail_example;  // string | Filters invoices by customer's email. Admins only. (optional) 
            var filterFulfillmentStatus = filterFulfillmentStatus_example;  // string | Filters invoices by fulfillment status type. Can be a comma separated list of statuses (optional) 
            var filterPaymentStatus = filterPaymentStatus_example;  // string | Filters invoices by payment status type. Can be a comma separated list of statuses (optional) 
            var filterItemName = filterItemName_example;  // string | Filters invoices by item name containing the given string (optional) 
            var filterExternalRef = filterExternalRef_example;  // string | Filters invoices by external reference. (optional) 
            var filterCreatedDate = filterCreatedDate_example;  // string | Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date=OP,ts&... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date=GT,1452154258,LT,1554254874 (optional) 
            var filterVendorIds = filterVendorIds_example;  // string | Filters invoices for ones from one of the vendors whose id is in the given comma separated list (optional) 
            var filterCurrency = filterCurrency_example;  // string | Filters invoices by currency. ISO3 currency code (optional) 
            var filterShippingStateName = filterShippingStateName_example;  // string | Filters invoices by shipping address: Exact match state name (optional) 
            var filterShippingCountryName = filterShippingCountryName_example;  // string | Filters invoices by shipping address: Exact match country name (optional) 
            var filterShipping = 3.4;  // float? | Filters invoices by shipping price (optional) 
            var filterVendorName = filterVendorName_example;  // string | Filters invoices by vendor name starting with given string (optional) 
            var filterSku = filterSku_example;  // string | Filters invoices by item sku (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // Retrieve invoices
                PageResourceInvoiceResource result = apiInstance.GetInvoices(filterUser, filterEmail, filterFulfillmentStatus, filterPaymentStatus, filterItemName, filterExternalRef, filterCreatedDate, filterVendorIds, filterCurrency, filterShippingStateName, filterShippingCountryName, filterShipping, filterVendorName, filterSku, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterUser** | **int?**| The id of a user to get invoices for. Automtically added if not being called with admin permissions. | [optional] 
 **filterEmail** | **string**| Filters invoices by customer&#39;s email. Admins only. | [optional] 
 **filterFulfillmentStatus** | **string**| Filters invoices by fulfillment status type. Can be a comma separated list of statuses | [optional] 
 **filterPaymentStatus** | **string**| Filters invoices by payment status type. Can be a comma separated list of statuses | [optional] 
 **filterItemName** | **string**| Filters invoices by item name containing the given string | [optional] 
 **filterExternalRef** | **string**| Filters invoices by external reference. | [optional] 
 **filterCreatedDate** | **string**| Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date&#x3D;GT,1452154258,LT,1554254874 | [optional] 
 **filterVendorIds** | **string**| Filters invoices for ones from one of the vendors whose id is in the given comma separated list | [optional] 
 **filterCurrency** | **string**| Filters invoices by currency. ISO3 currency code | [optional] 
 **filterShippingStateName** | **string**| Filters invoices by shipping address: Exact match state name | [optional] 
 **filterShippingCountryName** | **string**| Filters invoices by shipping address: Exact match country name | [optional] 
 **filterShipping** | **float?**| Filters invoices by shipping price | [optional] 
 **filterVendorName** | **string**| Filters invoices by vendor name starting with given string | [optional] 
 **filterSku** | **string**| Filters invoices by item sku | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**PageResourceInvoiceResource**](PageResourceInvoiceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentstatuses"></a>
# **GetPaymentStatuses**
> List<string> GetPaymentStatuses ()

Lists available payment statuses

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPaymentStatusesExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();

            try
            {
                // Lists available payment statuses
                List&lt;string&gt; result = apiInstance.GetPaymentStatuses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetPaymentStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payinvoice"></a>
# **PayInvoice**
> void PayInvoice (int? id, PayBySavedMethodRequest request = null)

Trigger payment of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PayInvoiceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var request = new PayBySavedMethodRequest(); // PayBySavedMethodRequest | Payment info (optional) 

            try
            {
                // Trigger payment of an invoice
                apiInstance.PayInvoice(id, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.PayInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **request** | [**PayBySavedMethodRequest**](PayBySavedMethodRequest.md)| Payment info | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setexternalref"></a>
# **SetExternalRef**
> void SetExternalRef (int? id, string externalRef = null)

Set the external reference of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetExternalRefExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var externalRef = externalRef_example;  // string | External reference info (optional) 

            try
            {
                // Set the external reference of an invoice
                apiInstance.SetExternalRef(id, externalRef);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetExternalRef: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **externalRef** | **string**| External reference info | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setinvoiceitemfulfillmentstatus"></a>
# **SetInvoiceItemFulfillmentStatus**
> void SetInvoiceItemFulfillmentStatus (int? id, string sku, string status)

Set the fulfillment status of an invoice item

This allows external fulfillment systems to report success or failure. Fulfillment status changes are restricted by a specific flow determining which status can lead to which.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetInvoiceItemFulfillmentStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var sku = sku_example;  // string | The sku of an item in the invoice
            var status = status_example;  // string | The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  'unfulfilled', 'fulfilled', 'not fulfillable', 'failed', 'processing', 'failed_permanent', 'delayed'

            try
            {
                // Set the fulfillment status of an invoice item
                apiInstance.SetInvoiceItemFulfillmentStatus(id, sku, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetInvoiceItemFulfillmentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **sku** | **string**| The sku of an item in the invoice | 
 **status** | **string**| The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  &#39;unfulfilled&#39;, &#39;fulfilled&#39;, &#39;not fulfillable&#39;, &#39;failed&#39;, &#39;processing&#39;, &#39;failed_permanent&#39;, &#39;delayed&#39; | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setordernotes"></a>
# **SetOrderNotes**
> void SetOrderNotes (int? id, string orderNotes = null)

Set the order notes of an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetOrderNotesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var orderNotes = orderNotes_example;  // string | Payment status info (optional) 

            try
            {
                // Set the order notes of an invoice
                apiInstance.SetOrderNotes(id, orderNotes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetOrderNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **orderNotes** | **string**| Payment status info | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpaymentstatus"></a>
# **SetPaymentStatus**
> void SetPaymentStatus (int? id, InvoicePaymentStatusRequest request = null)

Set the payment status of an invoice

This may trigger fulfillment if setting the status to 'paid'. This is mainly intended to support external payment systems that cannot be incorporated into the payment method system. Payment status changes are restricted by a specific flow determining which status can lead to which.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetPaymentStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var request = new InvoicePaymentStatusRequest(); // InvoicePaymentStatusRequest | Payment status info (optional) 

            try
            {
                // Set the payment status of an invoice
                apiInstance.SetPaymentStatus(id, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetPaymentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **request** | [**InvoicePaymentStatusRequest**](InvoicePaymentStatusRequest.md)| Payment status info | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillinginfo"></a>
# **UpdateBillingInfo**
> void UpdateBillingInfo (int? id, AddressResource billingInfoRequest = null)

Set or update billing info

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateBillingInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var billingInfoRequest = new AddressResource(); // AddressResource | Address info (optional) 

            try
            {
                // Set or update billing info
                apiInstance.UpdateBillingInfo(id, billingInfoRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateBillingInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **billingInfoRequest** | [**AddressResource**](AddressResource.md)| Address info | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

