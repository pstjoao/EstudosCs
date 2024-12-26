namespace ExercicioMaiorIdade {
    internal class Pessoa {

        public Pessoa() {
            Nome = "";
            Idade = 0;
        }

        public Pessoa(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        public string Nome;
        public int Idade;

        public void ExibirDados() {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }
}
