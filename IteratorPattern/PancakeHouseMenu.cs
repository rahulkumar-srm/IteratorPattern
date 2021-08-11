using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem("K&B Pancake Breakfast", "Pancake with scrambled eggs and toast", false, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancake with fried eggs and sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "With your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            menuItems.Add(new MenuItem(name, description, vegetarian, price));
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }
    }
}
