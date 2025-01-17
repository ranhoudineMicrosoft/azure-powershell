// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Savings plan order alias</summary>
    public partial class SavingsPlanOrderAliasModel :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModel,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.Resource();

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 14)]
        public string AppliedScopePropertyDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyDisplayName = value ?? null; }

        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 15)]
        public string AppliedScopePropertyManagementGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyManagementGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyManagementGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 16)]
        public string AppliedScopePropertyResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyResourceGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 17)]
        public string AppliedScopePropertySubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertySubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertySubscriptionId = value ?? null; }

        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 18)]
        public string AppliedScopePropertyTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopePropertyTenantId = value ?? null; }

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 13)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopeType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType)""); }

        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 12)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).BillingPlan; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).BillingPlan = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan)""); }

        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 10)]
        public string BillingScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).BillingScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).BillingScopeId = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 5)]
        public double? CommitmentAmount { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).CommitmentAmount; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).CommitmentAmount = value ?? default(double); }

        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 6)]
        public string CommitmentCurrencyCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).CommitmentCurrencyCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).CommitmentCurrencyCode = value ?? null; }

        /// <summary>Commitment grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 7)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain? CommitmentGrain { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).CommitmentGrain; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).CommitmentGrain = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain)""); }

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 1)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 2)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>Resource provider kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Internal Acessors for AppliedScopeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModelInternal.AppliedScopeProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopeProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).AppliedScopeProperty = value; }

        /// <summary>Internal Acessors for Commitment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ICommitment Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModelInternal.Commitment { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).Commitment; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).Commitment = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.SavingsPlanOrderAliasProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SavingsPlanOrderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModelInternal.SavingsPlanOrderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).SavingsPlanOrderId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).SavingsPlanOrderId = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasModelInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasProperties _property;

        /// <summary>Savings plan order alias properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.SavingsPlanOrderAliasProperties()); set => this._property = value; }

        /// <summary>Provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 9)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Identifier of the savings plan created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 8)]
        public string SavingsPlanOrderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).SavingsPlanOrderId; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku _sku;

        /// <summary>Savings plan SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.Sku()); set => this._sku = value; }

        /// <summary>Name of the SKU to be applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 4)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType)""); }

        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 11)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).Term; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasPropertiesInternal)Property).Term = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 3)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="SavingsPlanOrderAliasModel" /> instance.</summary>
        public SavingsPlanOrderAliasModel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Savings plan order alias
    public partial interface ISavingsPlanOrderAliasModel :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResource
    {
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the management group where the benefit must be applied.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the resource group.",
        SerializedName = @"resourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant ID where the benefit is applied.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.",
        SerializedName = @"billingPlan",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription that will be charged for purchasing the benefit",
        SerializedName = @"billingScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingScopeId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amount",
        PossibleTypes = new [] { typeof(double) })]
        double? CommitmentAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ISO 4217 3-letter currency code for the currency used by this purchase record.",
        SerializedName = @"currencyCode",
        PossibleTypes = new [] { typeof(string) })]
        string CommitmentCurrencyCode { get; set; }
        /// <summary>Commitment grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Commitment grain.",
        SerializedName = @"grain",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain? CommitmentGrain { get; set; }
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Resource provider kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource provider kind",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get; set; }
        /// <summary>Provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Identifier of the savings plan created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Identifier of the savings plan created",
        SerializedName = @"savingsPlanOrderId",
        PossibleTypes = new [] { typeof(string) })]
        string SavingsPlanOrderId { get;  }
        /// <summary>Name of the SKU to be applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the SKU to be applied",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represent benefit term in ISO 8601 format.",
        SerializedName = @"term",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
    /// Savings plan order alias
    internal partial interface ISavingsPlanOrderAliasModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal
    {
        /// <summary>Properties specific to applied scope type. Not required if not applicable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get; set; }
        /// <summary>Display name</summary>
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        string BillingScopeId { get; set; }
        /// <summary>Commitment towards the benefit.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ICommitment Commitment { get; set; }

        double? CommitmentAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        string CommitmentCurrencyCode { get; set; }
        /// <summary>Commitment grain.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CommitmentGrain? CommitmentGrain { get; set; }
        /// <summary>Display name</summary>
        string DisplayName { get; set; }
        /// <summary>Resource provider kind</summary>
        string Kind { get; set; }
        /// <summary>Savings plan order alias properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderAliasProperties Property { get; set; }
        /// <summary>Provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Identifier of the savings plan created</summary>
        string SavingsPlanOrderId { get; set; }
        /// <summary>Savings plan SKU</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku Sku { get; set; }
        /// <summary>Name of the SKU to be applied</summary>
        string SkuName { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
}