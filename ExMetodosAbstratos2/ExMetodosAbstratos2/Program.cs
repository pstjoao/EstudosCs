using System;
using System.Globalization;
using ExMetodosAbstratos2.Entities;

namespace ExMetodosAbstratos2 {
    internal class Program {
        static void Main(string[] args) {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpend));
                }
                else {
                    Console.Write("Number of employees: ");
                    int numberOfEmp = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmp));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach (TaxPayer payer in list) {
                Console.WriteLine(payer);
                sum += payer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
