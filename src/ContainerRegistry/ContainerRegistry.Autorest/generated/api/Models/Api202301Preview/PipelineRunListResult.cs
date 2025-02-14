// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The result of a request to list pipeline runs for a container registry.</summary>
    public partial class PipelineRunListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPipelineRunListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPipelineRunListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URI that can be used to request the next list of pipeline runs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPipelineRun[] _value;

        /// <summary>
        /// The list of pipeline runs. Since this list may be incomplete, the nextLink field should be used to request the next list
        /// of pipeline runs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPipelineRun[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PipelineRunListResult" /> instance.</summary>
        public PipelineRunListResult()
        {

        }
    }
    /// The result of a request to list pipeline runs for a container registry.
    public partial interface IPipelineRunListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The URI that can be used to request the next list of pipeline runs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI that can be used to request the next list of pipeline runs.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>
        /// The list of pipeline runs. Since this list may be incomplete, the nextLink field should be used to request the next list
        /// of pipeline runs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of pipeline runs. Since this list may be incomplete, the nextLink field should be used to request the next list of pipeline runs.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPipelineRun) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPipelineRun[] Value { get; set; }

    }
    /// The result of a request to list pipeline runs for a container registry.
    internal partial interface IPipelineRunListResultInternal

    {
        /// <summary>The URI that can be used to request the next list of pipeline runs.</summary>
        string NextLink { get; set; }
        /// <summary>
        /// The list of pipeline runs. Since this list may be incomplete, the nextLink field should be used to request the next list
        /// of pipeline runs.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPipelineRun[] Value { get; set; }

    }
}