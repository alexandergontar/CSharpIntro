using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public Student[] CreateSampleArray()
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };
            return studentArray;
        }

        public IList<Student> CreateSampleList()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } };
            return studentList;
        }

        public void DisplayStudentArray(Student[] studentArray)
        {
            foreach (var student in studentArray)
            {
                Console.Write($"{student.StudentID}\t{student.StudentName}\t{student.Age}\n");
            }
            Console.WriteLine();
        }

        public void DisplayStudentList(IList<Student> studentList) 
        {
            foreach (var student in studentList)
            {
                Console.Write($"{student.StudentID}\t{student.StudentName}\t{student.Age}\n");
            }
            Console.WriteLine();
        }
    }
}
