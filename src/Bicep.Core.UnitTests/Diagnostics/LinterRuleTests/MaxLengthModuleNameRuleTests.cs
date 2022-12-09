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

        [DataRow(@"
            module m1 'module1.bicep' = {
                name: '64characterslooooooooooooooooooooooooooooooooooooooooooooongname'
                scope: subscription()
            }
        ", false)]
        [DataRow(@"
            module m1 'module1.bicep' = {
                name: '65charactersloooooooooooooooooooooooooooooooooooooooooooooongname'
                scope: subscription()
            }
        ", true)]
        [DataTestMethod]
        public void Rule_Should_FailOrPass_AsExpected(string bicepThatUsesModule, bool shouldFailOnRule)
        {
            var result = CompilationHelper.Compile(
                ("main.bicep", bicepThatUsesModule),
                ("module1.bicep", @"
                    targetScope = 'subscription'
                    resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
                      name: 'name'
                      location: 'global'
                    }
                ")
            );

            if (shouldFailOnRule)
            {
                result.Diagnostics.Should().HaveDiagnostics(new[]
                {
                    (MaxLengthModuleNameRule.Code, DiagnosticLevel.Error, "The name for this module has a length of 65, which exceeds the maximum of 64."),
                });
            }

            else
            {
                result.Diagnostics.Should().BeEmpty();
            }
        }
    }
}
