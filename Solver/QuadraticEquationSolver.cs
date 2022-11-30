using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class QuadraticEquationSolver
    {
        public static double[] Solve(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            return new double[] { x1, x2 };
        }
    }
}
