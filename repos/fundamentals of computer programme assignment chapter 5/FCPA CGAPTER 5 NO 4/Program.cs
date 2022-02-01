using System;

namespace FCPA_CGAPTER_5_NO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort 3 real numbers in descending order. Use nested if statements.
            Console.Write("enter your first real number: ");
            int firstRealNumber = int.Parse(Console.ReadLine());
            Console.Write("enter you second real number: ");
            int secondRealNumber = int.Parse(Console.ReadLine());
            Console.Write("enter your third real number: ");
            int thirdRealNumber = int.Parse(Console.ReadLine());

            if (firstRealNumber > 0)
            {
                if (firstRealNumber < thirdRealNumber)
                {
                    firstRealNumber = firstRealNumber + thirdRealNumber;
                    thirdRealNumber = firstRealNumber - thirdRealNumber;
                    firstRealNumber = firstRealNumber - thirdRealNumber;

                    if (secondRealNumber > thirdRealNumber)
                    {
                        firstRealNumber = firstRealNumber + secondRealNumber;
                        secondRealNumber = firstRealNumber - secondRealNumber;
                        firstRealNumber = firstRealNumber - secondRealNumber;
                    }

                    else if (firstRealNumber >= thirdRealNumber)
                    {
                        firstRealNumber = firstRealNumber + secondRealNumber;
                        secondRealNumber = firstRealNumber - secondRealNumber;
                        firstRealNumber = firstRealNumber + secondRealNumber;
                    }
                    else if (firstRealNumber == secondRealNumber)
                    {
                        if(firstRealNumber < thirdRealNumber)
                        {
                            firstRealNumber = firstRealNumber + thirdRealNumber;
                            thirdRealNumber = firstRealNumber - thirdRealNumber;
                            firstRealNumber = firstRealNumber - thirdRealNumber;
                        }
                        if (secondRealNumber < thirdRealNumber)
                        secondRealNumber = secondRealNumber + thirdRealNumber;
                        thirdRealNumber = secondRealNumber - thirdRealNumber;
                         secondRealNumber = secondRealNumber - thirdRealNumber;   
                    }
                    if(firstRealNumber < secondRealNumber)
                    {
                        firstRealNumber = firstRealNumber + secondRealNumber;
                        secondRealNumber = firstRealNumber - secondRealNumber;
                        firstRealNumber = firstRealNumber - secondRealNumber;
                    }
                    
                }
                Console.WriteLine("{0} {1} {2}", firstRealNumber, secondRealNumber,thirdRealNumber);
                Console.ReadLine();
            }
        }
    }
}
