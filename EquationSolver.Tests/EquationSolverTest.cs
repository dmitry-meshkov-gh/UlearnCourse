using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EquationSolver.Tests
{
    [TestClass]
    public class EquationSolverTest
    {
        void TestEquiation(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }
        [TestMethod]
        public void OrdinaryEquation()
        {
            TestEquiation(1, -3, 2, 2, 1);
        }

        [TestMethod]
        public void NegativeDiscriminant()
        {
            TestEquiation(1, 1, 1);
        }

        [TestMethod]
        public void ZeroDiscriminant()
        {
            TestEquiation(1, 2, 1, -1);
        }

        [TestMethod]
        public void FunctionalTest()
        {
            Random rand = new Random(1);
            double a = rand.NextDouble() * 10;
            double b = rand.NextDouble() * 10;
            double c = rand.NextDouble() * 10;

            var result = QuadraticEquationSolver.Solve(a, b, c);
            foreach(var x in result)
            {
                Assert.AreEqual(0, a * x * x + b * x + c, 1e-10);
            }
        }
    }
}
