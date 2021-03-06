// <copyright file="DietaTest.cs">Copyright ©  2018</copyright>
using System;
using BeInShape;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeInShape.Tests
{
    /// <summary>This class contains parameterized unit tests for Dieta</summary>
    [PexClass(typeof(Dieta))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DietaTest
    {
        /// <summary>Test stub for .ctor(BMI_AF)</summary>
        [PexMethod]
        internal Dieta ConstructorTest(BMI_AF o)
        {
            Dieta target = new Dieta(o);
            return target;
            // TODO: add assertions to method DietaTest.ConstructorTest(BMI_AF)
        }

        /// <summary>Test stub for aktualizacjaDanych()</summary>
        [PexMethod]
        internal string aktualizacjaDanychTest([PexAssumeUnderTest]Dieta target)
        {
            string result = target.aktualizacjaDanych();
            return result;
            // TODO: add assertions to method DietaTest.aktualizacjaDanychTest(Dieta)
        }

        /// <summary>Test stub for wybierzDiete()</summary>
        [PexMethod]
        internal string wybierzDieteTest([PexAssumeUnderTest]Dieta target)
        {
            string result = target.wybierzDiete();
            return result;
            // TODO: add assertions to method DietaTest.wybierzDieteTest(Dieta)
        }
    }
}
