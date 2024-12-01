using System;

namespace ConversaoCasting {
    internal class Program {
        static void Main(string[] args) {

            double x;
            float y;

            x = 5.1;
            y = (float)x;
            Console.WriteLine(y);

            double m;
            int n;

            m = 5.1;
            n = (int)m;
            Console.WriteLine(n);

            int a = 5;
            int b = 2;

            double resultado = (double) a / b;
            Console.WriteLine(resultado);  
        }
    }
}
