using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas.Code;

namespace Katas.Tests
{
    [TestClass]
    public class StringTests
    {
        public StringTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ReverseStringTest()
        {
            // Arrange
            var stringHelper = new StringHelper();
            var inputString = "ASDFGQWERTY";
            var expectedResult = "YTREWQGFDSA";

            // Act
            var result = stringHelper.ReverseString(inputString);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WordCountTest()
        {
            // Arrange
            var stringHelper = new StringHelper();
            var inputString1 = "the night is dark and full of terrors";
            var expectedResult1 = 8;
            var inputString2 = "winter is coming";
            var expectedResult2 = 3;

            // Act
            var result1 = stringHelper.WordCount(inputString1);
            var result2 = stringHelper.WordCount(inputString2);

            // Assert
            Assert.AreEqual(expectedResult1, result1);
            Assert.AreEqual(expectedResult2, result2);
        }
    }
}
