using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Mobile;

namespace MobilePhone.Tests
{
    [TestClass]
    public class GSMTests
    {
        [TestMethod]
        public void ShoudThrowExceptionIfArgumentModelToCTORIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM(null, "something"));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentManufactorerToCTORIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM("something", null));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentsToCtorARENull()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM(null, null));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentModelToCTORIsEmptyString()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM(string.Empty, "something"));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentManufactorerToCTORIsEmptyString()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM("something", string.Empty));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentsToCtorAREEmptyStrings()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM(string.Empty, string.Empty));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentModelToCTORIsSPACES()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM(string.Empty, "  "));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentManufactorerToCTORIsSpaces()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM("  ", string.Empty));
        }

        [TestMethod]
        public void ShoudThrowExceptionIfArgumentsToCtorARESpaces()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM("  ", "  "));
        }

        [TestMethod]
        public void CtorShoudThrowExceptionIfPriceIsBelowZero()
        {
            Assert.ThrowsException<ArgumentException>(() => new GSM("something", "something", -1));
        }

        [TestMethod]
        public void CheckPriceMethodShoudThrowExceptionIfIsBelowZero()
        {
            Assert.ThrowsException<ArgumentException>(() => GSM.ChechPrice(-1));
        }

        [TestMethod]
        public void CheckOwnerMethodShoudThrowExceptionIfIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => GSM.CheckIfOwnerIsValidString(null));
        }

        [TestMethod]
        public void CheckOwnerMethodShoudThrowExceptionIfIsStringEmpty()
        {
            Assert.ThrowsException<ArgumentException>(() => GSM.CheckIfOwnerIsValidString(string.Empty));
        }

        [TestMethod]
        public void CheckOwnerMethodShoudThrowExceptionIfIsSpaces()
        {
            Assert.ThrowsException<ArgumentException>(() => GSM.CheckIfOwnerIsValidString("  "));
        }
    }
}