using System;
using System.Globalization;

namespace Exfor04 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Insira o número de pares de números que serão lidos: ");
            int pares = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pares; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (n2 != 0) { 
                double divisao = n1 / n2;
                Console.WriteLine(divisao.ToString("F3", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("Divisão impossível");
                }
            }
        }
    }
}
