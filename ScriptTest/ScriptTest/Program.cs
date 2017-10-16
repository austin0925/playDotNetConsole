using System;

namespace ScriptTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            ThreadExample2.Go();
            Console.ReadKey();


        }
    }
}
