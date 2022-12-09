// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Bicep.Core.Analyzers.Linter.Rules;
using Bicep.Core.Diagnostics;
using Bicep.Core.UnitTests.Assertions;
using Bicep.Core.UnitTests.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bicep.Core.UnitTests.Diagnostics.LinterRuleTests
{
    [TestClass]
    public class MaxLengthModuleNameRuleTests : LinterRuleTestsBase
    {
        [TestMethod]
        public void ActualAndMaxLengthInFormattedMessage()
        {
            var ruleToTest = new MaxLengthModuleNameRule();
            ruleToTest.GetMessage(100, 64).Should().Be("The name for this module has a length of 100, which exceeds the maximum of 64.");
        }

        [DataTestMethod]
        public void If_ModuleNameLength_UnderMaxLength_ShouldPass()
        {
            var result = CompilationHelper.Compile(
                ("main.bicep", @"
                    module m1 'module1.bicep' = {
                      name: 'ashortmodulename'
                      scope: subscription()
                    }
                "),
                ("module1.bicep", @"
                    targetScope = 'subscription'
                    resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
                      name: 'name'
                      location: 'global'
                    }
                ")
            );

            result.Diagnostics.Should().BeEmpty();
        }

        [DataTestMethod]
        public void If_ModuleNameLength_AboveMaxLength_ShouldFail()
        {
            var result = CompilationHelper.Compile(
                ("main.bicep", @"
                    module m1 'module1.bicep' = {
                      name: 'averyloooooooooooooooooooooooooooooooooooooooooooooooooooooooooongname'
                      scope: subscription()
                    }
                "),
                ("module1.bicep", @"
                    targetScope = 'subscription'
                    resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
                      name: 'name'
                      location: 'global'
                    }
                ")
            );

            result.Diagnostics.Should().HaveDiagnostics(new[]
            {
                (MaxLengthModuleNameRule.Code, DiagnosticLevel.Error, "The name for this module has a length of 70, which exceeds the maximum of 64."),
            });
        }
    }
}
