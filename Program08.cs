using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals {
    internal class Program08 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write(" Enter number to print fabonacci series : ");
            string num = Console.ReadLine();
            if (!int.TryParse(num, out int count)) {
                Console.WriteLine(" Invalid number.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(" Fabonacci series : ");
            int fab = 0;
            int num2 = 1;
            int temp=1;
            for (int i = 0; i < count; i++) {
                Console.Write($" {fab},");
                fab = num2;
                num2 = temp;
                temp = fab + temp;
            }
        Console.ReadKey();
        }
    }
}
