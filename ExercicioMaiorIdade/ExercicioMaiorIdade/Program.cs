using System;

namespace ExercicioMaiorIdade {
    internal class Program {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Console.Write("Nome da 1 pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade da 1 pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Nome da 2 pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade da 2 pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.Write("Nome da 3 pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Idade da 3 pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            if (p1.Idade > p2.Idade && p1.Idade > p3.Idade) {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else if (p2.Idade > p1.Idade && p2.Idade > p3.Idade) {
                Console.WriteLine("A pessoa mais velha é: ");
                p2.ExibirDados();
            }
            else if (p3.Idade > p1.Idade && p3.Idade > p2.Idade) {
                Console.WriteLine("A pessoa mais velha é: ");
                p3.ExibirDados();
            }
            else {
                Console.WriteLine("Todas as pessoas possuem a mesma idade");
            }
        }
    }
}
