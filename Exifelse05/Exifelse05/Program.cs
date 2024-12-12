using System;
using System.Globalization;

namespace Exifelse05 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o código do item e a quantidade desejada:");
            string[] valores = Console.ReadLine().Split(' ');
            int cod = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);

            double total;
            if (cod == 1) {
                total = quant * 4.00;
            }
            else if (cod == 2) {
                total = quant * 4.50;
            }
            else if (cod == 3) {
                total = quant * 5.00;
            }
            else if (cod == 4) {
                total = quant * 2.00;
            }
            else {
                total = quant * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
