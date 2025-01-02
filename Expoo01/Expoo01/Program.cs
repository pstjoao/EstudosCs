using System;

namespace Expoo01 {
    internal class Program {
        static void Main(string[] args) {

            Produto p;

            Console.Write("Informe o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade do produto: ");
            int quant = int.Parse(Console.ReadLine());

            p = new Produto(nome, preco, quant);

            Console.Write("Informe a quantidade de itens a serem adicionados: ");
            int quantadd = int.Parse(Console.ReadLine());
            p.AdicionarEstoque(quantadd);
            Console.Write("Informe a quantidade de itens a serem removidos: ");
            int quantrem = int.Parse(Console.ReadLine());
            p.RemoverEstoque(quantrem);

            Console.WriteLine(p);
        }
    }
}
