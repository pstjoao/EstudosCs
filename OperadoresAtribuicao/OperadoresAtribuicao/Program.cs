﻿using System;

namespace OperadoresAtribuicao {
    internal class OperadoresAtribuicao {
        static void Main(string[] args) {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            // O += também serve para a concatenação cumulativa de strings
            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            b++;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);

            int x = 10;
            int y = ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
