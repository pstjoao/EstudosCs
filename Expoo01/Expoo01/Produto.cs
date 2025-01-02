using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Expoo01 {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarEstoque(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverEstoque(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome 
                + ", " 
                + Preco 
                + ", " 
                + Quantidade;
        }
    }
}
