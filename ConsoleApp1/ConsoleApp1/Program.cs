using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int startNumber = 5;
            int amplifyNumber = 7;
            int maxNumber = 100;

            for (number = startNumber; number < maxNumber; number += amplifyNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
