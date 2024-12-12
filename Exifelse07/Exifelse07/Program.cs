using System;
using System.Globalization;

namespace Exifelse07 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira duas coordenadas (x,y) com uma casa decimal");
            string[] coord = Console.ReadLine().Split(' ');
            double x = double.Parse(coord[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coord[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0 && y != 0) {
                Console.WriteLine("Eixo Y");
            }
            else if (x != 0 && y == 0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}
