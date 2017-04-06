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
    public interface IAuthPermissionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>PermissionResource</returns>
        PermissionResource CreatePermission (PermissionResource permissionResource = null);

        /// <summary>
        /// Create a new permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>ApiResponse of PermissionResource</returns>
        ApiResponse<PermissionResource> CreatePermissionWithHttpInfo (PermissionResource permissionResource = null);
        /// <summary>
        /// Delete a permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="force">If true, removes permission assigned to roles (optional)</param>
        /// <returns></returns>
        void DeletePermission (string permission, bool? force = null);

        /// <summary>
        /// Delete a permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="force">If true, removes permission assigned to roles (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePermissionWithHttpInfo (string permission, bool? force = null);
        /// <summary>
        /// Get a single permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <returns>PermissionResource</returns>
        PermissionResource GetPermission (string permission);

        /// <summary>
        /// Get a single permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <returns>ApiResponse of PermissionResource</returns>
        ApiResponse<PermissionResource> GetPermissionWithHttpInfo (string permission);
        /// <summary>
        /// List and search permissions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to permission:ASC)</param>
        /// <returns>PageResourcePermissionResource</returns>
        PageResourcePermissionResource GetPermissions (int? size = null, int? page = null, string order = null);

        /// <summary>
        /// List and search permissions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to permission:ASC)</param>
        /// <returns>ApiResponse of PageResourcePermissionResource</returns>
        ApiResponse<PageResourcePermissionResource> GetPermissionsWithHttpInfo (int? size = null, int? page = null, string order = null);
        /// <summary>
        /// Update a permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>PermissionResource</returns>
        PermissionResource UpdatePermission (string permission, PermissionResource permissionResource = null);

        /// <summary>
        /// Update a permission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>ApiResponse of PermissionResource</returns>
        ApiResponse<PermissionResource> UpdatePermissionWithHttpInfo (string permission, PermissionResource permissionResource = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthPermissionsApi : IAuthPermissionsApi
    {
        private com.knetikcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthPermissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthPermissionsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AuthPermissionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthPermissionsApi(Configuration configuration = null)
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
        /// Create a new permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>PermissionResource</returns>
        public PermissionResource CreatePermission (PermissionResource permissionResource = null)
        {
             ApiResponse<PermissionResource> localVarResponse = CreatePermissionWithHttpInfo(permissionResource);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>ApiResponse of PermissionResource</returns>
        public ApiResponse< PermissionResource > CreatePermissionWithHttpInfo (PermissionResource permissionResource = null)
        {

            var localVarPath = "/auth/permissions";
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

            if (permissionResource != null && permissionResource.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(permissionResource); // http body (model) parameter
            }
            else
            {
                localVarPostBody = permissionResource; // byte array
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
                Exception exception = ExceptionFactory("CreatePermission", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PermissionResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionResource)));
            
        }

        /// <summary>
        /// Delete a permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="force">If true, removes permission assigned to roles (optional)</param>
        /// <returns></returns>
        public void DeletePermission (string permission, bool? force = null)
        {
             DeletePermissionWithHttpInfo(permission, force);
        }

        /// <summary>
        /// Delete a permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="force">If true, removes permission assigned to roles (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePermissionWithHttpInfo (string permission, bool? force = null)
        {
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthPermissionsApi->DeletePermission");

            var localVarPath = "/auth/permissions/{permission}";
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

            if (permission != null) localVarPathParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // path parameter
            if (force != null) localVarQueryParams.Add("force", Configuration.ApiClient.ParameterToString(force)); // query parameter

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
                Exception exception = ExceptionFactory("DeletePermission", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a single permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <returns>PermissionResource</returns>
        public PermissionResource GetPermission (string permission)
        {
             ApiResponse<PermissionResource> localVarResponse = GetPermissionWithHttpInfo(permission);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <returns>ApiResponse of PermissionResource</returns>
        public ApiResponse< PermissionResource > GetPermissionWithHttpInfo (string permission)
        {
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthPermissionsApi->GetPermission");

            var localVarPath = "/auth/permissions/{permission}";
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

            if (permission != null) localVarPathParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // path parameter

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
                Exception exception = ExceptionFactory("GetPermission", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PermissionResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionResource)));
            
        }

        /// <summary>
        /// List and search permissions 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to permission:ASC)</param>
        /// <returns>PageResourcePermissionResource</returns>
        public PageResourcePermissionResource GetPermissions (int? size = null, int? page = null, string order = null)
        {
             ApiResponse<PageResourcePermissionResource> localVarResponse = GetPermissionsWithHttpInfo(size, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List and search permissions 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="size">The number of objects returned per page (optional, default to 25)</param>
        /// <param name="page">The number of the page returned, starting with 1 (optional, default to 1)</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional, default to permission:ASC)</param>
        /// <returns>ApiResponse of PageResourcePermissionResource</returns>
        public ApiResponse< PageResourcePermissionResource > GetPermissionsWithHttpInfo (int? size = null, int? page = null, string order = null)
        {

            var localVarPath = "/auth/permissions";
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
                Exception exception = ExceptionFactory("GetPermissions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageResourcePermissionResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageResourcePermissionResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageResourcePermissionResource)));
            
        }

        /// <summary>
        /// Update a permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>PermissionResource</returns>
        public PermissionResource UpdatePermission (string permission, PermissionResource permissionResource = null)
        {
             ApiResponse<PermissionResource> localVarResponse = UpdatePermissionWithHttpInfo(permission, permissionResource);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a permission 
        /// </summary>
        /// <exception cref="com.knetikcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">The permission value</param>
        /// <param name="permissionResource">The permission resource object (optional)</param>
        /// <returns>ApiResponse of PermissionResource</returns>
        public ApiResponse< PermissionResource > UpdatePermissionWithHttpInfo (string permission, PermissionResource permissionResource = null)
        {
            // verify the required parameter 'permission' is set
            if (permission == null)
                throw new ApiException(400, "Missing required parameter 'permission' when calling AuthPermissionsApi->UpdatePermission");

            var localVarPath = "/auth/permissions/{permission}";
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

            if (permission != null) localVarPathParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // path parameter
            if (permissionResource != null && permissionResource.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(permissionResource); // http body (model) parameter
            }
            else
            {
                localVarPostBody = permissionResource; // byte array
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
                Exception exception = ExceptionFactory("UpdatePermission", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PermissionResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionResource)));
            
        }

    }
}
