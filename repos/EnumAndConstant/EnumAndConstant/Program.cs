using System;

namespace EnumAndConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] People = new Person[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter your preferred Name: ");
                var Name = Console.ReadLine();
                Console.Write("Enter your marital status:(press 1| for single, press 2| for married, press 3| for divorced, press 4| for single & searching: ) ");
                int status = int.Parse(Console.ReadLine());

              //  Person person1 = new Person(Name, (MaritalStatus)status);

                People[i] = new Person(Name, (MaritalStatus)status);

            }
            foreach(var item in People)
            {
                if(item.Status == MaritalStatus.single)
                {
                    Console.WriteLine($"{item.Name} is single. ");
                }
            }
        }
    }

    public class Person(string name; )
    {
        public string Name { get; set; }

    public MaritalStatus Status { get; }

    }



    public enum MaritalStatus
    {
         single,
        married,
        divorced,
    }
}
