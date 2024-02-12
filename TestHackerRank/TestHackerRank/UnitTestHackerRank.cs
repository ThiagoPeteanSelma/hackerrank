using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHackerRank.Class.Problem;

namespace TestHackerRank
{
    [TestClass]
    public class UnitTestHackerRank
    {
        [TestMethod]
        public void FizzBuzz_UnitTest()
        {
            string wait = @"1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n";
            Assert.AreEqual(wait, FizzBuzz.fizzBuzz(15));
        }

        [TestMethod]
        public void Compare_UnitTest()
        {
            List<int> wait = new() { 1, 1 }, result = Compare.compare(new List<int>() { 3, 6, 5 }, new List<int> { 2, 6, 8 });

            Assert.AreEqual(string.Join(" ", wait), string.Join(" ", result));
        }

        [TestMethod]
        public void DiagonalDifference_UnitTest()
        {
            Assert.AreEqual(1, DiagonalDifference.diagonalDifference(new List<List<int>>() { new List<int>() { 1, 2, 1, 2 }, new List<int> { 2, 1, 2, 3 }, new List<int> { 1, 2, 1, 5 }, new List<int> { 1, 2, 1, 5 } }));
        }

        [TestMethod]
        public void PlusMinus_UnitTest()
        {
            var result = PlusMinus.plusMinus(new List<int>() { 1, 1, 0, -1, -1 });

            Assert.AreEqual("0,400000\\r\\n0,400000\\r\\n0,200000", result);
        }

        [TestMethod]
        public void Staircase_UnitTest()
        {
            var r = StairCase.stairCase(4);
            Assert.AreEqual("   #\\r\\n  ##\\r\\n ###\\r\\n####", r);
        }
        [TestMethod]
        public void MiniMaxSum_UnitTest()
        {
            Assert.AreEqual("2063136757 2744467344", MiniMaxSum.miniMaxSum(new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 }));
        }
        [TestMethod]
        public void TimeConversion_UnitTest()
        {
            Assert.AreEqual("19:05:45", TimeConversion.timeConversion("07:05:45PM"));
        }
        [TestMethod]
        public void MiddleList_UnitTest()
        {
            Assert.AreEqual(3, MiddleList.middleList(new List<int>() { 3, 1, 2, 4, 5 }));
        }
        [TestMethod]
        public void LonelyInteger_UnitTest()
        {
            Assert.AreEqual(4, LonelyInteger.lonelyInteger(new List<int>() { 1, 2, 3, 4, 3, 2, 1 }));
        }
    }
}