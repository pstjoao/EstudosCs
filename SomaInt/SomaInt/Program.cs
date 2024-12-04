using System;

namespace SomaInt {
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Insira o valor 1:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor 2:");
            int y = int.Parse(Console.ReadLine());

            int result = x + y;

            Console.WriteLine("SOMA = " + result);
        }
    }
}
