using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace List.Tests
{
    class DoubleDoubleLinkedListTests
    {
        [TestCase(15, new int[] { 11 }, new int[] { 11, 15 })]
        [TestCase(-10, new int[] { 60, 90, 120, 150, 180 }, new int[] { 60, 90, 120, 150, 180, -10 })]
        public void Test1(int a, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.Add(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 15, 30, 60, 90, 120, 150, 180 })]
        [TestCase(5, new int[] { 30, 60, 90, 150, 180 }, new int[] { 5, 30, 60, 90, 150, 180 })]
        public void Test2(int a, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.AddFirst(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 2, new int[] { 30, 60, 90 }, new int[] { 30,  60, 2, 90 })]
        [TestCase(1, 5, new int[] { 30, 60, 90 }, new int[] { 30, 5, 60, 90 })]
        public void Test3(int index, int value, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150 })]
        [TestCase(new int[] { 30, 60, 90 }, new int[] { 30, 60 })]
        public void Test4(int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveEnd();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 60, 90, 120, 150, 180 })]
        [TestCase(new int[] { 150, 180 }, new int[] { 180 })]
        public void Test5(int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveFirst();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150 })]
        [TestCase(1, new int[] { 30, 60, 90 }, new int[] { 30, 90 })]
        [TestCase(0, new int[] { 30, 60, 90 }, new int[] { 60, 90 })]
        public void Test6(int index, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveByIndex(index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120 })]
        [TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        [TestCase(6, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { })]
        public void Test7(int n, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveValuesFromEnd(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 120, 150, 180 })]
        [TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 90, 120, 150, 180 })]
        public void Test8(int n, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveValuesFromBeginning(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        [TestCase(2, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 150, 180 })]
        [TestCase(0, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 90, 120, 150, 180 })]
        [TestCase(1, 1, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 90, 120, 150, 180 })]
        [TestCase(4, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, })]
        [TestCase(1, 5, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30 })]
        [TestCase(0, 6, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { })]
        public void Test9(int index, int number, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveValuesByIndex(index, number);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(90, new int[] { 30, 60, 90, 120, 150, 180 }, 2)]
        [TestCase(180, new int[] { 30, 60, 90, 120, 150, 180 }, 5)]
        [TestCase(18, new int[] { 30, 60, 90, 120, 150, 180 }, -1)]
        public void Test10(int value, int[] actualArray, int expected)
        {
            DoubleLinkedList actualDoubleLinkedList = new DoubleLinkedList(actualArray);
            int actual = actualDoubleLinkedList.SearchIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 30, 60, 90, 120, 150, 180 }, new int[] { 180, 150, 120, 90, 60, 30, 10 })]
        [TestCase(new int[] { 15, 30, 60 }, new int[] { 60, 30, 15 })]
        public void Test11(int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.Revers();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 190)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 90)]
        public void Test12(int[] actualArray, int expected)
        {
            DoubleLinkedList actualDoubleLinkedList = new DoubleLinkedList(actualArray);
            int actual = actualDoubleLinkedList.SearchMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, -1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 7)]
        public void Test13(int[] actualArray, int expected)
        {
            DoubleLinkedList actualDoubleLinkedList = new DoubleLinkedList(actualArray);
            int actual = actualDoubleLinkedList.SearchMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 4)]
        [TestCase(new int[] { 10, 30, 60, 7, -90, 90 }, 5)]
        public void Test14(int[] actualArray, int expected)
        {
            DoubleLinkedList actualDoubleLinkedList = new DoubleLinkedList(actualArray);
            int actual = actualDoubleLinkedList.SearchIndexMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 3)]
        public void Test15(int[] actualArray, int expected)
        {
            DoubleLinkedList actualDoubleLinkedList = new DoubleLinkedList(actualArray);
            int actual = actualDoubleLinkedList.SearchIndexMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 0, 15, 30, 90, 180, 1200 })]
        [TestCase(new int[] { -30, -60, -90 }, new int[] { -90, -60, -30 })]
        public void Test16(int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.SortAscending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 1200, 180, 90, 30, 15, 0 })]
        [TestCase(new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void Test17(int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.SortDescending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 0, 180 })]
        [TestCase(0, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void Test18(int value, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveTheFirstByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 180 })]
        [TestCase(-30, new int[] { -30, -30 }, new int[] { })]
        [TestCase(-20, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void Test19(int value, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            actual.RemoveAllByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 15, 180, 0, 90, 1200, 15, 180 })]
        [TestCase(3, new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 777, 777, 777, 1200, 15, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void Test20(int index, int[] DoubleLinkedList, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            DoubleLinkedList list = new DoubleLinkedList(DoubleLinkedList);
            actual.AddListByIndex(index, list);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 15, 180 })]
        [TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 777, 777, 777 })]
        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void Test21(int[] DoubleLinkedList, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            DoubleLinkedList list = new DoubleLinkedList(DoubleLinkedList);
            actual.AddListFromEnd(list);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 15, 180, 30, 0, 90, 1200, 15, 180 })]
        [TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 777, 777, 777, 30, 0, 90, 1200, 15, 180 })]
        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void Test22(int[] DoubleLinkedList, int[] actualArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            DoubleLinkedList list = new DoubleLinkedList(DoubleLinkedList);
            actual.AddListFromBeginning(list);
            Assert.AreEqual(expected, actual);
        }



        //NEGATIVE TESTS


        [TestCase(15, -2, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(1, 4, new int[] { 30, 60, 90 })]
        public void Tes23(int value, int index, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddByIndex(index, value));
        }

        [TestCase(-2, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(3, new int[] { 30, 60, 90 })]
        public void Tes24(int index, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveByIndex(index));
        }


        [TestCase(-2, 1, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(3, 1, new int[] { 30, 60, 90 })]
        public void Tes24(int index, int number, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));
        }


        [TestCase(2, 5, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(2, 2, new int[] { 30, 60, 90 })]
        public void Tes25(int index, int number, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));

        }
        [TestCase(2, 0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(2, -2, new int[] { 30, 60, 90 })]
        public void Tes29(int index, int number, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));
        }


        [TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 30, 60, 90 })]
        public void Tes26(int number, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromBeginning(number));
        }

        [TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(-2, new int[] { 30, 60, 90 })]
        public void Tes30(int number, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromBeginning(number));
        }




        [TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 30, 60, 90 })]
        public void Tes27(int number, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromEnd(number));
        }

        [TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(-2, new int[] { 30, 60, 90 })]
        public void Tes31(int number, int[] actualArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromEnd(number));
        }


        [TestCase(-2, new int[] { 15, 180 }, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 15, 180 }, new int[] { 30, 60, 90 })]
        public void Tes28(int index, int[] addArray, int[] actualArray)
        {
            DoubleLinkedList list = new DoubleLinkedList(addArray);
            DoubleLinkedList actual = new DoubleLinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddListByIndex(index, list));
        }



    }
}
