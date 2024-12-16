using System;

namespace Exfor05 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Insira o valor: ");
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= n; i++) {
                int valor = i;
                fatorial *= valor;
            }
            Console.WriteLine(fatorial);
        }
    }
}
