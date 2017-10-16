using System;

namespace ScriptTest
{
    class Program
    {
        static void Go(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            ThreadExample2.Go();
            Console.ReadKey();

            CQ_EnqueueDequeuePeek a = new CQ_EnqueueDequeuePeek();

        }
    }
}
