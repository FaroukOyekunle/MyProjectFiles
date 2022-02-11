using System;

namespace FCPA_CHAPTER_6_NO_3
{
    class Program
    {
        static void Main(string[] args)
        {


            // Write a program that reads from the console a series of integers and
            //prints the smallest and largest of them

            int smallest = 0;
            int highest = 0;
            int output;

            Console.Write("enter your preferred integer: ");
            int firstInteger = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < firstInteger; i++)
            {
                Console.Write("enter your integer: ");
                output = Int32.Parse(Console.ReadLine());

                if(i == 0)
                {
                    smallest = highest = output;
                }
                else
                {
                    if(smallest > output)
                    {
                        smallest = output;
                    }
                    if(highest < output)
                    {
                        highest = output ; 
                    }
                }
            }
            Console.WriteLine("the smallest integer among all is:  {0}, the highest integer among all is:   {1}", smallest, highest);

            Console.ReadLine();
        }
    }
}
