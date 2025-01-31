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
using Yaksa.OrckestraCommerce.Client.Model;

namespace Yaksa.OrckestraCommerce.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITimezonesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest}
        /// </summary>
        /// <remarks>
        /// Convert a UTC datetime to a specific TimeZone datetime
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <returns>UtcOffsetForTimeZone</returns>
        UtcOffsetForTimeZone FindUtcOffsetForTimeZoneRequestconvertPost(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest));

        /// <summary>
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest}
        /// </summary>
        /// <remarks>
        /// Convert a UTC datetime to a specific TimeZone datetime
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of UtcOffsetForTimeZone</returns>
        ApiResponse<UtcOffsetForTimeZone> FindUtcOffsetForTimeZoneRequestconvertPostWithHttpInfo(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest));
        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all time zones
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <returns>List&lt;TimeZone&gt;</returns>
        List<Model.TimeZone> GetTimeZonesRequestGet(string accept);

        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all time zones
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <returns>ApiResponse of List&lt;TimeZone&gt;</returns>
        ApiResponse<List<Model.TimeZone>> GetTimeZonesRequestGetWithHttpInfo(string accept);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITimezonesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest}
        /// </summary>
        /// <remarks>
        /// Convert a UTC datetime to a specific TimeZone datetime
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UtcOffsetForTimeZone</returns>
        System.Threading.Tasks.Task<UtcOffsetForTimeZone> FindUtcOffsetForTimeZoneRequestconvertPostAsync(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest}
        /// </summary>
        /// <remarks>
        /// Convert a UTC datetime to a specific TimeZone datetime
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UtcOffsetForTimeZone)</returns>
        System.Threading.Tasks.Task<ApiResponse<UtcOffsetForTimeZone>> FindUtcOffsetForTimeZoneRequestconvertPostWithHttpInfoAsync(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all time zones
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimeZone&gt;</returns>
        System.Threading.Tasks.Task<List<Model.TimeZone>> GetTimeZonesRequestGetAsync(string accept, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest}
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all time zones
        /// </remarks>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimeZone&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Model.TimeZone>>> GetTimeZonesRequestGetWithHttpInfoAsync(string accept, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITimezonesApi : ITimezonesApiSync, ITimezonesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TimezonesApi : ITimezonesApi
    {
        private Yaksa.OrckestraCommerce.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimezonesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TimezonesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimezonesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TimezonesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="TimezonesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TimezonesApi(Yaksa.OrckestraCommerce.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TimezonesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TimezonesApi(Yaksa.OrckestraCommerce.Client.Client.ISynchronousClient client, Yaksa.OrckestraCommerce.Client.Client.IAsynchronousClient asyncClient, Yaksa.OrckestraCommerce.Client.Client.IReadableConfiguration configuration)
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
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest} Convert a UTC datetime to a specific TimeZone datetime
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <returns>UtcOffsetForTimeZone</returns>
        public UtcOffsetForTimeZone FindUtcOffsetForTimeZoneRequestconvertPost(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest))
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<UtcOffsetForTimeZone> localVarResponse = FindUtcOffsetForTimeZoneRequestconvertPostWithHttpInfo(accept, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest} Convert a UTC datetime to a specific TimeZone datetime
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of UtcOffsetForTimeZone</returns>
        public Yaksa.OrckestraCommerce.Client.Client.ApiResponse<UtcOffsetForTimeZone> FindUtcOffsetForTimeZoneRequestconvertPostWithHttpInfo(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest))
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling TimezonesApi->FindUtcOffsetForTimeZoneRequestconvertPost");

            Yaksa.OrckestraCommerce.Client.Client.RequestOptions localVarRequestOptions = new Yaksa.OrckestraCommerce.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter
            localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = this.Client.Post<UtcOffsetForTimeZone>("/timezones/convert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindUtcOffsetForTimeZoneRequestconvertPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest} Convert a UTC datetime to a specific TimeZone datetime
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UtcOffsetForTimeZone</returns>
        public async System.Threading.Tasks.Task<UtcOffsetForTimeZone> FindUtcOffsetForTimeZoneRequestconvertPostAsync(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<UtcOffsetForTimeZone> localVarResponse = await FindUtcOffsetForTimeZoneRequestconvertPostWithHttpInfoAsync(accept, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Convert a UTC datetime to a specific TimeZone datetime - {FindUtcOffsetForTimeZoneRequest} Convert a UTC datetime to a specific TimeZone datetime
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UtcOffsetForTimeZone)</returns>
        public async System.Threading.Tasks.Task<Yaksa.OrckestraCommerce.Client.Client.ApiResponse<UtcOffsetForTimeZone>> FindUtcOffsetForTimeZoneRequestconvertPostWithHttpInfoAsync(string accept, FindUtcOffsetForTimeZoneRequest body = default(FindUtcOffsetForTimeZoneRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling TimezonesApi->FindUtcOffsetForTimeZoneRequestconvertPost");


            Yaksa.OrckestraCommerce.Client.Client.RequestOptions localVarRequestOptions = new Yaksa.OrckestraCommerce.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Yaksa.OrckestraCommerce.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter
            localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UtcOffsetForTimeZone>("/timezones/convert", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindUtcOffsetForTimeZoneRequestconvertPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest} Retrieve a list of all time zones
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <returns>List&lt;TimeZone&gt;</returns>
        public List<Model.TimeZone> GetTimeZonesRequestGet(string accept)
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<Model.TimeZone>> localVarResponse = GetTimeZonesRequestGetWithHttpInfo(accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest} Retrieve a list of all time zones
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <returns>ApiResponse of List&lt;TimeZone&gt;</returns>
        public Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<Model.TimeZone>> GetTimeZonesRequestGetWithHttpInfo(string accept)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling TimezonesApi->GetTimeZonesRequestGet");

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

            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Model.TimeZone>>("/timezones", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTimeZonesRequestGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest} Retrieve a list of all time zones
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TimeZone&gt;</returns>
        public async System.Threading.Tasks.Task<List<Model.TimeZone>> GetTimeZonesRequestGetAsync(string accept, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<Model.TimeZone>> localVarResponse = await GetTimeZonesRequestGetWithHttpInfoAsync(accept, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all time zones - {GetTimeZonesRequest} Retrieve a list of all time zones
        /// </summary>
        /// <exception cref="Yaksa.OrckestraCommerce.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">Accept Header</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TimeZone&gt;)</returns>
        public async System.Threading.Tasks.Task<Yaksa.OrckestraCommerce.Client.Client.ApiResponse<List<Model.TimeZone>>> GetTimeZonesRequestGetWithHttpInfoAsync(string accept, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new Yaksa.OrckestraCommerce.Client.Client.ApiException(400, "Missing required parameter 'accept' when calling TimezonesApi->GetTimeZonesRequestGet");


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

            localVarRequestOptions.HeaderParameters.Add("Accept", Yaksa.OrckestraCommerce.Client.Client.ClientUtils.ParameterToString(accept)); // header parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Model.TimeZone>>("/timezones", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTimeZonesRequestGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
