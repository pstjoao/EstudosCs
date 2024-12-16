using System;

namespace Exfor06 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Os divisores são: ");
            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
