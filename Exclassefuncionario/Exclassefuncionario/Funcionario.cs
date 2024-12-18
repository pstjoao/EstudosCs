using System.Globalization;

namespace Exclassefuncionario {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcent) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcent / 100.0);
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
