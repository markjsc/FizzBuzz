using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.API
{
	public static class BetterFizzBuzzer
    {
        public static IEnumerable<string> FizzBuzz(int upperBound)
        {
            return Enumerable.Range(1, upperBound)
                             .Select(GetDisplayValue);
        }

        private static string GetDisplayValue(int counter)
        {
            var itemToAdd = string.Empty;
            if (counter % 3 == 0)
            {
                itemToAdd = "Fizz";
            }
            if (counter % 5 == 0)
            {
                itemToAdd = $"{itemToAdd}Buzz";
            }

            if (string.IsNullOrEmpty(itemToAdd))
            {
                itemToAdd = $"{counter}";
            }

            return itemToAdd;
        }
    }
}
