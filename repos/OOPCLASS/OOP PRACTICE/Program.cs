using System;

namespace OOP_PRACTICE
{
    namespace OOP_PRACTICE.OOP_PRACTICE
    {
        class program
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("ade");
            student.SetAge(58);
            Student student1 = new Student();
            student.SetName("trent");
            student.SetAge(29);
            Student student2 = new Student();
            student.SetName("arnold");
            student.SetAge(21);
            Student student3 = new Student();
            student.SetName("ashake");
            student.SetAge(18);
            Student student4 = new Student();
            student.SetName("kabirah");
            student.SetAge(27);

            student.PrintStudentDetails();
        }
    }
    class Student
    {
        string studentName;
        int studentAge;


        public string Getname()
        {
            return studentName;
        }

        public void SetName(string studentName)
        {
            this.studentName = studentName;
        }


        public  void PrintStudentDetails()
        {
            Console.WriteLine($"{studentName} is {studentAge} years old");
        }


        public int Getage()
        {
            return studentAge;
        }
        public void SetAge(int studentAge)
        {
            this.studentAge = studentAge;
        }


    }


}
