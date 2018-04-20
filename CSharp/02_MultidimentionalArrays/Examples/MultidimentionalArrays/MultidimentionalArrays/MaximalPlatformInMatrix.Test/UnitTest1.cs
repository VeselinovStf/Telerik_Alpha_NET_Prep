using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximalPlatformInMatrix.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaximalPlatformIsEqualToExpected()
        {
            int[,] matrix = {
                   { 0, 2, 4, 0, 9, 5 },
                   { 7, 1, 3, 3, 2, 1 },
                   { 1, 3, 9, 8, 5, 6 },
                   { 4, 6, 7, 9, 1, 0 }
            };

            int expected = 33;
            int actual = StartUp.FindMaximalPlatformSum(matrix);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximalPlatformIsNotEqualToExpected()
        {
            int[,] matrix = {
                   { 0, 2, 4, 0, 9, 5 },
                   { 7, 1, 9, 9, 2, 1 },
                   { 1, 3, 9, 9, 5, 6 },
                   { 4, 6, 7, 9, 1, 0 }
            };

            int expected = 33;
            int actual = StartUp.FindMaximalPlatformSum(matrix);

            Assert.AreNotEqual(expected, actual);
        }
    }
}