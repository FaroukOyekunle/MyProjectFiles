using System;

namespace FCPA_CHAPTER_5_NO_11
{
    class Program
    {
        static void Main(string[] args)
        {


            // Write a program that converts a number in the range[0…999] to
            //words, corresponding to the English pronunciation. Examples:
            // -0-- > "Zero"
            //  - 12-- > "Twelve"
            // - 98-- > "Ninety eight"
            //  - 273-- > "Two hundred seventy three"
            // - 400-- > "Four hundred"
            //  - 501-- > "Five hundred and one"
            //  - 711-- > "Seven hundred and eleven"


            Console.Write("Enter a number between 0 and 999: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());

            int hundreds = (int)(yourNumber / 100 );
            int tensAndUnits;

            if (yourNumber > 99)
            {
                tensAndUnits= (int)(yourNumber % 100);
            }
           
            else
            {
                tensAndUnits= (int)(yourNumber * 10);
            }

            int units = (int)(yourNumber % 10);
            switch(hundreds)
            {
                  case 1:  
                        Console.Write("one hundred ");
                   break;
                case 2:
                    Console.Write("two hundred ");
                    break;
                case 3:
                    Console.Write("three hundred ");
                    break;
                case 4:
                    Console.Write("four hundred ");
                    break;
                case 5:
                    Console.Write("five hundred ");
                    break;
                case 6:
                    Console.Write("six hundred ");
                    break;
                case 7:
                    Console.Write("seven hundred ");
                    break;
                case 8:
                    Console.Write("eight hundred ");
                    break;
                case 9:
                    Console.Write("nine hundred ");
                    break;
            }
            
            if(hundreds >= 1 && tensAndUnits >= 1)
            {
                Console.Write(" and ");
            }
            if(tensAndUnits >= 20 && tensAndUnits < 30)
            {
                Console.Write(" twenty ");
            }
            else if(tensAndUnits >= 30 && tensAndUnits < 40)
            {
                Console.Write(" thirty ");
            }
            else if (tensAndUnits >= 40 && tensAndUnits < 50)
            {
                Console.Write("forty ");
            }
            else if (tensAndUnits >= 50 && tensAndUnits < 60)
            {
                Console.Write(" fifty ");
            }
            else if(tensAndUnits >= 60 && tensAndUnits < 70)
            {
                Console.Write(" sixty");
            }
            else if(tensAndUnits >= 70 && tensAndUnits < 80)
            {
                Console.Write(" seventy ");
            }
            else if(tensAndUnits >= 80 && tensAndUnits < 90)
            {
                Console.Write(" eighty ");
            }
            else if(tensAndUnits >= 90 && tensAndUnits < 100)
            {
                Console.Write(" ninety ");
            }


            switch(tensAndUnits )
            {
                case 1:
                    Console.Write(" one ");
                    break;
                case 2:
                    Console.Write(" two ");
                    break;
                case 3:
                    Console.Write(" three ");
                    break;
                case 4:
                    Console.Write(" four ");
                    break;
                case 5:
                       Console.Write(" five ");
                    break;
                case 6:
                    Console.Write(" six ");
                    break;
                case 7:
                    Console.Write(" seven ");
                    break;
                case 8:
                    Console.Write(" eight ");
                    break;
                case 9:
                    Console.Write(" nine ");
                    break;
                case 10:
                    Console.Write(" ten ");
                    break;
                case 11:
                    Console.Write(" eleven ");
                    break;
                case 12:
                    Console.Write(" twelve ");
                    break;
                case 13:
                    Console.Write(" thirteen ");
                    break;
                case 14:
                    Console.Write(" fourteen ");
                    break;
                case 15:
                    Console.Write(" fifteen ");
                    break;
                case 16:
                    Console.Write(" sixteen ");
                    break;
                case 17:
                    Console.Write(" seventeen ");
                    break;
                case 18:
                    Console.Write(" eighteen ");
                    break;
                case 19:
                    Console.Write(" nineteen ");
                    break;
            }

            if(tensAndUnits > 20)
            {
                switch(units)
                {
                    case 1:
                        Console.Write(" one ");
                        break;
                    case 2:
                        Console.Write(" two ");
                        break;
                    case 3:
                        Console.Write(" three ");
                        break;
                    case 4:
                        Console.Write(" four ");
                        break;
                    case 5:
                        Console.Write(" five ");
                        break;
                    case 6:
                        Console.Write(" six ");
                        break;
                    case 7:
                        Console.Write(" seven ");
                        break;
                    case 8:
                        Console.Write(" eight ");
                        break;
                    case 9:
                        Console.Write(" nine ");
                        break;
                }
            }
            if(yourNumber == 0)
            {
                Console.Write(" zero ");
            }




        }
    }
}
