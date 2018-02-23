using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Recursion
{
    public static class Recursions
    {
        public static int TriangularNumbers(int num)
        {
            if (num == 1) return 1;
            return TriangularNumbers(num - 1) + num;
        }

        public static int Factorial(int num)
        {
            if (num == 1) return 1;
            return Factorial(num - 1) * num;
        }
    }
}
