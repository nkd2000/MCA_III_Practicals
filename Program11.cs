using System;

namespace MCA_III_Practicals {
    internal class Program11 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            for (int i = 1; i <7; i++) {
                int n = 1;
                int n1 = 1;
                int temp = 1;
                for (int j = 1; j <= i; j++) {
                    Console.Write($" {n1}");
                    n = n1;
                    n1 = temp;
                    temp = n+n1;
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
