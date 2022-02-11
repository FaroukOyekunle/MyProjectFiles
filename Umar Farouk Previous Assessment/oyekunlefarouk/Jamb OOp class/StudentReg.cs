using System;
using System.Collections.Generic;
namespace Jamb_OOp_class
{
    class StudentReg
    {
        public string FirstName;
        public string LastName;
        public int YearOfBirth;
        public string Gender;
        public string Institution;
        public string Course;
        bool YouAreBeenAdmitted;
        string RegistrationNumber;
        int Age;

        public StudentReg(string firstName , string lastName , int yearOfBirth , string gender , string institution , string course )
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            Gender = gender;
            Institution = institution;
            Course = course;
            YouAreBeenAdmitted = false;
            RegistrationNumber = GenerateRegNum();
            Age = GetCurrentAge();
        }
        public string GenerateRegNum()
        {
            char [] alphabetLetters = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            string randIdNumber = " ";
            for(int i = 0; i < 2; i++)
            {
                Random rdm = new Random();
                int num = rdm.Next(alphabetLetters.Length);
                randIdNumber += $"{alphabetLetters[num]}";
                
            }
            Random rdm2 = new Random();
            int num2 = rdm2.Next(1000 , 10000);
            string IdNumber = num2.ToString();
            string registrationNumber ="JM"+IdNumber+randIdNumber ;
            return registrationNumber;
        }
        public string GetRegNumber()
        {
            return RegistrationNumber;
        }
        public int GetCurrentAge()
        {
            return  2021 - YearOfBirth;
        }
        public bool GetIsAdmitted()
        {
            return YouAreBeenAdmitted;
        }
        public void SetIsAdmitted(bool check)
        {
            YouAreBeenAdmitted = check;
        }
    }
}