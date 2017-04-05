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
    public interface IAccessTokenApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant type</param>
        /// <param name="clientId">The id of the client</param>
        /// <param name="clientSecret">The secret key of the client.  Used only with a grant_type of client_credentials (optional)</param>
        /// <param name="username">The username of the client.  Used only with a grant_type of password (optional)</param>
        /// <param name="password">The password of the client.  Used only with a grant_type of password (optional)</param>
        /// <returns>OAuth2Resource</returns>
        OAuth2Resource GetOAuthToken (string grantType, string clientId, string clientSecret = null, string username = null, string password = null);

        /// <summary>
        /// Get access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant type</param>
        /// <param name="clientId">The id of the client</param>
        /// <param name="clientSecret">The secret key of the client.  Used only with a grant_type of client_credentials (optional)</param>
        /// <param name="username">The username of the client.  Used only with a grant_type of password (optional)</param>
        /// <param name="password">The password of the client.  Used only with a grant_type of password (optional)</param>
        /// <returns>ApiResponse of OAuth2Resource</returns>
        ApiResponse<OAuth2Resource> GetOAuthTokenWithHttpInfo (string grantType, string clientId, string clientSecret = null, string username = null, string password = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccessTokenApi : IAccessTokenApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessTokenApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AccessTokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccessTokenApi(Configuration configuration = null)
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
        /// Get access token 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant type</param>
        /// <param name="clientId">The id of the client</param>
        /// <param name="clientSecret">The secret key of the client.  Used only with a grant_type of client_credentials (optional)</param>
        /// <param name="username">The username of the client.  Used only with a grant_type of password (optional)</param>
        /// <param name="password">The password of the client.  Used only with a grant_type of password (optional)</param>
        /// <returns>OAuth2Resource</returns>
        public OAuth2Resource GetOAuthToken (string grantType, string clientId, string clientSecret = null, string username = null, string password = null)
        {
             ApiResponse<OAuth2Resource> localVarResponse = GetOAuthTokenWithHttpInfo(grantType, clientId, clientSecret, username, password);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get access token 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant type</param>
        /// <param name="clientId">The id of the client</param>
        /// <param name="clientSecret">The secret key of the client.  Used only with a grant_type of client_credentials (optional)</param>
        /// <param name="username">The username of the client.  Used only with a grant_type of password (optional)</param>
        /// <param name="password">The password of the client.  Used only with a grant_type of password (optional)</param>
        /// <returns>ApiResponse of OAuth2Resource</returns>
        public ApiResponse< OAuth2Resource > GetOAuthTokenWithHttpInfo (string grantType, string clientId, string clientSecret = null, string username = null, string password = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling AccessTokenApi->GetOAuthToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AccessTokenApi->GetOAuthToken");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter
            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOAuthToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OAuth2Resource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuth2Resource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuth2Resource)));
            
        }

    }
}
