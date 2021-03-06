/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace com.knetikcloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAmazon_Web_Services_S3Api : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a temporary signed S3 URL for download
        /// </summary>
        /// <remarks>
        /// To give access to files in your own S3 account, you will need to grant KnetikcCloud access to the file by adjusting your bucket policy accordingly. See S3 documentation for details. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bucket">S3 bucket name (optional)</param>
        /// <param name="path">The path to the file relative to the bucket (the s3 object key) (optional)</param>
        /// <param name="expiration">The number of seconds this URL will be valid. Default to 60 (optional, default to 60)</param>
        /// <returns>string</returns>
        string GetDownloadURL (string bucket = null, string path = null, int? expiration = null);

        /// <summary>
        /// Get a temporary signed S3 URL for download
        /// </summary>
        /// <remarks>
        /// To give access to files in your own S3 account, you will need to grant KnetikcCloud access to the file by adjusting your bucket policy accordingly. See S3 documentation for details. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bucket">S3 bucket name (optional)</param>
        /// <param name="path">The path to the file relative to the bucket (the s3 object key) (optional)</param>
        /// <param name="expiration">The number of seconds this URL will be valid. Default to 60 (optional, default to 60)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetDownloadURLWithHttpInfo (string bucket = null, string path = null, int? expiration = null);
        /// <summary>
        /// Get a signed S3 URL for upload
        /// </summary>
        /// <remarks>
        /// Requires the file name and file content type (i.e., &#39;video/mpeg&#39;). Make a PUT to the resulting url to upload the file and use the cdn_url to retrieve it after. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_USER or S3_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>AmazonS3Activity</returns>
        AmazonS3Activity GetSignedS3URL (string filename = null, string contentType = null);

        /// <summary>
        /// Get a signed S3 URL for upload
        /// </summary>
        /// <remarks>
        /// Requires the file name and file content type (i.e., &#39;video/mpeg&#39;). Make a PUT to the resulting url to upload the file and use the cdn_url to retrieve it after. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_USER or S3_ADMIN
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>ApiResponse of AmazonS3Activity</returns>
        ApiResponse<AmazonS3Activity> GetSignedS3URLWithHttpInfo (string filename = null, string contentType = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Amazon_Web_Services_S3Api : IAmazon_Web_Services_S3Api
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Amazon_Web_Services_S3Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Amazon_Web_Services_S3Api(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amazon_Web_Services_S3Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public Amazon_Web_Services_S3Api(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.knetikcloud.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new Dictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a temporary signed S3 URL for download To give access to files in your own S3 account, you will need to grant KnetikcCloud access to the file by adjusting your bucket policy accordingly. See S3 documentation for details. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bucket">S3 bucket name (optional)</param>
        /// <param name="path">The path to the file relative to the bucket (the s3 object key) (optional)</param>
        /// <param name="expiration">The number of seconds this URL will be valid. Default to 60 (optional, default to 60)</param>
        /// <returns>string</returns>
        public string GetDownloadURL (string bucket = null, string path = null, int? expiration = null)
        {
             ApiResponse<string> localVarResponse = GetDownloadURLWithHttpInfo(bucket, path, expiration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a temporary signed S3 URL for download To give access to files in your own S3 account, you will need to grant KnetikcCloud access to the file by adjusting your bucket policy accordingly. See S3 documentation for details. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bucket">S3 bucket name (optional)</param>
        /// <param name="path">The path to the file relative to the bucket (the s3 object key) (optional)</param>
        /// <param name="expiration">The number of seconds this URL will be valid. Default to 60 (optional, default to 60)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetDownloadURLWithHttpInfo (string bucket = null, string path = null, int? expiration = null)
        {

            var localVarPath = "/amazon/s3/downloadurl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (bucket != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "bucket", bucket)); // query parameter
            if (path != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "path", path)); // query parameter
            if (expiration != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration", expiration)); // query parameter

            // authentication (oauth2_client_credentials_grant) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_password_grant) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDownloadURL", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Get a signed S3 URL for upload Requires the file name and file content type (i.e., &#39;video/mpeg&#39;). Make a PUT to the resulting url to upload the file and use the cdn_url to retrieve it after. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_USER or S3_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>AmazonS3Activity</returns>
        public AmazonS3Activity GetSignedS3URL (string filename = null, string contentType = null)
        {
             ApiResponse<AmazonS3Activity> localVarResponse = GetSignedS3URLWithHttpInfo(filename, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a signed S3 URL for upload Requires the file name and file content type (i.e., &#39;video/mpeg&#39;). Make a PUT to the resulting url to upload the file and use the cdn_url to retrieve it after. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_USER or S3_ADMIN
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename">The file name (optional)</param>
        /// <param name="contentType">The content type (optional)</param>
        /// <returns>ApiResponse of AmazonS3Activity</returns>
        public ApiResponse< AmazonS3Activity > GetSignedS3URLWithHttpInfo (string filename = null, string contentType = null)
        {

            var localVarPath = "/amazon/s3/signedposturl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (filename != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filename", filename)); // query parameter
            if (contentType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "content_type", contentType)); // query parameter

            // authentication (oauth2_client_credentials_grant) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_password_grant) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSignedS3URL", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AmazonS3Activity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AmazonS3Activity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AmazonS3Activity)));
        }

    }
}
