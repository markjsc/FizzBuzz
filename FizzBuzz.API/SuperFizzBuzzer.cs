using System.Collections.Generic;

namespace FizzBuzz.API
{
	using System.Linq;

	/// <summary>
	/// NOTE: I do NOT make all methods static in a normal application.
	/// However, this example has no state and is perfectly appropriate
	/// to use static methods basically everywhere.
	/// -Mark Johnston
	/// </summary>
	public static class SuperFizzBuzzer
    {
        public static IEnumerable<string> FizzBuzz(int upperBound, Dictionary<int, string> actionValues)
        {
            return Enumerable.Range(1, upperBound)
                             .Select(counter => GetDisplayValue(counter, actionValues));
        }

        private static string GetDisplayValue(int counter, Dictionary<int, string> actionValues)
        {
            var itemToAdd = string.Empty;

            foreach(var item in actionValues)
            {
                if(counter % item.Key == 0)
                {
                    itemToAdd = $"{itemToAdd}{item.Value}";
                }                    
            }

            if (string.IsNullOrEmpty(itemToAdd))
            {
                itemToAdd = $"{counter}";
            }

            return itemToAdd;
        }
    }
}
