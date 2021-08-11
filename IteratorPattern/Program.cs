﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress(new PancakeHouseMenu(), new DinerMenu());
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
