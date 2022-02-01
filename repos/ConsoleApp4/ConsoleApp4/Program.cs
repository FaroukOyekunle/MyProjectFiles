using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Pig myPig = new Pig(); // Create a Pig object
                myPig.animalSound();  // Call the abstract method
                myPig.sleep();  // Call the regular method

            /*  Console.WriteLine("Hellhbjhihiio,ouojoj,uupouoyiyiyyiihhhbjo World!");
              Console.ReadLine();*/
            Score score = new Score()
          {
              Name
          };
        }
    }
    // private abstract class Animal
    // {
    //  public string Name { get; private set; }


    //
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    
    class Score
    {
        public string Name { get; set; }
        public int Mark { get; set; }
    }
    
    
        
    
}
