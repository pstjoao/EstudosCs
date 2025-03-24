using System;
using GetHashCodeAndEquals.Entities;

namespace GetHashCodeAndEquals {
    internal class Program {
        static void Main(string[] args) {

            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b)); // Retorna "False"

            string c = "Joao";
            string d = "Joao";
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode()); // Gera o mesmo código
            Console.WriteLine("------------------");

            Client x = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client y = new Client { Name = "Alex", Email = "maria@gmail.com" }; // Os emails são iguais, retorna true

            Console.WriteLine(x.Equals(y));
            Console.WriteLine(x == y);
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());
        }
    }
}
