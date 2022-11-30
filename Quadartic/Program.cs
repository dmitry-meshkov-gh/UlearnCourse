using EquationSolver;

var a = double.Parse(Console.ReadLine());
var b = double.Parse(Console.ReadLine());
var c = double.Parse(Console.ReadLine());

var result = QuadraticEquationSolver.Solve(a, b, c);

Console.WriteLine(result[0]);
Console.WriteLine(result[1]);