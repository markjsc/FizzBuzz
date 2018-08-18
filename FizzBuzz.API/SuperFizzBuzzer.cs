using System.Collections.Generic;

namespace FizzBuzz.API
{
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
            for (var counter = 1; counter <= upperBound; counter++)
            {
                string itemToAdd = string.Empty;

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
                
                yield return itemToAdd;
            }
        }
    }
}
