using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System.Security;


namespace LINQ
{
    class SimpleConfigModule : NinjectModule
    {
        //CimCredential Credentials;
        public override void Load()
        {
            // ConnectionOptions oConn = new();
           // ConnectionOptions connection = new ConnectionOptions();
            // CimSession mySession = CimSession.Create("127.0.0.1");

            //Bind<IScheduleManager>().To<ScheduleManager>();
            // нижняя строка необязательна, это поведение стоит по умолчанию:
            // т.е. класс подставляет сам себя
            //Bind<ScheduleViewer>().ToSelf();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            ConnectionOptions connection = new ConnectionOptions();
            // CimSession mySession = CimSession.Create("127.0.0.1");
            /* Console.WriteLine("Hello World!");
             string[] names = { "Bill", "Steve", "James", "Mohan" };
             var linqQuery =
                 from name in names
                 where name.Contains('a')
                 select name;
             foreach(string name in linqQuery) 
             {
                 Console.Write(name + " ");
             }*/
            Student studentSample = new Student();
            Student[] studentArray = studentSample.CreateSampleArray();        
            studentSample.DisplayStudentArray(studentArray);

            var teenagerStudents = from s in studentArray
                                   where s.Age < 20
                                   select s;
            studentSample.DisplayStudentArray(teenagerStudents.ToArray());

            Student[] teenAgerStudent = studentArray.Where(s => s.Age > 12 &&
                                                         s.Age <= 19).ToArray();
            studentSample.DisplayStudentArray(teenAgerStudent);

            IList<Student> studentList = studentSample.CreateSampleList();
            studentSample.DisplayStudentList(studentList);
            IList<Student> teenagerList = studentList.Where(s => s.Age < 20).ToList();
            studentSample.DisplayStudentList(teenagerList);

            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine($"{bill.StudentID}  {bill.StudentName} {bill.Age}");
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine($"{student5.StudentID}  {student5.StudentName} {student5.Age}");
            Console.ReadKey();
        }
    }
}
