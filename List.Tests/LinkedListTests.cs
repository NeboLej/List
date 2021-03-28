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
        public void Add_intValue_ShouldAddValue(int a, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.Add(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 15, 30, 60, 90, 120, 150, 180 })]
        [TestCase(5, new int[] { 30, 60, 90, 150, 180 }, new int[] { 5, 30, 60, 90, 150, 180 })]
        public void AddFirst_intValue_ShouldAddValueFromBeginning(int value, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(15, 3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 15, 120, 150, 180 })]
        [TestCase(1, 1, new int[] { 30, 60, 90 }, new int[] { 30, 1, 60, 90 })]
        public void AddByIndex_IndexExistsInTheList_ShouldAddValueByIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.AddByIndex(value, index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150 })]
        [TestCase(new int[] { 30, 60, 90 }, new int[] { 30, 60 })]
        public void RemoveEnd_ListNotEmpty_ShouldRemoveEndValue(int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveByEnd();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 60, 90, 120, 150, 180 })]
        [TestCase(new int[] { 150, 180 }, new int[] { 180 })]
        public void RemoveFirst_ListNotEmpty_ShouldRemoveFirstValue(int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveFirst();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120, 150 })]
        [TestCase(1, new int[] { 30, 60, 90 }, new int[] { 30, 90 })]
        [TestCase(0, new int[] { 30, 60, 90 }, new int[] { 60, 90 })]
        public void RemoveByIndex_IndexExistsInTheList_ShouldRemoveValueByIndex(int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveByIndex(index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120 })]
        [TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        [TestCase(6, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { })]
        public void RemoveValuesFromEnd_NumberNoMoreLengthList_ShouldRemoveValuesByIndex(int n, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveValuesFromEnd(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 120, 150, 180 })]
        [TestCase(2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 90, 120, 150, 180 })]
        public void RemoveValuesFromBeginning_NumberNoMoreLengthList_ShouldRemoveValuesFromBegining(int n, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveValuesFromBeginning(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90 })]
        [TestCase(2, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 150, 180 })]
        [TestCase(0, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 90, 120, 150, 180 })]
        [TestCase(1, 1, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 90, 120, 150, 180 })]
        [TestCase(4, 2, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30, 60, 90, 120,})]
        [TestCase(1, 5, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { 30})]
        [TestCase(0, 6, new int[] { 30, 60, 90, 120, 150, 180 }, new int[] { })]
        public void RemoveValuesByIndex_NumberNoMoreLengthList_ShouldRemoveValuesByIndex(int index, int number, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveValuesByIndex(index, number);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(90, new int[] { 30, 60, 90, 120, 150, 180 }, 2)]
        [TestCase(180, new int[] { 30, 60, 90, 120, 150, 180 }, 5)]
        [TestCase(18, new int[] { 30, 60, 90, 120, 150, 180 }, -1)]
        public void SearchIndexValue_IndexExistsInTheList_ShouldIndexByValue(int value, int[] actualArray, int expected)
        {
            LinkedList actualLinkedList = new LinkedList(actualArray);
            int actual = actualLinkedList.SearchIndexValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 30, 60, 90, 120, 150, 180 }, new int[] { 180, 150, 120, 90, 60, 30, 10 })]
        [TestCase(new int[] { 15, 30, 60 }, new int[] { 60, 30, 15 })]
        public void Revers_ShouldReversList(int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.Revers();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 190)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 90)]
        public void SearchMaximumValue_ListNotEmpty_ShouldMaximumValue(int[] actualArray, int expected)
        {
            LinkedList actualLinkedList = new LinkedList(actualArray);
            int actual = actualLinkedList.SearchMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, -1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 7)]
        public void SearchMinimumValue_ListNotEmpty_ShouldMinimumValue(int[] actualArray, int expected)
        {
            LinkedList actualLinkedList = new LinkedList(actualArray);
            int actual = actualLinkedList.SearchMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 4)]
        [TestCase(new int[] { 10, 30, 60, 7, -90, 90 }, 5)]
        public void SearchIndexMaximumValue_ListNotEmpty_ShouldIndexMaximumValue(int[] actualArray, int expected)
        {
            LinkedList actualLinkedList = new LinkedList (actualArray);
            int actual = actualLinkedList.SearchIndexMaximumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, -1, 30, 60, 190, 90, 120, 150, 180 }, 1)]
        [TestCase(new int[] { 10, 30, 60, 7, 90 }, 3)]
        public void SearchIndexMinimumValue_ListNotEmpty_ShouldIndexMinimumValue(int[] actualArray, int expected)
        {
            LinkedList actualLinkedList = new LinkedList(actualArray);
            int actual = actualLinkedList.SearchIndexMinimumValue();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 0, 15, 30, 90, 180, 1200 })]
        [TestCase(new int[] { -30, -60, -90 }, new int[] { -90, -60, -30 })]
        public void SortAscending_ListNotEmpty_ShouldListSortedInAscending(int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.SortAscending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 1200, 180, 90, 30, 15, 0 })]
        [TestCase(new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void SortDescending_ListNotEmpty_ShouldListSortedInDescending(int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.SortDescending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 0, 180 })]
        [TestCase(0, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void RemoveTheFirstByValue_ListNotEmpty_ShouldRemoveTheFirstByValue(int value, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveTheFirstByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 0, 180 }, new int[] { 30, 90, 1200, 15, 180 })]
        [TestCase(-30, new int[] { -30, -30 }, new int[] { })]
        [TestCase(-20, new int[] { -30, -30, -90 }, new int[] { -30, -30, -90 })]
        public void RemoveAllByValue_ListNotEmpty_ShouldRemoveAllByValue(int value, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            actual.RemoveAllByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 15, 180, 0, 90, 1200, 15, 180 })]
        [TestCase(3, new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 777, 777, 777, 1200, 15, 180 })]
        [TestCase(0, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void AddLinkedListByIndex_IndexExistsInTheList_ShouldAddList(int index, int[] LinkedList, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            LinkedList list = new LinkedList(LinkedList);
            actual.AddLinkedListByIndex(list, index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 15, 180 })]
        [TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 777, 777, 777 })]
        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void AddLinkedListFromEnd_IndexExistsInTheList_ShouldAddList(int[] LinkedList, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            LinkedList list = new LinkedList(LinkedList);
            actual.AddLinkedListFromEnd(list);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 15, 180, 30, 0, 90, 1200, 15, 180 })]
        [TestCase(new int[] { 777, 777, 777 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 777, 777, 777, 30, 0, 90, 1200, 15, 180 })]
        [TestCase(new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180 }, new int[] { 30, 0, 90, 1200, 15, 180, 30, 0, 90, 1200, 15, 180 })]
        public void AddLinkedListFromBeginning_IndexExistsInTheList_ShouldAddList(int[] LinkedList, int[] actualArray, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(actualArray);
            LinkedList list = new LinkedList(LinkedList);
            actual.AddLinkedListFromBiginning(list);
            Assert.AreEqual(expected, actual);
        }



        ////NEGATIVE TESTS


        [TestCase(15, -2, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(1, 4, new int[] { 30, 60, 90 })]
        public void AddByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int a, int index, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddByIndex(a, index));
        }

        [TestCase(-2, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(3, new int[] { 30, 60, 90 })]
        public void RemoveByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int index, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveByIndex(index));
        }


        [TestCase(-2, 1, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(3, 1, new int[] { 30, 60, 90 })]
        public void RemoveValuesByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int index, int number, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));
        }


        [TestCase(2, 5, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(2, 2, new int[] { 30, 60, 90 })]
        public void RemoveValuesByIndex_WhenRemoveMoreThanTheListhas_ShouldArgumentOutOfRangeException(int index, int number, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));

        }
        [TestCase(2, 0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(2, -2, new int[] { 30, 60, 90 })]
        public void RemoveValuesByIndex_WhenRemoveNegativeQuantity_ShouldArgumentOutOfRangeException(int index, int number, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesByIndex(index, number));
        }


        [TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromBeginning_WhenRemoveMoreThanTheListhas_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromBeginning(number));
        }

        [TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(-2, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromBeginning_WhenRemoveNegativeQuantity_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromBeginning(number));
        }




        [TestCase(7, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromEnd_WhenRemoveMoreThanTheListhas_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromEnd(number));
        }

        [TestCase(0, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(-2, new int[] { 30, 60, 90 })]
        public void RemoveValuesFromEnd_WhenRemoveNegativeQuantity_ShouldArgumentOutOfRangeException(int number, int[] actualArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveValuesFromEnd(number));
        }


        [TestCase(-2, new int[] { 15, 180 }, new int[] { 30, 60, 90, 120, 150, 180 })]
        [TestCase(10, new int[] { 15, 180 }, new int[] { 30, 60, 90 })]
        public void AddListByIndex_WhenIndexNotExist_ShouldIndexOutOfRangeException(int index, int[] addArray, int[] actualArray)
        {
            LinkedList list = new LinkedList(addArray);
            LinkedList actual = new LinkedList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddLinkedListByIndex(list, index));
        }



    }
}
