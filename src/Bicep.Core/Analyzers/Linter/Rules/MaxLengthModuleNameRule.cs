// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Bicep.Core.Diagnostics;
using Bicep.Core.Semantics;
using Bicep.Core.Syntax;

namespace Bicep.Core.Analyzers.Linter.Rules
{
    public sealed class MaxLengthModuleNameRule : LinterRuleBase
    {
        public new const string Code = "max-length-module-name";
        public const int MaxLength = 64;

        public MaxLengthModuleNameRule() : base(
            code: Code,
            description: CoreResources.MaxLengthModuleNameRuleDescription,
            docUri: new Uri($"https://aka.ms/bicep/linter/{Code}"),
            diagnosticLevel: DiagnosticLevel.Error
        )
        {
        }

        public override string FormatMessage(params object[] values)
        {
            return string.Format(CoreResources.MaxLengthModuleNameRuleMessageFormat, values);
        }

        public override IEnumerable<IDiagnostic> AnalyzeInternal(SemanticModel model, DiagnosticLevel diagnosticLevel)
        {
            var level = GetDiagnosticLevel(model);

            foreach (var module in model.Root.ModuleDeclarations)
            {
                if (module.TryGetBodyPropertyValue(LanguageConstants.ModuleNamePropertyName) is { } nameValue &&
                    (nameValue as StringSyntax)?.TryGetLiteralValue() is { } literalName &&
                    literalName.Length > MaxLength)
                {
                    yield return CreateDiagnosticForSpan(level, nameValue.Span, literalName.Length, MaxLength);
                }
            }
        }
    }
}
