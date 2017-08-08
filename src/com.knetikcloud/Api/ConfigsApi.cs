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
    public interface IConfigsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">The config object (optional)</param>
        /// <returns>Config</returns>
        Config CreateConfig (Config config = null);

        /// <summary>
        /// Create a new config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">The config object (optional)</param>
        /// <returns>ApiResponse of Config</returns>
        ApiResponse<Config> CreateConfigWithHttpInfo (Config config = null);
        /// <summary>
        /// Delete an existing config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns></returns>
        void DeleteConfig (string name);

        /// <summary>
        /// Delete an existing config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteConfigWithHttpInfo (string name);
        /// <summary>
        /// Get a single config
        /// </summary>
        /// <remarks>
        /// Only configs that are public readable will be shown without admin access
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns>Config</returns>
        Config GetConfig (string name);

        /// <summary>
        /// Get a single config
        /// </summary>
        /// <remarks>
        /// Only configs that are public readable will be shown without admin access
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns>ApiResponse of Config</returns>
        ApiResponse<Config> GetConfigWithHttpInfo (string name);
        /// <summary>
        /// List and search configs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterSearch">Filter for configs whose name contains the given string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to 1)</param>
        /// <returns>PageResourceConfig</returns>
        PageResourceConfig GetConfigs (string filterSearch = null, int? size = null, int? page = null, string order = null);

        /// <summary>
        /// List and search configs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterSearch">Filter for configs whose name contains the given string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to 1)</param>
        /// <returns>ApiResponse of PageResourceConfig</returns>
        ApiResponse<PageResourceConfig> GetConfigsWithHttpInfo (string filterSearch = null, int? size = null, int? page = null, string order = null);
        /// <summary>
        /// Update an existing config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <param name="config">The config object (optional)</param>
        /// <returns></returns>
        void UpdateConfig (string name, Config config = null);

        /// <summary>
        /// Update an existing config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <param name="config">The config object (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateConfigWithHttpInfo (string name, Config config = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConfigsApi : IConfigsApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigsApi(Configuration configuration = null)
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
        /// Create a new config 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">The config object (optional)</param>
        /// <returns>Config</returns>
        public Config CreateConfig (Config config = null)
        {
             ApiResponse<Config> localVarResponse = CreateConfigWithHttpInfo(config);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new config 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="config">The config object (optional)</param>
        /// <returns>ApiResponse of Config</returns>
        public ApiResponse< Config > CreateConfigWithHttpInfo (Config config = null)
        {

            var localVarPath = "/configs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (config != null && config.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(config); // http body (model) parameter
            }
            else
            {
                localVarPostBody = config; // byte array
            }

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateConfig", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Config>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Config) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Config)));
        }

        /// <summary>
        /// Delete an existing config 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns></returns>
        public void DeleteConfig (string name)
        {
             DeleteConfigWithHttpInfo(name);
        }

        /// <summary>
        /// Delete an existing config 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConfigWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ConfigsApi->DeleteConfig");

            var localVarPath = "/configs/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteConfig", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a single config Only configs that are public readable will be shown without admin access
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns>Config</returns>
        public Config GetConfig (string name)
        {
             ApiResponse<Config> localVarResponse = GetConfigWithHttpInfo(name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single config Only configs that are public readable will be shown without admin access
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <returns>ApiResponse of Config</returns>
        public ApiResponse< Config > GetConfigWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ConfigsApi->GetConfig");

            var localVarPath = "/configs/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter

            // authentication (OAuth2) required
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
                Exception exception = ExceptionFactory("GetConfig", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Config>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Config) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Config)));
        }

        /// <summary>
        /// List and search configs 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterSearch">Filter for configs whose name contains the given string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to 1)</param>
        /// <returns>PageResourceConfig</returns>
        public PageResourceConfig GetConfigs (string filterSearch = null, int? size = null, int? page = null, string order = null)
        {
             ApiResponse<PageResourceConfig> localVarResponse = GetConfigsWithHttpInfo(filterSearch, size, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List and search configs 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterSearch">Filter for configs whose name contains the given string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to 1)</param>
        /// <returns>ApiResponse of PageResourceConfig</returns>
        public ApiResponse< PageResourceConfig > GetConfigsWithHttpInfo (string filterSearch = null, int? size = null, int? page = null, string order = null)
        {

            var localVarPath = "/configs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (filterSearch != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filter_search", filterSearch)); // query parameter
            if (size != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter

            // authentication (OAuth2) required
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
                Exception exception = ExceptionFactory("GetConfigs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceConfig) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceConfig)));
        }

        /// <summary>
        /// Update an existing config 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <param name="config">The config object (optional)</param>
        /// <returns></returns>
        public void UpdateConfig (string name, Config config = null)
        {
             UpdateConfigWithHttpInfo(name, config);
        }

        /// <summary>
        /// Update an existing config 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The config name</param>
        /// <param name="config">The config object (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateConfigWithHttpInfo (string name, Config config = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ConfigsApi->UpdateConfig");

            var localVarPath = "/configs/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (config != null && config.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(config); // http body (model) parameter
            }
            else
            {
                localVarPostBody = config; // byte array
            }

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateConfig", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
