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



        public void Add(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
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
    }
}
