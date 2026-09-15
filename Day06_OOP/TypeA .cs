using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daye06_OOP01
{
    internal class TypeA
    {
        private int F = 10;
        internal int G = 20;
        public int H = 30;

        public void accessModifiers()
        {
            Console.WriteLine($"F = {F}");
            Console.WriteLine($"G = {G}");
            Console.WriteLine($"H = {H}");
        }
    }
}
