using System;

namespace ASSESSMENT_ON_METHOD_NO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a code that by given name prints on the console "Hello, <name>!"
            //(for example: "Hello, Peter!").

            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();
            Hello(yourName);
        }
        public static void Hello(string yourName)
        {
            Console.WriteLine($"Hello  {yourName}");
        }
    }
}
