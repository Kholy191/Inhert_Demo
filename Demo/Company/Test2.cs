using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Company
{
    internal class Test2
    {
        private int x;
        static string Name = "Ahmed";

        public ref int Method()
        {
            return ref x;
        }

        public int getMethod()
        {
            return x;
        }

        public static string RetString1()
        {
            return "Ahmed";
        }

        public static string RetString2()
        {
            return Name;
        }

        public static ref string RetString3()
        {
            return ref Name;
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

    }
}
