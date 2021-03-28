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
            { //отбить тут indexOutOfRangeException
                if (index > Length || index < 0)
                {
                    throw new IndexOutOfRangeException("Неверный индекс элемента");
                }
                return _array[index];
            }
            set
            {
                if (index > Length || index < 0)
                {
                    throw new IndexOutOfRangeException("Неверный индекс элемента");
                }
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


        public void RemoveValueByIndex(int index)
        {
            if (index > Length - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Неверный индекс элемента");
            }

            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            DownSize();
        }
        public void AddValueByIndex(int value, int index)
        {
            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException("Неверный индекс элемента");
            }

            if (Length == _array.Length)
            {
                UpSize();
            }
            for (int i = Length - 1; i >= index; i--)
            {
                _array[i + 1] = _array[i];

            }
            _array[index] = value;
            Length++;
        }
        public void RemoveValuesByIndex(int index, int number)
        {
            if (index > Length - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Неверный индекс элемента");
            }

            if (index + number > Length)
            {
                throw new ArgumentOutOfRangeException("Ваш список меньше количества удаляемых элементов");
            }

            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("колличество удаляемых элементов должно быть больше 0");
            }

            for (int i = index; i < Length - number; i++)
            {
                _array[i] = _array[i + number];
            }
            Length -= number;
            DownSize();
        }


        public void Add(int value)
        {
            AddValueByIndex(value, Length);
        }
        public void AddToTheBeginning(int value)
        {
            AddValueByIndex(value, 0);
        }


        public void RemoveValueFromEnd()
        {

            Length--;
            DownSize();
        }
        public void RemoveValueFromBeginning()
        {
            RemoveValueByIndex(0);
        }



        public void RemoveValuesFromBeginning(int number)
        {
            RemoveValuesByIndex(0, number);
        }
        public void RemovingValuesFromEnd(int number)
        {
            if (number > Length)
            {
                throw new ArgumentOutOfRangeException("Ваш список меньше количества удаляемых элементов");
            }
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("колличество удаляемых элементов должно быть больше 0");
            }

            Length -= number;
            DownSize();
        }


        public int SearchIndexValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    int index = i;
                    return index;
                }
            }
            return -1;
        }
        public int SearchMaximumValue()
        {
            int[] index = new int[2];
            index = SearchIndexAndValueMaximumElements();
            return index[0];
        }
        public int SearchMinimumValue()
        {
            int[] index = new int[2];
            index = SearchIndexAndValueMinimumElements();
            return index[0];
        }
        public int SearchIndexMinimumValue()
        {

            int[] index = new int[2];
            index = SearchIndexAndValueMinimumElements();
            return index[1];
        }
        public int SearchIndexMaximumValue()
        {
            int[] index = new int[2];
            index = SearchIndexAndValueMaximumElements();
            return index[1];
        }


        public void Revers()
        {
            for (int i = 0; i < Length / 2; i++)
            {
                int tmp = 0;
                tmp = _array[i];
                _array[i] = _array[Length - 1 - i];
                _array[Length - 1 - i] = tmp;
            }
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
            if (Length != arrayList.Length)
            {
                return false;
            }
            for (int i = 0; i < Length; i++)
            {
                if (this._array[i] != arrayList._array[i])
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


        public void SortAscending()
        {

            for (int i = 0; i < Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[j] < _array[min])
                    {
                        min = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[min];
                _array[min] = tmp;
            }
        }
        public void SortDescending()
        {

            for (int i = 0; i < Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[j] > _array[max])
                    {
                        max = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[max];
                _array[max] = tmp;
            }
        }

        public void AddArrayByIndex(ArrayList arrayList, int index)
        {
            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException("Неверный индекс элемента");
            }

            while (_array.Length <= Length + arrayList.Length)
            {
                UpSize();
            }

            for (int i = Length - 1; i >= index; i--)
            {
                _array[i + arrayList.Length] = _array[i];
            }
            int j = 0;
            for (int i = index; i < index + arrayList.Length; i++)
            {
                _array[i] = arrayList[j];
                j++;
            }
            Length += arrayList.Length;
        }
        public void AddArray(ArrayList arrayList)
        {
            AddArrayByIndex(arrayList, Length);
        }
        public void AddArrayFromBiginning(ArrayList arrayList)
        {
            AddArrayByIndex(arrayList, 0);
        }


        public void RemoveTheFirstByValue(int value)
        {
            int index = SearchIndexValue(value);
            if (index != -1)
            {
                RemoveValueByIndex(index);
            }
        }
        public void RemoveAllByValue(int value)
        {
            for (int i = 0; i < Length - 1; i++)
            {
                if (_array[i] == value)
                {
                    RemoveValueByIndex(i);
                    i--;
                }
            }
        }


        private void DownSize()
        {
            if (Length < (int)(_array.Length / 2) - 1)
            {
                int newLenght = (int)(_array.Length / 3);
                int[] tmpArray = new int[newLenght];
                for (int i = 0; i < newLenght; i++)
                {
                    tmpArray[i] = _array[i];
                }
                _array = tmpArray;
                DownSize();
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

        private int[] SearchIndexAndValueMaximumElements()
        {
            int[] maxElement = new int[] { _array[0], 0 };

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > maxElement[0])
                {
                    maxElement[0] = _array[i];
                    maxElement[1] = i;
                }
            }
            return maxElement;
        }
        private int[] SearchIndexAndValueMinimumElements()
        {
            int[] minElement = new int[] { _array[0], 0 };

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < minElement[0])
                {
                    minElement[0] = _array[i];
                    minElement[1] = i;
                }
            }
            return minElement;
        }


    }
}
