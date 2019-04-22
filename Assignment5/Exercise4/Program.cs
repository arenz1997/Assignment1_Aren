using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //Printing all students list
        public static void PrintStudentList(List<Student> students)
        {
            Console.WriteLine("\n\nTop 3 students...\n");
            foreach (var student in students)
            {
                Console.WriteLine(student.Id + "\t" + student.Name);
                foreach (var mark in student.TestScores)
                {
                    Console.WriteLine(mark.Key + "-" + mark.Value);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Console design
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            StudentCatalog students = new StudentCatalog();
            
            //Creating some students
            Student anna = new Student(12, "Anna");
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");
            Student diana = new Student(295, "Diana");
            
            //Adding some marks to those students
            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            diana.AddTestResult("English", 57);
            diana.AddTestResult("Math", 42);
            diana.AddTestResult("Chemistry", 75);
            diana.AddTestResult("French", 44);

            //Adding those students into "students" StudentCatalog
            students.AddStudent(anna);
            students.AddStudent(betty);
            students.AddStudent(carl);
            students.AddStudent(diana);

            Console.WriteLine("Total average of all students - " + students.GetTotalAverage() + "\n");

            //Creating a list of students and printing it via static method "GetTopThreeStudents"
            List<Student> std = new List<Student>();
            std = students.GetTopThreeStudents();
            PrintStudentList(std);
        }
    }
}