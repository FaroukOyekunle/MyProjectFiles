using System;

namespace NOVEMBER._9._ASSIGNMENT_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // WRITE AN EXPRESSION THAT CHECKS FOR A GIVEN INTEGER IF ITS THIRD DIGIT ( RIGHT TO LEFT) IS 7.
            int myNum = 45764/ 100 ;
            int myNum1 = myNum % 10;
            Console.WriteLine(myNum1 == 7 );
        }
    }
}
