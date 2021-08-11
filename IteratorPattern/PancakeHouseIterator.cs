using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class PancakeHouseIterator : Iterator
    {
        int pos = 0;
        List<MenuItem> items;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (pos < items.Count)
                return true;
            else
                return false;
        }

        public object Next()
        {
            MenuItem menuItem = items[pos++];
            return menuItem;
        }
    }
}
