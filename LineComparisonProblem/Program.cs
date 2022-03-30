using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program.");
            //UC-2
            double x1 = 2, x2 = 3;
            double y1 = 4, y2 = 5;

            double p1 = 5, p2 = 6;
            double q1 = 8, q2 = 9;

            CheckEqualityAndCompare(x1, x2, y1, y2, p1, p2, q1, q2);
            Console.ReadLine();
        }
        public static void CheckEqualityAndCompare(double x1, double x2, double y1, double y2, double p1, double p2, double q1, double q2)
        {
            //UC-2
            double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double line2 = Math.Sqrt((Math.Pow(p2 - p1, 2) + Math.Pow(q2 - q1, 2)));
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.ReadLine();
        }
    }
}
