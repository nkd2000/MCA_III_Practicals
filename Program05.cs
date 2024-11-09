using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals {
    internal class Program05 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.WriteLine(" Twin Prime numbers between 1 to 100 are :  ");
            int start = 1;
            int end = 100;
            var prime = new HashSet<int>();
            while(start < end) {
                int i = 2;
                bool f = true;
                while(i < start) {
                    if (start % i == 0) {
                        f = false;
                        break;
                    }
                    i++;
                }
                if (f) {
                    prime.Add(start);
                }
                start++;
            }
            for(var i=0; i<prime.Count(); i++) {
                for(var j=1; j<prime.Count(); j++) {
                    if (prime.ElementAt(i) - prime.ElementAt(j) == 2) {
                        Console.Write($" ({prime.ElementAt(j)},{prime.ElementAt(i)}),");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
