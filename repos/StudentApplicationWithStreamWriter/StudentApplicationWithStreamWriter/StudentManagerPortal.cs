using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplicationWithStreamWriter
{
    class StudentManagerPortal
    {
        readonly FileManagerPortal _fileManager = new FileManagerPortal("../../../file.txt");
        List<Student> Students = new List<Student>();

        public StudentManagerPortal()
        {
            LoadStudentContentFromFile();
        }

        // Method use in creating or making registration for each aspirant / student.
        public void CreateOrMakeARegistrationForEachStudent()
        {
            ; ;
            Console.WriteLine("Enter Your FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your LastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Gender: ");
            string gender = Console.ReadLine();
            var student = new Student(firstName, lastName, email, phoneNumber, age, gender, Students.Count +1);
            SaveStudentDetails(student);
        }

        //Method use in updating student new information back to the Studentportal.
        public  void UpdateStudentDetails()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            var student = FindStudentFileInfo(regNumber);
            if (student != null)
            {
                student.UpdateInfo();
                RefreshStudentDetails();
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public  void RemoveStudent()
        {
            Console.WriteLine("Enter the registration number of the student you which to remove. ");
            string regNumber = Console.ReadLine().Replace("", " ");
            foreach(var student in Students)
            {
                if(student.RegNumber.Equals(regNumber))
                {
                    Students.Remove(student);
                }
            }
        }

        // Method use in searching/ finding a student through its Registered registration number.
        public void FindStudentDetails()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            foreach (var student in Students)
            {
                if (student.RegNumber == regNumber)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }

       // Method use in finding student information through its registration number if its correct or not.
        public Student FindStudentFileInfo(string regNumber)
        {

            foreach (var student in Students)
            {
                if (student.RegNumber == regNumber)
                {
                    return student;
                }
            }
            return null;
        }

        // Message use in returning list of all student/aspirant back to the Profile list.
        public void ListOfAllStudentDetails()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        // Method use in loading student content profile from file.
        private void LoadStudentContentFromFile()
        {
            foreach (var line in _fileManager.Read())
            {
                Student student = Student.ConvertToStudent(line);
                Students.Add(student);
            }
        }
        // Method use in refreshing student list after making a changes/ updating of any student infornation.
        private  void RefreshStudentDetails()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (i == 0)
                {
                    _fileManager.Write(Students[i].ToString(), false);
                }
                else
                {
                    _fileManager.Write(Students[i].ToString());
                }
            }
        }

        // Method use in saving each student information back to the file
        private void SaveStudentDetails(Student student)
        {
            Students.Add(student);
            _fileManager.Write(student.ToString());
        }
    }
}
