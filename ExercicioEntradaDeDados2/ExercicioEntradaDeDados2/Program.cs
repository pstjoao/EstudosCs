﻿using System;
using System.Globalization;

namespace ExercicioEntradaDeDados2 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?:");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string ultnome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seus dados são:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Preço do produto: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Último nome: " + ultnome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
