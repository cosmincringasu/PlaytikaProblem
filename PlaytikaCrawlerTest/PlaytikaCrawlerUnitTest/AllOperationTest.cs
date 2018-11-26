using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaytikaCrawlerTest;
using PlaytikaCrawlerTest.Helpers;

namespace PlaytikaCrawlerUnitTest
{
    [TestClass]
    public class AllOperationTest
    {

        [TestMethod]
        public void Operation_BadStartDirectory()
        {

            string[] args = { string.Empty, SharedConstants.InputAction.All, string.Empty };

            bool expected = false;

            bool result = ValidationHelper.ValidateInput(args, out string startDirectory, out string action, out string resultFilePath);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Operation_CorrectStartDirectory()
        {

            string[] args = { @"C:\", SharedConstants.InputAction.All};

            bool expected = true;

            bool result = ValidationHelper.ValidateInput(args, out string startDirectory, out string action, out string resultFilePath);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Operation_BadAction()
        {

            string[] args = { @"C:\", "all1", string.Empty };

            bool expected = false;

            bool result = ValidationHelper.ValidateInput(args, out string startDirectory, out string action, out string resultFilePath);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Operation_CorrrectAction()
        {

            string[] args = { @"C:\", SharedConstants.InputAction.Cs};

            bool expected = true;

            bool result = ValidationHelper.ValidateInput(args, out string startDirectory, out string action, out string resultFilePath);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Operation_BadResultFile()
        {

            string[] args = { @"C:\", SharedConstants.InputAction.Cs, "C:\result.jpeg" };

            bool expected = false;

            bool result = ValidationHelper.ValidateInput(args, out string startDirectory, out string action, out string resultFilePath);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Operation_CorrectResultFile()
        {

            string[] args = { @"C:\", SharedConstants.InputAction.Cs};

            bool expected = true;

            bool result = ValidationHelper.ValidateInput(args, out string startDirectory, out string action, out string resultFilePath);

            Assert.AreEqual(expected, result);
        }

    }
}