using System;

namespace NOVEMBER._9.ASSIGNMENT_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARE TWO VARIABLES OF TYPE string AND ASSIGN THEM VALUES "Hello" AND "World". DECLARE A VARIABLE OF TYPE object AND ASSIGN TO IT THE VALUE
            //OBTAINED OF CONCATENATION OF THE TWO VARIABLES OF TYPE STRING (do Not MISS THE SPACE IN THE MIDDLE).
            // DECLARE A THIRD VARIABLE OF TYPE string AND INITIALIZE IT WITH THE VALUE OF THE VARIABLE OF TYPE object (you should use type casting).
            string object1 = "Hello";
            string object2 = "World";
            object object3 = object1 + "   " + "World";

            string object4 = object3.ToString();

            Console.WriteLine(object4);
        }
    }
}
