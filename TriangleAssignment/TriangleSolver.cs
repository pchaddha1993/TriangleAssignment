
using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleAssignment
{
    public static class TriangleSolver
    {
        static string result;
        public static string Analyze(int Side_1, int Side_2, int Side_3)
        {
                if ((Side_1 + Side_2 > Side_3) && (Side_2 + Side_3 > Side_1) && (Side_1 + Side_3 > Side_2))
                {
                    if (Side_1 == Side_2 && Side_2 == Side_3)
                    {
                        result = "Equilateral";
                    }
                    else if (Side_1 == Side_2 || Side_1 == Side_3 || Side_2 == Side_3)
                    {
                    result = "Isosceles";
                    }
                    else
                    {
                    result = "Scalene";
                    }
                }
                return result;
        }
    }
}
