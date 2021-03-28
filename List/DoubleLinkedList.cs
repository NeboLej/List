using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class DoubleLinkedList
    {
        public int Length { get; private set; }
        private DoubleNode _root;
        private DoubleNode _tail;

        public int this[int index]
        {
            get
            {
                DoubleNode current = _root;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }

            set
            {
                DoubleNode current = _root;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                current.Value = value;
            }
        }
        public DoubleLinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }
        public DoubleLinkedList(int value)
        {
            Length = 1;
            _root = new DoubleNode(value);
            _tail = _root;
        }
        public DoubleLinkedList(int[] values)
        {
            if (values.Length != 0)
            {
                Length = 1;
                _root = new DoubleNode(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    Add(values[i]);
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }


        public void Add(int value)
        {
            if (Length != 0)
            {
                Length++;
                //DoubleNode tmp = _tail;
                _tail.Next = new DoubleNode(value);
                _tail.Next.Previous = _tail;
                _tail = _tail.Next;
                //Console.WriteLine($"значение рута = {_root.Value} значение первиуса = {_tail.Previous.Value} значение тейла = {_tail.Value}");

            }
            else
            {
                Length++;
                _tail = new DoubleNode(value);
                _root = _tail;

            }



        }
        public void AddByIndex(int index, int value)
        {
            if (index == Length)
            {
                Add(value);
            }
            else if (index == 0)
            {
                AddFirst(value);
            }
            else if (index < 0 || index >= Length)
            {
                Console.WriteLine("ошибка");
            }
            else if (index <= Length / 2)
            {
                DoubleNode current = _root;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                current.Next.Previous = new DoubleNode(value);
                current.Next.Previous.Next = current.Next;
                current.Next = current.Next.Previous;
                current.Next.Previous = current;
                Length++;
            }
            else
            {
                if (index > Length / 2)
                {
                    DoubleNode current = _tail;
                    for (int i = Length - 1; i > index; i--)
                    {
                        current = current.Previous;
                    }
                    current.Previous.Next = new DoubleNode(value);
                    current.Previous.Next.Previous = current.Previous;
                    current.Previous = current.Previous.Next;
                    current.Previous.Next = current;
                    Length++;

                }
            }
        }
        public void AddFirst(int value)
        {
            _root.Previous = new DoubleNode(value);
            _root.Previous.Next = _root;
            _root = _root.Previous;
            Length++;
        }

        public void RemoveByIndex(int index)
        {
            if (index >= Length || index < 0)
            {
                Console.WriteLine("Ошибка");
            }
            else if (index == 0)
            {
                RemoveFirst();
            }
            else if(index == Length - 1)
            {
                RemoveEnd();
            }
            else if(index <= Length / 2)
            {
                DoubleNode current = _root;
                for(int i = 1; i<index; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                current.Next.Previous = current;
                Length--;
            }
            else
            {
                DoubleNode current = _tail;
                for (int i = Length-2; i > index; i--)
                {
                    current = current.Previous;
                }
                current.Previous = current.Previous.Previous;
                current.Previous.Next = current;
                Length--;
            }
        }
        public void RemoveFirst()
        {
            _root = _root.Next;
            _root.Previous = null;
            Length--;
        }
        public void RemoveEnd()
        {
            _tail = _tail.Previous;
            _tail.Next = null;
            Length--;
        }

        public void RemoveValuesByIndex(int index, int number)
        {

            if (index >= Length || index < 0)
            {
                Console.WriteLine("Ошибка");
            }
            else if (index+number > Length)
            {
                Console.WriteLine("Ошибка");
            }
            else if (index == 0 && number == Length)
            {
                Empty();
            }
            else if (index+number == Length)
            {
                RemoveValuesFromEnd(number);
            }
            else if (index == 0)
            {
                RemoveValuesFromBiginning(number);
            }
            
            else if (index <= Length / 2)
            {
                DoubleNode current = _root;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                DoubleNode tmp = current;
                for (int i = 0; i<number; i++)
                {
                    current = current.Next;
                }
                tmp.Next = current.Next;
                current.Previous = tmp;
                Length -= number;
            }
            else
            {
                DoubleNode current = _tail;
                for (int i = Length - 1; i >= index; i--)
                {
                    current = current.Previous;
                }
                DoubleNode tmp = current;
                for (int i = 0; i < number; i++)
                {
                    current = current.Next;
                }
                tmp.Next = current.Next;
                current.Previous = tmp;
                Length -= number;
            }
        }
        public void RemoveValuesFromEnd(int number)
        {
            DoubleNode current = _tail;
            for(int i = 1; i<=number; i++)
            {
                current = current.Previous;
            }
            _tail = current;
            current.Next = null;
            Length -= number;
        }
        public void RemoveValuesFromBiginning(int number)
        {
            DoubleNode current = _root;
            for(int i = 1; i<=number; i++)
            {
                current = current.Next;
            }
            _root = current;
            current.Previous = null;
            Length -= number;
        }

        public int SearchIndexByValue(int value)
        {
            DoubleNode current = _root;
            for(int i = 0; i<Length-1; i++)
            {
                if(current.Value == value)
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }
        public int SearchIndexMaximumValue()
        {
            int[] values = new int[2];
            values = SearchIndexAndValueMaximumElement();
            return values[0];
        }
        public int SearchMaximumValue()
        {
            int[] values = new int[2];
            values = SearchIndexAndValueMaximumElement();
            return values[1];
        }
        public int SearchIndexMinimumValue()
        {
            int[] values = new int[2];
            values = SearchIndexAndValueMinimumElement();
            return values[0];

        }
        public int SearchMinimumValue()
        {
            int[] values = new int[2];
            values = SearchIndexAndValueMinimumElement();
            return values[1];

        }

        public void SortAscending()
        {
            int[] firstElement = new int[2];
            firstElement = SearchIndexAndValueMinimumElement();
            RemoveByIndex(firstElement[0]);
            DoubleLinkedList tmpList = new DoubleLinkedList(firstElement[1]);

            while (Length != 0)
            {
                int[] minimum = SearchIndexAndValueMinimumElement();
                RemoveByIndex(minimum[0]);
                tmpList.Add(minimum[1]);
            }
            this._root = tmpList._root;
            Length = tmpList.Length;
        }
        public void SortDescending()
        {
            int[] firstElement = new int[2];
            firstElement = SearchIndexAndValueMaximumElement();
            RemoveByIndex(firstElement[0]);
            DoubleLinkedList tmpList = new DoubleLinkedList(firstElement[1]);

            while (Length != 0)
            {
                int[] maximum = SearchIndexAndValueMaximumElement();
                RemoveByIndex(maximum[0]);
                tmpList.Add(maximum[1]);
            }
            this._root = tmpList._root;
            Length = tmpList.Length;
        }

        public void RemoveTheFirstByValue(int value)
        {

            int index = SearchIndexByValue(value);
            if (index != -1)
            {
                RemoveByIndex(index);
            }
        }
        public void RemoveAllByValue(int value)
        {
            int index = SearchIndexByValue(value);
            while (index != -1)
            {
                RemoveByIndex(index);
                index = SearchIndexByValue(value);
            }
        }

        public void Revers()
        {
            DoubleNode currentOne = _root;
            DoubleNode currentTwo = _tail;


            for (int i = 0; i<Length/2; i++)
            {
                int tmp = currentOne.Value;
                currentOne.Value = currentTwo.Value;
                currentTwo.Value = tmp;
                currentOne = currentOne.Next;
                currentTwo = currentTwo.Previous;
            }
        }
        public void AddListFromBiginning(DoubleLinkedList list)
        {
            DoubleNode currentList = list._tail;
            for(int i =1; i <=list.Length; i++)
            {
                AddFirst(currentList.Value);
                currentList = currentList.Previous;
            }
        }
        public void AddListByIndex(int index, DoubleLinkedList list)
        {
            if (index >= Length || index < 0)
            {
                Console.WriteLine("Ошибка");
            }
            else if (index == 0)
            {
                AddListFromBiginning(list);
            }
            else if (index <= Length/2)
            {
                DoubleNode currentThis = _root;
                for (int i = 1; i < index; i++)
                {
                     currentThis = currentThis.Next;
                }
                DoubleNode tmp1 = currentThis.Next;
                DoubleNode currentList = list._root;
                for (int i = 0; i < list.Length; i++)
                {
                   DoubleNode tmp2 = currentThis.Next;
                   currentThis.Next = new DoubleNode(currentList.Value);
                   currentThis.Next.Next = tmp2;
                   currentList = currentList.Next;
                   currentThis = currentThis.Next;
                }
                currentThis.Next = tmp1;
                Length += list.Length;
            }
            else
            {
                DoubleNode currentThis = _tail;
                for (int i = 1; i <= Length-index; i++)
                {
                    currentThis = currentThis.Previous;
                }
                DoubleNode tmp1 = currentThis.Next;
                DoubleNode currentList = list._root;
                for (int i = 0; i < list.Length; i++)
                {
                    DoubleNode tmp2 = currentThis.Next;
                    currentThis.Next = new DoubleNode(currentList.Value);
                    currentThis.Next.Next = tmp2;
                    currentList = currentList.Next;
                    currentThis = currentThis.Next;
                }
                currentThis.Next = tmp1;
                Length += list.Length;


            }

        }
        public void AddListByEnd(DoubleLinkedList list)
        {
            DoubleNode currentList = list._root;
            for(int i =1; i<=list.Length; i++)
            {
                Add(currentList.Value);
                currentList = currentList.Next;
            }
        }

        public override bool Equals(object obj)
        {
            DoubleLinkedList list = (DoubleLinkedList)obj;
            if (this.Length != list.Length)
            {
                return false;
            }

            DoubleNode currentThis = this._root;
            DoubleNode currentList = list._root;
            if (currentList is null && currentThis is null)
            {
                return true;
            }

            while (!(currentThis.Next is null))
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentList = currentList.Next;
                currentThis = currentThis.Next;
            }
            if (currentList.Value != currentThis.Value)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            if (Length != 0)
            {
                DoubleNode current = _root;
                string s = current.Value + " ";

                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += current.Value + " ";
                }
                return s;

            }
            else
            {
                return String.Empty;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        private int[] SearchIndexAndValueMaximumElement()
        {
            int indexMaxElement = 0;
            int maxElement = _root.Value;
            DoubleNode current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value > maxElement)
                {
                    maxElement = current.Value;
                    indexMaxElement = i;
                }
                current = current.Next;
            }
            return new int[] { indexMaxElement, maxElement };

        }
        private int[] SearchIndexAndValueMinimumElement()
        {
            int indexMinElement = 0;
            int minElement = _root.Value;
            DoubleNode current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value < minElement)
                {
                    minElement = current.Value;
                    indexMinElement = i;
                }
                current = current.Next;
            }
            return new int[] { indexMinElement, minElement };

        }


        private void Empty()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }


    }
}
