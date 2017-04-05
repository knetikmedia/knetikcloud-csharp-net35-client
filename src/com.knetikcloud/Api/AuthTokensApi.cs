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
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace com.knetikcloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthTokensApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a token by username and client id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns></returns>
        void DeleteToken (string username, string clientId);

        /// <summary>
        /// Delete a token by username and client id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTokenWithHttpInfo (string username, string clientId);
        /// <summary>
        /// Delete all tokens by username
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <returns></returns>
        void DeleteTokens (string username);

        /// <summary>
        /// Delete all tokens by username
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTokensWithHttpInfo (string username);
        /// <summary>
        /// Get a single token by username and client id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns>OauthAccessTokenResource</returns>
        OauthAccessTokenResource GetToken (string username, string clientId);

        /// <summary>
        /// Get a single token by username and client id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns>ApiResponse of OauthAccessTokenResource</returns>
        ApiResponse<OauthAccessTokenResource> GetTokenWithHttpInfo (string username, string clientId);
        /// <summary>
        /// List usernames and client ids
        /// </summary>
        /// <remarks>
        /// Token value not shown
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterClientId">Filters for token whose client id matches provided string (optional)</param>
        /// <param name="filterUsername">Filters for token whose username matches provided string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to username:ASC)</param>
        /// <returns>PageResourceOauthAccessTokenResource</returns>
        PageResourceOauthAccessTokenResource GetTokens (string filterClientId = null, string filterUsername = null, int? size = null, int? page = null, string order = null);

        /// <summary>
        /// List usernames and client ids
        /// </summary>
        /// <remarks>
        /// Token value not shown
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterClientId">Filters for token whose client id matches provided string (optional)</param>
        /// <param name="filterUsername">Filters for token whose username matches provided string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to username:ASC)</param>
        /// <returns>ApiResponse of PageResourceOauthAccessTokenResource</returns>
        ApiResponse<PageResourceOauthAccessTokenResource> GetTokensWithHttpInfo (string filterClientId = null, string filterUsername = null, int? size = null, int? page = null, string order = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthTokensApi : IAuthTokensApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthTokensApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthTokensApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;

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
        /// Delete a token by username and client id 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns></returns>
        public void DeleteToken (string username, string clientId)
        {
             DeleteTokenWithHttpInfo(username, clientId);
        }

        /// <summary>
        /// Delete a token by username and client id 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteTokenWithHttpInfo (string username, string clientId)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling AuthTokensApi->DeleteToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthTokensApi->DeleteToken");

            var localVarPath = "/auth/tokens/{username}/{client_id}";
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

            if (username != null) localVarPathParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteToken", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete all tokens by username 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <returns></returns>
        public void DeleteTokens (string username)
        {
             DeleteTokensWithHttpInfo(username);
        }

        /// <summary>
        /// Delete all tokens by username 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteTokensWithHttpInfo (string username)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling AuthTokensApi->DeleteTokens");

            var localVarPath = "/auth/tokens/{username}";
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

            if (username != null) localVarPathParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteTokens", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a single token by username and client id 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns>OauthAccessTokenResource</returns>
        public OauthAccessTokenResource GetToken (string username, string clientId)
        {
             ApiResponse<OauthAccessTokenResource> localVarResponse = GetTokenWithHttpInfo(username, clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single token by username and client id 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns>ApiResponse of OauthAccessTokenResource</returns>
        public ApiResponse< OauthAccessTokenResource > GetTokenWithHttpInfo (string username, string clientId)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling AuthTokensApi->GetToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthTokensApi->GetToken");

            var localVarPath = "/auth/tokens/{username}/{client_id}";
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

            if (username != null) localVarPathParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter

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
                Exception exception = ExceptionFactory("GetToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OauthAccessTokenResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OauthAccessTokenResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OauthAccessTokenResource)));
            
        }

        /// <summary>
        /// List usernames and client ids Token value not shown
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterClientId">Filters for token whose client id matches provided string (optional)</param>
        /// <param name="filterUsername">Filters for token whose username matches provided string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to username:ASC)</param>
        /// <returns>PageResourceOauthAccessTokenResource</returns>
        public PageResourceOauthAccessTokenResource GetTokens (string filterClientId = null, string filterUsername = null, int? size = null, int? page = null, string order = null)
        {
             ApiResponse<PageResourceOauthAccessTokenResource> localVarResponse = GetTokensWithHttpInfo(filterClientId, filterUsername, size, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List usernames and client ids Token value not shown
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterClientId">Filters for token whose client id matches provided string (optional)</param>
        /// <param name="filterUsername">Filters for token whose username matches provided string (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to username:ASC)</param>
        /// <returns>ApiResponse of PageResourceOauthAccessTokenResource</returns>
        public ApiResponse< PageResourceOauthAccessTokenResource > GetTokensWithHttpInfo (string filterClientId = null, string filterUsername = null, int? size = null, int? page = null, string order = null)
        {

            var localVarPath = "/auth/tokens";
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

            if (filterClientId != null) localVarQueryParams.Add("filter_client_id", Configuration.ApiClient.ParameterToString(filterClientId)); // query parameter
            if (filterUsername != null) localVarQueryParams.Add("filter_username", Configuration.ApiClient.ParameterToString(filterUsername)); // query parameter
            if (size != null) localVarQueryParams.Add("size", Configuration.ApiClient.ParameterToString(size)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter

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
                Exception exception = ExceptionFactory("GetTokens", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceOauthAccessTokenResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceOauthAccessTokenResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceOauthAccessTokenResource)));
            
        }

    }
}