using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace List.Tests
{
    class LinkedListTests
    {
        [TestCase(15, new int[] { 11 }, new int[] {11, 15 })]
        [TestCase(-10, new int[] { 60, 90, 120, 150, 180 }, new int[] { 60, 90, 120, 150, 180, -10 })]
        public void Test1(int a, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.Add(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 15, 30, 60, 90, 120, 150, 180 })]
        [TestCase(5, new int[] { 30, 60, 90, 150, 180 }, new int[] { 5, 30, 60, 90, 150, 180 })]
        public void Test2(int a, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.AddFirst(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(15, 3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 15, 120, 150, 180 })]
        [TestCase(1, 1, new int[] { 30, 60, 90 }, new int[] { 30, 1, 60, 90 })]
        public void Test3(int a, int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.AddByIndex(a, index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150 })]
        [TestCase(new int[] { 30, 60, 90 }, new int[] { 30, 60 })]
        public void Test4(int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveByEnd();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 60, 90, 120, 150, 180 })]
        [TestCase(new int[] { 150, 180 }, new int[] { 180 })]
        public void Test5(int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveFirst();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150 })]
        [TestCase(1, new int[] { 30, 60, 90 }, new int[] { 30, 90 })]
        public void Test6(int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveByIndex(index);
            Assert.AreEqual(expected, actual);
        }


        //[TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120 })]
        //[TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        //public void Test7(int n, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.RemovingValuesFromEnd(n);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 120, 150, 180 })]
        //[TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 90, 120, 150, 180 })]
        //public void Test8(int n, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.RemovingValuesFromBeginning(n);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(3, 3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        //[TestCase(2, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 150, 180 })]
        //public void Test9(int index, int number, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.RemovingValuesByIndex(index, number);
        //    Assert.AreEqual(expected, actual);
        //}


        [TestCase(90, new int[] { 30, 60, 90, 120, 150, 180 }, 2)]
        [TestCase(180, new int[] { 30, 60, 90, 120, 150, 180 }, 5)]
        [TestCase(18, new int[] { 30, 60, 90, 120, 150, 180 }, -1)]
        public void Test10(int value, int[] actualArray, int expected)
        {
            LinkedList actualArrayList = new LinkedList(actualArray);
            int actual = actualArrayList.SearchIndexValue(value);
            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 10, 30, 60, 90, 120, 150, 180 }, new int[] { 180, 150, 120, 90, 60, 30, 10 })]
        //[TestCase(new int[] { 15, 30, 60 }, new int[] { 60, 30, 15 })]
        //public void Test11(int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.Revers();
        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 190)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 90)]
        public void Test12(int[] actualArray, int expected)
        {
            LinkedList actualArrayList = new LinkedList(actualArray);
            int actual = actualArrayList.SearchMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, -1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 7)]
        public void Test13(int[] actualArray, int expected)
        {
            LinkedList actualArrayList = new LinkedList(actualArray);
            int actual = actualArrayList.SearchMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 4)]
        [TestCase(new int[] { 10, 30, 60, 7, -90, 90 }, 5)]
        public void Test14(int[] actualArray, int expected)
        {
            LinkedList actualArrayList = new LinkedList (actualArray);
            int actual = actualArrayList.SearchIndexMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 3)]
        public void Test15(int[] actualArray, int expected)
        {
            LinkedList actualArrayList = new LinkedList(actualArray);
            int actual = actualArrayList.SearchIndexMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        //[TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 0, 15, 30, 90, 180, 1200 })]
        //[TestCase(new int[] { -30, -60, -90 }, new int[] { -90, -60, -30 })]
        //public void Test16(int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.SortAscending();
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 1200, 180, 90, 30, 15, 0 })]
        //[TestCase(new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        //public void Test17(int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.SortDescending();
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        //[TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 0, 180 })]
        //[TestCase(0, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        //public void Test18(int value, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.RemoveTheFirstByValue(value);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        //[TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 180 })]
        //[TestCase(-30, new int[] { -30, -30, -90 }, new int[] { -90 })]
        //[TestCase(-20, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        //public void Test19(int value, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    actual.RemoveAllByValue(value);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(1, new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 15, 180, 0, 90, 1200, 15, 180 })]
        //[TestCase(3, new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 777, 777, 777, 1200, 15, 180 })]
        //[TestCase(0, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        //public void Test20(int index, int[] arrayList, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    ArrayList list = new ArrayList(arrayList);
        //    actual.AddArrayByIndex(list, index);
        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 15, 180 })]
        //[TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 777, 777, 777 })]
        //[TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        //public void Test21(int[] arrayList, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    ArrayList list = new ArrayList(arrayList);
        //    actual.AddArray(list);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 15, 180, 30, 0, 90, 1200, 15, 180 })]
        //[TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 777, 777, 777, 30, 0, 90, 1200, 15, 180 })]
        //[TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        //public void Test22(int[] arrayList, int[] actualArray, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    ArrayList list = new ArrayList(arrayList);
        //    actual.AddArrayFromBiginning(list);
        //    Assert.AreEqual(expected, actual);
        //}



        ////NEGATIVE TESTS


        //[TestCase(15, -2, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(1, 4, new int[] { 30, 60, 90 })]
        //public void Tes23(int a, int index, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<IndexOutOfRangeException>(() => actual.AddValueByIndex(a, index));
        //}

        //[TestCase(-2, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(3, new int[] { 30, 60, 90 })]
        //public void Tes24(int index, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValueByIndex(index));
        //}


        //[TestCase(-2, 1, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(3, 1, new int[] { 30, 60, 90 })]
        //public void Tes24(int index, int number, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<IndexOutOfRangeException>(() => actual.RemovingValuesByIndex(index, number));
        //}


        //[TestCase(2, 5, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(2, 2, new int[] { 30, 60, 90 })]
        //public void Tes25(int index, int number, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesByIndex(index, number));

        //}
        //[TestCase(2, 0, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(2, -2, new int[] { 30, 60, 90 })]
        //public void Tes29(int index, int number, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesByIndex(index, number));
        //}


        //[TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(10, new int[] { 30, 60, 90 })]
        //public void Tes26(int number, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesFromBeginning(number));
        //}

        //[TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(-2, new int[] { 30, 60, 90 })]
        //public void Tes30(int number, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesFromBeginning(number));
        //}




        //[TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(10, new int[] { 30, 60, 90 })]
        //public void Tes27(int number, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesFromEnd(number));
        //}

        //[TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(-2, new int[] { 30, 60, 90 })]
        //public void Tes31(int number, int[] actualArray)
        //{
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesFromEnd(number));
        //}


        //[TestCase(-2, new int[] { 15, 180 }, new int[] { 30, 60, 90, 120, 150, 180 })]
        //[TestCase(10, new int[] { 15, 180 }, new int[] { 30, 60, 90 })]
        //public void Tes28(int index, int[] addArray, int[] actualArray)
        //{
        //    ArrayList list = new ArrayList(addArray);
        //    ArrayList actual = new ArrayList(actualArray);
        //    Assert.Throws<IndexOutOfRangeException>(() => actual.AddArrayByIndex(list, index));
        //}



    }
}
