using System.Globalization;

namespace Exclasseprodutos {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quant;

        public double ValorTotalEmEstoque() {
            return Preco * Quant;
        }

        public void AdicionarProdutos(int quantidade) {
            Quant += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quant -= quantidade;
        }

        public override string ToString() {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quant 
                + " unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
