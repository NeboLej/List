using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList oleg = new DoubleLinkedList(new int[] { 4, 8, 15 , 16, 23, 42});
            Console.WriteLine(oleg);
            oleg.AddByIndex(0, 100);
            Console.WriteLine(oleg);


        }
    }
}
