using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_11_1
{
    internal class Algebra
    {
        public static int Cube(int number)
        {
            return number * number * number;
        }
        
        public static double Cube(double number)
        {
            return number * number * number;
        }

        public static int MinElement(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        public static int MinElement(int a, int b, int c, int d)
        {
            return Math.Min(Math.Min(Math.Min(a, b), c), d);
        }
    }
}
