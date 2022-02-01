using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralAdminitrativeProcessingUnit
{
    class StudentRegistrationPortal
    {
        public string FirstName;

        public string LastName;

        public String RegistrationNumber;

        public  int YearOfBirth;

        public  string Gender;

        public string ChoiceOfInstitution;

        public string CourseOffered;

        private bool IsAdmitted = false;

        public  RegisterStudent(string firstname, string lastname, String reistrationNumber ,int yearofbirth, string gender, string choiceofinstitution, string courseoffered )
        {
            FirstName = firstname;
            LastName = lastname;
            RegistrationNumber = reistrationNumber;
            YearOfBirth = yearofbirth;
            Gender = gender;
            ChoiceOfInstitution = choiceofinstitution;
            CourseOffered = courseoffered;
        }

        public string GenerateRegNo()
        {
            Random random = new Random();
            int number = random.Next(1000, 10000);
            int num1 = random.Next(0, 26);
            int num2 = random.Next(0, 26);
            char[] letter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            String registrationNumber = $"JM{number}{letter}{[num1]}{letter}{num2}";
            return registrationNumber;

            //string registrationNumber = $"JM{random.Next{0,9999}.ToString{"0000"}}{(((char)random.Next{'A',26}
            //return registrationNumber;
        }

        public  StudentRegistrationPortal registrationPortal()
        {
            Console.Write("Enter your preferred firstName:");
            string FirstName = Console.ReadLine();


            
        }
    }
}
