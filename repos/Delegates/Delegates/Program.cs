using System;
using System.Collections.Generic;

namespace Delegates
{
  
    class Program
    {
        public delegate bool MyDelegate(Student Student);
        static void Main(string[] args)
        {
            
            var students = new List<Student>()
            {
                new Student
                {
                    Name = "tobi",
                    Age = 15,
                    Gender = "FEMALE"
                },
                new Student
                {
                    Name = "sola",
                    Age = 12,
                    Gender = "FEMALE"
                },
                new Student
                {
                    Name = "adeayo",
                    Age = 50,
                    Gender = "MALE"
                },
                new Student
                {
                    Name = "adefemi",
                    Age = 40,
                    Gender = "MALE"
                },
                new Student
                {
                    Name = "solakunmi",
                    Age = 9,
                    Gender = "FEMALE"
                },
                new Student
                {
                    Name = "morayo",
                    Age = 20,
                    Gender = "MALE"
                },


            };

            //  PrintDetails("male that start with a", students, st => st.Name.StartsWith("a") && st.Gender.Equals("MALE"));
            //  MALE STUDENTS THAT THERE NAME START WITH 'A'.

            //  PrintALLDetails("ade", students);     NORMAL STUDENTS DETAILS:

            //  PrintDetails("only male student", students,IsMale20);    STUDENTS OF MALE GENDER 


            //anonymous functions

            /*  MyDelegate maleDelegate = delegate (Student student)
                 {
                     return student.Gender.Equals("Male");
                 };

                 PrintDetails("Male students", students, maleDelegate);   */



            /*  MyDelegate studentLessThanFour = delegate (Student student)
              {
                  return student.Name.Length > 4;
              };

              PrintDetails("Male students with the name higher than four letter", students, studentLessThanFour);    */


            // lambda expression that matches delegate signature\\
            /*  MyDelegate femaleLessThanTwenty =  (Student student) =>
              {
                  return student.Gender.Equals("FEMALE") && student.Age < 20;
              };

              PrintDetails("female student less than twenty years ", students, femaleLessThanTwenty);   

              MyDelegate femaleLessThan = (Student student) =>
              {
                  return student.Gender.Equals("FEMALE") && student.Age < 20;
              };   */

            //  MyDelegate femaleLessThanTwent = (Student student) => student.Gender.Equals("FEMALE");

            //DELEGATE COMPARISON\\

            /*   MyDelegate femaleLessThanTwentyYears = delegate (Student student)
               {
                   return student.Gender.Equals("FEMALE") && student.Age < 20;
               };

               PrintDetails("female student less than twenty years ", students, femaleLessThanTwentyYears);  */

          //  PrintDetails("male that start with a", students, st => st.Name.StartsWith("a") && st.Gender.Equals("MALE"));
        }  

        static void PrintDetails(string title, List<Student> students, MyDelegate myFilter)
        {

            foreach(var student in students)
            {
                if (myFilter(student))
                {
                    
                    Console.WriteLine(student);
                }
            }
        }

        static bool IsMale20(Student student)
        {
            return student.Gender.Equals("Male") && student.Age > 20;
        }
        static void PrintALLDetails(string title, List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void PrintStudentsDetailsA(string title, List<Student> students)
        {
            foreach (var student in students)
            {
                if(student.Name.StartsWith("a"))
                {
                    Console.WriteLine(student);
                }
            }
        }
        static void PrintStudentThatAreFemale(string title, List<Student> students)
        {
            foreach (var student in students)
            {
                if(student.Gender.Equals("FEMALE"))
                {
                    Console.WriteLine(student);
                }
            }
        }
        static void PrintStudentThatAreOlderThanTwenty(string title, List<Student> students)
        {
            foreach(var student in students)
            {
                if(student.Age > 20)
                {
                    Console.WriteLine(student);
                }
            }
        }
        
    }
}
