using System;

namespace MCA_III_Practicals {
    internal class Program10 {
        static void Main(string[] args) {
            Console.WriteLine(":: Name  : Nilesh Kumar Dahariya");
            Console.WriteLine(":: Class : M.C.A. III sem ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");

            Console.Write($" Enter year between {DateTime.MinValue.Year} to {DateTime.MaxValue.Year} : ");
            string year = Console.ReadLine();
            Console.Write(" Enter month between 1 to 12 : ");
            string month = Console.ReadLine();

            if(!(int.TryParse(year,out int y) && int.TryParse(month,out int m))) {
                Console.WriteLine(" not valid month/year.");
                return;
            }
            if (DateTime.MinValue.Year > y || DateTime.MaxValue.Year < y) {
                Console.WriteLine(" not valid year.");
                return;
            }
            if (!(DateTime.MinValue.Month < y || DateTime.MaxValue.Month > y)) {
                Console.WriteLine(" not valid month.");
                return;
            }
            DateTime days = new DateTime(y, m, 1);
            Console.WriteLine($" Given month has {DateTime.DaysInMonth(y,m)} days \n " +
                $"and total days in given year is {new DateTime(y,12,31).DayOfYear}");

            Console.ReadKey();
        }
    }
}
