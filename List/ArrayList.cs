using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;

        public ArrayList()
        {
            _array = new int[5];

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
            if (Length == _array.Length)
            {
                UpSize();
            }
            int[] tmpArray = new int[_array.Length];
            for (int i = 0; i <= Length; i++)
            {
                tmpArray[i + 1] = _array[i];
            }
            tmpArray[0] = value;
            _array = tmpArray;
            Length++;


        }


        public void ListOutputToTheConsole()
        {
            for(int i =0; i< Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
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
