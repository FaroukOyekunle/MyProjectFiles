using System;

namespace november._8.assessment10
{
    class Program
    {
        static void Main(string[] args)
        {
          //  what is casting, explain types of casting and give examples.
          // answer: CASTING is used to convert explicitly an expression to a given type, i.e copying a value into a variable
         //  or method parameter of another type.
          // CASTING is also a way of telling the compiler "Object X is really type Y, go ahead and treat it as such."
        // TYPES OF CASTING:
         //   * implicit casting - Implicit casting is done automatically when passing a smaller size type to a larger size type.
    
        //    * explicit casting - Explicit casting must be done manually by placing the type in parentheses in front of the value.

        //     EXAMPLES: 
      //  * implicit casting - int sum = 66;
             //                double result = sum;
      //   * explicit casting - double myDouble = 9.78;
        //                      int result = (int)myDouble;    // Manual casting: double to int

          //                    Console.WriteLine(myDouble);   // Outputs 9.78
            //                  Console.WriteLine(result);      // Outputs 9
        }
    }
}
