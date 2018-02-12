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
    public interface ITemplatesPropertiesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get details for a template property type
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">type</param>
        /// <returns>PropertyFieldListResource</returns>
        PropertyFieldListResource GetTemplatePropertyType (string type);

        /// <summary>
        /// Get details for a template property type
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">type</param>
        /// <returns>ApiResponse of PropertyFieldListResource</returns>
        ApiResponse<PropertyFieldListResource> GetTemplatePropertyTypeWithHttpInfo (string type);
        /// <summary>
        /// List template property types
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PropertyFieldListResource&gt;</returns>
        List<PropertyFieldListResource> GetTemplatePropertyTypes ();

        /// <summary>
        /// List template property types
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PropertyFieldListResource&gt;</returns>
        ApiResponse<List<PropertyFieldListResource>> GetTemplatePropertyTypesWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TemplatesPropertiesApi : ITemplatesPropertiesApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesPropertiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TemplatesPropertiesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesPropertiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TemplatesPropertiesApi(Configuration configuration = null)
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
        /// Get details for a template property type &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">type</param>
        /// <returns>PropertyFieldListResource</returns>
        public PropertyFieldListResource GetTemplatePropertyType (string type)
        {
             ApiResponse<PropertyFieldListResource> localVarResponse = GetTemplatePropertyTypeWithHttpInfo(type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details for a template property type &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">type</param>
        /// <returns>ApiResponse of PropertyFieldListResource</returns>
        public ApiResponse< PropertyFieldListResource > GetTemplatePropertyTypeWithHttpInfo (string type)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling TemplatesPropertiesApi->GetTemplatePropertyType");

            var localVarPath = "/templates/properties/{type}";
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

            if (type != null) localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter

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
                Exception exception = ExceptionFactory("GetTemplatePropertyType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PropertyFieldListResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertyFieldListResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyFieldListResource)));
        }

        /// <summary>
        /// List template property types &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PropertyFieldListResource&gt;</returns>
        public List<PropertyFieldListResource> GetTemplatePropertyTypes ()
        {
             ApiResponse<List<PropertyFieldListResource>> localVarResponse = GetTemplatePropertyTypesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List template property types &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PropertyFieldListResource&gt;</returns>
        public ApiResponse< List<PropertyFieldListResource> > GetTemplatePropertyTypesWithHttpInfo ()
        {

            var localVarPath = "/templates/properties";
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
                Exception exception = ExceptionFactory("GetTemplatePropertyTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PropertyFieldListResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PropertyFieldListResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PropertyFieldListResource>)));
        }

    }
}
