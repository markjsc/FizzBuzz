using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.API;

namespace FizzBuzz.App
{
    class Program
    {
        private static MenuItemList _menuItemList = new MenuItemList()
            .Register(ConsoleKey.D1, "1", "Run Original Fizz Buzzer", () => RunOriginalFizzBuzzer())
            .Register(ConsoleKey.D2, "2", "Run Better Fizz Buzzer", () => RunBetterFizzBuzzer())
            .Register(ConsoleKey.D3, "3", "Run SUPER Fizz Buzzer", () => RunSuperFizzBuzzer());

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
            Program._menuItemList.ShowInstructions();
        }

        private static void ProcessInput()
        {
            var input = Console.ReadKey(true).Key;
            Program._menuItemList.PerformOperation(input);
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

