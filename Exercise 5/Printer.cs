using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Printer
    {
        public virtual void Print (string value) 
        {
            Console.ForegroundColor = (ConsoleColor)(new Random()).Next(0, 15);
            Console.WriteLine(value);
        }
    }
}
