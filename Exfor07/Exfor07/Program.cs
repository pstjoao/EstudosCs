﻿using System;

namespace Exfor07 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Insira um valor positivo: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2) + " ");
                Console.WriteLine(Math.Pow(i, 3) + " ");
            }
        }
    }
}
