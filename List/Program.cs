using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList Oleg = new LinkedList(new int[] { 0, -1, 200, 3, 224, -5});
            Console.WriteLine(Oleg.SearchMinimumValue());
            Console.WriteLine(Oleg);
            Oleg.SortAscending();
            Console.WriteLine(Oleg);
            Oleg.SortDescending();
            Console.WriteLine(Oleg);

        }
    }
}
