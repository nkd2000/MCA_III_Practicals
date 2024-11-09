using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals {
    internal class Program07 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write(" Enter a number to print factorial : ");
            string num = Console.ReadLine();
            if(!int.TryParse(num,out int n)) {
                Console.WriteLine(" Enter only numbers.");
                Console.ReadKey();
                return;
            }
            for(int i = 1; i<=n; i++) {
                Console.WriteLine($" = {PrintFact(i)}");
            }
            Console.ReadKey();
        }
        public static long PrintFact(int num) {
            long fact = 1;
            Console.WriteLine("");
            Console.Write($" {num}! = ");
            for (int i = 1; i <= num; i++) {
                if (i == num)
                    Console.Write($"{i}");
                else
                    Console.Write($"{i} x ");
                
                fact *= i;
            }
            return fact;
            
        }
    }
}
