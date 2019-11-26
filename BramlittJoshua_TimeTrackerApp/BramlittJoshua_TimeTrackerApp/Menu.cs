using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_TimeTrackerApp
{
    class Menu
    {
        // Set the title variable so you can change it
        public string Title { get; set; }
        private List<string> _items;

        public Menu()
        {
            Title = "Main Menu";

            // Create a new list of strings
            _items = new List<string>();
        }

        public Menu(params string[] items)
        {
            Title = "Main Menu";
            _items = items.ToList();
        }

        public void AddMenuItem(string item)
        {
            // Add the items to the list
            _items.Add(item);
        }

        public void Display()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================");
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {_items[i]}");
            }
        }
    }
}
