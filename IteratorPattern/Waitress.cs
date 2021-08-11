using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Waitress
    {
        IMenu pancakeHouse, dinerMenu;

        public Waitress(IMenu pancakeHouse, IMenu dinerMenu)
        {
            this.dinerMenu = dinerMenu;
            this.pancakeHouse = pancakeHouse;
        }

        public void PrintMenu()
        {
            Iterator pancakeIterator = pancakeHouse.CreateIterator();
            Iterator dinerIterator = dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);

            }
        }
    }
}
