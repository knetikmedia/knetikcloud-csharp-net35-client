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
    public interface ICurrenciesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns>CurrencyResource</returns>
        CurrencyResource CreateCurrency (CurrencyResource currency = null);

        /// <summary>
        /// Create a currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns>ApiResponse of CurrencyResource</returns>
        ApiResponse<CurrencyResource> CreateCurrencyWithHttpInfo (CurrencyResource currency = null);
        /// <summary>
        /// Delete a currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns></returns>
        void DeleteCurrency (string code);

        /// <summary>
        /// Delete a currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCurrencyWithHttpInfo (string code);
        /// <summary>
        /// List and search currencies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEnabledCurrencies">Filter for alternate currencies setup explicitely in system config (optional)</param>
        /// <param name="filterType">Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;) (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to name:ASC)</param>
        /// <returns>PageResourceCurrencyResource</returns>
        PageResourceCurrencyResource GetCurrencies (bool? filterEnabledCurrencies = null, string filterType = null, int? size = null, int? page = null, string order = null);

        /// <summary>
        /// List and search currencies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEnabledCurrencies">Filter for alternate currencies setup explicitely in system config (optional)</param>
        /// <param name="filterType">Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;) (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to name:ASC)</param>
        /// <returns>ApiResponse of PageResourceCurrencyResource</returns>
        ApiResponse<PageResourceCurrencyResource> GetCurrenciesWithHttpInfo (bool? filterEnabledCurrencies = null, string filterType = null, int? size = null, int? page = null, string order = null);
        /// <summary>
        /// Get a single currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns>CurrencyResource</returns>
        CurrencyResource GetCurrency (string code);

        /// <summary>
        /// Get a single currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns>ApiResponse of CurrencyResource</returns>
        ApiResponse<CurrencyResource> GetCurrencyWithHttpInfo (string code);
        /// <summary>
        /// Update a currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns></returns>
        void UpdateCurrency (string code, CurrencyResource currency = null);

        /// <summary>
        /// Update a currency
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCurrencyWithHttpInfo (string code, CurrencyResource currency = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CurrenciesApi : ICurrenciesApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrenciesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CurrenciesApi(Configuration configuration = null)
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
        /// Create a currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns>CurrencyResource</returns>
        public CurrencyResource CreateCurrency (CurrencyResource currency = null)
        {
             ApiResponse<CurrencyResource> localVarResponse = CreateCurrencyWithHttpInfo(currency);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns>ApiResponse of CurrencyResource</returns>
        public ApiResponse< CurrencyResource > CreateCurrencyWithHttpInfo (CurrencyResource currency = null)
        {

            var localVarPath = "/currencies";
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

            if (currency != null && currency.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(currency); // http body (model) parameter
            }
            else
            {
                localVarPostBody = currency; // byte array
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
                Exception exception = ExceptionFactory("CreateCurrency", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CurrencyResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyResource)));
            
        }

        /// <summary>
        /// Delete a currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns></returns>
        public void DeleteCurrency (string code)
        {
             DeleteCurrencyWithHttpInfo(code);
        }

        /// <summary>
        /// Delete a currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCurrencyWithHttpInfo (string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling CurrenciesApi->DeleteCurrency");

            var localVarPath = "/currencies/{code}";
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

            if (code != null) localVarPathParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteCurrency", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// List and search currencies 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEnabledCurrencies">Filter for alternate currencies setup explicitely in system config (optional)</param>
        /// <param name="filterType">Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;) (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to name:ASC)</param>
        /// <returns>PageResourceCurrencyResource</returns>
        public PageResourceCurrencyResource GetCurrencies (bool? filterEnabledCurrencies = null, string filterType = null, int? size = null, int? page = null, string order = null)
        {
             ApiResponse<PageResourceCurrencyResource> localVarResponse = GetCurrenciesWithHttpInfo(filterEnabledCurrencies, filterType, size, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List and search currencies 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterEnabledCurrencies">Filter for alternate currencies setup explicitely in system config (optional)</param>
        /// <param name="filterType">Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;) (optional)</param>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to name:ASC)</param>
        /// <returns>ApiResponse of PageResourceCurrencyResource</returns>
        public ApiResponse< PageResourceCurrencyResource > GetCurrenciesWithHttpInfo (bool? filterEnabledCurrencies = null, string filterType = null, int? size = null, int? page = null, string order = null)
        {

            var localVarPath = "/currencies";
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

            if (filterEnabledCurrencies != null) localVarQueryParams.Add("filter_enabled_currencies", Configuration.ApiClient.ParameterToString(filterEnabledCurrencies)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filter_type", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (size != null) localVarQueryParams.Add("size", Configuration.ApiClient.ParameterToString(size)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCurrencies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourceCurrencyResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourceCurrencyResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourceCurrencyResource)));
            
        }

        /// <summary>
        /// Get a single currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns>CurrencyResource</returns>
        public CurrencyResource GetCurrency (string code)
        {
             ApiResponse<CurrencyResource> localVarResponse = GetCurrencyWithHttpInfo(code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <returns>ApiResponse of CurrencyResource</returns>
        public ApiResponse< CurrencyResource > GetCurrencyWithHttpInfo (string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling CurrenciesApi->GetCurrency");

            var localVarPath = "/currencies/{code}";
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

            if (code != null) localVarPathParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCurrency", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CurrencyResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyResource)));
            
        }

        /// <summary>
        /// Update a currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns></returns>
        public void UpdateCurrency (string code, CurrencyResource currency = null)
        {
             UpdateCurrencyWithHttpInfo(code, currency);
        }

        /// <summary>
        /// Update a currency 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The currency code</param>
        /// <param name="currency">The currency object (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCurrencyWithHttpInfo (string code, CurrencyResource currency = null)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling CurrenciesApi->UpdateCurrency");

            var localVarPath = "/currencies/{code}";
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

            if (code != null) localVarPathParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (currency != null && currency.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(currency); // http body (model) parameter
            }
            else
            {
                localVarPostBody = currency; // byte array
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
                Exception exception = ExceptionFactory("UpdateCurrency", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
