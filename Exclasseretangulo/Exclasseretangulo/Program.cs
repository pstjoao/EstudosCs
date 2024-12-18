using System;

namespace Exclasseretangulo {
    internal class Program {
        static void Main(string[] args) {

            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("ÁREA = " + ret.Area());
            Console.WriteLine("PERÍMETRO = " + ret.Perimetro());
            Console.WriteLine("DIAGONAL = " + ret.Diagonal());
        }
    }
}
