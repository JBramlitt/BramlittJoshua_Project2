using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_Project1
{
    class Menu
    {
        public string Title { get; set; }
        private List<string> _items;

        public Menu()
        {
            Title = "Main Menu";
            _items = new List<string>();
        }

        public Menu(params string[] items)
        {
            Title = "Main Menu";
            _items = items.ToList();
        }

        public void AddMenuItem(string item)
        {
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
