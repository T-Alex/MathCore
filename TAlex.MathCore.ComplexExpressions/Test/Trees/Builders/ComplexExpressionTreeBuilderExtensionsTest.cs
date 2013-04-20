﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using TAlex.MathCore.ExpressionEvaluation.Trees;
using TAlex.MathCore.ExpressionEvaluation.Trees.Builders;
using TAlex.MathCore.LinearAlgebra;
using System.Globalization;


namespace TAlex.MathCore.ComplexExpressions.Test.Trees.Builders
{
    [TestFixture]
    public class ComplexExpressionTreeBuilderExtensionsTest
    {
        protected FunctionFactory<Object> FunctionFactory;
        protected ConstantFlyweightFactory<Object> ConstantFactory;
        protected ComplexExpressionTreeBuilder ExpressionTreeBuilder;

        [SetUp]
        public void SetUp()
        {
            var targetAssembly = typeof(TAlex.MathCore.ExpressionEvaluation.ComplexExpressions.Constants.CatalanConstantExpression).Assembly;

            ConstantFactory = new ConstantFlyweightFactory<object>();
            ConstantFactory.LoadFromAssemblies(new List<Assembly> { targetAssembly });

            FunctionFactory = new FunctionFactory<object>();
            FunctionFactory.LoadFromAssemblies(new List<Assembly> { targetAssembly });

            ExpressionTreeBuilder = new ComplexExpressionTreeBuilder
            {
                ConstantFactory = ConstantFactory,
                FunctionFactory = FunctionFactory
            };
        }

        [Test]
        public void AllFunctionsTest_DecoratedWithDisplayName()
        {
            //action
            var metadata = FunctionFactory.GetMetadata();

            //assert
            foreach (var item in metadata)
            {
                String.IsNullOrWhiteSpace(item.DisplayName).Should().BeFalse();
            }
        }

        [Test]
        public void AllFunctionsTest_DecoratedWithCategory()
        {
            //action
            var metadata = FunctionFactory.GetMetadata();

            //assert
            foreach (var item in metadata)
            {
                String.IsNullOrWhiteSpace(item.Category).Should().BeFalse();
            }
        }

        [Test]
        public void AllFunctionsTest_DecoratedWithDescription()
        {
            //action
            var metadata = FunctionFactory.GetMetadata();

            //assert
            foreach (var item in metadata)
            {
                String.IsNullOrWhiteSpace(item.Description).Should().BeFalse();
            }
        }

        [Test]
        public void AllFunctionsTest_DecoratedWithExampleUsage()
        {
            //action
            var metadata = FunctionFactory.GetMetadata();

            //assert
            foreach (var item in metadata)
            {
                item.ExampleUsages.Count.Should().BeGreaterOrEqualTo(item.Signatures.Count,
                    "Example usages count must be greater or equal signatures count. Target function type: {0}", item.FunctionType);
            }
        }

        [Test]
        public void AllFunctionsTest_ShouldContainsCorrectedExampleUsages()
        {
            //action
            var metadata = FunctionFactory.GetMetadata();

            foreach (var item in metadata)
            {
                foreach (var exampleUsage in item.ExampleUsages)
                {
                    //action
                    Expression<Object> tree = ExpressionTreeBuilder.BuildTree(exampleUsage.Expression);
                    object actual = tree.Evaluate();

                    //assert
                    (actual is Complex || actual is CMatrix).Should().BeTrue();
                    
                    IFormattable formatedResult = (IFormattable)actual;
                    formatedResult.ToString(null, CultureInfo.InvariantCulture).Replace(" ", String.Empty)
                        .Should().Be(exampleUsage.Result.Replace(" ", String.Empty),
                        "Example usage contains inccorect result. Target type: {0}", item.FunctionType);
                }
            }
        }
    }
}