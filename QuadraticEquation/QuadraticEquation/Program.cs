using System;

namespace QuadraticEquation {
    internal class Program {
        static void Main(string[] args) {

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double resultado1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double resultado2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
        }
    }
}
