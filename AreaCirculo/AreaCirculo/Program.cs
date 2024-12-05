using System;
using System.Globalization;

namespace AreaCirculo {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o valor do raio:");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.Pow(r, 2) * 3.14159;

            Console.WriteLine("A área é: ");
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
