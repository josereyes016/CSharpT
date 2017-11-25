using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMod3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            ValidateBirthday("111290");
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthday);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            // Gets teacher, course, program, and degree
            Console.WriteLine("Enter the teacher's name");
            string teacher = Console.ReadLine();
            Console.WriteLine("Enter the course");
            string course = Console.ReadLine();
            Console.WriteLine("Enter the program");
            string program = Console.ReadLine();
            Console.WriteLine("Enter the degree");
            string degree = Console.ReadLine();
            PrintTecherDetails(teacher, course, program, degree);
        }

        static void PrintTecherDetails(string teacher, string course, string program, string degree)
        {
            Console.WriteLine("{0} will teach course {1} in the program {2} for degree {3}", teacher, course, program, degree);
        }

        // Not implemented
        static Boolean ValidateBirthday(string birthday)
        {
            throw new NotImplementedException();
        }


    }
}
