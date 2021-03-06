// <copyright file="ProgramTest.cs">Copyright ©  2016</copyright>
using System;
using Hello_World_Test;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hello_World_Test.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {
        /// <summary>Test stub for GetGreeting()</summary>
        [PexMethod]
        internal void GetGreetingTest()
        {
            string result = Program.GetGreeting();

            Assert.AreEqual(result, "Hello github!");
        }
    }
}
