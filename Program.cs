using BenchmarkDotNet.Running;
using System;

namespace BenchmarkApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkHarness>();
            Console.ReadKey();
        }
    }
}
