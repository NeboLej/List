using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList oleg = new DoubleLinkedList(new int[] { 4, 8, 15 , 16, 23, 42, 70, 100});
            Console.WriteLine(oleg);
            oleg.RemoveFirst();
            Console.WriteLine(oleg);
            oleg.RemoveEnd();
            Console.WriteLine(oleg);
            oleg.RemooveByIndex(0);
            Console.WriteLine(oleg);
            oleg.RemooveByIndex(4);
            Console.WriteLine(oleg);
            oleg.RemooveByIndex(4);
            Console.WriteLine(oleg);



        }
    }
}
