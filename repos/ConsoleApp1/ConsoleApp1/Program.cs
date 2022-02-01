using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amotul Fareed";
            string lastName = "Olayemi";
            int age = 17;
            string address = "jagun street,orisunbare area,oke-odo,Apata,Ibadan";
            double accBalance = 89.56;
            char bestGrade = 'B';
            Console.WriteLine("My name is " + firstName  + lastName);
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("I live at " + address);
            Console.WriteLine("My Account Balance is " + accBalance);
            Console.WriteLine("My Best Grade is " + bestGrade);
            Console.ReadLine();

        }
    }
}
