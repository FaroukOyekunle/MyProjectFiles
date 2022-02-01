using System;

namespace constructorANDencapsulation_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class STUDENT
    {
        public string name;

        public int age;

        public string state;

        public string Email;

        public decimal payment;

        public bool IsCleared;

        public STUDENT(decimal Payment, bool iscleared)
        {
            payment = Payment;
            iscleared = IsCleared;
        }

//public override void PrintStudentDetails()
//{
       //     Console.WriteLine(IsCleared? $"You have been successfully registered, and you {IsCleared}? "have" :  "have not" been cleared.  ");
//}
    }


}
