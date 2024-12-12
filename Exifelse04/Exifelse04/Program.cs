using System;

namespace Exifelse04 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira a hora inicial do jogo:");
            int h1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora final do jogo:");
            int h2 = int.Parse(Console.ReadLine());

            int dif = h2 - h1;

            if (dif > 0) {
                int tempo1 = dif;
                Console.WriteLine("O jogo durou " + tempo1 + " hora(s)");
            }
            else if (dif == -12) {
                int tempo2 = -dif;
                Console.WriteLine("O jogo durou " + tempo2 + " hora(s)");
            }
            else if (dif < -12 || dif > -12) {
                h2 = 24 + h2;
                int tempo3 = h2 - h1;
                Console.WriteLine("O jogo durou " + tempo3 + " hora(s)");
            }
            else {
                Console.WriteLine("O jogo durou 24 hora(s)");
            }
        }
    }
}
