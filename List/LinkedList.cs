using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                Node current = _root;
                for(int i= 1; i<=index; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }

            set
            {
                Node current = _root;
                for(int i =1; i<=index; i++)
                {
                    current = current.Next;
                }
                current.Value = value;
            }
        }

        private Node _root;
        private Node _tail;

        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }
        public LinkedList(int[] values)
        {
            if(values.Length != 0)
            {
                Length = 1;
                _root = new Node(values[0]);
                _tail = _root;

                for(int i = 1; i < values.Length; i++)
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
        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;

        }



        public void Add(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        
        public void RemoveByIndex(int index)
        {
            Node current = _root;
            //if (index == Length - 1)
            //{
            //    _tail.Next = current;
            //    _tail = _tail.Next;
            //}
            if( index == 0)
            {
                RemoveFirst();
            }
            else 
            {

                for (int i = 1; i < index; i++)
                {
                current = current.Next;
                }
                current.Next = current.Next.Next;
                Length--;
            }

        }
        public void RemoveFirst()
        {
            _root = _root.Next;
            Length--;
        }
        public void RemoveByEnd()
        {
            RemoveByIndex(Length-1);
             Node current = _root;
             _tail.Next = current;
             _tail = _tail.Next;
        }

        public void RemoveTheFirstByValue(int value)
        {

            int index = SearchIndexValue(value);
            if(index !=-1)
            {
                RemoveByIndex(index);
            }
        }
        public void RemoveAllByValue(int value)
        {
            int index = SearchIndexValue(value);
            while(index != -1)
            {
                RemoveByIndex(index);
                index = SearchIndexValue(value);
            }
        }



        public void AddByIndex(int value, int index)
        {
            Node current = _root;
           
            for (int i = 1; i < index; i++)
            {
                current = current.Next;
            }
            Node tmp = current.Next;
            current.Next = new Node(value);
            current.Next.Next = tmp;
            Length++;
        }


        public void RemoveValuesByIndex(int index, int number)
        {
            if (index != 0)
            {
                Node current = _root;
                for(int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                Node tmp = current;
                for(int i = 0; i<number; i++)
                {
                    current = current.Next;
                }
                tmp.Next = current.Next;
                Length -= number;
            }
            else
            {
                RemoveValuesFromBeginning(number);
            }
        }
        public void RemoveValuesFromBeginning(int number)
        {
            if (number != Length)
            {
                for (int i = 0; i < number; i++)
                {
                    _root = _root.Next;
                    Length--;
                }
            }
            else
            {
                Empty();
            }

        }
        public void RemoveValuesFromEnd(int number)
        {
            if (Length != number)
            {
                int index = Length - number;
                RemoveValuesByIndex(index, number);
            }
            else
            {
                Empty();
            }
            //_tail.Next = new Node(value);
            //_tail = _tail.Next;


        }


        public void Revers()
        {
            Node prev = _root;
            Node next = null;
            _tail = _root;
            while (prev != null)
            {
                Node tmp = prev.Next;
                prev.Next = next;
                next = prev;
                prev = tmp;
            }
            _root = next;
        }


        public void AddFirst(int value)
        {
            Length++;
            //Node tmp = new Node(value);
            //tmp.Next = _root;
            //_root = tmp;
            Node current = _root;
            _root = new Node(value);
            _root.Next = current;
        }

        public int SearchIndexValue(int value)
        {
            Node current = _root;
            for(int i = 0; i < Length; i++)
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


        public void AddLinkedListByIndex(LinkedList list, int index)
        {
            if(index != 0)
            {

                Node currentThis = _root;
                for(int i = 1; i < index; i++)
                {
                    currentThis = currentThis.Next;
                }
                Node tmp1 = currentThis.Next;
                Node currentList = list._root;
                for(int i = 0; i<list.Length; i++)
                {
                    Node tmp2 = currentThis.Next;
                    currentThis.Next = new Node(currentList.Value);
                    currentThis.Next.Next = tmp2;
                    currentList = currentList.Next;
                    currentThis = currentThis.Next;
                }
                currentThis.Next = tmp1;
                Length += list.Length;

            }
            else
            {
                for(int i = list.Length-1; i >=0; i--)
                {
                    AddFirst(list[i]);
                }
            }

        }
        public void AddLinkedListFromBiginning(LinkedList list)
        {
            AddLinkedListByIndex(list, 0);
        }
        public void AddLinkedListFromEnd(LinkedList list)
        {
            for(int i = 0; i<list.Length; i++)
            {
                Add(list[i]);
            }
        }

        public void SortAscending()
        {
            int[] firstElement = new int[2];
            firstElement = SearchIndexAndValueMinimumElement();
            RemoveByIndex(firstElement[0]);
            LinkedList tmpList = new LinkedList(firstElement[1]);

            while(Length!=0)
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
            LinkedList tmpList = new LinkedList(firstElement[1]);

            while(Length!=0)
            {
                int[] maximum = SearchIndexAndValueMaximumElement();
                RemoveByIndex(maximum[0]);
                tmpList.Add(maximum[1]);
            }
            this._root = tmpList._root;
            Length = tmpList.Length;
        }

        public override bool Equals(object obj)
        {
            LinkedList list = (LinkedList)obj;
            if (this.Length != list.Length)
            {
                return false;
            }

            Node currentThis = this._root;
            Node currentList = list._root;
            if (currentList is null && currentThis is null)
            {
                return true;
            }

            while (!(currentThis.Next is null))
            {
                if(currentThis.Value != currentList.Value)
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
                Node current = _root;
                string s = current.Value + " ";

                while(!(current.Next is null))
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
            Node current = _root;
            for(int i =0; i<Length; i++)
            {
                if (current.Value > maxElement)
                {
                    maxElement = current.Value;
                    indexMaxElement = i;
                }
                current = current.Next;
            }
            return  new int[] { indexMaxElement, maxElement };

        }
        private int[] SearchIndexAndValueMinimumElement()
        {
            int indexMinElement = 0;
            int minElement = _root.Value;
            Node current = _root;
            for(int i =0; i<Length; i++)
            {
                if (current.Value < minElement)
                {
                    minElement = current.Value;
                    indexMinElement = i;
                }
                current = current.Next;
            }
            return  new int[] { indexMinElement, minElement };

        }

        private void Empty()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }
    }
}
