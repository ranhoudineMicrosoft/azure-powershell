// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// FirewallPolicyIdpsSignaturesOperations operations.
    /// </summary>
    public partial interface IFirewallPolicyIdpsSignaturesOperations
    {
        /// <summary>
        /// Retrieves the current status of IDPS signatures for the relevant policy.
        /// Maximal amount of returned signatures is 1000.
        /// </summary>
        /// <remarks>
        /// Retrieves the current status of IDPS signatures for the relevant policy.
        /// Maximal amount of returned signatures is 1000.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='parameters'>
        /// 
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<QueryResults>> ListWithHttpMessagesAsync(string resourceGroupName, string firewallPolicyName, IdpsQueryObject parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}