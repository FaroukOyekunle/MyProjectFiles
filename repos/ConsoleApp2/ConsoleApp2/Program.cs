using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  int[] evenMunber = new int[6] { 1, 2, 4, 5, 6, 8 };
              int[] oddNumber = new int[5] { 3, 5, 7, 9, 11 };

              Console.WriteLine($"first element (evenNum) = {evenMunber[0]}");
              Console.WriteLine($"first element (oddNum) = {oddNumber[0]}");
              Console.WriteLine($"");
  */
            var score = new Score
            {
                Name = "morayo",
                Mark = 50 * 4
            };

        }
    }
    class Score
    {
        public string Name { get; set; }

        public int Mark { get; set; }
    }
    
}
