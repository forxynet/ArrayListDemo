using System;
using System.Collections;

namespace ArrayListDemo {
    class Program {
        static void Main(string[] args) {
            ArrayList Numbers = new ArrayList(1);
            Numbers.Add(100);
            Numbers.Add(200);
            Numbers.Add(300);
            Numbers.Add(400);
            foreach (int Number in Numbers) {
                Console.WriteLine(Number + "  ");
            }
            Console.ReadKey();
        }
    }
}
