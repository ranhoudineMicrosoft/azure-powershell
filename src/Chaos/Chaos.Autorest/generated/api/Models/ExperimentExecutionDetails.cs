// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents the execution details of an Experiment.</summary>
    public partial class ExperimentExecutionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal
    {

        /// <summary>The reason why the execution failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string FailureReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).FailureReason; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>String of the fully qualified resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>String that represents the last action date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastActionAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).LastActionAt; }

        /// <summary>Internal Acessors for FailureReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.FailureReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).FailureReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).FailureReason = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LastActionAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.LastActionAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).LastActionAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).LastActionAt = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ExperimentExecutionDetailsProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RunInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformation Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.RunInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).RunInformation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).RunInformation = value; }

        /// <summary>Internal Acessors for RunInformationStep</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.RunInformationStep { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).RunInformationStep; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).RunInformationStep = value; }

        /// <summary>Internal Acessors for StartedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.StartedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).StartedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).StartedAt = value; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for StoppedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.StoppedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).StoppedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).StoppedAt = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>String of the resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties _property;

        /// <summary>The properties of the experiment execution details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ExperimentExecutionDetailsProperties()); }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The steps of the experiment run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> RunInformationStep { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal)Property).RunInformationStep; }

        /// <summary>String that represents the start date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).StartedAt; }

        /// <summary>The status of the execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).Status; }

        /// <summary>String that represents the stop date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public global::System.DateTime? StoppedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionPropertiesInternal)Property).StoppedAt; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>String of the resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ExperimentExecutionDetails" /> instance.</summary>
        public ExperimentExecutionDetails()
        {

        }
    }
    /// Model that represents the execution details of an Experiment.
    public partial interface IExperimentExecutionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>The reason why the execution failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The reason why the execution failed.",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string FailureReason { get;  }
        /// <summary>String of the fully qualified resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the fully qualified resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>String that represents the last action date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the last action date time.",
        SerializedName = @"lastActionAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastActionAt { get;  }
        /// <summary>String of the resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The steps of the experiment run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The steps of the experiment run.",
        SerializedName = @"steps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> RunInformationStep { get;  }
        /// <summary>String that represents the start date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the start date time.",
        SerializedName = @"startedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartedAt { get;  }
        /// <summary>The status of the execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the execution.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }
        /// <summary>String that represents the stop date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the stop date time.",
        SerializedName = @"stoppedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StoppedAt { get;  }
        /// <summary>String of the resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Model that represents the execution details of an Experiment.
    internal partial interface IExperimentExecutionDetailsInternal

    {
        /// <summary>The reason why the execution failed.</summary>
        string FailureReason { get; set; }
        /// <summary>String of the fully qualified resource ID.</summary>
        string Id { get; set; }
        /// <summary>String that represents the last action date time.</summary>
        global::System.DateTime? LastActionAt { get; set; }
        /// <summary>String of the resource name.</summary>
        string Name { get; set; }
        /// <summary>The properties of the experiment execution details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties Property { get; set; }
        /// <summary>The information of the experiment run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformation RunInformation { get; set; }
        /// <summary>The steps of the experiment run.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> RunInformationStep { get; set; }
        /// <summary>String that represents the start date time.</summary>
        global::System.DateTime? StartedAt { get; set; }
        /// <summary>The status of the execution.</summary>
        string Status { get; set; }
        /// <summary>String that represents the stop date time.</summary>
        global::System.DateTime? StoppedAt { get; set; }
        /// <summary>String of the resource type.</summary>
        string Type { get; set; }

    }
}