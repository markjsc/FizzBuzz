using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.API
{
	/// <summary>
	/// NOTE: I do NOT make all methods static in a normal application.
	/// However, this example has no state and is perfectly appropriate
	/// to use static methods basically everywhere.
	/// -Mark Johnston
	/// </summary>
	public static class OriginalFizzBuzzer
    {
        public static IEnumerable<string> FizzBuzz(int upperBound)
        {
            return Enumerable.Range(1, upperBound)
                             .Select(GetDisplayValue);
        }

        private static string GetDisplayValue(int counter)
        {
            string itemToAdd = string.Empty;
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
