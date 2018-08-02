using System;
using System.Threading;

namespace L3_P1
{
class Program
{
    static void Main(string[] args)
    {
            var thread = new Thread(() =>
            {
                Console.WriteLine("Hello World!");
                Console.ReadKey();
            });
            thread.IsBackground = true;
            thread.Start();


    }
}
}
