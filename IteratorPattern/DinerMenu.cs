using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class DinerMenu : IMenu
{
        const int max_items = 6;
        int numberOfItems = 0;

        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[max_items];

            AddItem("Vegeterian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hotdog with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            if (numberOfItems >= max_items)
                Console.WriteLine("Sorry, menu is full! can't add item to menu");
            else
                menuItems[numberOfItems++] = new MenuItem(name, description, vegetarian, price);
        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
