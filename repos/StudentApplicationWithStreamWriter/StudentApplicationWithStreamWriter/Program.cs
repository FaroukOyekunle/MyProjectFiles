using System;

namespace StudentApplicationWithStreamWriter
{

    class Program
    {
        delegate void PrintMenuDelegate();
        static StudentManagerPortal studentManagerPortal = new StudentManagerPortal();
        static void Main(string[] args)
        {
            Console.WriteLine("We Welcome you to (Losted Zahfia app)!" +
                "Here is the list of the required menu for registration.");
            Run();
        }

        static void Run()
        {
            bool flag;
            PrintMenuDelegate printMenu = new(PrintMenu);
            do
            {
                PrintMenu();
                var option = HandleSelections(Console.ReadLine(), printMenu);
                flag = HandleMenuOption(option);
            }
            while (flag);
            Console.WriteLine("Thanks for choosing (Losted Zahfia app) for your registration portal, " +
                "Do have a nice day. ");
        }


        static void PrintMenu()
        {
            Console.WriteLine("Press 1: To make a Registration for an aspirant.");
            Console.WriteLine("Press 2: To Update a student Record. ");
            Console.WriteLine("Press 3: To List All Students. ");
            Console.WriteLine("Press 4: To Remove a left student. ");
            Console.WriteLine("Press 0: to end the Application. ");
        }

        static bool HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1:
                    studentManagerPortal.CreateOrMakeARegistrationForEachStudent();
                    return true;
                case 2:
                    studentManagerPortal.UpdateStudentDetails();
                    return true;
                case 3:
                    studentManagerPortal.ListOfAllStudentDetails();
                    return true;
                case 4:
                    studentManagerPortal.RemoveStudent();
                    return true;
                case 0:
                    return false;
                default:
                    return false;
            }
        }

        static int HandleSelections(string selcetion, PrintMenuDelegate printMenu)
        {
            bool result = int.TryParse(selcetion, out int action);
            while (result == false)
            {
                Console.WriteLine("Try again!");
                printMenu();
                result = int.TryParse(Console.ReadLine(), out action);
            }
            return action;
        }
    }
}
