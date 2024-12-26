namespace ExercicioAreaRetangulo {
    internal class Retangulo {

        public double Altura;
        public double Largura;

        public double Area() {
            return Altura * Largura;
        }

        public void ExibirDados() {
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Largura: " + Largura);
            Console.WriteLine("Área: " + Area());
        }
    }
}
