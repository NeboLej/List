using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 9, 10};

            ArrayList Oleg = new ArrayList(array);
            Console.WriteLine(Oleg);

            Oleg.FillWithRandom(10);
            Console.WriteLine(Oleg);

            //Oleg.ListOutputToTheConsole();
            //Console.WriteLine();

            Oleg.Add(15);
            //Oleg.ListOutputToTheConsole();
            Console.WriteLine(Oleg);

            Oleg.AddToTheBeginning(70);
            //Oleg.ListOutputToTheConsole();

            Console.WriteLine(Oleg);
        }
    }
}
