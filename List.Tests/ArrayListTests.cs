using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace List.Tests
{
    class ArrayListTests
    {
        [TestCase(15, new int[] { 30, 60, 90, 120, 150, 180, 15 })]
        public void Test1(int a, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.Add(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 15, 30, 60, 90, 120, 150, 180 })]
        public void Test2(int a, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.AddToTheBeginning(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(15, 3, new int[] { 30, 60, 90, 15, 120, 150, 180 })]
        public void Test3(int a, int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.AddValueByIndex(a, index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150 })]
        public void Test4(int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.RemoveValueFromEnd();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 60, 90, 120, 150, 180 })]
        public void Test5(int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.RemoveValueFromBeginning();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 30, 60, 120, 150, 180 })]
        public void Test6(int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.RemoveValueByIndex(index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 30, 60, 90, 120 })]
        public void Test7(int n, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.RemovingValuesFromEnd(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 120, 150, 180 })]
        public void Test8(int n, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.RemovingValuesFromBeginning(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3 , 3 , new int[] { 30, 60, 90 })]
        public void Test9(int index, int number, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.RemovingValuesByIndex(index, number);
            Assert.AreEqual(expected, actual);


        }
    }
}
