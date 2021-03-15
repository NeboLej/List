using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList Oleg = new ArrayList();
            Oleg.FillWithRandom(10);
            Oleg.ListOutputToTheConsole();
            Console.WriteLine();

            Oleg.Add(15);
            Oleg.ListOutputToTheConsole();
            Console.WriteLine();

            Oleg.AddToTheBeginning(70);
            Oleg.ListOutputToTheConsole();

            Console.WriteLine();
        }
    }
}
