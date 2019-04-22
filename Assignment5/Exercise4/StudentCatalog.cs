using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class StudentCatalog
    {
        public Dictionary<int, Student> StudentList = new Dictionary<int, Student>();

        public void AddStudent(Student aStudent)
        {
            StudentList.Add(aStudent.Id, aStudent);
        }

        public Student GetStudent(int id)
        {
            foreach(var stud in StudentList)
            {
                if (stud.Key == id) return stud.Value;
            }
            return null;
        }

        public int GetAverageForStudent(int id)
        {
            int sum = 0;
            foreach (var stud in StudentList)
            {
                if (id == stud.Key)
                {
                    foreach (var mark in stud.Value.TestScores)
                    {
                        sum += mark.Value;
                    }
                    return sum / stud.Value.TestScores.Count;
                }
            }
            return -1;
        }

        public int GetTotalAverage()
        {
            int sum = 0, count = 0;
            foreach(var stud in StudentList)
            {
                foreach (var mark in stud.Value.TestScores)
                {
                    if (mark.Value < 1) continue;
                    sum += mark.Value;
                    count++;
                }
            }
            if(sum != 0) return sum/count;
            return 0;

        }

        public List<Student> GetTopThreeStudents()
        {
            //Creating a List of topStudents
            List<Student> topStudents = new List<Student>();
            
            //Creating an array for saving all average marks
            int[] averageMarks = new int[StudentList.Count];
            int index = 0, temp;

            //Saving all average marks
            foreach (var student in StudentList)
            {
                averageMarks[index++] = GetAverageForStudent(student.Key);
            }

            //Sorting averageMarks Int Array with BubbleSort algorithm
            for (int i = 0; i < index; ++i)
            {
                for (int j = 0; j < index; ++j)
                {
                    if (averageMarks[j] < averageMarks[i])
                    {
                        temp = averageMarks[i];
                        averageMarks[i] = averageMarks[j];
                        averageMarks[j] = temp;
                    }
                }
            }

            //Adding top 3 students from Dictionary "StudentList" to List "topStudents"
            foreach (var student in StudentList)
            {
                if ((GetAverageForStudent(student.Key) == averageMarks[0])
                 || (GetAverageForStudent(student.Key) == averageMarks[1])
                 || (GetAverageForStudent(student.Key) == averageMarks[2])) topStudents.Add(student.Value);
            }
            
            //Returning the final list of top 3 students
            return topStudents;
        }
    }
}