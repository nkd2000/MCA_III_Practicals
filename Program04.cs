using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals {
    internal class Program04 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write(" Enter start number : ");
            string start = Console.ReadLine();
            Console.Write(" Enter end number : ");
            string end = Console.ReadLine();

            if(!int.TryParse(start,out int sval)) {
                if (!int.TryParse(end, out _)) {
                    Console.WriteLine(" Enter only numbers.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine($" Prime numbers from {start} to {end} are : ");
            int.TryParse(end,out int val);
            while(sval <= val) {
                int i = 2;
                bool f = true;
                while(i < sval) {
                    if(sval%i == 0) {
                        f = false;
                        break;
                    }
                    i++;
                }
                if (f) {
                    Console.Write($" {sval},");
                }
                sval++;
            }
            Console.ReadKey();
        }
    }
}
