/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBRERuleEngineActionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of available actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>List&lt;ActionResource&gt;</returns>
        List<ActionResource> GetBREActions (string filterCategory = null, string filterName = null);

        /// <summary>
        /// Get a list of available actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>ApiResponse of List&lt;ActionResource&gt;</returns>
        ApiResponse<List<ActionResource>> GetBREActionsWithHttpInfo (string filterCategory = null, string filterName = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of available actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>Task of List&lt;ActionResource&gt;</returns>
        System.Threading.Tasks.Task<List<ActionResource>> GetBREActionsAsync (string filterCategory = null, string filterName = null);

        /// <summary>
        /// Get a list of available actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ActionResource&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ActionResource>>> GetBREActionsAsyncWithHttpInfo (string filterCategory = null, string filterName = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BRERuleEngineActionsApi : IBRERuleEngineActionsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineActionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BRERuleEngineActionsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineActionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BRERuleEngineActionsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Get a list of available actions 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>List&lt;ActionResource&gt;</returns>
        public List<ActionResource> GetBREActions (string filterCategory = null, string filterName = null)
        {
             ApiResponse<List<ActionResource>> localVarResponse = GetBREActionsWithHttpInfo(filterCategory, filterName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of available actions 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>ApiResponse of List&lt;ActionResource&gt;</returns>
        public ApiResponse< List<ActionResource> > GetBREActionsWithHttpInfo (string filterCategory = null, string filterName = null)
        {

            var localVarPath = "/bre/actions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

            if (filterCategory != null) localVarQueryParams.Add("filter_category", Configuration.ApiClient.ParameterToString(filterCategory)); // query parameter
            if (filterName != null) localVarQueryParams.Add("filter_name", Configuration.ApiClient.ParameterToString(filterName)); // query parameter

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
                Exception exception = ExceptionFactory("GetBREActions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ActionResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ActionResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ActionResource>)));
            
        }

        /// <summary>
        /// Get a list of available actions 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>Task of List&lt;ActionResource&gt;</returns>
        public async System.Threading.Tasks.Task<List<ActionResource>> GetBREActionsAsync (string filterCategory = null, string filterName = null)
        {
             ApiResponse<List<ActionResource>> localVarResponse = await GetBREActionsAsyncWithHttpInfo(filterCategory, filterName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of available actions 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterCategory">Filter for actions that are within a specific category (optional)</param>
        /// <param name="filterName">Filter for actions that have names containing the given string (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ActionResource&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ActionResource>>> GetBREActionsAsyncWithHttpInfo (string filterCategory = null, string filterName = null)
        {

            var localVarPath = "/bre/actions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
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

            if (filterCategory != null) localVarQueryParams.Add("filter_category", Configuration.ApiClient.ParameterToString(filterCategory)); // query parameter
            if (filterName != null) localVarQueryParams.Add("filter_name", Configuration.ApiClient.ParameterToString(filterName)); // query parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBREActions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ActionResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ActionResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ActionResource>)));
            
        }

    }
}
