using IsInclude;
using NUnit.Framework;

namespace TestEntryCheck
{
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15 }, new int[] { }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15 }, new int[] { 1, 2, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15 }, new int[] { 3, 5, 7 }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15 }, new int[] { 4, 5, 7 }, false)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15 }, new int[] { 9, 11, 15 }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15, 21, 22, 29, 38, 56, 101 }, new int[] { 11, 15, 21, 22, 29, 38, 56, 101 }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15, 21, 22, 29, 38, 56, 101 }, new int[] { 29, 38, 56, 101 }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15, 21, 22, 29, 38, 56, 101 }, new int[] { 11, 15, 21, 23 }, false)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15, 21, 22, 29, 38, 56, 101 }, new int[] { 11 }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15, 21, 22, 29, 38, 56, 101 }, new int[] { 1 }, true)]
        [TestCase(new int[] { 1, 2, 3, 5, 7, 9, 11, 15, 21, 22, 29, 38, 56, 101 }, new int[] { 101 }, true)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { }, true)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { 0, 5, 7, 9, 9, 9 }, true)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { 9, 9, 9, 9, 9, 10, 11, 15, 21 }, false)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { 9, 9, 9, 10, 11, 15, 21 }, true)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { 0, 0, 0 }, true)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { 101, 101 }, true)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { 0, 0, 0, 5 }, true)]
        [TestCase(new int[] { 0, 0, 0, 5, 7, 9, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { 56, 101, 101, 101 }, true)]
        [TestCase(new int[] { -5, -1, -1, -1, 0, 0, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { -1, -1, 0, 0 }, true)]
        [TestCase(new int[] { -5, -1, -1, -1, 0, 0, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { -1, -1, -1, 0, 0, 0 }, false)]
        [TestCase(new int[] { -5, -1, -1, -1, 0, 0, 9, 9, 9, 10, 11, 15, 21, 22, 29, 38, 56, 101, 101, 101, 101 }, new int[] { -5, -1, -1 }, true)]
        public void TestIsInclude(int[] array, int[] subArray, bool expected)
        {
            // act
            bool actual = EntryCheck.IsInclude(array, subArray);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}