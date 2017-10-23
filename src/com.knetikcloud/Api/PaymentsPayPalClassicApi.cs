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
    public interface IPaymentsPayPalClassicApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a PayPal Classic billing agreement for the user
        /// </summary>
        /// <remarks>
        /// Returns the token that should be used to forward the user to PayPal so they can accept the agreement.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal billing agreement (optional)</param>
        /// <returns>string</returns>
        string CreatePayPalBillingAgreementUrl (CreateBillingAgreementRequest request = null);

        /// <summary>
        /// Create a PayPal Classic billing agreement for the user
        /// </summary>
        /// <remarks>
        /// Returns the token that should be used to forward the user to PayPal so they can accept the agreement.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal billing agreement (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CreatePayPalBillingAgreementUrlWithHttpInfo (CreateBillingAgreementRequest request = null);
        /// <summary>
        /// Create a payment token for PayPal express checkout
        /// </summary>
        /// <remarks>
        /// Returns the token that should be used to forward the user to PayPal so they can complete the checkout.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal payment token (optional)</param>
        /// <returns>string</returns>
        string CreatePayPalExpressCheckout (CreatePayPalPaymentRequest request = null);

        /// <summary>
        /// Create a payment token for PayPal express checkout
        /// </summary>
        /// <remarks>
        /// Returns the token that should be used to forward the user to PayPal so they can complete the checkout.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal payment token (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CreatePayPalExpressCheckoutWithHttpInfo (CreatePayPalPaymentRequest request = null);
        /// <summary>
        /// Finalizes a billing agreement after the user has accepted through PayPal
        /// </summary>
        /// <remarks>
        /// Returns the ID of the new payment method created for the user for the billing agreement.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize a PayPal billing agreement (optional)</param>
        /// <returns>int?</returns>
        int? FinalizePayPalBillingAgreement (FinalizeBillingAgreementRequest request = null);

        /// <summary>
        /// Finalizes a billing agreement after the user has accepted through PayPal
        /// </summary>
        /// <remarks>
        /// Returns the ID of the new payment method created for the user for the billing agreement.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize a PayPal billing agreement (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> FinalizePayPalBillingAgreementWithHttpInfo (FinalizeBillingAgreementRequest request = null);
        /// <summary>
        /// Finalizes a payment after the user has completed checkout with PayPal
        /// </summary>
        /// <remarks>
        /// The invoice will be marked paid/failed by asynchronous IPN callback.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize the payment (optional)</param>
        /// <returns></returns>
        void FinalizePayPalCheckout (FinalizePayPalPaymentRequest request = null);

        /// <summary>
        /// Finalizes a payment after the user has completed checkout with PayPal
        /// </summary>
        /// <remarks>
        /// The invoice will be marked paid/failed by asynchronous IPN callback.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize the payment (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FinalizePayPalCheckoutWithHttpInfo (FinalizePayPalPaymentRequest request = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentsPayPalClassicApi : IPaymentsPayPalClassicApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsPayPalClassicApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsPayPalClassicApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.knetikcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsPayPalClassicApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentsPayPalClassicApi(Configuration configuration = null)
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
        /// Create a PayPal Classic billing agreement for the user Returns the token that should be used to forward the user to PayPal so they can accept the agreement.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal billing agreement (optional)</param>
        /// <returns>string</returns>
        public string CreatePayPalBillingAgreementUrl (CreateBillingAgreementRequest request = null)
        {
             ApiResponse<string> localVarResponse = CreatePayPalBillingAgreementUrlWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a PayPal Classic billing agreement for the user Returns the token that should be used to forward the user to PayPal so they can accept the agreement.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal billing agreement (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CreatePayPalBillingAgreementUrlWithHttpInfo (CreateBillingAgreementRequest request = null)
        {

            var localVarPath = "/payment/provider/paypal/classic/agreements/start";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("CreatePayPalBillingAgreementUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Create a payment token for PayPal express checkout Returns the token that should be used to forward the user to PayPal so they can complete the checkout.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal payment token (optional)</param>
        /// <returns>string</returns>
        public string CreatePayPalExpressCheckout (CreatePayPalPaymentRequest request = null)
        {
             ApiResponse<string> localVarResponse = CreatePayPalExpressCheckoutWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a payment token for PayPal express checkout Returns the token that should be used to forward the user to PayPal so they can complete the checkout.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a PayPal payment token (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CreatePayPalExpressCheckoutWithHttpInfo (CreatePayPalPaymentRequest request = null)
        {

            var localVarPath = "/payment/provider/paypal/classic/checkout/start";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("CreatePayPalExpressCheckout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Finalizes a billing agreement after the user has accepted through PayPal Returns the ID of the new payment method created for the user for the billing agreement.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize a PayPal billing agreement (optional)</param>
        /// <returns>int?</returns>
        public int? FinalizePayPalBillingAgreement (FinalizeBillingAgreementRequest request = null)
        {
             ApiResponse<int?> localVarResponse = FinalizePayPalBillingAgreementWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finalizes a billing agreement after the user has accepted through PayPal Returns the ID of the new payment method created for the user for the billing agreement.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize a PayPal billing agreement (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > FinalizePayPalBillingAgreementWithHttpInfo (FinalizeBillingAgreementRequest request = null)
        {

            var localVarPath = "/payment/provider/paypal/classic/agreements/finish";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("FinalizePayPalBillingAgreement", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
        }

        /// <summary>
        /// Finalizes a payment after the user has completed checkout with PayPal The invoice will be marked paid/failed by asynchronous IPN callback.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize the payment (optional)</param>
        /// <returns></returns>
        public void FinalizePayPalCheckout (FinalizePayPalPaymentRequest request = null)
        {
             FinalizePayPalCheckoutWithHttpInfo(request);
        }

        /// <summary>
        /// Finalizes a payment after the user has completed checkout with PayPal The invoice will be marked paid/failed by asynchronous IPN callback.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to finalize the payment (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FinalizePayPalCheckoutWithHttpInfo (FinalizePayPalPaymentRequest request = null)
        {

            var localVarPath = "/payment/provider/paypal/classic/checkout/finish";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("FinalizePayPalCheckout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
