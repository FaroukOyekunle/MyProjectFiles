using System;

namespace ASSESSMENT_ON_METHOD_NO_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a method that calculates the sum of two polynomials with integer
            //coefficients, for example(3x2 + x - 3) + (x - 1) = (3x2 + 2x - 4).

            Console.WriteLine("Enter your Co-oefficient for x^0");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Co-oefficient for x^1");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Co-oefficient for x^2");
            int thirdNumber = int.Parse(Console.ReadLine());

            int[] firstNumber1 = { firstNumber, secondNumber, thirdNumber };
            int[] secondNumber2 = { secondNumber, -1 };

            SumOfTwoPolynomial(firstNumber1, secondNumber2);
        }
        static void SumOfTwoPolynomial(int [] firstNumber1, int [] secondNumber2)
        {
            int sum1 = 0;
            int sum2 = 0;
            int x = 0;
            int thirdNumber = firstNumber1[2];
            for(int i = 0; i < secondNumber2.Length; i++)
            {
                if(i == 0)
                {
                    sum1 = firstNumber1[x] + secondNumber2[1];
                }
                else
                {
                    sum2 = firstNumber1[x] + secondNumber2[0];
                }
                x++;
            }

            if(sum2 < 0 && sum1 < 0)
            {
                Console.WriteLine($"The result is ({thirdNumber}x^2  {sum2}x  {sum1}) ");
            }
            if(sum2 > 0 && sum1 > 0)
            {
                Console.WriteLine($"the result is ({thirdNumber}x^2 +{sum2}x  +{sum1}) ");
            }
            if(sum2 > 0 && sum1 < 0)
            {
                Console.WriteLine($"The result is ({thirdNumber}x^2 +{sum2}x {sum1}) ");
            }
            if(sum2 < 0 && sum1 > 0)
            {
                Console.WriteLine($"The result of adding ({thirdNumber}x^2 {sum2}x +{sum1}) ");
            }
        }
    }
}
