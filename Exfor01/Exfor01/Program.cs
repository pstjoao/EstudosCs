using System;

namespace Exfor01 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um valor de 1 a 1000: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i += 2) {
                    Console.WriteLine(i);
            }
        }
    }
}
