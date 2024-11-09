using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA_III_Practicals {
    internal class Program09 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write(" Enter first operand op1 : ");
            string op1 = Console.ReadLine();
            Console.Write(" Enter second operand op2 : ");
            string op2 = Console.ReadLine();
            Console.Write(" Enter an operator (+,-,*,/,%) : ");
            string opr = Console.ReadLine();

                    var oper = new HashSet<char>() {'+', '-', '*', '/', '%' };
            if (!(float.TryParse(op1, out _) && float.TryParse(op2, out _) && oper.Contains(opr[0]))) {
                Console.WriteLine(" invalid input");
                Console.ReadKey();
                return;
            }
            float res = 0;
            switch (opr) {
                case "+": res = float.Parse(op1) + float.Parse(op2);
                    break;
                case "-": res = float.Parse(op1) - float.Parse(op2);
                    break;
                case "*": res = float.Parse(op1) * float.Parse(op2);
                    break;
                case "/": res = float.Parse(op1) / float.Parse(op2);
                    break;
                case "%": res = float.Parse(op1) % float.Parse(op2);
                    break;
            }

            Console.WriteLine($" {op1} {opr} {op2} = {res}");
            Console.ReadKey();
        }

    }
}
