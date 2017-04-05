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
    public interface IPaymentsStripeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Stripe payment method for a user
        /// </summary>
        /// <remarks>
        /// Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a Stripe customer with payment info (optional)</param>
        /// <returns>PaymentMethodResource</returns>
        PaymentMethodResource CreateStripePaymentMethod (StripeCreatePaymentMethod request = null);

        /// <summary>
        /// Create a Stripe payment method for a user
        /// </summary>
        /// <remarks>
        /// Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a Stripe customer with payment info (optional)</param>
        /// <returns>ApiResponse of PaymentMethodResource</returns>
        ApiResponse<PaymentMethodResource> CreateStripePaymentMethodWithHttpInfo (StripeCreatePaymentMethod request = null);
        /// <summary>
        /// Pay with a single use token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to pay an invoice (optional)</param>
        /// <returns></returns>
        void PayStripeInvoice (StripePaymentRequest request = null);

        /// <summary>
        /// Pay with a single use token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to pay an invoice (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PayStripeInvoiceWithHttpInfo (StripePaymentRequest request = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentsStripeApi : IPaymentsStripeApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsStripeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsStripeApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PaymentsStripeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentsStripeApi(Configuration configuration = null)
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
        /// Create a Stripe payment method for a user Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a Stripe customer with payment info (optional)</param>
        /// <returns>PaymentMethodResource</returns>
        public PaymentMethodResource CreateStripePaymentMethod (StripeCreatePaymentMethod request = null)
        {
             ApiResponse<PaymentMethodResource> localVarResponse = CreateStripePaymentMethodWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Stripe payment method for a user Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to create a Stripe customer with payment info (optional)</param>
        /// <returns>ApiResponse of PaymentMethodResource</returns>
        public ApiResponse< PaymentMethodResource > CreateStripePaymentMethodWithHttpInfo (StripeCreatePaymentMethod request = null)
        {

            var localVarPath = "/payment/provider/stripe/payment-methods";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("CreateStripePaymentMethod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMethodResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMethodResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMethodResource)));
            
        }

        /// <summary>
        /// Pay with a single use token 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to pay an invoice (optional)</param>
        /// <returns></returns>
        public void PayStripeInvoice (StripePaymentRequest request = null)
        {
             PayStripeInvoiceWithHttpInfo(request);
        }

        /// <summary>
        /// Pay with a single use token 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request to pay an invoice (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PayStripeInvoiceWithHttpInfo (StripePaymentRequest request = null)
        {

            var localVarPath = "/payment/provider/stripe/payments";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PayStripeInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
