using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals{
    internal class Program03{
        static void Main(string[] args){
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write(" Enter a number : ");
            string inp = Console.ReadLine();
            if(!int.TryParse(inp,out int val)) {
                Console.WriteLine(" Please enter only numbers.");
                Console.ReadKey();
                return;
            }
            double sum = 0;
            foreach(var dig in inp) {
                int digit = (int)dig - '0';
                sum += digit;
            }

            if(val%sum == 0) {
                Console.WriteLine(" Given number is a harshad Number.");
            }
            else {
                Console.WriteLine(" Given number is not a harshad number.");
            }
            Console.ReadKey();
        }
    }
}
