using System;

namespace firstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string firstName = "arnold  ";
              string lastName = "trent";
              int age = 66;
              double weight = 68.75;
              char grade = 'A';

              Console.WriteLine("my name is:  " + firstName +  lastName);
              Console.WriteLine("i am:  " + age +  " years old");
              Console.WriteLine("THE LEVEL OF MY WEIGHT IS:  " + weight  );
              Console.WriteLine("my best grade is:  " + grade);

              Console.ReadLine */

            /*Console.Write("enter your firstName: ");
            string firstName = Console.ReadLine();

            Console.Write("enter your lastName: ");
            string lastName = Console.ReadLine();

            Console.Write("enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter your weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter your grade: ");
            char grade = Convert.ToChar (Console.ReadLine());

            Console.WriteLine($"my name is { firstName} { lastName}");
            Console.WriteLine("i am " + age + " years old");
            Console.WriteLine("the level of my weight is " + weight + "kg");
            Console.WriteLine("my best grade is " + grade);

            Console.ReadLine();  */

            /* Console.Write("enter the area: ");
              double area = Convert.ToDouble(Console.ReadLine());

              Console.Write("enter the base: ");
              double Base = Convert.ToDouble(Console.ReadLine());

              Console.Write("enter the height: ");
              double height = Convert.ToDouble(Console.ReadLine());

              double AREA = 0.5 *( area + Base) * height;

              Console.ReadKey();   */


            /*            Console.Write("enter A:   ");
                          double A = Convert.ToDouble(Console.ReadLine());

                          Console.Write("enter B:   ");
                          double B = Convert.ToDouble(Console.ReadLine());

                          Console.Write("enter H:    ");
                          double H = Convert.ToDouble(Console.ReadLine());

                          double area = 0.5 *( A + B) * H;

                          Console.WriteLine($"the area of a trapezium is:  {area}");
                          Console.ReadLine();*/


            //IF STATEMENT 

            /*  Console.Write("enter your score: ");
              int score = Convert.ToInt32(Console.ReadLine());

              if (score >= 40 && score <= 100)
              {
                  Console.WriteLine("A");
              }
              else if (score >= 60 && score < 69)
              {
                  Console.WriteLine("B");
              }
              else if (score >= 50 && score <= 59)
              {
                  Console.WriteLine("C");
              }
              else if (score >= 45 && score <= 49)
              {
                  Console.WriteLine("D");
              }
              else if (score >= 40 && score <= 44)  
              {
                  Console.WriteLine("E");
              }
              else if (score >= 0 && score <= 39)
              {
                  Console.WriteLine("F");
              }
              else
              {
                  Console.WriteLine("invalid input");
              }

              Console.ReadKey();    */



            //c# EXERCISE.TXT

            //QUESTION NO: 1

            /*   Console.Write("enter the firstNumber:  ");
              int firstNumber = Convert.ToInt32(Console.ReadLine());

              Console.Write("enter the secondNumber:  ");
              int secondNumber = Convert.ToInt32(Console.ReadLine());

              int result = firstNumber / secondNumber;
              Console.WriteLine($"the division of both answer is equal to {result}");
              Console.ReadKey();    */

            //QUESTION NO: 2

            // fahrenheitDegree = (9 / 5) * Celsius + 32;

            /*     Console.Write("ENTER THE AMOUNT OF CELSIUS:   ");
               int celsius = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("kelvin = {0}", celsius + 273);
             Console.WriteLine("fahrenheit = {0}", celsius * 18 / 10 + 32);

               Console.ReadKey();   */

            //QUESTION NO:3
            /*   Console.Write("enter the first number: ");
               int firstNumber = Convert.ToInt32(Console.ReadLine());
               Console.Write("enter the secondNumber: ");
               int secondNumber = Convert.ToInt32(Console.ReadLine());  */





            // QUESTION NO: 4
            /*    Console.WriteLine("\ninput first integer");
                int x = Convert.ToInt32(Console.ReadLine());

                if(num % 3 == 0 && num % 7 == 0)
            {
            multiple of 3 and 7   
            }
            else if     
                {
                    Console.WriteLine(x % 3 == &&  x % 7 == 0);
                }
            Console.ReadKey();   */



            //QUESTION NO:5
            /*     Console.Write("Input the first integer: ");
                 int x = Convert.ToInt32(Console.ReadLine());
                 Console.Write("input the second integer: ");
                 int y = Convert.ToInt32(Console.ReadLine()); 
                 Console.Write("inputr the third integer: ");
                 int z = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("the largest number among three: " +Math.Max (x, Math.Max(y,z)));
                 Console.WriteLine("the lower number among three: " + Math.Min(x, Math.Min(y, z)));

                 Console.ReadKey();     */

            //QUESTION NO:6
            /*   Console.Write("enter your name: ");
               string name = Console.ReadLine();
               Console.Write("enter your age: ");
               int age = Convert.ToInt32(Console.ReadLine());
               Console.Write("enter your phoneNumber: ");
               double phoneNumber = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine($"your name is {name}");
               Console.WriteLine($"you are {age} years old");
               Console.WriteLine($"your phoneNumber is {phoneNumber}");

               Console.ReadKey();    */

            // QUESTION NO:7
            /*   Console.Write("enter the first number: ");
               int P = Convert.ToInt32(Console.ReadLine());
               Console.Write("enter the second number: ");
               int Q = Convert.ToInt32(Console.ReadLine());
               Console.Write("enter the third: ");
               int R = Convert.ToInt32(Console.ReadLine());

               int result = P + Q + R;
               if (P + Q > R && P + R > Q)
               {
                   Console.WriteLine($"therefore, the perimeter is equal to {result}");
                   Console.WriteLine("congratulations, your result is correct");
               }
               else
               {
                   Console.WriteLine("your answer is invalid");
               }
               Console.ReadKey();    */

            //QUESTION NO:8

            /*   Console.Write("enter the first number: ");
               double firstNumber = Convert.ToDouble(Console.ReadLine());
               Console.Write("enter the second number: ");
               double secondNumber = Convert.ToDouble(Console.ReadLine());

               double addition = firstNumber + secondNumber;
               double subtraction = firstNumber - secondNumber;
               double multiplication = firstNumber * secondNumber;
               double division = firstNumber / secondNumber;

               Console.WriteLine($"the output of adding two integers to each other is equal to: {addition} ");
               Console.WriteLine($"the output of subtracting two integers from each other is equal to:{subtraction} ");
               Console.WriteLine($"the multiplication of two integers to each other is equal to: {multiplication} ");
               Console.WriteLine($"the division of two integers from each other is equal to: {division} ");

               Console.ReadKey();    */

            //QUESTION NO:9
            /*   Console.Write("enter a number: ");
               double numberOne = int.Parse(Console.ReadLine());
               Console.Write("enter another number: ");
               double numberTwo = int.Parse(Console.ReadLine());

               if(numberOne > 0 && numberTwo > 0)
               {
                   Console.WriteLine($"your answer is positive ");
               }
               else
               {
                   Console.WriteLine($"your answer is negative ");
               }
               Console.ReadKey();     */




            //QUESTION NO:10

            /*Console.Write("enter the firstNumber: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the secondNumber: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            if (firstNumber == 20 || firstNumber + secondNumber == 20)
            {

            }*/














            //C# SWITCH STATEMENT  NOVEMBER 2, 2021.
            /*  char GRADE = Convert.ToChar(Console.ReadLine());
              switch(GRADE)
              {
                  case 'A'
                  case 'a':
                      Console.WriteLine("your result is excellent");
                      break;
                  case 'B'
                  case 'b':
                      Console.WriteLine("your result is very.good");
                     break;
                  case 'C'
                  case 'c':
                      Console.WriteLine("your result is good");
                     break;
                  case 'D'
                  case 'd':
                      Console.WriteLine("your result is fair");
                      break;
                  case 'E'
                  case 'e':
                      Console.WriteLine("your result is poor");
                      break;
                  case 'F'
                  case 'f':
                      Console.WriteLine("your failed");
                      break;
                  default:
                  Console.WriteLine("invalid input");
                      break;

              }
              Console.ReadKey();    */




            //C# LOOPS
            //TYPES OF LOOPS       1. WHILE LOOP  2. DO WHILE LOOP    3. FOR LOOP 4. FOR EACH LOOP.

            //examples of while loop

            /*  int index = 1;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadKey();    */



            // CLASSWORK_ONE::: (CONVERT POUNDS TO KILOGRAM)\\
            /*    Console.Write("ENTER A NUMBER IN KILOGRAM: ");
             double kilogram = Convert.ToDouble(Console.ReadLine());
                 double pounds = kilogram * 2.21;
                 Console.WriteLine($"THE CONVERSION OF kilogram TO pounds IS EQUAL TO:  {pounds}");
                 Console.ReadKey();     */

            //CONVERSION FROM KILOGRAMS TO POUNDS DISPLAYING TWO TABLES SIDE BY SIDE.

            /* int KILOGRAM = 1;
             while (KILOGRAM <= 2.205)
             {
                 double POUNDS = KILOGRAM * 2.205;
                 Console.WriteLine($"{KILOGRAM}    {POUNDS}");
                 KILOGRAM += 2;
             }
             Console.ReadKey();  */







            //DAY TWO ASSIGNMENT.TXT
            //QUESTION NO: 1
            /*  string line = "CONVERSION FROM KILOGRAMS TO POUNDS DISPLAYING TWO TABLES SIDE BY SIDE.";

              Console.WriteLine(line.ToLower());
              Console.ReadKey();   */

            //QUESTION NO: 2
            /*   int firstNumber, secondNumber;
               bool bothEven;
               Console.WriteLine("input the firstNumber: ");
               firstNumber = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("input the secondNumber: ");
               secondNumber = Convert.ToInt32(Console.ReadLine());

               //bothEven = ((firstnumber%2!= 0) || (firstNumber%2! = 0))? false:true;
               bothEven = ((firstNumber % 2 == 0) && (secondNumber % 2 == 0)) ? true : false;

               Console.WriteLine(bothEven ? "there're numbers bothEven" : "there's a number odd");

               Console.ReadKey();  */

            //QUESTION NO: 3

            /*   int i = 1;
               Console.Write("Display the first 10 natural numbers:\n ");

               Console.WriteLine("the first 10 natural number: ");
               for (i = 1; i <= 10; i++) ;
               {
                   Console.Write("{0} ", i);
               }
               Console.Write("\n\n");

               Console.ReadKey();*/

            /* int index = 1;
             while (index <= 10)
             {
                 Console.WriteLine(index);
                 index++;
             }
             Console.ReadKey(); */

            //QUESTION NO: 4
            /*  int firstNumber, secondNumber, thirdNumber;
              Console.Write("input the firstNumber: ");
              firstNumber = Convert.ToInt32(Console.ReadLine());
              Console.Write("input the secondNumber: ");
              secondNumber = Convert.ToInt32(Console.ReadLine());
              Console.Write("input the thirdNumber: ");
              thirdNumber = Convert.ToInt32(Console.ReadLine());

              if (firstNumber > secondNumber)
              {
                  if (firstNumber > thirdNumber)
                  {
                      Console.Write("the firstNumber is the greatest among three. ");
                  }
                  else
                  {
                      Console.Write("the thirdNumber is the greatest among three. ");
                  }
              }
              else if (secondNumber > thirdNumber)
                  Console.Write("the secondNumber is the greatest among three. ");
              else
                  Console.Write("the thirdNumber is the greatest among three. ");
              Console.ReadKey();    */

            //QUESTION NO: 5

            /*   Console.WriteLine("program to convert");
               Console.WriteLine("Press 0 to convert from U.S Dollar to Chinese RMB and 1 to convert from Chinese RMB to Dollar");

               byte input = byte.Parse(Console.ReadLine());

               if( input == 0)
               {
                   Console.WriteLine("Convert U.S Dollar to Chinese RMB");
                   Console.WriteLine("enter the dollar amount:");
                   double dollar = Convert.ToDouble(Console.ReadLine());

                   double result = dollar * 342;
                   Console.WriteLine($"the conversion from U.S Dollar to Chinese RMB is {result}");
               }
              else if (input == 1)
               {
                   Console.WriteLine("Convert Chinese RMB to U.S Dollar");
                   Console.WriteLine("enter the Chinese RMB:");
                   double chineseRmb = Convert.ToDouble(Console.ReadLine());

                   double result = chineseRmb / 342;
                   Console.WriteLine($"the conversion from Chinese RMB to U.S Dollar is {result}");
               }
               else
               {
                   Console.WriteLine("the input is invalid");   

               }    */


            //QUESTION NO: 6
            /*   Console.WriteLine("Program To calculate Interest");
               Console.WriteLine("enter balance; ");
               double balance = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("enter annual interest Rate; ");
               double interestRate = Convert.ToDouble(Console.ReadLine());

               double interest = balance * (interestRate / 1200);
               Console.WriteLine($" the equivalent interest for { balance} and {interestRate} is  {interest}");   */


            //QUESTION NO: 8
            /*   Console.WriteLine("Program To enter minutes ");
               double minutes = Convert.ToDouble(Console.ReadLine());

               double year = Math.Floor(minutes / 525600);
               double days = Math.Floor((minutes % 525600) / 1440);

               Console.WriteLine($"the years is {year} years and {days} days");

               Console.ReadKey();   */

            //QUESTION NO: 9

            /*    Console.WriteLine("enter today's date: ");
                double date = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the number of days elasped since today: ");
                double timeElasped = Convert.ToDouble(Console.ReadLine());

                double futureDate = (date + timeElasped) % 7;
                String day_of_week = "";

                switch(date)
                {
                    case 0: day_of_week = "sunday";
                        break;
                    case 1: day_of_week = "monday";
                        break;
                    case 2: day_of_week = "tuesday";
                        break;
                    case 3: day_of_week = "wednesday";
                        break; 
                    case 4: day_of_week = "thurday";
                .;        break;
                    case 5: day_of_week = "friday";
                        break;
                    case 6: day_of_week = "saturday";
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }

                if(futureDate == 0)
                {
                    Console.WriteLine("today's is %s and the future day is sunday", day_of_week);
                    Console.WriteLine("today's is %s and the future day is monday", day_of_week);
                    Console.WriteLine("");
                }    */





            Console.Write("enter your mathematics score: ");
            int mathSore = int.Parse(Console.ReadLine());
            double percent1 = (mathSore * 100) / 100);
            if (percent1 >= 90 )
            {
                Console.WriteLine("your math grade is A");
            }
            else if(percent1 >= 80 || percent1 <= 90)
            {
                Console.WriteLine("your math score is B");
            }
            else if(percent1 >= 70 || percent1 <= 80)
            {
                Console.WriteLine("your math score is C");
            }
            else if(percent1 >= 60 || percent1 <= 70)
            {
                Console.WriteLine("your math score is D");
            }
            else if(percent1 >= 50 || percent1 <= 60)
            {
                Console.WriteLine("your math score is E");
            }
            else if (percent1 >= 40 || percent1 <= 50)
            {
                Console.WriteLine("your math score is F");
            }

            Console.Write("enter your english score: ");
            int engScore = int.Parse(Console.ReadLine());
            double percent2 = (engScore * 100) / 100);
            if (percent2 >= 90)
            {
                Console.WriteLine("your english grade is A");
            }
            else if(percent2 >= 80 || percent2 <= 90)
            {
                Console.WriteLine("your english grade is B");
            }
            else if (percent2 >= 70 || percent2 <= 80)
            {
                Console.WriteLine("your english score is C");
            }
            else if (percent2 >= 60 || percent2 <= 70)
            {
                Console.WriteLine("your emglish score is D");
            }
            else if (percent2 >= 50 || percent2 <= 60)
            {
                Console.WriteLine("your english score is E");
            }
            else if (percent2 >= 40 || percent2 <= 50)
            {
                Console.WriteLine("your english score is F");
            }
             Console.Write("enter your physics score: ");
            int phyScore = int.Parse(Console.ReadLine());
            double percent2 = (engScore * 100) / 100);
            if (percent2 >= 90)
            {
                Console.WriteLine("your english grade is A");
            }
            else if (percent2 >= 80 || percent2 <= 90)
            {
                Console.WriteLine("your english grade is B");
            }
            else if (percent2 >= 70 || percent2 <= 80)
            {
                Console.WriteLine("your english score is C");
            }
            else if (percent2 >= 60 || percent2 <= 70)
            {
                Console.WriteLine("your emglish score is D");
            }
            else if (percent2 >= 50 || percent2 <= 60)
            {
                Console.WriteLine("your english score is E");
            }
            else if (percent2 >= 40 || percent2 <= 50)
            {
                Console.WriteLine("your english score is F");






























                /*   Console.Write("enter your chemistry score: ");
                   int cheScore = int.Parse(Console.ReadLine());
                   Console.Write("enter your biology score: ");
                   int bioScore = int.Parse(Console.ReadLine());
                   if ()
                   A')
                     {
                       Console.WriteLine("your result is excellent");
                   }
                     else if (grade == 'B')
                   {
                       Console.WriteLine("your result is very good");
                   }
                   else if (grade == 'C')
                   {
                       Console.WriteLine("your result is good");
                   }
                   else if (grade == 'D')
                   {
                       Console.WriteLine("your result is fair");
                   }
                   else if (grade == 'E')
                   {
                       Console.WriteLine("your result is poor");
                   }
                   else if (grade == 'F')
                   {
                       Console.WriteLine("your result is very bad");
                   }
                   else
                   {
                       Console.WriteLine("your result is invalid");
                   }
                   ")    */














            }
        }
}
