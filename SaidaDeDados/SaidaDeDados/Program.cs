using System;

namespace SaidaDeDados {
    class Program {
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "José";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("-------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
        }
    }
}
