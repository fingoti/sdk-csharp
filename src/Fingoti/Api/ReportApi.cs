/*
 * Fingoti API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Fingoti.Client;
using Fingoti.Model;

namespace Fingoti.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve command log
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CommandLogResponse</returns>
        CommandLogResponse GetReportIdCommands(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0);

        /// <summary>
        /// Retrieve command log
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CommandLogResponse</returns>
        ApiResponse<CommandLogResponse> GetReportIdCommandsWithHttpInfo(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0);
        /// <summary>
        /// Retrieve property usage statistics per day per device
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UsageTrackingResponse</returns>
        UsageTrackingResponse GetReportUsage(string? start = default(string?), string? end = default(string?), int operationIndex = 0);

        /// <summary>
        /// Retrieve property usage statistics per day per device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UsageTrackingResponse</returns>
        ApiResponse<UsageTrackingResponse> GetReportUsageWithHttpInfo(string? start = default(string?), string? end = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve command log
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommandLogResponse</returns>
        System.Threading.Tasks.Task<CommandLogResponse> GetReportIdCommandsAsync(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve command log
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommandLogResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandLogResponse>> GetReportIdCommandsWithHttpInfoAsync(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieve property usage statistics per day per device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UsageTrackingResponse</returns>
        System.Threading.Tasks.Task<UsageTrackingResponse> GetReportUsageAsync(string? start = default(string?), string? end = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve property usage statistics per day per device
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UsageTrackingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsageTrackingResponse>> GetReportUsageWithHttpInfoAsync(string? start = default(string?), string? end = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApi : IReportApiSync, IReportApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportApi : IReportApi
    {
        private Fingoti.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportApi(string basePath)
        {
            this.Configuration = Fingoti.Client.Configuration.MergeConfigurations(
                Fingoti.Client.GlobalConfiguration.Instance,
                new Fingoti.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Fingoti.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Fingoti.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Fingoti.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportApi(Fingoti.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Fingoti.Client.Configuration.MergeConfigurations(
                Fingoti.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Fingoti.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Fingoti.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Fingoti.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ReportApi(Fingoti.Client.ISynchronousClient client, Fingoti.Client.IAsynchronousClient asyncClient, Fingoti.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Fingoti.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Fingoti.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Fingoti.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Fingoti.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Fingoti.Client.ExceptionFactory ExceptionFactory
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
        /// Retrieve command log 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CommandLogResponse</returns>
        public CommandLogResponse GetReportIdCommands(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0)
        {
            Fingoti.Client.ApiResponse<CommandLogResponse> localVarResponse = GetReportIdCommandsWithHttpInfo(id, start, end, direction);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve command log 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CommandLogResponse</returns>
        public Fingoti.Client.ApiResponse<CommandLogResponse> GetReportIdCommandsWithHttpInfo(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Fingoti.Client.ApiException(400, "Missing required parameter 'id' when calling ReportApi->GetReportIdCommands");
            }

            Fingoti.Client.RequestOptions localVarRequestOptions = new Fingoti.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fingoti.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fingoti.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Fingoti.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "direction", direction));
            }

            localVarRequestOptions.Operation = "ReportApi.GetReportIdCommands";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CommandLogResponse>("/v1/report/{id}/commands", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReportIdCommands", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve command log 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommandLogResponse</returns>
        public async System.Threading.Tasks.Task<CommandLogResponse> GetReportIdCommandsAsync(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fingoti.Client.ApiResponse<CommandLogResponse> localVarResponse = await GetReportIdCommandsWithHttpInfoAsync(id, start, end, direction, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve command log 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommandLogResponse)</returns>
        public async System.Threading.Tasks.Task<Fingoti.Client.ApiResponse<CommandLogResponse>> GetReportIdCommandsWithHttpInfoAsync(string id, string? start = default(string?), string? end = default(string?), CommandDirection? direction = default(CommandDirection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Fingoti.Client.ApiException(400, "Missing required parameter 'id' when calling ReportApi->GetReportIdCommands");
            }


            Fingoti.Client.RequestOptions localVarRequestOptions = new Fingoti.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fingoti.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fingoti.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Fingoti.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "direction", direction));
            }

            localVarRequestOptions.Operation = "ReportApi.GetReportIdCommands";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CommandLogResponse>("/v1/report/{id}/commands", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReportIdCommands", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve property usage statistics per day per device 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UsageTrackingResponse</returns>
        public UsageTrackingResponse GetReportUsage(string? start = default(string?), string? end = default(string?), int operationIndex = 0)
        {
            Fingoti.Client.ApiResponse<UsageTrackingResponse> localVarResponse = GetReportUsageWithHttpInfo(start, end);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve property usage statistics per day per device 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UsageTrackingResponse</returns>
        public Fingoti.Client.ApiResponse<UsageTrackingResponse> GetReportUsageWithHttpInfo(string? start = default(string?), string? end = default(string?), int operationIndex = 0)
        {
            Fingoti.Client.RequestOptions localVarRequestOptions = new Fingoti.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fingoti.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fingoti.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }

            localVarRequestOptions.Operation = "ReportApi.GetReportUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<UsageTrackingResponse>("/v1/report/usage", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReportUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve property usage statistics per day per device 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UsageTrackingResponse</returns>
        public async System.Threading.Tasks.Task<UsageTrackingResponse> GetReportUsageAsync(string? start = default(string?), string? end = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fingoti.Client.ApiResponse<UsageTrackingResponse> localVarResponse = await GetReportUsageWithHttpInfoAsync(start, end, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve property usage statistics per day per device 
        /// </summary>
        /// <exception cref="Fingoti.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional)</param>
        /// <param name="end"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UsageTrackingResponse)</returns>
        public async System.Threading.Tasks.Task<Fingoti.Client.ApiResponse<UsageTrackingResponse>> GetReportUsageWithHttpInfoAsync(string? start = default(string?), string? end = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Fingoti.Client.RequestOptions localVarRequestOptions = new Fingoti.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fingoti.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fingoti.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fingoti.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }

            localVarRequestOptions.Operation = "ReportApi.GetReportUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<UsageTrackingResponse>("/v1/report/usage", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReportUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
