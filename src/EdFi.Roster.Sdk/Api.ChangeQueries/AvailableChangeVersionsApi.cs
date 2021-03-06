/*
 * Available Change Versions API Endpoint
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
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
using EdFi.Roster.Sdk.Client;
using EdFi.Roster.Sdk.Models.ChangeQueries;

namespace EdFi.Roster.Sdk.Api.ChangeQueries
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAvailableChangeVersionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available.
        /// </summary>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AvailableChangeVersion</returns>
        AvailableChangeVersion GetAvailableChangeVersions();

        /// <summary>
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AvailableChangeVersion</returns>
        ApiResponse<AvailableChangeVersion> GetAvailableChangeVersionsWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAvailableChangeVersionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AvailableChangeVersion</returns>
        System.Threading.Tasks.Task<AvailableChangeVersion> GetAvailableChangeVersionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AvailableChangeVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvailableChangeVersion>> GetAvailableChangeVersionsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAvailableChangeVersionsApi : IAvailableChangeVersionsApiSync, IAvailableChangeVersionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AvailableChangeVersionsApi : IAvailableChangeVersionsApi
    {
        private EdFi.Roster.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableChangeVersionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvailableChangeVersionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableChangeVersionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvailableChangeVersionsApi(String basePath)
        {
            this.Configuration = EdFi.Roster.Sdk.Client.Configuration.MergeConfigurations(
                EdFi.Roster.Sdk.Client.GlobalConfiguration.Instance,
                new EdFi.Roster.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new EdFi.Roster.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new EdFi.Roster.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = EdFi.Roster.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableChangeVersionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AvailableChangeVersionsApi(EdFi.Roster.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = EdFi.Roster.Sdk.Client.Configuration.MergeConfigurations(
                EdFi.Roster.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new EdFi.Roster.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new EdFi.Roster.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = EdFi.Roster.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableChangeVersionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AvailableChangeVersionsApi(EdFi.Roster.Sdk.Client.ISynchronousClient client, EdFi.Roster.Sdk.Client.IAsynchronousClient asyncClient, EdFi.Roster.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = EdFi.Roster.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public EdFi.Roster.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public EdFi.Roster.Sdk.Client.ISynchronousClient Client { get; set; }

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
        public EdFi.Roster.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public EdFi.Roster.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available. 
        /// </summary>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AvailableChangeVersion</returns>
        public AvailableChangeVersion GetAvailableChangeVersions()
        {
            EdFi.Roster.Sdk.Client.ApiResponse<AvailableChangeVersion> localVarResponse = GetAvailableChangeVersionsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available. 
        /// </summary>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AvailableChangeVersion</returns>
        public EdFi.Roster.Sdk.Client.ApiResponse<AvailableChangeVersion> GetAvailableChangeVersionsWithHttpInfo()
        {
            EdFi.Roster.Sdk.Client.RequestOptions localVarRequestOptions = new EdFi.Roster.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = EdFi.Roster.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = EdFi.Roster.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AvailableChangeVersion>("/availableChangeVersions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAvailableChangeVersions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available. 
        /// </summary>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AvailableChangeVersion</returns>
        public async System.Threading.Tasks.Task<AvailableChangeVersion> GetAvailableChangeVersionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            EdFi.Roster.Sdk.Client.ApiResponse<AvailableChangeVersion> localVarResponse = await GetAvailableChangeVersionsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the change versions for the earliest (oldest) and most recent (newest) changes available. 
        /// </summary>
        /// <exception cref="EdFi.Roster.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AvailableChangeVersion)</returns>
        public async System.Threading.Tasks.Task<EdFi.Roster.Sdk.Client.ApiResponse<AvailableChangeVersion>> GetAvailableChangeVersionsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            EdFi.Roster.Sdk.Client.RequestOptions localVarRequestOptions = new EdFi.Roster.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = EdFi.Roster.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = EdFi.Roster.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AvailableChangeVersion>("/availableChangeVersions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAvailableChangeVersions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
