using System;

namespace Dries.Mertens66
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "oyekunle qawiyah";
            Console.WriteLine(phrase.Substring(phrase.IndexOf("qawiyah"))  );

            Console.ReadLine();
        }
    }
}