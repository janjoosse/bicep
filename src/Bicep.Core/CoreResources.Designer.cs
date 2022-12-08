﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicep.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CoreResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CoreResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bicep.Core.CoreResources", typeof(CoreResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;adminUserName&apos; should not use a literal value. Use a param instead..
        /// </summary>
        internal static string AdminUsernameShouldNotBeLiteralRuleDescription {
            get {
                return ResourceManager.GetString("AdminUsernameShouldNotBeLiteralRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If an &apos;{0}&apos; parameter is provided, an &apos;{1}&apos; parameter must also be provided..
        /// </summary>
        internal static string ArtifactsLocationRule_Error_ParamMissing {
            get {
                return ResourceManager.GetString("ArtifactsLocationRule_Error_ParamMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Artifacts parameter &apos;{0}&apos; must use the @secure() attribute.
        /// </summary>
        internal static string ArtifactsLocationRule_Error_ParamMustBeSecure {
            get {
                return ResourceManager.GetString("ArtifactsLocationRule_Error_ParamMustBeSecure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Artifacts parameter &apos;{0}&apos; must be of type &apos;{1}&apos;.
        /// </summary>
        internal static string ArtifactsLocationRule_Error_ParamMustBeType {
            get {
                return ResourceManager.GetString("ArtifactsLocationRule_Error_ParamMustBeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change parameter type to &apos;{0}&apos;.
        /// </summary>
        internal static string ArtifactsLocationRule_FixTitle_ChangeType {
            get {
                return ResourceManager.GetString("ArtifactsLocationRule_FixTitle_ChangeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom bicepconfig.json file found ({0})..
        /// </summary>
        internal static string BicepConfigCustomSettingsFoundFormatMessage {
            get {
                return ResourceManager.GetString("BicepConfigCustomSettingsFoundFormatMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No bicepconfig.json found for configuration override..
        /// </summary>
        internal static string BicepConfigNoCustomSettingsMessage {
            get {
                return ResourceManager.GetString("BicepConfigNoCustomSettingsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some decompiler imperfections may need to be cleaned up manually.
        /// </summary>
        internal static string DecompilerImperfectionsRule_Description {
            get {
                return ResourceManager.GetString("DecompilerImperfectionsRule_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consider renaming it and removing the suffix (using the editor&apos;s rename functionality)..
        /// </summary>
        internal static string DecompilerImperfectionsRule_MayWantToRename {
            get {
                return ResourceManager.GetString("DecompilerImperfectionsRule_MayWantToRename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The symbolic name of resource &apos;{0}&apos; appears to have originated from a naming conflict during a decompilation from JSON..
        /// </summary>
        internal static string DecompilerImperfectionsRule_Resource {
            get {
                return ResourceManager.GetString("DecompilerImperfectionsRule_Resource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of variable &apos;{0}&apos; appears to have originated from a naming conflict during a decompilation from JSON..
        /// </summary>
        internal static string DecompilerImperfectionsRule_Variable {
            get {
                return ResourceManager.GetString("DecompilerImperfectionsRule_Variable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment URLs should not be hardcoded. Use the environment() function to ensure compatibility across clouds..
        /// </summary>
        internal static string EnvironmentUrlHardcodedRuleDescription {
            get {
                return ResourceManager.GetString("EnvironmentUrlHardcodedRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation: {0}..
        /// </summary>
        internal static string InterpolateNotConcatFixTitle {
            get {
                return ResourceManager.GetString("InterpolateNotConcatFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation instead of the concat function..
        /// </summary>
        internal static string InterpolateNotConcatRuleDescription {
            get {
                return ResourceManager.GetString("InterpolateNotConcatRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Linter is disabled in settings file located at {0} .
        /// </summary>
        internal static string LinterDisabledFormatMessage {
            get {
                return ResourceManager.GetString("LinterDisabledFormatMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzer &apos;{0}&apos; encountered an unexpected exception. {1}.
        /// </summary>
        internal static string LinterRuleExceptionMessageFormat {
            get {
                return ResourceManager.GetString("LinterRuleExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource location should be specified by a parameter without a default value or one that defaults to &apos;global&apos; or resourceGroup().location..
        /// </summary>
        internal static string LocationSetByParameterRuleDescription {
            get {
                return ResourceManager.GetString("LocationSetByParameterRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module name is exceeding max length..
        /// </summary>
        internal static string MaxLengthModuleNameRuleDescription {
            get {
                return ResourceManager.GetString("MaxLengthModuleNameRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name for this module has a length of {0}, which exceeds the maximum of {1}..
        /// </summary>
        internal static string MaxLengthModuleNameRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxLengthModuleNameRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum number of outputs used..
        /// </summary>
        internal static string MaxNumberOutputsRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberOutputsRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many outputs. Number of outputs is limited to {0}..
        /// </summary>
        internal static string MaxNumberOutputsRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberOutputsRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum number of parameters used..
        /// </summary>
        internal static string MaxNumberParametersRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberParametersRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many parameters. Number of parameters is limited to {0}..
        /// </summary>
        internal static string MaxNumberParametersRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberParametersRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum number of resources used..
        /// </summary>
        internal static string MaxNumberResourcesRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberResourcesRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many resources. Number of resources is limited to {0}..
        /// </summary>
        internal static string MaxNumberResourcesRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberResourcesRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum number of variables used..
        /// </summary>
        internal static string MaxNumberVariablesRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberVariablesRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many variables. Number of variables is limited to {0}..
        /// </summary>
        internal static string MaxNumberVariablesRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberVariablesRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A resource location should not use a hard-coded string or variable value. Change variable &apos;{0}&apos; into a parameter instead..
        /// </summary>
        internal static string NoHardcodedLocation_ErrorChangeVarToParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorChangeVarToParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; may be used as a resource location in the module and should not be assigned a hard-coded string or variable value..
        /// </summary>
        internal static string NoHardcodedLocation_ErrorForModuleParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorForModuleParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A resource location should not use a hard-coded string or variable value..
        /// </summary>
        internal static string NoHardcodedLocation_ErrorForResourceLocation {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorForResourceLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use a parameter value, an expression, or the string &apos;{0}&apos;. Found: &apos;{1}&apos;.
        /// </summary>
        internal static string NoHardcodedLocation_ErrorSolution {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change variable &apos;{0}&apos; into a parameter instead.
        /// </summary>
        internal static string NoHardcodedLocation_FixChangeVarToParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_FixChangeVarToParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new parameter &apos;{0}&apos; with default value {1}.
        /// </summary>
        internal static string NoHardcodedLocation_FixNewParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_FixNewParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; of module &apos;{1}&apos; isn&apos;t assigned an explicit value, and its default value may not give the intended behavior for a location-related parameter. You should assign an explicit value to the parameter..
        /// </summary>
        internal static string NoHardcodedLocation_ModuleLocationNeedsExplicitValue {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ModuleLocationNeedsExplicitValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A resource location should be either an expression or the string &apos;{0}&apos;. Found &apos;{1}&apos;.
        /// </summary>
        internal static string NoHardcodedLocation_ResourceLocationShouldBeExpressionOrGlobal {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ResourceLocationShouldBeExpressionOrGlobal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A resource&apos;s location should not use a hard-coded string or variable value. It should use a parameter, an expression, or the string &apos;global&apos;..
        /// </summary>
        internal static string NoHardcodedLocationRuleDescription {
            get {
                return ResourceManager.GetString("NoHardcodedLocationRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Functions resourceGroup().location and deployment().location should only be used as the default value of a parameter..
        /// </summary>
        internal static string NoLocExprOutsideParamsRuleDescription {
            get {
                return ResourceManager.GetString("NoLocExprOutsideParamsRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use a parameter here instead of &apos;{0}&apos;. &apos;resourceGroup().location&apos; and &apos;deployment().location&apos; should only be used as a default value for parameters..
        /// </summary>
        internal static string NoLocExprOutsideParamsRuleError {
            get {
                return ResourceManager.GetString("NoLocExprOutsideParamsRuleError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No unnecessary dependsOn..
        /// </summary>
        internal static string NoUnnecessaryDependsOnRuleDescription {
            get {
                return ResourceManager.GetString("NoUnnecessaryDependsOnRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary dependsOn entry &apos;{0}&apos;..
        /// </summary>
        internal static string NoUnnecessaryDependsOnRuleMessage {
            get {
                return ResourceManager.GetString("NoUnnecessaryDependsOnRuleMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function &apos;{0}&apos;.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsFunction {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsFunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Found possible secret: {1}.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsMessageFormat {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to output name &apos;{0}&apos; suggests a secret.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsOutputName {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsOutputName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outputs should not contain secrets..
        /// </summary>
        internal static string OutputsShouldNotContainSecretsRuleDescription {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to secure parameter &apos;{0}&apos;.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsSecureParam {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsSecureParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All parameters must be used..
        /// </summary>
        internal static string ParameterMustBeUsedRuleDescription {
            get {
                return ResourceManager.GetString("ParameterMustBeUsedRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &quot;{0}&quot; is declared but never used..
        /// </summary>
        internal static string ParameterMustBeUsedRuleMessageFormat {
            get {
                return ResourceManager.GetString("ParameterMustBeUsedRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function &apos;{0}&apos;.
        /// </summary>
        internal static string PossibleSecretMessageFunction {
            get {
                return ResourceManager.GetString("PossibleSecretMessageFunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to secure parameter &apos;{0}&apos;.
        /// </summary>
        internal static string PossibleSecretMessageSecureParam {
            get {
                return ResourceManager.GetString("PossibleSecretMessageSecureParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove quotes from property name &apos;{0}&apos;.
        /// </summary>
        internal static string PreferUnquotedPropertyNames_DeclarationFixTitle {
            get {
                return ResourceManager.GetString("PreferUnquotedPropertyNames_DeclarationFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace array syntax with &apos;{0}&apos;.
        /// </summary>
        internal static string PreferUnquotedPropertyNames_DereferenceFixTitle {
            get {
                return ResourceManager.GetString("PreferUnquotedPropertyNames_DereferenceFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property names that are valid identifiers should be declared without quotation marks and accessed using dot notation..
        /// </summary>
        internal static string PreferUnquotedPropertyNamesRule_Description {
            get {
                return ResourceManager.GetString("PreferUnquotedPropertyNamesRule_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use protectedSettings for commandToExecute secrets.
        /// </summary>
        internal static string ProtectCommandToExecuteSecretsRuleDescription {
            get {
                return ResourceManager.GetString("ProtectCommandToExecuteSecretsRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use protectedSettings for commandToExecute secrets. Found possible secret: {0}.
        /// </summary>
        internal static string ProtectCommandToExecuteSecretsRuleMessage {
            get {
                return ResourceManager.GetString("ProtectCommandToExecuteSecretsRuleMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameters that represent secrets must be secure..
        /// </summary>
        internal static string SecretsInParamsRule_Description {
            get {
                return ResourceManager.GetString("SecretsInParamsRule_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; may represent a secret (according to its name) and must be declared with the &apos;@secure()&apos; attribute..
        /// </summary>
        internal static string SecretsInParamsRule_MessageFormat {
            get {
                return ResourceManager.GetString("SecretsInParamsRule_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove insecure default value..
        /// </summary>
        internal static string SecureParameterDefaultFixTitle {
            get {
                return ResourceManager.GetString("SecureParameterDefaultFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secure parameters should not have hardcoded defaults (except for empty or newGuid())..
        /// </summary>
        internal static string SecureParameterDefaultRuleDescription {
            get {
                return ResourceManager.GetString("SecureParameterDefaultRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outer-scoped nested deployment resources should not be used for secure parameters or list* functions..
        /// </summary>
        internal static string SecureParamsInNestedDeployRule_Description {
            get {
                return ResourceManager.GetString("SecureParamsInNestedDeployRule_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is an outer scoped nested deployment that calls a list* function (&quot;{1}&quot;), which could expose sensitive values in deployment history..
        /// </summary>
        internal static string SecureParamsInNestedDeployRule_Message_ListFunction {
            get {
                return ResourceManager.GetString("SecureParamsInNestedDeployRule_Message_ListFunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is an outer scoped nested deployment that accesses secure string parameters ({1}), which could expose their values in deployment history..
        /// </summary>
        internal static string SecureParamsInNestedDeployRule_Message_SecureParams {
            get {
                return ResourceManager.GetString("SecureParamsInNestedDeployRule_Message_SecureParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either set the deployment&apos;s properties.expressionEvaluationOptions.scope to &apos;inner&apos; or use a Bicep module instead..
        /// </summary>
        internal static string SecureParamsInNestedDeployRule_Solution {
            get {
                return ResourceManager.GetString("SecureParamsInNestedDeployRule_Solution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary string interpolation..
        /// </summary>
        internal static string SimplifyInterpolationFixTitle {
            get {
                return ResourceManager.GetString("SimplifyInterpolationFixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary string interpolation..
        /// </summary>
        internal static string SimplifyInterpolationRuleDescription {
            get {
                return ResourceManager.GetString("SimplifyInterpolationRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All existing resources must be used..
        /// </summary>
        internal static string UnusedExistingResourceRuleDescription {
            get {
                return ResourceManager.GetString("UnusedExistingResourceRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existing resource &quot;{0}&quot; is declared but never used..
        /// </summary>
        internal static string UnusedExistingResourceRuleMessageFormat {
            get {
                return ResourceManager.GetString("UnusedExistingResourceRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All variables must be used..
        /// </summary>
        internal static string UnusedVariableRuleDescription {
            get {
                return ResourceManager.GetString("UnusedVariableRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable &quot;{0}&quot; is declared but never used..
        /// </summary>
        internal static string UnusedVariableRuleMessageFormat {
            get {
                return ResourceManager.GetString("UnusedVariableRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Acceptable versions: {0}.
        /// </summary>
        internal static string UseRecentApiVersionRule_AcceptableVersions {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_AcceptableVersions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use recent API versions.
        /// </summary>
        internal static string UseRecentApiVersionRule_Description {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use more recent API version for &apos;{0}&apos;. {1}.
        /// </summary>
        internal static string UseRecentApiVersionRule_ErrorMessageFormat {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_ErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace with {0}.
        /// </summary>
        internal static string UseRecentApiVersionRule_Fix_ReplaceApiVersion {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_Fix_ReplaceApiVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a preview version and there is a more recent non-preview version available..
        /// </summary>
        internal static string UseRecentApiVersionRule_MoreRecentStable {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_MoreRecentStable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a preview version and there is a non-preview version available with the same date..
        /// </summary>
        internal static string UseRecentApiVersionRule_StableWithSameDate {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_StableWithSameDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is {1} days old, should be no more than {2} days old, or the most recent..
        /// </summary>
        internal static string UseRecentApiVersionRule_TooOld {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_TooOld", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find resource type &quot;{0}&quot;..
        /// </summary>
        internal static string UseRecentApiVersionRule_UnknownType {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_UnknownType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did you mean &quot;{0}&quot;?.
        /// </summary>
        internal static string UseRecentApiVersionRule_UnknownTypeSuggestion {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_UnknownTypeSuggestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find apiVersion {0} for {1}..
        /// </summary>
        internal static string UseRecentApiVersionRule_UnknownVersion {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRule_UnknownVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Properties representing a resource ID must be generated appropriately..
        /// </summary>
        internal static string UseResourceIdFunctionsRule_Description {
            get {
                return ResourceManager.GetString("UseResourceIdFunctionsRule_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If property &quot;{0}&quot; represents a resource ID, it must use a symbolic resource reference, be a parameter or start with one of these functions: {1}..
        /// </summary>
        internal static string UseResourceIdFunctionsRule_MessageFormat {
            get {
                return ResourceManager.GetString("UseResourceIdFunctionsRule_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found nonconforming expression at {0}.
        /// </summary>
        internal static string UseResourceIdFunctionsRule_NonConformingExprPath {
            get {
                return ResourceManager.GetString("UseResourceIdFunctionsRule_NonConformingExprPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource identifiers should be reproducible outside of their initial deployment context. .
        /// </summary>
        internal static string UseStableResourceIdentifiersMessage {
            get {
                return ResourceManager.GetString("UseStableResourceIdentifiersMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource identifiers should be reproducible outside of their initial deployment context. Resource {0}&apos;s &apos;{1}&apos; identifier is potentially nondeterministic due to its use of the &apos;{2}&apos; function ({3})..
        /// </summary>
        internal static string UseStableResourceIdentifiersMessageFormat {
            get {
                return ResourceManager.GetString("UseStableResourceIdentifiersMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual machines shouldn&apos;t use preview images..
        /// </summary>
        internal static string UseStableVMImage {
            get {
                return ResourceManager.GetString("UseStableVMImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual machines shouldn&apos;t use preview images. Use stable version in imageReference property &quot;{0}&quot;..
        /// </summary>
        internal static string UseStableVMImageRuleFixMessageFormat {
            get {
                return ResourceManager.GetString("UseStableVMImageRuleFixMessageFormat", resourceCulture);
            }
        }
    }
}
