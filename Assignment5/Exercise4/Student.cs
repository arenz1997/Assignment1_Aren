using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Student
    {
        //The fields of "Student class"
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int> TestScores = new Dictionary<string, int>();

        //Parapeter constructor
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //Default constructor
        public Student()
        {

        }

        //AddTestResult method which sets the values to fields of "Student" class
        public void AddTestResult(string subject, int mark)
        {
            this.TestScores.Add(subject, mark);
        }
    }
}