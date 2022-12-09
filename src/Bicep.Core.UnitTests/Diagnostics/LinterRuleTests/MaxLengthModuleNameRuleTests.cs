// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Bicep.Core.Analyzers.Linter.Rules;
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
    }
}