using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals
{
    internal class Program01
    {
        //To find out the total number of an odd digits and even digits within the given number and print the sum of all odd digits and sum of even digits.
        public static void Main(string[] args)
        {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write("Enter a number : ");
            String number = Console.ReadLine();
            bool isNumeric = int.TryParse(number,out int value);

            if (!isNumeric) {
                Console.WriteLine("Please enter valid number");
                Environment.Exit(0);
            }

            int sumOdd = 0, noOdd = 0, noEven = 0, sumEven=0;

            foreach (var digit in number)
            {
                int x = digit - '0';
                if (x % 2 == 0)
                {
                    sumEven +=x;
                    noEven += 1;
                }
                else
                {
                    sumOdd += x;
                    noOdd += 1;
                }
            }
            Console.WriteLine($" >> In given number {number} ");
            Console.WriteLine($" >> Total number of Odd digits is : {noOdd}");
            Console.WriteLine($" >> Sum of Odd digits is : {sumOdd}");
            Console.WriteLine($" >> Total number of even digits is : {noEven}");
            Console.WriteLine($" >> Sum of Even digits is : {sumEven}");
            Console.ReadKey();
        }

    }
}
