using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.API;

namespace FizzBuzz.App
{
    class Program
    {
        /// <summary>
        /// NOTE: I do NOT make all methods static in a normal application.
        /// However, this example has no state and is perfectly appropriate
        /// to use static methods basically everywhere.
        /// -Mark Johnston
        /// </summary>
        static void Main(string[] args)
        {
            ShowInstructions();
            ProcessInput();
        }

        private static void ShowInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("Enter an option to continue:");
            Console.WriteLine("1) Run Original Fizz Buzzer");
            Console.WriteLine("2) Run Better Fizz Buzzer");
            Console.WriteLine("3) Run SUPER Fizz Buzzer");
            Console.WriteLine("Press ESCAPE to exit");
            Console.WriteLine();
        }

        private static void ProcessInput()
        {
            var input = Console.ReadKey(true).Key;
            Console.Clear();

            while (true)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        RunOriginalFizzBuzzer();
                        break;

                    case ConsoleKey.D2:
                        RunBetterFizzBuzzer();
                        break;

                    case ConsoleKey.D3:
                        RunSuperFizzBuzzer();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Goodbye...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Unknown input - try again.");
                        break;
                }

                ShowInstructions();
                input = Console.ReadKey(true).Key;
                Console.Clear();
            }
        }

        private static void RunOriginalFizzBuzzer()
        {
            const int UpperBound = 100;
            foreach (var item in OriginalFizzBuzzer.FizzBuzz(UpperBound))
            {
                Console.WriteLine(item);
            }
        }

        private static void RunBetterFizzBuzzer()
        {
            const int UpperBound = 100;
            foreach (var item in OriginalFizzBuzzer.FizzBuzz(UpperBound))
            {
                Console.WriteLine(item);
            }
        }

        private static void RunSuperFizzBuzzer()
        {
            const int UpperBound = 100;
            var actionValues = new Dictionary<int, string>
            {
                { 3, "Clear" },
                { 9, "Measure" },
                { 11, "Rocks" }
            };
            foreach (var item in SuperFizzBuzzer.FizzBuzz(UpperBound, actionValues))
            {
                Console.WriteLine(item);
            }
        }

    }
}

