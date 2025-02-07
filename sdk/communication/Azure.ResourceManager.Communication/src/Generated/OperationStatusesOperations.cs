// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Communication.Models;

namespace Azure.ResourceManager.Communication
{
    /// <summary> The OperationStatuses service client. </summary>
    public partial class OperationStatusesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal OperationStatusesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of OperationStatusesOperations for mocking. </summary>
        protected OperationStatusesOperations()
        {
        }

        /// <summary> Initializes a new instance of OperationStatusesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal OperationStatusesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-08-20-preview")
        {
            RestClient = new OperationStatusesRestOperations(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the current status of an async operation. </summary>
        /// <param name="location"> The Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OperationStatus>> GetAsync(string location, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OperationStatusesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(location, operationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the current status of an async operation. </summary>
        /// <param name="location"> The Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OperationStatus> Get(string location, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OperationStatusesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(location, operationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
