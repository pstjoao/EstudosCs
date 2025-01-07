using System;
using System.Collections.Generic;

namespace Listas {
    internal class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Edward");
            list.Add("John");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); // Expressão lambda
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int position1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("First position 'M': " + position1);

            int position2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Last position 'M': " + position2);

            Console.WriteLine("--------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("--------------------");
            Console.WriteLine("Sem Alex:");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3);
            Console.WriteLine("--------------------");
            Console.WriteLine("Sem Anna:");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------");
            Console.WriteLine("Sem Maria, Marco:");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(1, 2);
            Console.WriteLine("--------------------");
            Console.WriteLine("Sem Edward, John:");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
