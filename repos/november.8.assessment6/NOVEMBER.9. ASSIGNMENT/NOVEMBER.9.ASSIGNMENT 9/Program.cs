using System;

namespace NOVEMBER._9.ASSIGNMENT_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARE TWO VARIABLES OF TYPE string AND ASSIGN THEM A VALUE "THE "USE" OF QUOTATIONS CAUSES DIFFICULTIES."(WITHOUT THE OUTER QUOTES).
            //IN ONE OF THE VARIABLS USE QUOTED string AND IN OTHER DO NOT USE IT.
            string and1 = "the \"use\" of quotations causes difficulties.";
            string and2 = "The " + "\u0022" + " use " + "\u0022" + " of quotations causes difficulties";
            Console.WriteLine($"{ and1}");
            Console.WriteLine($"{and2}");
        }
    }
}
