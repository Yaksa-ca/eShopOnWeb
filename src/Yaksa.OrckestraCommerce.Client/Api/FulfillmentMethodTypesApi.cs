/*
 * Overture API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Yaksa.OrckestraCommerce.Client.Client;

namespace Yaksa.OrckestraCommerce.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFulfillmentMethodTypesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet(string accept, string scopeId, string fulfillmentLocationId);

        /// <summary>
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetWithHttpInfo(string accept, string scopeId, string fulfillmentLocationId);
        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetFulfillmentMethodTypesByScopeRequestScopeIdGet(string accept, string scopeId);

        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetFulfillmentMethodTypesByScopeRequestScopeIdGetWithHttpInfo(string accept, string scopeId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFulfillmentMethodTypesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetAsync(string accept, string scopeId, string fulfillmentLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetWithHttpInfoAsync(string accept, string scopeId, string fulfillmentLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetFulfillmentMethodTypesByScopeRequestScopeIdGetAsync(string accept, string scopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetFulfillmentMethodTypesByScopeRequestScopeIdGetWithHttpInfoAsync(string accept, string scopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFulfillmentMethodTypesApi : IFulfillmentMethodTypesApiSync, IFulfillmentMethodTypesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FulfillmentMethodTypesApi : IFulfillmentMethodTypesApi
    {
        private Yaksa.OrckestraCommerce.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentMethodTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FulfillmentMethodTypesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentMethodTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FulfillmentMethodTypesApi(String basePath)
        {
            this.Configuration = Yaksa.OrckestraCommerce.Client.Client.Configuration.MergeConfigurations(
                Yaksa.OrckestraCommerce.Client.Client.GlobalConfiguration.Instance,
                new Yaksa.OrckestraCommerce.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Yaksa.OrckestraCommerce.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Yaksa.OrckestraCommerce.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Yaksa.OrckestraCommerce.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentMethodTypesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FulfillmentMethodTypesApi(Yaksa.OrckestraCommerce.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Yaksa.OrckestraCommerce.Client.Client.Configuration.MergeConfigurations(
                Yaksa.OrckestraCommerce.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Yaksa.OrckestraCommerce.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Yaksa.OrckestraCommerce.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Yaksa.OrckestraCommerce.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentMethodTypesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FulfillmentMethodTypesApi(Yaksa.OrckestraCommerce.Client.Client.ISynchronousClient client, Yaksa.OrckestraCommerce.Client.Client.IAsynchronousClient asyncClient, Yaksa.OrckestraCommerce.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Yaksa.OrckestraCommerce.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Yaksa.OrckestraCommerce.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Yaksa.OrckestraCommerce.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Yaksa.OrckestraCommerce.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Yaksa.OrckestraCommerce.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest} Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet(string accept, string scopeId, string fulfillmentLocationId)
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>> localVarResponse = GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetWithHttpInfo(accept, scopeId, fulfillmentLocationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest} Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetWithHttpInfo(string accept, string scopeId, string fulfillmentLocationId)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet");

            // verify the required parameter 'scopeId' is set
            if (scopeId == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'scopeId' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet");

            // verify the required parameter 'fulfillmentLocationId' is set
            if (fulfillmentLocationId == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'fulfillmentLocationId' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet");

            Yaksa.OrckestraCommerce.Client.Client.RequestOptions localVarRequestOptions = new Yaksa.OrckestraCommerce.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("ScopeId", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(scopeId)); // path parameter
            localVarRequestOptions.PathParameters.Add("FulfillmentLocationId", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(fulfillmentLocationId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<string>>("/fulfillmentMethodTypes/{ScopeId}/{FulfillmentLocationId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest} Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetAsync(string accept, string scopeId, string fulfillmentLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>> localVarResponse = await GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetWithHttpInfoAsync(accept, scopeId, fulfillmentLocationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the fulfillment method types supported by a fulfillment location - {GetFulfillmentMethodTypesByFulfillmentLocationRequest} Retrieve the fulfillment method types supported by a specific fulfillment location
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="fulfillmentLocationId">the unique identifier of the Fulfillment location.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>>> GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGetWithHttpInfoAsync(string accept, string scopeId, string fulfillmentLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet");

            // verify the required parameter 'scopeId' is set
            if (scopeId == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'scopeId' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet");

            // verify the required parameter 'fulfillmentLocationId' is set
            if (fulfillmentLocationId == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'fulfillmentLocationId' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet");


            Yaksa.OrckestraCommerce.Client.Client.RequestOptions localVarRequestOptions = new Yaksa.OrckestraCommerce.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("ScopeId", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(scopeId)); // path parameter
            localVarRequestOptions.PathParameters.Add("FulfillmentLocationId", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(fulfillmentLocationId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<string>>("/fulfillmentMethodTypes/{ScopeId}/{FulfillmentLocationId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFulfillmentMethodTypesByFulfillmentLocationRequestScopeIdFulfillmentLocationIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest} Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetFulfillmentMethodTypesByScopeRequestScopeIdGet(string accept, string scopeId)
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>> localVarResponse = GetFulfillmentMethodTypesByScopeRequestScopeIdGetWithHttpInfo(accept, scopeId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest} Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>> GetFulfillmentMethodTypesByScopeRequestScopeIdGetWithHttpInfo(string accept, string scopeId)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByScopeRequestScopeIdGet");

            // verify the required parameter 'scopeId' is set
            if (scopeId == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'scopeId' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByScopeRequestScopeIdGet");

            Yaksa.OrckestraCommerce.Client.Client.RequestOptions localVarRequestOptions = new Yaksa.OrckestraCommerce.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("ScopeId", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(scopeId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<string>>("/fulfillmentMethodTypes/{ScopeId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFulfillmentMethodTypesByScopeRequestScopeIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest} Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetFulfillmentMethodTypesByScopeRequestScopeIdGetAsync(string accept, string scopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>> localVarResponse = await GetFulfillmentMethodTypesByScopeRequestScopeIdGetWithHttpInfoAsync(accept, scopeId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the Fulfillment method types supported by the locations of a specific scope - {GetFulfillmentMethodTypesByScopeRequest} Retrieve the Fulfillment method types supported by the locations of a specific scope
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="scopeId">The id of the requested scope</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<string>>> GetFulfillmentMethodTypesByScopeRequestScopeIdGetWithHttpInfoAsync(string accept, string scopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByScopeRequestScopeIdGet");

            // verify the required parameter 'scopeId' is set
            if (scopeId == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'scopeId' when calling FulfillmentMethodTypesApi->GetFulfillmentMethodTypesByScopeRequestScopeIdGet");


            Yaksa.OrckestraCommerce.Client.Client.RequestOptions localVarRequestOptions = new Yaksa.OrckestraCommerce.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("ScopeId", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(scopeId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<string>>("/fulfillmentMethodTypes/{ScopeId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFulfillmentMethodTypesByScopeRequestScopeIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
