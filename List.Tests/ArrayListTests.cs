using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace List.Tests
{
    class ArrayListTests
    {
        [TestCase(15, new int[] { 30, 60, 90, 120, 150, 180, 15})]
        public void Test1(int a, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.Add(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 15, 30, 60, 90, 120, 150, 180})]
        public void Test2(int a, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
            actual.AddToTheBeginning(a);
            Assert.AreEqual(expected, actual);
        }


        //[TestCase(15, 3, new int[] { 30, 60, 90, 15, 120, 150, 180 })]
        //public void Test3(int a, int index, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
        //    actual.AddByIndex(a, index);
        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(new int[] { 30, 60, 90, 120, 150})]
        //public void Test4(int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
        //    actual.RemoveValueFromTheEnd();
        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(new int[] { 60, 90, 120, 150, 180 })]
        //public void Test5(int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
        //    actual.RemoveValueFromTheBeginning();
        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(2, new int[] { 30, 60, 120, 150, 180 })]
        //public void Test6(int index, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(new int[] { 30, 60, 90, 120, 150, 180 });
        //    actual.RemoveValueByIndex(index);
        //    Assert.AreEqual(expected, actual);
        //}






    }


}
