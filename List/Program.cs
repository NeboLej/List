using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList Oleg = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5});
            Console.WriteLine(Oleg.Length);
            Oleg.RemoveByEnd();
        }
    }
}
