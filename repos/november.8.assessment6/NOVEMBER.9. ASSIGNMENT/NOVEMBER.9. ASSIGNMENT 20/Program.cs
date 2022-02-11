using System;

namespace NOVEMBER._9._ASSIGNMENT_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter weight of the man: ");
            double weigth = double.Parse(Console.ReadLine());
            double percentage = 0.17;

            Console.WriteLine($"the weigth of the man is {weigth} kg on the moon.,{ weigth} *{ 0.17} " );
        }
    }
}
