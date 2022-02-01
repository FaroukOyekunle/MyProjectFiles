using System;

namespace OOPCLASS
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating instances (objects) of the class Animal.
            Animal Dog = new Animal();
            Animal Cat = new Animal();
            Animal Lion = new Animal();


            //Accessing the properties of the class Animal through the object.

            Dog.Name = "Trent";
            Dog.NumberOfLegs = 4;
            Dog.colour = "black";

            string AnimalSound = "Bark";
            Console.WriteLine(Dog.Sounds(AnimalSound));
        }
    }
    class Animal
    {
        public string Name;
        public string Name1 = "Dog";
        public int NumberOfLegs;
        public int NumberOfLegs1 = 4;
        public string colour;
        public string colour1 = "white";


        public string Sounds(string animalSound)
        {
            return animalSound;
        }

    }
}
