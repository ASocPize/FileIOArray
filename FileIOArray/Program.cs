using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = @"Data\Student.txt";
            string[] students;

            students = new string[3];
            students[0] = "Sue,McWaters,34";
            students[1] = "Bill,Tompson,23";
            students[2] = "Charlie,Velis,22";

            WriteAllStudents(dataPath, students);

            students = ReadAllStudents(dataPath);

            DisplayStudentInfo(students);
        }

        static void DisplayStudentInfo(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("Student Info");
            Console.WriteLine();

            //++++++++++++++++//
            // Display Header //
            //++++++++++++++++//

            Console.WriteLine("First Name".PadRight(15) + "Last Name".PadRight(15) + "Age".PadRight(15));

            Console.WriteLine("--------".PadRight(15) + "--------".PadRight(15) + "--------".PadRight(15));

            foreach (string student in students)
            {
                //++++++++++++++//
                // Info Sorting //
                //++++++++++++++//

                string[] studentInfo = student.Split(',');
                string firstName = studentInfo[0];
                string LastName = studentInfo[1];
                string Age = studentInfo[2];

                //+++++++++++++++//
                // Display Table //
                //+++++++++++++++//

                Console.WriteLine(firstName.PadRight(15) + LastName.PadRight(15) + Age.PadRight(15));

                //Console.WriteLine(student);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static string[] ReadAllStudents(string dataPath)
        {
            string[] students;

            students = File.ReadAllLines(dataPath);

            return students;
        }
    }
}
