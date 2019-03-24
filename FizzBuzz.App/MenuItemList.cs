using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.App
{
    public class MenuItemList
    {
        private MenuItem _exitMenuItem = new MenuItem
        {
            KeyToActivate = ConsoleKey.Escape,
            KeyDescription = "ESCAPE",
            Description = "Exit",
            Operation = () =>
            {
                Console.WriteLine("Goodbye...");
                Environment.Exit(0);
            }
        };

        private readonly Dictionary<ConsoleKey, MenuItem> _menuItems = new Dictionary<ConsoleKey, MenuItem>();

        public MenuItemList()
        {
            this._menuItems.Add(this._exitMenuItem.KeyToActivate, this._exitMenuItem);
        }

        public MenuItemList Register(MenuItem menuItem)
        {
            if(this._menuItems.ContainsKey(menuItem.KeyToActivate))
            {
                throw new ArgumentException($"A Menu Item with the specified Key To Activate ({menuItem.KeyToActivate}) has already been registered.");
            }

            this._menuItems.Add(menuItem.KeyToActivate, menuItem);
            return this;
        }

        public MenuItemList Register(ConsoleKey keyToActivate, string keyDescription, string description, Action operation)
        {
            return this.Register(new MenuItem()
            {
                KeyToActivate = keyToActivate,
                KeyDescription = keyDescription,
                Description = description,
                Operation = operation
            });
        }

        public void ShowInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("Enter an option to continue:");
            this._menuItems.Where(mi => mi.Key != this._exitMenuItem.KeyToActivate).ToList().ForEach(mi =>
            {
                Console.WriteLine($"{mi.Value.KeyDescription}) {mi.Value.Description}");
            });
            Console.WriteLine($"Press {this._exitMenuItem.KeyDescription} to exit");
            Console.WriteLine();
        }

        public void PerformOperation(ConsoleKey input)
        {
            Console.Clear();

            while (true)
            {
                if(this._menuItems.ContainsKey(input) != true)
                {
                    Console.WriteLine("Unknown input - try again.");
                }
                else
                {
                    var foundMenuItem = this._menuItems[input];
                    try
                    {
                        foundMenuItem.Operation();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Unable to execute the operation specified with the registered menu item ({foundMenuItem.KeyToActivate}: {foundMenuItem.Description})", ex);
                    }
                }
                

                ShowInstructions();
                input = Console.ReadKey(true).Key;
                Console.Clear();
            }
        }
    }
}
