using System;
using System.Globalization;

namespace Exfor03 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Insira o número de casos que serão analisados: ");
            int casos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= casos; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (2*v1 + 3*v2 + 5*v3) / (2 + 3 + 5);
                Console.WriteLine("Média ponderada: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
