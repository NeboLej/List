﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace List.Tests
{
    class ArrayListTests
    {
        [TestCase(15, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150, 180, 15 })]
        [TestCase(-10, new int[] { 60, 90, 120, 150, 180 }, new int[] { 60, 90, 120, 150, 180, -10 })]
        public void Add_intValue_ShouldAddValue(int a, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.Add(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 15, 30, 60, 90, 120, 150, 180 })]
        [TestCase(5, new int[] { 30, 60, 90, 150, 180 }, new int[] { 5, 30, 60, 90, 150, 180 })]
        public void AddFirst_intValue_ShouldAddValueFromBeginning(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddToTheBeginning(value);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(15, 3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 15, 120, 150, 180 })]
        [TestCase(1, 1, new int[] { 30, 60, 90 }, new int[] { 30, 1, 60, 90 })]
        public void AddByIndex_IndexExistsInTheList_ShouldAddValueByIndex(int values, int index, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueByIndex(values, index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150 })]
        [TestCase(new int[] { 30, 60, 90 }, new int[] { 30, 60 })]
        public void RemoveEnd_ListNotEmpty_ShouldRemoveEndValue(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueFromEnd();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 60, 90, 120, 150, 180 })]
        [TestCase(new int[] { 150, 180 }, new int[] { 180 })]
        public void RemoveFirst_ListNotEmpty_ShouldRemoveFirstValue(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueFromBeginning();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 120, 150, 180 })]
        [TestCase(1, new int[] { 30, 60, 90 }, new int[] { 30, 90 })]
        public void RemoveByIndex_IndexExistsInTheList_ShouldRemoveValueByIndex(int index, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueByIndex(index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120 })]
        [TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromEnd_NumberNoMoreLengthList_ShouldRemoveValuesByIndex(int n, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemovingValuesFromEnd(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 120, 150, 180 })]
        [TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 90, 120, 150, 180 })]
        public void RemoveValuesFromBeginning_NumberNoMoreLengthList_ShouldRemoveValuesFromBegining(int n, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValuesFromBeginning(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        [TestCase(2, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 150, 180 })]
        public void RemoveValuesByIndex_NumberNoMoreLengthList_ShouldRemoveValuesByIndex(int index, int number, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValuesByIndex(index, number);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(90, new int[] { 30, 60, 90, 120, 150, 180 }, 2)]
        [TestCase(180, new int[] { 30, 60, 90, 120, 150, 180 }, 5)]
        [TestCase(18, new int[] { 30, 60, 90, 120, 150, 180 }, -1)]
        public void SearchIndexValue_IndexExistsInTheList_ShouldIndexByValue(int value, int[] actualArray, int expected)
        {
            ArrayList actualArrayList = new ArrayList(actualArray);
            int actual = actualArrayList.SearchIndexValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 30, 60, 90, 120, 150, 180 }, new int[] { 180, 150, 120, 90, 60, 30, 10 })]
        [TestCase(new int[] { 15, 30, 60 }, new int[] { 60, 30, 15 })]
        public void Revers_ShouldReversList(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.Revers();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 190)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 90)]
        public void SearchMaximumValue_ListNotEmpty_ShouldMaximumValue(int[] actualArray, int expected)
        {
            ArrayList actualArrayList = new ArrayList(actualArray);
            int actual = actualArrayList.SearchMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, -1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 7)]
        public void SearchMinimumValue_ListNotEmpty_ShouldMinimumValue(int[] actualArray, int expected)
        {
            ArrayList actualArrayList = new ArrayList(actualArray);
            int actual = actualArrayList.SearchMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 4)]
        [TestCase(new int[] { 10, 30, 60, 7, -90, 90 }, 5)]
        public void SearchIndexMaximumValue_ListNotEmpty_ShouldIndexMaximumValue(int[] actualArray, int expected)
        {
            ArrayList actualArrayList = new ArrayList(actualArray);
            int actual = actualArrayList.SearchIndexMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 3)]
        public void TestSearchIndexMinimumValue_ListNotEmpty_ShouldIndexMinimumValue(int[] actualArray, int expected)
        {
            ArrayList actualArrayList = new ArrayList(actualArray);
            int actual = actualArrayList.SearchIndexMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 0, 15, 30, 90, 180, 1200 })]
        [TestCase(new int[] { -30, -60, -90 }, new int[] { -90, -60, -30 })]
        public void SortAscending_ListNotEmpty_ShouldListSortedInAscending(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.SortAscending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 1200, 180, 90, 30, 15, 0 })]
        [TestCase(new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void SortDescending_ListNotEmpty_ShouldListSortedInDescending(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.SortDescending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 0, 180 })]
        [TestCase(0, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void RemoveTheFirstByValue_ListNotEmpty_ShouldRemoveTheFirstByValue(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveTheFirstByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 180 })]
        [TestCase(-30, new int[] { -30, -30, -90 }, new int[] { -90 })]
        [TestCase(-20, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void RemoveAllByValue_ListNotEmpty_ShouldRemoveAllByValue(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveAllByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 15, 180, 0, 90, 1200, 15, 180 })]
        [TestCase(3, new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 777, 777, 777, 1200, 15, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void AddArrayListByIndex_IndexExistsInTheList_ShouldAddList(int index, int[] arrayList, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            ArrayList list = new ArrayList(arrayList);
            actual.AddArrayByIndex(list, index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 15, 180 })]
        [TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 777, 777, 777 })]
        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void AddArray_IndexExistsInTheList_ShouldAddListFromEnd(int[] arrayList, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            ArrayList list = new ArrayList(arrayList);
            actual.AddArray(list);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 15, 180, 30, 0, 90, 1200, 15, 180 })]
        [TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 777, 777, 777, 30, 0, 90, 1200, 15, 180 })]
        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void AddArrayFromBeginning_IndexExistsInTheList_ShouldAddList(int[] arrayList, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            ArrayList list = new ArrayList(arrayList);
            actual.AddArrayFromBiginning(list);
            Assert.AreEqual(expected, actual);
        }



        //NEGATIVE TESTS


        [TestCase(15, -2, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(1, 4, new int[] { 30, 60, 90 })]
        public void AddByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int a, int index, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddValueByIndex(a, index));
        }

        [TestCase(-2, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(3, new int[] { 30, 60, 90 })]
        public void RemoveByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int index, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValueByIndex(index));
        }


        [TestCase(-2, 1, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(3, 1, new int[] { 30, 60, 90 })]
        public void RemoveValuesByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int index, int number, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));
        }


        [TestCase(2, 5, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(2, 2, new int[] { 30, 60, 90 })]
        public void RemoveValuesByIndex_WhenRemoveMoreThanTheListhas_ShouldArgumentOutOfRangeException(int index, int number, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));

        }
        [TestCase(2, 0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(2, -2, new int[] { 30, 60, 90 })]
        public void RemoveValuesByIndex_WhenRemoveNegativeQuantity_ShouldArgumentOutOfRangeException(int index, int number, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));
        }


        [TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromBeginning_WhenRemoveMoreThanTheListhas_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromBeginning(number));
        }

        [TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(-2, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromBeginning_WhenRemoveNegativeQuantity_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromBeginning(number));
        }




        [TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromEnd_WhenRemoveMoreThanTheListhas_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesFromEnd(number));
        }

        [TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(-2, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromEnd_WhenRemoveNegativeQuantity_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemovingValuesFromEnd(number));
        }


        [TestCase(-2, new int[] { 15, 180 }, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 15, 180 }, new int[] { 30, 60, 90 })]
        public void AddListByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int index, int[] addArray, int[] actualArray)
        {
            ArrayList list = new ArrayList(addArray);
            ArrayList actual = new ArrayList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddArrayByIndex(list, index));
        }



    }
}
