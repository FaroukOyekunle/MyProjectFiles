using System;
using System.Collections.Generic;

namespace Jamb_OOp_class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentReg> Firststudent = new List<StudentReg>();
            string institution = " ";
            string course = " ";
            string registration = "";
            
            for(;;)
            {
                Console.WriteLine("Press 1| to PerformRegistration , Press 2| to Check  your Admission Status: ," +
                    " Press 3| to Update your profile Status , " +
                    "Press 4| to get Admitted as a Student, Press 5| to exit. ");
                Console.WriteLine("***  Main Menu *** ");
                int input = int.Parse(Console.ReadLine());
                
                if(input == 1 )
                {
                    Console.WriteLine("Enter your preferred firstName: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter your preferred lastName: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter your year of birth: ");
                    int yearOfBirth = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the sex you belong too : i.e gender: ");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Enter your preferred choice of institution: ");
                    string institution1 = Console.ReadLine();
                    Console.WriteLine("Enter your preferred course you intended to read: ");
                    string course1 = Console.ReadLine();
 
                    StudentReg student = new StudentReg(firstName , lastName ,yearOfBirth , gender , institution1 , course1);
                    Console.WriteLine(student.GetRegNumber());
                    Firststudent.Add(student);
                }
               
                if(input == 2)
                {
                    Console.WriteLine("Enter the registration number been given to you: ");
                    string studentRegNum = Console.ReadLine();
                    
                    foreach(var item in Firststudent)
                    {
                        if(item.GetRegNumber() == studentRegNum && item.GetIsAdmitted() == true  && item.GetCurrentAge() >= 18)
                        {
                            Console.WriteLine($" Congratulattions! You have been admitted as a student. ");
                           
                        }

                        else
                        {
                            Console.WriteLine($"Sorry! you are yet to be offered any admission. ");
                        }
                    }
                    

                }
                if(input == 3)
                {
                    Console.WriteLine("Enter your registration number to update your status");
                    string regNumberUpdate = Console.ReadLine();

                    foreach(var item in Firststudent)
                    {
                        if(item.GetRegNumber() == regNumberUpdate)
                        {
                            Console.WriteLine("Press 1| to update your firstName , Press 2| to Update your Lastname , " +
                                " Press 3| to update your date of birth , Press 4| to update your given course ," +
                                " Press 5| to update your sex, i.e gender , Press 6| to update your given institution. ");
                            int response = int.Parse(Console.ReadLine());
                            if(response == 1)
                            {
                                Console.WriteLine("Enter the firstname you intended to change: ");
                                item.FirstName = Console.ReadLine();
                            }
                            if(response == 2)
                            {
                                Console.WriteLine("Enter the lastname you which to change: ");
                                item.LastName = Console.ReadLine();
                            }
                            if(response == 3)
                            {
                                Console.WriteLine("Enter the year of birth your choice: ");
                                item.YearOfBirth = int.Parse(Console.ReadLine());
                            }
                            if(response == 4)
                            {
                                Console.WriteLine("Enter the course you which to change too: ");
                                item.Course = Console.ReadLine();
                            }
                            if(response == 5)
                            {
                                Console.WriteLine("Enter the gender you intended to change too: ");
                                item.Gender = Console.ReadLine();
                            }
                            if(response == 6)
                            {
                                Console.WriteLine("Enter the institution you intended to change to: ");
                                item.Institution = Console.ReadLine();
                            }
                            if(response == 6 || response == 4)
                            {
                                foreach(var student in Firststudent)
                                {
                                    if( student.Course == course || student.Institution == institution)
                                    {
                                        student.SetIsAdmitted(true);
                                    }
                                }
                            }
                            
                        }
                        
                    }
                }
                if(input == 4)
                {
                    Console.WriteLine("Press 1| to be given admission by  your RegistrationNumber ," +
                        " Press 2| to get admitted by your given course , " +
                        " Press 3| to be  admitted by your choice of institution");
                    int ans = int.Parse(Console.ReadLine());
                    if(ans == 1)
                    {
                        Console.WriteLine("Enter  your registration number: ");
                        registration = Console.ReadLine();
                    }
                    if(ans == 2)
                    {
                        Console.WriteLine("Enter your course: ");
                        course = Console.ReadLine();
                    }
                    if(ans == 3)
                    {
                        Console.WriteLine("Enter  your institution: ");
                        institution = Console.ReadLine();
                    }
                    foreach(var item in Firststudent)
                    {
                        if(item.GetRegNumber() == registration || item.Course == course || item.Institution == institution)
                        {
                            item.SetIsAdmitted(true);
                        }
                    }
                }
                if(input == 5)
                {
                    break;
                }
            }

        }
    }
}
