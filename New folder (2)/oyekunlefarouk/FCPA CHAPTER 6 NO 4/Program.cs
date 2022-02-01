using System;

namespace FCPA_CHAPTER_6_NO_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that prints all possible cards from a standard deck
             //of cards, without jokers(there are 52 cards: 4 suits of 13 cards).

            for (int p = 0; p < 4; p++)
            {
                if(p != 0)
                {
                    Console.WriteLine();
                }
                for(int q = 0; q < 13; q++)
                {
                    switch(p)
                    {
                        case 0:
                            Console.Write(" club ");
                            break;
                        case 1:
                            Console.Write(" diamond ");
                            break;
                        case 2:
                            Console.Write(" heart ");
                            break;
                        case 3:
                            Console.Write(" spades");
                            break;
                        default:
                            Console.Write("invalid input.");
                            break;
                    }
                    switch(q)
                    {
                        case 0:
                            Console.WriteLine("2");
                            break;
                        case 1:
                            Console.WriteLine("3");
                            break;
                        case 2:
                            Console.WriteLine("4");
                            break;
                        case 3:
                            Console.WriteLine("5");
                            break;
                        case 4:
                            Console.WriteLine("6");
                            break;
                        case 5:
                            Console.WriteLine("7");
                            break;
                        case 6:
                            Console.WriteLine("8");
                            break;
                        case 7:
                            Console.WriteLine("9");
                            break;
                        case 8:
                            Console.WriteLine("10");
                            break;
                        case 9:
                            Console.WriteLine("J");
                            break;
                        case 10:
                            Console.WriteLine("Q");
                            break;
                        case 11:
                            Console.WriteLine("K");
                            break;
                        case 12:
                            Console.WriteLine("A");
                            break;

                    }
                }
            }



            Console.ReadLine();
































        }
    }
}
