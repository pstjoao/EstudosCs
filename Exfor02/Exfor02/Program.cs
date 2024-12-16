using System;

namespace Exfor02 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um valor inteiro N: ");
            int N = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= N; i++) {
               int n = int.Parse(Console.ReadLine());
               if (n >= 10 && n <= 20) {
                    dentro += 1;
               }
               else {
                    fora += 1;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
