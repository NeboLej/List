using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList oleg = new DoubleLinkedList(new int[] { 0, 1, 2, 3, 4, 5 ,6 ,7 ,8, 9, 10,11, 12});
            Console.WriteLine(oleg);
            oleg.Revers();
            Console.WriteLine(oleg);
            //oleg.RemuveValuesByIndex(0, 3);
            //Console.WriteLine(oleg);


        }
    }
}
