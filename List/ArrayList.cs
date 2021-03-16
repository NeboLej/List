using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;

        public int this[int index]
        {
            get
            { //отбить тут out if range exception
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }


        public ArrayList()
        {
            Length = 0;
            _array = new int[10];

        }
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }
        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = value;
            UpSize();
        }


        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        public void AddToTheBeginning(int value)
        {
            if  (Length == _array.Length)
            {
                UpSize();
            }
            for (int i = Length; i >=0; i--)
            {
                _array[i + 1] = _array[i];

            }
            _array[0] = value;
            Length++;


        }

        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < Length; i++)
            {
                tmp += _array[i] + " ";
            }
            return tmp;
        }
        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            if(Length != arrayList.Length)
            {
                return false;
            }
            for(int i = 0; i < Length; i++)
            {
                if(this._array[i] != arrayList._array[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void FillWithRandom(int numberOfElements)
        {

            Random random = new Random();
            for (int i = 0; i < numberOfElements; i++)
            {
                Add(random.Next(0, 101));
            }
        }

        private void UpSize()
        {
            int newLenght = (int)(_array.Length * 1.33d + 1);

            int[] tmpArray = new int[newLenght];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }
    }
}
