using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYLENE_CARUANA
{
    public delegate int GetAction(int x, int y);
    class Process
    {
        public static int getSum(int a, int b)
        {
            return a + b;
        }
        public static int getDifference(int a, int b)
        {
            return a - b;
        }
        public static int getProduct(int a, int b)
        {
            return a * b;
        }
        public static int getQuotient(int a, int b)
        {
            return a / b;
        }
    }
}
