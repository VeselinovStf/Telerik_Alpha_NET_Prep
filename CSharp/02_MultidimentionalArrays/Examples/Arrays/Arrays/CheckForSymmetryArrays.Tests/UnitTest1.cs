using System;
using CheckForSymmetricArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckForSymmetryArrays.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OddElementsArraysAreSymmetric()
        {
            int[] array = { 1, 2, 3, 2, 1 };

            Assert.IsTrue(StartUp.CheckForSymmetryIntArray(array));
        }

        [TestMethod]
        public void EavenElementsArraysAreSymmetric()
        {
            int[] array = { 1, 2, 2, 1 };

            Assert.IsTrue(StartUp.CheckForSymmetryIntArray(array));
        }

        [TestMethod]
        public void OddElementsArraysAreNotSymmetric()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Assert.IsFalse(StartUp.CheckForSymmetryIntArray(array));
        }

        [TestMethod]
        public void EavenElementsArraysAreNotSymmetric()
        {
            int[] array = { 1, 2, 4, 5 };

            Assert.IsFalse(StartUp.CheckForSymmetryIntArray(array));
        }
    }
}