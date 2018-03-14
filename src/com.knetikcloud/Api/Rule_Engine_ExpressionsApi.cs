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
    public interface IRule_Engine_ExpressionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Lookup a specific expression
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Specifiy the type of expression as returned by the listing endpoint</param>
        /// <returns>ExpressionResource</returns>
        ExpressionResource GetBREExpression (string type);

        /// <summary>
        /// Lookup a specific expression
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Specifiy the type of expression as returned by the listing endpoint</param>
        /// <returns>ApiResponse of ExpressionResource</returns>
        ApiResponse<ExpressionResource> GetBREExpressionWithHttpInfo (string type);
        /// <summary>
        /// Get a list of supported expressions to use in conditions or actions.
        /// </summary>
        /// <remarks>
        /// Each resource contains a type and a definition that are read-only, all the other fields must be provided when using the expression in a rule. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterTypeGroup">Filter for expressions by type group (optional)</param>
        /// <returns>List&lt;ExpressionResource&gt;</returns>
        List<ExpressionResource> GetBREExpressions (string filterTypeGroup = null);

        /// <summary>
        /// Get a list of supported expressions to use in conditions or actions.
        /// </summary>
        /// <remarks>
        /// Each resource contains a type and a definition that are read-only, all the other fields must be provided when using the expression in a rule. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterTypeGroup">Filter for expressions by type group (optional)</param>
        /// <returns>ApiResponse of List&lt;ExpressionResource&gt;</returns>
        ApiResponse<List<ExpressionResource>> GetBREExpressionsWithHttpInfo (string filterTypeGroup = null);
        /// <summary>
        /// Returns the textual representation of an expression
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expression">The expression resource to be converted (optional)</param>
        /// <returns>StringWrapper</returns>
        StringWrapper GetExpressionAsText (ExpressionResource expression = null);

        /// <summary>
        /// Returns the textual representation of an expression
        /// </summary>
        /// <remarks>
        /// &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expression">The expression resource to be converted (optional)</param>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetExpressionAsTextWithHttpInfo (ExpressionResource expression = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Rule_Engine_ExpressionsApi : IRule_Engine_ExpressionsApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_ExpressionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Rule_Engine_ExpressionsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_ExpressionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public Rule_Engine_ExpressionsApi(Configuration configuration = null)
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
        /// Lookup a specific expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Specifiy the type of expression as returned by the listing endpoint</param>
        /// <returns>ExpressionResource</returns>
        public ExpressionResource GetBREExpression (string type)
        {
             ApiResponse<ExpressionResource> localVarResponse = GetBREExpressionWithHttpInfo(type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup a specific expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Specifiy the type of expression as returned by the listing endpoint</param>
        /// <returns>ApiResponse of ExpressionResource</returns>
        public ApiResponse< ExpressionResource > GetBREExpressionWithHttpInfo (string type)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling Rule_Engine_ExpressionsApi->GetBREExpression");

            var localVarPath = "/bre/expressions/{type}";
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
                Exception exception = ExceptionFactory("GetBREExpression", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExpressionResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExpressionResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExpressionResource)));
        }

        /// <summary>
        /// Get a list of supported expressions to use in conditions or actions. Each resource contains a type and a definition that are read-only, all the other fields must be provided when using the expression in a rule. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterTypeGroup">Filter for expressions by type group (optional)</param>
        /// <returns>List&lt;ExpressionResource&gt;</returns>
        public List<ExpressionResource> GetBREExpressions (string filterTypeGroup = null)
        {
             ApiResponse<List<ExpressionResource>> localVarResponse = GetBREExpressionsWithHttpInfo(filterTypeGroup);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of supported expressions to use in conditions or actions. Each resource contains a type and a definition that are read-only, all the other fields must be provided when using the expression in a rule. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterTypeGroup">Filter for expressions by type group (optional)</param>
        /// <returns>ApiResponse of List&lt;ExpressionResource&gt;</returns>
        public ApiResponse< List<ExpressionResource> > GetBREExpressionsWithHttpInfo (string filterTypeGroup = null)
        {

            var localVarPath = "/bre/expressions";
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

            if (filterTypeGroup != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filter_type_group", filterTypeGroup)); // query parameter

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
                Exception exception = ExceptionFactory("GetBREExpressions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ExpressionResource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ExpressionResource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExpressionResource>)));
        }

        /// <summary>
        /// Returns the textual representation of an expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expression">The expression resource to be converted (optional)</param>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetExpressionAsText (ExpressionResource expression = null)
        {
             ApiResponse<StringWrapper> localVarResponse = GetExpressionAsTextWithHttpInfo(expression);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the textual representation of an expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expression">The expression resource to be converted (optional)</param>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse< StringWrapper > GetExpressionAsTextWithHttpInfo (ExpressionResource expression = null)
        {

            var localVarPath = "/bre/expressions";
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

            if (expression != null && expression.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(expression); // http body (model) parameter
            }
            else
            {
                localVarPostBody = expression; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExpressionAsText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringWrapper>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StringWrapper) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringWrapper)));
        }

    }
}