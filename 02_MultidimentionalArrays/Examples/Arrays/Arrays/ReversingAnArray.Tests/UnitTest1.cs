using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversingAnArray;

namespace ReversingAnArray.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsReversingElementsOfAnOddArrayElementsSizeInToNewOne()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedResultArray = { 5, 4, 3, 2, 1 };
            int size = array.Length;

            int[] reversed = new int[size];

            StartUp.GetElementsInReversedOrder(array, reversed);

            CollectionAssert.AreEqual(reversedResultArray, reversed);
        }

        [TestMethod]
        public void IsReversingElementsOfAnEavenArrayElementsSizeInToNewOne()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int[] reversedResultArray = { 6, 5, 4, 3, 2, 1 };
            int size = array.Length;

            int[] reversed = new int[size];

            StartUp.GetElementsInReversedOrder(array, reversed);

            CollectionAssert.AreEqual(reversedResultArray, reversed);
        }
    }
}