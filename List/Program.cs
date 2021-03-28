using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList oleg = new DoubleLinkedList(new int[] { 0, 1, 2, 3, 4, 5 ,6 ,7 ,8, 9, 10,11, 12});
            DoubleLinkedList vitia = new DoubleLinkedList(new int[] { 10, 20, 30 });
            Console.WriteLine(oleg);
            oleg.SortAscending();
            //oleg.AddByIndex(8, 10);
            //Console.WriteLine(vitia);
            //oleg.AddListByEnd(vitia);
            //oleg.AddListByIndex(13, vitia);
            //vitia.Revers();
            Console.WriteLine(oleg);
            //oleg.RemuveValuesByIndex(0, 3);
            //Console.WriteLine(oleg);


        }
    }
}
