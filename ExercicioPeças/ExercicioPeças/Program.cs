using System;
using System.Globalization;

namespace ExercicioPeças {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o código da peça 1, o número de peças 1 e o valor unitário de cada peça 1");
            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int num1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o código da peça 2, o número de peças 2 e o valor unitário de cada peça 2");
            string[] v = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(v[0]);
            int num2 = int.Parse(v[1]);
            double valor2 = double.Parse(v[2], CultureInfo.InvariantCulture);

            double result = num1 * valor1 + num2 * valor2;
            Console.WriteLine("Valor a pagar: R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
