using System;

namespace Baekjoon {
    class Program {
        static void Main() {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i < count+1; i++) {
                for(int j=1; j < i+1; j++) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }          
        }           
    }
}