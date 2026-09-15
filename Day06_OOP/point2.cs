using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daye06_OOP01
{
    public struct point2
    {
        public int X;
        public int Y;

        public point2(int x)
        {
            X = x;
            Y = 5;
        }

        public point2(int x , int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
