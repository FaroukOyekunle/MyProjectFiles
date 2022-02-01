using System;

namespace QUESTION.TXT_TWO
{
    class Program
    {
        static void Main(string[] args)
        {
            //question no : 1
            /* Write an app that plays “guess the number” as follows: Your app
             chooses the number to be guessed by selecting a random integer in the range 1 to 1000.The app
             displays the prompt Guess a number between 1 and 1000.The player inputs a first guess.If the player's
             guess is incorrect, your app should display Too high. Try again. or Too low.Try again. to help
             the player “zero in” on the correct answer. The app should prompt the user for the next guess.When
             the user enters the correct answer, display Congratulations.You guessed the number! and allow
             the user to choose whether to play again.    */


            /* bool playOn = true;
             while (playOn)
             {
                 Random random = new Random();
                 int prediction = random.Next(1, 1000);
                 Console.WriteLine(prediction);

                 bool guessOn = true;
                 while (guessOn)
                 {

                     Console.Write("Enter guess:");
                     int guess = int.Parse(Console.ReadLine());

                     if (guess > prediction)
                     {
                         Console.WriteLine("SORRY! Try with lesser number  Next time");
                     }
                     else if (guess < prediction)
                     {
                         Console.WriteLine(" Sorry! Try with a relatively bigger number next time");
                     }
                     else if (guess == prediction)
                     {
                         Console.WriteLine(" Congratulations! You have made a correct guess");
                         guessOn = false;
                     }
                     Console.WriteLine("Enter N to Continue and Y To Exit The Game");
                     string response = (Console.ReadLine());

                     if (response == "N")
                     {
                         playOn = true;
                     }

                     else
                     {
                         playOn = false; 
                     }

                 }   */


            //question no: 2
            /* Write an app that simulates coin tossing.Let the app toss a coin each time
               the user chooses the “Toss Coin” menu option. Count the number of times each side of the coin
               appears.Display the results.The app should call a separate method Flip that takes no arguments
               and returns false for tails and true for heads.   */

            /* bool playOn = true;
             while (playOn)
             {
                 Random random = new Random();
                 int prediction = random.Next(1, 1000);
                 Console.WriteLine(prediction);

                 bool guessOn = true; 
                    while (guessOn)
                    {

                    }

             }   */


            //question no: 3
            /* Write method QualityPoints that inputs
               a student’s average and returns 4 if the student's average is 90–100, 3 if the average is 80–89,
               2 if the average is 70–79, 1 if the average is 60–69 and 0 if the average is lower than 60.     */

            /*   Console.Write("method quality point that calculate the student average:\n ");
               Console.Write("prompt the user to enter the student average score: ");
               int averageScore = int.Parse(Console.ReadLine());

               if (averageScore > 90 || averageScore == 100)
               {
                   Console.Write("4");
               }
               else if (averageScore > 80 || averageScore == 89)
               {
                   Console.Write("3");
               }
               else if (averageScore > 70 || averageScore == 79)
               {
                   Console.Write("2");
               }
               else if (averageScore > 60 || averageScore == 69)
               {
                   Console.Write("1");
               }
               else 
               {
                   Console.Write("0");
               }
               Console.ReadLine();    */


            //question no : 4
            /*  The greatest common divisor(GCD) of two integers is the largest
                integer that evenly divides each of the two numbers.Write method Gcd that returns the greatest
                common divisor of two integers    */

            /*  Console.Write("prompt the user to enter two integers: \n");
              Console.Write("enter the firstInteger: ");
              int firstInteger = Convert.ToInt32(Console.ReadLine());
              Console.Write("enter the secondInteger: ");
              int secondInteger = Convert.ToInt32(Console.ReadLine());
              int highest = 0;
              int result = Math.Min(firstInteger, secondInteger);
              for (int i = 1; i<=result; i++)
              {
                  if (firstInteger % i == 0 && secondInteger % i == 0 )
                  {                  
                     if (i > highest)
                     {
                      highest = i;
                     }
                  }

              }
              Console.WriteLine($"the greatest common divisor of the two integer is: {highest}");
              Console.ReadKey();    */


            // question no: 5
            /*   Write method Distance to calculate the distance between
                 two points(x1, y1) and(x2, y2).All numbers and return values should be of type double.

          /*   Console.WriteLine("to find the distance between two points. ");
             Console.Write("try and enter the first number: ");
             double x1 = double.Parse(Console.ReadLine());
             Console.Write("try and enter the second number: ");
             double y1 = double.Parse(Console.ReadLine());
             Console.Write("try and enter the third number: ");
             double x2 = double.Parse(Console.ReadLine());
             Console.Write("try and enter the fourth number: ");
             double y2 = double.Parse(Console.ReadLine());

             double distance = Math.Sqrt(x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) * 1.0;

             Console.WriteLine($"the distance between two points X1 - Y1, X2 - Y2 is ? {distance} ");
             Console.ReadLine();    */


            //question no : 6
            /* (Find future dates) Write a program that prompts the user to enter an integer for
                today’s day of the week(Sunday is 0, Monday is 1, . . ., and Saturday is 6).Also
                prompt the user to enter the number of days after today for a future day and display
                the future day of the week.

             /*   Console.WriteLine("enter today's date: ");
                 double dayNum = Convert.ToDouble(Console.ReadLine());
                 int futureDate = 0;
                 double A = 1;
               while(A <= 6)
               {
                   switch(A <= 6)
                   {
                       case 0:
                           Console.WriteLine("sunday");
                           break;
                       case 1:
                           Console.WriteLine("monday");
                           break;
                       case 2:
                           Console.WriteLine("tuesday");
                           break;
                       case 3:
                           Console.WriteLine("wednesday");
                           break;
                       case 4:
                           Console.WriteLine("thursday");
                           break;
                       case 5:
                           Console.WriteLine("friday");
                           break;
                       case 6:
                           Console.WriteLine("friday");
                           break;
                       default:
                           Console.WriteLine("invalid day number");
                           break;
                   }
                   A++;
               }     */



            //question no : 7
            /*  (Sort three integers) Write a program that sorts three integers.The integers are
                entered from the input dialogs and stored in variables num1, num2, and num3,
                espectively.The program sorts the numbers so that num1 <= num2 <= num3.   */

            /* Console.Write("enter the first integers and store it in a variables. ");
               double num1 = Convert.ToDouble(Console.ReadLine());

               Console.Write("enter the second integers and store it in a variables.  ");
               double num2 = Convert.ToDouble(Console.ReadLine());

               Console.Write("enter the third integers and store it in a variables. ");
               double num3 = Convert.ToDouble(Console.ReadLine());

               if (num1 > num2)
               {
                 num1 = num1 + num2;
                 num2 = num1 - num2;
                 num1 = num1 - num2;
               }
               if(num1 > num3)
               {
                 num1 = num1 + num3;
                 num3 = num1 - num3;
                 num1 = num1 - num3;
               }  
               if (num2 < num1)
               {
                 num2 = num2 + num1;
                 num1 = num2 - num1;
                 num2 = num2 - num1;
               }
               if (num2 > num3)
               {
                 num2 = num2 + num3;
                 num3 = num2 - num3;
                 num2 = num2 - num3;
               }
               if (num3 < num1)
               {
                 num3 = num3 + num1;
                 num1 = num3 - num1;
                 num3 = num3 - num1;
               }
               if(num3 < num2)
               {
                 num3 = num3 + num2;
                 num3 = num3 - num2;
                 num3 = num3 - num2;
               }

             Console.WriteLine($"{num1} <= {num2} <= {num3}");

             Console.ReadKey();  */


            //question no: 8
            /*    Write a program that lets the user guess whether the flip of
                  a coin results in heads or tails.The program randomly generates an integer 0 or 1,
                  which represents head or tail.The program prompts the user to enter a guess and
                  reports whether the guess is correct or incorrect.   */

            /*  Console.WriteLine("prompt the user to toss a coin between: 0 and 50 \n  do you want to playOn? yes/no  ");
              string answer = Console.ReadLine();

              while (answer == "yes")
              {
                  Random random = new Random();
                  int flip = random.Next(0, 50);

                  Console.WriteLine(flip);

                  Console.Write("prompt the user to toss a coin: ");
                  int guess = int.Parse(Console.ReadLine());

                  if (guess == flip)
                  {
                      Console.WriteLine("your guess is correct.");
                  }
                  else
                  {
                      Console.WriteLine("your guess is incorrect.");
                  }
                  Console.WriteLine("do you want to stop the game and exit? if answer is exit, your game has to exit ");
                  string ans = Console.ReadLine();
                  if(ans == "exit")
                  {
                      break;
                  }
              }    */


            //question no: 9
            /*  (Compute the perimeter of a triangle) Write a program that reads three edges for a
                triangle and computes the perimeter if the input is valid. Otherwise, display that
                the input is invalid. The input is valid if the sum of every pair of two edges is
                greater than the remaining edge.    */

            /*  Console.WriteLine("compute the perimeter of a triangle: ");
              Console.Write("enter the first egde of your triangle: ");
              int firstEgde = int.Parse(Console.ReadLine());
              Console.Write("enter the second egde of your triangle: ");
              int secondegde = int.Parse(Console.ReadLine());
              Console.Write("enter the third egde of your triangle: ");
              int thirdegde = int.Parse(Console.ReadLine());

              int sum1 = firstEgde + secondegde;
              int sum2 = secondegde + thirdegde;
              int sum3 = thirdegde + firstEgde;

              if (sum1 > thirdegde && sum2 > firstEgde && sum3 > secondegde) 
              {
                  Console.WriteLine("The perimeter is valid");

              }


              else
              {
                  Console.WriteLine("The perimeter is invalid");

              }   */


            //question no : 10
            /*  (Financial application: compound value) Suppose you save $100 each month
                rate is After the first month, the value in the account becomes
                100 * (1 + 0.00417) = 100.417
                After the second month, the value in the account becomes
               (100 + 100.417) * (1 + 0.00417) = 201.252
               After the third month, the value in the account becomes
               (100 + 201.252) * (1 + 0.00417) = 302.507
               and so on.
               Write a program that prompts the user to enter a monthly saving amount and displays
               the account value after the sixth month. (In Exercise 4.30, you will use a
               loop to simplify the code and display the account value for any month.)    */

            /*   Console.Write("prompt the user to enter the monthly savings. ");
               double monthlySavings = Convert.ToDouble(Console.ReadLine());
               double monthlyReturn = 0;
             for (int a = 0; a <= 6; a++)
             {
                monthlySavings = (monthlyReturn + monthlySavings) + (1 + 0.417);
                Console.WriteLine($"{monthlyReturn}");
             }
             Console.ReadLine();  */


            //question no: 11
            /* Write a program that prompts the user to enter
               the exchange rate from currency in U.S.dollars to Chinese RMB.Prompt the user
               to enter 0 to convert from U.S.dollars to Chinese RMB and 1 to convert from
               Chinese RMB and U.S.dollars.Prompt the user to enter the amount in U.S.dollars
               or Chinese RMB to convert it to Chinese RMB or U.S.dollars, respectively   */

            /*    Console.WriteLine("program to convert");
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

            //question no : 12
            /* Write a program that generates two integers under 100
               and prompts the user to enter the sum of these two integers. The program then
               reports true if the answer is correct, false otherwise.   */

            /* Random sum1 = new Random();
             int random = sum1.Next(0, 100);

             Random sum2 = new Random();
             int random2 = sum2.Next(0, 100);
             Console.Write("what is the sum of this integers ? ");
             Console.WriteLine($"the sum two imtegers is {random} + {random2}");

               int  secondInteger = int.Parse(Console.ReadLine());

               int Total = random + random2;

             if (secondInteger == Total)
             {
                 Console.WriteLine("your answer is correct.");
             }
             else
             {
                 Console.WriteLine("your answer is incorrect.");
             }  */


            //question no : 13
            /* (Financial application: calculate interest) If you know the balance and the annual
               percentage interest rate, you can compute the interest on the next monthly payment
               Write a program that reads the balance and the annual percentage interest rate and
               displays the interest for the next month    */

            /*   Console.Write("enter the balance and interest rate ");
                 double balance = Convert.ToDouble(Console.ReadLine());
                 Console.Write("enter the annual percentage interest rate ");
                 double annualInterestRate = Convert.ToDouble(Console.ReadLine());

              double INTEREST = 1;
              INTEREST = balance * (annualInterestRate / 1200);

              INTEREST = INTEREST * 2;
                 Console.WriteLine($"the interestRate for the next month is: {INTEREST}");
                 Console.ReadLine();  */



            //question no: 14
            /*  (Financial application: calculate future investment value) Write a program that
               reads in investment amount, annual interest rate, and number of years, and displays
                the future investment value using the following formula:   
                futureInvestmentValue = investmentAmount x(1 + monthlyInterestRate) ^ numberOfYears * 12   */

            /*    Console.Write("prompt the user to calculate the future investment value ");
             Console.Write("enter the investment amount. ");
             double investmentAmount = double.Parse(Console.ReadLine());
             Console.Write("enter the annualInterestRate. ");
             double annualInterestRate = double.Parse(Console.ReadLine());
             Console.Write("enter the number of years. ");
             int numberOfYears = int.Parse(Console.ReadLine());
             Console.Write("enter the monthlyInterestRate. ");
             int monthlyInterestRate = int.Parse(Console.ReadLine());

             double futureInvestmentRate = 0;
             futureInvestmentRate = investmentAmount * (1 + annualInterestRate) * numberOfYears * 12 *(1 + annualInterestRate);
             Console.WriteLine($"the future investment value is equal to. {futureInvestmentRate} ");
             Console.ReadLine();  */



            //QUESTION NO: 15 
            /*  Write a program that prompts the user to enter the
                minutes(e.g., 1 billion), and displays the number of years and days for the
                minutes.For simplicity, assume a year has 365 days.    */

            /*    Console.Write("prompt the user to enter the minutes: ");
                 double minutes = Convert.ToDouble(Console.ReadLine());

                 double years = Math.Round(minutes / 525600 );
                 double days = Math.Round(minutes % 525600) / 1440;
                 Console.WriteLine($"The {minutes} minutes is  equivalent to {years} years and {days} days.");
                 Console.ReadKey();    */


            //QUESTION NO : 16
            /* (Enforcing Privacy with Cryptography) The explosive growth of Internet communications
               and data storage on Internet - connected computers has greatly increased privacy concerns. The field
               of cryptography is concerned with coding data to make it difficult(and hopefully—with the most
               advanced schemes—impossible) for unauthorized users to read.In this exercise you’ll investigate a
               simple scheme for encrypting and decrypting data.A company that wants to send data over the Internet
               has asked you to write a program that will encrypt it so that it may be transmitted more securely.
               All the data is transmitted as four - digit integers.Your app should read a four - digit integer
               the third, and swap the second digit with the fourth.Then display the encrypted integer.Write a
               separate app that inputs an encrypted four - digit integer and decrypts it(by reversing the encryption
               scheme) to form the original number.   */

            /*   Console.Write("enforcing privacy with cryptography\n");
               Console.Write("enter your firstNumber; ");
               int firstNumber = int.Parse(Console.ReadLine());
               Console.Write("enter your secondNumber: ");
               int secondNumber = int.Parse(Console.ReadLine());
               Console.Write("enter your thirdNumber: ");
               int thirdNumber = int.Parse(Console.ReadLine());
               Console.Write("enter your fourthNumber: ");
               int fourthNumber = int.Parse(Console.ReadLine());

             int sum1 = firstNumber + 7;
             int sum2 = secondNumber + 7;
             int sum3 = thirdNumber + 7;
             int sum4 = fourthNumber + 7;

             int remainder1 = sum1 / 10;
             int remainder2 = sum2 / 10;
             int remainder3 = sum3 / 10;
             int remainder4 = sum4 / 10;

             int firstNumber1 = sum1 % 10;
             int secondNumber2 = sum2 % 10;
             int thirdNumber3 = sum3 % 10;
             int fourthNumber4 = sum4 % 10;

             firstNumber1 = firstNumber1 + thirdNumber3;
             thirdNumber3 = firstNumber1 - thirdNumber3;
             firstNumber1 = firstNumber1 - thirdNumber3;

             Console.WriteLine($"the encryption of the  integer are: {firstNumber1} {secondNumber2} {thirdNumber3} {fourthNumber4} ");

             firstNumber1 = firstNumber1 + thirdNumber3;
             thirdNumber3 = firstNumber1 - thirdNumber3;
             firstNumber1 = firstNumber1 - thirdNumber3;

             int answer1 = remainder1 * 10;
             int answer2 = remainder2 * 10;
             int answer3 = remainder3 * 10;
             int answer4 = remainder4 * 10;

             int check1 = answer1 + firstNumber1;
             int check2 = answer2 + secondNumber2;
             int check3 = answer3 + thirdNumber3;
             int check4 = answer4 + fourthNumber4;

             int finalAnswer1 = check1 - 7;
             int finalAnswer2 = check2 - 7;
             int finalAnswer3 = check3 - 7;
             int finalAnswer4 = check4 - 7;

             Consolqe.WriteLine($"the decryption of the integers are: {finalAnswer1} {finalAnswer2} {finalAnswer3} {finalAnswer4}");

             Console.ReadKey();    */

            //QUESTION  NO: 17
            /*    (World Population Growth) World population has grown considerably over the centuries.
                Continued growth could eventually challenge the limits of breathable air, drinkable water, arable
                cropland and other limited resources. There’s evidence that growth has been slowing in recent years
                and that world population could peak some time this century, then start to decline.
                For this exercise, research world population growth issues online. Be sure to investigate various
                viewpoints.Get estimates for the current world population and its growth rate(the percentage by
                which it is likely to increase this year).Write a program that calculates world population growth
                each year for the next 75 years, using the simplifying assumption that the current growth rate will stay
                constant.When displaying the results, the first column should display the year from year 1 to year
                75.The second column should display the anticipated world population at the end of that year.
                The third column should display the numerical increase in the world population that would occur
                that year. Using your results, determine the year in which the population would be double what it is
                today, if this year’s growth rate were to persist. [Hint: Use double variables because int variables can
                 store values only up to approximately two billion.]   */

            /* Console.WriteLine("a program that calculates world population growth each year for the next 75 years");
             double anticipatedWorldPopulation = 1000;
             int currentWorldPopulation = 0;
             double worldPopulation = 5000 * 2;
             for (int i =1; i <= 75; i++)
             {
               double populationGrowth = anticipatedWorldPopulation + 1000 * i; 


                 double currentGrowthRate = (10 * populationGrowth) + populationGrowth;
                 Console.WriteLine($" Year:  {i}   anticipatedYear:  {populationGrowth}   numerical increase in the world population:  {currentGrowthRate}");
                 if (worldPopulation == populationGrowth)
                 {
                     currentWorldPopulation = i;
                 }
             }
             Console.WriteLine($" world population is:    {currentWorldPopulation}th year.");
             Console.ReadKey();   */


            //question no: 18
            /* (Global Warming Facts Quiz) The controversial issue of global warming has been widely
                publicized by the film An Inconvenient Truth, featuring former Vice President Al Gore.Mr.Gore
                and a U.N.network of scientists, the Intergovernmental Panel on Climate Change, shared the 2007
                Nobel Peace Prize in recognition of “their efforts to build up and disseminate greater knowledge
                about man - made climate change.” Research both sides of the global warming issue online(you
                might want to search for phrases like “global warming skeptics”).Create a five-question multiplechoice
                quiz on global warming, each question having four possible answers(numbered 1–4). Be objective
                and try to fairly represent both sides of the issue. Next, write an app that administers the quiz,
                calculates the number of correct answers(zero through five) and returns a message to the user.If the
                user correctly answers five questions, display “Excellent”; if four, display “Very good”; if three or
                fewer, display “Time to brush up on your knowledge of global warming,” and include a list of some
                of the websites where you found your facts.  */






 












        }
    }
}
