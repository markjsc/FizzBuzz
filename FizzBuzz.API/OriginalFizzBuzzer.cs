using System.Collections.Generic;

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
            for (var counter = 1; counter <= upperBound; counter++)
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

                yield return itemToAdd;
            }
        }

        
    }
}
