using System;

namespace WEEKEND_ASSESSMENT_BATCH_7_NO_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //  (Science: day of the week) Zeller’s congruence is an algorithm developed by Christian Zeller to calculate the day of the week.The formula is



            //Where :
            //h is the day of the week(0: Saturday, 1: Sunday, 2: Monday, 3: Tuesday, 4: Wednesday, 5: Thursday, 6: Friday).
            //q is the day of the month.
            //m is the month (3: March, 4: April, . . ., 12: December). January and February are counted as months 13 and 14 of the previous year. 
            //j is the century (i.e., ).
            //k is the year of the century(i.e., year % 100).


            string[] days = { "saturday", "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", };
            Console.WriteLine("Enter your preferred year in digits: e.g  1999: ");
            int years = Int32.Parse(Console.ReadLine());
            int k = years / 100;
            int k1 = years % 100;

            Console.WriteLine("enter your preferred month 1-12: ");
            int a = Int32.Parse(Console.ReadLine());
            if(a > 12 && a <=14)
            {
                a = a % 12;
                years--;
            }

            Console.WriteLine("Enter your preferred day of the month from the above range 1- 31: ");
            int b = Int32.Parse(Console.ReadLine());
            int b1 = (26 * (a + 1)) / 10;
            int i = (b + b1 + k + k / 4 + a / 4 + 5 * a) % 7;
            for(int r = 0; r <= days.Length; r++)
            {
                Console.WriteLine($"the day of the week is {days[i]} {i} {a} {years}");
            }
        }
    }
}
