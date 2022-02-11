using System;

namespace NOVEMBER._9.ASSIGNMENT_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARE TWO VARIABLES OF TYPE string WITH VALUES "Hello" AND "World". DECLARE A VARIABLE OF TYPE object. ASSIGN TO THIS VARIABLE
            // THE VALUE OBTAINED OF CONCATENATION OF THE TWO STRING VARIABLES(ADD SPACE IF NECESSARY). PRINT THE VARIABLE OF TYPE object.
            string greet = "Hello";
            string wave = "World";

            object  greetingsweeve = greet + "   " + wave;
            Console.WriteLine(greet + "  " + wave);
        }
    }
}
