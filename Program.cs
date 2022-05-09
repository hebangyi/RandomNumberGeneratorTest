using System;
using System.Security.Cryptography;

namespace RandomNumberGeneratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(RandomGenerator.RandomStr(10));
            }*/

            // RandomTestCollector.RandCharTest();
            RandomTestCollector.RandStrGenTimeTest();
        }
    }
}