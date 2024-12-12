using System;

namespace Exifelse03 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um valor inteiro A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor inteiro B:");
            int b = int.Parse(Console.ReadLine());

            if (a == 1 && b != 1) {
                Console.WriteLine("B é múltiplo de A");
            }
            else if (b == 1 && a != 1) {
                Console.WriteLine("A é múltiplo de B");
            }
            else if  (a % b == 0 || b % a == 0) {
                Console.WriteLine("São múltiplos");
            }
            else {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}
