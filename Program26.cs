using System;

namespace MCA_III_Practicals {
    internal class Program26 {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            invalidInputn1:
            Console.Write("Enter starting number : ");
            if(!int.TryParse(Console.ReadLine(),out int n1)) {
                Console.WriteLine("not a valid number.");
                goto invalidInputn1;
            }
            invalidInputn2:
            Console.Write("Enter ending number : ");
            if(!int.TryParse(Console.ReadLine(), out int n2)) {
                Console.WriteLine("not a valid number.");
                goto invalidInputn2;
            }
            string even = string.Empty, odd = string.Empty;
            Console.WriteLine($"Here is Even Odd series from {n1} to {n2}");
            for(int i = n1; i <= n2; i++) {
                if (i % 2 == 0) {
                    even += $"{i}, ";
                }
                else {
                    odd += $"{i}, ";
                }

            }
            Console.WriteLine($"Even numbers are : {even,4}");
            Console.WriteLine($"Odd numbers are  : {odd,4}");
            Console.ReadKey();
        }
    }
}
