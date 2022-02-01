using System;
using System.Collections.Generic;
using System.Linq;

namespace IqueryableLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHOD SYNTAX
            /*  List<int> Mynumbers = new List<int>()
              {
                  1,2,3,4,5,6,7,8,9
              };
              var selectNumbers = Mynumbers.Where(num => num > 4);
              foreach(var number in selectNumbers)
              {
                  Console.Write(number + " ");
              }
            

              List<string> names = new List<string>()
              {
                  "ola","bola","morayo","ayinde","gbolahan"
              };
              var myNames = from name in names where 
              foreach(var yourNames in myNames)
              {
                  Console.Write(yourNames + " ");
              }   */

            List<Student> students = new List<Student>()
        {
          new Student() {ID = 1, Name = "morayo", Gender = "male"},
          new Student(){ID = 2, Name = "lolade", Gender = "female"},
          new Student(){ID = 3, Name = "funmi", Gender = "female"},
          new Student(){ID = 4, Name = "dayo", Gender = "male"},
          new Student(){ID = 5, Name = "opeyemi", Gender = "female"}
        };

            var maleStudents = from student in students
                               where student.Gender == "male"
                               select new Student

                               {
                                 Name = student.Name,
                                 Gender = student.Gender
                               };
           foreach(var stud in maleStudents)
            {
                Console.WriteLine($"Firstname  {stud.Name}  gender  {stud.Gender}");
            }   

            IEnumerable<Student> newFemaleStudents = students.Where(s => s.Gender == "Female").Select(s => new Student
            {
                ID = s.ID,
                Name = s.Name,
                Gender = s.Gender,
            }) ;
            foreach(var student in newFemaleStudents)
            {
                Console.WriteLine($"FirstName: {student.Name}  Id: {student.ID} Gender: {student.Gender} ");
            }
        }
    }
}
