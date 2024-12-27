using System;
using System.IO;
using System.Windows.Forms;

namespace MCA_III_Practicals {

    internal class Program23 {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Student application");
            do {
                Console.WriteLine("1 -> Enter 1 for add student details");
                Console.WriteLine("2 -> Enter 2 for show students details");
                Console.WriteLine("3 -> Enter 3 for exit.");
                string choice = Console.ReadLine();
                    switch (choice) {
                        case "1":
                            new Student().StudentEntry();
                            break;
                        case "2":
                            new Student().StudentDetails();
                            break;
                        case "3":
                            Application.Exit();
                        return;
                        default:
                            Console.WriteLine("Not a valid choice.");
                            break;
                    }
            } while (Console.ReadLine() != "3");
        }
        
    }
    public class Student {
        string name;
        string rollno;
        string dpt;

        public void StudentDetails() {
            string fname = "StudentRecord.txt";
            int counter = 0;
            using (StreamReader reader = new StreamReader(fname)) {
                string line;
                while ((line = reader.ReadLine())!= null) {
                    Console.WriteLine(line);
                    counter++;
                }
            }
            Console.WriteLine($"Total returned rows : {counter-3}");
        }
        public void StudentEntry() {
            string fname = "StudentRecord.txt";
            int existRows = -3;
            if (!File.Exists(fname)) {
                using (FileStream file = File.Create(fname)) {
                    Console.WriteLine($"{fname} is created.");
                    Console.WriteLine(Path.GetFullPath(fname));
                }
                using (StreamWriter writer = new StreamWriter(fname)) {
                    writer.WriteLine("-------------------------------------------------------");
                    writer.WriteLine($"{"s.n.",-5} | {"Roll number",-10} | {"Name",-21} | {"Department",-20}");
                    writer.WriteLine("-------------------------------------------------------");
                }
            }
            Console.WriteLine("Enter number of student : ");
            int sn;
            int.TryParse(Console.ReadLine().ToString(), out sn);
            using (StreamReader reader = new StreamReader(fname)) {
                while(reader.ReadLine() != null) {
                    existRows++;
                }
            }
            using (StreamWriter writter = new StreamWriter(fname,append:true)) {
                for (int i = 0; i < sn; i++) {
                    Console.WriteLine($"\nDetails of student : {i + 1}");
                    Console.WriteLine("------------------------------");
                    Console.Write("Enter student roll number : ");
                    rollno = Console.ReadLine();
                    Console.Write("Enter student name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter department name : ");
                    dpt = Console.ReadLine();
                    writter.WriteLine($"{(existRows + i + 1),-5} | {rollno,-10} | {name,-21} | {dpt,-20}");
                }
            }
        }
    }
}

