using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList oleg = new DoubleLinkedList(new int[] { 4, 8, 15 , 16, 23, 42, 70, 100});
            Console.WriteLine(oleg);
            oleg.RemoveValuesByIndex(3, 0);
            Console.WriteLine(oleg);
            //oleg.RemuveValuesByIndex(0, 3);
            //Console.WriteLine(oleg);


        }
    }
}
