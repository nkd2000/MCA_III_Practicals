using System;

namespace MCA_III_Practicals {
    internal class Program02{
        static void Main(string[] args){
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write(" Enter a number : ");
            string inp = Console.ReadLine();

            Double sum = 0;

            if (!int.TryParse(inp, out int val)){
                Console.WriteLine("Enter valid number");
                Console.ReadKey();
                return;
            }
            int len = inp.Length;
            foreach (var digit in inp){
                int d = (int)digit - '0';
                sum += Math.Pow(d,len);
            }
            if (sum == val) {
                Console.WriteLine(" Given number is armstrong number");
            }
            else{
                Console.WriteLine(" Given number is not an armstrong number.");
            }
            Console.ReadKey();
        }
    }
}
