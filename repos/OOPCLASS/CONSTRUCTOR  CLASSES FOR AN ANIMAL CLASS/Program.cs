using System;

namespace CONSTRUCTOR__CLASSES_FOR_AN_ANIMAL_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Dog dog1 = new("trent", 66, "male");
            Cat cat1 = new("arnold", 27, "female");
            TomCat tomCat1 = new("jadon", 18, "male");
            Frog frog1 = new("milik", 21, "female");
            Kitten kitten1 = new("hamsik", 29, "male");

            class_animal_oop[] class_Animal_Oops = { dog1, cat1, tomCat1, frog1, kitten1 };
            foreach(var item in class_Animal_Oops)
            {
                Console.WriteLine(item.PrintDetails());
            }



        }
    }
}
