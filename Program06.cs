using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals {
    internal class Program06 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write(" Enter first number : ");
            string firstNum = Console.ReadLine();
            Console.Write(" Enter second number of same lenght : ");
            string secondNum = Console.ReadLine();

            if(!int.TryParse(firstNum,out _)) {
                if(!int.TryParse(secondNum, out _)) {
                    Console.WriteLine(" Enter only numbers.");
                    Console.ReadKey();
                    return;
                }
            }
            int sum = 0;
            for (int i = 0; i < firstNum.Length; i++) {
                int x = (int)firstNum[i] - '0';
                int y = (int)secondNum[i] - '0';
                Console.WriteLine($" {x} x {y} = {x * y} + {sum} = {x*y+sum}");
                sum += x * y;
            }
            Console.ReadKey();
        }
        
    }
}
