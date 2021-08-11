using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int pos = 0;

        public DinerMenuIterator(MenuItem[] menuItem)
        {
            items = menuItem;
        }

        public bool HasNext()
        {
            if (pos >= items.Length || items[pos] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            MenuItem menuItem = items[pos++];
            return menuItem;
        }
    }
}
