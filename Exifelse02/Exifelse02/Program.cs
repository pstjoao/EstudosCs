using System;

namespace Exifelse02 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("O número é PAR");
            }
            else {
                Console.WriteLine("O número é ÍMPAR");
            }
        }
    }
}
