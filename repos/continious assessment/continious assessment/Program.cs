using System;

namespace continious_assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //question no: 1
            /*  int firstNumber, secondNumber ;
              Console.Write("input the firstNumber: ");
              firstNumber = Convert.ToInt32(Console.ReadLine());
              Console.Write("input the secondNumber: ");
              secondNumber = Convert.ToInt32(Console.ReadLine());

              int sum = firstNumber + secondNumber;
              int product = firstNumber * secondNumber;
              int difference = firstNumber - secondNumber;
              int quotient = firstNumber / secondNumber;
              int remainder = firstNumber % secondNumber;
              Console.WriteLine($"sum is: {sum} ");
              Console.WriteLine($"product is :{product}");
              Console.WriteLine($"difference is : {difference}");
              Console.WriteLine($"quotient is : {quotient}");
              Console.WriteLine($"remainder is : {remainder}");

              Console.ReadLine();   */

            //question no: 2

            /*   int firstNumber, secondNumber, thirdNumber;
               Console.Write("input the firstNumber: ");
               firstNumber = Convert.ToInt32(Console.ReadLine());
               Console.Write("input the secondNumber: ");
               secondNumber = Convert.ToInt32(Console.ReadLine());
               Console.Write("input the thirdNumber: ");
               thirdNumber = Convert.ToInt32(Console.ReadLine());

               int sum = firstNumber + secondNumber + thirdNumber;
               int average = (firstNumber + secondNumber + thirdNumber) / 3;
               int product = firstNumber * secondNumber * thirdNumber;

               Console.WriteLine($"sum is : {sum}");
               Console.WriteLine($"average is : {average}");
               Console.WriteLine($"product is : {product}");
               if (firstNumber > secondNumber && thirdNumber < firstNumber && secondNumber > thirdNumber)
               {
                   if (firstNumber > thirdNumber  )
                   {
                       Console.Write("the firstNumber is the greatest among three. ");
                   }
                   else if 
                   {
                       Console.Write("the thirdNumber is the lowest among three. ");
                   }
               }
               else if (secondNumber > thirdNumber)
                   Console.Write("the secondNumber is the lowest among three. ");
               else if (thirdNumber>firstNumber
                   Console.Write("the thirdNumber is the greatest among three. ");
               Console.ReadKey(); */


            //question no : 3
            /*     Console.Write("enter the firstNumber: ");
                 double firstNumber = Convert.ToDouble(Console.ReadLine());
                 Console.Write("enter the number: ");
                 double secondNumber = Convert.ToDouble(Console.ReadLine());

                 if (firstNumber < secondNumber)
                 {
                     Console.Write("the firstNumber is larger.");
                 }
                 else  (firstNumber == secondNumber)
                 {
                     Console.Write("the two numbers are equal.");
                 }
                 Console.ReadLine();   */


            //question no : 4
            /*   int firstNumber = 1;
               while(firstNumber <= 10)
               {
                   int square = firstNumber * 2;
                   int cube = firstNumber * 3;
                   firstNumber+= 1;
                   Console.WriteLine($"the first table: {firstNumber}  and the square is: {square} the cube is: {cube}");
               }
               Console.ReadLine();    */


            //question no : 5
            /* Console.Write("enter the value of height: ");
             int height = Convert.ToInt32(Console.ReadLine());
             Console.Write("enter the value of radius: ");
             int radius = Convert.ToInt32(Console.ReadLine());
             Console.Write("enter the value of pie: ");
             double pie = Convert.ToDouble(Console.ReadLine());

             double volume = pie * (radius * 2) * height;

             Console.WriteLine($"volume of a cylinder is equal to: {volume} ");
             Console.ReadKey(); */

            //question no : 6
            /* Console.Write("Enter a number in feet: ");
             double feet = double.Parse(Console.ReadLine());

             double meters = feet * 0.305;
             Console.WriteLine($"conversion of feet into meters is equal to: {meters}");
             Console.ReadKey();  */


            //question no : 7
            /*  Console.Write("enter a number: ");
              int number = Convert.ToInt32(Console.ReadLine());
              if(number % 2 == 0)
              {
                  Console.WriteLine($"{number} is an even number.");
              }
              else if(number % 2 == 1)
              {
                  Console.WriteLine($"{number} is an odd number.");
              }
              else
              {
                  Console.WriteLine("your result is invalid.");
              }
              Console.ReadLine();   */


            /*   //question no : 9
               Console.Write("enter the firstNumber: ");
               byte firstNumber = byte.Parse(Console.ReadLine());
               Console.Write("enter the secondNumber: ");
               byte secondNumber = byte.Parse(Console.ReadLine());

               if(firstNumber % secondNumber == 0)
               {
                   Console.WriteLine($"{firstNumber} is a multiple of {secondNumber}");
               }
               else
               {
                   Console.WriteLine($"invalid input.");
               }
               Console.ReadLine();   */


            //QUESTION NO: 10
         /*    int largest = 0;
            int counter = 0;

             for (counter = 1; counter <= 10; counter++) ;
             {
                 Console.WriteLine($"enter your {counter} number.");
                 int input = int.Parse(Console.ReadLine());
                 if (input>largest)
                 {
                     largest = input;
                    counter += 1;
                 }
                else if (input == largest)
                {
                    largest = input;
                    counter++;
                }
                 if(input == 0)
                {

                }   */
                
                
                
             }
             Console.WriteLine($"{largest} is the largest number. ");
             Console.ReadLine();   




            //casting of one  data types to another types 
            /*  float a = 2.5f;
              double b = 'a';
              a = (float)b;*/
            /*  Console.Write("enter a number");
             long age  = long.Parse((Console.ReadLine());  */

         /*   string input = (Console.ReadLine());
            int RESULT = 0;
            bool CHECK = int.TryParse(input, out RESULT);
            Console.WriteLine($"results is {RESULT} ");
            Console.WriteLine($"check is {CHECK}");
            Console.ReadKey();   */
            


             
















        }
    }
}
