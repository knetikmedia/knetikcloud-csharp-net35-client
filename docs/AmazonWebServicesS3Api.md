# com.knetikcloud.Api.AmazonWebServicesS3Api

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDownloadURL**](AmazonWebServicesS3Api.md#getdownloadurl) | **GET** /amazon/s3/downloadurl | Get a temporary signed S3 URL for download
[**GetSignedS3URL**](AmazonWebServicesS3Api.md#getsigneds3url) | **GET** /amazon/s3/signedposturl | Get a signed S3 URL for upload


<a name="getdownloadurl"></a>
# **GetDownloadURL**
> string GetDownloadURL (string bucket = null, string path = null, int? expiration = null)

Get a temporary signed S3 URL for download

To give access to files in your own S3 account, you will need to grant KnetikcCloud access to the file by adjusting your bucket policy accordingly. See S3 documentation for details.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDownloadURLExample
    {
        public void main()
        {
            var apiInstance = new AmazonWebServicesS3Api();
            var bucket = bucket_example;  // string | S3 bucket name (optional) 
            var path = path_example;  // string | The path to the file relative the bucket (the s3 object key) (optional) 
            var expiration = 56;  // int? | The number of seconds this URL will be valid. Default to 60 (optional)  (default to 60)

            try
            {
                // Get a temporary signed S3 URL for download
                string result = apiInstance.GetDownloadURL(bucket, path, expiration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonWebServicesS3Api.GetDownloadURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bucket** | **string**| S3 bucket name | [optional] 
 **path** | **string**| The path to the file relative the bucket (the s3 object key) | [optional] 
 **expiration** | **int?**| The number of seconds this URL will be valid. Default to 60 | [optional] [default to 60]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsigneds3url"></a>
# **GetSignedS3URL**
> AmazonS3Activity GetSignedS3URL (string filename = null, string contentType = null)

Get a signed S3 URL for upload

Requires the file name and file content type (i.e., 'video/mpeg'). Make a PUT to the resulting url to upload the file and use the cdn_url to retrieve it after.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetSignedS3URLExample
    {
        public void main()
        {
            var apiInstance = new AmazonWebServicesS3Api();
            var filename = filename_example;  // string | The file name (optional) 
            var contentType = contentType_example;  // string | The content type (optional) 

            try
            {
                // Get a signed S3 URL for upload
                AmazonS3Activity result = apiInstance.GetSignedS3URL(filename, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonWebServicesS3Api.GetSignedS3URL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**| The file name | [optional] 
 **contentType** | **string**| The content type | [optional] 

### Return type

[**AmazonS3Activity**](AmazonS3Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

