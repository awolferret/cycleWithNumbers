using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int amplifyNumber = 7;

            for (number = 5; number < 100; number += amplifyNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
