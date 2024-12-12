using System;

namespace Exifelse01 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um número inteiro:");
            int num = int.Parse(Console.ReadLine());

            if (num < 0 ) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
