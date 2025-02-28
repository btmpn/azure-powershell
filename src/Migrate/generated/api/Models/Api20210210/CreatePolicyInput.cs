namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Protection Policy input.</summary>
    public partial class CreatePolicyInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreatePolicyInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputProperties _property;

        /// <summary>Policy creation properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreatePolicyInputProperties()); set => this._property = value; }

        /// <summary>The ReplicationProviderSettings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput ProviderSpecificInput { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputPropertiesInternal)Property).ProviderSpecificInput; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputPropertiesInternal)Property).ProviderSpecificInput = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="CreatePolicyInput" /> instance.</summary>
        public CreatePolicyInput()
        {

        }
    }
    /// Protection Policy input.
    public partial interface ICreatePolicyInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The ReplicationProviderSettings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ReplicationProviderSettings.",
        SerializedName = @"providerSpecificInput",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput ProviderSpecificInput { get; set; }

    }
    /// Protection Policy input.
    internal partial interface ICreatePolicyInputInternal

    {
        /// <summary>Policy creation properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreatePolicyInputProperties Property { get; set; }
        /// <summary>The ReplicationProviderSettings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput ProviderSpecificInput { get; set; }

    }
}