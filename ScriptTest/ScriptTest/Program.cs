using System;

namespace ScriptTest
{
    class Program
    {
        static void Go(string[] args)
        {
            Console.WriteLine("abc" ?? "abc");
            Console.WriteLine("abc" ?? "abC");
            Console.WriteLine("abC" ?? "abc");
            Console.WriteLine("abC" ?? "abC");

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            ThreadExample2.Go();
            Console.ReadKey();

            CQ_EnqueueDequeuePeek a = new CQ_EnqueueDequeuePeek();

        }
    }
}
