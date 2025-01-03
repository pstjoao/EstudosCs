using System;

namespace Exvetores {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Estudante[] vect = new Estudante[10];

            for (int i = 0; i < quartos; i++) {
                Console.WriteLine("Aluguel #" + (i+1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[num] = new Estudante(nome, email, num);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
